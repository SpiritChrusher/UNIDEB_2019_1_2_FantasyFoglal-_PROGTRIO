using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Shapes;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Programom
{
    /// <summary>
    /// Interaction logic for Questions.xaml
    /// </summary>
    public partial class Questions : Window
    {

        
       

        static string jsonösszes = File.ReadAllText("sw.json");

        static JObject Feladványok = JObject.Parse(jsonösszes);

        /*  private static int szamgenerator()
          {
              Random rand = new Random();

              //   var tömb = Feladványok["SW"]["Kérdések"][3]["id"];


              int szam = rand.Next(1, 17);// tömb.Count());
              return szam;
          } */

        static Random rand = new Random(); 
         ///Questions.szamgenerator();

        

     /*   private static List<String> feltölt(List<String> a)
        {
            a = Feladványok["SW"]["Kérdések"][sorszam]["answers"].Select(x => (string)x).ToList();
            return a;
        }*/

        public Questions()
        {

            InitializeComponent();
            //  feltölt(kérdések);
            int sorszam = rand.Next(1, 17);
            List<String> kérdések = Feladványok["SW"]["Kérdések"][sorszam]["answers"].Select(x => (string)x).ToList(); // new List<string>();

           // int megoldas = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];

            Player.gamers[0].Helyes = (int)Feladványok["SW"]["Kérdések"][sorszam]["answer"];  //megoldas;

            testquestion.Text = Feladványok["SW"]["Kérdések"][sorszam]["question"].ToString();
            Button1.Content = kérdések[0];
            Button2.Content = kérdések[1];
            Button3.Content = kérdések[2];
            Button4.Content = kérdések[3];
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            int a = 4;
            if(a == Player.gamers[0].Helyes)
            {
                Player.Pointincrease(Player.gamers[0]);
                 Player.gamers[0].Points += 10;
                this.Close();
            }
            else
            {
                Player.gamers[0].Points -= 10;
                this.Close(); }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            int a = 3;
            if (a == Player.gamers[0].Helyes)
            {
                Player.Pointincrease(Player.gamers[0]);
               Player.gamers[0].Points += 10;
                this.Close();
            }
            else {
                Player.gamers[0].Points -= 10;
                this.Close(); }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            int a = 2;
            if (a == Player.gamers[0].Helyes)
            {
                Player.Pointincrease(Player.gamers[0]);
                 Player.gamers[0].Points += 10;
                this.Close();
            }
            else {
                Player.gamers[0].Points -= 10;
                this.Close(); }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            int a = 1;
            if (a == Player.gamers[0].Helyes)
            {
                Player.Pointincrease(Player.gamers[0]);
                Player.gamers[0].Points += 10;

                this.Close();
            }
            else {
                Player.gamers[0].Points -= 10;
                this.Close(); }
        }
    }
}
