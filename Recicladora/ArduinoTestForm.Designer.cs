namespace Recicladora
{
    partial class ArduinoTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonParpadear = new System.Windows.Forms.Button();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(12, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(129, 51);
            this.buttonApagar.TabIndex = 0;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // buttonParpadear
            // 
            this.buttonParpadear.Location = new System.Drawing.Point(169, 12);
            this.buttonParpadear.Name = "buttonParpadear";
            this.buttonParpadear.Size = new System.Drawing.Size(129, 51);
            this.buttonParpadear.TabIndex = 1;
            this.buttonParpadear.Text = "Cerrar";
            this.buttonParpadear.UseVisualStyleBackColor = true;
            this.buttonParpadear.Click += new System.EventHandler(this.buttonParpadear_Click);
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(322, 12);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(129, 51);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Abrir";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // ArduinoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 78);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.buttonParpadear);
            this.Controls.Add(this.buttonApagar);
            this.Name = "ArduinoTest";
            this.Text = "ArduinoTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArduinoTest_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button buttonApagar;
        private System.Windows.Forms.Button buttonParpadear;
        private System.Windows.Forms.Button buttonEncender;
    }
}