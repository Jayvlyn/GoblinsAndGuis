namespace GoblinsAndGuis
{
    partial class Form4
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
            thatsItLabel = new Label();
            resultLabel = new Label();
            subtitleLabel = new Label();
            restartButton = new Button();
            SuspendLayout();
            // 
            // thatsItLabel
            // 
            thatsItLabel.AutoSize = true;
            thatsItLabel.Font = new Font("Segoe UI", 34F, FontStyle.Italic, GraphicsUnit.Point);
            thatsItLabel.Location = new Point(510, 9);
            thatsItLabel.Name = "thatsItLabel";
            thatsItLabel.Size = new Size(295, 91);
            thatsItLabel.TabIndex = 0;
            thatsItLabel.Text = "That's it!";
            // 
            // resultLabel
            // 
            resultLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultLabel.AutoSize = true;
            resultLabel.BackColor = Color.DarkOliveGreen;
            resultLabel.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            resultLabel.ForeColor = Color.Gold;
            resultLabel.Location = new Point(496, 308);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(329, 93);
            resultLabel.TabIndex = 1;
            resultLabel.Text = "You win?";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Location = new Point(547, 86);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(222, 25);
            subtitleLabel.TabIndex = 2;
            subtitleLabel.Text = "No more characters so far!";
            subtitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // restartButton
            // 
            restartButton.BackColor = Color.Goldenrod;
            restartButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            restartButton.Location = new Point(415, 631);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(486, 113);
            restartButton.TabIndex = 3;
            restartButton.Text = "Play again?";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1347, 756);
            Controls.Add(restartButton);
            Controls.Add(subtitleLabel);
            Controls.Add(resultLabel);
            Controls.Add(thatsItLabel);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fin";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label thatsItLabel;
        private Label resultLabel;
        private Label subtitleLabel;
        private Button restartButton;
    }
}