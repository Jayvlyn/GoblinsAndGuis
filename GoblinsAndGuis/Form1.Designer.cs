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
        speedUpDown.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        speedUpDown.Location = new Point(332, 137);
        speedUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        speedUpDown.Name = "speedUpDown";
        speedUpDown.Size = new Size(296, 114);
        speedUpDown.TabIndex = 0;
        speedUpDown.TextAlign = HorizontalAlignment.Center;
        speedUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        speedUpDown.ValueChanged += speedUpDown_ValueChanged;
        // 
        // nameTextBox
        // 
        nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        nameTextBox.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
        nameTextBox.Location = new Point(30, 32);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.PlaceholderText = "Enter Character Name";
        nameTextBox.Size = new Size(959, 87);
        nameTextBox.TabIndex = 1;
        nameTextBox.TextChanged += textBox1_TextChanged;
        // 
        // speedTextBox
        // 
        speedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        speedTextBox.BackColor = Color.LightSkyBlue;
        speedTextBox.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        speedTextBox.Location = new Point(30, 137);
        speedTextBox.Name = "speedTextBox";
        speedTextBox.ReadOnly = true;
        speedTextBox.Size = new Size(274, 114);
        speedTextBox.TabIndex = 2;
        speedTextBox.Text = "Speed";
        speedTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // healthTextBox
        // 
        healthTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        healthTextBox.BackColor = Color.MediumSeaGreen;
        healthTextBox.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        healthTextBox.Location = new Point(30, 269);
        healthTextBox.Name = "healthTextBox";
        healthTextBox.ReadOnly = true;
        healthTextBox.Size = new Size(315, 114);
        healthTextBox.TabIndex = 3;
        healthTextBox.Text = "Health";
        healthTextBox.TextAlign = HorizontalAlignment.Center;
        // 
        // healthUpDown
        // 
        healthUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        healthUpDown.BackColor = Color.SeaGreen;
        healthUpDown.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        healthUpDown.Location = new Point(362, 270);
        healthUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        healthUpDown.Name = "healthUpDown";
        healthUpDown.Size = new Size(266, 114);
        healthUpDown.TabIndex = 4;
        healthUpDown.TextAlign = HorizontalAlignment.Center;
        healthUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        healthUpDown.ValueChanged += healthUpDown_ValueChanged;
        // 
        // powerUpDown
        // 
        powerUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        powerUpDown.BackColor = Color.Brown;
        powerUpDown.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        powerUpDown.Location = new Point(332, 406);
        powerUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        powerUpDown.Name = "powerUpDown";
        powerUpDown.Size = new Size(296, 114);
        powerUpDown.TabIndex = 5;
        powerUpDown.TextAlign = HorizontalAlignment.Center;
        powerUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
        powerUpDown.ValueChanged += powerUpDown_ValueChanged;
        // 
        // powerTextBox
        // 
        powerTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        powerTextBox.BackColor = Color.IndianRed;
        powerTextBox.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        powerTextBox.Location = new Point(30, 405);
        powerTextBox.Name = "powerTextBox";
        powerTextBox.ReadOnly = true;
        powerTextBox.Size = new Size(274, 114);
        powerTextBox.TabIndex = 6;
        powerTextBox.Text = "Power";
        powerTextBox.TextAlign = HorizontalAlignment.Center;
        powerTextBox.TextChanged += powerTextBox_TextChanged;
        // 
        // createButton
        // 
        createButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        createButton.BackColor = Color.Gold;
        createButton.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        createButton.Location = new Point(529, 692);
        createButton.Name = "createButton";
        createButton.Size = new Size(460, 124);
        createButton.TabIndex = 7;
        createButton.Text = "Create Character";
        createButton.UseVisualStyleBackColor = false;
        createButton.Click += createButton_Click;
        // 
        // pointsLabel
        // 
        pointsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pointsLabel.AutoSize = true;
        pointsLabel.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
        pointsLabel.Location = new Point(30, 692);
        pointsLabel.Name = "pointsLabel";
        pointsLabel.Size = new Size(298, 106);
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
