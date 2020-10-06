namespace Recicladora
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTextNumeroEmpleado = new System.Windows.Forms.Label();
            this.textBoxNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.labelTextNombre = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTextSONES = new System.Windows.Forms.Label();
            this.labelSONES = new System.Windows.Forms.Label();
            this.buttonReciclar = new System.Windows.Forms.Button();
            this.buttonProductos = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxInstrucciones = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.pictureBoxDesign = new System.Windows.Forms.PictureBox();
            this.labelLatasRecicladas = new System.Windows.Forms.Label();
            this.labelTextLatasRecicladas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstrucciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTextNumeroEmpleado
            // 
            this.labelTextNumeroEmpleado.AutoSize = true;
            this.labelTextNumeroEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextNumeroEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(195)))));
            this.labelTextNumeroEmpleado.Location = new System.Drawing.Point(44, 169);
            this.labelTextNumeroEmpleado.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.labelTextNumeroEmpleado.Name = "labelTextNumeroEmpleado";
            this.labelTextNumeroEmpleado.Size = new System.Drawing.Size(258, 32);
            this.labelTextNumeroEmpleado.TabIndex = 3;
            this.labelTextNumeroEmpleado.Text = "Número de Empleado:";
            // 
            // textBoxNumeroEmpleado
            // 
            this.textBoxNumeroEmpleado.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumeroEmpleado.Location = new System.Drawing.Point(50, 204);
            this.textBoxNumeroEmpleado.Name = "textBoxNumeroEmpleado";
            this.textBoxNumeroEmpleado.Size = new System.Drawing.Size(362, 39);
            this.textBoxNumeroEmpleado.TabIndex = 4;
            this.textBoxNumeroEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumeroEmpleado_KeyDown);
            this.textBoxNumeroEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroEmpleado_KeyPress);
            // 
            // labelTextNombre
            // 
            this.labelTextNombre.AutoSize = true;
            this.labelTextNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(195)))));
            this.labelTextNombre.Location = new System.Drawing.Point(44, 261);
            this.labelTextNombre.Margin = new System.Windows.Forms.Padding(35, 15, 3, 0);
            this.labelTextNombre.Name = "labelTextNombre";
            this.labelTextNombre.Size = new System.Drawing.Size(110, 32);
            this.labelTextNombre.TabIndex = 5;
            this.labelTextNombre.Text = "Nombre:";
            this.labelTextNombre.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(44, 302);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(250, 32);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "<NombreEmpleado/>";
            this.labelNombre.Visible = false;
            // 
            // labelTextSONES
            // 
            this.labelTextSONES.AutoSize = true;
            this.labelTextSONES.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSONES.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(195)))));
            this.labelTextSONES.Location = new System.Drawing.Point(44, 349);
            this.labelTextSONES.Margin = new System.Windows.Forms.Padding(35, 15, 3, 0);
            this.labelTextSONES.Name = "labelTextSONES";
            this.labelTextSONES.Size = new System.Drawing.Size(95, 32);
            this.labelTextSONES.TabIndex = 7;
            this.labelTextSONES.Text = "SONES:";
            this.labelTextSONES.Visible = false;
            // 
            // labelSONES
            // 
            this.labelSONES.AutoSize = true;
            this.labelSONES.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSONES.Location = new System.Drawing.Point(44, 390);
            this.labelSONES.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.labelSONES.Name = "labelSONES";
            this.labelSONES.Size = new System.Drawing.Size(130, 32);
            this.labelSONES.TabIndex = 8;
            this.labelSONES.Text = "<SONES/>";
            this.labelSONES.Visible = false;
            // 
            // buttonReciclar
            // 
            this.buttonReciclar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReciclar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(194)))), ((int)(((byte)(94)))));
            this.buttonReciclar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReciclar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReciclar.ForeColor = System.Drawing.Color.White;
            this.buttonReciclar.Location = new System.Drawing.Point(807, 602);
            this.buttonReciclar.Name = "buttonReciclar";
            this.buttonReciclar.Size = new System.Drawing.Size(205, 50);
            this.buttonReciclar.TabIndex = 9;
            this.buttonReciclar.Text = "Reciclar";
            this.buttonReciclar.UseVisualStyleBackColor = false;
            this.buttonReciclar.Click += new System.EventHandler(this.buttonReciclar_Click);
            // 
            // buttonProductos
            // 
            this.buttonProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(195)))));
            this.buttonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductos.ForeColor = System.Drawing.Color.White;
            this.buttonProductos.Location = new System.Drawing.Point(596, 602);
            this.buttonProductos.Name = "buttonProductos";
            this.buttonProductos.Size = new System.Drawing.Size(205, 50);
            this.buttonProductos.TabIndex = 10;
            this.buttonProductos.Text = "Ver Productos";
            this.buttonProductos.UseVisualStyleBackColor = false;
            this.buttonProductos.Click += new System.EventHandler(this.buttonProductos_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Image = global::Recicladora.Properties.Resources.delete__1_;
            this.buttonClear.Location = new System.Drawing.Point(371, 170);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(41, 37);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBoxInstrucciones
            // 
            this.pictureBoxInstrucciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxInstrucciones.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInstrucciones.Image")));
            this.pictureBoxInstrucciones.Location = new System.Drawing.Point(14, 461);
            this.pictureBoxInstrucciones.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxInstrucciones.Name = "pictureBoxInstrucciones";
            this.pictureBoxInstrucciones.Size = new System.Drawing.Size(341, 274);
            this.pictureBoxInstrucciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInstrucciones.TabIndex = 11;
            this.pictureBoxInstrucciones.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::Recicladora.Properties.Resources.Nemak_Word_Mark_Symbol;
            this.pictureBoxLogo.Location = new System.Drawing.Point(769, 658);
            this.pictureBoxLogo.MaximumSize = new System.Drawing.Size(255, 91);
            this.pictureBoxLogo.MinimumSize = new System.Drawing.Size(255, 91);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(255, 91);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Image = global::Recicladora.Properties.Resources.TitleDesign;
            this.pictureBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(578, 166);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTitle.TabIndex = 1;
            this.pictureBoxTitle.TabStop = false;
            // 
            // pictureBoxDesign
            // 
            this.pictureBoxDesign.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxDesign.Image = global::Recicladora.Properties.Resources.MainScreenDesing;
            this.pictureBoxDesign.Location = new System.Drawing.Point(466, 0);
            this.pictureBoxDesign.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxDesign.MaximumSize = new System.Drawing.Size(558, 477);
            this.pictureBoxDesign.MinimumSize = new System.Drawing.Size(558, 477);
            this.pictureBoxDesign.Name = "pictureBoxDesign";
            this.pictureBoxDesign.Size = new System.Drawing.Size(558, 477);
            this.pictureBoxDesign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDesign.TabIndex = 0;
            this.pictureBoxDesign.TabStop = false;
            // 
            // labelLatasRecicladas
            // 
            this.labelLatasRecicladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelLatasRecicladas.AutoSize = true;
            this.labelLatasRecicladas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatasRecicladas.Location = new System.Drawing.Point(365, 699);
            this.labelLatasRecicladas.Margin = new System.Windows.Forms.Padding(35, 0, 3, 0);
            this.labelLatasRecicladas.Name = "labelLatasRecicladas";
            this.labelLatasRecicladas.Size = new System.Drawing.Size(109, 32);
            this.labelLatasRecicladas.TabIndex = 14;
            this.labelLatasRecicladas.Text = "<Latas/>";
            this.labelLatasRecicladas.Visible = false;
            // 
            // labelTextLatasRecicladas
            // 
            this.labelTextLatasRecicladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTextLatasRecicladas.AutoSize = true;
            this.labelTextLatasRecicladas.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextLatasRecicladas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(125)))), ((int)(((byte)(195)))));
            this.labelTextLatasRecicladas.Location = new System.Drawing.Point(365, 658);
            this.labelTextLatasRecicladas.Margin = new System.Windows.Forms.Padding(35, 15, 3, 0);
            this.labelTextLatasRecicladas.Name = "labelTextLatasRecicladas";
            this.labelTextLatasRecicladas.Size = new System.Drawing.Size(196, 32);
            this.labelTextLatasRecicladas.TabIndex = 13;
            this.labelTextLatasRecicladas.Text = "Latas Recicladas:";
            this.labelTextLatasRecicladas.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.labelLatasRecicladas);
            this.Controls.Add(this.labelTextLatasRecicladas);
            this.Controls.Add(this.textBoxNumeroEmpleado);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.pictureBoxInstrucciones);
            this.Controls.Add(this.buttonProductos);
            this.Controls.Add(this.buttonReciclar);
            this.Controls.Add(this.labelSONES);
            this.Controls.Add(this.labelTextSONES);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTextNombre);
            this.Controls.Add(this.labelTextNumeroEmpleado);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxTitle);
            this.Controls.Add(this.pictureBoxDesign);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInstrucciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDesign)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDesign;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTextNumeroEmpleado;
        private System.Windows.Forms.TextBox textBoxNumeroEmpleado;
        private System.Windows.Forms.Label labelTextNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTextSONES;
        private System.Windows.Forms.Label labelSONES;
        private System.Windows.Forms.Button buttonReciclar;
        private System.Windows.Forms.Button buttonProductos;
        private System.Windows.Forms.PictureBox pictureBoxInstrucciones;
        private System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Label labelLatasRecicladas;
        private System.Windows.Forms.Label labelTextLatasRecicladas;
    }
}