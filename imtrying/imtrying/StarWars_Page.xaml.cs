using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace imtrying
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StarWars_Page : ContentPage
    {
        public StarWars_Page()
        {
            InitializeComponent();

            var assembly = typeof(StarWars_Page);

            Tatoo.Source = ImageSource.FromResource("imtrying.Assets.Images.Tatmap.png", assembly);
        }

        private void startgame_Clicked(object sender, EventArgs e)
        {
            //Quiz_View.ContentProperty
        }
    }
}