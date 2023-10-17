using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseAuto
{
    public partial class Form1 : Form
    {
        Auto auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Auto();
            velres.Text = "0";
            marres.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void motoreb_Click(object sender, EventArgs e)
        {
            bool a = auto.AccendeSpegne(!auto.Motore);
            if (!a)
            {
                MessageBox.Show("Portare velocità a zero e marcia in folle prima di spegnere.", "Avviso", MessageBoxButtons.OK);
            }
            else
            {
                if (auto.Motore)
                {
                    MessageBox.Show("Motore Acceso", "Avviso", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Motore Spento", "Avviso", MessageBoxButtons.OK);
                }
            }
        }

        private void velocitap_Click(object sender, EventArgs e)
        {
            if (auto.Motore)
            {
                int a = auto.Accelera(double.Parse(vel.Text));
                if (a == 3)
                {
                    MessageBox.Show("La marcia è in folle. Riprova", "Avviso", MessageBoxButtons.OK);
                }
                else if (a == 2)
                {
                    MessageBox.Show("Aumenta la marcia e riprova", "Avviso", MessageBoxButtons.OK);
                }
                else if (a == 1)
                {
                    MessageBox.Show("Scala la marcia e riprova", "Avviso", MessageBoxButtons.OK);
                }
                else
                {
                    velres.Text = auto.Velocita.ToString();
                }
            }
        }

        private void velocitam_Click(object sender, EventArgs e)
        {
            if (auto.Motore)
            {
                int a = auto.Decelera(double.Parse(vel.Text));
                if (a == 4)
                {
                    MessageBox.Show("Impossibile decelerare sotto zero. Riprova", "Avviso", MessageBoxButtons.OK);
                }
                if (a == 3)
                {
                    MessageBox.Show("La marcia è in folle. Riprova", "Avviso", MessageBoxButtons.OK);
                }
                else if (a == 2)
                {
                    MessageBox.Show("Aumenta la marcia e riprova", "Avviso", MessageBoxButtons.OK);
                }
                else if (a == 1)
                {
                    MessageBox.Show("Scala la marcia e riprova", "Avviso", MessageBoxButtons.OK);
                }
                else
                {
                    velres.Text = auto.Velocita.ToString();
                }
            }
        }

        private void aummarcia_Click(object sender, EventArgs e)
        {
            if (auto.Motore)
            {
                auto.MarciaPM(true);
                marres.Text = auto.Marcia.ToString();
            }
        }

        private void scalamar_Click(object sender, EventArgs e)
        {
            if (auto.Motore)
            {
                auto.MarciaPM(false);
                marres.Text = auto.Marcia.ToString();
            }
        }
    }
}
