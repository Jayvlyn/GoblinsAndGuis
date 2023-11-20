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
            ((System.ComponentModel.ISupportInitialize)feedBorder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            playerLabel.ForeColor = SystemColors.ButtonHighlight;
            playerLabel.Location = new Point(12, 9);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(111, 25);
            playerLabel.TabIndex = 2;
            playerLabel.Text = "Player Name";
            playerLabel.Click += label1_Click;
            // 
            // nonPlayerLabel
            // 
            nonPlayerLabel.AutoSize = true;
            nonPlayerLabel.ForeColor = SystemColors.ButtonHighlight;
            nonPlayerLabel.Location = new Point(1147, 9);
            nonPlayerLabel.Name = "nonPlayerLabel";
            nonPlayerLabel.Size = new Size(98, 25);
            nonPlayerLabel.TabIndex = 3;
            nonPlayerLabel.Text = "NPC Name";
            nonPlayerLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // nonPlayerDialogue
            // 
            nonPlayerDialogue.AutoSize = true;
            nonPlayerDialogue.BackColor = Color.Khaki;
            nonPlayerDialogue.Location = new Point(39, 468);
            nonPlayerDialogue.Name = "nonPlayerDialogue";
            nonPlayerDialogue.Size = new Size(24, 25);
            nonPlayerDialogue.TabIndex = 4;
            nonPlayerDialogue.Text = "...";
            nonPlayerDialogue.Click += label1_Click_1;
            // 
            // responseComboBox
            // 
            responseComboBox.BackColor = Color.Khaki;
            responseComboBox.FormattingEnabled = true;
            responseComboBox.Location = new Point(39, 627);
            responseComboBox.Name = "responseComboBox";
            responseComboBox.Size = new Size(1170, 33);
            responseComboBox.TabIndex = 5;
            responseComboBox.Text = "Your Response:";
            responseComboBox.SelectedIndexChanged += responseComboBox_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(1257, 708);
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
    }
}