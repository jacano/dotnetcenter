using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DotnetCenter
{
    public partial class ButtonItem : UserControl
    {
        public delegate void EventAction();
        private string text;
        public EventAction action;

        public enum state
        {
            normal,
            mouseOver,
            select
        }

        public new string Text
        {
            get { return text; }
            set { text = value; }
        }

        public ButtonItem(string text)
        {
            this.text = text;
            InitializeComponent();
        }

        public new void Paint(Graphics graph, LinearGradientBrush backgroundItems, SolidBrush sbBackGround, Color darkColor,
            Font font, int i, int width, state state)
        {
            Pen dark = new Pen(new SolidBrush(darkColor));

            switch (state)
            {
                case state.normal:
                    graph.FillRectangle(backgroundItems, new Rectangle(0, (i * 30), width, 30));
                    graph.DrawLine(new Pen(sbBackGround), new Point(6, ((i + 1) * 30) - 1), new Point(width - 6, ((i + 1) * 30) - 1));
                    graph.DrawString(text, font, Brushes.Black, new PointF(10, (i * 30) + 7));

                    break;
                case state.mouseOver:
                    graph.FillRectangle(backgroundItems, new Rectangle(0, (i * 30), width, 30));
                    graph.DrawLine(new Pen(sbBackGround), new Point(6, ((i + 1) * 30) - 1), new Point(width - 6, ((i + 1) * 30) - 1));
                    graph.DrawLine(dark, new Point(3, (i * 30) - 1), new Point(width, (i * 30) - 1));
                    graph.DrawLine(dark, new Point(3, (i * 30) + 29), new Point(width, (i * 30) + 29));
                    graph.DrawLine(Pens.Chocolate, new Point(1, (i * 30) + 1), new Point(1, (i * 30) + 28));
                    graph.DrawLine(Pens.Orange, new Point(2, (i * 30)), new Point(2, (i * 30) + 29));
                    graph.DrawLine(Pens.Orange, new Point(3, (i * 30) - 1), new Point(3, (i * 30) + 30));
                    graph.DrawString(text, font, Brushes.Black, new PointF(10, (i * 30) + 7));

                    break;
                case state.select:
                    graph.FillRectangle(sbBackGround, new Rectangle(0, (i * 30) - 1, width, 30));
                    graph.DrawLine(new Pen(sbBackGround), new Point(6, ((i + 1) * 30) - 1), new Point(width - 6, ((i + 1) * 30) - 1));
                    graph.DrawLine(dark, new Point(3, (i * 30) - 1), new Point(width, (i * 30) - 1));
                    graph.DrawLine(dark, new Point(3, (i * 30) + 29), new Point(width, (i * 30) + 29));
                    graph.DrawLine(Pens.Chocolate, new Point(1, (i * 30) + 1), new Point(1, (i * 30) + 28));
                    graph.DrawLine(Pens.Orange, new Point(2, (i * 30)), new Point(2, (i * 30) + 29));
                    graph.DrawLine(Pens.Orange, new Point(3, (i * 30) - 1), new Point(3, (i * 30) + 30));
                    graph.DrawString(text, font, Brushes.Black, new PointF(10, (i * 30) + 7));

                    break;
            }
        }
    }
}
