using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FiringRange.EXE.v1
{
    public partial class Form1 : Form
    {
        int playerScore = 0;
        int target;

        SoundPlayer boom = new SoundPlayer(Properties.Resources.wingmanShooting);

        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            Randomize();

            
        }

        public void Randomize()
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            int computerRandom = randGen.Next(1, 7);
            target = computerRandom;


            if (target == 1)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
            }
            else if (target < computerRandom || target > computerRandom)
            {
                Application.Exit();
            }

            if (target == 2)
            {
                target2.BackColor = Color.DodgerBlue;
                target2.ForeColor = Color.AliceBlue;
            }
            else if (target < computerRandom || target > computerRandom)
            {
                Application.Exit();
            }

            if (target == 3)
            {
                target3.BackColor = Color.DodgerBlue;
                target3.ForeColor = Color.AliceBlue;
            }
            else if (target < computerRandom || target > computerRandom)
            {
                Application.Exit();
            }

            if (target == 4)
            {
                target4.BackColor = Color.DodgerBlue;
                target4.ForeColor = Color.AliceBlue;
            }
            else if (target < computerRandom || target > computerRandom)
            {
                Application.Exit();
            }

            if (target == 5)
            {
                target5.BackColor = Color.DodgerBlue;
                target5.ForeColor = Color.AliceBlue;
            }
            else if (target < computerRandom || target > computerRandom)
            {
                Application.Exit();
            }

            if (target == 6)
            {
                target6.BackColor = Color.DodgerBlue;
                target6.ForeColor = Color.AliceBlue;
            }
            else if (target < computerRandom || target > computerRandom)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void target1_Click(object sender, EventArgs e)
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            boom.Play();

            if (target == 1)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
                Randomize();
            }
            else
            {
                Application.Exit();
            }
        }

        private void target2_Click(object sender, EventArgs e)
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            boom.Play();

            if (target == 2)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
                Randomize();
            }
            else
            {
                Application.Exit();
            }
        }

        private void target3_Click(object sender, EventArgs e)
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            boom.Play();

            if (target == 3)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
                Randomize();
            }
            else
            {
                Application.Exit();
            }
        }

        private void target4_Click(object sender, EventArgs e)
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            boom.Play();

            if (target == 4)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
                Randomize();
            }
            else
            {
                Application.Exit();
            }
        }

        private void target5_Click(object sender, EventArgs e)
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            boom.Play();

            if (target == 5)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
                Randomize();
            }
            else
            {
                Application.Exit();
            }
        }

        private void target6_Click(object sender, EventArgs e)
        {
            target1.BackColor = Color.Red;
            target1.ForeColor = Color.LightCoral;
            target2.BackColor = Color.Red;
            target2.ForeColor = Color.LightCoral;
            target3.BackColor = Color.Red;
            target3.ForeColor = Color.LightCoral;
            target4.BackColor = Color.Red;
            target4.ForeColor = Color.LightCoral;
            target5.BackColor = Color.Red;
            target5.ForeColor = Color.LightCoral;
            target6.BackColor = Color.Red;
            target6.ForeColor = Color.LightCoral;

            boom.Play();

            if (target == 6)
            {
                target1.BackColor = Color.DodgerBlue;
                target1.ForeColor = Color.AliceBlue;
                Randomize();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
