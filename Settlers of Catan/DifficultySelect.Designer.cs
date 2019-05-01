namespace SOCForm
{
    partial class DifficultySelect
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
            this.easyBtn = new System.Windows.Forms.Button();
            this.insaneBtn = new System.Windows.Forms.Button();
            this.difSelLabel = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // easyBtn
            // 
            this.easyBtn.Location = new System.Drawing.Point(128, 124);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(75, 23);
            this.easyBtn.TabIndex = 0;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = true;
            this.easyBtn.Click += new System.EventHandler(this.easyBtn_Click);
            // 
            // insaneBtn
            // 
            this.insaneBtn.Location = new System.Drawing.Point(252, 124);
            this.insaneBtn.Name = "insaneBtn";
            this.insaneBtn.Size = new System.Drawing.Size(75, 23);
            this.insaneBtn.TabIndex = 1;
            this.insaneBtn.Text = "Insane";
            this.insaneBtn.UseVisualStyleBackColor = true;
            this.insaneBtn.Click += new System.EventHandler(this.insaneBtn_Click);
            // 
            // difSelLabel
            // 
            this.difSelLabel.AutoSize = true;
            this.difSelLabel.Location = new System.Drawing.Point(187, 69);
            this.difSelLabel.Name = "difSelLabel";
            this.difSelLabel.Size = new System.Drawing.Size(80, 13);
            this.difSelLabel.TabIndex = 2;
            this.difSelLabel.Text = "Select Difficulty";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(190, 208);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // DifficultySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 271);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.difSelLabel);
            this.Controls.Add(this.insaneBtn);
            this.Controls.Add(this.easyBtn);
            this.Name = "DifficultySelect";
            this.Text = "Settlers of Catan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button insaneBtn;
        private System.Windows.Forms.Label difSelLabel;
        private System.Windows.Forms.Button backBtn;
    }
}