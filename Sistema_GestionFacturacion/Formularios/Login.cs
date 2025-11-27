using Sistema_GestionFacturacion.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Guna.UI2.WinForms;



namespace Sistema_GestionFacturacion.Formularios
{
    public partial class Login : Form
    {
        ConsultasSQL consulta = new ConsultasSQL();
        Conexion conexion = new Conexion();
        AlertasDelSistema Alertas = new AlertasDelSistema();

        public Login()
        {
            InitializeComponent();
            Habilitar();
           

        }

        void Habilitar()
        {
            txtUsuario.Enabled = true;
            txtClave.Enabled = true;
        }

        // Iniciar sesión: solo usa usuario + contraseña; abre formulario según rol.
        public void IniciarSesion()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text ?? string.Empty;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                Alertas.Advertencia("Ingrese usuario y contraseña.");
                return;
            }

            const string sql = @"
                SELECT TOP(1)
                    u.IdUsuario,
                    u.Nombre,
                    u.Apellido,
                    u.Clave,
                    u.Sal,
                    u.Iteraciones,
                    u.IdRol,
                    u.Estado,
                    r.Rol AS RolNombre
                FROM Usuarios u
                LEFT JOIN Roles r ON u.IdRol = r.IdRol
                WHERE u.Usuario = @Usuario;";
            try
            {
                using (var cmd = new SqlCommand(sql, Conexion.SQLConexion))
                {
                    cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar, 50).Value = usuario;
                    conexion.abrirConexion();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            Alertas.Advertencia("Usuario no encontrado.");
                            return;
                        }
                        reader.Read();

                        string estado = reader["Estado"] != DBNull.Value ? reader["Estado"].ToString() : string.Empty;
                        if (!string.Equals(estado, "Activo", StringComparison.OrdinalIgnoreCase))
                        {
                            Alertas.Advertencia("Usuario no está activo.");
                            return;
                        }
                        int iteraciones = 10000;
                        if (reader["Iteraciones"] != DBNull.Value)
                            int.TryParse(reader["Iteraciones"].ToString(), out iteraciones);

                        byte[] storedHash = LeerDbBinary(reader, "Clave");
                        byte[] salt = LeerDbBinary(reader, "Sal");

                        if (storedHash == null || salt == null)
                        {
                            Alertas.Advertencia("Credenciales incompletas en la base de datos.");
                            return;
                        }

                        bool valido = VerificarPassword(clave, salt, storedHash, iteraciones);

                        if (!valido)
                        {
                            Alertas.Advertencia("Usuario o contraseña incorrectos.");
                            return;
                        }
                        string nombre = reader["Nombre"] != DBNull.Value ? reader["Nombre"].ToString() : string.Empty;
                        string apellido = reader["Apellido"] != DBNull.Value ? reader["Apellido"].ToString() : string.Empty;
                        string rolNombre = reader["RolNombre"] != DBNull.Value ? reader["RolNombre"].ToString() : string.Empty;
                        int idUsuario = reader["IdUsuario"] != DBNull.Value ? Convert.ToInt32(reader["IdUsuario"]) : 0;
                        Alertas.Realizado("Inicio de sesión exitoso.");

                        // Abrir formulario según rol
                        if (!string.IsNullOrEmpty(rolNombre) && rolNombre.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                        {
                            try
                            {
                                var menu = new FormMenu(idUsuario, rolNombre, nombre, apellido);
                                menu.StartPosition = FormStartPosition.CenterScreen;
                                menu.Show();

                                this.Hide();
                            }
                            catch (Exception ex)
                            { 
                                Alertas.Advertencia($"No se pudo abrir el menu principal: {ex.Message}");
                            }
                        }

                        else if(!string.IsNullOrEmpty(rolNombre) && rolNombre.Equals("Empleado", StringComparison.OrdinalIgnoreCase))
                        {
                            try
                            {
                                var menu = new FormMenu(idUsuario, rolNombre, nombre, apellido);
                                menu.StartPosition = FormStartPosition.CenterScreen;
                                menu.Show();

                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                Alertas.Advertencia($"No se pudo abrir el menu principal: {ex.Message}");
                            }

                        }
                        else
                        {
                            try
                            {
                                // Abrir FormularioPedidos 
                                string EstadoPago = "Pendiente";
                                string MetodooPago = "Pendiente";
                                var pedidos = new FormPedidos(idUsuario, rolNombre, nombre, apellido, EstadoPago, MetodooPago);
                                this.Hide();
                                pedidos.Show();
                            }
                            catch (Exception ex)
                            {
                                Alertas.Advertencia($"No se pudo abrir FormularioPedidos: {ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Alertas.Advertencia($"Error de base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al iniciar sesión: {ex.Message}");
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        // Verifica la contraseña usando PBKDF2 (Rfc2898). Comparación en tiempo constante.
        bool VerificarPassword(string password, byte[] salt, byte[] storedHash, int iteraciones)
        {
            if (password == null || salt == null || storedHash == null) return false;
            try
            {
                using (var pbk = new Rfc2898DeriveBytes(password, salt, iteraciones))
                {
                    byte[] computed = pbk.GetBytes(storedHash.Length);
                    if (computed.Length != storedHash.Length) return false;

                    int diff = 0;
                    for (int i = 0; i < storedHash.Length; i++)
                        diff |= storedHash[i] ^ computed[i];

                    return diff == 0;
                }
            }
            catch
            {
                return false;
            }
        }

        // Lee una columna que puede contener VARBINARY (byte[]) o una cadena Base64 (NVARCHAR) y devuelve byte[]
        byte[] LeerDbBinary(SqlDataReader reader, string nombreColumna)
        {
            try
            {
                object val = reader[nombreColumna];
                if (val == DBNull.Value || val == null) return null;

                if (val is byte[] bytes) return bytes;

                var s = val as string;
                if (!string.IsNullOrEmpty(s))
                {
                    try
                    {
                        return Convert.FromBase64String(s);
                    }
                    catch
                    {
                        return null;
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }



        void MostrasrClave()
        {
            if (chkMostrar.Checked)
            {
                txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            MostrasrClave();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}