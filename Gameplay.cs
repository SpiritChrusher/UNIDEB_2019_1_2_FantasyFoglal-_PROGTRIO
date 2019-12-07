using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace imtrying
{
    public class Gameplay
    {

        public static List<Gameplay> Questions = new List<Gameplay>();

        public static string jsonösszes;

        static JObject Feladványok = JObject.Parse(jsonösszes);



        private int helyes;

        public int Helyes
        {
            get => helyes;
            set
            {
                helyes = value;
            }
        }


        //amilyen pályát kiválsztja a játékos (SW, LOTR)
        private string name;

        public string Name
        {
            get => name;

            set
            {
                name = value;
            }
        }

        private int maxnumber;

        public int Maxnumber
        {
            get => maxnumber;

            set
            {
                maxnumber = value;
            }
        }

        public Gameplay() { }

        public Gameplay(string név, string path )
        {
            name = név;

            Gameplay.ReadJSON(path);

            maxnumber = Gameplay.MaximumNumber(név);

            helyes = (int)Feladványok["SW"]["Kérdések"][Gameplay.RandNumber(Maxnumber)]["answer"];
        }
        
        private static void ReadJSON(string path)
        {
           jsonösszes = File.ReadAllText(path);
        }


        public static int RandNumber(int maxnumber)
        {
            Random rand = new Random();

            return rand.Next(1, maxnumber);

        }

        private static int MaximumNumber(string name)
        {

            //"SW" vagy "LOTR" majd a pályaválasztásnál lesz megadva a name attribútumnál.
            JArray tömb = (JArray)Feladványok[name]["Kérdések"];

            return tömb.Count;

        }

    }
}
