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
            Giri = 0;
        }

        //metodi
        public override int Accelera(double v)
        {
            int c = 0;
            Velocita += v;
            Giri = 1500;
            int dif = (int)Math.Round(500 * Velocita / 20);
            int g = Giri + dif;
            MessageBox.Show(g.ToString());
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
        public override int Decelera(double v)
        {
            int c = 0;
            Velocita -= v;
            Giri = 1500;
            int dif = (int)Math.Round(100 * Velocita / 20);
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
