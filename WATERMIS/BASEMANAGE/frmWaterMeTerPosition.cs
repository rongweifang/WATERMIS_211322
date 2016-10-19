﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BASEFUNCTION;
using MODEL;
using BLL;

namespace BASEMANAGE
{
    public partial class frmWaterMeTerPosition : DockContentEx
    {
        public frmWaterMeTerPosition()
        {
            InitializeComponent();
            tb1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tb1, true, null);
        }

        private void frmWaterMeTerPosition_Load(object sender, EventArgs e)
        {
            toolSearch_Click(null, null);
        }
        Log log = new Log(Application.StartupPath + @"\Logs\", LogType.Daily);
        Messages mes = new Messages();
        GETTABLEID GETTABLEID = new GETTABLEID();
        BLLwaterMeterPosition BLLwaterMeterPosition = new BLLwaterMeterPosition();
        private void toolSearch_Click(object sender, EventArgs e)
        {
            string strFilter = "";
            if (txtNameS.Text.Trim() != "")
                strFilter = " AND waterMeterPositionName LIKE '%" + txtNameS.Text.Trim() + "%'";
            DataTable dtList = BLLwaterMeterPosition.Query(strFilter);
            dgList.DataSource = dtList;
        }

        //private bool isAdd = false;
        private void toolAdd_Click(object sender, EventArgs e)
        {
            if (toolAdd.Text == "添加")
            {
                toolSearch.Enabled = false;
                toolDelete.Enabled = false;
                dgList.Enabled = false;

                EnableControl(gbDetail);
                toolAdd.Text = "取消";
            }
            else
            {
                toolSearch.Enabled = true;
                toolDelete.Enabled = true;
                dgList.Enabled = true;

                dgList_SelectionChanged(null, null);

                //DisEnableControl(gbDetail);
                toolAdd.Text = "添加";
            }

        }

        private void toolSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    mes.Show("请输入组名称!");
                    txtName.Focus();
                    return;
                }

                MODELwaterMeterPosition MODELwaterMeterPosition = new MODELwaterMeterPosition();
                MODELwaterMeterPosition.waterMeterPositionName = txtName.Text;
                MODELwaterMeterPosition.MEMO = txtMemo.Text;
                if (txtID.Text == "")
                {
                    MODELwaterMeterPosition.waterMeterPositionId = GETTABLEID.GetTableID("", "waterMeterPosition");
                    if (BLLwaterMeterPosition.Insert(MODELwaterMeterPosition))
                    {
                        toolSearch_Click(null, null);
                        dgList.ClearSelection();
                        dgList.CurrentCell = dgList.Rows[dgList.Rows.Count - 1].Cells[1];
                        dgList_SelectionChanged(null, null);
                    }
                    else
                    {
                        mes.Show("添加失败,请重新点击保存按钮!");
                        return;
                    }
                }
                else
                {
                    MODELwaterMeterPosition.waterMeterPositionId = txtID.Text;
                    if (BLLwaterMeterPosition.Update(MODELwaterMeterPosition))
                    {
                        dgList.CurrentRow.Cells["waterMeterPositionName"].Value = MODELwaterMeterPosition.waterMeterPositionName;
                        dgList.CurrentRow.Cells["MEMO"].Value = MODELwaterMeterPosition.MEMO;
                    }
                    else
                    {
                        mes.Show("修改失败,请重新点击保存按钮!");
                        return;
                    }
                }
                //DisEnableControl(gbDetail);

                dgList.Enabled = true;
                toolAdd.Text = "添加";
                toolDelete.Enabled = true;
                toolSearch.Enabled = true;
            }
            catch (Exception ex)
            {
                log.Write(ex.Message, MsgType.Error);
                mes.Show(ex.Message);
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (dgList.CurrentRow == null)
            {
                mes.Show("请从下方列表中选择要删除的行!");
                return;
            }
            if (txtID.Text == "")
            {
                mes.Show("系统检测到ID为空，请从下方列表中选择要删除的行!");
                return;
            }
            object obj = dgList.CurrentRow.Cells["waterMeterPositionName"].Value;
            if (obj != null && obj != DBNull.Value)
                if (mes.ShowQ("确定要删除" + obj.ToString() + "的信息吗?") == DialogResult.OK)
                {
                    if (!BLLwaterMeterPosition.Delete(txtID.Text))
                    {
                        mes.Show("删除失败,请从下方列表中重新选择要删除的行!");
                        return;
                    }
                    dgList.Rows.Remove(dgList.CurrentRow);
                }
        }

        private void dgList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgList.CurrentRow == null)
            {
                txtID.Clear();
                txtName.Clear();
                txtMemo.Clear();
                return;
            }
            object obj = dgList.CurrentRow.Cells["waterMeterPositionId"].Value;
            if (obj != null && obj != DBNull.Value)
                txtID.Text = obj.ToString();
            else
                txtID.Clear();
            obj = dgList.CurrentRow.Cells["waterMeterPositionName"].Value;
            if (obj != null && obj != DBNull.Value)
                txtName.Text = obj.ToString();
            else
                txtName.Clear();
            obj = dgList.CurrentRow.Cells["MEMO"].Value;
            if (obj != null && obj != DBNull.Value)
                txtMemo.Text = obj.ToString();
            else
                txtMemo.Clear();
        }

        /// <summary>
        /// 使能父控件内的所有控件
        /// </summary>
        /// <param name="conParent">父控件</param>
        private void EnableControl(Control conParent)
        {
            foreach (Control con in conParent.Controls)
            {
                if (con is TextBox)
                {
                    ((TextBox)con).Enabled = true;
                    ((TextBox)con).Clear();
                }
            }
        }

        /// <summary>
        /// 禁能父控件内的所有控件
        /// </summary>
        /// <param name="conParent">父控件</param>
        private void DisEnableControl(Control conParent)
        {
            foreach (Control con in conParent.Controls)
            {
                if (con is TextBox)
                {
                    ((TextBox)con).ReadOnly = false;
                }
            }
        }

        private void dgList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //判断是不是列Header
            if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                //单元格描绘  
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                //决定行号码描绘的范围   
                //不管e.AdvancedBorderStyle和e.CellStyle.Padding  
                Rectangle indexRect = e.CellBounds; indexRect.Inflate(-2, -2);
                //行号码描绘  
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), e.CellStyle.Font, indexRect, e.CellStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                //描绘完后通知 
                e.Handled = true;
            }
        }
    }
}
