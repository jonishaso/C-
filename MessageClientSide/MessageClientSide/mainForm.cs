using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace MessageClientSide
{
    public partial class mainForm : Form
    {
        private UdpClient udpReceiver;
        private UdpClient udpSender;
        private int receivePort = 11001;
        private const int sendPort = 11002;
        private const int serverListenPort = 11000;
        private string localIPString ;
        private const string serverIPString = "192.168.1.219";      
        private IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIPString), serverListenPort);

        public mainForm()
        {
            localIPString = Array.FindAll(Dns.GetHostEntry(Dns.GetHostName()).AddressList,
                             a => a.AddressFamily == AddressFamily.InterNetwork)[0].ToString();
            //dynamic configFile = JsonConvert.DeserializeObject( File.ReadAllText("C:/Users/manlyptops.com/Desktop/versions/modifed/C_sharp/MessageClientSide/MessageClientSide/config.json"));
            //messageRichBox.AppendText(configFile.server.serverIPAdress);
            udpReceiver = new UdpClient(new IPEndPoint(IPAddress.Parse(localIPString),receivePort));
            udpSender = new UdpClient(new IPEndPoint(IPAddress.Parse(localIPString),sendPort));
            InitializeComponent();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {   
             
            messageRichBox.Text = localIPString;
            byte[] bytes = Encoding.ASCII.GetBytes("init>");
            udpSender.Send(bytes, bytes.Length,serverAddress);
            udpReceiver.BeginReceive(new AsyncCallback(receiveCallBack), null);
        }
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpReceiver.Close();
            udpSender.Close();
            Application.Exit();
        }
        private void receiveCallBack(IAsyncResult obj)
        {
            IPEndPoint ep = new IPEndPoint(IPAddress.Any,0);
            byte[] data = udpReceiver.EndReceive(obj, ref ep);
            string jsonstring = Encoding.ASCII.GetString(data, 0, data.Length);
            this.dataGridView.DataSource = (DataTable)JsonConvert.DeserializeObject<DataTable>(jsonstring);                  
        }

        private void sendBtt_Click(object sender, EventArgs e)
        {
            if (messageRichBox.Text == "")
            {
                MessageBox.Show("you cannot send empty message");
                return;
            }
            if (radioCheckBox.Checked && !mobileCheckBox.Checked)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    string udpPack = string.Format("radio>to:{0};msg:{1};", row.Cells[3].Value.ToString(), messageRichBox.Text);
                    byte[] bytes = Encoding.ASCII.GetBytes(udpPack);
                    udpSender.BeginSend(bytes, bytes.Length, serverAddress, new AsyncCallback(sendCallBack), null);
                }
            }
            else if (!radioCheckBox.Checked && mobileCheckBox.Checked)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    string udpPack = string.Format("mobile>to:{0};msg:{1};", row.Cells[3].Value.ToString(), messageRichBox.Text);
                    byte[] bytes = Encoding.ASCII.GetBytes(udpPack);
                    udpSender.BeginSend(bytes, bytes.Length, serverAddress, new AsyncCallback(sendCallBack), null);
                }
            }
            else
            {
                MessageBox.Show("you have to select one-only method of sending meassage");
                return;
            }

        }
        private void hibBtt_Click(object sender, EventArgs e)
        {
            if (messageRichBox.Text == "")
            {
                MessageBox.Show("you cannot send empty message");
                return;
            }
            if (radioCheckBox.Checked && !mobileCheckBox.Checked)
            {
                foreach (DataGridViewRow i in dataGridView.Rows)
                {
                    if (i.Cells[4].Value.ToString() == "1")
                    {
                        string udpPack = string.Format("radio>to:{0};msg:{1};", i.Cells[3].Value.ToString(), messageRichBox.Text);
                        byte[] bytes = Encoding.ASCII.GetBytes(udpPack);
                        udpSender.BeginSend(bytes, bytes.Length, serverAddress, new AsyncCallback(sendCallBack), null);
                    }

                }
            }
            else if (!radioCheckBox.Checked && mobileCheckBox.Checked)
            {
                foreach (DataGridViewRow i in dataGridView.Rows)
                {
                    if (i.Cells[4].Value.ToString() == "1")
                    {
                        string udpPack = string.Format("mobile>to:{0};msg:{1};", i.Cells[3].Value.ToString(), messageRichBox.Text);
                        byte[] bytes = Encoding.ASCII.GetBytes(udpPack);
                        udpSender.BeginSend(bytes, bytes.Length, serverAddress, new AsyncCallback(sendCallBack), null);
                    }

                }
            }
            else
            {
                MessageBox.Show("you have to select one-only method of sending meassage");
                return;
            }
        }

        private void sendCallBack(IAsyncResult iar)
        {
            if (udpSender.EndSend(iar) > 0)
                MessageBox.Show("message send");
        }

       
    }

}
