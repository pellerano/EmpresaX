namespace EmpresaX
{
    partial class Lista_de_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_de_Usuarios));
            this.button2 = new System.Windows.Forms.Button();
            this.txtFiltrarAutor = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.Usuario_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Todos los Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtFiltrarAutor
            // 
            this.txtFiltrarAutor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarAutor.Location = new System.Drawing.Point(139, 45);
            this.txtFiltrarAutor.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txtFiltrarAutor.Name = "txtFiltrarAutor";
            this.txtFiltrarAutor.PromptChar = ' ';
            this.txtFiltrarAutor.Size = new System.Drawing.Size(311, 25);
            this.txtFiltrarAutor.TabIndex = 25;
            this.txtFiltrarAutor.Click += new System.EventHandler(this.TxtFiltrarAutor_Click);
            this.txtFiltrarAutor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFiltrarAutor_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(426, 469);
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
            this.btnBuscarAutor.Location = new System.Drawing.Point(478, 43);
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
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filtrar por Nombre:";
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
            this.Usuario_ID,
            this.Usuario_NombreUsuario,
            this.Usuario_Nombre,
            this.Apellido_Usuario,
            this.Email_Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.Location = new System.Drawing.Point(10, 121);
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
            // Usuario_ID
            // 
            this.Usuario_ID.DataPropertyName = "Usuario_ID";
            this.Usuario_ID.HeaderText = "ID";
            this.Usuario_ID.Name = "Usuario_ID";
            this.Usuario_ID.ReadOnly = true;
            // 
            // Usuario_NombreUsuario
            // 
            this.Usuario_NombreUsuario.DataPropertyName = "Usuario_NombreUsuario";
            this.Usuario_NombreUsuario.HeaderText = "Username";
            this.Usuario_NombreUsuario.Name = "Usuario_NombreUsuario";
            this.Usuario_NombreUsuario.ReadOnly = true;
            // 
            // Usuario_Nombre
            // 
            this.Usuario_Nombre.DataPropertyName = "Usuario_Nombre";
            this.Usuario_Nombre.HeaderText = "Nombre";
            this.Usuario_Nombre.Name = "Usuario_Nombre";
            this.Usuario_Nombre.ReadOnly = true;
            // 
            // Apellido_Usuario
            // 
            this.Apellido_Usuario.DataPropertyName = "Usuario_Apellido";
            this.Apellido_Usuario.HeaderText = "Apellido";
            this.Apellido_Usuario.Name = "Apellido_Usuario";
            this.Apellido_Usuario.ReadOnly = true;
            // 
            // Email_Usuario
            // 
            this.Email_Usuario.DataPropertyName = "Usuario_Email";
            this.Email_Usuario.HeaderText = "Email";
            this.Email_Usuario.Name = "Email_Usuario";
            this.Email_Usuario.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 38);
            this.panel1.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(478, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 28;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Filtrar por Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(139, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 25);
            this.textBox1.TabIndex = 29;
            this.textBox1.Click += new System.EventHandler(this.TextBox1_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
            // 
            // Lista_de_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 504);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
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
            this.Name = "Lista_de_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lista_de_Usuarios_FormClosed);
            this.Load += new System.EventHandler(this.Lista_de_Usuarios_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Usuario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}