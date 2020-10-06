using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Recicladora
{
    public partial class MainForm : Form
    {
        string strNombre = null;
        string strSONES = null;
        int nRowPersona = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm(strNombre, strSONES);
            productosForm.ShowDialog();
            textBoxNumeroEmpleado.Focus();
        }

        private void textBoxNumeroEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Presionó enter en TextBox
            {
                if (string.IsNullOrWhiteSpace(textBoxNumeroEmpleado.Text)) // El TextBox esta vacío o son espacios en blanco
                {
                    MessageBox.Show("Favor de ingresar su número de empleado Nemak", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ExcelSearch(textBoxNumeroEmpleado.Text);
                }
            }
        }

        private void textBoxNumeroEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números en TextBox
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExcelSearch(string numeroEmpleado)
        {
            // Declaración e inicialización de variables
            string path = Path.Combine(Environment.CurrentDirectory, @"Excel\ReciclaSON.xlsx"); // Localización del archivo Excel
            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbooks excelWorkbooks = excelApplication.Workbooks;
            Excel.Workbook excelWorkbook = excelWorkbooks.Open(path);
            Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            Excel.Range excelRange = excelWorksheet.UsedRange;
            Excel.Range nominaRange = excelWorksheet.Columns["A:A"];
            try
            {
                // Busqueda
                var excelResult = nominaRange.Find(numeroEmpleado, LookAt: Excel.XlLookAt.xlWhole);
                if (excelResult == null)
                {
                    if (labelNombre.Visible == true)
                    {
                        strNombre = null;
                        strSONES = null;
                        labelNombre.Visible = false;
                        labelTextNombre.Visible = false;
                        labelTextSONES.Visible = false;
                        labelSONES.Visible = false;
                        labelTextLatasRecicladas.Visible = false;
                        labelLatasRecicladas.Visible = false;
                    }
                    MessageBox.Show("No se encontró un empleado con este número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNumeroEmpleado.Clear();
                }
                else
                {
                    var nombreResult = (excelWorksheet.Cells[excelResult.Row, 2] as Excel.Range).Value2;
                    var sonesResult = (excelWorksheet.Cells[excelResult.Row, 6] as Excel.Range).Value2;
                    int latasResult = (int)(excelWorksheet.Cells[excelResult.Row, 7] as Excel.Range).Value2;
                    nRowPersona = excelResult.Row;
                    labelTextNombre.Visible = true;
                    labelNombre.Text = Convert.ToString(nombreResult);
                    labelNombre.Visible = true;
                    labelTextSONES.Visible = true;
                    labelTextLatasRecicladas.Visible = true;
                    labelLatasRecicladas.Text = latasResult.ToString();
                    labelLatasRecicladas.Visible = true;
                    if (Convert.ToString(sonesResult) == "-2146826246")
                        labelSONES.Text = "0";
                    else
                        labelSONES.Text = Convert.ToString(sonesResult);
                    labelSONES.Visible = true;
                    strNombre = labelNombre.Text;
                    strSONES = labelSONES.Text;
                }
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
                Marshal.ReleaseComObject(excelRange);
                Marshal.ReleaseComObject(nominaRange);
                Marshal.ReleaseComObject(excelWorksheet);
                excelWorkbook.Close();
                Marshal.ReleaseComObject(excelWorkbook);
                excelWorkbooks.Close();
                Marshal.ReleaseComObject(excelWorkbooks);
                excelApplication.Quit();
                Marshal.ReleaseComObject(excelApplication);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNumeroEmpleado.Text))
            {
                textBoxNumeroEmpleado.Clear();
                if (labelNombre.Visible == true)
                {
                    strNombre = null;
                    strSONES = null;
                    labelNombre.Visible = false;
                    labelTextNombre.Visible = false;
                    labelSONES.Visible = false;
                    labelTextSONES.Visible = false;
                    labelTextLatasRecicladas.Visible = false;
                    labelLatasRecicladas.Visible = false;
                }
                textBoxNumeroEmpleado.Focus();
            }
            else
            {
                textBoxNumeroEmpleado.Focus();
            }
        }

        private void buttonReciclar_Click(object sender, EventArgs e)
        {
            if (labelNombre.Visible == true)
            {
                ReciclarForm iniciarReciclajeForm = new ReciclarForm(nRowPersona);
                if (iniciarReciclajeForm.ShowDialog() == DialogResult.Cancel)
                {
                    ActualizarLatas();
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar su número de empleado Nemak antes de iniciar el reciclaje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNumeroEmpleado.Focus();
            }
        }

        private void ActualizarLatas()
        {
            // Declaración e inicialización de variables
            string path = Path.Combine(Environment.CurrentDirectory, @"Excel\ReciclaSON.xlsx"); // Localización del archivo Excel
            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbooks excelWorkbooks = excelApplication.Workbooks;
            Excel.Workbook excelWorkbook = excelWorkbooks.Open(path);
            Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            try
            {
                int nLatas = (int)(excelWorksheet.Cells[nRowPersona, 7] as Excel.Range).Value2;
                labelLatasRecicladas.Text = nLatas.ToString();
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
