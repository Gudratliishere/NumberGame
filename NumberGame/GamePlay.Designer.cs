namespace NumberGame
{
    partial class GamePlay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gtbar_score = new Guna.UI.WinForms.GunaTrackBar();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.flp_points = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_maxScore = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // gtbar_score
            // 
            this.gtbar_score.Enabled = false;
            this.gtbar_score.Location = new System.Drawing.Point(55, 31);
            this.gtbar_score.Name = "gtbar_score";
            this.gtbar_score.Size = new System.Drawing.Size(205, 71);
            this.gtbar_score.TabIndex = 0;
            this.gtbar_score.TrackColor = System.Drawing.Color.DimGray;
            this.gtbar_score.TrackHoverColor = System.Drawing.Color.Gray;
            this.gtbar_score.TrackIdleColor = System.Drawing.Color.Silver;
            this.gtbar_score.TrackPressedColor = System.Drawing.Color.Black;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(232, 31);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(19, 21);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "0";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_status.Location = new System.Drawing.Point(60, 105);
            this.lbl_status.MaximumSize = new System.Drawing.Size(200, 50);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(200, 50);
            this.lbl_status.TabIndex = 2;
            this.lbl_status.Text = "Good luck";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flp_points
            // 
            this.flp_points.Location = new System.Drawing.Point(55, 168);
            this.flp_points.Name = "flp_points";
            this.flp_points.Size = new System.Drawing.Size(205, 121);
            this.flp_points.TabIndex = 3;
            // 
            // lbl_maxScore
            // 
            this.lbl_maxScore.AutoSize = true;
            this.lbl_maxScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maxScore.Location = new System.Drawing.Point(51, 31);
            this.lbl_maxScore.Name = "lbl_maxScore";
            this.lbl_maxScore.Size = new System.Drawing.Size(105, 21);
            this.lbl_maxScore.TabIndex = 4;
            this.lbl_maxScore.Text = "Max score: 20";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.lbl_maxScore);
            this.Controls.Add(this.flp_points);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.gtbar_score);
            this.Name = "GamePlay";
            this.Size = new System.Drawing.Size(306, 326);
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTrackBar gtbar_score;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.FlowLayoutPanel flp_points;
        private System.Windows.Forms.Label lbl_maxScore;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
