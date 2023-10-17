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
                bool a = auto.AcceleraDecelera(double.Parse(vel.Text), true);
                if (!a)
                {
                    MessageBox.Show("Aumenta marcia e riprova", "Avviso", MessageBoxButtons.OK);
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
                bool a = auto.AcceleraDecelera(double.Parse(vel.Text), false);
                if (!a)
                {
                    MessageBox.Show("Scala marcia e riprova", "Avviso", MessageBoxButtons.OK);
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
