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

        public bool AcceleraDecelera(double v, bool ad)
        {
            bool c = true;
            double vel = Velocita + v;
            if (Velocita < v && !ad)
            {
                c = false;
            }
            else
            {
                switch (Marcia)
                {
                    case 1:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 2:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 3:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 4:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 5:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 6:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 7:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                    case 8:
                        if (vel <= 0 || vel >= 20)
                        {
                            c = false;
                        }
                        else
                        {
                            if (ad)
                            {
                                Velocita += v;
                            }
                            else
                            {
                                Velocita -= v;
                            }
                        }
                        break;
                }
            }
            return c;
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
