using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigiClock : Form
    {
        public DigiClock()
        {
            InitializeComponent();
        }

        private void DigiClock_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(this.timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs s)
        {
            timerLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");
        }
    }
}
