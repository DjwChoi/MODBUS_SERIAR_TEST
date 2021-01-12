namespace MODBUS_SERIAR
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSeriarSetting = new System.Windows.Forms.GroupBox();
            this.lbStopBits = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbPortName = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbDataBits = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.gbTransmitterLog = new System.Windows.Forms.GroupBox();
            this.lbTransmitter = new System.Windows.Forms.ListBox();
            this.gbReceiverLog = new System.Windows.Forms.GroupBox();
            this.lbReceiver = new System.Windows.Forms.ListBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.rsslName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcCommunicationTools = new System.Windows.Forms.TabControl();
            this.tpReadSingleCoil = new System.Windows.Forms.TabPage();
            this.udNumOfData_01 = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfData_01 = new System.Windows.Forms.Label();
            this.lbFunction_01 = new System.Windows.Forms.Label();
            this.rtbMessage_01 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_01 = new System.Windows.Forms.TextBox();
            this.btSendMassage_01 = new System.Windows.Forms.Button();
            this.cbModbusRules_01 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_01 = new System.Windows.Forms.Label();
            this.cbCrc_01 = new System.Windows.Forms.ComboBox();
            this.lbCrc_01 = new System.Windows.Forms.Label();
            this.udDataAddr_01 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_01 = new System.Windows.Forms.Label();
            this.udSlaveAddr_01 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_01 = new System.Windows.Forms.Label();
            this.tpReadDiscreteInputs = new System.Windows.Forms.TabPage();
            this.udNumOfData_02 = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfData_02 = new System.Windows.Forms.Label();
            this.lbFunction_02 = new System.Windows.Forms.Label();
            this.rtbMessage_02 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_02 = new System.Windows.Forms.TextBox();
            this.btSendMassage_02 = new System.Windows.Forms.Button();
            this.cbModbusRules_02 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_02 = new System.Windows.Forms.Label();
            this.cbCrc_02 = new System.Windows.Forms.ComboBox();
            this.lbCrc_02 = new System.Windows.Forms.Label();
            this.udDataAddr_02 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_02 = new System.Windows.Forms.Label();
            this.udSlaveAddr_02 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_02 = new System.Windows.Forms.Label();
            this.tpReadHoldingRegister = new System.Windows.Forms.TabPage();
            this.udNumOfData_03 = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfData_03 = new System.Windows.Forms.Label();
            this.lbFunction_03 = new System.Windows.Forms.Label();
            this.rtbMessage_03 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_3 = new System.Windows.Forms.TextBox();
            this.btSendMassage_03 = new System.Windows.Forms.Button();
            this.cbModbusRules_03 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_03 = new System.Windows.Forms.Label();
            this.cbCrc_03 = new System.Windows.Forms.ComboBox();
            this.lbCrc_03 = new System.Windows.Forms.Label();
            this.udDataAddr_03 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_03 = new System.Windows.Forms.Label();
            this.udSlaveAddr_03 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_03 = new System.Windows.Forms.Label();
            this.tpReadInputRegister = new System.Windows.Forms.TabPage();
            this.udNumOfData_04 = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfData_04 = new System.Windows.Forms.Label();
            this.lbFunction_04 = new System.Windows.Forms.Label();
            this.rtbMessage_04 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_04 = new System.Windows.Forms.TextBox();
            this.btSendMassage_04 = new System.Windows.Forms.Button();
            this.cbModbusRules_04 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_04 = new System.Windows.Forms.Label();
            this.cbCrc_04 = new System.Windows.Forms.ComboBox();
            this.lbCrc_04 = new System.Windows.Forms.Label();
            this.udDataAddr_04 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_04 = new System.Windows.Forms.Label();
            this.udSlaveAddr_04 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_04 = new System.Windows.Forms.Label();
            this.tpWriteSingleCoil = new System.Windows.Forms.TabPage();
            this.cbForceData_05 = new System.Windows.Forms.ComboBox();
            this.lbForceData_05 = new System.Windows.Forms.Label();
            this.lbFunction_05 = new System.Windows.Forms.Label();
            this.rtbMessage_05 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_05 = new System.Windows.Forms.TextBox();
            this.btSendMassage_05 = new System.Windows.Forms.Button();
            this.cbModbusRules_05 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_05 = new System.Windows.Forms.Label();
            this.cbCrc_05 = new System.Windows.Forms.ComboBox();
            this.lbCrc_05 = new System.Windows.Forms.Label();
            this.udDataAddr_05 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_05 = new System.Windows.Forms.Label();
            this.udSlaveAddr_05 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_05 = new System.Windows.Forms.Label();
            this.tpWriteSingleRegister = new System.Windows.Forms.TabPage();
            this.tbPresetData_06 = new System.Windows.Forms.TextBox();
            this.lbPresetData_06 = new System.Windows.Forms.Label();
            this.lbFunction_06 = new System.Windows.Forms.Label();
            this.rtbMessage_06 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_06 = new System.Windows.Forms.TextBox();
            this.btSendMassage_06 = new System.Windows.Forms.Button();
            this.cbModbusRules_06 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_06 = new System.Windows.Forms.Label();
            this.cbCrc_06 = new System.Windows.Forms.ComboBox();
            this.lbCrc_06 = new System.Windows.Forms.Label();
            this.udDataAddr_06 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_06 = new System.Windows.Forms.Label();
            this.udSlaveAddr_06 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_06 = new System.Windows.Forms.Label();
            this.tpWriteMultipleCoil = new System.Windows.Forms.TabPage();
            this.btSetData_0F = new System.Windows.Forms.Button();
            this.tbSetData_0F = new System.Windows.Forms.TextBox();
            this.cbSetData_0F = new System.Windows.Forms.ComboBox();
            this.lbSetData_0F = new System.Windows.Forms.Label();
            this.udNumOfData_0F = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfData_0F = new System.Windows.Forms.Label();
            this.lbFunction_0F = new System.Windows.Forms.Label();
            this.rtbMessage_0F = new System.Windows.Forms.RichTextBox();
            this.tbFunction_0F = new System.Windows.Forms.TextBox();
            this.btSendMassage_0F = new System.Windows.Forms.Button();
            this.cbModbusRules_0F = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_0F = new System.Windows.Forms.Label();
            this.cbCrc_0F = new System.Windows.Forms.ComboBox();
            this.lbCrc_0F = new System.Windows.Forms.Label();
            this.udDataAddr_0F = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_0F = new System.Windows.Forms.Label();
            this.udSlaveAddr_0F = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_0F = new System.Windows.Forms.Label();
            this.tpWriteMultipleRegister = new System.Windows.Forms.TabPage();
            this.tbNumOfData_10 = new System.Windows.Forms.TextBox();
            this.udSizeofData_10 = new System.Windows.Forms.NumericUpDown();
            this.lbSizeofData_10 = new System.Windows.Forms.Label();
            this.btSetData_10 = new System.Windows.Forms.Button();
            this.tbSetData_10 = new System.Windows.Forms.TextBox();
            this.cbSetData_10 = new System.Windows.Forms.ComboBox();
            this.lbSetData_10 = new System.Windows.Forms.Label();
            this.lbNumOfData_10 = new System.Windows.Forms.Label();
            this.lbFunction_10 = new System.Windows.Forms.Label();
            this.rtbMessage_10 = new System.Windows.Forms.RichTextBox();
            this.tbFunction_10 = new System.Windows.Forms.TextBox();
            this.btSendMassage_10 = new System.Windows.Forms.Button();
            this.cbModbusRules_10 = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls_10 = new System.Windows.Forms.Label();
            this.cbCrc_10 = new System.Windows.Forms.ComboBox();
            this.lbCrc_10 = new System.Windows.Forms.Label();
            this.udDataAddr_10 = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr_10 = new System.Windows.Forms.Label();
            this.udSlaveAddr_10 = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr_10 = new System.Windows.Forms.Label();
            this.tpASCII = new System.Windows.Forms.TabPage();
            this.gbTail_ASCII = new System.Windows.Forms.GroupBox();
            this.rbNone_ASCII = new System.Windows.Forms.RadioButton();
            this.rbCRLF_ASCII = new System.Windows.Forms.RadioButton();
            this.rbOnlyLF_ASCII = new System.Windows.Forms.RadioButton();
            this.rbOnlyCR_ASCII = new System.Windows.Forms.RadioButton();
            this.rtbMessage_ASCII = new System.Windows.Forms.RichTextBox();
            this.btSendMassage_ASCII = new System.Windows.Forms.Button();
            this.tpHex = new System.Windows.Forms.TabPage();
            this.gbTail_Hex = new System.Windows.Forms.GroupBox();
            this.rbNone_Hex = new System.Windows.Forms.RadioButton();
            this.rbCRLF_Hex = new System.Windows.Forms.RadioButton();
            this.rbOnlyLF_Hex = new System.Windows.Forms.RadioButton();
            this.rbOnlyCR_Hex = new System.Windows.Forms.RadioButton();
            this.rtbMessage_Hex = new System.Windows.Forms.RichTextBox();
            this.btSendMassage_Hex = new System.Windows.Forms.Button();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.gbSeriarSetting.SuspendLayout();
            this.gbTransmitterLog.SuspendLayout();
            this.gbReceiverLog.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.tcCommunicationTools.SuspendLayout();
            this.tpReadSingleCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_01)).BeginInit();
            this.tpReadDiscreteInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_02)).BeginInit();
            this.tpReadHoldingRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_03)).BeginInit();
            this.tpReadInputRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_04)).BeginInit();
            this.tpWriteSingleCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_05)).BeginInit();
            this.tpWriteSingleRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_06)).BeginInit();
            this.tpWriteMultipleCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_0F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_0F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_0F)).BeginInit();
            this.tpWriteMultipleRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSizeofData_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_10)).BeginInit();
            this.tpASCII.SuspendLayout();
            this.gbTail_ASCII.SuspendLayout();
            this.tpHex.SuspendLayout();
            this.gbTail_Hex.SuspendLayout();
            this.gbTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSeriarSetting
            // 
            this.gbSeriarSetting.Controls.Add(this.lbStopBits);
            this.gbSeriarSetting.Controls.Add(this.cbParity);
            this.gbSeriarSetting.Controls.Add(this.cbDataBits);
            this.gbSeriarSetting.Controls.Add(this.cbPortName);
            this.gbSeriarSetting.Controls.Add(this.lbParity);
            this.gbSeriarSetting.Controls.Add(this.btConnect);
            this.gbSeriarSetting.Controls.Add(this.lbDataBits);
            this.gbSeriarSetting.Controls.Add(this.lbPortName);
            this.gbSeriarSetting.Controls.Add(this.lbBaudRate);
            this.gbSeriarSetting.Controls.Add(this.cbStopBits);
            this.gbSeriarSetting.Controls.Add(this.cbBaudRate);
            this.gbSeriarSetting.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbSeriarSetting.Location = new System.Drawing.Point(12, 12);
            this.gbSeriarSetting.Name = "gbSeriarSetting";
            this.gbSeriarSetting.Size = new System.Drawing.Size(249, 245);
            this.gbSeriarSetting.TabIndex = 0;
            this.gbSeriarSetting.TabStop = false;
            this.gbSeriarSetting.Text = "Seriar Setting";
            // 
            // lbStopBits
            // 
            this.lbStopBits.AutoSize = true;
            this.lbStopBits.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbStopBits.Location = new System.Drawing.Point(6, 157);
            this.lbStopBits.Name = "lbStopBits";
            this.lbStopBits.Size = new System.Drawing.Size(48, 12);
            this.lbStopBits.TabIndex = 23;
            this.lbStopBits.Text = "Stop Bit";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(96, 88);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(138, 20);
            this.cbParity.TabIndex = 18;
            // 
            // cbDataBits
            // 
            this.cbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBits.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "8",
            "9"});
            this.cbDataBits.Location = new System.Drawing.Point(96, 120);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(138, 20);
            this.cbDataBits.TabIndex = 20;
            // 
            // cbPortName
            // 
            this.cbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPortName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbPortName.FormattingEnabled = true;
            this.cbPortName.Location = new System.Drawing.Point(96, 23);
            this.cbPortName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPortName.Name = "cbPortName";
            this.cbPortName.Size = new System.Drawing.Size(138, 20);
            this.cbPortName.TabIndex = 14;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbParity.Location = new System.Drawing.Point(6, 92);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(55, 12);
            this.lbParity.TabIndex = 19;
            this.lbParity.Text = "Parity Bit";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(9, 184);
            this.btConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(225, 48);
            this.btConnect.TabIndex = 24;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataBits.Location = new System.Drawing.Point(6, 124);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(59, 12);
            this.lbDataBits.TabIndex = 21;
            this.lbDataBits.Text = "Data Size";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPortName.Location = new System.Drawing.Point(6, 27);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(65, 12);
            this.lbPortName.TabIndex = 15;
            this.lbPortName.Text = "Port Name";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBaudRate.Location = new System.Drawing.Point(6, 59);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(63, 12);
            this.lbBaudRate.TabIndex = 17;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // cbStopBits
            // 
            this.cbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStopBits.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
            this.cbStopBits.Location = new System.Drawing.Point(96, 153);
            this.cbStopBits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(138, 20);
            this.cbStopBits.TabIndex = 22;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115100"});
            this.cbBaudRate.Location = new System.Drawing.Point(96, 56);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(138, 20);
            this.cbBaudRate.TabIndex = 16;
            // 
            // gbTransmitterLog
            // 
            this.gbTransmitterLog.Controls.Add(this.lbTransmitter);
            this.gbTransmitterLog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbTransmitterLog.Location = new System.Drawing.Point(12, 263);
            this.gbTransmitterLog.Name = "gbTransmitterLog";
            this.gbTransmitterLog.Size = new System.Drawing.Size(557, 285);
            this.gbTransmitterLog.TabIndex = 3;
            this.gbTransmitterLog.TabStop = false;
            this.gbTransmitterLog.Text = "Transmitter Log";
            // 
            // lbTransmitter
            // 
            this.lbTransmitter.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTransmitter.FormattingEnabled = true;
            this.lbTransmitter.ItemHeight = 12;
            this.lbTransmitter.Location = new System.Drawing.Point(6, 20);
            this.lbTransmitter.Name = "lbTransmitter";
            this.lbTransmitter.Size = new System.Drawing.Size(544, 256);
            this.lbTransmitter.TabIndex = 0;
            // 
            // gbReceiverLog
            // 
            this.gbReceiverLog.Controls.Add(this.lbReceiver);
            this.gbReceiverLog.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbReceiverLog.Location = new System.Drawing.Point(585, 263);
            this.gbReceiverLog.Name = "gbReceiverLog";
            this.gbReceiverLog.Size = new System.Drawing.Size(557, 285);
            this.gbReceiverLog.TabIndex = 4;
            this.gbReceiverLog.TabStop = false;
            this.gbReceiverLog.Text = "Receiver Log";
            // 
            // lbReceiver
            // 
            this.lbReceiver.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbReceiver.FormattingEnabled = true;
            this.lbReceiver.ItemHeight = 12;
            this.lbReceiver.Location = new System.Drawing.Point(6, 20);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(544, 256);
            this.lbReceiver.TabIndex = 1;
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnectionStatus,
            this.tsslVersion,
            this.rsslName});
            this.ssStatus.Location = new System.Drawing.Point(0, 559);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1154, 22);
            this.ssStatus.TabIndex = 6;
            this.ssStatus.Text = "ssStatus";
            // 
            // tsslConnectionStatus
            // 
            this.tsslConnectionStatus.Name = "tsslConnectionStatus";
            this.tsslConnectionStatus.Size = new System.Drawing.Size(106, 17);
            this.tsslConnectionStatus.Text = "Connection Status";
            this.tsslConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(516, 17);
            this.tsslVersion.Spring = true;
            this.tsslVersion.Text = "0.0.0.0 ver.";
            this.tsslVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rsslName
            // 
            this.rsslName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rsslName.Name = "rsslName";
            this.rsslName.Size = new System.Drawing.Size(516, 17);
            this.rsslName.Spring = true;
            this.rsslName.Text = "Copyright © 2020 by DjwChoi (Juwon Choi) All rights reserved";
            this.rsslName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcCommunicationTools
            // 
            this.tcCommunicationTools.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcCommunicationTools.Controls.Add(this.tpReadSingleCoil);
            this.tcCommunicationTools.Controls.Add(this.tpReadDiscreteInputs);
            this.tcCommunicationTools.Controls.Add(this.tpReadHoldingRegister);
            this.tcCommunicationTools.Controls.Add(this.tpReadInputRegister);
            this.tcCommunicationTools.Controls.Add(this.tpWriteSingleCoil);
            this.tcCommunicationTools.Controls.Add(this.tpWriteSingleRegister);
            this.tcCommunicationTools.Controls.Add(this.tpWriteMultipleCoil);
            this.tcCommunicationTools.Controls.Add(this.tpWriteMultipleRegister);
            this.tcCommunicationTools.Controls.Add(this.tpASCII);
            this.tcCommunicationTools.Controls.Add(this.tpHex);
            this.tcCommunicationTools.Font = new System.Drawing.Font("굴림", 9F);
            this.tcCommunicationTools.Location = new System.Drawing.Point(17, 20);
            this.tcCommunicationTools.Multiline = true;
            this.tcCommunicationTools.Name = "tcCommunicationTools";
            this.tcCommunicationTools.SelectedIndex = 0;
            this.tcCommunicationTools.Size = new System.Drawing.Size(851, 212);
            this.tcCommunicationTools.TabIndex = 7;
            this.tcCommunicationTools.Selected += new System.Windows.Forms.TabControlEventHandler(this.tcCommunicationTools_Selected);
            this.tcCommunicationTools.EnabledChanged += new System.EventHandler(this.tcCommunicationTools_EnabledChanged);
            // 
            // tpReadSingleCoil
            // 
            this.tpReadSingleCoil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpReadSingleCoil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpReadSingleCoil.Controls.Add(this.udNumOfData_01);
            this.tpReadSingleCoil.Controls.Add(this.lbNumOfData_01);
            this.tpReadSingleCoil.Controls.Add(this.lbFunction_01);
            this.tpReadSingleCoil.Controls.Add(this.rtbMessage_01);
            this.tpReadSingleCoil.Controls.Add(this.tbFunction_01);
            this.tpReadSingleCoil.Controls.Add(this.btSendMassage_01);
            this.tpReadSingleCoil.Controls.Add(this.cbModbusRules_01);
            this.tpReadSingleCoil.Controls.Add(this.lbModebusRuls_01);
            this.tpReadSingleCoil.Controls.Add(this.cbCrc_01);
            this.tpReadSingleCoil.Controls.Add(this.lbCrc_01);
            this.tpReadSingleCoil.Controls.Add(this.udDataAddr_01);
            this.tpReadSingleCoil.Controls.Add(this.lbDataAddr_01);
            this.tpReadSingleCoil.Controls.Add(this.udSlaveAddr_01);
            this.tpReadSingleCoil.Controls.Add(this.lbSlaveAddr_01);
            this.tpReadSingleCoil.Location = new System.Drawing.Point(4, 49);
            this.tpReadSingleCoil.Name = "tpReadSingleCoil";
            this.tpReadSingleCoil.Padding = new System.Windows.Forms.Padding(3);
            this.tpReadSingleCoil.Size = new System.Drawing.Size(843, 159);
            this.tpReadSingleCoil.TabIndex = 0;
            this.tpReadSingleCoil.Text = "Read Single Coil";
            // 
            // udNumOfData_01
            // 
            this.udNumOfData_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udNumOfData_01.Location = new System.Drawing.Point(352, 49);
            this.udNumOfData_01.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udNumOfData_01.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_01.Name = "udNumOfData_01";
            this.udNumOfData_01.Size = new System.Drawing.Size(104, 21);
            this.udNumOfData_01.TabIndex = 46;
            this.udNumOfData_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumOfData_01.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_01.ValueChanged += new System.EventHandler(this.udNumOfData_01_ValueChanged);
            // 
            // lbNumOfData_01
            // 
            this.lbNumOfData_01.AutoSize = true;
            this.lbNumOfData_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData_01.Location = new System.Drawing.Point(253, 52);
            this.lbNumOfData_01.Name = "lbNumOfData_01";
            this.lbNumOfData_01.Size = new System.Drawing.Size(93, 12);
            this.lbNumOfData_01.TabIndex = 45;
            this.lbNumOfData_01.Text = "Number of Data";
            // 
            // lbFunction_01
            // 
            this.lbFunction_01.AutoSize = true;
            this.lbFunction_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_01.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_01.Name = "lbFunction_01";
            this.lbFunction_01.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_01.TabIndex = 30;
            this.lbFunction_01.Text = "Function Code";
            // 
            // rtbMessage_01
            // 
            this.rtbMessage_01.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_01.Name = "rtbMessage_01";
            this.rtbMessage_01.ReadOnly = true;
            this.rtbMessage_01.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_01.TabIndex = 44;
            this.rtbMessage_01.Text = "";
            // 
            // tbFunction_01
            // 
            this.tbFunction_01.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_01.Name = "tbFunction_01";
            this.tbFunction_01.ReadOnly = true;
            this.tbFunction_01.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_01.TabIndex = 31;
            this.tbFunction_01.Text = "Read Single Coil (0x01)";
            this.tbFunction_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_01
            // 
            this.btSendMassage_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_01.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_01.Name = "btSendMassage_01";
            this.btSendMassage_01.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_01.TabIndex = 43;
            this.btSendMassage_01.Text = "Send Message";
            this.btSendMassage_01.UseVisualStyleBackColor = true;
            this.btSendMassage_01.Click += new System.EventHandler(this.btSendMassage_01_Click);
            // 
            // cbModbusRules_01
            // 
            this.cbModbusRules_01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_01.FormattingEnabled = true;
            this.cbModbusRules_01.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_01.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_01.Name = "cbModbusRules_01";
            this.cbModbusRules_01.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_01.TabIndex = 42;
            // 
            // lbModebusRuls_01
            // 
            this.lbModebusRuls_01.AutoSize = true;
            this.lbModebusRuls_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_01.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_01.Name = "lbModebusRuls_01";
            this.lbModebusRuls_01.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_01.TabIndex = 41;
            this.lbModebusRuls_01.Text = "Modbus Rules";
            // 
            // cbCrc_01
            // 
            this.cbCrc_01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_01.FormattingEnabled = true;
            this.cbCrc_01.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_01.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_01.Name = "cbCrc_01";
            this.cbCrc_01.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_01.TabIndex = 40;
            // 
            // lbCrc_01
            // 
            this.lbCrc_01.AutoSize = true;
            this.lbCrc_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_01.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_01.Name = "lbCrc_01";
            this.lbCrc_01.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_01.TabIndex = 39;
            this.lbCrc_01.Text = "CRC";
            // 
            // udDataAddr_01
            // 
            this.udDataAddr_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_01.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_01.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_01.Name = "udDataAddr_01";
            this.udDataAddr_01.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_01.TabIndex = 33;
            this.udDataAddr_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_01.ValueChanged += new System.EventHandler(this.udDataAddr_01_ValueChanged);
            // 
            // lbDataAddr_01
            // 
            this.lbDataAddr_01.AutoSize = true;
            this.lbDataAddr_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_01.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_01.Name = "lbDataAddr_01";
            this.lbDataAddr_01.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_01.TabIndex = 32;
            this.lbDataAddr_01.Text = "Data Address";
            // 
            // udSlaveAddr_01
            // 
            this.udSlaveAddr_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_01.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_01.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_01.Name = "udSlaveAddr_01";
            this.udSlaveAddr_01.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_01.TabIndex = 29;
            this.udSlaveAddr_01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_01.ValueChanged += new System.EventHandler(this.udSlaveAddr_01_ValueChanged);
            // 
            // lbSlaveAddr_01
            // 
            this.lbSlaveAddr_01.AutoSize = true;
            this.lbSlaveAddr_01.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_01.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_01.Name = "lbSlaveAddr_01";
            this.lbSlaveAddr_01.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_01.TabIndex = 28;
            this.lbSlaveAddr_01.Text = "Slave Address";
            // 
            // tpReadDiscreteInputs
            // 
            this.tpReadDiscreteInputs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpReadDiscreteInputs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpReadDiscreteInputs.Controls.Add(this.udNumOfData_02);
            this.tpReadDiscreteInputs.Controls.Add(this.lbNumOfData_02);
            this.tpReadDiscreteInputs.Controls.Add(this.lbFunction_02);
            this.tpReadDiscreteInputs.Controls.Add(this.rtbMessage_02);
            this.tpReadDiscreteInputs.Controls.Add(this.tbFunction_02);
            this.tpReadDiscreteInputs.Controls.Add(this.btSendMassage_02);
            this.tpReadDiscreteInputs.Controls.Add(this.cbModbusRules_02);
            this.tpReadDiscreteInputs.Controls.Add(this.lbModebusRuls_02);
            this.tpReadDiscreteInputs.Controls.Add(this.cbCrc_02);
            this.tpReadDiscreteInputs.Controls.Add(this.lbCrc_02);
            this.tpReadDiscreteInputs.Controls.Add(this.udDataAddr_02);
            this.tpReadDiscreteInputs.Controls.Add(this.lbDataAddr_02);
            this.tpReadDiscreteInputs.Controls.Add(this.udSlaveAddr_02);
            this.tpReadDiscreteInputs.Controls.Add(this.lbSlaveAddr_02);
            this.tpReadDiscreteInputs.Location = new System.Drawing.Point(4, 49);
            this.tpReadDiscreteInputs.Name = "tpReadDiscreteInputs";
            this.tpReadDiscreteInputs.Padding = new System.Windows.Forms.Padding(3);
            this.tpReadDiscreteInputs.Size = new System.Drawing.Size(843, 159);
            this.tpReadDiscreteInputs.TabIndex = 1;
            this.tpReadDiscreteInputs.Text = "Read Discrete Inputs";
            // 
            // udNumOfData_02
            // 
            this.udNumOfData_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udNumOfData_02.Location = new System.Drawing.Point(352, 49);
            this.udNumOfData_02.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udNumOfData_02.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_02.Name = "udNumOfData_02";
            this.udNumOfData_02.Size = new System.Drawing.Size(104, 21);
            this.udNumOfData_02.TabIndex = 60;
            this.udNumOfData_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumOfData_02.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_02.ValueChanged += new System.EventHandler(this.udNumOfData_02_ValueChanged);
            // 
            // lbNumOfData_02
            // 
            this.lbNumOfData_02.AutoSize = true;
            this.lbNumOfData_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData_02.Location = new System.Drawing.Point(253, 52);
            this.lbNumOfData_02.Name = "lbNumOfData_02";
            this.lbNumOfData_02.Size = new System.Drawing.Size(93, 12);
            this.lbNumOfData_02.TabIndex = 59;
            this.lbNumOfData_02.Text = "Number of Data";
            // 
            // lbFunction_02
            // 
            this.lbFunction_02.AutoSize = true;
            this.lbFunction_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_02.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_02.Name = "lbFunction_02";
            this.lbFunction_02.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_02.TabIndex = 49;
            this.lbFunction_02.Text = "Function Code";
            // 
            // rtbMessage_02
            // 
            this.rtbMessage_02.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_02.Name = "rtbMessage_02";
            this.rtbMessage_02.ReadOnly = true;
            this.rtbMessage_02.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_02.TabIndex = 58;
            this.rtbMessage_02.Text = "";
            // 
            // tbFunction_02
            // 
            this.tbFunction_02.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_02.Name = "tbFunction_02";
            this.tbFunction_02.ReadOnly = true;
            this.tbFunction_02.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_02.TabIndex = 50;
            this.tbFunction_02.Text = "Read Discrete Inputs (0x02)";
            this.tbFunction_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_02
            // 
            this.btSendMassage_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_02.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_02.Name = "btSendMassage_02";
            this.btSendMassage_02.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_02.TabIndex = 57;
            this.btSendMassage_02.Text = "Send Message";
            this.btSendMassage_02.UseVisualStyleBackColor = true;
            this.btSendMassage_02.Click += new System.EventHandler(this.btSendMassage_02_Click);
            // 
            // cbModbusRules_02
            // 
            this.cbModbusRules_02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_02.FormattingEnabled = true;
            this.cbModbusRules_02.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_02.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_02.Name = "cbModbusRules_02";
            this.cbModbusRules_02.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_02.TabIndex = 56;
            // 
            // lbModebusRuls_02
            // 
            this.lbModebusRuls_02.AutoSize = true;
            this.lbModebusRuls_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_02.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_02.Name = "lbModebusRuls_02";
            this.lbModebusRuls_02.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_02.TabIndex = 55;
            this.lbModebusRuls_02.Text = "Modbus Rules";
            // 
            // cbCrc_02
            // 
            this.cbCrc_02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_02.FormattingEnabled = true;
            this.cbCrc_02.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_02.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_02.Name = "cbCrc_02";
            this.cbCrc_02.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_02.TabIndex = 54;
            // 
            // lbCrc_02
            // 
            this.lbCrc_02.AutoSize = true;
            this.lbCrc_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_02.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_02.Name = "lbCrc_02";
            this.lbCrc_02.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_02.TabIndex = 53;
            this.lbCrc_02.Text = "CRC";
            // 
            // udDataAddr_02
            // 
            this.udDataAddr_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_02.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_02.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_02.Name = "udDataAddr_02";
            this.udDataAddr_02.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_02.TabIndex = 52;
            this.udDataAddr_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_02.ValueChanged += new System.EventHandler(this.udDataAddr_02_ValueChanged);
            // 
            // lbDataAddr_02
            // 
            this.lbDataAddr_02.AutoSize = true;
            this.lbDataAddr_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_02.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_02.Name = "lbDataAddr_02";
            this.lbDataAddr_02.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_02.TabIndex = 51;
            this.lbDataAddr_02.Text = "Data Address";
            // 
            // udSlaveAddr_02
            // 
            this.udSlaveAddr_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_02.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_02.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_02.Name = "udSlaveAddr_02";
            this.udSlaveAddr_02.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_02.TabIndex = 48;
            this.udSlaveAddr_02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_02.ValueChanged += new System.EventHandler(this.udSlaveAddr_02_ValueChanged);
            // 
            // lbSlaveAddr_02
            // 
            this.lbSlaveAddr_02.AutoSize = true;
            this.lbSlaveAddr_02.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_02.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_02.Name = "lbSlaveAddr_02";
            this.lbSlaveAddr_02.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_02.TabIndex = 47;
            this.lbSlaveAddr_02.Text = "Slave Address";
            // 
            // tpReadHoldingRegister
            // 
            this.tpReadHoldingRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpReadHoldingRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpReadHoldingRegister.Controls.Add(this.udNumOfData_03);
            this.tpReadHoldingRegister.Controls.Add(this.lbNumOfData_03);
            this.tpReadHoldingRegister.Controls.Add(this.lbFunction_03);
            this.tpReadHoldingRegister.Controls.Add(this.rtbMessage_03);
            this.tpReadHoldingRegister.Controls.Add(this.tbFunction_3);
            this.tpReadHoldingRegister.Controls.Add(this.btSendMassage_03);
            this.tpReadHoldingRegister.Controls.Add(this.cbModbusRules_03);
            this.tpReadHoldingRegister.Controls.Add(this.lbModebusRuls_03);
            this.tpReadHoldingRegister.Controls.Add(this.cbCrc_03);
            this.tpReadHoldingRegister.Controls.Add(this.lbCrc_03);
            this.tpReadHoldingRegister.Controls.Add(this.udDataAddr_03);
            this.tpReadHoldingRegister.Controls.Add(this.lbDataAddr_03);
            this.tpReadHoldingRegister.Controls.Add(this.udSlaveAddr_03);
            this.tpReadHoldingRegister.Controls.Add(this.lbSlaveAddr_03);
            this.tpReadHoldingRegister.Location = new System.Drawing.Point(4, 49);
            this.tpReadHoldingRegister.Name = "tpReadHoldingRegister";
            this.tpReadHoldingRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpReadHoldingRegister.Size = new System.Drawing.Size(843, 159);
            this.tpReadHoldingRegister.TabIndex = 2;
            this.tpReadHoldingRegister.Text = "Read Holding Register";
            // 
            // udNumOfData_03
            // 
            this.udNumOfData_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udNumOfData_03.Location = new System.Drawing.Point(352, 49);
            this.udNumOfData_03.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udNumOfData_03.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_03.Name = "udNumOfData_03";
            this.udNumOfData_03.Size = new System.Drawing.Size(104, 21);
            this.udNumOfData_03.TabIndex = 74;
            this.udNumOfData_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumOfData_03.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_03.ValueChanged += new System.EventHandler(this.udNumOfData_03_ValueChanged);
            // 
            // lbNumOfData_03
            // 
            this.lbNumOfData_03.AutoSize = true;
            this.lbNumOfData_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData_03.Location = new System.Drawing.Point(253, 52);
            this.lbNumOfData_03.Name = "lbNumOfData_03";
            this.lbNumOfData_03.Size = new System.Drawing.Size(93, 12);
            this.lbNumOfData_03.TabIndex = 73;
            this.lbNumOfData_03.Text = "Number of Data";
            // 
            // lbFunction_03
            // 
            this.lbFunction_03.AutoSize = true;
            this.lbFunction_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_03.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_03.Name = "lbFunction_03";
            this.lbFunction_03.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_03.TabIndex = 63;
            this.lbFunction_03.Text = "Function Code";
            // 
            // rtbMessage_03
            // 
            this.rtbMessage_03.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_03.Name = "rtbMessage_03";
            this.rtbMessage_03.ReadOnly = true;
            this.rtbMessage_03.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_03.TabIndex = 72;
            this.rtbMessage_03.Text = "";
            // 
            // tbFunction_3
            // 
            this.tbFunction_3.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_3.Name = "tbFunction_3";
            this.tbFunction_3.ReadOnly = true;
            this.tbFunction_3.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_3.TabIndex = 64;
            this.tbFunction_3.Text = "Read Holding Register (0x03)";
            this.tbFunction_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_03
            // 
            this.btSendMassage_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_03.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_03.Name = "btSendMassage_03";
            this.btSendMassage_03.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_03.TabIndex = 71;
            this.btSendMassage_03.Text = "Send Message";
            this.btSendMassage_03.UseVisualStyleBackColor = true;
            this.btSendMassage_03.Click += new System.EventHandler(this.btSendMassage_03_Click);
            // 
            // cbModbusRules_03
            // 
            this.cbModbusRules_03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_03.FormattingEnabled = true;
            this.cbModbusRules_03.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_03.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_03.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_03.Name = "cbModbusRules_03";
            this.cbModbusRules_03.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_03.TabIndex = 70;
            // 
            // lbModebusRuls_03
            // 
            this.lbModebusRuls_03.AutoSize = true;
            this.lbModebusRuls_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_03.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_03.Name = "lbModebusRuls_03";
            this.lbModebusRuls_03.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_03.TabIndex = 69;
            this.lbModebusRuls_03.Text = "Modbus Rules";
            // 
            // cbCrc_03
            // 
            this.cbCrc_03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_03.FormattingEnabled = true;
            this.cbCrc_03.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_03.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_03.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_03.Name = "cbCrc_03";
            this.cbCrc_03.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_03.TabIndex = 68;
            // 
            // lbCrc_03
            // 
            this.lbCrc_03.AutoSize = true;
            this.lbCrc_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_03.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_03.Name = "lbCrc_03";
            this.lbCrc_03.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_03.TabIndex = 67;
            this.lbCrc_03.Text = "CRC";
            // 
            // udDataAddr_03
            // 
            this.udDataAddr_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_03.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_03.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_03.Name = "udDataAddr_03";
            this.udDataAddr_03.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_03.TabIndex = 66;
            this.udDataAddr_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_03.ValueChanged += new System.EventHandler(this.udDataAddr_03_ValueChanged);
            // 
            // lbDataAddr_03
            // 
            this.lbDataAddr_03.AutoSize = true;
            this.lbDataAddr_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_03.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_03.Name = "lbDataAddr_03";
            this.lbDataAddr_03.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_03.TabIndex = 65;
            this.lbDataAddr_03.Text = "Data Address";
            // 
            // udSlaveAddr_03
            // 
            this.udSlaveAddr_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_03.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_03.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_03.Name = "udSlaveAddr_03";
            this.udSlaveAddr_03.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_03.TabIndex = 62;
            this.udSlaveAddr_03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_03.ValueChanged += new System.EventHandler(this.udSlaveAddr_03_ValueChanged);
            // 
            // lbSlaveAddr_03
            // 
            this.lbSlaveAddr_03.AutoSize = true;
            this.lbSlaveAddr_03.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_03.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_03.Name = "lbSlaveAddr_03";
            this.lbSlaveAddr_03.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_03.TabIndex = 61;
            this.lbSlaveAddr_03.Text = "Slave Address";
            // 
            // tpReadInputRegister
            // 
            this.tpReadInputRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpReadInputRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpReadInputRegister.Controls.Add(this.udNumOfData_04);
            this.tpReadInputRegister.Controls.Add(this.lbNumOfData_04);
            this.tpReadInputRegister.Controls.Add(this.lbFunction_04);
            this.tpReadInputRegister.Controls.Add(this.rtbMessage_04);
            this.tpReadInputRegister.Controls.Add(this.tbFunction_04);
            this.tpReadInputRegister.Controls.Add(this.btSendMassage_04);
            this.tpReadInputRegister.Controls.Add(this.cbModbusRules_04);
            this.tpReadInputRegister.Controls.Add(this.lbModebusRuls_04);
            this.tpReadInputRegister.Controls.Add(this.cbCrc_04);
            this.tpReadInputRegister.Controls.Add(this.lbCrc_04);
            this.tpReadInputRegister.Controls.Add(this.udDataAddr_04);
            this.tpReadInputRegister.Controls.Add(this.lbDataAddr_04);
            this.tpReadInputRegister.Controls.Add(this.udSlaveAddr_04);
            this.tpReadInputRegister.Controls.Add(this.lbSlaveAddr_04);
            this.tpReadInputRegister.Location = new System.Drawing.Point(4, 49);
            this.tpReadInputRegister.Name = "tpReadInputRegister";
            this.tpReadInputRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpReadInputRegister.Size = new System.Drawing.Size(843, 159);
            this.tpReadInputRegister.TabIndex = 3;
            this.tpReadInputRegister.Text = "Read Input Register";
            // 
            // udNumOfData_04
            // 
            this.udNumOfData_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udNumOfData_04.Location = new System.Drawing.Point(352, 49);
            this.udNumOfData_04.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udNumOfData_04.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_04.Name = "udNumOfData_04";
            this.udNumOfData_04.Size = new System.Drawing.Size(104, 21);
            this.udNumOfData_04.TabIndex = 74;
            this.udNumOfData_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumOfData_04.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_04.ValueChanged += new System.EventHandler(this.udNumOfData_04_ValueChanged);
            // 
            // lbNumOfData_04
            // 
            this.lbNumOfData_04.AutoSize = true;
            this.lbNumOfData_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData_04.Location = new System.Drawing.Point(253, 52);
            this.lbNumOfData_04.Name = "lbNumOfData_04";
            this.lbNumOfData_04.Size = new System.Drawing.Size(93, 12);
            this.lbNumOfData_04.TabIndex = 73;
            this.lbNumOfData_04.Text = "Number of Data";
            // 
            // lbFunction_04
            // 
            this.lbFunction_04.AutoSize = true;
            this.lbFunction_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_04.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_04.Name = "lbFunction_04";
            this.lbFunction_04.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_04.TabIndex = 63;
            this.lbFunction_04.Text = "Function Code";
            // 
            // rtbMessage_04
            // 
            this.rtbMessage_04.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_04.Name = "rtbMessage_04";
            this.rtbMessage_04.ReadOnly = true;
            this.rtbMessage_04.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_04.TabIndex = 72;
            this.rtbMessage_04.Text = "";
            // 
            // tbFunction_04
            // 
            this.tbFunction_04.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_04.Name = "tbFunction_04";
            this.tbFunction_04.ReadOnly = true;
            this.tbFunction_04.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_04.TabIndex = 64;
            this.tbFunction_04.Text = "Read Input Register (0x04)";
            this.tbFunction_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_04
            // 
            this.btSendMassage_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_04.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_04.Name = "btSendMassage_04";
            this.btSendMassage_04.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_04.TabIndex = 71;
            this.btSendMassage_04.Text = "Send Message";
            this.btSendMassage_04.UseVisualStyleBackColor = true;
            this.btSendMassage_04.Click += new System.EventHandler(this.btSendMassage_04_Click);
            // 
            // cbModbusRules_04
            // 
            this.cbModbusRules_04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_04.FormattingEnabled = true;
            this.cbModbusRules_04.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_04.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_04.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_04.Name = "cbModbusRules_04";
            this.cbModbusRules_04.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_04.TabIndex = 70;
            // 
            // lbModebusRuls_04
            // 
            this.lbModebusRuls_04.AutoSize = true;
            this.lbModebusRuls_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_04.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_04.Name = "lbModebusRuls_04";
            this.lbModebusRuls_04.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_04.TabIndex = 69;
            this.lbModebusRuls_04.Text = "Modbus Rules";
            // 
            // cbCrc_04
            // 
            this.cbCrc_04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_04.FormattingEnabled = true;
            this.cbCrc_04.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_04.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_04.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_04.Name = "cbCrc_04";
            this.cbCrc_04.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_04.TabIndex = 68;
            // 
            // lbCrc_04
            // 
            this.lbCrc_04.AutoSize = true;
            this.lbCrc_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_04.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_04.Name = "lbCrc_04";
            this.lbCrc_04.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_04.TabIndex = 67;
            this.lbCrc_04.Text = "CRC";
            // 
            // udDataAddr_04
            // 
            this.udDataAddr_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_04.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_04.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_04.Name = "udDataAddr_04";
            this.udDataAddr_04.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_04.TabIndex = 66;
            this.udDataAddr_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_04.ValueChanged += new System.EventHandler(this.udDataAddr_04_ValueChanged);
            // 
            // lbDataAddr_04
            // 
            this.lbDataAddr_04.AutoSize = true;
            this.lbDataAddr_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_04.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_04.Name = "lbDataAddr_04";
            this.lbDataAddr_04.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_04.TabIndex = 65;
            this.lbDataAddr_04.Text = "Data Address";
            // 
            // udSlaveAddr_04
            // 
            this.udSlaveAddr_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_04.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_04.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_04.Name = "udSlaveAddr_04";
            this.udSlaveAddr_04.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_04.TabIndex = 62;
            this.udSlaveAddr_04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_04.ValueChanged += new System.EventHandler(this.udSlaveAddr_04_ValueChanged);
            // 
            // lbSlaveAddr_04
            // 
            this.lbSlaveAddr_04.AutoSize = true;
            this.lbSlaveAddr_04.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_04.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_04.Name = "lbSlaveAddr_04";
            this.lbSlaveAddr_04.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_04.TabIndex = 61;
            this.lbSlaveAddr_04.Text = "Slave Address";
            // 
            // tpWriteSingleCoil
            // 
            this.tpWriteSingleCoil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpWriteSingleCoil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpWriteSingleCoil.Controls.Add(this.cbForceData_05);
            this.tpWriteSingleCoil.Controls.Add(this.lbForceData_05);
            this.tpWriteSingleCoil.Controls.Add(this.lbFunction_05);
            this.tpWriteSingleCoil.Controls.Add(this.rtbMessage_05);
            this.tpWriteSingleCoil.Controls.Add(this.tbFunction_05);
            this.tpWriteSingleCoil.Controls.Add(this.btSendMassage_05);
            this.tpWriteSingleCoil.Controls.Add(this.cbModbusRules_05);
            this.tpWriteSingleCoil.Controls.Add(this.lbModebusRuls_05);
            this.tpWriteSingleCoil.Controls.Add(this.cbCrc_05);
            this.tpWriteSingleCoil.Controls.Add(this.lbCrc_05);
            this.tpWriteSingleCoil.Controls.Add(this.udDataAddr_05);
            this.tpWriteSingleCoil.Controls.Add(this.lbDataAddr_05);
            this.tpWriteSingleCoil.Controls.Add(this.udSlaveAddr_05);
            this.tpWriteSingleCoil.Controls.Add(this.lbSlaveAddr_05);
            this.tpWriteSingleCoil.Location = new System.Drawing.Point(4, 49);
            this.tpWriteSingleCoil.Name = "tpWriteSingleCoil";
            this.tpWriteSingleCoil.Padding = new System.Windows.Forms.Padding(3);
            this.tpWriteSingleCoil.Size = new System.Drawing.Size(843, 159);
            this.tpWriteSingleCoil.TabIndex = 4;
            this.tpWriteSingleCoil.Text = "Write Single Coil";
            // 
            // cbForceData_05
            // 
            this.cbForceData_05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForceData_05.FormattingEnabled = true;
            this.cbForceData_05.Items.AddRange(new object[] {
            "Force ON",
            "Force OFF"});
            this.cbForceData_05.Location = new System.Drawing.Point(334, 49);
            this.cbForceData_05.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbForceData_05.Name = "cbForceData_05";
            this.cbForceData_05.Size = new System.Drawing.Size(104, 20);
            this.cbForceData_05.TabIndex = 89;
            this.cbForceData_05.SelectionChangeCommitted += new System.EventHandler(this.cbForceData_05_SelectionChangeCommitted);
            // 
            // lbForceData_05
            // 
            this.lbForceData_05.AutoSize = true;
            this.lbForceData_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbForceData_05.Location = new System.Drawing.Point(253, 52);
            this.lbForceData_05.Name = "lbForceData_05";
            this.lbForceData_05.Size = new System.Drawing.Size(66, 12);
            this.lbForceData_05.TabIndex = 87;
            this.lbForceData_05.Text = "Force Data";
            // 
            // lbFunction_05
            // 
            this.lbFunction_05.AutoSize = true;
            this.lbFunction_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_05.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_05.Name = "lbFunction_05";
            this.lbFunction_05.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_05.TabIndex = 77;
            this.lbFunction_05.Text = "Function Code";
            // 
            // rtbMessage_05
            // 
            this.rtbMessage_05.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_05.Name = "rtbMessage_05";
            this.rtbMessage_05.ReadOnly = true;
            this.rtbMessage_05.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_05.TabIndex = 86;
            this.rtbMessage_05.Text = "";
            // 
            // tbFunction_05
            // 
            this.tbFunction_05.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_05.Name = "tbFunction_05";
            this.tbFunction_05.ReadOnly = true;
            this.tbFunction_05.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_05.TabIndex = 78;
            this.tbFunction_05.Text = "Write Single Coil (0x05)";
            this.tbFunction_05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_05
            // 
            this.btSendMassage_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_05.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_05.Name = "btSendMassage_05";
            this.btSendMassage_05.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_05.TabIndex = 85;
            this.btSendMassage_05.Text = "Send Message";
            this.btSendMassage_05.UseVisualStyleBackColor = true;
            this.btSendMassage_05.Click += new System.EventHandler(this.btSendMassage_05_Click);
            // 
            // cbModbusRules_05
            // 
            this.cbModbusRules_05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_05.FormattingEnabled = true;
            this.cbModbusRules_05.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_05.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_05.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_05.Name = "cbModbusRules_05";
            this.cbModbusRules_05.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_05.TabIndex = 84;
            // 
            // lbModebusRuls_05
            // 
            this.lbModebusRuls_05.AutoSize = true;
            this.lbModebusRuls_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_05.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_05.Name = "lbModebusRuls_05";
            this.lbModebusRuls_05.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_05.TabIndex = 83;
            this.lbModebusRuls_05.Text = "Modbus Rules";
            // 
            // cbCrc_05
            // 
            this.cbCrc_05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_05.FormattingEnabled = true;
            this.cbCrc_05.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_05.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_05.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_05.Name = "cbCrc_05";
            this.cbCrc_05.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_05.TabIndex = 82;
            // 
            // lbCrc_05
            // 
            this.lbCrc_05.AutoSize = true;
            this.lbCrc_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_05.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_05.Name = "lbCrc_05";
            this.lbCrc_05.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_05.TabIndex = 81;
            this.lbCrc_05.Text = "CRC";
            // 
            // udDataAddr_05
            // 
            this.udDataAddr_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_05.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_05.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_05.Name = "udDataAddr_05";
            this.udDataAddr_05.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_05.TabIndex = 80;
            this.udDataAddr_05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_05.ValueChanged += new System.EventHandler(this.udDataAddr_05_ValueChanged);
            // 
            // lbDataAddr_05
            // 
            this.lbDataAddr_05.AutoSize = true;
            this.lbDataAddr_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_05.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_05.Name = "lbDataAddr_05";
            this.lbDataAddr_05.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_05.TabIndex = 79;
            this.lbDataAddr_05.Text = "Data Address";
            // 
            // udSlaveAddr_05
            // 
            this.udSlaveAddr_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_05.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_05.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_05.Name = "udSlaveAddr_05";
            this.udSlaveAddr_05.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_05.TabIndex = 76;
            this.udSlaveAddr_05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_05.ValueChanged += new System.EventHandler(this.udSlaveAddr_05_ValueChanged);
            // 
            // lbSlaveAddr_05
            // 
            this.lbSlaveAddr_05.AutoSize = true;
            this.lbSlaveAddr_05.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_05.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_05.Name = "lbSlaveAddr_05";
            this.lbSlaveAddr_05.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_05.TabIndex = 75;
            this.lbSlaveAddr_05.Text = "Slave Address";
            // 
            // tpWriteSingleRegister
            // 
            this.tpWriteSingleRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpWriteSingleRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpWriteSingleRegister.Controls.Add(this.tbPresetData_06);
            this.tpWriteSingleRegister.Controls.Add(this.lbPresetData_06);
            this.tpWriteSingleRegister.Controls.Add(this.lbFunction_06);
            this.tpWriteSingleRegister.Controls.Add(this.rtbMessage_06);
            this.tpWriteSingleRegister.Controls.Add(this.tbFunction_06);
            this.tpWriteSingleRegister.Controls.Add(this.btSendMassage_06);
            this.tpWriteSingleRegister.Controls.Add(this.cbModbusRules_06);
            this.tpWriteSingleRegister.Controls.Add(this.lbModebusRuls_06);
            this.tpWriteSingleRegister.Controls.Add(this.cbCrc_06);
            this.tpWriteSingleRegister.Controls.Add(this.lbCrc_06);
            this.tpWriteSingleRegister.Controls.Add(this.udDataAddr_06);
            this.tpWriteSingleRegister.Controls.Add(this.lbDataAddr_06);
            this.tpWriteSingleRegister.Controls.Add(this.udSlaveAddr_06);
            this.tpWriteSingleRegister.Controls.Add(this.lbSlaveAddr_06);
            this.tpWriteSingleRegister.Location = new System.Drawing.Point(4, 49);
            this.tpWriteSingleRegister.Name = "tpWriteSingleRegister";
            this.tpWriteSingleRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpWriteSingleRegister.Size = new System.Drawing.Size(843, 159);
            this.tpWriteSingleRegister.TabIndex = 5;
            this.tpWriteSingleRegister.Text = "Write Single Register";
            // 
            // tbPresetData_06
            // 
            this.tbPresetData_06.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPresetData_06.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbPresetData_06.Location = new System.Drawing.Point(336, 49);
            this.tbPresetData_06.MaxLength = 2;
            this.tbPresetData_06.Name = "tbPresetData_06";
            this.tbPresetData_06.Size = new System.Drawing.Size(104, 21);
            this.tbPresetData_06.TabIndex = 134;
            this.tbPresetData_06.Text = "00";
            this.tbPresetData_06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPresetData_06.TextChanged += new System.EventHandler(this.tbPresetData_06_TextChanged);
            this.tbPresetData_06.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPresetData_06_KeyPress);
            this.tbPresetData_06.Leave += new System.EventHandler(this.tbPresetData_06_Leave);
            // 
            // lbPresetData_06
            // 
            this.lbPresetData_06.AutoSize = true;
            this.lbPresetData_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPresetData_06.Location = new System.Drawing.Point(253, 52);
            this.lbPresetData_06.Name = "lbPresetData_06";
            this.lbPresetData_06.Size = new System.Drawing.Size(70, 12);
            this.lbPresetData_06.TabIndex = 101;
            this.lbPresetData_06.Text = "Preset Data";
            // 
            // lbFunction_06
            // 
            this.lbFunction_06.AutoSize = true;
            this.lbFunction_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_06.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_06.Name = "lbFunction_06";
            this.lbFunction_06.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_06.TabIndex = 91;
            this.lbFunction_06.Text = "Function Code";
            // 
            // rtbMessage_06
            // 
            this.rtbMessage_06.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_06.Name = "rtbMessage_06";
            this.rtbMessage_06.ReadOnly = true;
            this.rtbMessage_06.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_06.TabIndex = 100;
            this.rtbMessage_06.Text = "";
            // 
            // tbFunction_06
            // 
            this.tbFunction_06.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_06.Name = "tbFunction_06";
            this.tbFunction_06.ReadOnly = true;
            this.tbFunction_06.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_06.TabIndex = 92;
            this.tbFunction_06.Text = "Write Single Register (0x06)";
            this.tbFunction_06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_06
            // 
            this.btSendMassage_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_06.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_06.Name = "btSendMassage_06";
            this.btSendMassage_06.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_06.TabIndex = 99;
            this.btSendMassage_06.Text = "Send Message";
            this.btSendMassage_06.UseVisualStyleBackColor = true;
            this.btSendMassage_06.Click += new System.EventHandler(this.btSendMassage_06_Click);
            // 
            // cbModbusRules_06
            // 
            this.cbModbusRules_06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_06.FormattingEnabled = true;
            this.cbModbusRules_06.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_06.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_06.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_06.Name = "cbModbusRules_06";
            this.cbModbusRules_06.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_06.TabIndex = 98;
            // 
            // lbModebusRuls_06
            // 
            this.lbModebusRuls_06.AutoSize = true;
            this.lbModebusRuls_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_06.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_06.Name = "lbModebusRuls_06";
            this.lbModebusRuls_06.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_06.TabIndex = 97;
            this.lbModebusRuls_06.Text = "Modbus Rules";
            // 
            // cbCrc_06
            // 
            this.cbCrc_06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_06.FormattingEnabled = true;
            this.cbCrc_06.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_06.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_06.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_06.Name = "cbCrc_06";
            this.cbCrc_06.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_06.TabIndex = 96;
            // 
            // lbCrc_06
            // 
            this.lbCrc_06.AutoSize = true;
            this.lbCrc_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_06.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_06.Name = "lbCrc_06";
            this.lbCrc_06.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_06.TabIndex = 95;
            this.lbCrc_06.Text = "CRC";
            // 
            // udDataAddr_06
            // 
            this.udDataAddr_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_06.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_06.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_06.Name = "udDataAddr_06";
            this.udDataAddr_06.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_06.TabIndex = 94;
            this.udDataAddr_06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_06.ValueChanged += new System.EventHandler(this.udDataAddr_06_ValueChanged);
            // 
            // lbDataAddr_06
            // 
            this.lbDataAddr_06.AutoSize = true;
            this.lbDataAddr_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_06.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_06.Name = "lbDataAddr_06";
            this.lbDataAddr_06.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_06.TabIndex = 93;
            this.lbDataAddr_06.Text = "Data Address";
            // 
            // udSlaveAddr_06
            // 
            this.udSlaveAddr_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_06.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_06.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_06.Name = "udSlaveAddr_06";
            this.udSlaveAddr_06.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_06.TabIndex = 90;
            this.udSlaveAddr_06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_06.ValueChanged += new System.EventHandler(this.udSlaveAddr_06_ValueChanged);
            // 
            // lbSlaveAddr_06
            // 
            this.lbSlaveAddr_06.AutoSize = true;
            this.lbSlaveAddr_06.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_06.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_06.Name = "lbSlaveAddr_06";
            this.lbSlaveAddr_06.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_06.TabIndex = 89;
            this.lbSlaveAddr_06.Text = "Slave Address";
            // 
            // tpWriteMultipleCoil
            // 
            this.tpWriteMultipleCoil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpWriteMultipleCoil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpWriteMultipleCoil.Controls.Add(this.btSetData_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.tbSetData_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.cbSetData_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbSetData_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.udNumOfData_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbNumOfData_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbFunction_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.rtbMessage_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.tbFunction_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.btSendMassage_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.cbModbusRules_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbModebusRuls_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.cbCrc_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbCrc_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.udDataAddr_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbDataAddr_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.udSlaveAddr_0F);
            this.tpWriteMultipleCoil.Controls.Add(this.lbSlaveAddr_0F);
            this.tpWriteMultipleCoil.Location = new System.Drawing.Point(4, 49);
            this.tpWriteMultipleCoil.Name = "tpWriteMultipleCoil";
            this.tpWriteMultipleCoil.Padding = new System.Windows.Forms.Padding(3);
            this.tpWriteMultipleCoil.Size = new System.Drawing.Size(843, 159);
            this.tpWriteMultipleCoil.TabIndex = 6;
            this.tpWriteMultipleCoil.Text = "Write Multiple Coil";
            // 
            // btSetData_0F
            // 
            this.btSetData_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSetData_0F.Location = new System.Drawing.Point(719, 47);
            this.btSetData_0F.Name = "btSetData_0F";
            this.btSetData_0F.Size = new System.Drawing.Size(102, 24);
            this.btSetData_0F.TabIndex = 120;
            this.btSetData_0F.Text = "Set Data";
            this.btSetData_0F.UseVisualStyleBackColor = true;
            // 
            // tbSetData_0F
            // 
            this.tbSetData_0F.Location = new System.Drawing.Point(649, 48);
            this.tbSetData_0F.MaxLength = 2;
            this.tbSetData_0F.Name = "tbSetData_0F";
            this.tbSetData_0F.Size = new System.Drawing.Size(64, 21);
            this.tbSetData_0F.TabIndex = 119;
            this.tbSetData_0F.Text = "00";
            this.tbSetData_0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSetData_0F
            // 
            this.cbSetData_0F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetData_0F.FormattingEnabled = true;
            this.cbSetData_0F.Location = new System.Drawing.Point(540, 48);
            this.cbSetData_0F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSetData_0F.Name = "cbSetData_0F";
            this.cbSetData_0F.Size = new System.Drawing.Size(103, 20);
            this.cbSetData_0F.TabIndex = 118;
            // 
            // lbSetData_0F
            // 
            this.lbSetData_0F.AutoSize = true;
            this.lbSetData_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSetData_0F.Location = new System.Drawing.Point(482, 52);
            this.lbSetData_0F.Name = "lbSetData_0F";
            this.lbSetData_0F.Size = new System.Drawing.Size(52, 12);
            this.lbSetData_0F.TabIndex = 117;
            this.lbSetData_0F.Text = "Set Data";
            // 
            // udNumOfData_0F
            // 
            this.udNumOfData_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udNumOfData_0F.Location = new System.Drawing.Point(352, 49);
            this.udNumOfData_0F.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udNumOfData_0F.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNumOfData_0F.Name = "udNumOfData_0F";
            this.udNumOfData_0F.Size = new System.Drawing.Size(104, 21);
            this.udNumOfData_0F.TabIndex = 116;
            this.udNumOfData_0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udNumOfData_0F.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumOfData_0F
            // 
            this.lbNumOfData_0F.AutoSize = true;
            this.lbNumOfData_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData_0F.Location = new System.Drawing.Point(253, 52);
            this.lbNumOfData_0F.Name = "lbNumOfData_0F";
            this.lbNumOfData_0F.Size = new System.Drawing.Size(93, 12);
            this.lbNumOfData_0F.TabIndex = 115;
            this.lbNumOfData_0F.Text = "Number of Data";
            // 
            // lbFunction_0F
            // 
            this.lbFunction_0F.AutoSize = true;
            this.lbFunction_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_0F.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_0F.Name = "lbFunction_0F";
            this.lbFunction_0F.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_0F.TabIndex = 105;
            this.lbFunction_0F.Text = "Function Code";
            // 
            // rtbMessage_0F
            // 
            this.rtbMessage_0F.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_0F.Name = "rtbMessage_0F";
            this.rtbMessage_0F.ReadOnly = true;
            this.rtbMessage_0F.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_0F.TabIndex = 114;
            this.rtbMessage_0F.Text = "";
            // 
            // tbFunction_0F
            // 
            this.tbFunction_0F.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_0F.Name = "tbFunction_0F";
            this.tbFunction_0F.ReadOnly = true;
            this.tbFunction_0F.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_0F.TabIndex = 106;
            this.tbFunction_0F.Text = "Write Multiple Coil (0x0F)";
            this.tbFunction_0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_0F
            // 
            this.btSendMassage_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_0F.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_0F.Name = "btSendMassage_0F";
            this.btSendMassage_0F.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_0F.TabIndex = 113;
            this.btSendMassage_0F.Text = "Send Message";
            this.btSendMassage_0F.UseVisualStyleBackColor = true;
            // 
            // cbModbusRules_0F
            // 
            this.cbModbusRules_0F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_0F.FormattingEnabled = true;
            this.cbModbusRules_0F.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_0F.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_0F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_0F.Name = "cbModbusRules_0F";
            this.cbModbusRules_0F.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_0F.TabIndex = 112;
            // 
            // lbModebusRuls_0F
            // 
            this.lbModebusRuls_0F.AutoSize = true;
            this.lbModebusRuls_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_0F.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_0F.Name = "lbModebusRuls_0F";
            this.lbModebusRuls_0F.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_0F.TabIndex = 111;
            this.lbModebusRuls_0F.Text = "Modbus Rules";
            // 
            // cbCrc_0F
            // 
            this.cbCrc_0F.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_0F.FormattingEnabled = true;
            this.cbCrc_0F.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_0F.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_0F.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_0F.Name = "cbCrc_0F";
            this.cbCrc_0F.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_0F.TabIndex = 110;
            // 
            // lbCrc_0F
            // 
            this.lbCrc_0F.AutoSize = true;
            this.lbCrc_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_0F.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_0F.Name = "lbCrc_0F";
            this.lbCrc_0F.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_0F.TabIndex = 109;
            this.lbCrc_0F.Text = "CRC";
            // 
            // udDataAddr_0F
            // 
            this.udDataAddr_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_0F.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_0F.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_0F.Name = "udDataAddr_0F";
            this.udDataAddr_0F.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_0F.TabIndex = 108;
            this.udDataAddr_0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDataAddr_0F
            // 
            this.lbDataAddr_0F.AutoSize = true;
            this.lbDataAddr_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_0F.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_0F.Name = "lbDataAddr_0F";
            this.lbDataAddr_0F.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_0F.TabIndex = 107;
            this.lbDataAddr_0F.Text = "Data Address";
            // 
            // udSlaveAddr_0F
            // 
            this.udSlaveAddr_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_0F.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_0F.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_0F.Name = "udSlaveAddr_0F";
            this.udSlaveAddr_0F.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_0F.TabIndex = 104;
            this.udSlaveAddr_0F.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSlaveAddr_0F
            // 
            this.lbSlaveAddr_0F.AutoSize = true;
            this.lbSlaveAddr_0F.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_0F.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_0F.Name = "lbSlaveAddr_0F";
            this.lbSlaveAddr_0F.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_0F.TabIndex = 103;
            this.lbSlaveAddr_0F.Text = "Slave Address";
            // 
            // tpWriteMultipleRegister
            // 
            this.tpWriteMultipleRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpWriteMultipleRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpWriteMultipleRegister.Controls.Add(this.tbNumOfData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.udSizeofData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbSizeofData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.btSetData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.tbSetData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.cbSetData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbSetData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbNumOfData_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbFunction_10);
            this.tpWriteMultipleRegister.Controls.Add(this.rtbMessage_10);
            this.tpWriteMultipleRegister.Controls.Add(this.tbFunction_10);
            this.tpWriteMultipleRegister.Controls.Add(this.btSendMassage_10);
            this.tpWriteMultipleRegister.Controls.Add(this.cbModbusRules_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbModebusRuls_10);
            this.tpWriteMultipleRegister.Controls.Add(this.cbCrc_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbCrc_10);
            this.tpWriteMultipleRegister.Controls.Add(this.udDataAddr_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbDataAddr_10);
            this.tpWriteMultipleRegister.Controls.Add(this.udSlaveAddr_10);
            this.tpWriteMultipleRegister.Controls.Add(this.lbSlaveAddr_10);
            this.tpWriteMultipleRegister.Location = new System.Drawing.Point(4, 49);
            this.tpWriteMultipleRegister.Name = "tpWriteMultipleRegister";
            this.tpWriteMultipleRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tpWriteMultipleRegister.Size = new System.Drawing.Size(843, 159);
            this.tpWriteMultipleRegister.TabIndex = 7;
            this.tpWriteMultipleRegister.Text = "Write Multiple Register";
            // 
            // tbNumOfData_10
            // 
            this.tbNumOfData_10.Location = new System.Drawing.Point(352, 48);
            this.tbNumOfData_10.Name = "tbNumOfData_10";
            this.tbNumOfData_10.ReadOnly = true;
            this.tbNumOfData_10.Size = new System.Drawing.Size(104, 21);
            this.tbNumOfData_10.TabIndex = 137;
            this.tbNumOfData_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // udSizeofData_10
            // 
            this.udSizeofData_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSizeofData_10.Location = new System.Drawing.Point(667, 16);
            this.udSizeofData_10.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udSizeofData_10.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSizeofData_10.Name = "udSizeofData_10";
            this.udSizeofData_10.Size = new System.Drawing.Size(104, 21);
            this.udSizeofData_10.TabIndex = 136;
            this.udSizeofData_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSizeofData_10.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSizeofData_10.ValueChanged += new System.EventHandler(this.udSizeofData_10_ValueChanged);
            // 
            // lbSizeofData_10
            // 
            this.lbSizeofData_10.AutoSize = true;
            this.lbSizeofData_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSizeofData_10.Location = new System.Drawing.Point(587, 19);
            this.lbSizeofData_10.Name = "lbSizeofData_10";
            this.lbSizeofData_10.Size = new System.Drawing.Size(73, 12);
            this.lbSizeofData_10.TabIndex = 135;
            this.lbSizeofData_10.Text = "Size of Data";
            // 
            // btSetData_10
            // 
            this.btSetData_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSetData_10.Location = new System.Drawing.Point(717, 47);
            this.btSetData_10.Name = "btSetData_10";
            this.btSetData_10.Size = new System.Drawing.Size(104, 24);
            this.btSetData_10.TabIndex = 134;
            this.btSetData_10.Text = "Set Data";
            this.btSetData_10.UseVisualStyleBackColor = true;
            this.btSetData_10.Click += new System.EventHandler(this.btSetData_10_Click);
            // 
            // tbSetData_10
            // 
            this.tbSetData_10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSetData_10.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbSetData_10.Location = new System.Drawing.Point(647, 48);
            this.tbSetData_10.MaxLength = 4;
            this.tbSetData_10.Name = "tbSetData_10";
            this.tbSetData_10.Size = new System.Drawing.Size(64, 21);
            this.tbSetData_10.TabIndex = 133;
            this.tbSetData_10.Text = "0000";
            this.tbSetData_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSetData_10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSetData_10_KeyPress);
            this.tbSetData_10.Leave += new System.EventHandler(this.tbSetData_10_Leave);
            // 
            // cbSetData_10
            // 
            this.cbSetData_10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSetData_10.FormattingEnabled = true;
            this.cbSetData_10.Location = new System.Drawing.Point(538, 48);
            this.cbSetData_10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSetData_10.Name = "cbSetData_10";
            this.cbSetData_10.Size = new System.Drawing.Size(103, 20);
            this.cbSetData_10.TabIndex = 132;
            this.cbSetData_10.SelectionChangeCommitted += new System.EventHandler(this.cbSetData_10_SelectionChangeCommitted);
            // 
            // lbSetData_10
            // 
            this.lbSetData_10.AutoSize = true;
            this.lbSetData_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSetData_10.Location = new System.Drawing.Point(480, 52);
            this.lbSetData_10.Name = "lbSetData_10";
            this.lbSetData_10.Size = new System.Drawing.Size(52, 12);
            this.lbSetData_10.TabIndex = 131;
            this.lbSetData_10.Text = "Set Data";
            // 
            // lbNumOfData_10
            // 
            this.lbNumOfData_10.AutoSize = true;
            this.lbNumOfData_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData_10.Location = new System.Drawing.Point(253, 52);
            this.lbNumOfData_10.Name = "lbNumOfData_10";
            this.lbNumOfData_10.Size = new System.Drawing.Size(93, 12);
            this.lbNumOfData_10.TabIndex = 129;
            this.lbNumOfData_10.Text = "Number of Data";
            // 
            // lbFunction_10
            // 
            this.lbFunction_10.AutoSize = true;
            this.lbFunction_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction_10.Location = new System.Drawing.Point(17, 18);
            this.lbFunction_10.Name = "lbFunction_10";
            this.lbFunction_10.Size = new System.Drawing.Size(87, 12);
            this.lbFunction_10.TabIndex = 119;
            this.lbFunction_10.Text = "Function Code";
            // 
            // rtbMessage_10
            // 
            this.rtbMessage_10.Location = new System.Drawing.Point(252, 86);
            this.rtbMessage_10.Name = "rtbMessage_10";
            this.rtbMessage_10.ReadOnly = true;
            this.rtbMessage_10.Size = new System.Drawing.Size(421, 55);
            this.rtbMessage_10.TabIndex = 128;
            this.rtbMessage_10.Text = "";
            // 
            // tbFunction_10
            // 
            this.tbFunction_10.Location = new System.Drawing.Point(110, 13);
            this.tbFunction_10.Name = "tbFunction_10";
            this.tbFunction_10.ReadOnly = true;
            this.tbFunction_10.Size = new System.Drawing.Size(221, 21);
            this.tbFunction_10.TabIndex = 120;
            this.tbFunction_10.Text = "Write Multiple Register (0x10)";
            this.tbFunction_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSendMassage_10
            // 
            this.btSendMassage_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_10.Location = new System.Drawing.Point(679, 86);
            this.btSendMassage_10.Name = "btSendMassage_10";
            this.btSendMassage_10.Size = new System.Drawing.Size(142, 55);
            this.btSendMassage_10.TabIndex = 127;
            this.btSendMassage_10.Text = "Send Message";
            this.btSendMassage_10.UseVisualStyleBackColor = true;
            this.btSendMassage_10.Click += new System.EventHandler(this.btSendMassage_10_Click);
            // 
            // cbModbusRules_10
            // 
            this.cbModbusRules_10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules_10.FormattingEnabled = true;
            this.cbModbusRules_10.Items.AddRange(new object[] {
            "M2I MODBUS(MASTER)"});
            this.cbModbusRules_10.Location = new System.Drawing.Point(110, 86);
            this.cbModbusRules_10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules_10.Name = "cbModbusRules_10";
            this.cbModbusRules_10.Size = new System.Drawing.Size(119, 20);
            this.cbModbusRules_10.TabIndex = 126;
            // 
            // lbModebusRuls_10
            // 
            this.lbModebusRuls_10.AutoSize = true;
            this.lbModebusRuls_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls_10.Location = new System.Drawing.Point(17, 89);
            this.lbModebusRuls_10.Name = "lbModebusRuls_10";
            this.lbModebusRuls_10.Size = new System.Drawing.Size(87, 12);
            this.lbModebusRuls_10.TabIndex = 125;
            this.lbModebusRuls_10.Text = "Modbus Rules";
            // 
            // cbCrc_10
            // 
            this.cbCrc_10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc_10.FormattingEnabled = true;
            this.cbCrc_10.Items.AddRange(new object[] {
            "CRC-16"});
            this.cbCrc_10.Location = new System.Drawing.Point(54, 121);
            this.cbCrc_10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc_10.Name = "cbCrc_10";
            this.cbCrc_10.Size = new System.Drawing.Size(175, 20);
            this.cbCrc_10.TabIndex = 124;
            // 
            // lbCrc_10
            // 
            this.lbCrc_10.AutoSize = true;
            this.lbCrc_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc_10.Location = new System.Drawing.Point(17, 124);
            this.lbCrc_10.Name = "lbCrc_10";
            this.lbCrc_10.Size = new System.Drawing.Size(31, 12);
            this.lbCrc_10.TabIndex = 123;
            this.lbCrc_10.Text = "CRC";
            // 
            // udDataAddr_10
            // 
            this.udDataAddr_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr_10.Location = new System.Drawing.Point(110, 50);
            this.udDataAddr_10.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.udDataAddr_10.Name = "udDataAddr_10";
            this.udDataAddr_10.Size = new System.Drawing.Size(119, 21);
            this.udDataAddr_10.TabIndex = 122;
            this.udDataAddr_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udDataAddr_10.ValueChanged += new System.EventHandler(this.udDataAddr_10_ValueChanged);
            // 
            // lbDataAddr_10
            // 
            this.lbDataAddr_10.AutoSize = true;
            this.lbDataAddr_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr_10.Location = new System.Drawing.Point(17, 53);
            this.lbDataAddr_10.Name = "lbDataAddr_10";
            this.lbDataAddr_10.Size = new System.Drawing.Size(81, 12);
            this.lbDataAddr_10.TabIndex = 121;
            this.lbDataAddr_10.Text = "Data Address";
            // 
            // udSlaveAddr_10
            // 
            this.udSlaveAddr_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr_10.Location = new System.Drawing.Point(446, 16);
            this.udSlaveAddr_10.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr_10.Name = "udSlaveAddr_10";
            this.udSlaveAddr_10.Size = new System.Drawing.Size(119, 21);
            this.udSlaveAddr_10.TabIndex = 118;
            this.udSlaveAddr_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.udSlaveAddr_10.ValueChanged += new System.EventHandler(this.udSlaveAddr_10_ValueChanged);
            // 
            // lbSlaveAddr_10
            // 
            this.lbSlaveAddr_10.AutoSize = true;
            this.lbSlaveAddr_10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr_10.Location = new System.Drawing.Point(353, 18);
            this.lbSlaveAddr_10.Name = "lbSlaveAddr_10";
            this.lbSlaveAddr_10.Size = new System.Drawing.Size(87, 12);
            this.lbSlaveAddr_10.TabIndex = 117;
            this.lbSlaveAddr_10.Text = "Slave Address";
            // 
            // tpASCII
            // 
            this.tpASCII.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpASCII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpASCII.Controls.Add(this.gbTail_ASCII);
            this.tpASCII.Controls.Add(this.rtbMessage_ASCII);
            this.tpASCII.Controls.Add(this.btSendMassage_ASCII);
            this.tpASCII.Location = new System.Drawing.Point(4, 49);
            this.tpASCII.Name = "tpASCII";
            this.tpASCII.Padding = new System.Windows.Forms.Padding(3);
            this.tpASCII.Size = new System.Drawing.Size(843, 159);
            this.tpASCII.TabIndex = 8;
            this.tpASCII.Text = "ASCII";
            // 
            // gbTail_ASCII
            // 
            this.gbTail_ASCII.Controls.Add(this.rbNone_ASCII);
            this.gbTail_ASCII.Controls.Add(this.rbCRLF_ASCII);
            this.gbTail_ASCII.Controls.Add(this.rbOnlyLF_ASCII);
            this.gbTail_ASCII.Controls.Add(this.rbOnlyCR_ASCII);
            this.gbTail_ASCII.Location = new System.Drawing.Point(678, 10);
            this.gbTail_ASCII.Name = "gbTail_ASCII";
            this.gbTail_ASCII.Size = new System.Drawing.Size(142, 74);
            this.gbTail_ASCII.TabIndex = 131;
            this.gbTail_ASCII.TabStop = false;
            this.gbTail_ASCII.Text = "Set Tail";
            // 
            // rbNone_ASCII
            // 
            this.rbNone_ASCII.AutoSize = true;
            this.rbNone_ASCII.Location = new System.Drawing.Point(84, 15);
            this.rbNone_ASCII.Name = "rbNone_ASCII";
            this.rbNone_ASCII.Size = new System.Drawing.Size(53, 16);
            this.rbNone_ASCII.TabIndex = 3;
            this.rbNone_ASCII.Text = "None";
            this.rbNone_ASCII.UseVisualStyleBackColor = true;
            // 
            // rbCRLF_ASCII
            // 
            this.rbCRLF_ASCII.AutoSize = true;
            this.rbCRLF_ASCII.Checked = true;
            this.rbCRLF_ASCII.Location = new System.Drawing.Point(8, 51);
            this.rbCRLF_ASCII.Name = "rbCRLF_ASCII";
            this.rbCRLF_ASCII.Size = new System.Drawing.Size(62, 16);
            this.rbCRLF_ASCII.TabIndex = 2;
            this.rbCRLF_ASCII.TabStop = true;
            this.rbCRLF_ASCII.Text = "CR, LF";
            this.rbCRLF_ASCII.UseVisualStyleBackColor = true;
            // 
            // rbOnlyLF_ASCII
            // 
            this.rbOnlyLF_ASCII.AutoSize = true;
            this.rbOnlyLF_ASCII.Location = new System.Drawing.Point(8, 33);
            this.rbOnlyLF_ASCII.Name = "rbOnlyLF_ASCII";
            this.rbOnlyLF_ASCII.Size = new System.Drawing.Size(67, 16);
            this.rbOnlyLF_ASCII.TabIndex = 1;
            this.rbOnlyLF_ASCII.Text = "Only LF";
            this.rbOnlyLF_ASCII.UseVisualStyleBackColor = true;
            // 
            // rbOnlyCR_ASCII
            // 
            this.rbOnlyCR_ASCII.AutoSize = true;
            this.rbOnlyCR_ASCII.Location = new System.Drawing.Point(8, 15);
            this.rbOnlyCR_ASCII.Name = "rbOnlyCR_ASCII";
            this.rbOnlyCR_ASCII.Size = new System.Drawing.Size(70, 16);
            this.rbOnlyCR_ASCII.TabIndex = 0;
            this.rbOnlyCR_ASCII.Text = "Only CR";
            this.rbOnlyCR_ASCII.UseVisualStyleBackColor = true;
            // 
            // rtbMessage_ASCII
            // 
            this.rtbMessage_ASCII.Location = new System.Drawing.Point(17, 13);
            this.rtbMessage_ASCII.Name = "rtbMessage_ASCII";
            this.rtbMessage_ASCII.ReadOnly = true;
            this.rtbMessage_ASCII.Size = new System.Drawing.Size(656, 128);
            this.rtbMessage_ASCII.TabIndex = 130;
            this.rtbMessage_ASCII.Text = "";
            // 
            // btSendMassage_ASCII
            // 
            this.btSendMassage_ASCII.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_ASCII.Location = new System.Drawing.Point(678, 86);
            this.btSendMassage_ASCII.Name = "btSendMassage_ASCII";
            this.btSendMassage_ASCII.Size = new System.Drawing.Size(143, 55);
            this.btSendMassage_ASCII.TabIndex = 129;
            this.btSendMassage_ASCII.Text = "Send Message";
            this.btSendMassage_ASCII.UseVisualStyleBackColor = true;
            // 
            // tpHex
            // 
            this.tpHex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpHex.Controls.Add(this.gbTail_Hex);
            this.tpHex.Controls.Add(this.rtbMessage_Hex);
            this.tpHex.Controls.Add(this.btSendMassage_Hex);
            this.tpHex.Location = new System.Drawing.Point(4, 49);
            this.tpHex.Name = "tpHex";
            this.tpHex.Padding = new System.Windows.Forms.Padding(3);
            this.tpHex.Size = new System.Drawing.Size(843, 159);
            this.tpHex.TabIndex = 9;
            this.tpHex.Text = "Hex";
            // 
            // gbTail_Hex
            // 
            this.gbTail_Hex.Controls.Add(this.rbNone_Hex);
            this.gbTail_Hex.Controls.Add(this.rbCRLF_Hex);
            this.gbTail_Hex.Controls.Add(this.rbOnlyLF_Hex);
            this.gbTail_Hex.Controls.Add(this.rbOnlyCR_Hex);
            this.gbTail_Hex.Location = new System.Drawing.Point(678, 10);
            this.gbTail_Hex.Name = "gbTail_Hex";
            this.gbTail_Hex.Size = new System.Drawing.Size(142, 74);
            this.gbTail_Hex.TabIndex = 134;
            this.gbTail_Hex.TabStop = false;
            this.gbTail_Hex.Text = "Set Tail";
            // 
            // rbNone_Hex
            // 
            this.rbNone_Hex.AutoSize = true;
            this.rbNone_Hex.Location = new System.Drawing.Point(84, 15);
            this.rbNone_Hex.Name = "rbNone_Hex";
            this.rbNone_Hex.Size = new System.Drawing.Size(53, 16);
            this.rbNone_Hex.TabIndex = 3;
            this.rbNone_Hex.Text = "None";
            this.rbNone_Hex.UseVisualStyleBackColor = true;
            // 
            // rbCRLF_Hex
            // 
            this.rbCRLF_Hex.AutoSize = true;
            this.rbCRLF_Hex.Checked = true;
            this.rbCRLF_Hex.Location = new System.Drawing.Point(8, 51);
            this.rbCRLF_Hex.Name = "rbCRLF_Hex";
            this.rbCRLF_Hex.Size = new System.Drawing.Size(62, 16);
            this.rbCRLF_Hex.TabIndex = 2;
            this.rbCRLF_Hex.TabStop = true;
            this.rbCRLF_Hex.Text = "CR, LF";
            this.rbCRLF_Hex.UseVisualStyleBackColor = true;
            // 
            // rbOnlyLF_Hex
            // 
            this.rbOnlyLF_Hex.AutoSize = true;
            this.rbOnlyLF_Hex.Location = new System.Drawing.Point(8, 33);
            this.rbOnlyLF_Hex.Name = "rbOnlyLF_Hex";
            this.rbOnlyLF_Hex.Size = new System.Drawing.Size(67, 16);
            this.rbOnlyLF_Hex.TabIndex = 1;
            this.rbOnlyLF_Hex.Text = "Only LF";
            this.rbOnlyLF_Hex.UseVisualStyleBackColor = true;
            // 
            // rbOnlyCR_Hex
            // 
            this.rbOnlyCR_Hex.AutoSize = true;
            this.rbOnlyCR_Hex.Location = new System.Drawing.Point(8, 15);
            this.rbOnlyCR_Hex.Name = "rbOnlyCR_Hex";
            this.rbOnlyCR_Hex.Size = new System.Drawing.Size(70, 16);
            this.rbOnlyCR_Hex.TabIndex = 0;
            this.rbOnlyCR_Hex.Text = "Only CR";
            this.rbOnlyCR_Hex.UseVisualStyleBackColor = true;
            // 
            // rtbMessage_Hex
            // 
            this.rtbMessage_Hex.Location = new System.Drawing.Point(17, 13);
            this.rtbMessage_Hex.Name = "rtbMessage_Hex";
            this.rtbMessage_Hex.ReadOnly = true;
            this.rtbMessage_Hex.Size = new System.Drawing.Size(656, 128);
            this.rtbMessage_Hex.TabIndex = 133;
            this.rtbMessage_Hex.Text = "";
            // 
            // btSendMassage_Hex
            // 
            this.btSendMassage_Hex.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage_Hex.Location = new System.Drawing.Point(678, 86);
            this.btSendMassage_Hex.Name = "btSendMassage_Hex";
            this.btSendMassage_Hex.Size = new System.Drawing.Size(143, 55);
            this.btSendMassage_Hex.TabIndex = 132;
            this.btSendMassage_Hex.Text = "Send Message";
            this.btSendMassage_Hex.UseVisualStyleBackColor = true;
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.tcCommunicationTools);
            this.gbTools.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbTools.Location = new System.Drawing.Point(267, 12);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(875, 245);
            this.gbTools.TabIndex = 8;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1154, 581);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gbReceiverLog);
            this.Controls.Add(this.gbTransmitterLog);
            this.Controls.Add(this.gbSeriarSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODBUS TEST (SERIAR)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbSeriarSetting.ResumeLayout(false);
            this.gbSeriarSetting.PerformLayout();
            this.gbTransmitterLog.ResumeLayout(false);
            this.gbReceiverLog.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.tcCommunicationTools.ResumeLayout(false);
            this.tpReadSingleCoil.ResumeLayout(false);
            this.tpReadSingleCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_01)).EndInit();
            this.tpReadDiscreteInputs.ResumeLayout(false);
            this.tpReadDiscreteInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_02)).EndInit();
            this.tpReadHoldingRegister.ResumeLayout(false);
            this.tpReadHoldingRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_03)).EndInit();
            this.tpReadInputRegister.ResumeLayout(false);
            this.tpReadInputRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_04)).EndInit();
            this.tpWriteSingleCoil.ResumeLayout(false);
            this.tpWriteSingleCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_05)).EndInit();
            this.tpWriteSingleRegister.ResumeLayout(false);
            this.tpWriteSingleRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_06)).EndInit();
            this.tpWriteMultipleCoil.ResumeLayout(false);
            this.tpWriteMultipleCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udNumOfData_0F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_0F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_0F)).EndInit();
            this.tpWriteMultipleRegister.ResumeLayout(false);
            this.tpWriteMultipleRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSizeofData_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr_10)).EndInit();
            this.tpASCII.ResumeLayout(false);
            this.gbTail_ASCII.ResumeLayout(false);
            this.gbTail_ASCII.PerformLayout();
            this.tpHex.ResumeLayout(false);
            this.gbTail_Hex.ResumeLayout(false);
            this.gbTail_Hex.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSeriarSetting;
        private System.Windows.Forms.Label lbStopBits;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbPortName;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbDataBits;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.GroupBox gbTransmitterLog;
        private System.Windows.Forms.ListBox lbTransmitter;
        private System.Windows.Forms.GroupBox gbReceiverLog;
        private System.Windows.Forms.ListBox lbReceiver;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel rsslName;
        private System.Windows.Forms.TabControl tcCommunicationTools;
        private System.Windows.Forms.TabPage tpReadSingleCoil;
        private System.Windows.Forms.TabPage tpReadDiscreteInputs;
        private System.Windows.Forms.TabPage tpReadHoldingRegister;
        private System.Windows.Forms.TabPage tpReadInputRegister;
        private System.Windows.Forms.TabPage tpWriteSingleCoil;
        private System.Windows.Forms.TabPage tpWriteSingleRegister;
        private System.Windows.Forms.TabPage tpWriteMultipleCoil;
        private System.Windows.Forms.TabPage tpWriteMultipleRegister;
        private System.Windows.Forms.TabPage tpASCII;
        private System.Windows.Forms.TabPage tpHex;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.RichTextBox rtbMessage_01;
        private System.Windows.Forms.Button btSendMassage_01;
        private System.Windows.Forms.ComboBox cbModbusRules_01;
        private System.Windows.Forms.Label lbModebusRuls_01;
        private System.Windows.Forms.ComboBox cbCrc_01;
        private System.Windows.Forms.Label lbCrc_01;
        private System.Windows.Forms.NumericUpDown udDataAddr_01;
        private System.Windows.Forms.Label lbDataAddr_01;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_01;
        private System.Windows.Forms.Label lbSlaveAddr_01;
        private System.Windows.Forms.Label lbFunction_01;
        private System.Windows.Forms.TextBox tbFunction_01;
        private System.Windows.Forms.NumericUpDown udNumOfData_01;
        private System.Windows.Forms.Label lbNumOfData_01;
        private System.Windows.Forms.NumericUpDown udNumOfData_02;
        private System.Windows.Forms.Label lbNumOfData_02;
        private System.Windows.Forms.Label lbFunction_02;
        private System.Windows.Forms.RichTextBox rtbMessage_02;
        private System.Windows.Forms.TextBox tbFunction_02;
        private System.Windows.Forms.Button btSendMassage_02;
        private System.Windows.Forms.ComboBox cbModbusRules_02;
        private System.Windows.Forms.Label lbModebusRuls_02;
        private System.Windows.Forms.ComboBox cbCrc_02;
        private System.Windows.Forms.Label lbCrc_02;
        private System.Windows.Forms.NumericUpDown udDataAddr_02;
        private System.Windows.Forms.Label lbDataAddr_02;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_02;
        private System.Windows.Forms.Label lbSlaveAddr_02;
        private System.Windows.Forms.NumericUpDown udNumOfData_03;
        private System.Windows.Forms.Label lbNumOfData_03;
        private System.Windows.Forms.Label lbFunction_03;
        private System.Windows.Forms.RichTextBox rtbMessage_03;
        private System.Windows.Forms.TextBox tbFunction_3;
        private System.Windows.Forms.Button btSendMassage_03;
        private System.Windows.Forms.ComboBox cbModbusRules_03;
        private System.Windows.Forms.Label lbModebusRuls_03;
        private System.Windows.Forms.ComboBox cbCrc_03;
        private System.Windows.Forms.Label lbCrc_03;
        private System.Windows.Forms.NumericUpDown udDataAddr_03;
        private System.Windows.Forms.Label lbDataAddr_03;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_03;
        private System.Windows.Forms.Label lbSlaveAddr_03;
        private System.Windows.Forms.NumericUpDown udNumOfData_04;
        private System.Windows.Forms.Label lbNumOfData_04;
        private System.Windows.Forms.Label lbFunction_04;
        private System.Windows.Forms.RichTextBox rtbMessage_04;
        private System.Windows.Forms.TextBox tbFunction_04;
        private System.Windows.Forms.Button btSendMassage_04;
        private System.Windows.Forms.ComboBox cbModbusRules_04;
        private System.Windows.Forms.Label lbModebusRuls_04;
        private System.Windows.Forms.ComboBox cbCrc_04;
        private System.Windows.Forms.Label lbCrc_04;
        private System.Windows.Forms.NumericUpDown udDataAddr_04;
        private System.Windows.Forms.Label lbDataAddr_04;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_04;
        private System.Windows.Forms.Label lbSlaveAddr_04;
        private System.Windows.Forms.Label lbForceData_05;
        private System.Windows.Forms.Label lbFunction_05;
        private System.Windows.Forms.RichTextBox rtbMessage_05;
        private System.Windows.Forms.TextBox tbFunction_05;
        private System.Windows.Forms.Button btSendMassage_05;
        private System.Windows.Forms.ComboBox cbModbusRules_05;
        private System.Windows.Forms.Label lbModebusRuls_05;
        private System.Windows.Forms.ComboBox cbCrc_05;
        private System.Windows.Forms.Label lbCrc_05;
        private System.Windows.Forms.NumericUpDown udDataAddr_05;
        private System.Windows.Forms.Label lbDataAddr_05;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_05;
        private System.Windows.Forms.Label lbSlaveAddr_05;
        private System.Windows.Forms.Label lbPresetData_06;
        private System.Windows.Forms.Label lbFunction_06;
        private System.Windows.Forms.RichTextBox rtbMessage_06;
        private System.Windows.Forms.TextBox tbFunction_06;
        private System.Windows.Forms.Button btSendMassage_06;
        private System.Windows.Forms.ComboBox cbModbusRules_06;
        private System.Windows.Forms.Label lbModebusRuls_06;
        private System.Windows.Forms.ComboBox cbCrc_06;
        private System.Windows.Forms.Label lbCrc_06;
        private System.Windows.Forms.NumericUpDown udDataAddr_06;
        private System.Windows.Forms.Label lbDataAddr_06;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_06;
        private System.Windows.Forms.Label lbSlaveAddr_06;
        private System.Windows.Forms.NumericUpDown udNumOfData_0F;
        private System.Windows.Forms.Label lbNumOfData_0F;
        private System.Windows.Forms.Label lbFunction_0F;
        private System.Windows.Forms.RichTextBox rtbMessage_0F;
        private System.Windows.Forms.TextBox tbFunction_0F;
        private System.Windows.Forms.Button btSendMassage_0F;
        private System.Windows.Forms.ComboBox cbModbusRules_0F;
        private System.Windows.Forms.Label lbModebusRuls_0F;
        private System.Windows.Forms.ComboBox cbCrc_0F;
        private System.Windows.Forms.Label lbCrc_0F;
        private System.Windows.Forms.NumericUpDown udDataAddr_0F;
        private System.Windows.Forms.Label lbDataAddr_0F;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_0F;
        private System.Windows.Forms.Label lbSlaveAddr_0F;
        private System.Windows.Forms.Label lbNumOfData_10;
        private System.Windows.Forms.Label lbFunction_10;
        private System.Windows.Forms.RichTextBox rtbMessage_10;
        private System.Windows.Forms.TextBox tbFunction_10;
        private System.Windows.Forms.Button btSendMassage_10;
        private System.Windows.Forms.ComboBox cbModbusRules_10;
        private System.Windows.Forms.Label lbModebusRuls_10;
        private System.Windows.Forms.ComboBox cbCrc_10;
        private System.Windows.Forms.Label lbCrc_10;
        private System.Windows.Forms.NumericUpDown udDataAddr_10;
        private System.Windows.Forms.Label lbDataAddr_10;
        private System.Windows.Forms.NumericUpDown udSlaveAddr_10;
        private System.Windows.Forms.Label lbSlaveAddr_10;
        private System.Windows.Forms.RichTextBox rtbMessage_ASCII;
        private System.Windows.Forms.Button btSendMassage_ASCII;
        private System.Windows.Forms.GroupBox gbTail_ASCII;
        private System.Windows.Forms.RadioButton rbOnlyCR_ASCII;
        private System.Windows.Forms.RadioButton rbOnlyLF_ASCII;
        private System.Windows.Forms.RadioButton rbCRLF_ASCII;
        private System.Windows.Forms.RadioButton rbNone_ASCII;
        private System.Windows.Forms.GroupBox gbTail_Hex;
        private System.Windows.Forms.RadioButton rbNone_Hex;
        private System.Windows.Forms.RadioButton rbCRLF_Hex;
        private System.Windows.Forms.RadioButton rbOnlyLF_Hex;
        private System.Windows.Forms.RadioButton rbOnlyCR_Hex;
        private System.Windows.Forms.RichTextBox rtbMessage_Hex;
        private System.Windows.Forms.Button btSendMassage_Hex;
        private System.Windows.Forms.ComboBox cbForceData_05;
        private System.Windows.Forms.Button btSetData_0F;
        private System.Windows.Forms.ComboBox cbSetData_0F;
        private System.Windows.Forms.Label lbSetData_0F;
        private System.Windows.Forms.Button btSetData_10;
        private System.Windows.Forms.TextBox tbSetData_10;
        private System.Windows.Forms.ComboBox cbSetData_10;
        private System.Windows.Forms.Label lbSetData_10;
        private System.Windows.Forms.NumericUpDown udSizeofData_10;
        private System.Windows.Forms.Label lbSizeofData_10;
        private System.Windows.Forms.TextBox tbPresetData_06;
        private System.Windows.Forms.TextBox tbSetData_0F;
        private System.Windows.Forms.TextBox tbNumOfData_10;
    }
}

