namespace winScreen
{
    partial class frmWinner
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
            this.lblCongradulations = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCongradulations
            // 
            this.lblCongradulations.AutoSize = true;
            this.lblCongradulations.Font = new System.Drawing.Font("PMingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongradulations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCongradulations.Location = new System.Drawing.Point(331, 142);
            this.lblCongradulations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCongradulations.Name = "lblCongradulations";
            this.lblCongradulations.Size = new System.Drawing.Size(344, 48);
            this.lblCongradulations.TabIndex = 0;
            this.lblCongradulations.Text = "Congratulations!";
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(342, 380);
            this.btnReplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(134, 75);
            this.btnReplay.TabIndex = 3;
            this.btnReplay.Text = "Replay Game";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.BtnReplay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(530, 380);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 75);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1006, 692);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblCongradulations);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmWinner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongradulations;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnClose;
    }
}

