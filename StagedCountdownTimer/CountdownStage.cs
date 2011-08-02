using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StagedCountdownTimer
{
    public partial class CountdownStage : UserControl
    {
        public CountdownStage()
        {
            InitializeComponent();
            this.Invalidated += new InvalidateEventHandler(CountdownStage_Invalidated);
        }

        void CountdownStage_Invalidated(object sender, InvalidateEventArgs e)
        {
            //label5.Text = 
        }

        int _stage = 0;
        public int JourneyStage
        {
            get { return _stage; }
            set { _stage = value; label1.Text = string.Format("Stage {0}", value); }
        }

        string _departureName, _destinationName;
        public string JourneyStageDepartureName
        {
            get { return _departureName; }
            set
            {
                _departureName = value;
                label2.Text = value;
            }
        }

        public string JourneyStageDestinationName
        {
            get { return _destinationName; }
            set
            {
                _destinationName = value;
                label3.Text = value;
            }
        }

        DateTime _departureTime, _arrivalTime;
        public DateTime JourneyStageDepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; label4.Text = value.ToString(); }
        }
        public DateTime JourneyStageArrivalTime
        {
            get { return _arrivalTime; }
            set { _arrivalTime = value; label6.Text = value.ToString(); }
        }


    }
}
