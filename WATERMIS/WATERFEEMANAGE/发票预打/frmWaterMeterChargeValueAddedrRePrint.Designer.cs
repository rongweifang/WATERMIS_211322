﻿namespace WATERFEEMANAGE
{
    partial class frmWaterMeterChargeValueAddedrRePrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaterMeterChargeValueAddedrRePrint));
            FastReport.Design.DesignerSettings designerSettings1 = new FastReport.Design.DesignerSettings();
            FastReport.Design.DesignerRestrictions designerRestrictions1 = new FastReport.Design.DesignerRestrictions();
            FastReport.Export.Email.EmailSettings emailSettings1 = new FastReport.Export.Email.EmailSettings();
            FastReport.PreviewSettings previewSettings1 = new FastReport.PreviewSettings();
            FastReport.ReportSettings reportSettings1 = new FastReport.ReportSettings();
            this.tb1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNewInvoiceNO = new System.Windows.Forms.TextBox();
            this.cmbBatchNew = new System.Windows.Forms.ComboBox();
            this.labInvoiceNO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btChangeInvoice = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btOther = new System.Windows.Forms.Button();
            this.txtChargeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbInvoiceCancelReason = new System.Windows.Forms.ComboBox();
            this.txtChargeInvoicePrintID = new System.Windows.Forms.TextBox();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.txtStartRow = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndRow = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtInvoiceNO = new System.Windows.Forms.TextBox();
            this.btInvoiceMakeUp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btInvoiceCancel = new System.Windows.Forms.Button();
            this.btInvoicePrint = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgHistoryWaterFee = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbWaterUserType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCharger = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenior = new System.Windows.Forms.TextBox();
            this.btSenior = new System.Windows.Forms.Button();
            this.cmbChargerWorkName = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtWaterUserName = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbInvoicePrintState = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btRight = new System.Windows.Forms.Button();
            this.btLeft = new System.Windows.Forms.Button();
            this.txtYearAndMonth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbWaterMeterType = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.txtWaterUserNO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trMeterReading = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.environmentSettings1 = new FastReport.EnvironmentSettings();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.反月结ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反日结ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgGetFPNO = new System.ComponentModel.BackgroundWorker();
            this.waterUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readMeterRecordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterUserNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterUserAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterMeterNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readMeterRecordYearAndMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterMeterLastNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterMeterEndNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalNumberDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avePriceDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterTotalChargeEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargePriceLS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraChargeLS8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraTotalChargeEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OVERDUEEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalChargeEND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterMeterTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterMeterTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WATERFIXVALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEINVOICEPRINTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALNUMBERCHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WATERTOTALCHARGECHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXTRACHARGECHARGE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXTRACHARGECHARGE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALCHARGECHARGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICEBATCHNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICENO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICECANCEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEIPTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGETYPEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGETYPENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEBCYS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEBCSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEYSQQYE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEYSBCSZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEYSJSYE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEWORKERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGEDATETIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHARGECANCEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAYCHECKSTATES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SETTLEACCOUNTSSSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterReaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterReaderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chargerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICEPRINTSIGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterUserTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterUserTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoryWaterFee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.ColumnCount = 1;
            this.tb1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb1.Controls.Add(this.groupBox2, 0, 1);
            this.tb1.Controls.Add(this.tb2, 0, 0);
            this.tb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb1.Location = new System.Drawing.Point(0, 0);
            this.tb1.Name = "tb1";
            this.tb1.RowCount = 2;
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tb1.Size = new System.Drawing.Size(847, 662);
            this.tb1.TabIndex = 910;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 482);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 177);
            this.groupBox2.TabIndex = 911;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "9999";
            this.groupBox2.Text = "发票开具操作";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNewInvoiceNO);
            this.groupBox3.Controls.Add(this.cmbBatchNew);
            this.groupBox3.Controls.Add(this.labInvoiceNO);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btChangeInvoice);
            this.groupBox3.Location = new System.Drawing.Point(584, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 127);
            this.groupBox3.TabIndex = 803;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "票号变更";
            // 
            // txtNewInvoiceNO
            // 
            this.txtNewInvoiceNO.BackColor = System.Drawing.Color.LightYellow;
            this.txtNewInvoiceNO.Location = new System.Drawing.Point(92, 56);
            this.txtNewInvoiceNO.Name = "txtNewInvoiceNO";
            this.txtNewInvoiceNO.Size = new System.Drawing.Size(125, 26);
            this.txtNewInvoiceNO.TabIndex = 5;
            // 
            // cmbBatchNew
            // 
            this.cmbBatchNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchNew.FormattingEnabled = true;
            this.cmbBatchNew.Location = new System.Drawing.Point(92, 25);
            this.cmbBatchNew.Name = "cmbBatchNew";
            this.cmbBatchNew.Size = new System.Drawing.Size(125, 24);
            this.cmbBatchNew.TabIndex = 110;
            this.cmbBatchNew.SelectionChangeCommitted += new System.EventHandler(this.cmbBatchNew_SelectionChangeCommitted);
            // 
            // labInvoiceNO
            // 
            this.labInvoiceNO.AutoSize = true;
            this.labInvoiceNO.Location = new System.Drawing.Point(15, 61);
            this.labInvoiceNO.Name = "labInvoiceNO";
            this.labInvoiceNO.Size = new System.Drawing.Size(80, 16);
            this.labInvoiceNO.TabIndex = 108;
            this.labInvoiceNO.Text = "新发票号:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "发票批次:";
            // 
            // btChangeInvoice
            // 
            this.btChangeInvoice.Enabled = false;
            this.btChangeInvoice.Location = new System.Drawing.Point(18, 86);
            this.btChangeInvoice.Name = "btChangeInvoice";
            this.btChangeInvoice.Size = new System.Drawing.Size(80, 32);
            this.btChangeInvoice.TabIndex = 6;
            this.btChangeInvoice.Text = "发票变更";
            this.btChangeInvoice.UseVisualStyleBackColor = true;
            this.btChangeInvoice.Click += new System.EventHandler(this.btChangeInvoice_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btOther);
            this.groupBox4.Controls.Add(this.txtChargeID);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cmbInvoiceCancelReason);
            this.groupBox4.Controls.Add(this.txtChargeInvoicePrintID);
            this.groupBox4.Controls.Add(this.cmbBatch);
            this.groupBox4.Controls.Add(this.txtStartRow);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtEndRow);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.txtInvoiceNO);
            this.groupBox4.Controls.Add(this.btInvoiceMakeUp);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btInvoiceCancel);
            this.groupBox4.Controls.Add(this.btInvoicePrint);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(3, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 127);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "9999";
            this.groupBox4.Text = "开票及作废";
            // 
            // btOther
            // 
            this.btOther.Location = new System.Drawing.Point(311, 86);
            this.btOther.Name = "btOther";
            this.btOther.Size = new System.Drawing.Size(113, 32);
            this.btOther.TabIndex = 806;
            this.btOther.Text = "打印其他费用";
            this.btOther.UseVisualStyleBackColor = true;
            this.btOther.Click += new System.EventHandler(this.btOther_Click);
            // 
            // txtChargeID
            // 
            this.txtChargeID.BackColor = System.Drawing.Color.LightYellow;
            this.txtChargeID.Location = new System.Drawing.Point(233, 56);
            this.txtChargeID.Name = "txtChargeID";
            this.txtChargeID.ReadOnly = true;
            this.txtChargeID.Size = new System.Drawing.Size(11, 26);
            this.txtChargeID.TabIndex = 805;
            this.txtChargeID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 80);
            this.label5.TabIndex = 804;
            this.label5.Text = "|\r\n|\r\n|\r\n|\r\n|";
            // 
            // cmbInvoiceCancelReason
            // 
            this.cmbInvoiceCancelReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceCancelReason.FormattingEnabled = true;
            this.cmbInvoiceCancelReason.Items.AddRange(new object[] {
            "",
            "损坏作废",
            "未打作废"});
            this.cmbInvoiceCancelReason.Location = new System.Drawing.Point(453, 53);
            this.cmbInvoiceCancelReason.Name = "cmbInvoiceCancelReason";
            this.cmbInvoiceCancelReason.Size = new System.Drawing.Size(112, 24);
            this.cmbInvoiceCancelReason.TabIndex = 802;
            // 
            // txtChargeInvoicePrintID
            // 
            this.txtChargeInvoicePrintID.BackColor = System.Drawing.Color.LightYellow;
            this.txtChargeInvoicePrintID.Location = new System.Drawing.Point(216, 56);
            this.txtChargeInvoicePrintID.Name = "txtChargeInvoicePrintID";
            this.txtChargeInvoicePrintID.ReadOnly = true;
            this.txtChargeInvoicePrintID.Size = new System.Drawing.Size(11, 26);
            this.txtChargeInvoicePrintID.TabIndex = 122;
            this.txtChargeInvoicePrintID.Visible = false;
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.DropDownWidth = 130;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(85, 25);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(125, 24);
            this.cmbBatch.TabIndex = 110;
            this.cmbBatch.SelectionChangeCommitted += new System.EventHandler(this.cmbBatch_SelectionChangeCommitted);
            // 
            // txtStartRow
            // 
            this.txtStartRow.BackColor = System.Drawing.Color.LightYellow;
            this.txtStartRow.Location = new System.Drawing.Point(85, 89);
            this.txtStartRow.Name = "txtStartRow";
            this.txtStartRow.Size = new System.Drawing.Size(48, 26);
            this.txtStartRow.TabIndex = 114;
            this.txtStartRow.Text = "1";
            this.txtStartRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartRow_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 16);
            this.label21.TabIndex = 803;
            this.label21.Text = "执行行号:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 801;
            this.label9.Text = "作废原因:";
            // 
            // txtEndRow
            // 
            this.txtEndRow.BackColor = System.Drawing.Color.LightYellow;
            this.txtEndRow.Location = new System.Drawing.Point(162, 89);
            this.txtEndRow.Name = "txtEndRow";
            this.txtEndRow.Size = new System.Drawing.Size(48, 26);
            this.txtEndRow.TabIndex = 803;
            this.txtEndRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartRow_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(137, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 16);
            this.label20.TabIndex = 802;
            this.label20.Text = "至";
            // 
            // txtInvoiceNO
            // 
            this.txtInvoiceNO.BackColor = System.Drawing.Color.LightYellow;
            this.txtInvoiceNO.Location = new System.Drawing.Point(85, 56);
            this.txtInvoiceNO.Name = "txtInvoiceNO";
            this.txtInvoiceNO.Size = new System.Drawing.Size(125, 26);
            this.txtInvoiceNO.TabIndex = 9;
            // 
            // btInvoiceMakeUp
            // 
            this.btInvoiceMakeUp.Enabled = false;
            this.btInvoiceMakeUp.Location = new System.Drawing.Point(237, 23);
            this.btInvoiceMakeUp.Name = "btInvoiceMakeUp";
            this.btInvoiceMakeUp.Size = new System.Drawing.Size(80, 32);
            this.btInvoiceMakeUp.TabIndex = 112;
            this.btInvoiceMakeUp.Text = "补打发票";
            this.btInvoiceMakeUp.UseVisualStyleBackColor = true;
            this.btInvoiceMakeUp.Visible = false;
            this.btInvoiceMakeUp.Click += new System.EventHandler(this.btInvoiceMakeUp_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 109;
            this.label8.Text = "发票批次:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "起始号码:";
            // 
            // btInvoiceCancel
            // 
            this.btInvoiceCancel.Enabled = false;
            this.btInvoiceCancel.Location = new System.Drawing.Point(452, 86);
            this.btInvoiceCancel.Name = "btInvoiceCancel";
            this.btInvoiceCancel.Size = new System.Drawing.Size(80, 32);
            this.btInvoiceCancel.TabIndex = 8;
            this.btInvoiceCancel.Text = "发票作废";
            this.btInvoiceCancel.UseVisualStyleBackColor = true;
            this.btInvoiceCancel.Click += new System.EventHandler(this.btInvoiceCancel_Click);
            // 
            // btInvoicePrint
            // 
            this.btInvoicePrint.Enabled = false;
            this.btInvoicePrint.Location = new System.Drawing.Point(221, 86);
            this.btInvoicePrint.Name = "btInvoicePrint";
            this.btInvoicePrint.Size = new System.Drawing.Size(80, 32);
            this.btInvoicePrint.TabIndex = 10;
            this.btInvoicePrint.Text = "打印发票";
            this.btInvoicePrint.UseVisualStyleBackColor = true;
            this.btInvoicePrint.Click += new System.EventHandler(this.btInvoicePrint_Click);
            // 
            // tb2
            // 
            this.tb2.ColumnCount = 1;
            this.tb2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb2.Controls.Add(this.dgHistoryWaterFee, 0, 1);
            this.tb2.Controls.Add(this.groupBox1, 0, 0);
            this.tb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb2.Location = new System.Drawing.Point(3, 3);
            this.tb2.Name = "tb2";
            this.tb2.RowCount = 2;
            this.tb2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tb2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb2.Size = new System.Drawing.Size(841, 473);
            this.tb2.TabIndex = 905;
            // 
            // dgHistoryWaterFee
            // 
            this.dgHistoryWaterFee.AllowUserToAddRows = false;
            this.dgHistoryWaterFee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgHistoryWaterFee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistoryWaterFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgHistoryWaterFee.ColumnHeadersHeight = 25;
            this.dgHistoryWaterFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgHistoryWaterFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.waterUserId,
            this.readMeterRecordId,
            this.waterUserNO,
            this.waterUserName,
            this.waterPhone,
            this.waterUserAddress,
            this.waterMeterNo,
            this.readMeterRecordYearAndMonth,
            this.waterMeterLastNumber,
            this.waterMeterEndNumber,
            this.totalNumber,
            this.totalNumberDescribe,
            this.avePrice,
            this.avePriceDescribe,
            this.waterTotalChargeEND,
            this.extraChargePriceLS1,
            this.extraChargeLS1,
            this.extraChargePriceLS2,
            this.extraChargeLS2,
            this.extraChargePriceLS3,
            this.extraChargeLS3,
            this.extraChargePriceLS4,
            this.extraChargeLS4,
            this.extraChargePriceLS5,
            this.extraChargeLS5,
            this.extraChargePriceLS6,
            this.extraChargeLS6,
            this.extraChargePriceLS7,
            this.extraChargeLS7,
            this.extraChargePriceLS8,
            this.extraChargeLS8,
            this.extraTotalChargeEND,
            this.OVERDUEEND,
            this.totalChargeEND,
            this.waterMeterTypeId,
            this.waterMeterTypeName,
            this.WATERFIXVALUE,
            this.chargeID,
            this.CHARGEINVOICEPRINTID,
            this.TOTALNUMBERCHARGE,
            this.WATERTOTALCHARGECHARGE,
            this.EXTRACHARGECHARGE1,
            this.EXTRACHARGECHARGE2,
            this.TOTALCHARGECHARGE,
            this.INVOICEBATCHNAME,
            this.INVOICENO,
            this.INVOICECANCEL,
            this.RECEIPTNO,
            this.CHARGETYPEID,
            this.CHARGETYPENAME,
            this.CHARGEBCYS,
            this.CHARGEBCSS,
            this.CHARGEYSQQYE,
            this.CHARGEYSBCSZ,
            this.CHARGEYSJSYE,
            this.CHARGEWORKERNAME,
            this.CHARGEDATETIME,
            this.CHARGECANCEL,
            this.DAYCHECKSTATES,
            this.SETTLEACCOUNTSSSID,
            this.meterReaderName,
            this.meterReaderID,
            this.chargerName,
            this.memo,
            this.INVOICEPRINTSIGN,
            this.waterUserTypeId,
            this.waterUserTypeName});
            this.dgHistoryWaterFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistoryWaterFee.Location = new System.Drawing.Point(3, 124);
            this.dgHistoryWaterFee.MultiSelect = false;
            this.dgHistoryWaterFee.Name = "dgHistoryWaterFee";
            this.dgHistoryWaterFee.ReadOnly = true;
            this.dgHistoryWaterFee.RowHeadersWidth = 45;
            this.dgHistoryWaterFee.RowTemplate.Height = 23;
            this.dgHistoryWaterFee.Size = new System.Drawing.Size(835, 346);
            this.dgHistoryWaterFee.TabIndex = 907;
            this.dgHistoryWaterFee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHistoryWaterFee_RowEnter);
            this.dgHistoryWaterFee.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgHistoryWaterFee_CellMouseDown);
            this.dgHistoryWaterFee.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgHistoryWaterFee_CellFormatting);
            this.dgHistoryWaterFee.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgHistoryWaterFee_CellPainting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.cmbWaterUserType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbCharger);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSenior);
            this.groupBox1.Controls.Add(this.btSenior);
            this.groupBox1.Controls.Add(this.cmbChargerWorkName);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtWaterUserName);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.cmbInvoicePrintState);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btRight);
            this.groupBox1.Controls.Add(this.btLeft);
            this.groupBox1.Controls.Add(this.txtYearAndMonth);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbWaterMeterType);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.btSearch);
            this.groupBox1.Controls.Add(this.txtWaterUserNO);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 117);
            this.groupBox1.TabIndex = 906;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "9999";
            this.groupBox1.Text = "查询条件";
            // 
            // cmbWaterUserType
            // 
            this.cmbWaterUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaterUserType.DropDownWidth = 150;
            this.cmbWaterUserType.FormattingEnabled = true;
            this.cmbWaterUserType.Location = new System.Drawing.Point(81, 84);
            this.cmbWaterUserType.Name = "cmbWaterUserType";
            this.cmbWaterUserType.Size = new System.Drawing.Size(100, 24);
            this.cmbWaterUserType.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 154;
            this.label4.Text = "用户类别:";
            // 
            // cmbCharger
            // 
            this.cmbCharger.FormattingEnabled = true;
            this.cmbCharger.Location = new System.Drawing.Point(452, 18);
            this.cmbCharger.Name = "cmbCharger";
            this.cmbCharger.Size = new System.Drawing.Size(100, 24);
            this.cmbCharger.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 144;
            this.label1.Text = "收 费 员:";
            // 
            // txtSenior
            // 
            this.txtSenior.BackColor = System.Drawing.Color.White;
            this.txtSenior.Location = new System.Drawing.Point(581, 17);
            this.txtSenior.Multiline = true;
            this.txtSenior.Name = "txtSenior";
            this.txtSenior.ReadOnly = true;
            this.txtSenior.Size = new System.Drawing.Size(184, 57);
            this.txtSenior.TabIndex = 142;
            this.txtSenior.Visible = false;
            // 
            // btSenior
            // 
            this.btSenior.Location = new System.Drawing.Point(769, 17);
            this.btSenior.Name = "btSenior";
            this.btSenior.Size = new System.Drawing.Size(50, 45);
            this.btSenior.TabIndex = 141;
            this.btSenior.Text = "高级条件";
            this.btSenior.UseVisualStyleBackColor = true;
            this.btSenior.Visible = false;
            this.btSenior.Click += new System.EventHandler(this.btSenior_Click);
            // 
            // cmbChargerWorkName
            // 
            this.cmbChargerWorkName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChargerWorkName.FormattingEnabled = true;
            this.cmbChargerWorkName.Location = new System.Drawing.Point(268, 52);
            this.cmbChargerWorkName.Name = "cmbChargerWorkName";
            this.cmbChargerWorkName.Size = new System.Drawing.Size(100, 24);
            this.cmbChargerWorkName.TabIndex = 131;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(193, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 16);
            this.label25.TabIndex = 132;
            this.label25.Text = "收 款 员:";
            // 
            // txtWaterUserName
            // 
            this.txtWaterUserName.Location = new System.Drawing.Point(268, 17);
            this.txtWaterUserName.Name = "txtWaterUserName";
            this.txtWaterUserName.Size = new System.Drawing.Size(102, 26);
            this.txtWaterUserName.TabIndex = 120;
            this.txtWaterUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChargeNO_KeyDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(193, 22);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 16);
            this.label22.TabIndex = 121;
            this.label22.Text = "用户名称:";
            // 
            // cmbInvoicePrintState
            // 
            this.cmbInvoicePrintState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoicePrintState.DropDownWidth = 120;
            this.cmbInvoicePrintState.FormattingEnabled = true;
            this.cmbInvoicePrintState.Items.AddRange(new object[] {
            "全部",
            "未开票",
            "已开票"});
            this.cmbInvoicePrintState.Location = new System.Drawing.Point(452, 52);
            this.cmbInvoicePrintState.Name = "cmbInvoicePrintState";
            this.cmbInvoicePrintState.Size = new System.Drawing.Size(100, 24);
            this.cmbInvoicePrintState.TabIndex = 115;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 116;
            this.label11.Text = "开票状态:";
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(360, 83);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(27, 24);
            this.btRight.TabIndex = 113;
            this.btRight.Text = ">";
            this.btRight.UseVisualStyleBackColor = true;
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(333, 83);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(27, 24);
            this.btLeft.TabIndex = 114;
            this.btLeft.Text = "<";
            this.btLeft.UseVisualStyleBackColor = true;
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // txtYearAndMonth
            // 
            this.txtYearAndMonth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtYearAndMonth.Location = new System.Drawing.Point(269, 83);
            this.txtYearAndMonth.Name = "txtYearAndMonth";
            this.txtYearAndMonth.ReadOnly = true;
            this.txtYearAndMonth.Size = new System.Drawing.Size(62, 26);
            this.txtYearAndMonth.TabIndex = 112;
            this.txtYearAndMonth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYearAndMonth_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 111;
            this.label10.Text = "抄表月份:";
            // 
            // cmbWaterMeterType
            // 
            this.cmbWaterMeterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWaterMeterType.DropDownWidth = 150;
            this.cmbWaterMeterType.FormattingEnabled = true;
            this.cmbWaterMeterType.Location = new System.Drawing.Point(81, 52);
            this.cmbWaterMeterType.Name = "cmbWaterMeterType";
            this.cmbWaterMeterType.Size = new System.Drawing.Size(100, 24);
            this.cmbWaterMeterType.TabIndex = 109;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(5, 56);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(80, 16);
            this.label56.TabIndex = 110;
            this.label56.Text = "用水性质:";
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(581, 76);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(62, 36);
            this.btSearch.TabIndex = 2;
            this.btSearch.Tag = "";
            this.btSearch.Text = "查询";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // txtWaterUserNO
            // 
            this.txtWaterUserNO.Location = new System.Drawing.Point(81, 17);
            this.txtWaterUserNO.Name = "txtWaterUserNO";
            this.txtWaterUserNO.Size = new System.Drawing.Size(100, 26);
            this.txtWaterUserNO.TabIndex = 0;
            this.txtWaterUserNO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChargeNO_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "用户编号:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trMeterReading);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tb1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 662);
            this.splitContainer1.SplitterDistance = 157;
            this.splitContainer1.TabIndex = 911;
            // 
            // trMeterReading
            // 
            this.trMeterReading.BackColor = System.Drawing.SystemColors.Window;
            this.trMeterReading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trMeterReading.FullRowSelect = true;
            this.trMeterReading.HideSelection = false;
            this.trMeterReading.ImageIndex = 0;
            this.trMeterReading.ImageList = this.imageList1;
            this.trMeterReading.ItemHeight = 22;
            this.trMeterReading.Location = new System.Drawing.Point(0, 0);
            this.trMeterReading.Margin = new System.Windows.Forms.Padding(0);
            this.trMeterReading.Name = "trMeterReading";
            this.trMeterReading.SelectedImageIndex = 1;
            this.trMeterReading.Size = new System.Drawing.Size(157, 662);
            this.trMeterReading.TabIndex = 11;
            this.trMeterReading.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trMeterReading_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.ico");
            this.imageList1.Images.SetKeyName(1, "open.ico");
            // 
            // environmentSettings1
            // 
            designerSettings1.ApplicationConnection = null;
            designerSettings1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            designerSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("designerSettings1.Icon")));
            designerSettings1.Restrictions = designerRestrictions1;
            designerSettings1.Text = "";
            this.environmentSettings1.DesignerSettings = designerSettings1;
            emailSettings1.Address = "";
            emailSettings1.Host = "";
            emailSettings1.MessageTemplate = "";
            emailSettings1.Name = "";
            emailSettings1.Password = "";
            emailSettings1.UserName = "";
            this.environmentSettings1.EmailSettings = emailSettings1;
            previewSettings1.Buttons = ((FastReport.PreviewButtons)((((FastReport.PreviewButtons.Print | FastReport.PreviewButtons.Zoom)
                        | FastReport.PreviewButtons.PageSetup)
                        | FastReport.PreviewButtons.Close)));
            previewSettings1.Icon = ((System.Drawing.Icon)(resources.GetObject("previewSettings1.Icon")));
            previewSettings1.Text = "";
            this.environmentSettings1.PreviewSettings = previewSettings1;
            this.environmentSettings1.ReportSettings = reportSettings1;
            this.environmentSettings1.UIStyle = FastReport.Utils.UIStyle.Office2007Black;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.反月结ToolStripMenuItem,
            this.反日结ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // 反月结ToolStripMenuItem
            // 
            this.反月结ToolStripMenuItem.Name = "反月结ToolStripMenuItem";
            this.反月结ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.反月结ToolStripMenuItem.Text = "反月结";
            this.反月结ToolStripMenuItem.Click += new System.EventHandler(this.反月结ToolStripMenuItem_Click);
            // 
            // 反日结ToolStripMenuItem
            // 
            this.反日结ToolStripMenuItem.Name = "反日结ToolStripMenuItem";
            this.反日结ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.反日结ToolStripMenuItem.Text = "反日结";
            this.反日结ToolStripMenuItem.Click += new System.EventHandler(this.反日结ToolStripMenuItem_Click);
            // 
            // bgGetFPNO
            // 
            this.bgGetFPNO.WorkerSupportsCancellation = true;
            this.bgGetFPNO.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgGetFPNO_DoWork);
            this.bgGetFPNO.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgGetFPNO_RunWorkerCompleted);
            // 
            // waterUserId
            // 
            this.waterUserId.DataPropertyName = "waterUserId";
            this.waterUserId.Frozen = true;
            this.waterUserId.HeaderText = "waterUserId";
            this.waterUserId.Name = "waterUserId";
            this.waterUserId.ReadOnly = true;
            this.waterUserId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.waterUserId.Visible = false;
            this.waterUserId.Width = 121;
            // 
            // readMeterRecordId
            // 
            this.readMeterRecordId.DataPropertyName = "readMeterRecordId";
            this.readMeterRecordId.Frozen = true;
            this.readMeterRecordId.HeaderText = "readMeterRecordId";
            this.readMeterRecordId.Name = "readMeterRecordId";
            this.readMeterRecordId.ReadOnly = true;
            this.readMeterRecordId.Visible = false;
            this.readMeterRecordId.Width = 169;
            // 
            // waterUserNO
            // 
            this.waterUserNO.DataPropertyName = "waterUserNO";
            this.waterUserNO.Frozen = true;
            this.waterUserNO.HeaderText = "用户号";
            this.waterUserNO.Name = "waterUserNO";
            this.waterUserNO.ReadOnly = true;
            this.waterUserNO.Width = 81;
            // 
            // waterUserName
            // 
            this.waterUserName.DataPropertyName = "waterUserName";
            this.waterUserName.Frozen = true;
            this.waterUserName.HeaderText = "用户名";
            this.waterUserName.Name = "waterUserName";
            this.waterUserName.ReadOnly = true;
            this.waterUserName.Width = 120;
            // 
            // waterPhone
            // 
            this.waterPhone.DataPropertyName = "waterPhone";
            this.waterPhone.Frozen = true;
            this.waterPhone.HeaderText = "电话";
            this.waterPhone.Name = "waterPhone";
            this.waterPhone.ReadOnly = true;
            this.waterPhone.Visible = false;
            this.waterPhone.Width = 65;
            // 
            // waterUserAddress
            // 
            this.waterUserAddress.DataPropertyName = "waterUserAddress";
            this.waterUserAddress.Frozen = true;
            this.waterUserAddress.HeaderText = "地址";
            this.waterUserAddress.Name = "waterUserAddress";
            this.waterUserAddress.ReadOnly = true;
            this.waterUserAddress.Width = 130;
            // 
            // waterMeterNo
            // 
            this.waterMeterNo.DataPropertyName = "waterMeterNo";
            this.waterMeterNo.HeaderText = "水表编号";
            this.waterMeterNo.Name = "waterMeterNo";
            this.waterMeterNo.ReadOnly = true;
            this.waterMeterNo.Width = 97;
            // 
            // readMeterRecordYearAndMonth
            // 
            this.readMeterRecordYearAndMonth.DataPropertyName = "readMeterRecordYearAndMonth";
            this.readMeterRecordYearAndMonth.HeaderText = "水费月份";
            this.readMeterRecordYearAndMonth.Name = "readMeterRecordYearAndMonth";
            this.readMeterRecordYearAndMonth.ReadOnly = true;
            this.readMeterRecordYearAndMonth.Width = 97;
            // 
            // waterMeterLastNumber
            // 
            this.waterMeterLastNumber.DataPropertyName = "waterMeterLastNumber";
            this.waterMeterLastNumber.HeaderText = "上期读数";
            this.waterMeterLastNumber.Name = "waterMeterLastNumber";
            this.waterMeterLastNumber.ReadOnly = true;
            this.waterMeterLastNumber.Width = 97;
            // 
            // waterMeterEndNumber
            // 
            this.waterMeterEndNumber.DataPropertyName = "waterMeterEndNumber";
            this.waterMeterEndNumber.HeaderText = "本期读数";
            this.waterMeterEndNumber.Name = "waterMeterEndNumber";
            this.waterMeterEndNumber.ReadOnly = true;
            this.waterMeterEndNumber.Width = 97;
            // 
            // totalNumber
            // 
            this.totalNumber.DataPropertyName = "totalNumber";
            this.totalNumber.HeaderText = "用水量";
            this.totalNumber.Name = "totalNumber";
            this.totalNumber.ReadOnly = true;
            this.totalNumber.Width = 81;
            // 
            // totalNumberDescribe
            // 
            this.totalNumberDescribe.DataPropertyName = "totalNumberDescribe";
            this.totalNumberDescribe.HeaderText = "用水量描述";
            this.totalNumberDescribe.Name = "totalNumberDescribe";
            this.totalNumberDescribe.ReadOnly = true;
            this.totalNumberDescribe.Visible = false;
            this.totalNumberDescribe.Width = 113;
            // 
            // avePrice
            // 
            this.avePrice.DataPropertyName = "avePrice";
            this.avePrice.HeaderText = "平均单价";
            this.avePrice.Name = "avePrice";
            this.avePrice.ReadOnly = true;
            this.avePrice.Width = 97;
            // 
            // avePriceDescribe
            // 
            this.avePriceDescribe.DataPropertyName = "avePriceDescribe";
            this.avePriceDescribe.HeaderText = "avePriceDescribe";
            this.avePriceDescribe.Name = "avePriceDescribe";
            this.avePriceDescribe.ReadOnly = true;
            this.avePriceDescribe.Visible = false;
            this.avePriceDescribe.Width = 161;
            // 
            // waterTotalChargeEND
            // 
            this.waterTotalChargeEND.DataPropertyName = "waterTotalChargeEND";
            this.waterTotalChargeEND.HeaderText = "水费";
            this.waterTotalChargeEND.Name = "waterTotalChargeEND";
            this.waterTotalChargeEND.ReadOnly = true;
            this.waterTotalChargeEND.Visible = false;
            this.waterTotalChargeEND.Width = 65;
            // 
            // extraChargePriceLS1
            // 
            this.extraChargePriceLS1.DataPropertyName = "extraChargePrice1";
            this.extraChargePriceLS1.HeaderText = "附加费单价1";
            this.extraChargePriceLS1.Name = "extraChargePriceLS1";
            this.extraChargePriceLS1.ReadOnly = true;
            this.extraChargePriceLS1.Width = 121;
            // 
            // extraChargeLS1
            // 
            this.extraChargeLS1.DataPropertyName = "extraCharge1";
            this.extraChargeLS1.HeaderText = "附加费1";
            this.extraChargeLS1.Name = "extraChargeLS1";
            this.extraChargeLS1.ReadOnly = true;
            this.extraChargeLS1.Width = 89;
            // 
            // extraChargePriceLS2
            // 
            this.extraChargePriceLS2.DataPropertyName = "extraChargePrice2";
            this.extraChargePriceLS2.HeaderText = "extraChargePrice2";
            this.extraChargePriceLS2.Name = "extraChargePriceLS2";
            this.extraChargePriceLS2.ReadOnly = true;
            this.extraChargePriceLS2.Width = 169;
            // 
            // extraChargeLS2
            // 
            this.extraChargeLS2.DataPropertyName = "extraCharge2";
            this.extraChargeLS2.HeaderText = "附加费2";
            this.extraChargeLS2.Name = "extraChargeLS2";
            this.extraChargeLS2.ReadOnly = true;
            this.extraChargeLS2.Width = 89;
            // 
            // extraChargePriceLS3
            // 
            this.extraChargePriceLS3.DataPropertyName = "extraChargePrice3";
            this.extraChargePriceLS3.HeaderText = "extraChargePrice3";
            this.extraChargePriceLS3.Name = "extraChargePriceLS3";
            this.extraChargePriceLS3.ReadOnly = true;
            this.extraChargePriceLS3.Width = 169;
            // 
            // extraChargeLS3
            // 
            this.extraChargeLS3.DataPropertyName = "extraCharge3";
            this.extraChargeLS3.HeaderText = "附加费3";
            this.extraChargeLS3.Name = "extraChargeLS3";
            this.extraChargeLS3.ReadOnly = true;
            this.extraChargeLS3.Width = 89;
            // 
            // extraChargePriceLS4
            // 
            this.extraChargePriceLS4.DataPropertyName = "extraChargePrice4";
            this.extraChargePriceLS4.HeaderText = "extraChargePrice4";
            this.extraChargePriceLS4.Name = "extraChargePriceLS4";
            this.extraChargePriceLS4.ReadOnly = true;
            this.extraChargePriceLS4.Width = 169;
            // 
            // extraChargeLS4
            // 
            this.extraChargeLS4.DataPropertyName = "extraCharge4";
            this.extraChargeLS4.HeaderText = "附加费4";
            this.extraChargeLS4.Name = "extraChargeLS4";
            this.extraChargeLS4.ReadOnly = true;
            this.extraChargeLS4.Width = 89;
            // 
            // extraChargePriceLS5
            // 
            this.extraChargePriceLS5.DataPropertyName = "extraChargePrice5";
            this.extraChargePriceLS5.HeaderText = "extraChargePrice5";
            this.extraChargePriceLS5.Name = "extraChargePriceLS5";
            this.extraChargePriceLS5.ReadOnly = true;
            this.extraChargePriceLS5.Width = 169;
            // 
            // extraChargeLS5
            // 
            this.extraChargeLS5.DataPropertyName = "extraCharge5";
            this.extraChargeLS5.HeaderText = "附加费5";
            this.extraChargeLS5.Name = "extraChargeLS5";
            this.extraChargeLS5.ReadOnly = true;
            this.extraChargeLS5.Width = 89;
            // 
            // extraChargePriceLS6
            // 
            this.extraChargePriceLS6.DataPropertyName = "extraChargePrice6";
            this.extraChargePriceLS6.HeaderText = "extraChargePrice6";
            this.extraChargePriceLS6.Name = "extraChargePriceLS6";
            this.extraChargePriceLS6.ReadOnly = true;
            this.extraChargePriceLS6.Width = 169;
            // 
            // extraChargeLS6
            // 
            this.extraChargeLS6.DataPropertyName = "extraCharge6";
            this.extraChargeLS6.HeaderText = "附加费6";
            this.extraChargeLS6.Name = "extraChargeLS6";
            this.extraChargeLS6.ReadOnly = true;
            this.extraChargeLS6.Width = 89;
            // 
            // extraChargePriceLS7
            // 
            this.extraChargePriceLS7.DataPropertyName = "extraChargePrice7";
            this.extraChargePriceLS7.HeaderText = "extraChargePrice7";
            this.extraChargePriceLS7.Name = "extraChargePriceLS7";
            this.extraChargePriceLS7.ReadOnly = true;
            this.extraChargePriceLS7.Width = 169;
            // 
            // extraChargeLS7
            // 
            this.extraChargeLS7.DataPropertyName = "extraCharge7";
            this.extraChargeLS7.HeaderText = "附加费7";
            this.extraChargeLS7.Name = "extraChargeLS7";
            this.extraChargeLS7.ReadOnly = true;
            this.extraChargeLS7.Width = 89;
            // 
            // extraChargePriceLS8
            // 
            this.extraChargePriceLS8.DataPropertyName = "extraChargePrice8";
            this.extraChargePriceLS8.HeaderText = "extraChargePrice8";
            this.extraChargePriceLS8.Name = "extraChargePriceLS8";
            this.extraChargePriceLS8.ReadOnly = true;
            this.extraChargePriceLS8.Width = 169;
            // 
            // extraChargeLS8
            // 
            this.extraChargeLS8.DataPropertyName = "extraCharge8";
            this.extraChargeLS8.HeaderText = "附加费8";
            this.extraChargeLS8.Name = "extraChargeLS8";
            this.extraChargeLS8.ReadOnly = true;
            this.extraChargeLS8.Width = 89;
            // 
            // extraTotalChargeEND
            // 
            this.extraTotalChargeEND.DataPropertyName = "extraTotalChargeEND";
            this.extraTotalChargeEND.HeaderText = "附加费小计";
            this.extraTotalChargeEND.Name = "extraTotalChargeEND";
            this.extraTotalChargeEND.ReadOnly = true;
            this.extraTotalChargeEND.Visible = false;
            this.extraTotalChargeEND.Width = 113;
            // 
            // OVERDUEEND
            // 
            this.OVERDUEEND.DataPropertyName = "OVERDUEEND";
            this.OVERDUEEND.HeaderText = "滞纳金";
            this.OVERDUEEND.Name = "OVERDUEEND";
            this.OVERDUEEND.ReadOnly = true;
            this.OVERDUEEND.Visible = false;
            this.OVERDUEEND.Width = 81;
            // 
            // totalChargeEND
            // 
            this.totalChargeEND.DataPropertyName = "totalChargeEND";
            this.totalChargeEND.HeaderText = "费用合计";
            this.totalChargeEND.Name = "totalChargeEND";
            this.totalChargeEND.ReadOnly = true;
            this.totalChargeEND.Visible = false;
            this.totalChargeEND.Width = 97;
            // 
            // waterMeterTypeId
            // 
            this.waterMeterTypeId.DataPropertyName = "waterMeterTypeId";
            this.waterMeterTypeId.HeaderText = "waterMeterTypeId";
            this.waterMeterTypeId.Name = "waterMeterTypeId";
            this.waterMeterTypeId.ReadOnly = true;
            this.waterMeterTypeId.Visible = false;
            // 
            // waterMeterTypeName
            // 
            this.waterMeterTypeName.DataPropertyName = "waterMeterTypeName";
            this.waterMeterTypeName.HeaderText = "用水性质";
            this.waterMeterTypeName.Name = "waterMeterTypeName";
            this.waterMeterTypeName.ReadOnly = true;
            // 
            // WATERFIXVALUE
            // 
            this.WATERFIXVALUE.DataPropertyName = "WATERFIXVALUE";
            this.WATERFIXVALUE.HeaderText = "定量用水";
            this.WATERFIXVALUE.Name = "WATERFIXVALUE";
            this.WATERFIXVALUE.ReadOnly = true;
            this.WATERFIXVALUE.Visible = false;
            this.WATERFIXVALUE.Width = 97;
            // 
            // chargeID
            // 
            this.chargeID.DataPropertyName = "chargeID";
            this.chargeID.HeaderText = "收费单号";
            this.chargeID.Name = "chargeID";
            this.chargeID.ReadOnly = true;
            this.chargeID.Width = 97;
            // 
            // CHARGEINVOICEPRINTID
            // 
            this.CHARGEINVOICEPRINTID.DataPropertyName = "CHARGEINVOICEPRINTID";
            this.CHARGEINVOICEPRINTID.HeaderText = "CHARGEINVOICEPRINTID";
            this.CHARGEINVOICEPRINTID.Name = "CHARGEINVOICEPRINTID";
            this.CHARGEINVOICEPRINTID.ReadOnly = true;
            this.CHARGEINVOICEPRINTID.Visible = false;
            this.CHARGEINVOICEPRINTID.Width = 193;
            // 
            // TOTALNUMBERCHARGE
            // 
            this.TOTALNUMBERCHARGE.DataPropertyName = "TOTALNUMBERCHARGE";
            this.TOTALNUMBERCHARGE.HeaderText = "单据水量";
            this.TOTALNUMBERCHARGE.Name = "TOTALNUMBERCHARGE";
            this.TOTALNUMBERCHARGE.ReadOnly = true;
            this.TOTALNUMBERCHARGE.Width = 97;
            // 
            // WATERTOTALCHARGECHARGE
            // 
            this.WATERTOTALCHARGECHARGE.DataPropertyName = "WATERTOTALCHARGECHARGE";
            this.WATERTOTALCHARGECHARGE.HeaderText = "单据水费";
            this.WATERTOTALCHARGECHARGE.Name = "WATERTOTALCHARGECHARGE";
            this.WATERTOTALCHARGECHARGE.ReadOnly = true;
            this.WATERTOTALCHARGECHARGE.Width = 97;
            // 
            // EXTRACHARGECHARGE1
            // 
            this.EXTRACHARGECHARGE1.DataPropertyName = "EXTRACHARGECHARGE1";
            this.EXTRACHARGECHARGE1.HeaderText = "单据污水处理费";
            this.EXTRACHARGECHARGE1.Name = "EXTRACHARGECHARGE1";
            this.EXTRACHARGECHARGE1.ReadOnly = true;
            this.EXTRACHARGECHARGE1.Width = 145;
            // 
            // EXTRACHARGECHARGE2
            // 
            this.EXTRACHARGECHARGE2.DataPropertyName = "EXTRACHARGECHARGE2";
            this.EXTRACHARGECHARGE2.HeaderText = "单据附加费";
            this.EXTRACHARGECHARGE2.Name = "EXTRACHARGECHARGE2";
            this.EXTRACHARGECHARGE2.ReadOnly = true;
            this.EXTRACHARGECHARGE2.Width = 113;
            // 
            // TOTALCHARGECHARGE
            // 
            this.TOTALCHARGECHARGE.DataPropertyName = "TOTALCHARGECHARGE";
            this.TOTALCHARGECHARGE.HeaderText = "单据总计";
            this.TOTALCHARGECHARGE.Name = "TOTALCHARGECHARGE";
            this.TOTALCHARGECHARGE.ReadOnly = true;
            this.TOTALCHARGECHARGE.Width = 97;
            // 
            // INVOICEBATCHNAME
            // 
            this.INVOICEBATCHNAME.DataPropertyName = "INVOICEBATCHNAME";
            this.INVOICEBATCHNAME.HeaderText = "发票批次";
            this.INVOICEBATCHNAME.Name = "INVOICEBATCHNAME";
            this.INVOICEBATCHNAME.ReadOnly = true;
            this.INVOICEBATCHNAME.Width = 97;
            // 
            // INVOICENO
            // 
            this.INVOICENO.DataPropertyName = "INVOICENO";
            this.INVOICENO.HeaderText = "发票号";
            this.INVOICENO.Name = "INVOICENO";
            this.INVOICENO.ReadOnly = true;
            this.INVOICENO.Width = 81;
            // 
            // INVOICECANCEL
            // 
            this.INVOICECANCEL.DataPropertyName = "INVOICECANCEL";
            this.INVOICECANCEL.HeaderText = "发票状态";
            this.INVOICECANCEL.Name = "INVOICECANCEL";
            this.INVOICECANCEL.ReadOnly = true;
            this.INVOICECANCEL.Width = 97;
            // 
            // RECEIPTNO
            // 
            this.RECEIPTNO.DataPropertyName = "RECEIPTNO";
            this.RECEIPTNO.HeaderText = "收据号";
            this.RECEIPTNO.Name = "RECEIPTNO";
            this.RECEIPTNO.ReadOnly = true;
            // 
            // CHARGETYPEID
            // 
            this.CHARGETYPEID.DataPropertyName = "CHARGETYPEID";
            this.CHARGETYPEID.HeaderText = "CHARGETYPEID";
            this.CHARGETYPEID.Name = "CHARGETYPEID";
            this.CHARGETYPEID.ReadOnly = true;
            this.CHARGETYPEID.Visible = false;
            this.CHARGETYPEID.Width = 129;
            // 
            // CHARGETYPENAME
            // 
            this.CHARGETYPENAME.DataPropertyName = "CHARGETYPENAME";
            this.CHARGETYPENAME.HeaderText = "收费方式";
            this.CHARGETYPENAME.Name = "CHARGETYPENAME";
            this.CHARGETYPENAME.ReadOnly = true;
            this.CHARGETYPENAME.Width = 97;
            // 
            // CHARGEBCYS
            // 
            this.CHARGEBCYS.DataPropertyName = "CHARGEBCYS";
            this.CHARGEBCYS.HeaderText = "本次应收";
            this.CHARGEBCYS.Name = "CHARGEBCYS";
            this.CHARGEBCYS.ReadOnly = true;
            this.CHARGEBCYS.Width = 97;
            // 
            // CHARGEBCSS
            // 
            this.CHARGEBCSS.DataPropertyName = "CHARGEBCSS";
            this.CHARGEBCSS.HeaderText = "本次实收";
            this.CHARGEBCSS.Name = "CHARGEBCSS";
            this.CHARGEBCSS.ReadOnly = true;
            this.CHARGEBCSS.Width = 97;
            // 
            // CHARGEYSQQYE
            // 
            this.CHARGEYSQQYE.DataPropertyName = "CHARGEYSQQYE";
            this.CHARGEYSQQYE.HeaderText = "前期余额";
            this.CHARGEYSQQYE.Name = "CHARGEYSQQYE";
            this.CHARGEYSQQYE.ReadOnly = true;
            this.CHARGEYSQQYE.Width = 97;
            // 
            // CHARGEYSBCSZ
            // 
            this.CHARGEYSBCSZ.DataPropertyName = "CHARGEYSBCSZ";
            this.CHARGEYSBCSZ.HeaderText = "本次收支";
            this.CHARGEYSBCSZ.Name = "CHARGEYSBCSZ";
            this.CHARGEYSBCSZ.ReadOnly = true;
            this.CHARGEYSBCSZ.Width = 97;
            // 
            // CHARGEYSJSYE
            // 
            this.CHARGEYSJSYE.DataPropertyName = "CHARGEYSJSYE";
            this.CHARGEYSJSYE.HeaderText = "用户余额";
            this.CHARGEYSJSYE.Name = "CHARGEYSJSYE";
            this.CHARGEYSJSYE.ReadOnly = true;
            this.CHARGEYSJSYE.Width = 97;
            // 
            // CHARGEWORKERNAME
            // 
            this.CHARGEWORKERNAME.DataPropertyName = "CHARGEWORKERNAME";
            this.CHARGEWORKERNAME.HeaderText = "收款员";
            this.CHARGEWORKERNAME.Name = "CHARGEWORKERNAME";
            this.CHARGEWORKERNAME.ReadOnly = true;
            this.CHARGEWORKERNAME.Width = 81;
            // 
            // CHARGEDATETIME
            // 
            this.CHARGEDATETIME.DataPropertyName = "CHARGEDATETIME";
            this.CHARGEDATETIME.HeaderText = "收费日期";
            this.CHARGEDATETIME.Name = "CHARGEDATETIME";
            this.CHARGEDATETIME.ReadOnly = true;
            this.CHARGEDATETIME.Width = 97;
            // 
            // CHARGECANCEL
            // 
            this.CHARGECANCEL.DataPropertyName = "CHARGECANCEL";
            this.CHARGECANCEL.HeaderText = "单据状态";
            this.CHARGECANCEL.Name = "CHARGECANCEL";
            this.CHARGECANCEL.ReadOnly = true;
            this.CHARGECANCEL.Width = 97;
            // 
            // DAYCHECKSTATES
            // 
            this.DAYCHECKSTATES.DataPropertyName = "DAYCHECKSTATES";
            this.DAYCHECKSTATES.HeaderText = "日结";
            this.DAYCHECKSTATES.Name = "DAYCHECKSTATES";
            this.DAYCHECKSTATES.ReadOnly = true;
            this.DAYCHECKSTATES.Width = 65;
            // 
            // SETTLEACCOUNTSSSID
            // 
            this.SETTLEACCOUNTSSSID.DataPropertyName = "SETTLEACCOUNTSSSID";
            this.SETTLEACCOUNTSSSID.HeaderText = "月结单号";
            this.SETTLEACCOUNTSSSID.Name = "SETTLEACCOUNTSSSID";
            this.SETTLEACCOUNTSSSID.ReadOnly = true;
            this.SETTLEACCOUNTSSSID.Width = 65;
            // 
            // meterReaderName
            // 
            this.meterReaderName.DataPropertyName = "meterReaderName";
            this.meterReaderName.HeaderText = "抄表员";
            this.meterReaderName.Name = "meterReaderName";
            this.meterReaderName.ReadOnly = true;
            // 
            // meterReaderID
            // 
            this.meterReaderID.DataPropertyName = "meterReaderID";
            this.meterReaderID.HeaderText = "meterReaderID";
            this.meterReaderID.Name = "meterReaderID";
            this.meterReaderID.ReadOnly = true;
            this.meterReaderID.Visible = false;
            // 
            // chargerName
            // 
            this.chargerName.DataPropertyName = "chargerName";
            this.chargerName.HeaderText = "收费员";
            this.chargerName.Name = "chargerName";
            this.chargerName.ReadOnly = true;
            // 
            // memo
            // 
            this.memo.DataPropertyName = "memo";
            this.memo.HeaderText = "memo";
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            this.memo.Visible = false;
            this.memo.Width = 65;
            // 
            // INVOICEPRINTSIGN
            // 
            this.INVOICEPRINTSIGN.DataPropertyName = "INVOICEPRINTSIGN";
            this.INVOICEPRINTSIGN.HeaderText = "INVOICEPRINTSIGN";
            this.INVOICEPRINTSIGN.Name = "INVOICEPRINTSIGN";
            this.INVOICEPRINTSIGN.ReadOnly = true;
            this.INVOICEPRINTSIGN.Visible = false;
            this.INVOICEPRINTSIGN.Width = 161;
            // 
            // waterUserTypeId
            // 
            this.waterUserTypeId.DataPropertyName = "waterUserTypeId";
            this.waterUserTypeId.HeaderText = "waterUserTypeId";
            this.waterUserTypeId.Name = "waterUserTypeId";
            this.waterUserTypeId.ReadOnly = true;
            this.waterUserTypeId.Visible = false;
            // 
            // waterUserTypeName
            // 
            this.waterUserTypeName.DataPropertyName = "waterUserTypeName";
            this.waterUserTypeName.HeaderText = "用户类别";
            this.waterUserTypeName.Name = "waterUserTypeName";
            this.waterUserTypeName.ReadOnly = true;
            this.waterUserTypeName.Visible = false;
            // 
            // frmWaterMeterChargeValueAddedrRePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 662);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWaterMeterChargeValueAddedrRePrint";
            this.Text = "发票补打";
            this.Load += new System.EventHandler(this.frmWaterMeterChargeCancel_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWaterMeterChargeInvoicePrint_FormClosing);
            this.tb1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoryWaterFee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tb1;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TableLayoutPanel tb2;
        private System.Windows.Forms.DataGridView dgHistoryWaterFee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtWaterUserNO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btInvoiceCancel;
        private System.Windows.Forms.TextBox txtNewInvoiceNO;
        private System.Windows.Forms.Label labInvoiceNO;
        private System.Windows.Forms.Button btChangeInvoice;
        private System.Windows.Forms.TextBox txtInvoiceNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtChargeInvoicePrintID;
        private System.Windows.Forms.ComboBox cmbBatchNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbInvoiceCancelReason;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trMeterReading;
        private System.Windows.Forms.ComboBox cmbWaterMeterType;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.TextBox txtYearAndMonth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbInvoicePrintState;
        private System.Windows.Forms.Label label11;
        private FastReport.EnvironmentSettings environmentSettings1;
        private System.Windows.Forms.Button btInvoiceMakeUp;
        private System.Windows.Forms.TextBox txtEndRow;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtStartRow;
        private System.Windows.Forms.Button btInvoicePrint;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtWaterUserName;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbChargerWorkName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 反月结ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反日结ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenior;
        private System.Windows.Forms.Button btSenior;
        private System.ComponentModel.BackgroundWorker bgGetFPNO;
        private System.Windows.Forms.ComboBox cmbCharger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChargeID;
        private System.Windows.Forms.ComboBox cmbWaterUserType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn readMeterRecordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterUserNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterUserAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterMeterNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn readMeterRecordYearAndMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterMeterLastNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterMeterEndNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalNumberDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn avePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn avePriceDescribe;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterTotalChargeEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS1;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS2;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS3;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS4;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS5;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS6;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS7;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargePriceLS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraChargeLS8;
        private System.Windows.Forms.DataGridViewTextBoxColumn extraTotalChargeEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn OVERDUEEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalChargeEND;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterMeterTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterMeterTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WATERFIXVALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEINVOICEPRINTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALNUMBERCHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn WATERTOTALCHARGECHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXTRACHARGECHARGE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXTRACHARGECHARGE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALCHARGECHARGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICEBATCHNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICENO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICECANCEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEIPTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGETYPEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGETYPENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEBCYS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEBCSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEYSQQYE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEYSBCSZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEYSJSYE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEWORKERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGEDATETIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHARGECANCEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAYCHECKSTATES;
        private System.Windows.Forms.DataGridViewTextBoxColumn SETTLEACCOUNTSSSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterReaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterReaderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn chargerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICEPRINTSIGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterUserTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterUserTypeName;
    }
}