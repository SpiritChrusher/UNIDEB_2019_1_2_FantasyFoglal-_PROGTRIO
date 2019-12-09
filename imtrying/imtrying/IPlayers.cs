using System;
using System.Collections.Generic;
using System.Text;

namespace imtrying
{
    interface IPlayers
    {
         string Name
        {
            get;
            set;
        }


        int Points
        {
            get;
            set;
        }

        void Pointincrease();
        void PointDecrease();
    }
}
