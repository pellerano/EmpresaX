namespace EmpresaX
{
    partial class Lista_de_Ordenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Ordenes));
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Ord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro_Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Alquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ord_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(682, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cerrar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(513, 45);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 29);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar:";
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
            this.Ord_ID,
            this.Alumno_Matricula,
            this.Libro_Titulo,
            this.Fecha_Alquiler,
            this.Fecha_Devolucion,
            this.Ord_Estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.Location = new System.Drawing.Point(12, 79);
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
            this.dgv2.Size = new System.Drawing.Size(797, 333);
            this.dgv2.TabIndex = 19;
            // 
            // Ord_ID
            // 
            this.Ord_ID.DataPropertyName = "Ord_ID";
            this.Ord_ID.HeaderText = "ID";
            this.Ord_ID.Name = "Ord_ID";
            this.Ord_ID.ReadOnly = true;
            // 
            // Alumno_Matricula
            // 
            this.Alumno_Matricula.DataPropertyName = "Alumno_Matricula";
            this.Alumno_Matricula.HeaderText = "Matricula";
            this.Alumno_Matricula.Name = "Alumno_Matricula";
            this.Alumno_Matricula.ReadOnly = true;
            this.Alumno_Matricula.Width = 250;
            // 
            // Libro_Titulo
            // 
            this.Libro_Titulo.DataPropertyName = "Libro_Titulo";
            this.Libro_Titulo.HeaderText = "Titulo";
            this.Libro_Titulo.Name = "Libro_Titulo";
            this.Libro_Titulo.ReadOnly = true;
            // 
            // Fecha_Alquiler
            // 
            this.Fecha_Alquiler.DataPropertyName = "Fecha_Alquiler";
            this.Fecha_Alquiler.HeaderText = "Fecha de Alquiler";
            this.Fecha_Alquiler.Name = "Fecha_Alquiler";
            this.Fecha_Alquiler.ReadOnly = true;
            // 
            // Fecha_Devolucion
            // 
            this.Fecha_Devolucion.DataPropertyName = "Fecha_Devolucion";
            this.Fecha_Devolucion.HeaderText = "Fecha de Devolución";
            this.Fecha_Devolucion.Name = "Fecha_Devolucion";
            this.Fecha_Devolucion.ReadOnly = true;
            // 
            // Ord_Estado
            // 
            this.Ord_Estado.DataPropertyName = "Ord_Estado";
            this.Ord_Estado.HeaderText = "Estado";
            this.Ord_Estado.Name = "Ord_Estado";
            this.Ord_Estado.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-19, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 38);
            this.panel1.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alquilados",
            "Devueltos",
            "Todos"});
            this.comboBox1.Location = new System.Drawing.Point(60, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(439, 25);
            this.comboBox1.TabIndex = 23;
            // 
            // Lista_de_Ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 454);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Lista_de_Ordenes";
            this.Text = "Lista de Ordenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lista_de_Ordenes_FormClosed);
            this.Load += new System.EventHandler(this.Lista_de_Ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libro_Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Alquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord_Estado;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}