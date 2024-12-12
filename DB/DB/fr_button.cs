using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace fr_Design
{
    public class fr_button: Control
    {
        private StringFormat SF = new StringFormat();
        public fr_button()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            
            DoubleBuffered = true;
            
            Size = new Size(100, 30);

            BackColor = Color.DarkGray;
            ForeColor = Color.White;

            SF.Alignment=StringAlignment.Center;
            SF.LineAlignment=StringAlignment.Center;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width -1, Height -1);

            graph.DrawRectangle(new Pen(BackColor), rect);
            graph.FillRectangle(new SolidBrush(BackColor), rect);

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);

        }
    }
}
