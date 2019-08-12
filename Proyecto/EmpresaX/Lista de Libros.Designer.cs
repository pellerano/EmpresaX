namespace EmpresaX
{
    partial class Lista_de_Libros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Libros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Libro_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro_ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiltrarAutor = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 38);
            this.panel1.TabIndex = 0;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libro_Titulo,
            this.Autor_Nombre,
            this.Libro_ISBN,
            this.Genero_Nombre,
            this.Libro_Seccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.Location = new System.Drawing.Point(12, 120);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.Size = new System.Drawing.Size(776, 333);
            this.dgv2.TabIndex = 3;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv2_CellContentClick);
            // 
            // Libro_Titulo
            // 
            this.Libro_Titulo.DataPropertyName = "Libro_Titulo";
            this.Libro_Titulo.HeaderText = "Título";
            this.Libro_Titulo.Name = "Libro_Titulo";
            this.Libro_Titulo.ReadOnly = true;
            this.Libro_Titulo.Width = 200;
            // 
            // Autor_Nombre
            // 
            this.Autor_Nombre.DataPropertyName = "Autor_Nombre";
            this.Autor_Nombre.HeaderText = "Autor";
            this.Autor_Nombre.Name = "Autor_Nombre";
            this.Autor_Nombre.ReadOnly = true;
            this.Autor_Nombre.Width = 150;
            // 
            // Libro_ISBN
            // 
            this.Libro_ISBN.DataPropertyName = "Libro_ISBN";
            this.Libro_ISBN.HeaderText = "ISBN";
            this.Libro_ISBN.Name = "Libro_ISBN";
            this.Libro_ISBN.ReadOnly = true;
            this.Libro_ISBN.Width = 150;
            // 
            // Genero_Nombre
            // 
            this.Genero_Nombre.DataPropertyName = "Genero_Nombre";
            this.Genero_Nombre.HeaderText = "Género";
            this.Genero_Nombre.Name = "Genero_Nombre";
            this.Genero_Nombre.ReadOnly = true;
            this.Genero_Nombre.Width = 150;
            // 
            // Libro_Seccion
            // 
            this.Libro_Seccion.DataPropertyName = "Libro_Seccion";
            this.Libro_Seccion.HeaderText = "Sección";
            this.Libro_Seccion.Name = "Libro_Seccion";
            this.Libro_Seccion.ReadOnly = true;
            this.Libro_Seccion.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por Autor:";
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.Location = new System.Drawing.Point(567, 45);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarAutor.TabIndex = 6;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.BtnBuscarAutor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(661, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cerrar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarAutor.Location = new System.Drawing.Point(123, 47);
            this.txtFiltrarAutor.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.PromptChar = ' ';
            this.txtFiltrarAutor.Size = new System.Drawing.Size(432, 25);
            this.txtFiltrarAutor.TabIndex = 8;
            this.txtFiltrarAutor.Click += new System.EventHandler(this.TxtFiltrarAutor_Click);
            this.txtFiltrarAutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltrarAutor_KeyDown);
            // 
            // btnBuscarTitulo
            // 
            this.btnBuscarTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTitulo.Location = new System.Drawing.Point(567, 80);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarTitulo.TabIndex = 10;
            this.btnBuscarTitulo.Text = "Buscar";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.BtnBuscarTitulo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtrar por Titulo:";
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTitulo.Location = new System.Drawing.Point(123, 83);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(432, 25);
            this.txtBuscarTitulo.TabIndex = 11;
            this.txtBuscarTitulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBuscarTitulo_KeyDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Todos los Libros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Lista_de_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscarTitulo);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltrarAutor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_de_Libros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Libros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lista_de_Libros_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtFiltrarAutor;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro_ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro_Seccion;
    }
}