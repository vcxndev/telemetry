using System.Net.Sockets;

namespace wtel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Connector_Click(object sender, EventArgs e)
        {
            if(connector.Text == "Connect")
            {
                TcpClient client = Try_Connection("127.0.0.1", 1302);

                if(client != null)
                    connector.Text = "Disconnect"; return;


            }
            else if(connector.Text == "Disconnect")
            {
                connector.Text = "Connect";
            }
        }
        
        private TcpClient Try_Connection(string hostname, int portID)
        {
            TcpClient? client;

            inIP.Enabled = false;
            inPort.Enabled = false;
            connector.Text = "Trying";

            try
            {
                client = new TcpClient(hostname, portID);
            }
            catch (Exception msg)
            {
                client = null;
                inIP.Enabled = true;
                inPort.Enabled = true;
                connector.Text = "Connect";
                MessageBox.Show(msg.Message);
            }

#pragma warning disable CS8603 // let me you null return you dumb compiler 
            return client;
#pragma warning restore CS8603 // stop be a dumbass
        }
    }
}