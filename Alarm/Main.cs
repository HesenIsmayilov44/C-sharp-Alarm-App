using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Main : Form
    {
        private SoundPlayer playMusic;
        string assignedTime;
        bool startedAlarm = false;
        public Main()
        {
            InitializeComponent();
            
        }
        private void Main_Load(object sender, EventArgs e)
        {
            timer_now.Start();
            cmbbx_sound.SelectedIndex = 0;
            lbl_alarmIsSet.Text = "";
            cmbbx_partOfDay.SelectedIndex = 0;
            if(DateTime.Now.ToLongTimeString()[DateTime.Now.ToLongTimeString().Length - 2] == 'P')
            {
                cmbbx_partOfDay.SelectedIndex = 1;
            }
            minuteInput.Value = (int)DateTime.Now.Minute;
            secondInput.Value = (int)DateTime.Now.Second;
            if (DateTime.Now.ToLongTimeString()[2] == ':')
            {
                string temp = DateTime.Now.ToLongTimeString()[0] + "" + DateTime.Now.ToLongTimeString()[1];
                if (temp[0] == '0')
                {
                    hourInput.Value = (int)temp[1] - 48;
                }
                else
                {
                    hourInput.Value = ((int)temp[0] - 48) * 10 + ((int)temp[1] - 48);
                }
                
               

            }
            else
            {
                hourInput.Value = (int)(DateTime.Now.ToLongTimeString()[0])-48;
            }
        }
        private void timer_now_Tick(object sender, EventArgs e)
        {
            lbl_now.Text = DateTime.Now.ToLongTimeString();
            if (lbl_now.Text.Contains("AM") || lbl_now.Text.Contains("PM"))
            {
                cmbbx_partOfDay.Visible = true;
                hourInput.Maximum = 12;
            }
            else
            {
                cmbbx_partOfDay.Visible = false;
            }
        }
        

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (startedAlarm == false)
            {
                startedAlarm = true;
                lbl_alarmIsSet.Text = "alarm is available";
                string hour = hourInput.Value.ToString();
                string minute = minuteInput.Value.ToString();
                string second = secondInput.Value.ToString();
                timer_check.Start();
                
                if (hourInput.Value.ToString().Length == 1 && lbl_now.Text.ToString()[2] == ':')
                {
                    hour = "0" + hourInput.Value.ToString();
                }
                if (minuteInput.Value.ToString().Length == 1)
                {
                    minute = "0" + minuteInput.Value.ToString();
                }
                if (secondInput.Value.ToString().Length == 1)
                {
                    second = "0" + secondInput.Value.ToString();
                }

                assignedTime = hour + ":" + minute + ":" + second;
                if (cmbbx_partOfDay.Visible == true)
                {
                    assignedTime = assignedTime + " " + cmbbx_partOfDay.SelectedItem.ToString();
                }
                
            }
            else
            {
                MessageBox.Show("The alarm already started. You must stop the alarm and start a new one :)");
            }
            
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            if (lbl_now.Text == assignedTime)
            {
                lbl_alarmIsSet.Text = "alarm was played!!!";
                timer_check.Stop();
                string sound = cmbbx_sound.SelectedItem.ToString();
                playMusic = new SoundPlayer("Sounds/" + sound + ".wav");
                playMusic.Play();
                playMusic.PlayLooping();
                MessageBox.Show("The Alarm is Ringing...");
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (startedAlarm == true)
            {
                
                timer_check.Stop();
                try
                {
                    playMusic.Stop();
                }
                catch
                {
                    
                }
                if(lbl_alarmIsSet.Text != "alarm was played!!!")
                {
                    MessageBox.Show("WARNING!!!  Alarm didn't played");
                }
                lbl_alarmIsSet.Text = "alarm was deactivated";
                startedAlarm = false;
            }
            else
            {
                MessageBox.Show("First you must start the alarm");
            }
       
        }
    }
}
