using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MODBUS_SERIAR
{
    public partial class FormMain : Form
    {
        private Master mMaster = null;
        private Logger mLogger = null;

        private ushort[] usDataBuffer = null;
        private byte[] bDataBuffer = null;

        public FormMain()
        {
            InitializeComponent();
        }

        #region .this Form Events

        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Build Version
                tsslVersion.Text = "Build Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString();

                // Connection Status
                tsslConnectionStatus.Text = "Disconneted.";

                // Initialize Port
                foreach (string portnumber in SerialPort.GetPortNames())
                {
                    cbPortName.Items.Add(portnumber);
                }
                cbPortName.SelectedIndex = 0;
                cbBaudRate.SelectedIndex = 0;
                cbParity.SelectedIndex = 0;
                cbDataBits.SelectedIndex = 0;
                cbStopBits.SelectedIndex = 1;

                // Disenable GroupBoxs
                tcCommunicationTools.Enabled = false;
                tpReadSingleCoil.Enabled = false;
                tpReadDiscreteInputs.Enabled = false;
                tpReadHoldingRegister.Enabled = false;
                tpReadInputRegister.Enabled = false;
                tpWriteSingleCoil.Enabled = false;
                tpWriteSingleRegister.Enabled = false;
                tpWriteMultipleCoil.Enabled = false;
                tpWriteMultipleRegister.Enabled = false;
                gbTransmitterLog.Enabled = false;
                gbReceiverLog.Enabled = false;
                gbTools.Enabled = false;

                // Do Initialize for Member, Logger Class 
                mLogger = new Logger();
                mLogger.OnLogged += mLogger_OnLogged;

                // Do Initialize for Member, Master Class
                mMaster = new Master();
                mMaster.OnReceivedData += mMaster_OnReceivedData;
            }
            catch (Exception eFormMain_Load)
            {
                MessageBox.Show(eFormMain_Load.Message);
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mMaster.bConnected)
            {
                MessageBox.Show("If you want to close this program, You Should Disconnect Communication!", "Error");
                return;
            }

            if (MessageBox.Show("Are you sure you want to close the program?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
                Close();
            else
                return;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // TODO : Closed Form
        }

        #endregion

        #region Logger Events

        private void mLogger_OnLogged(string LogMassage, LogType LogType)
        {
            switch (LogType)
            {
                case LogType.Transmitter:

                    lbTransmitter.Items.Add(LogMassage);
                    break;

                case LogType.Receiver:

                    lbReceiver.Items.Add(LogMassage);
                    break;
            }
        }

        #endregion

        #region Master Events

        private void mMaster_OnReceivedData(byte[] data)
        {
            mLogger.log(System.BitConverter.ToString(data), LogType.Receiver, true);
        }

        #endregion

        #region Seriar Setting GroupBox

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mMaster.bConnected)
                {
                    // Master Connect
                    mMaster.Connect(
                        cbPortName.Text,
                        Convert.ToInt32(cbBaudRate.Text),
                        (Parity)Enum.Parse(typeof(Parity), cbParity.Text),
                        Convert.ToInt32(cbDataBits.Text),
                        (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text)
                        );

                    // Connection Status
                    btConnect.Text = "Disconnect";
                    tsslConnectionStatus.Text = "Connected.";

                    // Enable List
                    tcCommunicationTools.Enabled = true;
                    tpReadSingleCoil.Enabled = true;
                    tpReadDiscreteInputs.Enabled = true;
                    tpReadHoldingRegister.Enabled = true;
                    tpReadInputRegister.Enabled = true;
                    tpWriteSingleCoil.Enabled = true;
                    tpWriteSingleRegister.Enabled = true;
                    tpWriteMultipleCoil.Enabled = true;
                    tpWriteMultipleRegister.Enabled = true;
                    gbTransmitterLog.Enabled = true;
                    gbReceiverLog.Enabled = true;
                    gbTools.Enabled = true;

                    // Disenable List
                    cbPortName.Enabled = false;
                    cbBaudRate.Enabled = false;
                    cbParity.Enabled = false;
                    cbDataBits.Enabled = false;
                    cbStopBits.Enabled = false;
                }
                else
                {
                    // Master Disconnect
                    mMaster.Disconnect();

                    // Connection Status
                    btConnect.Text = "Connect";
                    tsslConnectionStatus.Text = "Disconnected.";

                    // Disenable List
                    tcCommunicationTools.Enabled = false;
                    tpReadSingleCoil.Enabled = false;
                    tpReadDiscreteInputs.Enabled = false;
                    tpReadHoldingRegister.Enabled = false;
                    tpReadInputRegister.Enabled = false;
                    tpWriteSingleCoil.Enabled = false;
                    tpWriteSingleRegister.Enabled = false;
                    tpWriteMultipleCoil.Enabled = false;
                    tpWriteMultipleRegister.Enabled = false;
                    gbTransmitterLog.Enabled = false;
                    gbReceiverLog.Enabled = false;
                    gbTools.Enabled = false;

                    // Enable List
                    cbPortName.Enabled = true;
                    cbBaudRate.Enabled = true;
                    cbParity.Enabled = true;
                    cbDataBits.Enabled = true;
                    cbStopBits.Enabled = true;
                }

            }
            catch (Exception eFormMain_Load)
            {
                MessageBox.Show(this.ToString() + " : " + MethodBase.GetCurrentMethod().Name + ", " + eFormMain_Load.Message, "Waring!");
            }
        }

        #endregion

        #region Tools

        private void tcCommunicationTools_EnabledChanged(object sender, EventArgs e)
        {
            // Show First Menu
            tcCommunicationTools.SelectedIndex = 0;

            //Initialize Units
            udSlaveAddr_01.Value = 0;
            udDataAddr_01.Value = 0;
            udNumOfData_01.Value = 1;
            cbModbusRules_01.SelectedIndex = 0;
            cbCrc_01.SelectedIndex = 0;
            Setting_bDataBuffer();
            rtbMessage_01.Text = BitConverter.ToString(bDataBuffer);
        }

        private void tcCommunicationTools_Selected(object sender, TabControlEventArgs e)
        {
            switch (tcCommunicationTools.SelectedIndex)
            {
                case 0: // Read Single Coil (0x01)

                    // Initialize Units
                    udSlaveAddr_01.Value = 0;
                    udDataAddr_01.Value = 0;
                    udNumOfData_01.Value = 1;
                    cbModbusRules_01.SelectedIndex = 0;
                    cbCrc_01.SelectedIndex = 0;
                    Setting_bDataBuffer();
                    rtbMessage_01.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 1: // Read Discrete Inputs (0x02)

                    // Initialize Units
                    udSlaveAddr_02.Value = 0;
                    udDataAddr_02.Value = 0;
                    udNumOfData_02.Value = 1;
                    cbModbusRules_02.SelectedIndex = 0;
                    cbCrc_02.SelectedIndex = 0;
                    Setting_bDataBuffer();
                    rtbMessage_02.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 2: // Read Holding Register (0x03)

                    // Initialize Units
                    udSlaveAddr_03.Value = 0;
                    udDataAddr_03.Value = 0;
                    udNumOfData_03.Value = 1;
                    cbModbusRules_03.SelectedIndex = 0;
                    cbCrc_03.SelectedIndex = 0;
                    Setting_bDataBuffer();
                    rtbMessage_03.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 3: // Read Input Register (0x04)

                    // Initialize Units
                    udSlaveAddr_04.Value = 0;
                    udDataAddr_04.Value = 0;
                    udNumOfData_04.Value = 1;
                    cbModbusRules_04.SelectedIndex = 0;
                    cbCrc_04.SelectedIndex = 0;
                    Setting_bDataBuffer();
                    rtbMessage_04.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 4: // Write Single Coil (0x05)

                    // Initialize Units
                    udSlaveAddr_05.Value = 0;
                    udDataAddr_05.Value = 0;
                    cbForceData_05.SelectedIndex = 0;
                    cbModbusRules_05.SelectedIndex = 0;
                    cbCrc_05.SelectedIndex = 0;
                    Setting_bDataBuffer();
                    rtbMessage_05.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 5: // Write Single Register (0x06)

                    // Initialize Units
                    udSlaveAddr_06.Value = 0;
                    udDataAddr_06.Value = 0;
                    tbPresetData_06.Text = "00";
                    cbModbusRules_06.SelectedIndex = 0;
                    cbCrc_06.SelectedIndex = 0;
                    Setting_bDataBuffer();
                    rtbMessage_06.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 6: // Write Multiple Coil (0x0F)

                    // Initialize Units
                    udSlaveAddr_0F.Enabled = false;
                    udDataAddr_0F.Enabled = false;
                    udNumOfData_0F.Enabled = false;
                    cbSetData_0F.Enabled = false;
                    tbSetData_0F.Enabled = false;
                    btSetData_0F.Enabled = false;
                    cbForceData_05.SelectedIndex = 0;
                    cbModbusRules_05.SelectedIndex = 0;
                    cbForceData_05.Enabled = false;
                    cbModbusRules_05.Enabled = false;
                    rtbMessage_0F.Text = "Can't use this protocol!";
                    break;

                case 7: // Write Multiple Register (0x10)

                    // Initialize Units
                    udSlaveAddr_10.Value = 0;
                    udSizeofData_10.Value = 1;
                    udDataAddr_10.Value = 0;
                    tbNumOfData_10.Text = (udSizeofData_10.Value * 2).ToString();
                    cbModbusRules_10.SelectedIndex = 0;
                    cbCrc_10.SelectedIndex = 0;
                    cbSetData_10.Items.Clear();
                    for (int i = 0; i <= (int)udSizeofData_10.Value - 1; i++)
                        cbSetData_10.Items.Add(String.Format("{0:D5}", (int)(udDataAddr_10.Value + i)));
                    cbSetData_10.SelectedIndex = 0;

                    // Initialize Variables
                    usDataBuffer = new ushort[(int)udSizeofData_10.Value];

                    // Initialize Units
                    tbSetData_10.Text = String.Format("{0:X4}", usDataBuffer[cbSetData_10.SelectedIndex]);
                    Setting_bDataBuffer();
                    rtbMessage_10.Text = BitConverter.ToString(bDataBuffer);
                    break;

                case 8: // ASCII

                    rtbMessage_ASCII.Text = "";
                    rbCRLF_ASCII.Checked = true;
                    break;

                case 9: // Hex

                    rtbMessage_Hex.Text = "";
                    rbCRLF_Hex.Checked = true;
                    break;
            }
        }

        private void Setting_bDataBuffer()
        {
            List<byte> lBuffer = null;

            switch (tcCommunicationTools.SelectedIndex)
            {
                case 0: // Read Single Coil (0x01)

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_01.Value,
                        FunctionCode.ReadSingleCoil,
                        (ushort)udDataAddr_01.Value,
                        (ushort)udNumOfData_01.Value
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;

                case 1: // Read Discrete Inputs (0x02)

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_02.Value,
                        FunctionCode.ReadDiscreteInputs,
                        (ushort)udDataAddr_02.Value,
                        (ushort)udNumOfData_02.Value
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;

                case 2: // Read Holding Register (0x03)

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_03.Value,
                        FunctionCode.ReadHoldingRegister,
                        (ushort)udDataAddr_03.Value,
                        (ushort)udNumOfData_03.Value
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;

                case 3: // Read Input Register (0x04)

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_04.Value,
                        FunctionCode.ReadInputRegister,
                        (ushort)udDataAddr_04.Value,
                        (ushort)udNumOfData_04.Value
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;

                case 4: // Write Single Coil (0x05)

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_05.Value,
                        FunctionCode.WriteSingleCoil,
                        (ushort)udDataAddr_05.Value,
                        (ushort)((cbForceData_05.Text == "Force ON") ? 0xFF00 : 0x0000)
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;

                case 5: // Write Single Register (0x06)

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_06.Value,
                        FunctionCode.WriteSingleRegister,
                        (ushort)udDataAddr_06.Value,
                        Convert.ToUInt16(tbPresetData_06.Text, 16)
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;

                case 6: // Write Multiple Coil (0x0F)

                    break;

                case 7: // Write Multiple Register (0x10)

                    byte[] bBuffer = new byte[usDataBuffer.Length * 2];
                    for (int i = 0; i < usDataBuffer.Length; i++)
                    {
                        bBuffer[i * 2] = (byte)(usDataBuffer[i] >> 8);
                        bBuffer[i * 2 + 1] = (byte)(0x00FF & (byte)(usDataBuffer[i]));
                    }

                    lBuffer = new List<byte>(Modbus.Protocol(
                        (byte)udSlaveAddr_10.Value,
                        FunctionCode.WriteMultipleRegister,
                        (ushort)udDataAddr_10.Value,
                        (ushort)udSizeofData_10.Value,
                        Convert.ToByte(tbNumOfData_10.Text),
                        (byte[])bBuffer.Clone()
                        ));

                    bDataBuffer = new byte[lBuffer.Count + 1];
                    bDataBuffer = lBuffer.ToArray();

                    break;
            }
        }

        #region Read Single Coil (0x01)

        private void udSlaveAddr_01_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_01.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_01_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_01.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udNumOfData_01_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_01.Text = BitConverter.ToString(bDataBuffer);
        }

        private void btSendMassage_01_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #region Read Discrete Inputs (0x02)

        private void udSlaveAddr_02_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_02.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_02_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_02.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udNumOfData_02_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_02.Text = BitConverter.ToString(bDataBuffer);
        }

        private void btSendMassage_02_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #region Read Holding Register (0x03)

        private void udSlaveAddr_03_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_03.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_03_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_03.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udNumOfData_03_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_03.Text = BitConverter.ToString(bDataBuffer);
        }

        private void btSendMassage_03_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #region Read Input Register (0x04)

        private void udSlaveAddr_04_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_04.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_04_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_04.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udNumOfData_04_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_04.Text = BitConverter.ToString(bDataBuffer);
        }

        private void btSendMassage_04_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #region Write Single Coil (0x05)

        private void udSlaveAddr_05_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_05.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_05_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_05.Text = BitConverter.ToString(bDataBuffer);
        }

        private void cbForceData_05_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_05.Text = BitConverter.ToString(bDataBuffer);
        }

        private void btSendMassage_05_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #region Write Single Register (0x06)

        private void udSlaveAddr_06_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_06.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_06_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_06.Text = BitConverter.ToString(bDataBuffer);
        }

        private void tbPresetData_06_TextChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_06.Text = BitConverter.ToString(bDataBuffer);
        }

        private void tbPresetData_06_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (("ABCDEF0123456789abcdef" + Convert.ToChar(Keys.Back)).IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }

        private void tbPresetData_06_Leave(object sender, EventArgs e)
        {
            while (tbPresetData_06.TextLength != 2)
            {
                tbPresetData_06.Text = "0" + tbPresetData_06.Text;
            }
        }

        private void btSendMassage_06_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #region Write Multiple Register (0x10)

        private void udSlaveAddr_10_ValueChanged(object sender, EventArgs e)
        {
            Setting_bDataBuffer();
            rtbMessage_10.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udSizeofData_10_ValueChanged(object sender, EventArgs e)
        {
            usDataBuffer = new ushort[(int)udSizeofData_10.Value];

            int index = cbSetData_10.SelectedIndex;

            cbSetData_10.Items.Clear();
            for (int i = 0; i <= (int)udSizeofData_10.Value - 1; i++)
                cbSetData_10.Items.Add(String.Format("{0:D5}", (int)(udDataAddr_10.Value + i)));

            cbSetData_10.SelectedIndex = index;

            tbNumOfData_10.Text = (udSizeofData_10.Value * 2).ToString();
            Setting_bDataBuffer();
            rtbMessage_10.Text = BitConverter.ToString(bDataBuffer);
        }

        private void udDataAddr_10_ValueChanged(object sender, EventArgs e)
        {
            int index = cbSetData_10.SelectedIndex;

            cbSetData_10.Items.Clear();
            for (int i = 0; i <= (int)udSizeofData_10.Value - 1; i++)
                cbSetData_10.Items.Add(String.Format("{0:D5}", (int)(udDataAddr_10.Value + i)));

            cbSetData_10.SelectedIndex = index;

            Setting_bDataBuffer();
            rtbMessage_10.Text = BitConverter.ToString(bDataBuffer);
        }

        private void cbSetData_10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbSetData_10.Text = String.Format("{0:X4}", usDataBuffer[cbSetData_10.SelectedIndex]);
        }

        private void tbSetData_10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (("ABCDEF0123456789abcdef" + Convert.ToChar(Keys.Back)).IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }

        private void tbSetData_10_Leave(object sender, EventArgs e)
        {
            while (tbSetData_10.TextLength != 4)
            {
                tbSetData_10.Text = "0" + tbSetData_10.Text;
            }
        }

        private void btSetData_10_Click(object sender, EventArgs e)
        {
            usDataBuffer[cbSetData_10.SelectedIndex] = Convert.ToUInt16(tbSetData_10.Text, 16);
            Setting_bDataBuffer();
            rtbMessage_10.Text = BitConverter.ToString(bDataBuffer);
        }

        private void btSendMassage_10_Click(object sender, EventArgs e)
        {
            mMaster.WriteData(bDataBuffer);
            mLogger.log(BitConverter.ToString(bDataBuffer), LogType.Transmitter, true);
        }

        #endregion

        #endregion
    }
}