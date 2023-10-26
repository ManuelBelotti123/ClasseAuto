using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Giri = 1500;
        }

        //metodi
        public override int Spegne()
        {
            int c = 0;
            if (Velocita == 0)
            {
                Motore = false;
            }
            else
            {
                c = 1;
            }
            return c;
        }

        public override int Accelera(double v)
        {
            int c = 0;
            if (Marcia <= 8)
            {
                Velocita += v;
            }
            int dif = (int)v * 25;
            Giri += dif;
            if (Giri >= 2000)
            {
                if (Marcia < 8)
                {
                    Marcia++;
                    Giri = 1500;
                }
                else
                {
                    c = 1;
                }
            }
            return c;
        }
        public override int Decelera(double v)
        {
            int c = 0;
            if (Velocita - v >= 0 && Marcia <= 8)
            {
                Velocita -= v;
            }
            else
            {
                c = 2;
                return c;
            }
            int dif = (int)v * 25;
            Giri -= dif;
            if (Giri <= 1000)
            {
                Marcia--;
                Giri = 1500;
            }
            return c;
        }
    }
}
