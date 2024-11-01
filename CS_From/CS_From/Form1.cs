using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TestButton testbutton = new TestButton(0,0,100,100);
            Controls.Add(testbutton);
            TestButton testbutton2 = new TestButton(100, 100,100,100);
            Controls.Add(testbutton2);
            TestButton testbutton3 = new TestButton(100, 0, 100, 100);
            Controls.Add(testbutton3);
            TestButton testbutton4 = new TestButton(0, 100, 100, 100);
            Controls.Add(testbutton4);
            TestButton testbutton5 = new TestButton(200, 200, 100, 100);
            Controls.Add(testbutton5);
            TestButton testbutton6 = new TestButton(0, 200, 100, 100);
            Controls.Add(testbutton6);
            TestButton testbutton7 = new TestButton(200, 0, 100, 100);
            Controls.Add(testbutton7);
            TestButton testbutton8 = new TestButton(300, 300, 100, 100);
            Controls.Add(testbutton8);
            TestButton testbutton9 = new TestButton(0, 300, 100, 100);
            Controls.Add(testbutton9);
            TestButton testbutton10 = new TestButton(300, 0, 100, 100);
            Controls.Add(testbutton10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
