using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anonymouswinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Click me";
            b.Size = new Size(100, 50);
            b.Location = new Point(357, 163);

            this.Controls.Add(b);

            b.Click += delegate (object sender1, EventArgs e1)

            {

                MessageBox.Show("Hello world!!");
            };
            b.Click += delegate (object sender2, EventArgs e2)

            {

                MessageBox.Show("Programming is fun");
            };
            b.Click += delegate (object sender3, EventArgs e3)

            {

                MessageBox.Show("This is printing");
            };
            b.Click += delegate (object sender4, EventArgs e4)

            {

                MessageBox.Show("This is printing again");

            };

            b.Click += delegate (object sender5, EventArgs e5)

            {

                MessageBox.Show("Yeyy!! This is crazy");
            };
            b.Click += delegate (object sender5, EventArgs e5)

            {

                MessageBox.Show("Yeyy!! This is printing crazy");
            };

        }
    }
}
