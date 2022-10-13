using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace Unit14Form
{
    public partial class Form1 : Form
    {
        ComboBox portSelector;
        Graphics canvas;
        SerialPort sp;

        public Form1()
        {
            InitializeComponent();
            portSelector = cbPortSelector;
            canvas = pbRadar.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCOMList();
            if(portSelector.Items.Count > 0)
            {
                portSelector.SelectedIndex = 0;
            }
            
        }

        private void btnStartSerial_Click(object sender, EventArgs e)
        {
            sp = new SerialPort(portSelector.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
            sp.Open();
            sp.ReadTimeout = 1000;
            serialPortTimer.Enabled = true;
        }

        private void pbRadar_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DrawCircle(SolidBrush brush, Graphics canvas, int x, int y, int width, int height)
        {
            Rectangle rectangle = new Rectangle(x - (width / 2), y - (height / 2), width, height);
            canvas.FillEllipse(brush, rectangle);
        }

        private void pbRadar_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateRadar(e.Location.X, e.Location.Y);
        }

        private void UpdateRadar(int x, int y)
        {
            canvas.Clear(Color.White);

            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);

            DrawCircle(blackBrush, canvas, pbRadar.Width / 2, pbRadar.Height / 2, 20, 20);
            DrawCircle(redBrush, canvas, x, y, 20, 20);

        }

        private void UpdateCOMList()
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                portSelector.Items.Add(ports[i]);
            }
        }

        private void serialPortTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen)
            {
                string output = sp.ReadExisting();

                if (int.TryParse(output, out int distance))
                {
                    UpdateRadar(pbRadar.Width / 2, pbRadar.Height / 2 - distance);
                }

                tbSerialInput.Text = output;
            }
        }
    }
}
