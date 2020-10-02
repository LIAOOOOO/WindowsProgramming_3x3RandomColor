using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_1
{
    public partial class Form1 : Form
    {
        Rectangle rect1;
        Rectangle rect2;
        Rectangle rect3;
        Rectangle rect4;
        Rectangle rect5;
        Rectangle rect6;
        Rectangle rect7;
        Rectangle rect8;
        Rectangle rect9;
        int r1, r2, r3, r4, r5, r6, r7, r8, r9;
        int g1, g2, g3, g4, g5, g6, g7, g8, g9;
        int b1, b2, b3, b4, b5, b6, b7, b8, b9;
        Random rd = new Random();
        Brush br1, br2, br3, br4, br5, br6, br7, br8, br9;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics gr1 = this.CreateGraphics();
            Graphics gr2 = this.CreateGraphics();
            Graphics gr3 = this.CreateGraphics();
            Graphics gr4 = this.CreateGraphics();
            Graphics gr5 = this.CreateGraphics();
            Graphics gr6 = this.CreateGraphics();
            Graphics gr7 = this.CreateGraphics();
            Graphics gr8 = this.CreateGraphics();
            Graphics gr9 = this.CreateGraphics();
            r1 = rd.Next(256);
            r2 = rd.Next(256);
            r3 = rd.Next(256);
            r4 = rd.Next(256);
            r5 = rd.Next(256);
            r6 = rd.Next(256);
            r7 = rd.Next(256);
            r8 = rd.Next(256);
            r9 = rd.Next(256);
            g1 = rd.Next(256);
            g2 = rd.Next(256);
            g3 = rd.Next(256);
            g4 = rd.Next(256);
            g5 = rd.Next(256);
            g6 = rd.Next(256);
            g7 = rd.Next(256);
            g8 = rd.Next(256);
            g9 = rd.Next(256);
            b1 = rd.Next(256);
            b2 = rd.Next(256);
            b3 = rd.Next(256);
            b4 = rd.Next(256);
            b5 = rd.Next(256);
            b6 = rd.Next(256);
            b7 = rd.Next(256);
            b8 = rd.Next(256);
            b9 = rd.Next(256);
            br1 = new SolidBrush(Color.FromArgb(r1, g1, b1));
            br2 = new SolidBrush(Color.FromArgb(r2, g2, b2));
            br3 = new SolidBrush(Color.FromArgb(r3, g3, b3));
            br4 = new SolidBrush(Color.FromArgb(r4, g4, b4));
            br5 = new SolidBrush(Color.FromArgb(r5, g5, b5));
            br6 = new SolidBrush(Color.FromArgb(r6, g6, b6));
            br7 = new SolidBrush(Color.FromArgb(r7, g7, b7));
            br8 = new SolidBrush(Color.FromArgb(r8, g8, b8));
            br9 = new SolidBrush(Color.FromArgb(r9, g9, b9));
            if (rect1.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr1.FillRectangle(br1, rect1);
                gr1.DrawRectangle(Pens.Black, rect1);
            }
            if (rect2.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr2.FillRectangle(br2, rect2);
                gr2.DrawRectangle(Pens.Black, rect2);
            }
            if (rect3.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr3.FillRectangle(br3, rect3);
                gr3.DrawRectangle(Pens.Black, rect3);
            }
            if (rect4.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr4.FillRectangle(br4, rect4);
                gr4.DrawRectangle(Pens.Black, rect4);
            }
            if (rect5.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr5.FillRectangle(br5, rect5);
                gr5.DrawRectangle(Pens.Black, rect5);
            }
            if (rect6.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr6.FillRectangle(br6, rect6);
                gr6.DrawRectangle(Pens.Black, rect6);
            }
            if (rect7.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr7.FillRectangle(br7, rect7);
                gr7.DrawRectangle(Pens.Black, rect7);
            }
            if (rect8.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr8.FillRectangle(br8, rect8);
                gr8.DrawRectangle(Pens.Black, rect8);
            }
            if (rect9.Contains(e.Location))
            {
                for (int i = 0; i < 10; i++)
                    gr9.FillRectangle(br9, rect9);
                gr9.DrawRectangle(Pens.Black, rect9);
            }

        }

        


        public Form1()
        {
            InitializeComponent();
            rect1 = new Rectangle(00, 0, 50, 50);
            rect2 = new Rectangle(50, 0, 50, 50);
            rect3 = new Rectangle(100, 0, 50, 50);
            rect4 = new Rectangle(0, 50, 50, 50);
            rect5 = new Rectangle(50, 50, 50, 50);
            rect6 = new Rectangle(50, 100, 50, 50);
            rect7 = new Rectangle(0, 100, 50, 50);
            rect8 = new Rectangle(100, 50, 50, 50);
            rect9 = new Rectangle(100, 100, 50, 50);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr1 = this.CreateGraphics();
            Graphics gr2 = this.CreateGraphics();
            Graphics gr3 = this.CreateGraphics();
            Graphics gr4 = this.CreateGraphics();
            Graphics gr5 = this.CreateGraphics();
            Graphics gr6 = this.CreateGraphics();
            Graphics gr7 = this.CreateGraphics();
            Graphics gr8 = this.CreateGraphics();
            Graphics gr9 = this.CreateGraphics();
            for (int i = 0; i < 10; i++)
            {
                r1 = rd.Next(256);
                r2 = rd.Next(256);
                r3 = rd.Next(256);
                r4 = rd.Next(256);
                r5 = rd.Next(256);
                r6 = rd.Next(256);
                r7 = rd.Next(256);
                r8 = rd.Next(256);
                r9 = rd.Next(256);
                g1 = rd.Next(256);
                g2 = rd.Next(256);
                g3 = rd.Next(256);
                g4 = rd.Next(256);
                g5 = rd.Next(256);
                g6 = rd.Next(256);
                g7 = rd.Next(256);
                g8 = rd.Next(256);
                g9 = rd.Next(256);
                b1 = rd.Next(256);
                b2 = rd.Next(256);
                b3 = rd.Next(256);
                b4 = rd.Next(256);
                b5 = rd.Next(256);
                b6 = rd.Next(256);
                b7 = rd.Next(256);
                b8 = rd.Next(256);
                b9 = rd.Next(256);
                br1 = new SolidBrush(Color.FromArgb(r1, g1, b1));
                br2 = new SolidBrush(Color.FromArgb(r2, g2, b2));
                br3 = new SolidBrush(Color.FromArgb(r3, g3, b3));
                br4 = new SolidBrush(Color.FromArgb(r4, g4, b4));
                br5 = new SolidBrush(Color.FromArgb(r5, g5, b5));
                br6 = new SolidBrush(Color.FromArgb(r6, g6, b6));
                br7 = new SolidBrush(Color.FromArgb(r7, g7, b7));
                br8 = new SolidBrush(Color.FromArgb(r8, g8, b8));
                br9 = new SolidBrush(Color.FromArgb(r9, g9, b9));
                gr1.FillRectangle(br1, rect1);
                gr2.FillRectangle(br2, rect2);
                gr3.FillRectangle(br3, rect3);
                gr4.FillRectangle(br4, rect4);
                gr5.FillRectangle(br5, rect5);
                gr6.FillRectangle(br6, rect6);
                gr7.FillRectangle(br7, rect7);
                gr8.FillRectangle(br8, rect8);
                gr9.FillRectangle(br9, rect9);
                e.Graphics.DrawRectangle(Pens.Black, rect1);
                e.Graphics.DrawRectangle(Pens.Black, rect2);
                e.Graphics.DrawRectangle(Pens.Black, rect3);
                e.Graphics.DrawRectangle(Pens.Black, rect4);
                e.Graphics.DrawRectangle(Pens.Black, rect5);
                e.Graphics.DrawRectangle(Pens.Black, rect6);
                e.Graphics.DrawRectangle(Pens.Black, rect7);
                e.Graphics.DrawRectangle(Pens.Black, rect8);
                e.Graphics.DrawRectangle(Pens.Black, rect9);
            }
        }
    }
}