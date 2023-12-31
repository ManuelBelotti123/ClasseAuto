﻿using System;
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
        AutoAut aut;
        bool b;
        public Form1()
        {
            InitializeComponent();
            b = false;
            velres.Text = "0";
            marres.Text = "0";
            girires.Visible = false;
            label4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void motoreb_Click(object sender, EventArgs e)
        {
            if (!b)
            {
                if (!auto.Motore)
                {
                    auto.Accende();
                    MessageBox.Show("Motore Acceso", "Avviso", MessageBoxButtons.OK);
                }
                else
                {
                    int c = auto.Spegne();
                    if (c == 1)
                    {
                        MessageBox.Show("Portare velocità a zero e marcia in folle prima di spegnere.", "Avviso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Motore Spento", "Avviso", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (!aut.Motore)
                {
                    aut.Accende();
                    aut.Marcia = 1;
                    MessageBox.Show("Motore Acceso", "Avviso", MessageBoxButtons.OK);
                }
                else
                {
                    int c = aut.Spegne();
                    if (c == 1)
                    {
                        MessageBox.Show("Portare velocità a zero prima di spegnere.", "Avviso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        aut.Marcia = 0;
                        MessageBox.Show("Motore Spento", "Avviso", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void velocitap_Click(object sender, EventArgs e)
        {
            if (!b)
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
            else
            {
                if (aut.Motore)
                {
                    int c = aut.Accelera(double.Parse(vel.Text));
                    if (c == 1)
                    {
                        MessageBox.Show("Limite di marcia raggiunto", "Avviso");
                    }
                    else
                    {
                        marres.Text = aut.Marcia.ToString();
                        velres.Text = aut.Velocita.ToString();
                        girires.Text = aut.Giri.ToString();
                    }
                }
            }
        }

        private void velocitam_Click(object sender, EventArgs e)
        {
            if (!b)
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
            else
            {
                if (aut.Motore)
                {
                    int c = aut.Decelera(double.Parse(vel.Text));
                    if (c == 2)
                    {
                        MessageBox.Show("Valore impossibile di velocita", "Avviso");
                    }
                    marres.Text = aut.Marcia.ToString();
                    velres.Text = aut.Velocita.ToString();
                    girires.Text = aut.Giri.ToString();
                }
            }
        }

        private void aummarcia_Click(object sender, EventArgs e)
        {
            if (auto.Motore)
            {
                auto.MarciaP();
                marres.Text = auto.Marcia.ToString();
            }
        }

        private void scalamar_Click(object sender, EventArgs e)
        {
            if (auto.Motore)
            {
                auto.MarciaM();
                marres.Text = auto.Marcia.ToString();
            }
        }

        private void manuale_Click(object sender, EventArgs e)
        {
            b = false;
            auto = new Auto();
            aummarcia.Visible = true;
            scalamar.Visible = true;
            girires.Visible = false;
            label4.Visible = false;
            marres.Text = auto.Marcia.ToString();
            velres.Text = auto.Velocita.ToString();
        }

        private void automatico_Click(object sender, EventArgs e)
        {
            b = true;
            aut = new AutoAut();
            aummarcia.Visible = false;
            scalamar.Visible = false;
            girires.Visible = true;
            label4.Visible = true;
            marres.Text = aut.Marcia.ToString();
            velres.Text = aut.Velocita.ToString();
            girires.Text = aut.Giri.ToString();
        }
    }
}   