namespace NumberGame
{
    partial class InitGame
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
            this.pnl_body = new System.Windows.Forms.Panel();
            this.gbtn_continue = new Guna.UI.WinForms.GunaButton();
            this.gtb_maxScore = new Guna.UI.WinForms.GunaTextBox();
            this.lbl_maxScore = new System.Windows.Forms.Label();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_body
            // 
            this.pnl_body.Controls.Add(this.gbtn_continue);
            this.pnl_body.Controls.Add(this.gtb_maxScore);
            this.pnl_body.Controls.Add(this.lbl_maxScore);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 0);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(305, 281);
            this.pnl_body.TabIndex = 3;
            // 
            // gbtn_continue
            // 
            this.gbtn_continue.AnimationHoverSpeed = 0.07F;
            this.gbtn_continue.AnimationSpeed = 0.03F;
            this.gbtn_continue.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_continue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_continue.BorderColor = System.Drawing.Color.Black;
            this.gbtn_continue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_continue.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_continue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_continue.ForeColor = System.Drawing.Color.White;
            this.gbtn_continue.Image = null;
            this.gbtn_continue.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_continue.Location = new System.Drawing.Point(85, 171);
            this.gbtn_continue.Name = "gbtn_continue";
            this.gbtn_continue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_continue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_continue.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_continue.OnHoverImage = null;
            this.gbtn_continue.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_continue.Radius = 15;
            this.gbtn_continue.Size = new System.Drawing.Size(127, 31);
            this.gbtn_continue.TabIndex = 2;
            this.gbtn_continue.Text = "Continue";
            this.gbtn_continue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_continue.Click += new System.EventHandler(this.gbtn_continue_Click);
            // 
            // gtb_maxScore
            // 
            this.gtb_maxScore.BackColor = System.Drawing.Color.Transparent;
            this.gtb_maxScore.BaseColor = System.Drawing.Color.White;
            this.gtb_maxScore.BorderColor = System.Drawing.Color.Silver;
            this.gtb_maxScore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtb_maxScore.FocusedBaseColor = System.Drawing.Color.White;
            this.gtb_maxScore.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gtb_maxScore.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gtb_maxScore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gtb_maxScore.Location = new System.Drawing.Point(69, 112);
            this.gtb_maxScore.Name = "gtb_maxScore";
            this.gtb_maxScore.PasswordChar = '\0';
            this.gtb_maxScore.Radius = 15;
            this.gtb_maxScore.SelectedText = "";
            this.gtb_maxScore.Size = new System.Drawing.Size(160, 36);
            this.gtb_maxScore.TabIndex = 1;
            this.gtb_maxScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtb_maxScore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gtb_maxScore_KeyDown);
            // 
            // lbl_maxScore
            // 
            this.lbl_maxScore.AutoSize = true;
            this.lbl_maxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_maxScore.Location = new System.Drawing.Point(55, 67);
            this.lbl_maxScore.Name = "lbl_maxScore";
            this.lbl_maxScore.Size = new System.Drawing.Size(191, 25);
            this.lbl_maxScore.TabIndex = 0;
            this.lbl_maxScore.Text = "Choose max score";
            // 
            // InitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnl_body);
            this.Name = "InitGame";
            this.Size = new System.Drawing.Size(305, 281);
            this.Load += new System.EventHandler(this.InitGame_Load);
            this.pnl_body.ResumeLayout(false);
            this.pnl_body.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_body;
        private Guna.UI.WinForms.GunaTextBox gtb_maxScore;
        private System.Windows.Forms.Label lbl_maxScore;
        private Guna.UI.WinForms.GunaButton gbtn_continue;
    }
}
