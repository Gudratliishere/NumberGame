namespace NumberGame
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gbtn_restart = new Guna.UI.WinForms.GunaButton();
            this.pnl_body = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gbtn_restart
            // 
            this.gbtn_restart.AnimationHoverSpeed = 0.07F;
            this.gbtn_restart.AnimationSpeed = 0.03F;
            this.gbtn_restart.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_restart.BorderColor = System.Drawing.Color.Black;
            this.gbtn_restart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_restart.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbtn_restart.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_restart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_restart.ForeColor = System.Drawing.Color.White;
            this.gbtn_restart.Image = null;
            this.gbtn_restart.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_restart.Location = new System.Drawing.Point(0, 0);
            this.gbtn_restart.Name = "gbtn_restart";
            this.gbtn_restart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_restart.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_restart.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_restart.OnHoverImage = null;
            this.gbtn_restart.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_restart.Size = new System.Drawing.Size(306, 39);
            this.gbtn_restart.TabIndex = 1;
            this.gbtn_restart.Text = "Restart";
            this.gbtn_restart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_restart.Visible = false;
            this.gbtn_restart.Click += new System.EventHandler(this.gbtn_restart_Click);
            // 
            // pnl_body
            // 
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.Location = new System.Drawing.Point(0, 39);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Size = new System.Drawing.Size(306, 326);
            this.pnl_body.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 365);
            this.Controls.Add(this.pnl_body);
            this.Controls.Add(this.gbtn_restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Game";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnl_body;
        public Guna.UI.WinForms.GunaButton gbtn_restart;
    }
}

