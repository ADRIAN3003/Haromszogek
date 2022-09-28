using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
    public partial class Form1 : Form
    {
        List<DHaromszog> dHaromszogs = new List<DHaromszog>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdatokBetoltese_Click(object sender, EventArgs e)
        {
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofdMegnyitas.FileName))
                {
                    VezerlokNullazasa();
                    int sor = 1;
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            DHaromszog uj = new DHaromszog(sr.ReadLine(), sor);
                            dHaromszogs.Add(uj);
                            lbHaromszog.Items.Add(uj.ToString());
                        }
                        catch (Exception ex)
                        {
                            lbHibak.Items.Add(sor + ". sor: " + ex.Message);
                        }
                        sor++;
                    }
                }
            }
        }

        private void VezerlokNullazasa()
        {
            dHaromszogs.Clear();
            lbHibak.Items.Clear();
            lbHaromszog.Items.Clear();
            lbKerulet.Text = "";
            lbTerulet.Text = "";
        }

        private void lbHaromszog_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbHaromszog.SelectedIndex;
            if (index != -1)
            {
                lbKerulet.Text = KeruletSzoveg(index);
                lbTerulet.Text = TeruletSzoveg(index);
            }
        }

        private string KeruletSzoveg(int index)
        {
            return "Kerület = " + dHaromszogs[index].Kerulet;
        }

        private string TeruletSzoveg(int index)
        {
            return "Terület = " + dHaromszogs[index].Terulet;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            lbKerulet.Text = "";
            lbTerulet.Text = "";
        }
    }
}