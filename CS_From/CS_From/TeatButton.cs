using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_From
{
    internal class TestButton : Button
    {
        public TestButton() 
        {
            Click += OnClick;
        }

        public virtual void OnClick(object sender, EventArgs s) 
        {
            MessageBox.Show("オーマイゴシゴシ");
        }
    }
}
