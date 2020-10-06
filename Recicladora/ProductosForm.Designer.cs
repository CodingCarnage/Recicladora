namespace Recicladora
{
    partial class ProductosForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTextNombre = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTextSONES = new System.Windows.Forms.Label();
            this.labelSONES = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Image = global::Recicladora.Properties.Resources.icons8_back_50;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(56, 56);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.Image = global::Recicladora.Properties.Resources.TitleDesign;
            this.pictureBoxTitle.Location = new System.Drawing.Point(65, 14);
            this.pictureBoxTitle.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(338, 54);
            this.pictureBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTitle.TabIndex = 2;
            this.pictureBoxTitle.TabStop = false;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeColumns = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            this.dataGridViewProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.ColumnHeadersVisible = false;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagen,
            this.Producto,
            this.SONES});
            this.dataGridViewProductos.GridColor = System.Drawing.Color.White;
            this.dataGridViewProductos.Location = new System.Drawing.Point(12, 87);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductos.Size = new System.Drawing.Size(1000, 650);
            this.dataGridViewProductos.TabIndex = 4;
            this.dataGridViewProductos.SelectionChanged += new System.EventHandler(this.dataGridViewProductos_SelectionChanged);
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // SONES
            // 
            this.SONES.HeaderText = "SONES";
            this.SONES.Name = "SONES";
            this.SONES.ReadOnly = true;
            // 
            // labelTextNombre
            // 
            this.labelTextNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextNombre.AutoSize = true;
            this.labelTextNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextNombre.Location = new System.Drawing.Point(593, 9);
            this.labelTextNombre.Name = "labelTextNombre";
            this.labelTextNombre.Size = new System.Drawing.Size(79, 21);
            this.labelTextNombre.TabIndex = 5;
            this.labelTextNombre.Text = "Nombre: ";
            this.labelTextNombre.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(672, 9);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(340, 21);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Mariana Yolanda Elizabeth Hernandez Cardenas";
            this.labelNombre.Visible = false;
            // 
            // labelTextSONES
            // 
            this.labelTextSONES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTextSONES.AutoSize = true;
            this.labelTextSONES.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSONES.Location = new System.Drawing.Point(593, 34);
            this.labelTextSONES.Name = "labelTextSONES";
            this.labelTextSONES.Size = new System.Drawing.Size(64, 21);
            this.labelTextSONES.TabIndex = 7;
            this.labelTextSONES.Text = "SONES:";
            this.labelTextSONES.Visible = false;
            // 
            // labelSONES
            // 
            this.labelSONES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSONES.AutoSize = true;
            this.labelSONES.Location = new System.Drawing.Point(672, 34);
            this.labelSONES.Name = "labelSONES";
            this.labelSONES.Size = new System.Drawing.Size(146, 21);
            this.labelSONES.TabIndex = 8;
            this.labelSONES.Text = "<NúmeroSONES/>";
            this.labelSONES.Visible = false;
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 749);
            this.Controls.Add(this.labelSONES);
            this.Controls.Add(this.labelTextSONES);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTextNombre);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONES;
        private System.Windows.Forms.Label labelTextNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTextSONES;
        private System.Windows.Forms.Label labelSONES;
    }
}