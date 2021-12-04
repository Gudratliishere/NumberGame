namespace NumberGame
{
    partial class ChoosePlayer
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
            this.lbl_who = new System.Windows.Forms.Label();
            this.gbtn_user = new Guna.UI.WinForms.GunaButton();
            this.gbtn_ai = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // lbl_who
            // 
            this.lbl_who.AutoSize = true;
            this.lbl_who.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_who.Location = new System.Drawing.Point(66, 73);
            this.lbl_who.Name = "lbl_who";
            this.lbl_who.Size = new System.Drawing.Size(175, 25);
            this.lbl_who.TabIndex = 0;
            this.lbl_who.Text = "Who will be first?";
            // 
            // gbtn_user
            // 
            this.gbtn_user.AnimationHoverSpeed = 0.07F;
            this.gbtn_user.AnimationSpeed = 0.03F;
            this.gbtn_user.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_user.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_user.BorderColor = System.Drawing.Color.Black;
            this.gbtn_user.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_user.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_user.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_user.ForeColor = System.Drawing.Color.White;
            this.gbtn_user.Image = null;
            this.gbtn_user.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_user.Location = new System.Drawing.Point(71, 115);
            this.gbtn_user.Name = "gbtn_user";
            this.gbtn_user.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_user.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_user.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_user.OnHoverImage = null;
            this.gbtn_user.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_user.Radius = 15;
            this.gbtn_user.Size = new System.Drawing.Size(160, 42);
            this.gbtn_user.TabIndex = 1;
            this.gbtn_user.Text = "You";
            this.gbtn_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_user.Click += new System.EventHandler(this.gbtn_user_Click);
            // 
            // gbtn_ai
            // 
            this.gbtn_ai.AnimationHoverSpeed = 0.07F;
            this.gbtn_ai.AnimationSpeed = 0.03F;
            this.gbtn_ai.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_ai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gbtn_ai.BorderColor = System.Drawing.Color.Black;
            this.gbtn_ai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gbtn_ai.FocusedColor = System.Drawing.Color.Empty;
            this.gbtn_ai.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbtn_ai.ForeColor = System.Drawing.Color.White;
            this.gbtn_ai.Image = null;
            this.gbtn_ai.ImageSize = new System.Drawing.Size(20, 20);
            this.gbtn_ai.Location = new System.Drawing.Point(71, 173);
            this.gbtn_ai.Name = "gbtn_ai";
            this.gbtn_ai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gbtn_ai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gbtn_ai.OnHoverForeColor = System.Drawing.Color.White;
            this.gbtn_ai.OnHoverImage = null;
            this.gbtn_ai.OnPressedColor = System.Drawing.Color.Black;
            this.gbtn_ai.Radius = 15;
            this.gbtn_ai.Size = new System.Drawing.Size(160, 42);
            this.gbtn_ai.TabIndex = 2;
            this.gbtn_ai.Text = "AI";
            this.gbtn_ai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gbtn_ai.Click += new System.EventHandler(this.gbtn_ai_Click);
            // 
            // ChoosePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.gbtn_ai);
            this.Controls.Add(this.gbtn_user);
            this.Controls.Add(this.lbl_who);
            this.Name = "ChoosePlayer";
            this.Size = new System.Drawing.Size(306, 326);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_who;
        private Guna.UI.WinForms.GunaButton gbtn_user;
        private Guna.UI.WinForms.GunaButton gbtn_ai;
    }
}
