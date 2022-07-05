using System;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace ftel
{
    public partial class ftel : Form
    {
        public ftel()
        {
            InitializeComponent();
            bReciever = new System.Threading.Thread(new System.Threading.ThreadStart(delegate
            {
                UpdateUI();
            }));
            bReciever.IsBackground = true;
        }

        private void connector_Click(object sender, EventArgs e)
        {
            switch (connector.Text)
            {
                case "Connect":
                    try
                    {
                        sport.PortName = COMlist.Text;
                        sport.BaudRate = Int32.Parse(baudList.Text);
                        sport.Open();
                    }

                    catch (Exception msg)
                    {
                        sport.PortName = "error";
                        sport.BaudRate = 1;
                        MessageBox.Show(msg.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //break;
                    }

                    COMlist.Enabled = false;
                    baudList.Enabled = false;
                    connector.Text = "Disconnect";
                    bReciever.Start();
                    break;

                case "Disconnect":
                    try
                    {
                        sport.Close();
                    }

                    catch (Exception msg)
                    {
                        MessageBox.Show(msg.Message, "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    COMlist.Enabled = true;
                    baudList.Enabled = true;
                    connector.Text = "Connect";
                    bReciever.Suspend();
                    break;

                default:
                    if (sport.IsOpen) { connector.Text = "Disconnect"; break; }
                    else { connector.Text = "Connect"; break; }
            }
        }

        private void UpdateChartVT(double temp, double volt)
        {
            if (chartVT.InvokeRequired)
            {
                Action update = delegate { UpdateChartVT(temp, volt); };
                chartVT.Invoke(update);
            }
            else
            {
                if (chartS.Series["speed"].Points.Count > 20)
                {
                    chartVT.Series["volts"].Points.RemoveAt(0);
                    chartVT.Series["temps"].Points.RemoveAt(0);
                }

                chartVT.Series["volts"].Points.AddY(volt);
                chartVT.Series["temps"].Points.AddY(temp);
            }
        }
        
        private void UpdateChartS(double speed)
        {
            if (chartS.InvokeRequired)
            {
                Action update = delegate { UpdateChartS(speed); };
                chartS.Invoke(update);
            }
            else
            {
                if (chartS.Series["speed"].Points.Count > 20)
                {
                    chartS.Series["speed"].Points.RemoveAt(0);
                }

                chartS.Series["speed"].Points.AddY(speed);
            }
        }

        private void UpdateText(double volt, double temp, double speed)
        {
            if (cVolt.InvokeRequired)
            {
                Action update = delegate { UpdateText(volt, temp, speed); };
                cVolt.Invoke(update);
            }
            else
            {
                cVolt.Text = volt.ToString("0.##");
                cTemp.Text = temp.ToString("0.##");
                cSpeed.Text = speed.ToString("0.##");
            }
        }

        private void UpdateUI()
        {
            var rnd = new Random();

            while (true)
            {
                double volt = rnd.NextDouble() * 60;
                double temp = rnd.NextDouble() * 60;
                double speed = rnd.NextDouble() * 60;

                UpdateChartVT(volt,temp);
                UpdateChartS(speed);
                UpdateText(volt, temp, speed);

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
