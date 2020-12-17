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
            this.gbModbusTools = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbModbusRules = new System.Windows.Forms.ComboBox();
            this.lbModebusRuls = new System.Windows.Forms.Label();
            this.cbCrc = new System.Windows.Forms.ComboBox();
            this.lbCrc = new System.Windows.Forms.Label();
            this.btSetData = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lbSetData = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbNumOfData = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.lbRawData = new System.Windows.Forms.Label();
            this.udDataAddr = new System.Windows.Forms.NumericUpDown();
            this.lbDataAddr = new System.Windows.Forms.Label();
            this.udSlaveAddr = new System.Windows.Forms.NumericUpDown();
            this.lbSlaveAddr = new System.Windows.Forms.Label();
            this.tbFunction = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbFunction = new System.Windows.Forms.Label();
            this.gbTransmitterLog = new System.Windows.Forms.GroupBox();
            this.lbTransmitter = new System.Windows.Forms.ListBox();
            this.gbReceiverLog = new System.Windows.Forms.GroupBox();
            this.lbReceiver = new System.Windows.Forms.ListBox();
            this.gbTransmitterTools = new System.Windows.Forms.GroupBox();
            this.rbChar = new System.Windows.Forms.RadioButton();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.btSendMassage = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.rsslName = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbSeriarSetting.SuspendLayout();
            this.gbModbusTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr)).BeginInit();
            this.gbTransmitterLog.SuspendLayout();
            this.gbReceiverLog.SuspendLayout();
            this.gbTransmitterTools.SuspendLayout();
            this.ssStatus.SuspendLayout();
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
            this.lbStopBits.Size = new System.Drawing.Size(60, 15);
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
            this.cbParity.Size = new System.Drawing.Size(138, 23);
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
            this.cbDataBits.Size = new System.Drawing.Size(138, 23);
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
            this.cbPortName.Size = new System.Drawing.Size(138, 23);
            this.cbPortName.TabIndex = 14;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbParity.Location = new System.Drawing.Point(6, 92);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(66, 15);
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
            // 
            // lbDataBits
            // 
            this.lbDataBits.AutoSize = true;
            this.lbDataBits.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataBits.Location = new System.Drawing.Point(6, 124);
            this.lbDataBits.Name = "lbDataBits";
            this.lbDataBits.Size = new System.Drawing.Size(71, 15);
            this.lbDataBits.TabIndex = 21;
            this.lbDataBits.Text = "Data Size";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbPortName.Location = new System.Drawing.Point(6, 27);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(75, 15);
            this.lbPortName.TabIndex = 15;
            this.lbPortName.Text = "Port Name";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbBaudRate.Location = new System.Drawing.Point(6, 59);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(76, 15);
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
            this.cbStopBits.Size = new System.Drawing.Size(138, 23);
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
            this.cbBaudRate.Size = new System.Drawing.Size(138, 23);
            this.cbBaudRate.TabIndex = 16;
            // 
            // gbModbusTools
            // 
            this.gbModbusTools.Controls.Add(this.button1);
            this.gbModbusTools.Controls.Add(this.cbModbusRules);
            this.gbModbusTools.Controls.Add(this.lbModebusRuls);
            this.gbModbusTools.Controls.Add(this.cbCrc);
            this.gbModbusTools.Controls.Add(this.lbCrc);
            this.gbModbusTools.Controls.Add(this.btSetData);
            this.gbModbusTools.Controls.Add(this.comboBox2);
            this.gbModbusTools.Controls.Add(this.numericUpDown2);
            this.gbModbusTools.Controls.Add(this.lbSetData);
            this.gbModbusTools.Controls.Add(this.numericUpDown1);
            this.gbModbusTools.Controls.Add(this.lbNumOfData);
            this.gbModbusTools.Controls.Add(this.tbData);
            this.gbModbusTools.Controls.Add(this.lbRawData);
            this.gbModbusTools.Controls.Add(this.udDataAddr);
            this.gbModbusTools.Controls.Add(this.lbDataAddr);
            this.gbModbusTools.Controls.Add(this.udSlaveAddr);
            this.gbModbusTools.Controls.Add(this.lbSlaveAddr);
            this.gbModbusTools.Controls.Add(this.tbFunction);
            this.gbModbusTools.Controls.Add(this.comboBox1);
            this.gbModbusTools.Controls.Add(this.lbFunction);
            this.gbModbusTools.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbModbusTools.Location = new System.Drawing.Point(278, 12);
            this.gbModbusTools.Name = "gbModbusTools";
            this.gbModbusTools.Size = new System.Drawing.Size(864, 154);
            this.gbModbusTools.TabIndex = 2;
            this.gbModbusTools.TabStop = false;
            this.gbModbusTools.Text = "Modbus Tools";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(635, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 26);
            this.button1.TabIndex = 41;
            this.button1.Text = "Create Modbus Message";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbModbusRules
            // 
            this.cbModbusRules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModbusRules.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbModbusRules.FormattingEnabled = true;
            this.cbModbusRules.Location = new System.Drawing.Point(430, 121);
            this.cbModbusRules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbModbusRules.Name = "cbModbusRules";
            this.cbModbusRules.Size = new System.Drawing.Size(199, 23);
            this.cbModbusRules.TabIndex = 40;
            // 
            // lbModebusRuls
            // 
            this.lbModebusRuls.AutoSize = true;
            this.lbModebusRuls.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbModebusRuls.Location = new System.Drawing.Point(310, 124);
            this.lbModebusRuls.Name = "lbModebusRuls";
            this.lbModebusRuls.Size = new System.Drawing.Size(102, 15);
            this.lbModebusRuls.TabIndex = 39;
            this.lbModebusRuls.Text = "Modbus Rules";
            // 
            // cbCrc
            // 
            this.cbCrc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCrc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbCrc.FormattingEnabled = true;
            this.cbCrc.Location = new System.Drawing.Point(62, 121);
            this.cbCrc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCrc.Name = "cbCrc";
            this.cbCrc.Size = new System.Drawing.Size(175, 23);
            this.cbCrc.TabIndex = 38;
            // 
            // lbCrc
            // 
            this.lbCrc.AutoSize = true;
            this.lbCrc.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbCrc.Location = new System.Drawing.Point(8, 124);
            this.lbCrc.Name = "lbCrc";
            this.lbCrc.Size = new System.Drawing.Size(37, 15);
            this.lbCrc.TabIndex = 37;
            this.lbCrc.Text = "CRC";
            // 
            // btSetData
            // 
            this.btSetData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSetData.Location = new System.Drawing.Point(711, 51);
            this.btSetData.Name = "btSetData";
            this.btSetData.Size = new System.Drawing.Size(142, 23);
            this.btSetData.TabIndex = 36;
            this.btSetData.Text = "Set Data";
            this.btSetData.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(430, 53);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 23);
            this.comboBox2.TabIndex = 25;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown2.Location = new System.Drawing.Point(601, 52);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(104, 25);
            this.numericUpDown2.TabIndex = 35;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSetData
            // 
            this.lbSetData.AutoSize = true;
            this.lbSetData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSetData.Location = new System.Drawing.Point(310, 59);
            this.lbSetData.Name = "lbSetData";
            this.lbSetData.Size = new System.Drawing.Size(64, 15);
            this.lbSetData.TabIndex = 34;
            this.lbSetData.Text = "Set Data";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(133, 88);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 25);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumOfData
            // 
            this.lbNumOfData.AutoSize = true;
            this.lbNumOfData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbNumOfData.Location = new System.Drawing.Point(8, 92);
            this.lbNumOfData.Name = "lbNumOfData";
            this.lbNumOfData.Size = new System.Drawing.Size(108, 15);
            this.lbNumOfData.TabIndex = 32;
            this.lbNumOfData.Text = "Number of Data";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(430, 87);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(423, 25);
            this.tbData.TabIndex = 31;
            // 
            // lbRawData
            // 
            this.lbRawData.AutoSize = true;
            this.lbRawData.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbRawData.Location = new System.Drawing.Point(310, 91);
            this.lbRawData.Name = "lbRawData";
            this.lbRawData.Size = new System.Drawing.Size(70, 15);
            this.lbRawData.TabIndex = 30;
            this.lbRawData.Text = "Raw Data";
            // 
            // udDataAddr
            // 
            this.udDataAddr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udDataAddr.Location = new System.Drawing.Point(133, 54);
            this.udDataAddr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udDataAddr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udDataAddr.Name = "udDataAddr";
            this.udDataAddr.Size = new System.Drawing.Size(104, 25);
            this.udDataAddr.TabIndex = 29;
            this.udDataAddr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDataAddr
            // 
            this.lbDataAddr.AutoSize = true;
            this.lbDataAddr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDataAddr.Location = new System.Drawing.Point(8, 59);
            this.lbDataAddr.Name = "lbDataAddr";
            this.lbDataAddr.Size = new System.Drawing.Size(95, 15);
            this.lbDataAddr.TabIndex = 28;
            this.lbDataAddr.Text = "Data Address";
            // 
            // udSlaveAddr
            // 
            this.udSlaveAddr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.udSlaveAddr.Location = new System.Drawing.Point(133, 21);
            this.udSlaveAddr.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udSlaveAddr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udSlaveAddr.Name = "udSlaveAddr";
            this.udSlaveAddr.Size = new System.Drawing.Size(104, 25);
            this.udSlaveAddr.TabIndex = 27;
            this.udSlaveAddr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbSlaveAddr
            // 
            this.lbSlaveAddr.AutoSize = true;
            this.lbSlaveAddr.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSlaveAddr.Location = new System.Drawing.Point(8, 28);
            this.lbSlaveAddr.Name = "lbSlaveAddr";
            this.lbSlaveAddr.Size = new System.Drawing.Size(102, 15);
            this.lbSlaveAddr.TabIndex = 26;
            this.lbSlaveAddr.Text = "Slave Address";
            // 
            // tbFunction
            // 
            this.tbFunction.Location = new System.Drawing.Point(789, 21);
            this.tbFunction.Name = "tbFunction";
            this.tbFunction.Size = new System.Drawing.Size(64, 25);
            this.tbFunction.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(430, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 23);
            this.comboBox1.TabIndex = 25;
            // 
            // lbFunction
            // 
            this.lbFunction.AutoSize = true;
            this.lbFunction.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbFunction.Location = new System.Drawing.Point(310, 28);
            this.lbFunction.Name = "lbFunction";
            this.lbFunction.Size = new System.Drawing.Size(103, 15);
            this.lbFunction.TabIndex = 25;
            this.lbFunction.Text = "Function Code";
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
            this.lbTransmitter.ItemHeight = 15;
            this.lbTransmitter.Location = new System.Drawing.Point(6, 20);
            this.lbTransmitter.Name = "lbTransmitter";
            this.lbTransmitter.Size = new System.Drawing.Size(544, 259);
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
            this.lbReceiver.ItemHeight = 15;
            this.lbReceiver.Location = new System.Drawing.Point(6, 20);
            this.lbReceiver.Name = "lbReceiver";
            this.lbReceiver.Size = new System.Drawing.Size(544, 259);
            this.lbReceiver.TabIndex = 1;
            // 
            // gbTransmitterTools
            // 
            this.gbTransmitterTools.Controls.Add(this.rbChar);
            this.gbTransmitterTools.Controls.Add(this.rbInt);
            this.gbTransmitterTools.Controls.Add(this.rbHex);
            this.gbTransmitterTools.Controls.Add(this.btSendMassage);
            this.gbTransmitterTools.Controls.Add(this.tbMessage);
            this.gbTransmitterTools.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbTransmitterTools.Location = new System.Drawing.Point(278, 172);
            this.gbTransmitterTools.Name = "gbTransmitterTools";
            this.gbTransmitterTools.Size = new System.Drawing.Size(864, 85);
            this.gbTransmitterTools.TabIndex = 5;
            this.gbTransmitterTools.TabStop = false;
            this.gbTransmitterTools.Text = "Transmitter Tools";
            // 
            // rbChar
            // 
            this.rbChar.AutoSize = true;
            this.rbChar.Location = new System.Drawing.Point(127, 26);
            this.rbChar.Name = "rbChar";
            this.rbChar.Size = new System.Drawing.Size(62, 19);
            this.rbChar.TabIndex = 45;
            this.rbChar.Text = "Char";
            this.rbChar.UseVisualStyleBackColor = true;
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Location = new System.Drawing.Point(75, 26);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(46, 19);
            this.rbInt.TabIndex = 44;
            this.rbInt.Text = "Int";
            this.rbInt.UseVisualStyleBackColor = true;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = true;
            this.rbHex.Location = new System.Drawing.Point(11, 26);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(58, 19);
            this.rbHex.TabIndex = 43;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            // 
            // btSendMassage
            // 
            this.btSendMassage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btSendMassage.Location = new System.Drawing.Point(711, 16);
            this.btSendMassage.Name = "btSendMassage";
            this.btSendMassage.Size = new System.Drawing.Size(142, 61);
            this.btSendMassage.TabIndex = 42;
            this.btSendMassage.Text = "Send Message";
            this.btSendMassage.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbMessage.Location = new System.Drawing.Point(11, 51);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(694, 25);
            this.tbMessage.TabIndex = 0;
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslConnectionStatus,
            this.tsslVersion,
            this.rsslName});
            this.ssStatus.Location = new System.Drawing.Point(0, 556);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1154, 25);
            this.ssStatus.TabIndex = 6;
            this.ssStatus.Text = "ssStatus";
            // 
            // tsslConnectionStatus
            // 
            this.tsslConnectionStatus.Name = "tsslConnectionStatus";
            this.tsslConnectionStatus.Size = new System.Drawing.Size(134, 20);
            this.tsslConnectionStatus.Text = "Connection Status";
            this.tsslConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(483, 20);
            this.tsslVersion.Spring = true;
            this.tsslVersion.Text = "0.0.0.0 ver.";
            this.tsslVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rsslName
            // 
            this.rsslName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rsslName.Name = "rsslName";
            this.rsslName.Size = new System.Drawing.Size(483, 20);
            this.rsslName.Spring = true;
            this.rsslName.Text = "Copyright © 2020 by DjwChoi (Juwon Choi) All rights reserved";
            this.rsslName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1154, 581);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gbTransmitterTools);
            this.Controls.Add(this.gbReceiverLog);
            this.Controls.Add(this.gbTransmitterLog);
            this.Controls.Add(this.gbModbusTools);
            this.Controls.Add(this.gbSeriarSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODBUS TEST (SERIAR)";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbSeriarSetting.ResumeLayout(false);
            this.gbSeriarSetting.PerformLayout();
            this.gbModbusTools.ResumeLayout(false);
            this.gbModbusTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udDataAddr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udSlaveAddr)).EndInit();
            this.gbTransmitterLog.ResumeLayout(false);
            this.gbReceiverLog.ResumeLayout(false);
            this.gbTransmitterTools.ResumeLayout(false);
            this.gbTransmitterTools.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbModbusTools;
        private System.Windows.Forms.GroupBox gbTransmitterLog;
        private System.Windows.Forms.ListBox lbTransmitter;
        private System.Windows.Forms.GroupBox gbReceiverLog;
        private System.Windows.Forms.ListBox lbReceiver;
        private System.Windows.Forms.TextBox tbFunction;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbFunction;
        private System.Windows.Forms.NumericUpDown udDataAddr;
        private System.Windows.Forms.Label lbDataAddr;
        private System.Windows.Forms.NumericUpDown udSlaveAddr;
        private System.Windows.Forms.Label lbSlaveAddr;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label lbRawData;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbNumOfData;
        private System.Windows.Forms.Button btSetData;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lbSetData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbModbusRules;
        private System.Windows.Forms.Label lbModebusRuls;
        private System.Windows.Forms.ComboBox cbCrc;
        private System.Windows.Forms.Label lbCrc;
        private System.Windows.Forms.GroupBox gbTransmitterTools;
        private System.Windows.Forms.RadioButton rbChar;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.Button btSendMassage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel rsslName;
    }
}

