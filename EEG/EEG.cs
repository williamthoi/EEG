using GLNeuroTech.Devices.BioRadio;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EEG
{
    public partial class EEG : Form
    {
        public string state = "end";
        public EEG()
        {
            InitializeComponent();
        }

        private void SetUIState(string newState)
        {   // Method to update the GUI based on a state parameter.s
            state = newState;
        }

        private void AcquireData(BioRadioDevice device)
        {

            Debug.WriteLine("StartAcquisition");
            device.StartAcquisition();
            chart_ElectrodeData.Series.Add("Raw Data");
            chart_ElectrodeData.Series["Raw Data"].ChartType = SeriesChartType.Line;
            chart_ElectrodeData.Series["Raw Data"].MarkerStyle = MarkerStyle.Circle;
            while (state == "start")
            {
                foreach (var signalGroup in device.SignalGroups)
                {
                    foreach (BioRadioSignal signal in signalGroup)
                    {
                        var samples = signal.GetScaledValueArray();
                        foreach (var val in samples)
                        {
                            Debug.Write(val.ToString("##.####   "));
                            chart_ElectrodeData.Series["Raw Data"].Points.AddXY(DateTime.Now, val.ToString("##.####   "));
                        }
                    }
                }
            }
            device.StopAcquisition();
            device.Disconnect();
        }

        private void SetupDevice(long macID)
        {
            BioRadioDeviceManager deviceManager = new BioRadioDeviceManager();
            Debug.WriteLine("SetupDevice");
            try
            {
                using (BioRadioDevice device = deviceManager.GetBluetoothDevice(macID))
                {
                    var thread = new Thread(() => AcquireData(device));
                    thread.Start();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {

            }
        }

        private void UserStart()
        {
            long macID = 123; //temp
            SetupDevice(macID);
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("start");
            if (state == "end")
            {
                SetUIState("start");
                UserStart();
            }
            else
            {
                SetUIState("end");
                // UserEnd();
            }

        }
    }
}
