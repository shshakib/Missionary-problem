using System;
using System.Collections.Generic;
using System.Text;

namespace Missoner
{
    public class Class1
    {
        public int Missionary = -1;
        public int Barbarian = -1;
        public int Boat = -1;

        public Class1()
        {
            //throw new System.NotImplementedException();
            Barbarian = -1;
            Missionary = -1;
            Boat = -1;
        }

        public Boolean Isanswer()
        {
            if (Barbarian == 0 & Missionary == 0 & Boat == 0)
                return true;
            else
                return false;
        }

        public Boolean Ispassible()
        {
            if ((((Barbarian > Missionary) & Missionary != 0) || Barbarian < 0 || Missionary < 0 || Barbarian > 3 || Missionary > 3))
            {
                return false;
            }
            else if (3 - Barbarian > 3 - Missionary & Missionary != 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
