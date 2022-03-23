using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ukol2
{
    public partial class Form1 : Form
    {
        Auto auto;

        public Form1()
        {
            InitializeComponent();
        }

        private void vytvorit_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_znacka.Text == "" || textBox_spotreba.Text == "")
                {
                    MessageBox.Show("Zadej správné hodnoty!", "Error");
                }
                else
                {
                    auto = new Auto(textBox_znacka.Text, Convert.ToInt32(textBox_spotreba.Text));
                    MessageBox.Show("Auto bylo úspěšně vytvořeno!");

                    info.Visible = true;
                    rozjet.Visible = true;
                    zastavit.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Zadej správné hodnoty!", "Error");
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(auto.ToString());
        }

        private void rozjet_Click(object sender, EventArgs e)
        {
            auto.Rozjeď();

            rozjezd.Text = Convert.ToString(auto.Rozjeď().ToString("HH:mm:ss"));
        }

        private void zastavit_Click(object sender, EventArgs e)
        {
            auto.Zastav();

            doba.Text = Convert.ToString(Math.Round(auto.Zastav().TimeOfDay.TotalHours, 3)) + " h";
            kilometry.Text = Convert.ToString(Math.Round(auto.VratUjeteKm(), 2)) + " km";
            spotreba.Text = Convert.ToString(Math.Round(auto.CelkováSpotřeba(), 2)) + " l";
        }
    }
}
