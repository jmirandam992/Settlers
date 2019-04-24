namespace SOCForm
{
    partial class MapSelect
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
            this.onePlayerBtn = new System.Windows.Forms.Button();
            this.twoPlayerBtn = new System.Windows.Forms.Button();
            this.threePlayerBtn = new System.Windows.Forms.Button();
            this.fourPlayerBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // onePlayerBtn
            // 
            this.onePlayerBtn.Location = new System.Drawing.Point(101, 274);
            this.onePlayerBtn.Name = "onePlayerBtn";
            this.onePlayerBtn.Size = new System.Drawing.Size(100, 100);
            this.onePlayerBtn.TabIndex = 0;
            this.onePlayerBtn.Text = "1 Player";
            this.onePlayerBtn.UseVisualStyleBackColor = true;
            this.onePlayerBtn.Click += new System.EventHandler(this.onePlayerBtn_Click);
            // 
            // twoPlayerBtn
            // 
            this.twoPlayerBtn.Location = new System.Drawing.Point(265, 274);
            this.twoPlayerBtn.Name = "twoPlayerBtn";
            this.twoPlayerBtn.Size = new System.Drawing.Size(100, 100);
            this.twoPlayerBtn.TabIndex = 1;
            this.twoPlayerBtn.Text = "2 Player";
            this.twoPlayerBtn.UseVisualStyleBackColor = true;
            this.twoPlayerBtn.Click += new System.EventHandler(this.twoPlayerBtn_Click);
            // 
            // threePlayerBtn
            // 
            this.threePlayerBtn.Location = new System.Drawing.Point(429, 274);
            this.threePlayerBtn.Name = "threePlayerBtn";
            this.threePlayerBtn.Size = new System.Drawing.Size(100, 100);
            this.threePlayerBtn.TabIndex = 2;
            this.threePlayerBtn.Text = "3 Player";
            this.threePlayerBtn.UseVisualStyleBackColor = true;
            this.threePlayerBtn.Click += new System.EventHandler(this.threePlayerBtn_Click);
            // 
            // fourPlayerBtn
            // 
            this.fourPlayerBtn.Location = new System.Drawing.Point(593, 274);
            this.fourPlayerBtn.Name = "fourPlayerBtn";
            this.fourPlayerBtn.Size = new System.Drawing.Size(100, 100);
            this.fourPlayerBtn.TabIndex = 3;
            this.fourPlayerBtn.Text = "4 Player";
            this.fourPlayerBtn.UseVisualStyleBackColor = true;
            this.fourPlayerBtn.Click += new System.EventHandler(this.fourPlayerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "How Many Players?";
            // 
            // MapSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fourPlayerBtn);
            this.Controls.Add(this.threePlayerBtn);
            this.Controls.Add(this.twoPlayerBtn);
            this.Controls.Add(this.onePlayerBtn);
            this.Name = "MapSelect";
            this.Text = "Settlers of Catan";
            this.Load += new System.EventHandler(this.MapSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onePlayerBtn;
        private System.Windows.Forms.Button twoPlayerBtn;
        private System.Windows.Forms.Button threePlayerBtn;
        private System.Windows.Forms.Button fourPlayerBtn;
        private System.Windows.Forms.Label label1;
    }
}