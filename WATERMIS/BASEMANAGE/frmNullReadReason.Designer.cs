﻿namespace BASEMANAGE
{
    partial class frmNullReadReason
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNullReadReason));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolAdd = new System.Windows.Forms.ToolStripButton();
            this.toolSubmit = new System.Windows.Forms.ToolStripButton();
            this.toolDelete = new System.Windows.Forms.ToolStripButton();
            this.tb1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.NullReadReasonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NullReadReasonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtIDOld = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNameS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tb1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSearch,
            this.toolAdd,
            this.toolSubmit,
            this.toolDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolSearch
            // 
            this.toolSearch.Image = global::BASEMANAGE.Properties.Resources.onebit_02;
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(55, 22);
            this.toolSearch.Text = "查询";
            this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // toolAdd
            // 
            this.toolAdd.Image = global::BASEMANAGE.Properties.Resources.onebit_31;
            this.toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdd.Name = "toolAdd";
            this.toolAdd.Size = new System.Drawing.Size(55, 22);
            this.toolAdd.Text = "添加";
            this.toolAdd.Click += new System.EventHandler(this.toolAdd_Click);
            // 
            // toolSubmit
            // 
            this.toolSubmit.Image = global::BASEMANAGE.Properties.Resources.onebit_34;
            this.toolSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSubmit.Name = "toolSubmit";
            this.toolSubmit.Size = new System.Drawing.Size(55, 22);
            this.toolSubmit.Text = "提交";
            this.toolSubmit.Click += new System.EventHandler(this.toolSubmit_Click);
            // 
            // toolDelete
            // 
            this.toolDelete.Image = global::BASEMANAGE.Properties.Resources.onebit_33;
            this.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(55, 22);
            this.toolDelete.Text = "删除";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.Transparent;
            this.tb1.ColumnCount = 1;
            this.tb1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb1.Controls.Add(this.groupBox2, 0, 2);
            this.tb1.Controls.Add(this.gbDetail, 0, 1);
            this.tb1.Controls.Add(this.groupBox3, 0, 0);
            this.tb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb1.Location = new System.Drawing.Point(0, 25);
            this.tb1.Margin = new System.Windows.Forms.Padding(4);
            this.tb1.Name = "tb1";
            this.tb1.RowCount = 3;
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb1.Size = new System.Drawing.Size(712, 404);
            this.tb1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(704, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "列表";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NullReadReasonID,
            this.NullReadReasonName,
            this.MEMO});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point(4, 23);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersWidth = 30;
            this.dgList.RowTemplate.Height = 23;
            this.dgList.Size = new System.Drawing.Size(696, 205);
            this.dgList.TabIndex = 0;
            this.dgList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_RowEnter);
            this.dgList.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgList_CellPainting);
            // 
            // NullReadReasonID
            // 
            this.NullReadReasonID.DataPropertyName = "NullReadReasonID";
            this.NullReadReasonID.HeaderText = "代码";
            this.NullReadReasonID.Name = "NullReadReasonID";
            this.NullReadReasonID.ReadOnly = true;
            this.NullReadReasonID.Width = 65;
            // 
            // NullReadReasonName
            // 
            this.NullReadReasonName.DataPropertyName = "NullReadReasonName";
            this.NullReadReasonName.HeaderText = "说明";
            this.NullReadReasonName.Name = "NullReadReasonName";
            this.NullReadReasonName.ReadOnly = true;
            this.NullReadReasonName.Width = 65;
            // 
            // MEMO
            // 
            this.MEMO.DataPropertyName = "MEMO";
            this.MEMO.HeaderText = "备注";
            this.MEMO.Name = "MEMO";
            this.MEMO.ReadOnly = true;
            this.MEMO.Width = 65;
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.LimeGreen;
            this.gbDetail.Controls.Add(this.txtIDOld);
            this.gbDetail.Controls.Add(this.txtID);
            this.gbDetail.Controls.Add(this.txtMemo);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.txtName);
            this.gbDetail.Controls.Add(this.label1);
            this.gbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDetail.Location = new System.Drawing.Point(4, 67);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(4);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(4);
            this.gbDetail.Size = new System.Drawing.Size(704, 93);
            this.gbDetail.TabIndex = 0;
            this.gbDetail.TabStop = false;
            this.gbDetail.Tag = "9999";
            this.gbDetail.Text = "详细信息";
            // 
            // txtIDOld
            // 
            this.txtIDOld.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDOld.Location = new System.Drawing.Point(151, 23);
            this.txtIDOld.Name = "txtIDOld";
            this.txtIDOld.Size = new System.Drawing.Size(13, 26);
            this.txtIDOld.TabIndex = 6;
            this.txtIDOld.Visible = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(70, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 26);
            this.txtID.TabIndex = 4;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(70, 56);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(626, 26);
            this.txtMemo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "*代码:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "备注:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(216, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(480, 26);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "*说明:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Wheat;
            this.groupBox3.Controls.Add(this.txtNameS);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Tag = "9999";
            this.groupBox3.Text = "查询条件";
            // 
            // txtNameS
            // 
            this.txtNameS.Location = new System.Drawing.Point(114, 21);
            this.txtNameS.Name = "txtNameS";
            this.txtNameS.Size = new System.Drawing.Size(169, 26);
            this.txtNameS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "情况说明:";
            // 
            // frmNullReadReason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 429);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNullReadReason";
            this.Text = "未抄表情况说明管理";
            this.Load += new System.EventHandler(this.frmBankManage_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tb1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolSearch;
        private System.Windows.Forms.ToolStripButton toolAdd;
        private System.Windows.Forms.ToolStripButton toolSubmit;
        private System.Windows.Forms.ToolStripButton toolDelete;
        private System.Windows.Forms.TableLayoutPanel tb1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNameS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NullReadReasonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NullReadReasonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMO;
        private System.Windows.Forms.TextBox txtIDOld;
    }
}