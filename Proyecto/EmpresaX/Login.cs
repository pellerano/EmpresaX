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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
        }
        
        private void TxtContraseña_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtContraseña.PasswordChar = '•';
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True");
            string query = "Select * from Usuario_Mstr Where Usuario_NombreUsuario = '" + txtUsuario.Text.Trim() + "' and Usuario_Contraseña = '" + txtContraseña.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Main objMain = new Main();
                this.Hide();
                objMain.Show();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña Incorrecta.");
            }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = '•';
        }

        private void BtnIniciarSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True");
                string query = "Select * from Usuario_Mstr Where Usuario_NombreUsuario = '" + txtUsuario.Text.Trim() + "' and Usuario_Contraseña = '" + txtContraseña.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    Main objMain = new Main();
                    this.Hide();
                    objMain.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña Incorrecta.");
                }
            }
        }
    }
}
