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
        public bool AccendeSpegne(bool a)
        {
            bool c = true;
            if (a)
            {
                Motore = true;
            }
            else
            {
                if (Velocita == 0 && Marcia == 0)
                {
                    Motore = false;
                }
                else
                {
                    c = false;
                }
            }
            return c;
        }

        public int Accelera(double v)
        {
            int c = 0;
            double vel = Velocita + v;
            switch (Marcia)
            {
                case 1:
                    if (vel >= 0 && vel <= 20)
                    {
                        Velocita += v;
                    }
                    else
                    {
                        c = 2;
                    }
                    break;
                case 2:
                    if (vel >= 20 && vel <= 40)
                    {
                        Velocita += v; ;
                    }
                    else if (vel < 20)
                    {
                        c = 1; //scala marcia
                    }
                    else
                    {
                        c = 2;//aumenta marcia
                    }
                    break;
                case 3:
                    if (vel >= 40 && vel <= 60)
                    {
                        Velocita += v;
                    }
                    else if (vel < 40)
                    {
                        c = 1; //scala marcia
                    }
                    else
                    {
                        c = 2;//aumenta marcia
                    }
                    break;
                case 4:
                    if (vel >= 60 && vel <= 80)
                    {
                        Velocita += v;
                    }
                    else if (vel < 40)
                    {
                        c = 1; //scala marcia
                    }
                    else
                    {
                        c = 2;//aumenta marcia
                    }
                    break;
                case 5:
                    if (vel >= 80 && vel <= 100)
                    {
                        Velocita += v;
                    }
                    else if (vel < 40)
                    {
                        c = 1; //scala marcia
                    }
                    else
                    {
                        c = 2;//aumenta marcia
                    }
                    break;
                case 6:
                    if (vel >= 100 && vel <= 140)
                    {
                        Velocita += v;
                    }
                    else if (vel < 40)
                    {
                        c = 1; //scala marcia
                    }
                    else
                    {
                        c = 2;//aumenta marcia
                    }
                    break;
                case 7:
                    if (vel >= 140 && vel <= 160)
                    {
                        Velocita += v;
                    }
                    else if (vel < 40)
                    {
                        c = 1; //scala marcia
                    }
                    else
                    {
                        c = 2;//aumenta marcia
                    }
                    break;
                case 8:
                    if (vel >= 180)
                    {
                        Velocita += v;
                    }
                    else
                    {
                        c = 1;
                    }
                    break;
                case 0:
                    c = 3;
                    break;
            }
            return c;
        }

        public bool Decelera(double v)
        {
            bool c = true;
            double vel = Velocita - v;
            switch (Marcia)
            {
                case 1:
                    if (vel >= 0 && vel <= 20)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 2:
                    if (vel >= 20 && vel <= 40)
                    {
                        Velocita -= v; ;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 3:
                    if (vel >= 41 && vel <= 60)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 4:
                    if (vel >= 61 && vel <= 80)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 5:
                    if (vel >= 81 && vel <= 100)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 6:
                    if (vel >= 101 && vel <= 140)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 7:
                    if (vel >= 141 && vel <= 160)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 8:
                    if (vel >= 181)
                    {
                        Velocita -= v;
                    }
                    else
                    {
                        c = false;
                    }
                    break;
                case 0:
                    c = false;
                    break;
            }
            return c;
        }

        public void MarciaPM(bool m)
        {
            if (Marcia < 8)
            {
                if (m)
                {
                    Marcia++;
                }
                else
                {
                    Marcia--;
                }
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
