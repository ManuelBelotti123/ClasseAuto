using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAuto
{
    internal class AutoAut : Auto
    {
        //attributi
        private int _giri;

        //proprietà
        public int Giri
        {
            get { return _giri; }
            set { _giri = value; }
        }

        //costruttori
        public AutoAut(bool mot, double vel, int mar, int giri) : base(mot, vel, mar)
        {
            Giri = giri;
        }

        public AutoAut() : base()
        {
            Giri = 0;
        }

        //metodi
        public override int Accelera(double v)
        {
            int c = 0;
            double vel = Velocita + v;
            Giri = 1500;
            int dif = (int)Math.Round(100 * vel / 20);
            int g = Giri - dif;
            if (g < 1000)
            {
                Marcia--;
            }
            else if (g > 2000)
            {
                Marcia++;
            }
            return c;
        }
    }
}
