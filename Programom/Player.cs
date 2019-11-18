using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace Programom
{
   public class Player : INotifyPropertyChanged
    {
        public static List<Player> gamers = new List<Player>();
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


        


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int points;

        public int Points
        {
            get => points;
            
            set
            {
                if (points != value)
                {
                    points = value;
                    OnPropertyChanged("Points");
                }

            }
        }

        public Player() { points = 0; } 

        public Player(string nev, string szin)
        {
            name = nev;
            color = szin;
            points = 0;
        }

        public static void Pointincrease(Player a)
        {
            a.points += 100;
        }




    }
}
