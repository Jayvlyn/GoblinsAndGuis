namespace GoblinsAndGuis
{
    partial class Form3
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
            nonPlayerLabel = new Label();
            playerLabel = new Label();
            playerMove1Button = new Button();
            playerMove2Button = new Button();
            playerMove3Button = new Button();
            playerMove4Button = new Button();
            nonPlayerMove4Button = new Button();
            nonPlayerMove3Button = new Button();
            nonPlayerMove2Button = new Button();
            nonPlayerMove1Button = new Button();
            npcPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            nonPlayerEffectPicture = new PictureBox();
            playerEffectPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)npcPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nonPlayerEffectPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerEffectPicture).BeginInit();
            SuspendLayout();
            // 
            // nonPlayerLabel
            // 
            nonPlayerLabel.AutoSize = true;
            nonPlayerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nonPlayerLabel.ForeColor = SystemColors.Control;
            nonPlayerLabel.Location = new Point(159, 22);
            nonPlayerLabel.Name = "nonPlayerLabel";
            nonPlayerLabel.Size = new Size(141, 32);
            nonPlayerLabel.TabIndex = 0;
            nonPlayerLabel.Text = "Non Player";
            nonPlayerLabel.TextAlign = ContentAlignment.BottomCenter;
            nonPlayerLabel.Click += nonPlayerLabel_Click;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playerLabel.ForeColor = SystemColors.Control;
            playerLabel.Location = new Point(457, 824);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(85, 32);
            playerLabel.TabIndex = 1;
            playerLabel.Text = "Player";
            playerLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // playerMove1Button
            // 
            playerMove1Button.BackColor = Color.Gray;
            playerMove1Button.Location = new Point(12, 576);
            playerMove1Button.Name = "playerMove1Button";
            playerMove1Button.Size = new Size(128, 128);
            playerMove1Button.TabIndex = 2;
            playerMove1Button.TabStop = false;
            playerMove1Button.Text = "Move1";
            playerMove1Button.UseVisualStyleBackColor = false;
            playerMove1Button.Click += playerMove1Button_Click;
            // 
            // playerMove2Button
            // 
            playerMove2Button.BackColor = Color.Gray;
            playerMove2Button.Location = new Point(159, 606);
            playerMove2Button.Name = "playerMove2Button";
            playerMove2Button.Size = new Size(128, 128);
            playerMove2Button.TabIndex = 3;
            playerMove2Button.TabStop = false;
            playerMove2Button.Text = "Move2";
            playerMove2Button.UseVisualStyleBackColor = false;
            playerMove2Button.Click += playerMove2Button_Click_1;
            // 
            // playerMove3Button
            // 
            playerMove3Button.BackColor = Color.Gray;
            playerMove3Button.Location = new Point(304, 632);
            playerMove3Button.Name = "playerMove3Button";
            playerMove3Button.Size = new Size(128, 128);
            playerMove3Button.TabIndex = 4;
            playerMove3Button.TabStop = false;
            playerMove3Button.Text = "Move3";
            playerMove3Button.UseVisualStyleBackColor = false;
            playerMove3Button.Click += playerMove3Button_Click;
            // 
            // playerMove4Button
            // 
            playerMove4Button.BackColor = Color.Gray;
            playerMove4Button.Location = new Point(457, 660);
            playerMove4Button.Name = "playerMove4Button";
            playerMove4Button.Size = new Size(128, 128);
            playerMove4Button.TabIndex = 5;
            playerMove4Button.TabStop = false;
            playerMove4Button.Text = "Move4";
            playerMove4Button.UseVisualStyleBackColor = false;
            playerMove4Button.Click += playerMove4Button_Click;
            // 
            // nonPlayerMove4Button
            // 
            nonPlayerMove4Button.BackColor = Color.Gray;
            nonPlayerMove4Button.Location = new Point(613, 421);
            nonPlayerMove4Button.Name = "nonPlayerMove4Button";
            nonPlayerMove4Button.Size = new Size(128, 128);
            nonPlayerMove4Button.TabIndex = 9;
            nonPlayerMove4Button.TabStop = false;
            nonPlayerMove4Button.Text = "Move4";
            nonPlayerMove4Button.UseVisualStyleBackColor = false;
            // 
            // nonPlayerMove3Button
            // 
            nonPlayerMove3Button.BackColor = Color.Gray;
            nonPlayerMove3Button.Location = new Point(457, 402);
            nonPlayerMove3Button.Name = "nonPlayerMove3Button";
            nonPlayerMove3Button.Size = new Size(128, 128);
            nonPlayerMove3Button.TabIndex = 8;
            nonPlayerMove3Button.TabStop = false;
            nonPlayerMove3Button.Text = "Move3";
            nonPlayerMove3Button.UseVisualStyleBackColor = false;
            // 
            // nonPlayerMove2Button
            // 
            nonPlayerMove2Button.BackColor = Color.Gray;
            nonPlayerMove2Button.Location = new Point(304, 384);
            nonPlayerMove2Button.Name = "nonPlayerMove2Button";
            nonPlayerMove2Button.Size = new Size(128, 128);
            nonPlayerMove2Button.TabIndex = 7;
            nonPlayerMove2Button.TabStop = false;
            nonPlayerMove2Button.Text = "Move2";
            nonPlayerMove2Button.UseVisualStyleBackColor = false;
            // 
            // nonPlayerMove1Button
            // 
            nonPlayerMove1Button.BackColor = Color.Gray;
            nonPlayerMove1Button.Location = new Point(159, 353);
            nonPlayerMove1Button.Name = "nonPlayerMove1Button";
            nonPlayerMove1Button.Size = new Size(128, 128);
            nonPlayerMove1Button.TabIndex = 6;
            nonPlayerMove1Button.TabStop = false;
            nonPlayerMove1Button.Text = "Move1";
            nonPlayerMove1Button.UseVisualStyleBackColor = false;
            nonPlayerMove1Button.Click += nonPlayerMove1Button_Click;
            // 
            // npcPictureBox
            // 
            npcPictureBox.Location = new Point(321, 22);
            npcPictureBox.Name = "npcPictureBox";
            npcPictureBox.Size = new Size(420, 420);
            npcPictureBox.TabIndex = 10;
            npcPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.Image = Properties.Resources.Player1;
            playerPictureBox.Location = new Point(12, 680);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(420, 420);
            playerPictureBox.TabIndex = 11;
            playerPictureBox.TabStop = false;
            // 
            // nonPlayerEffectPicture
            // 
            nonPlayerEffectPicture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nonPlayerEffectPicture.Location = new Point(517, 218);
            nonPlayerEffectPicture.Name = "nonPlayerEffectPicture";
            nonPlayerEffectPicture.Size = new Size(212, 212);
            nonPlayerEffectPicture.TabIndex = 13;
            nonPlayerEffectPicture.TabStop = false;
            nonPlayerEffectPicture.Visible = false;
            // 
            // playerEffectPicture
            // 
            playerEffectPicture.Location = new Point(23, 870);
            playerEffectPicture.Name = "playerEffectPicture";
            playerEffectPicture.Size = new Size(212, 212);
            playerEffectPicture.TabIndex = 14;
            playerEffectPicture.TabStop = false;
            playerEffectPicture.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(763, 1112);
            Controls.Add(nonPlayerMove4Button);
            Controls.Add(nonPlayerMove3Button);
            Controls.Add(nonPlayerMove2Button);
            Controls.Add(nonPlayerMove1Button);
            Controls.Add(playerMove4Button);
            Controls.Add(playerMove3Button);
            Controls.Add(playerMove2Button);
            Controls.Add(playerMove1Button);
            Controls.Add(playerLabel);
            Controls.Add(nonPlayerLabel);
            Controls.Add(nonPlayerEffectPicture);
            Controls.Add(npcPictureBox);
            Controls.Add(playerEffectPicture);
            Controls.Add(playerPictureBox);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)npcPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nonPlayerEffectPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerEffectPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nonPlayerLabel;
        private Label playerLabel;
        private Button playerMove1Button;
        private Button playerMove2Button;
        private Button playerMove3Button;
        private Button playerMove4Button;
        private Button nonPlayerMove4Button;
        private Button nonPlayerMove3Button;
        private Button nonPlayerMove2Button;
        private Button nonPlayerMove1Button;
        private PictureBox npcPictureBox;
        private PictureBox playerPictureBox;
        private PictureBox nonPlayerEffectPicture;
        private PictureBox playerEffectPicture;
    }
}