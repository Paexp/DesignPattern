using System;
using System.Drawing;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black);
            PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            PersonDirector pbThin = new PersonDirector(ptb);
            pbThin.CreatePerson();

            PersonFatBuilder pfb = new PersonFatBuilder(pictureBox2.CreateGraphics(), p);
            PersonDirector pbFat = new PersonDirector(pfb);
            pbFat.CreatePerson();
        }
    }
}
