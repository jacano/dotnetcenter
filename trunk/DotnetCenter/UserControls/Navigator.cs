using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DotnetCenter
{
    public partial class Navigator : UserControl
    {
        private List<ButtonItem> items;
        private Graphics graph;
        private Color backColor;
        private Color lightColor;
        private Color darkColor;
        private Color itemsColor;
        private SolidBrush sbBackItems;
        private SolidBrush sbBackGround;
        private LinearGradientBrush backgroundItems;
        private Font font;
        private int selectIndex;
        private int overIndex;

        #region Properties
        public int SelectIndex
        {
            get { return selectIndex; }
            set
            {
                selectIndex = value;
                Invalidate();
            }
        }

        public int OverIndex
        {
            set
            {
                overIndex = value;
                Invalidate();
            }
        }

        [CategoryAttribute("NavigatorProperties")]
        public Color ItemsColor
        {
            get { return itemsColor; }
            set
            {
                itemsColor = value;
                sbBackItems = new SolidBrush(itemsColor);
                Invalidate();
            }
        }

        [CategoryAttribute("NavigatorProperties")]
        public Color BackGroundColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                sbBackGround = new SolidBrush(backColor);
                Invalidate();
            }
        }

        public List<ButtonItem> Items
        {
            get { return items; }
        }

        #endregion

        #region Initialize
        public Navigator()
        {
            InitializeComponent();
            Initialize();
            SetStyle(ControlStyles.Opaque, true);
        }

        private void Initialize()
        {
            items = new List<ButtonItem>();
            BackGroundColor = Color.White;
            ItemsColor = Color.LightGray;
            font = new Font(new Font("Courier", 10), FontStyle.Regular);
            selectIndex = 0;
        }


        #endregion

        #region Paint
        protected override void OnPaint(PaintEventArgs pe)
        {
            //Initialize Values
            graph = this.CreateGraphics();
            lightColor = Color.FromArgb(itemsColor.R + (int)((float)(255 - itemsColor.R) / 1.5f),
                    itemsColor.G + (int)((float)(255 - itemsColor.G) / 1.5f),
                    itemsColor.B + (int)((float)(255 - itemsColor.B) / 1.5f));
            darkColor = Color.FromArgb(itemsColor.R - (int)((float)(255 - itemsColor.R) / 1.5f),
                    itemsColor.G - (int)((float)(255 - itemsColor.G) / 1.5f),
                    itemsColor.B - (int)((float)(255 - itemsColor.B) / 1.5f));

            backgroundItems = new LinearGradientBrush(
                new Point(0, Height / 2), new Point(Width, Height / 2), lightColor, itemsColor);

            //Items
            int i;
            for (i = 0; i < items.Count; i++)
            {
                ButtonItem.state itemState = ButtonItem.state.normal;
                if (selectIndex == i)
                    itemState = ButtonItem.state.select;
                else
                {
                    if (overIndex == i)
                        itemState = ButtonItem.state.mouseOver;
                }

                items[i].Paint(graph, backgroundItems, sbBackGround, darkColor, font, i, Width, itemState);
            }

            //BackGround
            graph.FillRectangle(sbBackGround, new Rectangle(0, i * 30, Width, Height));

            //Triangle
            Point[] points = { new Point(0, i * 30), new Point(Width - 1, i * 30), new Point(Width - 1, (i + 1) * 30) };
            graph.FillPolygon(backgroundItems, points);

            //Border
            Point[] border = { new Point(0, 0), points[0], points[2], points[1], new Point(Width - 1, 0) };
            Pen dark = new Pen(new SolidBrush(darkColor));
            graph.DrawPolygon(dark, border);
            graph.DrawRectangle(dark, new Rectangle(0,0,Width-1, Height-1));
        }


        #endregion

        #region Mouse
        private void Navigator_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < items.Count; i++)
            {
                int y = (i * 30);
                if ((e.Y > y) && (e.Y < (y + 30)))
                {
                    SelectIndex = i;
                    if (items[i].action != null)
                        items[i].action.Invoke();
                    break;
                }
            }
        }

        private void Navigator_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < items.Count; i++)
            {
                int y = (i * 30);
                if ((e.Y > y) && (e.Y < (y + 30)))
                {
                    if (overIndex != i)
                        OverIndex = i;
                    break;
                }
            }
        } 

        private void Navigator_MouseLeave(object sender, EventArgs e)
        {
            OverIndex = -1;
        }

        #endregion
    }
}
