using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_From
{
    internal class TestButton : Button
    {
        Form1 _form1;
        string[] strs =
            {
                "スプリンタートレノ",
                "スターレット",
                "クレスタ",
                "マークⅡ",
                "アルテッツァ",
                "チェイサー",
                "セリカ",
                "スープラ",
                "カローラレビン",
                "MR2"
            };
        public TestButton(Form1 form1,int id,int x,int y,int width, int height) 
        {
            _form1 = form1;

            Click += OnClick;
            
            Text = strs[id];

            Location = new Point(x,y);

            Size = new Size(width,height);
        }

        public void OnClick(object sender, EventArgs s)
        {
           
            string buttontext = Text;
            string texBoxText = _form1._textBox.Text;
            Text = texBoxText;
            _form1._textBox.Text = buttontext;


        }
        //public void OnClick(object sender, EventArgs s) 
        //{
        //    _form1.LavelTextUpdate(Text);
        //}
    }
}
