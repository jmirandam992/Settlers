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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // onePlayerBtn
            // 
            this.onePlayerBtn.Location = new System.Drawing.Point(67, 178);
            this.onePlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onePlayerBtn.Name = "onePlayerBtn";
            this.onePlayerBtn.Size = new System.Drawing.Size(67, 65);
            this.onePlayerBtn.TabIndex = 0;
            this.onePlayerBtn.Text = "1 Player";
            this.onePlayerBtn.UseVisualStyleBackColor = true;
            this.onePlayerBtn.Click += new System.EventHandler(this.onePlayerBtn_Click);
            // 
            // twoPlayerBtn
            // 
            this.twoPlayerBtn.Location = new System.Drawing.Point(177, 178);
            this.twoPlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twoPlayerBtn.Name = "twoPlayerBtn";
            this.twoPlayerBtn.Size = new System.Drawing.Size(67, 65);
            this.twoPlayerBtn.TabIndex = 1;
            this.twoPlayerBtn.Text = "2 Player";
            this.twoPlayerBtn.UseVisualStyleBackColor = true;
            this.twoPlayerBtn.Click += new System.EventHandler(this.twoPlayerBtn_Click);
            // 
            // threePlayerBtn
            // 
            this.threePlayerBtn.Location = new System.Drawing.Point(286, 178);
            this.threePlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.threePlayerBtn.Name = "threePlayerBtn";
            this.threePlayerBtn.Size = new System.Drawing.Size(67, 65);
            this.threePlayerBtn.TabIndex = 2;
            this.threePlayerBtn.Text = "3 Player";
            this.threePlayerBtn.UseVisualStyleBackColor = true;
            this.threePlayerBtn.Click += new System.EventHandler(this.threePlayerBtn_Click);
            // 
            // fourPlayerBtn
            // 
            this.fourPlayerBtn.Location = new System.Drawing.Point(395, 178);
            this.fourPlayerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fourPlayerBtn.Name = "fourPlayerBtn";
            this.fourPlayerBtn.Size = new System.Drawing.Size(67, 65);
            this.fourPlayerBtn.TabIndex = 3;
            this.fourPlayerBtn.Text = "4 Player";
            this.fourPlayerBtn.UseVisualStyleBackColor = true;
            this.fourPlayerBtn.Click += new System.EventHandler(this.fourPlayerBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "How Many Players?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fourPlayerBtn);
            this.Controls.Add(this.threePlayerBtn);
            this.Controls.Add(this.twoPlayerBtn);
            this.Controls.Add(this.onePlayerBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}