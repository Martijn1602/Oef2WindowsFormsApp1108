using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oef2WindowsFormsApp1108
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        new string provincie;
        private void btnIndienen_Click(object sender, EventArgs e)
        {
            if (rbWVL.Checked)
                provincie = "West-Vlaanderen";
            else if (rbOVL.Checked)
                provincie = "Oost-Vlaanderen";
            else if (rbAntwerp.Checked)
                provincie = "Antwerpen";
            else if (rbLim.Checked)
                provincie = "Limburg";
            else if (rbHene.Checked)
                provincie = "Henegouwen";
            else if (rbVB.Checked)
                provincie = "Vlaams-Brabant";
            else if (rbWB.Checked)
                provincie = "Waals-Brabant";
            else if (rbBrussel.Checked)
                provincie = "Brussel";
            else if (rbNamen.Checked)
                provincie = "Namen";
            else if (rbLuik.Checked)
                provincie = "Luik";
            else if (rbLux.Checked)
                provincie = "Luxemburg";
            {
                //W-Vl
                if (rbMan.Checked)
                {
                    MessageBox.Show(textBox1.Text + " " + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text + Environment.NewLine + numericUpDown1.Value + Environment.NewLine + "Man" + Environment.NewLine + provincie, "Overzicht");
                }
                else
                {
                    MessageBox.Show(textBox1.Text + " " + textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text + Environment.NewLine + numericUpDown1.Value + Environment.NewLine + "Vrouw" + Environment.NewLine + provincie, "Overzicht");


                }




            }
        }
    }
}
