using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IList<Animal> arrayAnimal;

        private void button1_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("咪咪");
            cat.ShoutNum = 5;
            MessageBox.Show(cat.Shout());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("旺财");
            dog.ShoutNum = 5;
            MessageBox.Show(dog.Shout());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arrayAnimal = new List<Animal>();

            arrayAnimal.Add(new Cat("小花"));
            arrayAnimal.Add(new Dog("阿毛"));
            arrayAnimal.Add(new Dog("小黑"));
            arrayAnimal.Add(new Dog("娇娇"));
            arrayAnimal.Add(new Dog("咪咪"));

            arrayAnimal.RemoveAt(1);
            arrayAnimal.RemoveAt(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Animal item in arrayAnimal)
            {
                MessageBox.Show(item.Shout());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MachineCat mcat = new MachineCat("叮当");
            StoneMonkey wukong = new StoneMonkey("孙悟空");

            IChange[] array = new IChange[2];
            array[0] = mcat;
            array[1] = wukong;

            MessageBox.Show(array[0].ChangeThing("各种各样的东西！"));
            MessageBox.Show(array[1].ChangeThing("各种各样的东西！"));
        }
    }
}
