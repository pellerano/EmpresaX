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
    public partial class Lista_de_Generos : Form
    {
        public string conString = "Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True";
        public SqlConnection mycon = new SqlConnection(@"Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True");

        public Lista_de_Generos()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Genero_Mstr", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
        }

        private void Lista_de_Generos_Load(object sender, EventArgs e)
        {

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

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Genero_Mstr", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
        }

        private void BtnBuscarAutor_Click(object sender, EventArgs e)
        {
            if (txtFiltrarAutor.Text == "")
            {
                MessageBox.Show("Por Favor llenar todos los campos.");
            }

            else
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Genero_Mstr WHERE Genero_Nombre = '" + txtFiltrarAutor.Text.ToString() + "' ", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgv2.AutoGenerateColumns = false;
                    dgv2.DataSource = dtbl;
                }
            }
        }

        private void Lista_de_Generos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtFiltrarAutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtFiltrarAutor.Text == "")
                {
                    MessageBox.Show("Por Favor llenar todos los campos.");
                }

                else
                {
                    using (SqlConnection sqlCon = new SqlConnection(conString))
                    {
                        sqlCon.Open();
                        SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Genero_Mstr WHERE Genero_Nombre = '" + txtFiltrarAutor.Text.ToString() + "' ", sqlCon);
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
