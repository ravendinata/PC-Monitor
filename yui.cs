using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Monitor
{
    class YUI
    {
        //Animations
        public async void Fadein(Form o, int ival = 80, double step = 0.05, double finalOpacity = 1.0)
        {
            while (o.Opacity < finalOpacity)
            {
                await Task.Delay(ival);
                o.Opacity += step;
            }
            o.Opacity = finalOpacity;
        }

        public async void Fadeout(Form o, int ival = 80, double step = 0.05, double finalOpacity = 0.0)
        {
            while (o.Opacity > finalOpacity)
            {
                await Task.Delay(ival);
                o.Opacity -= step;
            }
            o.Opacity = finalOpacity;
        }
        
        //Caret and autoscroll
        public void autoscrollRichtext(RichTextBox o)
        {
            o.SelectionStart = o.Text.Length;
            o.ScrollToCaret();
        }

        //Color highlighting
        public void appendHighlightText(RichTextBox o, string str, string compareStr, Color defaultCol, Color highlightCol)
        {
            o.SelectionStart = o.TextLength;
            o.SelectionLength = 0;

            if (str == compareStr)
                o.SelectionColor = highlightCol;
            else
                o.SelectionColor = defaultCol;

            o.AppendText(str);
        }
    }
}
