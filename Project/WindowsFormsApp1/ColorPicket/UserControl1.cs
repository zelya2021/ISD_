using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicket
{
    public partial class UserControl1: UserControl
    {
        public string ColorName { get; set; }
        public event EventHandler Click_UseControl;
        public UserControl1()
        {
            InitializeComponent();
        }
        private void tbColor_Scroll(object sender, EventArgs e)
        {
            int r = tbRed.Value;
            int g = tbGreen.Value;
            int b = tbBlue.Value;
            Color color = Color.FromArgb(r, g, b);
            lblColor.BackColor = color;
            ColorName = color.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Click_UseControl?.Invoke(this, e);
        }
    }
}
