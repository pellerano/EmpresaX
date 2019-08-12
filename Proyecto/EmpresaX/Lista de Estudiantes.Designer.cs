namespace EmpresaX
{
    partial class Lista_de_Estudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Estudiantes));
            this.button2 = new System.Windows.Forms.Button();
            this.txtFiltrarAutor = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Alumno_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Todos los Estudiantes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarAutor.Location = new System.Drawing.Point(143, 35);
            this.txtFiltrarAutor.Mask = "00-0000";
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.PromptChar = ' ';
            this.txtFiltrarAutor.Size = new System.Drawing.Size(329, 25);
            this.txtFiltrarAutor.TabIndex = 25;
            this.txtFiltrarAutor.ValidatingType = typeof(int);
            this.txtFiltrarAutor.Click += new System.EventHandler(this.TxtFiltrarAutor_Click);
            this.txtFiltrarAutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltrarAutor_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cerrar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.Location = new System.Drawing.Point(478, 33);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarAutor.TabIndex = 23;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            this.btnBuscarAutor.Click += new System.EventHandler(this.BtnBuscarAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filtrar por Matrícula:";
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
            this.Alumno_Matricula,
            this.Alumno_Nombre,
            this.Alumno_Apellido,
            this.Alumno_Email,
            this.Alumno_Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.Location = new System.Drawing.Point(10, 67);
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
            this.dgv2.Size = new System.Drawing.Size(543, 333);
            this.dgv2.TabIndex = 21;
            // 
            // Alumno_Matricula
            // 
            this.Alumno_Matricula.DataPropertyName = "Alumno_Matricula";
            this.Alumno_Matricula.HeaderText = "Matricula";
            this.Alumno_Matricula.Name = "Alumno_Matricula";
            this.Alumno_Matricula.ReadOnly = true;
            // 
            // Alumno_Nombre
            // 
            this.Alumno_Nombre.DataPropertyName = "Alumno_Nombre";
            this.Alumno_Nombre.HeaderText = "Nombre";
            this.Alumno_Nombre.Name = "Alumno_Nombre";
            this.Alumno_Nombre.ReadOnly = true;
            // 
            // Alumno_Apellido
            // 
            this.Alumno_Apellido.DataPropertyName = "Alumno_Apellido";
            this.Alumno_Apellido.HeaderText = "Apellido";
            this.Alumno_Apellido.Name = "Alumno_Apellido";
            this.Alumno_Apellido.ReadOnly = true;
            // 
            // Alumno_Email
            // 
            this.Alumno_Email.DataPropertyName = "Alumno_Email";
            this.Alumno_Email.HeaderText = "Email";
            this.Alumno_Email.Name = "Alumno_Email";
            this.Alumno_Email.ReadOnly = true;
            // 
            // Alumno_Telefono
            // 
            this.Alumno_Telefono.DataPropertyName = "Alumno_Telefono";
            this.Alumno_Telefono.HeaderText = "Teléfono";
            this.Alumno_Telefono.Name = "Alumno_Telefono";
            this.Alumno_Telefono.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-2, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 38);
            this.panel1.TabIndex = 20;
            // 
            // Lista_de_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtFiltrarAutor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista_de_Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Estudiantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lista_de_Estudiantes_FormClosed);
            this.Load += new System.EventHandler(this.Lista_de_Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtFiltrarAutor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno_Telefono;
        private System.Windows.Forms.Panel panel1;
    }
}