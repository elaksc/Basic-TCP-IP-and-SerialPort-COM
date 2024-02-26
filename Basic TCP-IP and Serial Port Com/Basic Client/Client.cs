using SimpleTCP;
using System.IO.Ports;
using System.Text;

namespace Basic_Client
{

    public partial class Client : Form
    {
        SerialPort serialPort;
        public Client()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {

            {
                tcpClient = new SimpleTcpClient();
                tcpClient.StringEncoder = Encoding.UTF8;
                tcpClient.DataReceived += TcpClient_DataReceived;

                // Instantiate the serialPort object as a SerialPort
                serialPort = new SerialPort();

                string[] ports = SerialPort.GetPortNames();
                comboBox1.Items.AddRange(ports);
                comboBox1.SelectedIndex = 0;
                btnSerialPortClose.Enabled = false;
            }

        }

        private void TcpClient_DataReceived(object? sender, SimpleTCP.Message e)
        {
            txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString;

            }
             );
        }

        SimpleTcpClient tcpClient;


        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            tcpClient.Connect(txtHost.Text, Convert.ToInt32(txtPort.Text));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tcpClient.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(3));
        }

        public void btnSerialPortOpen_Click(object sender, EventArgs e)
        {

            btnSerialPortOpen.Enabled = false;
            btnSerialPortClose.Enabled = true;
            try
            {
                serialPort.PortName = comboBox1.Text;
                serialPort.Open();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerialSend_Click(object sender, EventArgs e)
        {

            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.WriteLine(txtSerialSend.Text + Environment.NewLine);
                    txtSerialSend.Clear();
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSerialPortClose_Click(object sender, EventArgs e)
        {
            btnSerialPortOpen.Enabled = true;
            btnSerialPortClose.Enabled = false;
        
            try
            {

                serialPort.Close();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    txtSerialReceive.Text = serialPort.ReadExisting();
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
    }
}
