using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Windows.Forms.DataVisualization.Charting;
namespace MyAPP
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "N0mhfRGO9ZEzhBpmV7uXDJ7sREkX1RiA9z6KIu7E",
            BasePath = "https://tempapp-593c8-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            int x = 0;
            while (true)
            {

                client = new FireSharp.FirebaseClient(config);
                FirebaseResponse temperature1 = await client.GetAsync(@"/sensors/temp");
                string temv = temperature1.ResultAs<string>();
                FirebaseResponse humidite = await client.GetAsync(@"/sensors/hum");
                string humv = humidite.ResultAs<string>();
                FirebaseResponse etat_gaz = await client.GetAsync(@"/sensors/gaz");
                string gazv = etat_gaz.ResultAs<string>();
                FirebaseResponse etat_bot = await client.GetAsync(@"/sensors/bot");
                string botv = etat_bot.ResultAs<string>();

                temp.Text = temv;
                hum.Text = humv;
                


                chart1.Series["temperature"].Points.AddXY(x, temv);
                this.Controls.Add(chart1);
                if (gazv =="1")
                {
                    etatgaz.Text = "Safe";
                    gazp.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    etatgaz.Text = "Danger";
                    gazp.BackColor = System.Drawing.Color.Red;
                }
                if (botv == "1")
                {
                  
                    hey.BackColor = System.Drawing.Color.Green;
                }
                else
                {
              
                    hey.BackColor = System.Drawing.Color.Red;
                }
                x++;
            }
        }

        private void on_Click(object sender, EventArgs e)
        {
            client.Set(@"/V", 1);
        }

        private void off_Click(object sender, EventArgs e)
        {
            client.Set(@"/V", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 3);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 7);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            client.Set(@"/a", 9);
        }
    }
}
