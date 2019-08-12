using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmpresaX
{
    public partial class Lista_de_Usuarios : Form
    {
        public string conString = "Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True";
        public SqlConnection mycon = new SqlConnection(@"Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True");

        public Lista_de_Usuarios()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuario_Mstr", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
        }

        private void Lista_de_Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void Lista_de_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBuscarAutor_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuario_Mstr WHERE Usuario_Nombre = '" + txtFiltrarAutor.Text.ToString() + "' ", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor llenar todos los campos.");
            }

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuario_Mstr WHERE Usuario_NombreUsuario = '" + textBox1.Text.ToString() + "' ", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgv2.AutoGenerateColumns = false;
                    dgv2.DataSource = dtbl;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuario_Mstr", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }

        private void TxtFiltrarAutor_Click(object sender, EventArgs e)
        {
            txtFiltrarAutor.Clear();
        }

        private void TextBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void TxtFiltrarAutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtFiltrarAutor.Text == "")
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    using (SqlConnection sqlCon = new SqlConnection(conString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuario_Mstr WHERE Usuario_Nombre = '" + txtFiltrarAutor.Text.ToString() + "' ", sqlCon);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);

                        dgv2.AutoGenerateColumns = false;
                        dgv2.DataSource = dtbl;
                    }
                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    using (SqlConnection sqlCon = new SqlConnection(conString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Usuario_Mstr WHERE Usuario_NombreUsuario = '" + textBox1.Text.ToString() + "' ", sqlCon);
                        DataTable dtbl = new DataTable();
                        sqlDa.Fill(dtbl);

                        dgv2.AutoGenerateColumns = false;
                        dgv2.DataSource = dtbl;
                    }
                }
            }
        }
    }
}
