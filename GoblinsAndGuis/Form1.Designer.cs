using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GoblinsAndGuis;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        speedUpDown = new NumericUpDown();
        nameTextBox = new TextBox();
        speedTextBox = new TextBox();
        healthTextBox = new TextBox();
        healthUpDown = new NumericUpDown();
        powerUpDown = new NumericUpDown();
        powerTextBox = new TextBox();
        createButton = new Button();
        pointsLabel = new Label();
        ((System.ComponentModel.ISupportInitialize)speedUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)healthUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)powerUpDown).BeginInit();
        SuspendLayout();
        // 
        // speedUpDown
        // 
        speedUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        speedUpDown.BackColor = Color.SkyBlue;
        speedUpDown.Location = new Point(485, 294);
        speedUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        speedUpDown.Name = "speedUpDown";
        speedUpDown.Size = new Size(88, 31);
        speedUpDown.TabIndex = 0;
        speedUpDown.TextAlign = HorizontalAlignment.Center;
        speedUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        speedUpDown.ValueChanged += speedUpDown_ValueChanged;
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nameTextBox.Location = new Point(393, 257);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.PlaceholderText = "Enter Character Name";
        nameTextBox.Size = new Size(180, 31);
        nameTextBox.TabIndex = 1;
        nameTextBox.TextChanged += textBox1_TextChanged;
        // 
        // speedTextBox
        // 
        speedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        speedTextBox.BackColor = Color.LightSkyBlue;
        speedTextBox.Location = new Point(393, 294);
        speedTextBox.Name = "speedTextBox";
        speedTextBox.ReadOnly = true;
        speedTextBox.Size = new Size(86, 31);
        speedTextBox.TabIndex = 2;
        speedTextBox.Text = "Speed";
        speedTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // healthTextBox
        // 
        healthTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        healthTextBox.BackColor = Color.MediumSeaGreen;
        healthTextBox.Location = new Point(393, 331);
        healthTextBox.Name = "healthTextBox";
        healthTextBox.ReadOnly = true;
        healthTextBox.Size = new Size(86, 31);
        healthTextBox.TabIndex = 3;
        healthTextBox.Text = "Health";
        healthTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // healthUpDown
        // 
        healthUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        healthUpDown.BackColor = Color.SeaGreen;
        healthUpDown.Location = new Point(485, 331);
        healthUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        healthUpDown.Name = "healthUpDown";
        healthUpDown.Size = new Size(88, 31);
        healthUpDown.TabIndex = 4;
        healthUpDown.TextAlign = HorizontalAlignment.Center;
        healthUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        healthUpDown.ValueChanged += healthUpDown_ValueChanged;
        // 
        // powerUpDown
        // 
        powerUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        powerUpDown.BackColor = Color.Brown;
        powerUpDown.Location = new Point(485, 368);
        powerUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        powerUpDown.Name = "powerUpDown";
        powerUpDown.Size = new Size(88, 31);
        powerUpDown.TabIndex = 5;
        powerUpDown.TextAlign = HorizontalAlignment.Center;
        powerUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        powerUpDown.ValueChanged += powerUpDown_ValueChanged;
        // 
        // powerTextBox
        // 
        powerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        powerTextBox.BackColor = Color.IndianRed;
        powerTextBox.Location = new Point(393, 368);
        powerTextBox.Name = "powerTextBox";
        powerTextBox.ReadOnly = true;
        powerTextBox.Size = new Size(86, 31);
        powerTextBox.TabIndex = 6;
        powerTextBox.Text = "Power";
        powerTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // createButton
        // 
        createButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        createButton.BackColor = Color.Gold;
        createButton.Location = new Point(393, 434);
        createButton.Name = "createButton";
        createButton.Size = new Size(180, 34);
        createButton.TabIndex = 7;
        createButton.Text = "Create Character";
        createButton.UseVisualStyleBackColor = false;
        createButton.Click += createButton_Click;
        // 
        // pointsLabel
        // 
        pointsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pointsLabel.AutoSize = true;
        pointsLabel.Location = new Point(427, 402);
        pointsLabel.Name = "pointsLabel";
        pointsLabel.Size = new Size(69, 25);
        pointsLabel.TabIndex = 8;
        pointsLabel.Text = "Points: ";
        pointsLabel.Click += label1_Click_1;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.NavajoWhite;
        ClientSize = new Size(1011, 828);
        Controls.Add(pointsLabel);
        Controls.Add(createButton);
        Controls.Add(powerTextBox);
        Controls.Add(powerUpDown);
        Controls.Add(healthUpDown);
        Controls.Add(healthTextBox);
        Controls.Add(speedTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(speedUpDown);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Character Creation";
        KeyPress += Form1_KeyPress;
        ((System.ComponentModel.ISupportInitialize)speedUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)healthUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)powerUpDown).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private NumericUpDown speedUpDown;
    private TextBox nameTextBox;
    private TextBox speedTextBox;
    private TextBox healthTextBox;
    private NumericUpDown healthUpDown;
    private NumericUpDown powerUpDown;
    private TextBox powerTextBox;
    private Button createButton;
    private Label pointsLabel;
}
