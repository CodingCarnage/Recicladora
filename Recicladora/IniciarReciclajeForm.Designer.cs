namespace Recicladora
{
    partial class IniciarReciclajeForm
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
            this.buttonCamRechazo = new System.Windows.Forms.Button();
            this.buttonCamAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerArduino = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCamRechazo
            // 
            this.buttonCamRechazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCamRechazo.BackColor = System.Drawing.Color.White;
            this.buttonCamRechazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCamRechazo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamRechazo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.buttonCamRechazo.Location = new System.Drawing.Point(12, 687);
            this.buttonCamRechazo.Name = "buttonCamRechazo";
            this.buttonCamRechazo.Size = new System.Drawing.Size(230, 50);
            this.buttonCamRechazo.TabIndex = 12;
            this.buttonCamRechazo.Text = "Camara Rechazar";
            this.buttonCamRechazo.UseVisualStyleBackColor = false;
            this.buttonCamRechazo.Click += new System.EventHandler(this.buttonCamRechazo_Click);
            // 
            // buttonCamAceptar
            // 
            this.buttonCamAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCamAceptar.BackColor = System.Drawing.Color.White;
            this.buttonCamAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCamAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCamAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.buttonCamAceptar.Location = new System.Drawing.Point(248, 687);
            this.buttonCamAceptar.Name = "buttonCamAceptar";
            this.buttonCamAceptar.Size = new System.Drawing.Size(230, 50);
            this.buttonCamAceptar.TabIndex = 13;
            this.buttonCamAceptar.Text = "Camara Aceptar";
            this.buttonCamAceptar.UseVisualStyleBackColor = false;
            this.buttonCamAceptar.Click += new System.EventHandler(this.buttonCamAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.pictureBox1.Image = global::Recicladora.Properties.Resources.oie_19183510Mq8KAVuN;
            this.pictureBox1.Location = new System.Drawing.Point(161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 630);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // timerArduino
            // 
            this.timerArduino.Interval = 2500;
            this.timerArduino.Tick += new System.EventHandler(this.timerArduino_Tick);
            // 
            // IniciarReciclajeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCamAceptar);
            this.Controls.Add(this.buttonCamRechazo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IniciarReciclajeForm";
            this.Text = "Validando";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Validando_FormClosing);
            this.Load += new System.EventHandler(this.Validando_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCamRechazo;
        private System.Windows.Forms.Button buttonCamAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerArduino;
    }
}