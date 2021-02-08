using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdminClientVO;
using AdminClient.Service;
using AdminClient.PopUp;

namespace AdminClient.Forms
{
	public partial class FacilityGroupInfo : AdminClient.BaseForm.FormSerchListTemp
	{
		List<FacilityGroupVO> FacGrpList;
		FacilityGroupVO selectFgrp;

		public FacilityGroupInfo()
		{
			InitializeComponent();
		}

		private void FacilityGroupInfo_Load(object sender, EventArgs e)
		{
			#region 기초셋팅
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;

			#endregion

			#region 데이터그리드뷰 셋팅
			dgv_FacGrpList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "설비군코드", "FacGrp_Code");
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "설비군명", "FacGrp_Name");
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "사용여부", "FacGrp_Enable");
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "설명", "FacGrp_Description");
			#endregion

			#region 콤보박스 셋팅
			cbo_Enable.Items.Add("전체");
			cbo_Enable.Items.Add("Y");
			cbo_Enable.Items.Add("N");
			cbo_DetailEnable.Items.Add("전체");
			cbo_DetailEnable.Items.Add("Y");
			cbo_DetailEnable.Items.Add("N");

			cbo_Enable.SelectedIndex = cbo_DetailEnable.SelectedIndex = 0;
			#endregion
		}

		#region 이벤트

		private void chk_limit_CheckedChanged(object sender, EventArgs e)
		{
			nu_limit.Enabled = chk_limit.Checked;

			if (!chk_limit.Checked)
			{
				nu_limit.Value = 0;
			}
		}

		private void button1_Click(object sender, EventArgs e) //검색버튼
		{
			string limit, enable;
			limit = enable = string.Empty;

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();

			if (cbo_Enable.SelectedIndex > 0)
			{
				enable = cbo_Enable.SelectedItem.ToString();
			}

			FacilityService service = new FacilityService();
			FacGrpList = service.GetFacilityGroupList(limit, enable);
			service.Dispose();

			dgv_FacGrpList.DataSource = FacGrpList;

			if (FacGrpList != null && FacGrpList.Count > 0)
			{
				searchControl1.Getdata(dgv_FacGrpList);
				gb_detail.Enabled = true;
			}
		}

		private void dgv_FacGrpList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_FgrpCode.Text = txt_FgrpName.Text = string.Empty;

			if(e.RowIndex > -1)
			{
				txt_FgrpCode.Text = dgv_FacGrpList["FacGrp_Code", e.RowIndex].Value.ToString();
				selectFgrp.FacGrp_Code = dgv_FacGrpList["FacGrp_Code", e.RowIndex].Value.ToString();
				txt_FgrpName.Text = dgv_FacGrpList["FacGrp_Name", e.RowIndex].Value.ToString();
				selectFgrp.FacGrp_Name = dgv_FacGrpList["FacGrp_Name", e.RowIndex].Value.ToString();
				selectFgrp.FacGrp_Enable = dgv_FacGrpList["FacGrp_Enable", e.RowIndex].Value.ToString();
				if (dgv_FacGrpList["FacGrp_Description", e.RowIndex].Value != null)
					selectFgrp.FacGrp_Description = dgv_FacGrpList["FacGrp_Description", e.RowIndex].Value.ToString();
			}
		}

		private void btn_add_Click(object sender, EventArgs e) //신규등록 버튼
		{
			
		}

		private void dgv_FacGrpList_CellContentClick(object sender, DataGridViewCellEventArgs e) //수정을 위한 Edit셀컬럼 클릭
		{
			if (e.ColumnIndex == 1)
			{
				if (e.RowIndex > -1)
				{
					FacilityGroupPopUp pop = new FacilityGroupPopUp();
					pop.ThisMode = FacilityGroupPopUp.Mode.Update;
					pop.StartPosition = FormStartPosition.CenterParent;
					FacilityGroupVO vo = null;

					FacGrpList.ForEach((fgrp) =>
					{
						if (fgrp.FacGrp_Code == selectFgrp.FacGrp_Code)
						{
							vo = fgrp;
						}
					});

					pop.VO = vo; //수정할 설비군정보 전달

					if (pop.ShowDialog() == DialogResult.OK)
					{
						MessageBox.Show("수정에 성공했습니다.");
						vo = pop.VO; //수정한 정보 받아오기

						FacGrpList.ForEach((Fgrp) =>
						{
							if (Fgrp.FacGrp_Code == selectFgrp.FacGrp_Code)
							{
								Fgrp = vo;
							}
						});

						dgv_FacGrpList.DataSource = null;
						dgv_FacGrpList.DataSource = FacGrpList;
					}
				}
				else
					return;
			}
		}


		#endregion

	}
}
