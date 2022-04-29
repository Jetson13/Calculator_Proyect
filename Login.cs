using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Calculadora_Proyecto_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-KKNOU6U; database=Calculadora_ProyectoFinal; integrated security= true");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "select * from LoginPF Where Usuario= '" + TBUsuario.Text + "' and contraseña= '" + TBContraseña.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                this.Hide();
                Calculadora PC = new Calculadora();
                PC.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            conexion.Close();

        }

        private void BTCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}