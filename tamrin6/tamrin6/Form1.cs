namespace tamrin6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle car = new car();
            car.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vehicle bike = new bike();
            bike.start();
        }
    }
}
public abstract class vehicle
{
    public abstract void start();
}
public class car : vehicle
{
    public override void start()
    {
        MessageBox.Show("after we start , you can enjoy your journy with peace of mind");
    }
}
public class bike : vehicle
{
    public override void start()
    {
        MessageBox.Show("after starting with the bike , your legs will start to get tired");
    }
}