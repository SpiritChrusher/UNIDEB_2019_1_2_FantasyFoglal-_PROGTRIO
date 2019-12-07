using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace imtrying
{
   public class Player : INotifyPropertyChanged
    {
        public static List<Player> gamers = new List<Player>();

        private string email;

        private string password;

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

        public string Email
        {
            get => email;
            set
            {              
                    email = value;
            }
        }

        public string Password
        {
            get => password;
            set
            {               
                password = value;

            }
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

  /*      private int helyes;

        public int Helyes
        {
            get => helyes;

            set
            {
                if (helyes != value)
                {
                    helyes = value;
                    OnPropertyChanged("Helyes");
                }

            }
        }
        */
        private bool isTrue;
        public bool IsTrue
        {
            get => isTrue;

            set
            {
                if (isTrue != value)
                {
                    isTrue = value;
                    OnPropertyChanged("IsTrue");
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
            a.Points += 100;
        }

        public static void PointDecrease(Player a)
        {
            a.Points -= 100;
        }


        public static bool Namechecker(string a)
        {


            Regex r = new Regex(@"^[A-Z][a-z]+[ ][A-Z][a-z]+");

            bool isOkay = r.IsMatch(a);

            return isOkay;
        }

        public static bool Emailchecker(string a)
        {
            Regex r = new Regex(@"^((\w + ([-+.]\w +)*@\w + ([-.]\w +)*\.\w + ([-.]\w +)*)\s *[;]{ 0,1}\s *)+$");


            bool isOkay = r.IsMatch(a);

            return isOkay;
        }

        public static bool Passwordchecker()
        {
            bool isOkay = true;

            return isOkay;
        }



    }
}
