using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GoblinsAndGuis
{
    partial class Form2
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
            feedBorder = new PictureBox();
            pictureBox1 = new PictureBox();
            playerLabel = new Label();
            nonPlayerLabel = new Label();
            nonPlayerDialogue = new Label();
            responseComboBox = new ComboBox();
            npcPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)feedBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)npcPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // feedBorder
            // 
            feedBorder.BackColor = Color.Gold;
            feedBorder.Location = new Point(12, 440);
            feedBorder.Name = "feedBorder";
            feedBorder.Size = new Size(1233, 250);
            feedBorder.TabIndex = 0;
            feedBorder.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Location = new Point(27, 455);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 218);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playerLabel.ForeColor = SystemColors.ActiveCaptionText;
            playerLabel.Location = new Point(438, 278);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(149, 32);
            playerLabel.TabIndex = 2;
            playerLabel.Text = "Player Name";
            playerLabel.TextAlign = ContentAlignment.BottomLeft;
            playerLabel.Click += label1_Click;
            // 
            // nonPlayerLabel
            // 
            nonPlayerLabel.AutoSize = true;
            nonPlayerLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nonPlayerLabel.ForeColor = SystemColors.ActiveCaptionText;
            nonPlayerLabel.Location = new Point(616, 12);
            nonPlayerLabel.Name = "nonPlayerLabel";
            nonPlayerLabel.Size = new Size(194, 48);
            nonPlayerLabel.TabIndex = 3;
            nonPlayerLabel.Text = "NPC Name";
            nonPlayerLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // nonPlayerDialogue
            // 
            nonPlayerDialogue.AutoSize = true;
            nonPlayerDialogue.BackColor = Color.Khaki;
            nonPlayerDialogue.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nonPlayerDialogue.Location = new Point(39, 465);
            nonPlayerDialogue.MaximumSize = new Size(1200, 0);
            nonPlayerDialogue.Name = "nonPlayerDialogue";
            nonPlayerDialogue.Size = new Size(44, 48);
            nonPlayerDialogue.TabIndex = 4;
            nonPlayerDialogue.Text = "...";
            nonPlayerDialogue.Click += label1_Click_1;
            // 
            // responseComboBox
            // 
            responseComboBox.BackColor = Color.Khaki;
            responseComboBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            responseComboBox.FormattingEnabled = true;
            responseComboBox.Location = new Point(39, 608);
            responseComboBox.Name = "responseComboBox";
            responseComboBox.Size = new Size(1170, 49);
            responseComboBox.TabIndex = 5;
            responseComboBox.Text = "Your Response:";
            responseComboBox.SelectedIndexChanged += responseComboBox_SelectedIndexChanged;
            // 
            // npcPictureBox
            // 
            npcPictureBox.Location = new Point(825, 12);
            npcPictureBox.Name = "npcPictureBox";
            npcPictureBox.Size = new Size(420, 420);
            npcPictureBox.TabIndex = 6;
            npcPictureBox.TabStop = false;
            npcPictureBox.Click += npcPictureBox_Click;
            // 
            // playerPictureBox
            // 
            playerPictureBox.Image = Properties.Resources.Player1;
            playerPictureBox.Location = new Point(12, 12);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(420, 420);
            playerPictureBox.TabIndex = 7;
            playerPictureBox.TabStop = false;
            playerPictureBox.Click += playerPictureBox_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 708);
            Controls.Add(playerPictureBox);
            Controls.Add(npcPictureBox);
            Controls.Add(responseComboBox);
            Controls.Add(nonPlayerDialogue);
            Controls.Add(nonPlayerLabel);
            Controls.Add(playerLabel);
            Controls.Add(pictureBox1);
            Controls.Add(feedBorder);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adventure";
            ((System.ComponentModel.ISupportInitialize)feedBorder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)npcPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox feedBorder;
        private PictureBox pictureBox1;
        private Label playerLabel;
        private Label nonPlayerLabel;
        private Label nonPlayerDialogue;
        private ComboBox responseComboBox;
        private PictureBox npcPictureBox;
        private PictureBox playerPictureBox;
    }
}