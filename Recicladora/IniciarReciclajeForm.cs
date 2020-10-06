using System;
using System.IO.Ports;
using System.Windows.Forms;
using Global = Recicladora.Properties.Settings;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace Recicladora
{
    public partial class IniciarReciclajeForm : Form
    {
        SerialPort serialPort;
        int nRowPerson;

        public IniciarReciclajeForm(SerialPort serialPortArduino, int nRenglonPersona)
        {
            InitializeComponent();
            serialPort = serialPortArduino;
            nRowPerson = nRenglonPersona;
        }

        private void Validando_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Validando_Load(object sender, EventArgs e)
        {
            timerArduino.Start();
            buttonCamRechazo.Enabled = false;
        }

        private void buttonCamRechazo_Click(object sender, EventArgs e)
        {
            buttonCamRechazo.Enabled = false;
            buttonCamAceptar.Enabled = true;
            serialPort.Write("D");
        }

        private void buttonCamAceptar_Click(object sender, EventArgs e)
        {
            buttonCamAceptar.Enabled = false;
            buttonCamRechazo.Enabled = true;
            serialPort.Write("E");
        }

        private void timerArduino_Tick(object sender, EventArgs e)
        {
            string data = serialPort.ReadExisting();
            string result = data.Substring(data.Length - 4);
            timerArduino.Stop();
            if (result.Contains("0"))
            {
                MessageBox.Show("La lata NO es valida favor de retirarla o intentar de nuevo", "RECICLA-SON", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else if (result.Contains("1"))
            {
                MessageBox.Show("La lata SI es validad, gracias por utilizar el RECICLA-SON", "RECICLA-SON", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Global.Default.latasRecicladas += 1;
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    ExcelAumentarLatas();
                }).Start();      
                if (Global.Default.latasRecicladas == 5)
                {
                    MessageBox.Show("Comprimiendo", "RECICLA-SON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Global.Default.latasRecicladas = 0;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR favor de intentar de nuevo o retrirar la lata", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ExcelAumentarLatas()
        {
            // Declaración e inicialización de variables
            string path = Path.Combine(Environment.CurrentDirectory, @"Excel\ReciclaSON.xlsx"); // Localización del archivo Excel
            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbooks excelWorkbooks = excelApplication.Workbooks;
            Excel.Workbook excelWorkbook = excelWorkbooks.Open(path);
            Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            try
            {
                // Aumentar latas
                int latasActuales = (int)(excelWorksheet.Cells[nRowPerson, 7] as Excel.Range).Value2;
                (excelWorksheet.Cells[nRowPerson, 7] as Excel.Range).Value2 = latasActuales + 1;
                excelWorkbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar y Limpiar el proceso del Excel
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(excelWorksheet);
                excelWorkbook.Close();
                Marshal.ReleaseComObject(excelWorkbook);
                excelWorkbooks.Close();
                Marshal.ReleaseComObject(excelWorkbooks);
                excelApplication.Quit();
                Marshal.ReleaseComObject(excelApplication);
            }
        }
    }
}
