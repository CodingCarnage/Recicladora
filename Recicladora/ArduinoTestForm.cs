using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recicladora
{
    public partial class ArduinoTestForm : Form
    {
        public ArduinoTestForm()
        {
            InitializeComponent();
            serialPort.PortName = "COM5";
            serialPort.Open();
        }

        private void ArduinoTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("Apagado");
                serialPort.Close();
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("Apagado");
            buttonApagar.Enabled = false;
            buttonEncender.Enabled = true;
            buttonParpadear.Enabled = true;
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("Abriendo");
            buttonEncender.Enabled = false;
            buttonApagar.Enabled = true;
            buttonParpadear.Enabled = true;
        }

        private void buttonParpadear_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("Cerrando");
            buttonParpadear.Enabled = false;
            buttonEncender.Enabled = true;
            buttonApagar.Enabled = true;
        }
    }
}
