﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace imtrying
{
    public class Gameplay
    {

        public static List<Gameplay> Questions = new List<Gameplay>();

        public static string jsonösszes = @"{
'SW': {
'Title': 'Star Wars',
'Kérdések': 
[
{'id': 1,
'answer': 4,
'question': 'Mi a neve a Főgonosznak?',
'answers':
  [
  '1. Luke Skywalker',
  '2. Han Solo',
  '3. Ben Kenobi',
  '4. Palpatine'
  ] 
},
{
'id': 2,
'answer': 1,
'question': 'Mi a Havas bolygó neve?',
'answers':
  [
  '1. Hoth',
  '2. Tatooine',
  '3. Korusant',
  '4. Endor'
  ] 
},
{
'id': 3,
'answer': 2,
'question': 'Kicsoda Darth Vader?',
'answers':
  [
  '1. Én',
  '2. Anakin Skywalker',
  '3. Yoda',
  '4. Mace Windoo'
  ] 
},
{
'id': 4,
'answer': 3,
'question': 'Kit csókol meg legelőször Leia?',
'answers':
  [
  '1. Han Solo-t',
  '2. Darth Vader-t',
  '3. Luke Skywalker-t',
  '4. Ben Kenobi-t'
  ] 
},
{
'id': 5,
'answer': 1,
'question': 'Ki a kiválasztott?',
'answers':
  [
  '1. Anakin Skywalker',
  '2. Darth Vader',
  '3. Obi-Wan Kenobi',
  '4. Yoda mester'
  ] 
},
{'id': 6,
'answer': 3,
'question': 'Kik az Evokok?',
'answers':
  [
  '1. Jabba alatvalói',
  '2. Fejvadászok',
  '3. Erdőben élő macik',
  '4. Hószörnyek'
  ] 
},
{'id': 7,
'answer': 3,
'question': 'Hány parsec alatt tette meg Han a Kesseli utat?',
'answers':
 [
'1. 10',
'2. 11',
'3. 12',
'4. 13'
 ]
},
{'id': 8,
'answer': 2,
'question': 'Minek a mértékegysége a parsec?',
'answers':
 [
'1. idő',
'2. távolság',
'3. tömeg',
'4. hatásfok'
 ]
},
{'id': 9,
'answer': 3,
'question': 'Hány lába van egy AT-AT-nak?',
'answers':
 [
'1. 2',
'2. 3',
'3. 4',
'4. 6'
 ]
},
{'id': 10,
'answer': 1,
'question': 'Hol forgatták a jeleneteket a Tatooin-hoz?',
'answers':
 [
'1. Tunézia',
'2. Új-Zéland',
'3. Colorado',
'4. Izland'
 ]
},
{'id': 11,
'answer': 3,
'question': 'Melyik számozott rész KÖZVETLEN előzménye a Zsivány Egyes?',
'answers':
 [
'1. A klónok támadása',
'2. A Sithek bosszúja',
'3. Egy új remény',
'4. Solo'
 ]
},
{'id': 12,
'answer': 2,
'question': 'Miért lila Windu fénykardja?',
'answers':
 [
'1. Mert ő a legerősebb fénykard forgató',
'2. Mert Samuel L Jackson így akarta',
'3. Egy különleges általa készített kristály miatt',
'4. Hiba volt a számítógépes effektezésnél'
 ]
},

{'id': 14,
'answer': 4,
'question': 'A Cody parancsnok által vezetett 212-es légiónak milyen szín díszitette a páncélját?',
'answers':
 [
'1. Piros',
'2. Kék',
'3. Zöld',
'4. Sárga'
 ]
},
{'id': 15,
'answer': 4,
'question': 'A Cody parancsnok által vezetett 212-es légiónak milyen szín díszitette a páncélját?',
'answers':
 [
'1. Piros',
'2. Kék',
'3. Zöld',
'4. Sárga'
 ]
},
{'id': 16,
'answer': 3,
'question': 'Mit mondott Birodalom visszavágban az ikonikus jelenetben Darth Vader Luke-nak?',
'answers':
 [
'1. Nem Luke! Én vagyok az apád',
'2. Én vagyok az Apád!',
'3. Nem, én vagyok az apád!',
'4. Obi Wan ölte meg az apádat!'
 ]
},
{'id':18,
'answer': 1,
'question': 'Hanyadik évad lesz a befejező évad a Klónok Háborúja animációs sorozathoz?',
'answers':
 [
'1. 7',
'2. 8',
'3. 4',
'4. 10'
 ]
}
]
},
'LOTR' :{
'Title': 'Gyűrűk Ura',
'Kérdések': 
[
{ 'id': 1,
'answer': 4,
'question': 'Mi a neve az Tündének?',
'answers':
  [
  '1. Gimli',
  '2. Frodó',
  '3. Aragorn',
  '4. Legolas'
  ] 
},
{ 
'id': 2,
'answer': 1,
'question': 'A 3. részben melyik város ostromolják az orkok?',
'answers':
  [
  '1. Gondor',
  '2. Rohan',
  '3. Vasudvard',
  '4. Sziklavár'
  ] 
}
]
}
}";

        static JObject Feladványok = JObject.Parse(jsonösszes);



        private static int helyes;

        public static int Helyes
        {
            get => helyes;
            set
            {
                helyes = value;
            }
        }

        public static bool CompareInt(int a, int b)
        {
            if (a == b)
                return true;
            else
                return false;
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
