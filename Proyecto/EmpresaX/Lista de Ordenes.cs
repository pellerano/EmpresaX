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
    public partial class Lista_de_Ordenes : Form
    {
        public string conString = "Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True";
        public SqlConnection mycon = new SqlConnection(@"Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True");

        public Lista_de_Ordenes()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(conString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Orden_Mstr", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dgv2.AutoGenerateColumns = false;
                dgv2.DataSource = dtbl;
            }
        }

        private void Lista_de_Ordenes_Load(object sender, EventArgs e)
        {

        }

        private void Lista_de_Ordenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Alquilados")
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Orden_Mstr WHERE Ord_Estado = 'Alquilado'", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgv2.AutoGenerateColumns = false;
                    dgv2.DataSource = dtbl;
                }
            }

            else if(comboBox1.SelectedItem.ToString() == "Devueltos")
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Orden_Mstr WHERE Ord_Estado = 'Devuelto'", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgv2.AutoGenerateColumns = false;
                    dgv2.DataSource = dtbl;
                }
            }

            else if (comboBox1.SelectedItem.ToString() == "Todos")
            {
                using (SqlConnection sqlCon = new SqlConnection(conString))
                {
                    sqlCon.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Orden_Mstr", sqlCon);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);

                    dgv2.AutoGenerateColumns = false;
                    dgv2.DataSource = dtbl;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }
    }
}
