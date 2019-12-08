using System;
using System.Collections.Generic;
using System.Text;

namespace imtrying
{
    class Enemy : IPlayers
    {
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


        private string color;

        public string Color
        {
            get => color;

            set { color = value; }
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

          public bool IsTrue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Namechecker(string a)
        {
            throw new NotImplementedException();
        }

        public void PointDecrease()
        {
            this.Points -= 100;
        }

        public void Pointincrease()
        {
            this.Points += 100;
        }
    }
}
