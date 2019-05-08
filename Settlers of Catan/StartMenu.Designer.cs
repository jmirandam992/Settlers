namespace SOCForm
{
    partial class StartMenu
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
            this.startGameBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startGameBtn
            // 
            this.startGameBtn.Location = new System.Drawing.Point(109, 138);
            this.startGameBtn.Name = "startGameBtn";
            this.startGameBtn.Size = new System.Drawing.Size(128, 53);
            this.startGameBtn.TabIndex = 0;
            this.startGameBtn.Text = "StartGame";
            this.startGameBtn.UseVisualStyleBackColor = true;
            this.startGameBtn.Click += new System.EventHandler(this.startGameBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Location = new System.Drawing.Point(332, 138);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(128, 53);
            this.rulesBtn.TabIndex = 1;
            this.rulesBtn.Text = "Rules";
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(543, 138);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(128, 53);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(166, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.startGameBtn);
            this.Name = "StartMenu";
            this.Text = "Settlers of Catan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGameBtn;
        private System.Windows.Forms.Button rulesBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Panel panel1;

    }
}
