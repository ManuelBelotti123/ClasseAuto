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




    }
}
