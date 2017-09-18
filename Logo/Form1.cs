using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logo
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

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            formGraphics.DrawEllipse(drawPen, 100, 100, 200, 200);
            formGraphics.FillEllipse(drawBrush, 100, 100, 200, 200);

            Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Arial", 26, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.White);
            fg.DrawString("Rams", drawFont, drawBrush2, 200, 180);

            Graphics fg2 = this.CreateGraphics();
            Font drawFont2 = new Font("Ubuntu", 180, FontStyle.Bold);
            SolidBrush drawBrush3 = new SolidBrush(Color.White);
            fg.DrawString("c", drawFont2, drawBrush3, 100, 50);

            fg.TranslateTransform(350, 100);
            fg.RotateTransform(90);
            fg.DrawString("Central Rams", drawFont, drawBrush, new Rectangle());
            fg.ResetTransform();
        }
    }
}
