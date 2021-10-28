using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOT
{
    public class ClassRobot
    {
        public int x, y;
        public int charge;
        public bool needCharge;

        public void Charge()
        {
            if (charge <= 200)
            {
                charge += 5;
            }
        }

        public void WalkTo(int toX, int toY)
        {
            if (charge > 0)
            {
                x += toX;
                y += toY;
                charge -= 1;
            }

        }
        public void FullCharge()
        {
            if (charge < 200)
            {
                charge += 1;
            }
            else
            {
                needCharge = false;
            }
        }

        



    }
}
