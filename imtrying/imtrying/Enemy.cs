using System;
using System.Collections.Generic;
using System.Text;

namespace imtrying
{
    class Enemy : IPlayers
    {
        private static List<string> Names = new List<string>() { "Charles", "Gilbert", "Simon", "George", "Brittany", "James", "Heather" };



        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (!value.Equals(null))
                {
                    name = value;
                }
                else
                {
                    name = "Horváth Jenő";
                }

            }
        }


        private int points;

        public int Points
        {
            get => points;

            set
            {
                points = value;
            }
        }


        public Enemy()
        {
            name = Enemy.NameGenerate();
            points = 0;
        }

        public bool IsTrue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public void PointDecrease()
        {
            this.Points -= 100;
        }

        public void Pointincrease()
        {
            this.Points += 100;
        }

        static string NameGenerate()
        {
            Random rand = new Random();

            int number = rand.Next(0, Names.Count - 1);

            return Names[number];
        }

        public int SelfAnswer()
        {
            Random rand = new Random();

            return rand.Next(1, 4);
        }
    }
}
