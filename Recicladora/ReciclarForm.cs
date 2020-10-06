using System;
using System.Windows.Forms;

namespace Recicladora
{
    public partial class ReciclarForm : Form
    {
        int nRowPerson;

        public ReciclarForm(int nRenglonPersona)
        {
            InitializeComponent();
            nRowPerson = nRenglonPersona;
        }

        private void IniciarReciclajeForm_Load(object sender, EventArgs e)
        {
            serialPort.PortName = "COM5";
            try
            {
                serialPort.Open();
                serialPort.WriteLine("B");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void IniciarReciclajeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("A");
                serialPort.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonReciclar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("C");
                IniciarReciclajeForm validando = new IniciarReciclajeForm(serialPort, nRowPerson);
                validando.ShowDialog();
                if (validando.DialogResult == DialogResult.Cancel)
                {
                    serialPort.Write("B");
                }
            }
        }
    }
}
