using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ClasseAuto
{
    internal class Auto
    {
        //attributi
        private bool _motore;
        private double _velocita;
        private int _marcia;

        //proprietà
        public bool Motore
        {
            get { return _motore; }
            set { _motore = value; }
        }
        public double Velocita
        {
            get { return _velocita; }
            set { _velocita = value; }
        }
        public int Marcia
        {
            get { return _marcia; }
            set { _marcia = value; }
        }

        //costruttori
        public Auto(bool mot, double vel, int mar)
        {
            Motore = mot;
            Velocita = vel;
            Marcia = mar;
        }
        public Auto()
        {
            Motore = false;
            Velocita = 0;
            Marcia = 0;
        }

        //metodi
        public int AccendeSpegne(bool a)
        {
            if (a)
            {
                Motore = true;
                return 0;
            }
            else
            {
                if (Velocita == 0 && Marcia == 0)
                {
                    Motore = false;
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public void AcceleraDecelera(double v, bool ad)
        {
            double vel = Velocita + v;
            switch (Marcia)
            {

            }
        }
    }
}

/*
 tabella marcie
folle -> zero
1 -> 0 - 20 kmh
2 -> 20 - 40 kmh
3 -> 40 - 60 kmh
4 -> 60 - 80 kmh
5 -> 80 - 100 kmh
6 -> 100 - 140 kmh
7 -> 140 - 180 kmh
8 -> 180 e superiore kmh
*/
