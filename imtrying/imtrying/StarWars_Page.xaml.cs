using Newtonsoft.Json.Linq;
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

            pontlabel.Text = ""+Player.gamers[0].Points;

            nevlabel.Text = "" + Player.gamers[0].Name;


            var assembly = typeof(StarWars_Page);

            Tatoo.Source = ImageSource.FromResource("imtrying.Assets.Images.Tatmap.png", assembly);
        }

        private async void startgame_Clicked(object sender, EventArgs e)
        {
             JObject Feladványok = JObject.Parse(Gameplay.jsonösszes);

            //static Random rand = new Random();

             JArray tömb = (JArray)Feladványok["SW"]["Kérdések"];

            int sorszam = Gameplay.RandNumber(tömb.Count);

            List<String> kérdések = Feladványok["SW"]["Kérdések"][sorszam]["answers"].Select(x => (string)x).ToList(); // new List<string>();

           var response = await DisplayActionSheet( Feladványok["SW"]["Kérdések"][sorszam]["question"].ToString(), 
               "Back", "Failed", kérdések[0], kérdések[1], kérdések[2], kérdések[3]);

            Gameplay.Helyes = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];

            if (Gameplay.CompareInt((int)response[0], Gameplay.Helyes))
            {
                Player.gamers[0].Pointincrease();
            }
            else
            {
                Player.gamers[0].PointDecrease();
            }
            Navigation.InsertPageBefore(new StarWars_Page(), this);
            await Navigation.PopAsync();
        
            if(Player.gamers[0].Points == -300)
            {
                await Navigation.PopAsync();
            }

        }

    }
}