using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StagedCountdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Invalidated += new InvalidateEventHandler(Form1_Invalidated);
        }

        void Form1_Invalidated(object sender, InvalidateEventArgs e)
        {
            foreach (Control item in tableLayoutPanel1.Controls)
            {
                if (item is CountdownStage)
                    ((CountdownStage)item).refresh();
            }   
        }

        private void countdownStage1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
