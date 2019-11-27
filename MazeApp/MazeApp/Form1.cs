using System;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MazeApp
{
    public partial class Form1 : Form
    { 
      
        string playerTime = "";
        private Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
          
        }


        SoundPlayer mediaPlayer = new SoundPlayer(@"C:\Users\Client 0819\Documents\MazeApp\MazeApp\ahem.wav");
        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            mediaPlayer.Play();

            PointConverter pc = new PointConverter();
            Point pt = new Point();
            pt = (Point)pc.ConvertFromString("0, 50");
            Cursor.Position = pt;

            timer1.Stop();
            playerTime = timeBox.Text;
            lblPlayer.Text = playerTime;
            timer1.Dispose();

            (sender as Panel).Visible = false;
            System.Threading.Thread.Sleep(500);
            (sender as Panel).Visible = true;
            System.Threading.Thread.Sleep(500);
            (sender as Panel).Visible = false;
            System.Threading.Thread.Sleep(500);
            (sender as Panel).Visible = true;
            System.Threading.Thread.Sleep(500);
            (sender as Panel).Visible = false;
            System.Threading.Thread.Sleep(500);
            (sender as Panel).Visible = true;
            System.Threading.Thread.Sleep(500);

            ListViewItem timeItem = new ListViewItem();
            timeItem.Text = timeBox.Text;
            this.listView1.Items.Add(timeItem);
        }

        Stopwatch stopwatch1 = new Stopwatch();
        int seconds = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            PointConverter pc = new PointConverter();
            Point pt = new Point();
            pt = (Point)pc.ConvertFromString("0, 50");
            Cursor.Position = pt;

            timer1.Enabled = true;

            ListViewItem li = new ListViewItem();
            li.Text = nameBox.Text;
            this.listView1.Items.Add(li);    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            timeBox.Text = TimeSpan.FromSeconds(seconds).ToString("mm\\:ss");
        }


        SoundPlayer myMediaPlayer = new SoundPlayer(@"C:\Users\Client 0819\Documents\MazeApp\MazeApp\applause.wav");
        private void btnWin_MouseEnter(object sender, EventArgs e)
        {
            myMediaPlayer.Play();
            
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    c.BackColor = randomColor;
                    }
                }
            }

      
    }
    }
