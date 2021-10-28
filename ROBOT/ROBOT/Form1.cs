using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROBOT
{
    public partial class Picture : Form
    {
        ClassRobot robot;
        public int sizeTop, sizeBottom, sizeLeft, sizeRight;

        public Picture()
        {
            InitializeComponent();
            robot = new ClassRobot();
            robot.x = panel1.Width / 2 - pictureRobot.Width / 2;
            robot.y = panel1.Height / 2 - pictureRobot.Height / 2;
            pictureRobot.Location = new Point(robot.x, robot.y);
            sizeTop = 0;
            sizeLeft = 0;
            sizeRight = panel1.Width;
            sizeBottom = panel1.Height;

        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool CheckSize(int currentSizeX, int currentSizeY)
        {
            bool good;
            if (((sizeLeft <= currentSizeX) && !(currentSizeX >= sizeRight)) && ((sizeTop <= currentSizeY) && !(currentSizeY >= sizeBottom)))
            {
                good = true;
            }
            else
            {
                good = false;
            }
            return good;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x + 0, robot.y + 5))
            {
                robot.WalkTo(0, -5);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x + 5, robot.y + 0))
            {
                robot.WalkTo(5, 0);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x + 0, robot.y + 5))
            {
                robot.WalkTo(0, 5);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x -5, robot.y + 0))
            {
                robot.WalkTo(-5, 0);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void picturerobot_Click(object sender, EventArgs e)
        {

        }

        private void buttonCharge_Click(object sender, EventArgs e)
        {
            robot.Charge();
        }

        private void buttonLeftUp_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x - 5, robot.y - 5))
            {
                robot.WalkTo(-5, -5);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void buttonLeft_Click_1(object sender, EventArgs e)
        {
            if (CheckSize(robot.x - 5, robot.y + 0))
            {
                robot.WalkTo(-5, 0);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x + 5, robot.y - 5))
            {
                robot.WalkTo(5, -5);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x + 5, robot.y + 5))
            {
                robot.WalkTo(5, 5);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = robot.charge;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckSize(robot.x - 5, robot.y + 5))
            {
                robot.WalkTo(-5, 5);
                pictureRobot.Location = new Point(robot.x, robot.y);
            }
        }

        private void buttonFullCharge_Click(object sender, EventArgs e)
        {
            robot.needCharge = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = robot.charge;
        }
        
    }
}
