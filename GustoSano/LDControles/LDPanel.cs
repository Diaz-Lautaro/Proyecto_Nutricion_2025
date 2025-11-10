using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GustoSano.LDControles
{
    internal class LDPanel : Panel
    {
        // Fields
        private int borderRadius = 30;
        private float gradientAngle = 90f;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;

        // Constructor
        public LDPanel()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }


        // Properties

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; this.Invalidate(); }
        }
        public float GradientAngle
        {
            get => gradientAngle;
            set { gradientAngle = value; this.Invalidate(); }
        }
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set { gradientTopColor = value; this.Invalidate(); }
        }
        public Color GradientBottomColor
        {
            get => gradientBottomColor;
            set { gradientBottomColor = value; this.Invalidate(); }
        }

        // Methods

        private GraphicsPath GetLDPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();

            return path;
        }

        // Overriden Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Gradient 
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushLD = new LinearGradientBrush(this.ClientRectangle, this.gradientTopColor, this.gradientBottomColor, this.GradientAngle);
            Graphics graphicsLD = e.Graphics;
            graphicsLD.FillRectangle(brushLD, ClientRectangle);

            // BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetLDPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}
