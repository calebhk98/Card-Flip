namespace CardFlip
{
    partial class Form1
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
            this.cardBackpic = new System.Windows.Forms.PictureBox();
            this.cardFacePic = new System.Windows.Forms.PictureBox();
            this.flipBtn = new System.Windows.Forms.Button();
            this.showFaceBtn = new System.Windows.Forms.Button();
            this.showBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePic)).BeginInit();
            this.SuspendLayout();
            // 
            // cardBackpic
            // 
            this.cardBackpic.Image = global::CardFlip.Properties.Resources.Backface_Blue;
            this.cardBackpic.Location = new System.Drawing.Point(33, 47);
            this.cardBackpic.Name = "cardBackpic";
            this.cardBackpic.Size = new System.Drawing.Size(100, 140);
            this.cardBackpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardBackpic.TabIndex = 0;
            this.cardBackpic.TabStop = false;
            // 
            // cardFacePic
            // 
            this.cardFacePic.Image = global::CardFlip.Properties.Resources.Ace_Spades__1_;
            this.cardFacePic.Location = new System.Drawing.Point(261, 47);
            this.cardFacePic.Name = "cardFacePic";
            this.cardFacePic.Size = new System.Drawing.Size(100, 140);
            this.cardFacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardFacePic.TabIndex = 1;
            this.cardFacePic.TabStop = false;
            this.cardFacePic.Visible = false;
            // 
            // flipBtn
            // 
            this.flipBtn.Location = new System.Drawing.Point(160, 90);
            this.flipBtn.Name = "flipBtn";
            this.flipBtn.Size = new System.Drawing.Size(75, 41);
            this.flipBtn.TabIndex = 2;
            this.flipBtn.Text = "Click to flip the card";
            this.flipBtn.UseVisualStyleBackColor = true;
            this.flipBtn.Click += new System.EventHandler(this.flipBtn_Click);
            // 
            // showFaceBtn
            // 
            this.showFaceBtn.Location = new System.Drawing.Point(160, 47);
            this.showFaceBtn.Name = "showFaceBtn";
            this.showFaceBtn.Size = new System.Drawing.Size(75, 37);
            this.showFaceBtn.TabIndex = 3;
            this.showFaceBtn.Text = "Show the card face";
            this.showFaceBtn.UseVisualStyleBackColor = true;
            this.showFaceBtn.Click += new System.EventHandler(this.showFaceBtn_Click);
            // 
            // showBackBtn
            // 
            this.showBackBtn.Location = new System.Drawing.Point(160, 137);
            this.showBackBtn.Name = "showBackBtn";
            this.showBackBtn.Size = new System.Drawing.Size(75, 49);
            this.showBackBtn.TabIndex = 4;
            this.showBackBtn.Text = "Show the card back";
            this.showBackBtn.UseVisualStyleBackColor = true;
            this.showBackBtn.Click += new System.EventHandler(this.showBackBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 231);
            this.Controls.Add(this.showBackBtn);
            this.Controls.Add(this.showFaceBtn);
            this.Controls.Add(this.flipBtn);
            this.Controls.Add(this.cardFacePic);
            this.Controls.Add(this.cardBackpic);
            this.Name = "Form1";
            this.Text = "Card Flip";
            ((System.ComponentModel.ISupportInitialize)(this.cardBackpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackpic;
        private System.Windows.Forms.PictureBox cardFacePic;
        private System.Windows.Forms.Button flipBtn;
        private System.Windows.Forms.Button showFaceBtn;
        private System.Windows.Forms.Button showBackBtn;
    }
}

