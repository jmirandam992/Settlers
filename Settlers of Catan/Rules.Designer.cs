namespace SOCForm
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.backBtn = new System.Windows.Forms.Button();
            this.lblRuleLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHowtoWin = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(213, 230);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(108, 33);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // lblRuleLabel
            // 
            this.lblRuleLabel.AutoSize = true;
            this.lblRuleLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRuleLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRuleLabel.Location = new System.Drawing.Point(216, 8);
            this.lblRuleLabel.Name = "lblRuleLabel";
            this.lblRuleLabel.Size = new System.Drawing.Size(101, 37);
            this.lblRuleLabel.TabIndex = 1;
            this.lblRuleLabel.Text = "Rules";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.lblHowtoWin);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(509, 177);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lblHowtoWin
            // 
            this.lblHowtoWin.BackColor = System.Drawing.SystemColors.Control;
            this.lblHowtoWin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowtoWin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHowtoWin.Location = new System.Drawing.Point(3, 0);
            this.lblHowtoWin.Name = "lblHowtoWin";
            this.lblHowtoWin.Size = new System.Drawing.Size(483, 850);
            this.lblHowtoWin.TabIndex = 0;
            this.lblHowtoWin.Text = resources.GetString("lblHowtoWin.Text");
            this.lblHowtoWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblRuleLabel);
            this.Controls.Add(this.backBtn);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Rules";
            this.Text = "Settlers of Catan";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label lblRuleLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblHowtoWin;
    }
}
