using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SbaldeonS5B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Usuarios : ContentPage
    {
        private string Url = "http://172.22.48.1/RutaSegura/post.php";
        private HttpClient cliente = new HttpClient();
        private ObservableCollection<Usuario> post;

        public Usuarios()
        {
            InitializeComponent();

        }

      

        private async void btnMostrar_Clicked(object sender, EventArgs e)
        {
            var contenido = await cliente.GetStringAsync(Url);
            List<Usuario> listaPost = JsonConvert.DeserializeObject<List<Usuario>>(contenido);
            post = new ObservableCollection<Usuario>(listaPost);
            ListaUsuarios.ItemsSource = post;

        }
    }
}