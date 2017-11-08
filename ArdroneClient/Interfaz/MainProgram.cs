using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
using Exceptions;

namespace UI
{
    public partial class MainProgram : Form
    {
        Client e_client;

        public MainProgram()
        {
            InitializeComponent();
            this.reset_btn.Enabled = false;
            this.forward_btn.Enabled = false;
            this.backward_btn.Enabled = false;
            this.right_btn.Enabled = false;
            this.left_btn.Enabled = false;
            this.down_btn.Enabled = false;
            this.up_btn.Enabled = false;
            this.t_left_btn.Enabled = false;
            this.t_right_btn.Enabled = false;
            this.takeoff_btn.Enabled = false;
            this.land_btn.Enabled = false;
        }

        private void init_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ip_txt.Text.Trim().Length == 0 && this.port_txt.Text.Trim().Length == 0)
                    e_client = new Client();
                else
                    e_client = new Client(this.ip_txt.Text.Trim(), int.Parse(this.port_txt.Text.Trim()) );
                this.ip_txt.Enabled = false;
                this.port_txt.Enabled = false;
                this.init_btn.Enabled = false;
                this.reset_btn.Enabled = true;
                this.forward_btn.Enabled = true;
                this.backward_btn.Enabled = true;
                this.right_btn.Enabled = true;
                this.left_btn.Enabled = true;
                this.down_btn.Enabled = true;
                this.up_btn.Enabled = true;
                this.t_right_btn.Enabled = true;
                this.t_left_btn.Enabled = true;
                this.takeoff_btn.Enabled = true;
                this.land_btn.Enabled = true;
            }
            catch (InitializeConnectionException ice)
            {
                MessageBox.Show(ice.Message, "Server Initialize Error");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "Server Initialize Error");
            }
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("f"); //Forward
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }
        
        private void left_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("l"); //Left
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("r"); //Right
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void backward_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("b"); //Backward
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("u"); //Up
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void t_left_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("n"); //Turn Left
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void t_right_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("h"); //Turn Right
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void down_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("d"); //Down
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }

        private void takeoff_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("t"); //Take off
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }

        }

        private void land_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.e_client.SendCommand("a"); //Land
            }
            catch (MessageSenderException ms)
            {
                MessageBox.Show(ms.Message, "Sending Command to Server Error");
            }
        }
       
        private void reset_btn_Click(object sender, EventArgs e)
        {
            e_client.ResetConfig();
            this.ip_txt.Enabled = true;
            this.port_txt.Enabled = true;
            this.init_btn.Enabled = true;
            this.reset_btn.Enabled = false;
            this.forward_btn.Enabled = false;
            this.backward_btn.Enabled = false;
            this.right_btn.Enabled = false;
            this.left_btn.Enabled = false;
            this.down_btn.Enabled = false;
            this.up_btn.Enabled = false;
            this.t_left_btn.Enabled = false;
            this.t_right_btn.Enabled = false;
            this.takeoff_btn.Enabled = false;
            this.land_btn.Enabled = false;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F:
                    //this.forward_btn.PerformClick();
                    this.forward_btn.Select();
                    break;
                case Keys.L:
                    //this.left_btn.PerformClick();
                    this.left_btn.Select();
                    break;
                case Keys.R:
                    //this.right_btn.PerformClick();
                    this.right_btn.Select();
                    break;
                case Keys.B:
                    //this.backward_btn.PerformClick();
                    this.backward_btn.Select();
                    break;
                case Keys.U:
                    //this.up_btn.PerformClick();
                    this.up_btn.Select();
                    break;
                case Keys.N:
                    //this.t_left_btn.PerformClick();
                    this.t_left_btn.Select();
                    break;
                case Keys.H:
                    //this.t_right_btn.PerformClick();
                    this.t_right_btn.Select();
                    break;
                case Keys.D:
                    //this.down_btn.PerformClick();
                    this.down_btn.Select();
                    break;
                case Keys.T:
                    //this.takeoff_btn.PerformClick();
                    this.takeoff_btn.Select();
                    break;
                case Keys.A:
                    //this.land_btn.PerformClick();
                    this.land_btn.Select();
                    break;
                default:
                    break;
            }
        }
    }
}
