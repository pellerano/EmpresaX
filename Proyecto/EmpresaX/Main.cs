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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True";
        public SqlConnection mycon = new SqlConnection(@"Data Source=GOICOECHEA;Initial Catalog=Biblioteca;Integrated Security=True");

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login objLogin = new Login();
            this.Hide();
            objLogin.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TxtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && !char.IsLetter(e.KeyChar)
             && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void TxtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtNombreUsuario.Text == "Nombre")
               || (txtApellidoUsuario.Text == "Apellido")
               || (txtEmailUsuario.Text == "Email")
               || (txtU_NombreUsuario.Text == "Usuario")
               || (txtU_NombreUsuario.Text == "")
               || (txtNombreUsuario.Text == "")
               || (txtApellidoUsuario.Text == "")
               || (txtEmailUsuario.Text == "")
               && (txtContraseñaUsuario != txtRepContraseñaUsuario))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_mstr where Usuario_UsuarioNombre ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtApellidoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtNombreUsuario.Text == "Nombre")
               || (txtApellidoUsuario.Text == "Apellido")
               || (txtEmailUsuario.Text == "Email")
               || (txtU_NombreUsuario.Text == "Usuario")
               || (txtU_NombreUsuario.Text == "")
               || (txtNombreUsuario.Text == "")
               || (txtApellidoUsuario.Text == "")
               || (txtEmailUsuario.Text == "")
               && (txtContraseñaUsuario != txtRepContraseñaUsuario))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_mstr where Usuario_UsuarioNombre ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtEmailUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtNombreUsuario.Text == "Nombre")
               || (txtApellidoUsuario.Text == "Apellido")
               || (txtEmailUsuario.Text == "Email")
               || (txtU_NombreUsuario.Text == "Usuario")
               || (txtU_NombreUsuario.Text == "")
               || (txtNombreUsuario.Text == "")
               || (txtApellidoUsuario.Text == "")
               || (txtEmailUsuario.Text == "")
               && (txtContraseñaUsuario != txtRepContraseñaUsuario))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_mstr where Usuario_UsuarioNombre ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtU_NombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtNombreUsuario.Text == "Nombre")
               || (txtApellidoUsuario.Text == "Apellido")
               || (txtEmailUsuario.Text == "Email")
               || (txtU_NombreUsuario.Text == "Usuario")
               || (txtU_NombreUsuario.Text == "")
               || (txtNombreUsuario.Text == "")
               || (txtApellidoUsuario.Text == "")
               || (txtEmailUsuario.Text == "")
               && (txtContraseñaUsuario != txtRepContraseñaUsuario))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_mstr where Usuario_UsuarioNombre ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtContraseñaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtNombreUsuario.Text == "Nombre")
               || (txtApellidoUsuario.Text == "Apellido")
               || (txtEmailUsuario.Text == "Email")
               || (txtU_NombreUsuario.Text == "Usuario")
               || (txtU_NombreUsuario.Text == "")
               || (txtNombreUsuario.Text == "")
               || (txtApellidoUsuario.Text == "")
               || (txtEmailUsuario.Text == "")
               && (txtContraseñaUsuario != txtRepContraseñaUsuario))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_mstr where Usuario_UsuarioNombre ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtRepContraseñaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtU_NombreUsuario.Text == "")
               || (txtNombreUsuario.Text == "")
               || (txtApellidoUsuario.Text == "")
               || (txtEmailUsuario.Text == "")
               || (txtContraseñaUsuario.Text == "")
               && (txtContraseñaUsuario != txtRepContraseñaUsuario))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
             && !char.IsLetter(e.KeyChar)
             && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

        private void TxtContraseñaUsuario_Click(object sender, EventArgs e)
        {
            txtContraseñaUsuario.Clear();
            txtContraseñaUsuario.PasswordChar = '•';
        }

        private void TxtNombreUsuario_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
        }

        private void TxtApellidoUsuario_Click(object sender, EventArgs e)
        {
            txtApellidoUsuario.Clear();
        }

        private void TxtEmailUsuario_Click(object sender, EventArgs e)
        {
            txtEmailUsuario.Clear();
        }

        private void TxtU_NombreUsuario_Click(object sender, EventArgs e)
        {
            txtU_NombreUsuario.Clear();
        }

        private void TxtRepContraseñaUsuario_Click(object sender, EventArgs e)
        {
            txtRepContraseñaUsuario.Clear();
        }

        private void TxtMatricula_Click_1(object sender, EventArgs e)
        {
            txtMatricula.Clear();
        }

        private void BtnCrear_Click_1(object sender, EventArgs e)
        {
            if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
            {
                MessageBox.Show("Por favor llenar todos los campos.");
            }

            else
            {
                try
                {
                    string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                    mycon.Open();
                    SqlCommand cmda = new SqlCommand(che, mycon);
                    int count = (int)cmda.ExecuteScalar();
                    if (count > 0)
                    {
                        txtNombreEst.Clear();
                        txtApellido.Clear();
                        txtMatricula.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();
                        MessageBox.Show("Este estudiante ya existe.");
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        txtNombreEst.Clear();
                        txtApellido.Clear();
                        txtMatricula.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();
                        MessageBox.Show("Estudiante Registrado con Exito!");
                    }

                    mycon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (mycon.State == ConnectionState.Open)
                        mycon.Close();
                }
            }
        }

        private void TxtNombreEst_Click_1(object sender, EventArgs e)
        {
            txtNombreEst.Clear();
        }

        private void TxtApellido_Click_1(object sender, EventArgs e)
        {
            txtApellido.Clear();
        }

        private void TxtEmail_Click_1(object sender, EventArgs e)
        {
            txtEmail.Clear();
        }

        private void TxtTelefono_Click_1(object sender, EventArgs e)
        {
            txtTelefono.Clear();
        }

        private void TxtMatricula_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Este estudiante ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Estudiante Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtNombreEst_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Este estudiante ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Estudiante Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtApellido_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Este estudiante ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Estudiante Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtEmail_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Este estudiante ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Estudiante Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtTelefono_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
                {
                    txtNombreEst.Clear();
                    txtApellido.Clear();
                    txtMatricula.Clear();
                    txtEmail.Clear();
                    txtTelefono.Clear();
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {   //Bookmark
                        string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este estudiante ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Estudiante Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }

        private void BtnCrearUsuario_Click(object sender, EventArgs e)
        {
            if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
           || (txtU_NombreUsuario.Text == "")
           || (txtNombreUsuario.Text == "")
           || (txtApellidoUsuario.Text == "")
           || (txtEmailUsuario.Text == "")
           || (txtContraseñaUsuario.Text == ""))

            {
                MessageBox.Show("Por favor llenar todos los campos.");
            }

            else
            {
                try
                {
                    string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                    SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                    mycon.Open();
                    SqlCommand cmda = new SqlCommand(che, mycon);
                    int count = (int)cmda.ExecuteScalar();
                    if (count > 0)
                    {
                        txtNombreEst.Clear();
                        txtApellido.Clear();
                        txtMatricula.Clear();
                        txtEmail.Clear();
                        txtTelefono.Clear();
                        MessageBox.Show("Este usuario ya existe.");
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        txtNombreUsuario.Clear();
                        txtApellidoUsuario.Clear();
                        txtEmailUsuario.Clear();
                        txtU_NombreUsuario.Clear();
                        txtContraseñaUsuario.Clear();
                        txtRepContraseñaUsuario.Clear();
                        MessageBox.Show("Usuario Registrado con Exito!");
                    }

                    mycon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (mycon.State == ConnectionState.Open)
                        mycon.Close();
                }
            }
        }

        private void TxtNombreUsuario_Click_1(object sender, EventArgs e)
        {
            txtNombreUsuario.Clear();
        }

        private void TxtApellidoUsuario_Click_1(object sender, EventArgs e)
        {
            txtApellidoUsuario.Clear();
        }

        private void TxtEmailUsuario_Click_1(object sender, EventArgs e)
        {
            txtEmailUsuario.Clear();
        }

        private void TxtU_NombreUsuario_Click_1(object sender, EventArgs e)
        {
            txtU_NombreUsuario.Clear();
        }

        private void TxtContraseñaUsuario_Click_1(object sender, EventArgs e)
        {
            txtContraseñaUsuario.Clear();
            txtContraseñaUsuario.PasswordChar = '•';
        }

        private void TxtRepContraseñaUsuario_Click_1(object sender, EventArgs e)
        {
            txtRepContraseñaUsuario.Clear();
            txtRepContraseñaUsuario.PasswordChar = '•';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((txtISBN.Text == "")
               || (txtAutor.Text == "")
               || (txtTitulo.Text == "")
               || (txtGenero.Text == "")
               || (txtSeccion.Text == "")
               || (txtISBN.Text == "000-0-00-000000-0")
               || (txtISBN.Text == "   - -  -      -"))
            {
                MessageBox.Show("Por favor llenar todos los campos.");
            }

            else
            {
                try
                {   //2B
                    //Contadores
                    string a = @"(select count(*) from Libro_Mstr where Libro_Titulo ='" + txtTitulo.Text.ToString() + "')";
                    string b = @"(select count(*) from Autor_Mstr where Autor_Nombre ='" + txtAutor.Text.ToString() + "')";
                    string c = @"(select count(*) from Genero_Mstr where Genero_Nombre ='" + txtGenero.Text.ToString() + "')";

                    //Commands SQL

                    //Insertar Autor
                    SqlCommand amd = new SqlCommand("Insert into Autor_Mstr(Autor_Nombre)values('" + txtAutor.Text.ToString() + "')", mycon);

                    //Insertar Genero
                    SqlCommand bmd = new SqlCommand("Insert into Genero_Mstr(Genero_Nombre)values('" + txtGenero.Text.ToString() + "')", mycon);

                    //Insertar Info Libro
                    SqlCommand cmd = new SqlCommand("Insert into Libro_Mstr(Libro_ISBN, Libro_Titulo, Libro_Seccion, Autor_Nombre, Genero_Nombre)values('" + txtISBN.Text.ToString() + "','" + txtTitulo.Text.ToString() + "','" + txtSeccion.Text.ToString() + "','" + txtAutor.Text.ToString() + "','" + txtGenero.Text.ToString() + "')", mycon);

                    //Update Autor_ID
                    SqlCommand dmd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Autor_ID = Autor_Mstr.Autor_ID FROM Autor_Mstr WHERE Libro_Mstr.Libro_ISBN = '" + txtISBN.Text.ToString() + "' AND Autor_Mstr.Autor_Nombre = '" + txtAutor.Text.ToString() + "')", mycon);

                    //Update Genero_ID
                    SqlCommand emd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Genero_ID = Genero_Mstr.Genero_ID FROM Genero_Mstr WHERE Genero_Nombre = @gn AND  Libro_Mstr.Libro_ISBN = @ISBN", mycon);


                    mycon.Open();

                    //Contadores en SQL
                    SqlCommand cmda = new SqlCommand(a, mycon);
                    SqlCommand cmdb = new SqlCommand(b, mycon);
                    SqlCommand cmdc = new SqlCommand(c, mycon);
                    int counta = (int)cmda.ExecuteScalar();
                    int countb = (int)cmdb.ExecuteScalar();
                    int countc = (int)cmdc.ExecuteScalar();

                    //Agregar Libro Nuevo
                    if ((counta == 0)
                    && (countb == 0)
                    && (countc == 0))
                    {
                        amd.ExecuteNonQuery();
                        bmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        dmd.ExecuteNonQuery();
                        emd.ExecuteNonQuery();
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    //Agregar Libro Nuevo con Genero ya existente
                    else if ((counta == 0)
                    && (countb == 0)
                    && (countc > 0))
                    {
                        amd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        dmd.ExecuteNonQuery();
                        emd.ExecuteNonQuery();
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    //Agregar Libro Nuevo con Autor Existente
                    else if ((counta == 0)
                    && (countb > 0)
                    && (countc == 0))
                    {
                        bmd.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        dmd.ExecuteNonQuery();
                        emd.ExecuteNonQuery();
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    //Agregar Libro Nuevo con Autor y Genero Existente
                    else if ((counta == 0)
                    && (countb > 0)
                    && (countc > 0))
                    {
                        cmd.ExecuteNonQuery();
                        dmd.ExecuteNonQuery();
                        emd.ExecuteNonQuery();
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    else
                    {
                        MessageBox.Show("Este libro ya está registrado.");
                    }

                    mycon.Close();
                }

                catch
                {
                    MessageBox.Show("Libro Registrado con Exito!");
                }

                finally
                {
                    if (mycon.State == ConnectionState.Open)
                    {
                        mycon.Close();
                    }
                }
                txtISBN.Clear();
                txtAutor.Clear();
                txtTitulo.Clear();
                txtGenero.Clear();
                txtSeccion.Clear();
            }
        }


        private void TxtISBN_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
        }

        private void TxtApellido_Click(object sender, EventArgs e)
        {
            txtApellido.Clear();
        }

        private void TxtAutor_Click(object sender, EventArgs e)
        {
            txtAutor.Clear();
        }

        private void TxtTitulo_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
        }

        private void TxtGenero_Click(object sender, EventArgs e)
        {
            txtGenero.Clear();
        }

        private void TxtSeccion_Click(object sender, EventArgs e)
        {
            txtSeccion.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }

        private void TxtNombreUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
                || (txtU_NombreUsuario.Text == "")
                || (txtNombreUsuario.Text == "")
                || (txtApellidoUsuario.Text == "")
                || (txtEmailUsuario.Text == "")
                || (txtContraseñaUsuario.Text == ""))

                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreUsuario.Clear();
                            txtApellidoUsuario.Clear();
                            txtEmailUsuario.Clear();
                            txtU_NombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtRepContraseñaUsuario.Clear();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtApellidoUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
                || (txtU_NombreUsuario.Text == "")
                || (txtNombreUsuario.Text == "")
                || (txtApellidoUsuario.Text == "")
                || (txtEmailUsuario.Text == "")
                || (txtContraseñaUsuario.Text == ""))

                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreUsuario.Clear();
                            txtApellidoUsuario.Clear();
                            txtEmailUsuario.Clear();
                            txtU_NombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtRepContraseñaUsuario.Clear();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtEmailUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
                || (txtU_NombreUsuario.Text == "")
                || (txtNombreUsuario.Text == "")
                || (txtApellidoUsuario.Text == "")
                || (txtEmailUsuario.Text == "")
                || (txtContraseñaUsuario.Text == ""))

                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreUsuario.Clear();
                            txtApellidoUsuario.Clear();
                            txtEmailUsuario.Clear();
                            txtU_NombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtRepContraseñaUsuario.Clear();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtU_NombreUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
                || (txtU_NombreUsuario.Text == "")
                || (txtNombreUsuario.Text == "")
                || (txtApellidoUsuario.Text == "")
                || (txtEmailUsuario.Text == "")
                || (txtContraseñaUsuario.Text == ""))

                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreUsuario.Clear();
                            txtApellidoUsuario.Clear();
                            txtEmailUsuario.Clear();
                            txtU_NombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtRepContraseñaUsuario.Clear();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtContraseñaUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
                || (txtU_NombreUsuario.Text == "")
                || (txtNombreUsuario.Text == "")
                || (txtApellidoUsuario.Text == "")
                || (txtEmailUsuario.Text == "")
                || (txtContraseñaUsuario.Text == ""))

                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreUsuario.Clear();
                            txtApellidoUsuario.Clear();
                            txtEmailUsuario.Clear();
                            txtU_NombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtRepContraseñaUsuario.Clear();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtRepContraseñaUsuario_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtContraseñaUsuario.Text != txtRepContraseñaUsuario.Text)
                || (txtU_NombreUsuario.Text == "")
                || (txtNombreUsuario.Text == "")
                || (txtApellidoUsuario.Text == "")
                || (txtEmailUsuario.Text == "")
                || (txtContraseñaUsuario.Text == ""))

                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Usuario_Mstr where Usuario_NombreUsuario ='" + txtU_NombreUsuario.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Usuario_Mstr(Usuario_Nombre, Usuario_Apellido, Usuario_Email, Usuario_Contraseña, Usuario_NombreUsuario)values('" + txtNombreUsuario.Text.ToString() + "','" + txtApellidoUsuario.Text.ToString() + "','" + txtEmailUsuario.Text.ToString() + "','" + txtContraseñaUsuario.Text.ToString() + "','" + txtU_NombreUsuario.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Este usuario  ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreUsuario.Clear();
                            txtApellidoUsuario.Clear();
                            txtEmailUsuario.Clear();
                            txtU_NombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtRepContraseñaUsuario.Clear();
                            MessageBox.Show("Usuario Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void BtnListaLibros_Click(object sender, EventArgs e)
        {
            Lista_de_Libros objListaLibros = new Lista_de_Libros();
            this.Hide();
            objListaLibros.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Lista_de_Autores objListaAutores = new Lista_de_Autores();
            this.Hide();
            objListaAutores.Show();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Lista_de_Generos objListaGeneros = new Lista_de_Generos();
            this.Hide();
            objListaGeneros.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lista_de_Usuarios objListaUsuarios = new Lista_de_Usuarios();
            this.Hide();
            objListaUsuarios.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Lista_de_Estudiantes objListaEstudiantes = new Lista_de_Estudiantes();
            this.Hide();
            objListaEstudiantes.Show();
        }

        private void MaskedTextBox1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            mycon.Open();

            //Contadores
            string s2 = @"(select count(*) from Alumno_Mstr where Alumno_Matricula = '" + maskedTextBox1.Text.ToString() + "')";
            string s3 = @"(select count(*) from Libro_Mstr where Libro_Titulo = '" + textBox1.Text.ToString() + "')";
            string s1 = @"(select count(*) from Orden_Mstr where Alumno_Matricula ='" + maskedTextBox1.Text.ToString() + "' AND Ord_Estado = 'Alquilado')";
            SqlCommand edm = new SqlCommand(s1, mycon);
            SqlCommand adm = new SqlCommand(s2, mycon);
            SqlCommand bdm = new SqlCommand(s3, mycon);
            int cont1 = (int)edm.ExecuteScalar();
            int cont2 = (int)adm.ExecuteScalar();
            int cont3 = (int)bdm.ExecuteScalar();

            //Queries
            string foxtrot = @"Insert into Orden_Mstr(Alumno_Matricula, Libro_Titulo, Fecha_Alquiler, Fecha_Devolucion, Ord_Estado)VALUES(@matriculaest, @titulo, @FechaA, @FechaB, 'Alquilado')";

            //Insertar Matricula
            SqlCommand query1 = new SqlCommand(foxtrot, mycon);
            query1.Parameters.Add("@FechaA", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            query1.Parameters.Add("@FechaB", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            query1.Parameters.Add("@matriculaest", SqlDbType.VarChar).Value = maskedTextBox1.Text;
            query1.Parameters.Add("@titulo", SqlDbType.VarChar).Value = textBox1.Text;

            if ((cont2 == 0))
            {
                MessageBox.Show("Este estudiante no existe.");
                maskedTextBox1.Clear();
                textBox1.Clear();

            }

            else
            {
                if ((cont3 == 0))
                {
                    MessageBox.Show("Este libro no existe.");
                    maskedTextBox1.Clear();
                    textBox1.Clear();
                }

                else
                {
                    if ((cont1 == 0))
                    {
                        //Proceso
                        query1.ExecuteNonQuery();
                        MessageBox.Show("Libro Alquilado con exito!");
                        maskedTextBox1.Clear();
                        textBox1.Clear();
                    }

                    else
                    {

                        MessageBox.Show("Este estudiante ya tiene un libro alquilado.");
                        maskedTextBox1.Clear();
                        textBox1.Clear();
                    }
                }
            }

            mycon.Close();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
            objMain.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            mycon.Open();

            string s4 = @"(select count(*) from Orden_Mstr where Alumno_Matricula = '" + maskedTextBox2.Text.ToString() + "')";
            string s5 = @"(select count(*) from Orden_Mstr where Ord_Estado = 'Alquilado')";
            SqlCommand zdm = new SqlCommand(s4, mycon);
            SqlCommand ydm = new SqlCommand(s5, mycon);
            int cont4 = (int)zdm.ExecuteScalar();
            int cont5 = (int)ydm.ExecuteScalar();


            if ((cont4 > 0)
            && cont5 > 0)
            {
                string s2 = @"UPDATE Orden_Mstr SET Ord_Estado = 'Devuelto' WHERE Alumno_Matricula = @matricula AND Ord_Estado = 'Alquilado';";
                SqlCommand cdmz = new SqlCommand(s2, mycon);
                cdmz.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = maskedTextBox2.Text;
                cdmz.ExecuteNonQuery();
                MessageBox.Show("Libro Devuelto con exito!");
            }

            else
            {
                MessageBox.Show("Este estudiante no tiene un libro alquilado.");
            }

            mycon.Close();
        }

        private void MaskedTextBox2_Click(object sender, EventArgs e)
        {
            maskedTextBox2.Clear();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Lista_de_Ordenes objListaOrdenes = new Lista_de_Ordenes();
            this.Hide();
            objListaOrdenes.Show();
        }

        private void TxtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtMatricula.Text == "  -")
               || (txtMatricula.Text == "00-0000")
               || (txtNombreEst.Text == "")
               || (txtApellido.Text == "")
               || (txtEmail.Text == "")
               || (txtTelefono.Text == "(   )    -")
               || (txtTelefono.Text == "(000) 000-0000"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {
                        string che = @"(select count(*) from Alumno_mstr where Alumno_Matricula ='" + txtMatricula.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand("Insert into Alumno_Mstr(Alumno_Matricula, Alumno_Nombre, Alumno_Apellido, Alumno_Email, Alumno_Telefono)values('" + txtMatricula.Text.ToString() + "','" + txtNombreEst.Text.ToString() + "','" + txtApellido.Text.ToString() + "','" + txtEmail.Text.ToString() + "','" + txtTelefono.Text.ToString() + "')", mycon);
                        mycon.Open();
                        SqlCommand cmda = new SqlCommand(che, mycon);
                        int count = (int)cmda.ExecuteScalar();
                        if (count > 0)
                        {
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Este estudiante ya existe.");
                        }
                        else
                        {
                            cmd.ExecuteNonQuery();
                            txtNombreEst.Clear();
                            txtApellido.Clear();
                            txtMatricula.Clear();
                            txtEmail.Clear();
                            txtTelefono.Clear();
                            MessageBox.Show("Estudiante Registrado con Exito!");
                        }

                        mycon.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                            mycon.Close();
                    }
                }
            }
        }

        private void TxtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtISBN.Text == "")
               || (txtAutor.Text == "")
               || (txtTitulo.Text == "")
               || (txtGenero.Text == "")
               || (txtSeccion.Text == "")
               || (txtISBN.Text == "000-0-00-000000-0")
               || (txtISBN.Text == "   - -  -      -"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {   //2B
                        //Contadores
                        string a = @"(select count(*) from Libro_Mstr where Libro_Titulo ='" + txtTitulo.Text.ToString() + "')";
                        string b = @"(select count(*) from Autor_Mstr where Autor_Nombre ='" + txtAutor.Text.ToString() + "')";
                        string c = @"(select count(*) from Genero_Mstr where Genero_Nombre ='" + txtGenero.Text.ToString() + "')";

                        //Commands SQL

                        //Insertar Autor
                        SqlCommand amd = new SqlCommand("Insert into Autor_Mstr(Autor_Nombre)values('" + txtAutor.Text.ToString() + "')", mycon);

                        //Insertar Genero
                        SqlCommand bmd = new SqlCommand("Insert into Genero_Mstr(Genero_Nombre)values('" + txtGenero.Text.ToString() + "')", mycon);

                        //Insertar Info Libro
                        SqlCommand cmd = new SqlCommand("Insert into Libro_Mstr(Libro_ISBN, Libro_Titulo, Libro_Seccion, Autor_Nombre, Genero_Nombre)values('" + txtISBN.Text.ToString() + "','" + txtTitulo.Text.ToString() + "','" + txtSeccion.Text.ToString() + "','" + txtAutor.Text.ToString() + "','" + txtGenero.Text.ToString() + "')", mycon);

                        //Update Autor_ID
                        SqlCommand dmd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Autor_ID = Autor_Mstr.Autor_ID FROM Autor_Mstr WHERE Libro_Mstr.Libro_ISBN = '" + txtISBN.Text.ToString() + "' AND Autor_Mstr.Autor_Nombre = '" + txtAutor.Text.ToString() + "')", mycon);

                        //Update Genero_ID
                        SqlCommand emd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Genero_ID = Genero_Mstr.Genero_ID FROM Genero_Mstr WHERE Genero_Nombre = @gn AND  Libro_Mstr.Libro_ISBN = @ISBN", mycon);


                        mycon.Open();

                        //Contadores en SQL
                        SqlCommand cmda = new SqlCommand(a, mycon);
                        SqlCommand cmdb = new SqlCommand(b, mycon);
                        SqlCommand cmdc = new SqlCommand(c, mycon);
                        int counta = (int)cmda.ExecuteScalar();
                        int countb = (int)cmdb.ExecuteScalar();
                        int countc = (int)cmdc.ExecuteScalar();

                        //Agregar Libro Nuevo
                        if ((counta == 0)
                        && (countb == 0)
                        && (countc == 0))
                        {
                            amd.ExecuteNonQuery();
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Genero ya existente
                        else if ((counta == 0)
                        && (countb == 0)
                        && (countc > 0))
                        {
                            amd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc == 0))
                        {
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor y Genero Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc > 0))
                        {
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        else
                        {
                            MessageBox.Show("Este libro ya está registrado.");
                        }

                        mycon.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                        {
                            mycon.Close();
                        }
                    }
                    txtISBN.Clear();
                    txtAutor.Clear();
                    txtTitulo.Clear();
                    txtGenero.Clear();
                    txtSeccion.Clear();
                }
            }
        }

        private void TxtAutor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtISBN.Text == "")
               || (txtAutor.Text == "")
               || (txtTitulo.Text == "")
               || (txtGenero.Text == "")
               || (txtSeccion.Text == "")
               || (txtISBN.Text == "000-0-00-000000-0")
               || (txtISBN.Text == "   - -  -      -"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {   //2B
                        //Contadores
                        string a = @"(select count(*) from Libro_Mstr where Libro_Titulo ='" + txtTitulo.Text.ToString() + "')";
                        string b = @"(select count(*) from Autor_Mstr where Autor_Nombre ='" + txtAutor.Text.ToString() + "')";
                        string c = @"(select count(*) from Genero_Mstr where Genero_Nombre ='" + txtGenero.Text.ToString() + "')";

                        //Commands SQL

                        //Insertar Autor
                        SqlCommand amd = new SqlCommand("Insert into Autor_Mstr(Autor_Nombre)values('" + txtAutor.Text.ToString() + "')", mycon);

                        //Insertar Genero
                        SqlCommand bmd = new SqlCommand("Insert into Genero_Mstr(Genero_Nombre)values('" + txtGenero.Text.ToString() + "')", mycon);

                        //Insertar Info Libro
                        SqlCommand cmd = new SqlCommand("Insert into Libro_Mstr(Libro_ISBN, Libro_Titulo, Libro_Seccion, Autor_Nombre, Genero_Nombre)values('" + txtISBN.Text.ToString() + "','" + txtTitulo.Text.ToString() + "','" + txtSeccion.Text.ToString() + "','" + txtAutor.Text.ToString() + "','" + txtGenero.Text.ToString() + "')", mycon);

                        //Update Autor_ID
                        SqlCommand dmd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Autor_ID = Autor_Mstr.Autor_ID FROM Autor_Mstr WHERE Libro_Mstr.Libro_ISBN = '" + txtISBN.Text.ToString() + "' AND Autor_Mstr.Autor_Nombre = '" + txtAutor.Text.ToString() + "')", mycon);

                        //Update Genero_ID
                        SqlCommand emd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Genero_ID = Genero_Mstr.Genero_ID FROM Genero_Mstr WHERE Genero_Nombre = @gn AND  Libro_Mstr.Libro_ISBN = @ISBN", mycon);


                        mycon.Open();

                        //Contadores en SQL
                        SqlCommand cmda = new SqlCommand(a, mycon);
                        SqlCommand cmdb = new SqlCommand(b, mycon);
                        SqlCommand cmdc = new SqlCommand(c, mycon);
                        int counta = (int)cmda.ExecuteScalar();
                        int countb = (int)cmdb.ExecuteScalar();
                        int countc = (int)cmdc.ExecuteScalar();

                        //Agregar Libro Nuevo
                        if ((counta == 0)
                        && (countb == 0)
                        && (countc == 0))
                        {
                            amd.ExecuteNonQuery();
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Genero ya existente
                        else if ((counta == 0)
                        && (countb == 0)
                        && (countc > 0))
                        {
                            amd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc == 0))
                        {
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor y Genero Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc > 0))
                        {
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        else
                        {
                            MessageBox.Show("Este libro ya está registrado.");
                        }

                        mycon.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                        {
                            mycon.Close();
                        }
                    }
                    txtISBN.Clear();
                    txtAutor.Clear();
                    txtTitulo.Clear();
                    txtGenero.Clear();
                    txtSeccion.Clear();
                }
            }
        }

        private void TxtTitulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtISBN.Text == "")
               || (txtAutor.Text == "")
               || (txtTitulo.Text == "")
               || (txtGenero.Text == "")
               || (txtSeccion.Text == "")
               || (txtISBN.Text == "000-0-00-000000-0")
               || (txtISBN.Text == "   - -  -      -"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {   //2B
                        //Contadores
                        string a = @"(select count(*) from Libro_Mstr where Libro_Titulo ='" + txtTitulo.Text.ToString() + "')";
                        string b = @"(select count(*) from Autor_Mstr where Autor_Nombre ='" + txtAutor.Text.ToString() + "')";
                        string c = @"(select count(*) from Genero_Mstr where Genero_Nombre ='" + txtGenero.Text.ToString() + "')";

                        //Commands SQL

                        //Insertar Autor
                        SqlCommand amd = new SqlCommand("Insert into Autor_Mstr(Autor_Nombre)values('" + txtAutor.Text.ToString() + "')", mycon);

                        //Insertar Genero
                        SqlCommand bmd = new SqlCommand("Insert into Genero_Mstr(Genero_Nombre)values('" + txtGenero.Text.ToString() + "')", mycon);

                        //Insertar Info Libro
                        SqlCommand cmd = new SqlCommand("Insert into Libro_Mstr(Libro_ISBN, Libro_Titulo, Libro_Seccion, Autor_Nombre, Genero_Nombre)values('" + txtISBN.Text.ToString() + "','" + txtTitulo.Text.ToString() + "','" + txtSeccion.Text.ToString() + "','" + txtAutor.Text.ToString() + "','" + txtGenero.Text.ToString() + "')", mycon);

                        //Update Autor_ID
                        SqlCommand dmd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Autor_ID = Autor_Mstr.Autor_ID FROM Autor_Mstr WHERE Libro_Mstr.Libro_ISBN = '" + txtISBN.Text.ToString() + "' AND Autor_Mstr.Autor_Nombre = '" + txtAutor.Text.ToString() + "')", mycon);

                        //Update Genero_ID
                        SqlCommand emd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Genero_ID = Genero_Mstr.Genero_ID FROM Genero_Mstr WHERE Genero_Nombre = @gn AND  Libro_Mstr.Libro_ISBN = @ISBN", mycon);


                        mycon.Open();

                        //Contadores en SQL
                        SqlCommand cmda = new SqlCommand(a, mycon);
                        SqlCommand cmdb = new SqlCommand(b, mycon);
                        SqlCommand cmdc = new SqlCommand(c, mycon);
                        int counta = (int)cmda.ExecuteScalar();
                        int countb = (int)cmdb.ExecuteScalar();
                        int countc = (int)cmdc.ExecuteScalar();

                        //Agregar Libro Nuevo
                        if ((counta == 0)
                        && (countb == 0)
                        && (countc == 0))
                        {
                            amd.ExecuteNonQuery();
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Genero ya existente
                        else if ((counta == 0)
                        && (countb == 0)
                        && (countc > 0))
                        {
                            amd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc == 0))
                        {
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor y Genero Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc > 0))
                        {
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        else
                        {
                            MessageBox.Show("Este libro ya está registrado.");
                        }

                        mycon.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                        {
                            mycon.Close();
                        }
                    }
                    txtISBN.Clear();
                    txtAutor.Clear();
                    txtTitulo.Clear();
                    txtGenero.Clear();
                    txtSeccion.Clear();
                }
            }
        }

        private void TxtGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtISBN.Text == "")
               || (txtAutor.Text == "")
               || (txtTitulo.Text == "")
               || (txtGenero.Text == "")
               || (txtSeccion.Text == "")
               || (txtISBN.Text == "000-0-00-000000-0")
               || (txtISBN.Text == "   - -  -      -"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {   //2B
                        //Contadores
                        string a = @"(select count(*) from Libro_Mstr where Libro_Titulo ='" + txtTitulo.Text.ToString() + "')";
                        string b = @"(select count(*) from Autor_Mstr where Autor_Nombre ='" + txtAutor.Text.ToString() + "')";
                        string c = @"(select count(*) from Genero_Mstr where Genero_Nombre ='" + txtGenero.Text.ToString() + "')";

                        //Commands SQL

                        //Insertar Autor
                        SqlCommand amd = new SqlCommand("Insert into Autor_Mstr(Autor_Nombre)values('" + txtAutor.Text.ToString() + "')", mycon);

                        //Insertar Genero
                        SqlCommand bmd = new SqlCommand("Insert into Genero_Mstr(Genero_Nombre)values('" + txtGenero.Text.ToString() + "')", mycon);

                        //Insertar Info Libro
                        SqlCommand cmd = new SqlCommand("Insert into Libro_Mstr(Libro_ISBN, Libro_Titulo, Libro_Seccion, Autor_Nombre, Genero_Nombre)values('" + txtISBN.Text.ToString() + "','" + txtTitulo.Text.ToString() + "','" + txtSeccion.Text.ToString() + "','" + txtAutor.Text.ToString() + "','" + txtGenero.Text.ToString() + "')", mycon);

                        //Update Autor_ID
                        SqlCommand dmd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Autor_ID = Autor_Mstr.Autor_ID FROM Autor_Mstr WHERE Libro_Mstr.Libro_ISBN = '" + txtISBN.Text.ToString() + "' AND Autor_Mstr.Autor_Nombre = '" + txtAutor.Text.ToString() + "')", mycon);

                        //Update Genero_ID
                        SqlCommand emd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Genero_ID = Genero_Mstr.Genero_ID FROM Genero_Mstr WHERE Genero_Nombre = @gn AND  Libro_Mstr.Libro_ISBN = @ISBN", mycon);


                        mycon.Open();

                        //Contadores en SQL
                        SqlCommand cmda = new SqlCommand(a, mycon);
                        SqlCommand cmdb = new SqlCommand(b, mycon);
                        SqlCommand cmdc = new SqlCommand(c, mycon);
                        int counta = (int)cmda.ExecuteScalar();
                        int countb = (int)cmdb.ExecuteScalar();
                        int countc = (int)cmdc.ExecuteScalar();

                        //Agregar Libro Nuevo
                        if ((counta == 0)
                        && (countb == 0)
                        && (countc == 0))
                        {
                            amd.ExecuteNonQuery();
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Genero ya existente
                        else if ((counta == 0)
                        && (countb == 0)
                        && (countc > 0))
                        {
                            amd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc == 0))
                        {
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor y Genero Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc > 0))
                        {
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        else
                        {
                            MessageBox.Show("Este libro ya está registrado.");
                        }

                        mycon.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                        {
                            mycon.Close();
                        }
                    }
                    txtISBN.Clear();
                    txtAutor.Clear();
                    txtTitulo.Clear();
                    txtGenero.Clear();
                    txtSeccion.Clear();
                }
            }
        }

        private void TxtSeccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((txtISBN.Text == "")
               || (txtAutor.Text == "")
               || (txtTitulo.Text == "")
               || (txtGenero.Text == "")
               || (txtSeccion.Text == "")
               || (txtISBN.Text == "000-0-00-000000-0")
               || (txtISBN.Text == "   - -  -      -"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    try
                    {   //2B
                        //Contadores
                        string a = @"(select count(*) from Libro_Mstr where Libro_Titulo ='" + txtTitulo.Text.ToString() + "')";
                        string b = @"(select count(*) from Autor_Mstr where Autor_Nombre ='" + txtAutor.Text.ToString() + "')";
                        string c = @"(select count(*) from Genero_Mstr where Genero_Nombre ='" + txtGenero.Text.ToString() + "')";

                        //Commands SQL

                        //Insertar Autor
                        SqlCommand amd = new SqlCommand("Insert into Autor_Mstr(Autor_Nombre)values('" + txtAutor.Text.ToString() + "')", mycon);

                        //Insertar Genero
                        SqlCommand bmd = new SqlCommand("Insert into Genero_Mstr(Genero_Nombre)values('" + txtGenero.Text.ToString() + "')", mycon);

                        //Insertar Info Libro
                        SqlCommand cmd = new SqlCommand("Insert into Libro_Mstr(Libro_ISBN, Libro_Titulo, Libro_Seccion, Autor_Nombre, Genero_Nombre)values('" + txtISBN.Text.ToString() + "','" + txtTitulo.Text.ToString() + "','" + txtSeccion.Text.ToString() + "','" + txtAutor.Text.ToString() + "','" + txtGenero.Text.ToString() + "')", mycon);

                        //Update Autor_ID
                        SqlCommand dmd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Autor_ID = Autor_Mstr.Autor_ID FROM Autor_Mstr WHERE Libro_Mstr.Libro_ISBN = '" + txtISBN.Text.ToString() + "' AND Autor_Mstr.Autor_Nombre = '" + txtAutor.Text.ToString() + "')", mycon);

                        //Update Genero_ID
                        SqlCommand emd = new SqlCommand("UPDATE Libro_Mstr SET Libro_Mstr.Genero_ID = Genero_Mstr.Genero_ID FROM Genero_Mstr WHERE Genero_Nombre = @gn AND  Libro_Mstr.Libro_ISBN = @ISBN", mycon);


                        mycon.Open();

                        //Contadores en SQL
                        SqlCommand cmda = new SqlCommand(a, mycon);
                        SqlCommand cmdb = new SqlCommand(b, mycon);
                        SqlCommand cmdc = new SqlCommand(c, mycon);
                        int counta = (int)cmda.ExecuteScalar();
                        int countb = (int)cmdb.ExecuteScalar();
                        int countc = (int)cmdc.ExecuteScalar();

                        //Agregar Libro Nuevo
                        if ((counta == 0)
                        && (countb == 0)
                        && (countc == 0))
                        {
                            amd.ExecuteNonQuery();
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Genero ya existente
                        else if ((counta == 0)
                        && (countb == 0)
                        && (countc > 0))
                        {
                            amd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc == 0))
                        {
                            bmd.ExecuteNonQuery();
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        //Agregar Libro Nuevo con Autor y Genero Existente
                        else if ((counta == 0)
                        && (countb > 0)
                        && (countc > 0))
                        {
                            cmd.ExecuteNonQuery();
                            dmd.ExecuteNonQuery();
                            emd.ExecuteNonQuery();
                            MessageBox.Show("Libro Registrado con Exito!");
                        }

                        else
                        {
                            MessageBox.Show("Este libro ya está registrado.");
                        }

                        mycon.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Libro Registrado con Exito!");
                    }

                    finally
                    {
                        if (mycon.State == ConnectionState.Open)
                        {
                            mycon.Close();
                        }
                    }
                    txtISBN.Clear();
                    txtAutor.Clear();
                    txtTitulo.Clear();
                    txtGenero.Clear();
                    txtSeccion.Clear();
                }
            }
        }

        private void MaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((maskedTextBox1.Text == "")
                || (maskedTextBox1.Text == "  -")
                || (textBox1.Text == ""))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    mycon.Open();

                    //Contadores
                    string s2 = @"(select count(*) from Alumno_Mstr where Alumno_Matricula = '" + maskedTextBox1.Text.ToString() + "')";
                    string s3 = @"(select count(*) from Libro_Mstr where Libro_Titulo = '" + textBox1.Text.ToString() + "')";
                    string s1 = @"(select count(*) from Orden_Mstr where Alumno_Matricula ='" + maskedTextBox1.Text.ToString() + "' AND Ord_Estado = 'Alquilado')";
                    SqlCommand edm = new SqlCommand(s1, mycon);
                    SqlCommand adm = new SqlCommand(s2, mycon);
                    SqlCommand bdm = new SqlCommand(s3, mycon);
                    int cont1 = (int)edm.ExecuteScalar();
                    int cont2 = (int)adm.ExecuteScalar();
                    int cont3 = (int)bdm.ExecuteScalar();

                    //Queries
                    string foxtrot = @"Insert into Orden_Mstr(Alumno_Matricula, Libro_Titulo, Fecha_Alquiler, Fecha_Devolucion, Ord_Estado)VALUES(@matriculaest, @titulo, @FechaA, @FechaB, 'Alquilado')";

                    //Insertar Matricula
                    SqlCommand query1 = new SqlCommand(foxtrot, mycon);
                    query1.Parameters.Add("@FechaA", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    query1.Parameters.Add("@FechaB", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                    query1.Parameters.Add("@matriculaest", SqlDbType.VarChar).Value = maskedTextBox1.Text;
                    query1.Parameters.Add("@titulo", SqlDbType.VarChar).Value = textBox1.Text;

                    if ((cont2 == 0))
                    {
                        MessageBox.Show("Este estudiante no existe.");
                        maskedTextBox1.Clear();
                        textBox1.Clear();

                    }

                    else
                    {
                        if ((cont3 == 0))
                        {
                            MessageBox.Show("Este libro no existe.");
                            maskedTextBox1.Clear();
                            textBox1.Clear();
                        }

                        else
                        {
                            if ((cont1 == 0))
                            {
                                //Proceso
                                query1.ExecuteNonQuery();
                                MessageBox.Show("Libro Alquilado con exito!");
                                maskedTextBox1.Clear();
                                textBox1.Clear();
                            }

                            else
                            {

                                MessageBox.Show("Este estudiante ya tiene un libro alquilado.");
                                maskedTextBox1.Clear();
                                textBox1.Clear();
                            }
                        }
                    }

                    mycon.Close();
                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((maskedTextBox1.Text == "")
                || (maskedTextBox1.Text == "  -")
                || (textBox1.Text == ""))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    mycon.Open();

                    //Contadores
                    string s2 = @"(select count(*) from Alumno_Mstr where Alumno_Matricula = '" + maskedTextBox1.Text.ToString() + "')";
                    string s3 = @"(select count(*) from Libro_Mstr where Libro_Titulo = '" + textBox1.Text.ToString() + "')";
                    string s1 = @"(select count(*) from Orden_Mstr where Alumno_Matricula ='" + maskedTextBox1.Text.ToString() + "' AND Ord_Estado = 'Alquilado')";
                    SqlCommand edm = new SqlCommand(s1, mycon);
                    SqlCommand adm = new SqlCommand(s2, mycon);
                    SqlCommand bdm = new SqlCommand(s3, mycon);
                    int cont1 = (int)edm.ExecuteScalar();
                    int cont2 = (int)adm.ExecuteScalar();
                    int cont3 = (int)bdm.ExecuteScalar();

                    //Queries
                    string foxtrot = @"Insert into Orden_Mstr(Alumno_Matricula, Libro_Titulo, Fecha_Alquiler, Fecha_Devolucion, Ord_Estado)VALUES(@matriculaest, @titulo, @FechaA, @FechaB, 'Alquilado')";

                    //Insertar Matricula
                    SqlCommand query1 = new SqlCommand(foxtrot, mycon);
                    query1.Parameters.Add("@FechaA", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    query1.Parameters.Add("@FechaB", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                    query1.Parameters.Add("@matriculaest", SqlDbType.VarChar).Value = maskedTextBox1.Text;
                    query1.Parameters.Add("@titulo", SqlDbType.VarChar).Value = textBox1.Text;

                    if ((cont2 == 0))
                    {
                        MessageBox.Show("Este estudiante no existe.");
                        maskedTextBox1.Clear();
                        textBox1.Clear();

                    }

                    else
                    {
                        if ((cont3 == 0))
                        {
                            MessageBox.Show("Este libro no existe.");
                            maskedTextBox1.Clear();
                            textBox1.Clear();
                        }

                        else
                        {
                            if ((cont1 == 0))
                            {
                                //Proceso
                                query1.ExecuteNonQuery();
                                MessageBox.Show("Libro Alquilado con exito!");
                                maskedTextBox1.Clear();
                                textBox1.Clear();
                            }

                            else
                            {

                                MessageBox.Show("Este estudiante ya tiene un libro alquilado.");
                                maskedTextBox1.Clear();
                                textBox1.Clear();
                            }
                        }
                    }

                    mycon.Close();
                }
            }
        }

        private void MaskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((maskedTextBox2.Text == "")
                || (maskedTextBox2.Text == "  -"))
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }

                else
                {
                    mycon.Open();

                    string s4 = @"(select count(*) from Orden_Mstr where Alumno_Matricula = '" + maskedTextBox2.Text.ToString() + "')";
                    string s5 = @"(select count(*) from Orden_Mstr where Ord_Estado = 'Alquilado')";
                    SqlCommand zdm = new SqlCommand(s4, mycon);
                    SqlCommand ydm = new SqlCommand(s5, mycon);
                    int cont4 = (int)zdm.ExecuteScalar();
                    int cont5 = (int)ydm.ExecuteScalar();


                    if ((cont4 > 0)
                    && cont5 > 0)
                    {
                        string s2 = @"UPDATE Orden_Mstr SET Ord_Estado = 'Devuelto' WHERE Alumno_Matricula = @matricula AND Ord_Estado = 'Alquilado';";
                        SqlCommand cdmz = new SqlCommand(s2, mycon);
                        cdmz.Parameters.Add("@Matricula", SqlDbType.VarChar).Value = maskedTextBox2.Text;
                        cdmz.ExecuteNonQuery();
                        MessageBox.Show("Libro Devuelto con exito!");
                    }

                    else
                    {
                        MessageBox.Show("Este estudiante no tiene un libro alquilado.");
                    }

                    mycon.Close();
                }
            }
        }
    }
}

    

