namespace EmpresaX
{
    partial class Lista_de_Generos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Generos));
            this.button2 = new System.Windows.Forms.Button();
            this.txtFiltrarAutor = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Genero_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Todos los Géneros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarAutor.Location = new System.Drawing.Point(133, 45);
            this.txtFiltrarAutor.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.PromptChar = ' ';
            this.txtFiltrarAutor.Size = new System.Drawing.Size(189, 25);
            this.txtFiltrarAutor.TabIndex = 25;
            this.txtFiltrarAutor.Click += new System.EventHandler(this.TxtFiltrarAutor_Click);
            this.txtFiltrarAutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltrarAutor_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 425);
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
            this.btnBuscarAutor.Location = new System.Drawing.Point(328, 43);
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
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filtrar por Género:";
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
            this.Genero_ID,
            this.Genero_Nombre});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.Location = new System.Drawing.Point(10, 77);
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
            this.dgv2.Size = new System.Drawing.Size(393, 333);
            this.dgv2.TabIndex = 21;
            // 
            // Genero_ID
            // 
            this.Genero_ID.DataPropertyName = "Genero_ID";
            this.Genero_ID.HeaderText = "ID";
            this.Genero_ID.Name = "Genero_ID";
            this.Genero_ID.ReadOnly = true;
            // 
            // Genero_Nombre
            // 
            this.Genero_Nombre.DataPropertyName = "Genero_Nombre";
            this.Genero_Nombre.HeaderText = "Género";
            this.Genero_Nombre.Name = "Genero_Nombre";
            this.Genero_Nombre.ReadOnly = true;
            this.Genero_Nombre.Width = 250;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 38);
            this.panel1.TabIndex = 20;
            // 
            // Lista_de_Generos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 462);
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
            this.Name = "Lista_de_Generos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_de_Generos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lista_de_Generos_FormClosed);
            this.Load += new System.EventHandler(this.Lista_de_Generos_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero_Nombre;
    }
}