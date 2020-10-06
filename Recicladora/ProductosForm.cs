using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Recicladora
{
    public partial class ProductosForm : Form
    {
        private string strNombreEmpleado = null;
        private string strSONESEmpleado = null;

        public ProductosForm(string strNombre, string strSONES)
        {
            InitializeComponent();
            strNombreEmpleado = strNombre;
            strSONESEmpleado = strSONES;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExcelProductos()
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"Excel\ProductosSIEN.xlsx"); // Localización del archivo Excel
            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbooks excelWorkbooks = excelApplication.Workbooks;
            Excel.Workbook excelWorkbook = excelWorkbooks.Open(path);
            Excel.Worksheet excelWorksheet = excelWorkbook.Sheets[1];
            Excel.Range excelRange = excelWorksheet.UsedRange;
            int rowCount = excelRange.Rows.Count;
            int columnCount = excelRange.Columns.Count;
            try
            {
                int index = -1;
                for (int i = 2; i <= rowCount; i++)
                {
                    for (int j = 1; j <= columnCount; j++)
                    {
                        if (j == 1)
                        {
                            Excel.Shape excelShape = excelWorksheet.Shapes.Item(i - 1);
                            excelShape.Copy();
                            if (Clipboard.ContainsImage())
                            {
                                index = dataGridViewProductos.Rows.Add();
                                Image image = Clipboard.GetImage();
                                dataGridViewProductos.Rows[index].Cells[0].Value = image;
                            }
                        }
                        else if (j == 2 && index != -1)
                        {
                            if (excelRange.Cells[i, j] != null)
                            {
                                dataGridViewProductos.Rows[index].Cells[1].Value = excelRange.Cells[i, j].Value2.ToString();
                            }
                        }
                        else if (j == 3 && index != -1)
                        {
                            if (excelRange.Cells[i, j] != null)
                            {
                                dataGridViewProductos.Rows[index].Cells[2].Value = excelRange.Cells[i, j].Value2.ToString();
                            }
                        }
                    }
                }
            }
            finally
            {
                // Cerrar y Limpiar el proceso del Excel
                GC.Collect();
                GC.WaitForPendingFinalizers();
                Marshal.ReleaseComObject(excelRange);
                Marshal.ReleaseComObject(excelWorksheet);
                excelWorkbook.Close();
                Marshal.ReleaseComObject(excelWorkbook);
                excelWorkbooks.Close();
                Marshal.ReleaseComObject(excelWorkbooks);
                excelApplication.Quit();
                Marshal.ReleaseComObject(excelApplication);
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            if (strNombreEmpleado != null && strSONESEmpleado != null)
            {
                labelTextNombre.Visible = true;
                labelNombre.Text = strNombreEmpleado;
                labelNombre.Visible = true;
                labelTextSONES.Visible = true;
                labelSONES.Text = strSONESEmpleado;
                labelSONES.Visible = true;
            }
            else
            {
                labelNombre.Visible = false;
                labelSONES.Visible = false;
                labelTextNombre.Visible = false;
                labelTextSONES.Visible = false;
            }
            ExcelProductos();
        }

        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewProductos.ClearSelection();
        }
    }
}
