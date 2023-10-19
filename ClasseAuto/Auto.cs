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
        protected bool _motore;
        protected double _velocita;
        protected int _marcia;

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
            set
            {
                if (value < 0 || value > 8)
                {
                    _marcia = 0;
                }
                else
                {
                    _marcia = value;
                }
            }
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
        public void Accende()
        {
            Motore = true;
        }

        public int Spegne()
        {
            int c = 0;
            if (Velocita == 0 && Marcia == 0)
            {
                Motore = false;
            }
            else
            {
                c = 1;
            }
            return c;
        }

        public virtual int Accelera(double v)
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

        public virtual int Decelera(double v)
        {
            int c = 0;
            double vel = Velocita - v;
            switch (Marcia)
            {
                case 1:
                    if (vel >= 0 && vel <= 20)
                    {
                        Velocita -= v;
                    }
                    else if (vel < 0)
                    {
                        c = 4;
                    }
                    else
                    {
                        c = 2;
                    }
                    break;
                case 2:
                    if (vel >= 20 && vel <= 40)
                    {
                        Velocita -= v; ;
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
                        Velocita -= v;
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
                        Velocita -= v;
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
                        Velocita -= v;
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
                        Velocita -= v;
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
                        Velocita -= v;
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
                        Velocita -= v;
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

        public void MarciaP()
        {
            if (Marcia != 8)
            {
                Marcia++;
            }
        }

        public void MarciaM()
        {
            if (Marcia != 0)
            {
                Marcia--;
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
