using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace imtrying
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TesztPage1 : ContentPage
    {      // static string jsonösszes = File.ReadAllText("sw.json");

        static JObject Feladványok = JObject.Parse(Gameplay.jsonösszes);

        static Random rand = new Random();

       static JArray tömb = (JArray)Feladványok["SW"]["Kérdések"];

        private static int sorszam(string a)
        {
            int szam = (int)a.Last();

            return szam;
        }
        public TesztPage1()
        {
            InitializeComponent();

            int sorszam = rand.Next(1, tömb.Count);
            List<String> kérdések = Feladványok["SW"]["Kérdések"][sorszam]["answers"].Select(x => (string)x).ToList(); // new List<string>();

            // int megoldas = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];


            //átírva a Gameplay.cs osztályba
           Gameplay.Helyes = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];  //megoldas;

            Question.Text = Feladványok["SW"]["Kérdések"][sorszam]["question"].ToString();
            Answer1.Text = kérdések[0];
            Answer2.Text = kérdések[1];
            Answer3.Text = kérdések[2];
            Answer4.Text = kérdések[3];
        }

        private void Answer1_Clicked(object sender, EventArgs e)
        {
            if(TesztPage1.sorszam("Answer1") == Gameplay.Helyes)
            {
                Player.gamers[0].Pointincrease();
            }
            else
            {
                Player.gamers[0].PointDecrease();
            }
        }

        private void Answer2_Clicked(object sender, EventArgs e)
        {
            if (TesztPage1.sorszam("Answer2") == Gameplay.Helyes)
            {
                Player.gamers[0].Pointincrease();
            }
            else
            {
                Player.gamers[0].PointDecrease();
            }
        }

        private void Answer3_Clicked(object sender, EventArgs e)
        {
            if (TesztPage1.sorszam("Answer3") == Gameplay.Helyes)
            {
                Player.gamers[0].Pointincrease();
            }
            else
            {
                Player.gamers[0].PointDecrease();
            }
        }

        private void Answer4_Clicked(object sender, EventArgs e)
        {
            if (TesztPage1.sorszam("Answer4") == Gameplay.Helyes)
            {
                Player.gamers[0].Pointincrease();
            }
            else
            {
                Player.gamers[0].PointDecrease();
            }
        }
    }
}