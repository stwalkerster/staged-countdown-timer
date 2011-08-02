namespace StagedCountdownTimer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.countdownStage5 = new StagedCountdownTimer.CountdownStage();
            this.countdownStage4 = new StagedCountdownTimer.CountdownStage();
            this.countdownStage1 = new StagedCountdownTimer.CountdownStage();
            this.countdownStage2 = new StagedCountdownTimer.CountdownStage();
            this.countdownStage3 = new StagedCountdownTimer.CountdownStage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.countdownStage5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.countdownStage4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.countdownStage1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.countdownStage2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.countdownStage3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // countdownStage5
            // 
            this.countdownStage5.AutoSize = true;
            this.countdownStage5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countdownStage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countdownStage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownStage5.JourneyStage = 5;
            this.countdownStage5.JourneyStageArrivalTime = new System.DateTime(2011, 8, 2, 22, 15, 0, 0);
            this.countdownStage5.JourneyStageDepartureName = "Oxenholme Lake District";
            this.countdownStage5.JourneyStageDepartureTime = new System.DateTime(2011, 8, 2, 22, 0, 0, 0);
            this.countdownStage5.JourneyStageDestinationName = "Home";
            this.countdownStage5.Location = new System.Drawing.Point(3, 463);
            this.countdownStage5.Name = "countdownStage5";
            this.countdownStage5.Size = new System.Drawing.Size(601, 109);
            this.countdownStage5.TabIndex = 4;
            // 
            // countdownStage4
            // 
            this.countdownStage4.AutoSize = true;
            this.countdownStage4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countdownStage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countdownStage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownStage4.JourneyStage = 4;
            this.countdownStage4.JourneyStageArrivalTime = new System.DateTime(2011, 8, 2, 22, 0, 0, 0);
            this.countdownStage4.JourneyStageDepartureName = "Carstairs";
            this.countdownStage4.JourneyStageDepartureTime = new System.DateTime(2011, 8, 2, 19, 36, 0, 0);
            this.countdownStage4.JourneyStageDestinationName = "Oxenholme Lake District";
            this.countdownStage4.Location = new System.Drawing.Point(3, 348);
            this.countdownStage4.Name = "countdownStage4";
            this.countdownStage4.Size = new System.Drawing.Size(601, 109);
            this.countdownStage4.TabIndex = 3;
            // 
            // countdownStage1
            // 
            this.countdownStage1.AutoSize = true;
            this.countdownStage1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countdownStage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countdownStage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownStage1.JourneyStage = 1;
            this.countdownStage1.JourneyStageArrivalTime = new System.DateTime(2011, 8, 2, 20, 0, 0, 0);
            this.countdownStage1.JourneyStageDepartureName = "Flat";
            this.countdownStage1.JourneyStageDepartureTime = new System.DateTime(2011, 8, 2, 19, 30, 0, 0);
            this.countdownStage1.JourneyStageDestinationName = "Haymarket";
            this.countdownStage1.Location = new System.Drawing.Point(3, 3);
            this.countdownStage1.Name = "countdownStage1";
            this.countdownStage1.Size = new System.Drawing.Size(618, 109);
            this.countdownStage1.TabIndex = 0;
            this.countdownStage1.Load += new System.EventHandler(this.countdownStage1_Load);
            // 
            // countdownStage2
            // 
            this.countdownStage2.AutoSize = true;
            this.countdownStage2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countdownStage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countdownStage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownStage2.JourneyStage = 2;
            this.countdownStage2.JourneyStageArrivalTime = new System.DateTime(2011, 8, 2, 20, 30, 0, 0);
            this.countdownStage2.JourneyStageDepartureName = "Haymarket";
            this.countdownStage2.JourneyStageDepartureTime = new System.DateTime(2011, 8, 2, 20, 0, 0, 0);
            this.countdownStage2.JourneyStageDestinationName = "Carstairs";
            this.countdownStage2.Location = new System.Drawing.Point(3, 118);
            this.countdownStage2.Name = "countdownStage2";
            this.countdownStage2.Size = new System.Drawing.Size(618, 109);
            this.countdownStage2.TabIndex = 1;
            // 
            // countdownStage3
            // 
            this.countdownStage3.AutoSize = true;
            this.countdownStage3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countdownStage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countdownStage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countdownStage3.JourneyStage = 3;
            this.countdownStage3.JourneyStageArrivalTime = new System.DateTime(2011, 8, 2, 19, 30, 0, 0);
            this.countdownStage3.JourneyStageDepartureName = "Carstairs";
            this.countdownStage3.JourneyStageDepartureTime = new System.DateTime(2011, 8, 2, 19, 36, 0, 0);
            this.countdownStage3.JourneyStageDestinationName = "Carstairs";
            this.countdownStage3.Location = new System.Drawing.Point(3, 233);
            this.countdownStage3.Name = "countdownStage3";
            this.countdownStage3.Size = new System.Drawing.Size(618, 109);
            this.countdownStage3.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(642, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CountdownStage countdownStage1;
        private CountdownStage countdownStage5;
        private CountdownStage countdownStage4;
        private CountdownStage countdownStage2;
        private CountdownStage countdownStage3;
        private System.Windows.Forms.Timer timer1;
    }
}

