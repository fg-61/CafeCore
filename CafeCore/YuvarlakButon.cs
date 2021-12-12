using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ShapedButton
{
    class YuvarlakButon : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new System.Drawing.Rectangle(new System.Drawing.Point(), this.Size));
            this.Region = new System.Drawing.Region(gp);

            
        }
    }
}