using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trki
{
    public partial class Form1 : Form
    {
        bool tipkaGor, tipkaDol, tipkaLevo, tipkaDesno;
        int premik = 10;

        private void spustimoTipko(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tipkaGor = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                tipkaDol = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                tipkaLevo = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                tipkaDesno = false;
            }
        }

        private void pritisnemoTipko(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tipkaGor = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                tipkaDol = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                tipkaLevo = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                tipkaDesno = true;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// preverimo ali se zelen kvadrat prekriva s katerim rumenim
        /// </summary>
        private void PreverimoPrekrivanje()
        {
            // pregled nad prekrivanjem
            foreach (Control element in Controls)
            {
                if (element is PictureBox && (string)element.Tag == "rumen")
                {

                    // ob prekrivanju kvadratov, barvo rumenega nastavimo na rdečo
                    if (kvadratZ.Bounds.IntersectsWith(element.Bounds))
                    {
                        element.BackColor = Color.Red;
                    }

                    // barva rumenegakvadrata se ne spremeni
                    else
                    {
                        element.BackColor = Color.Yellow;
                    }
                }
            }
        }

        /// <summary>
        /// Premikanje Zelenega kvadrata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tipkaDol == true && kvadratZ.Bottom < this.Height)
            {
                kvadratZ.Top += premik;
            }

            if (tipkaLevo == true && kvadratZ.Left > 0)
            {
                kvadratZ.Left -= premik;
            }

            if (tipkaDesno == true && kvadratZ.Right < this.Width)
            {
                kvadratZ.Left += premik;
            }

            if (tipkaGor == true && kvadratZ.Top > 0)
            {
                kvadratZ.Top -= premik;
            }
            PreverimoPrekrivanje();

        }
    }
}
