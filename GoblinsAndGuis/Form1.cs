using System.Windows.Forms;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace GoblinsAndGuis;

public partial class Form1 : Form
{
    Random r;
    Time t;
    double dt;

    int pointBuy = 0;
    int speedValue = 1;
    int healthValue = 1;
    int powerValue = 1;


    public Form1(int points)
    {
        InitializeComponent();
        Init();

        // Timer for Update()
        System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
        tmr.Interval = 50;   // milliseconds
        tmr.Tick += Update;  // set handler
        tmr.Start();

        pointBuy = points;
        pointsLabel.Text = "Points: " + pointBuy;
    }

    private void Update(object sender, EventArgs e)  //run this logic each timer tick
    {
        t.Update();
    }

    private void Init()
    {
        r = new Random();
        t = new Time();
    }

    private void PointsUpdate()
    {
        pointsLabel.Text = "Points: " + pointBuy;
        if (pointBuy <= 0)
        {
            speedUpDown.Maximum = speedUpDown.Value;
            healthUpDown.Maximum = healthUpDown.Value;
            powerUpDown.Maximum = powerUpDown.Value;
        }
        else
        {
            speedUpDown.Maximum = 100;
            healthUpDown.Maximum = 100;
            powerUpDown.Maximum = 100;
        }
    }

    private void speedUpDown_ValueChanged(object sender, EventArgs e)
    {
        pointBuy = (speedUpDown.Value < speedValue) ? pointBuy + 1 : pointBuy - 1;
        speedValue = (int)speedUpDown.Value;
        PointsUpdate();
    }

    private void healthUpDown_ValueChanged(object sender, EventArgs e)
    {
        pointBuy = (healthUpDown.Value < healthValue) ? pointBuy + 1 : pointBuy - 1;
        healthValue = (int)healthUpDown.Value;
        PointsUpdate();
    }

    private void powerUpDown_ValueChanged(object sender, EventArgs e)
    {
        pointBuy = (powerUpDown.Value < powerValue) ? pointBuy + 1 : pointBuy - 1;
        powerValue = (int)powerUpDown.Value;
        PointsUpdate();
    }

    private void createButton_Click(object sender, EventArgs e)
    {
        Game.player.name = nameTextBox.Text;
        Game.player.speed = speedValue;
        Game.player.health = healthValue;
        Game.player.power = powerValue;
        Game.formManager.ChangeForm(FormManager.FormState.Adventure);
    }

    private void Form1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
    }

    // Trash Can
    private void picturePlayer_Click(object sender, EventArgs e) { }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

}
