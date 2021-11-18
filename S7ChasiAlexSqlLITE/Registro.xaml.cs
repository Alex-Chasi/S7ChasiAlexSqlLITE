using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using S7ChasiAlexSqlLITE.Models;


namespace S7ChasiAlexSqlLITE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;

        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var Registro = new Estudiante { Nombre = txtNombre.Text, Usuario = txtUsuario.Text, Contrasenia = txtContrasenia.Text };
                con.InsertAsync(Registro);
                DisplayAlert("Alert", "Dato Ingresado", "Ok");

                limpiarForm();

                Navigation.PushAsync(new Login());


                // Navigation.PushAsync(new ConsultaRegistro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", "ERROR" + ex.Message, "Ok");
            }

            void limpiarForm()
            {
                txtNombre.Text = "";
                txtUsuario.Text = "";
                txtContrasenia.Text = "";
                //DisplayAlert("Alert", "Dato Ingresado", "Ok");
            }

        }
    }
}