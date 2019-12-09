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

        //static Random rand = new Random();

       static JArray tömb = (JArray)Feladványok["SW"]["Kérdések"];

        private static int sorszam(string a)
        {
            
            int szam = (int)a.ToString().Last();

            return szam;
        }
        public TesztPage1()
        {
            InitializeComponent();

                


            int sorszam = Gameplay.RandNumber(tömb.Count);

            List<String> kérdések = Feladványok["SW"]["Kérdések"][sorszam]["answers"].Select(x => (string)x).ToList(); // new List<string>();

            // int megoldas = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];



            //átírva a Gameplay.cs osztályba
           Gameplay.Helyes = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];  //megoldas;

            Question.Text = Feladványok["SW"]["Kérdések"][sorszam]["question"].ToString();


         /*   var sztekk = new StackLayout();

            var Kérdéslabel = new Label();
            Kérdéslabel.Text = Feladványok["SW"]["Kérdések"][sorszam]["question"].ToString();
            Kérdéslabel.WidthRequest = 550;
            Kérdéslabel.HeightRequest = 150;

            this.Content = sztekk;
            sztekk.Children.Add(Kérdéslabel);

            Button[] Answers = new Button[5];

            for (int i = 0; i < 4; i++)
            {
                Answers[i+1] = new Button();
                Answers[i+1].HeightRequest = 70;
                Answers[i+1].WidthRequest = 550;
                Answers[i+1].Text = kérdések[i];
               // Answers[i+1].    
                Answers[i+1].Clicked += new EventHandler(this.Answers_Clicked);
                this.Content = sztekk;
                sztekk.Children.Add(Answers[i + 1]);
                
            }*/

        /*    var Labelpont = new Label();
            
            sztekk.Children.Add(Labelpont);
           Labelpont.SetBinding(Labelpont.Text, new Binding("[Player.]")); */
       
            Answer1.Text = kérdések[0];
            Answer2.Text = kérdések[1];
            Answer3.Text = kérdések[2];
            Answer4.Text = kérdések[3];

         //   lébelpontok.Text = "Pontok: " + Player.gamers[0].Points;
        }

       private void Answer1_Clicked(object sender, EventArgs e)
        {
            if(1 == Gameplay.Helyes)
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
            if (2 == Gameplay.Helyes)
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
            if (3 == Gameplay.Helyes)
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


            if (4 == Gameplay.Helyes)
            {
                Player.gamers[0].Pointincrease();
            }
            else
            {
                Player.gamers[0].PointDecrease();
            }
        }
        /*
        private void Answers_Clicked (object sender, EventArgs e)
        {
            
            Button brn = sender as Button;
            
            if ( == Gameplay.Helyes)
            {
                Player.gamers[0].Pointincrease();
                
               
            }
            else
            {
                Player.gamers[0].PointDecrease();


                lébel.Text = "f "+TesztPage1.sorszam(brn);
                
            }
        }*/
    }
}