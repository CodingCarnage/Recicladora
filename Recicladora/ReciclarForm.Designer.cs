namespace Recicladora
{
    partial class ReciclarForm
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonReciclar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancelar.BackColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.buttonCancelar.Location = new System.Drawing.Point(12, 687);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(230, 50);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonReciclar
            // 
            this.buttonReciclar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReciclar.BackColor = System.Drawing.Color.White;
            this.buttonReciclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReciclar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReciclar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.buttonReciclar.Location = new System.Drawing.Point(782, 687);
            this.buttonReciclar.Name = "buttonReciclar";
            this.buttonReciclar.Size = new System.Drawing.Size(230, 50);
            this.buttonReciclar.TabIndex = 11;
            this.buttonReciclar.Text = "Iniciar Reciclaje";
            this.buttonReciclar.UseVisualStyleBackColor = false;
            this.buttonReciclar.Click += new System.EventHandler(this.buttonReciclar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recicladora.Properties.Resources.oie_1716165OwnTaXTa;
            this.pictureBox1.Location = new System.Drawing.Point(248, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // IniciarReciclajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonReciclar);
            this.Controls.Add(this.buttonCancelar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IniciarReciclajeForm";
            this.Text = "IniciarReciclajeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IniciarReciclajeForm_FormClosing);
            this.Load += new System.EventHandler(this.IniciarReciclajeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonReciclar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.IO.Ports.SerialPort serialPort;
    }
}