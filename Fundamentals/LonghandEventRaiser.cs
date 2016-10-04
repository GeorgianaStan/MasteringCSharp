using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public delegate void ClickHandler(object sender, EventArgs e);
    public class LonghandEventRaiser
    {
        private ClickHandler currentHandler = null;
        public void OnClick()
        {
            ClickHandler tmp = currentHandler;
            if (tmp != null)
            {
                tmp.Invoke(this, EventArgs.Empty);
            }
        }

        public event ClickHandler Click
        {
            add { currentHandler += value; }
            remove { currentHandler -= value; }
        }
    }
}
