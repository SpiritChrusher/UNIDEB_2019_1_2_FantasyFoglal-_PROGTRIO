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
  'Luke Skywalker',
  'Han Solo',
  'Ben Kenobi',
  'Palpatine'
  ] 
},
{
'id': 2,
'answer': 1,
'question': 'Mi a Havas bolygó neve?',
'answers':
  [
  'Hoth',
  'Tatooine',
  'Korusant',
  'Endor'
  ] 
},
{
'id': 3,
'answer': 2,
'question': 'Kicsoda Darth Vader?',
'answers':
  [
  'Én',
  'Anakin Skywalker',
  'Yoda',
  'Mace Windoo'
  ] 
},
{
'id': 4,
'answer': 3,
'question': 'Kit csókol meg legelőször Leia?',
'answers':
  [
  'Han Solo-t',
  'Darth Vader-t',
  'Luke Skywalker-t',
  'Ben Kenobi-t'
  ] 
},
{
'id': 5,
'answer': 1,
'question': 'Ki a kiválasztott?',
'answers':
  [
  'Anakin Skywalker',
  'Darth Vader',
  'Obi-Wan Kenobi',
  'Yoda mester'
  ] 
},
{'id': 6,
'answer': 3,
'question': 'Kik az Evokok?',
'answers':
  [
  'Jabba alatvalói',
  'Fejvadászok',
  'Erdőben élő macik',
  'Hószörnyek'
  ] 
},
{'id': 7,
'answer': 3,
'question': 'Hány parsec alatt tette meg Han a Kesseli utat?',
'answers':
 [
'10',
'11',
'12',
'13'
 ]
},
{'id': 8,
'answer': 2,
'question': 'Minek a mértékegysége a parsec?',
'answers':
 [
'idő',
'távolság',
'tömeg',
'hatásfok'
 ]
},
{'id': 9,
'answer': 3,
'question': 'Hány lába van egy AT-AT-nak?',
'answers':
 [
'2',
'3',
'4',
'6'
 ]
},
{'id': 10,
'answer': 1,
'question': 'Hol forgatták a jeleneteket a Tatooin-hoz?',
'answers':
 [
'Tunézia',
'Új-Zéland',
'Colorado',
'Izland'
 ]
},
{'id': 11,
'answer': 3,
'question': 'Melyik számozott rész KÖZVETLEN előzménye a Zsivány Egyes?',
'answers':
 [
'A klónok támadása',
'A Sithek bosszúja',
'Egy új remény',
'Solo'
 ]
},
{'id': 12,
'answer': 2,
'question': 'Miért lila Windu fénykardja?',
'answers':
 [
'Mert ő a legerősebb fénykard forgató',
'Mert Samuel L Jackson így akarta',
'Egy különleges általa készített kristály miatt',
'Hiba volt a számítógépes effektezésnél'
 ]
},
{'id': 13,
'answer': 1,
'question': 'Melyik helyszínre utal Obi Wan amikor az Univerzum leghitvánabb söpredékének gyülekezőhelyére utal?',
'answers':
 [
'Mos Eisley',
'Coruscant',
'Blaha Lújza tér',
'Cato Neimoidia'
 ]
},
{'id': 14,
'answer': 4,
'question': 'A Cody parancsnok által vezetett 212-es légiónak milyen szín díszitette a páncélját?',
'answers':
 [
'Piros',
'Kék',
'Zöld',
'Sárga'
 ]
},
{'id': 15,
'answer': 4,
'question': 'A Cody parancsnok által vezetett 212-es légiónak milyen szín díszitette a páncélját?',
'answers':
 [
'Piros',
'Kék',
'Zöld',
'Sárga'
 ]
},
{'id': 16,
'answer': 3,
'question': 'Mit mondott valójában Birodalom visszavágban az ikonikus jelenetben Darth Vader Luke-nak?',
'answers':
 [
'Nem Luke! Én vagyok az apád',
'Én vagyok az Apád!',
'Nem, én vagyok az apád!',
'Obi Wan ölte meg az apádat!'
 ]
},
{'id':17,
'answer': 1,
'question': 'Miután a Disney tulajdonába került a Star Wars franchise, a filmeken és a Klónok Háborúján kívül minden mást eltörölt kánonnak, 
hogy hívja ezeket a műveket?',
'answers':
 [
'Legends',
'Expanded Universe!',
'Stories!',
'Lies, deception'
 ]
},
{'id':18,
'answer': 1,
'question': 'Hanyadik évad lesz a hamarosan érkező befejező évad a Klónok Háborúja animációs sorozathoz?',
'answers':
 [
'7',
'8!',
'4!',
'10'
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
  'Gimli',
  'Frodó',
  'Aragorn',
  'Legolas'
  ] 
},
{ 
'id': 2,
'answer': 1,
'question': 'A 3. részben melyik város ostromolják az orkok?',
'answers':
  [
  'Gondor',
  'Rohan',
  'Vasudvard',
  'Sziklavár'
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
