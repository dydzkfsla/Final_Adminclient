using AdminClient.PopUp;
using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient.Forms
{
	public partial class FacilityInfo_NEW : BaseForm.FormSerchListSplitTemp
	{
		List<ComboFgrpNameVO> FgrpNameList;
		List<FacilityGroupVO> FacGrpList;
		List<FacilityVO> FacList;
		FacilityGroupVO selectFgrp;

		public FacilityInfo_NEW()
		{
			InitializeComponent();
		}

		private void FacilityInfo_NEW_Load(object sender, EventArgs e)
		{
			#region 기초셋팅
			splitContainer1.SplitterDistance = 365;
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;

			#region 콤보박스 셋팅
			ComboBindingService service = new ComboBindingService();
			FgrpNameList = service.BindingFgrpName();
			FgrpNameList.Insert(0, new ComboFgrpNameVO { FacGrp_Name = "전체", FacGrp_Code = "" });
			cbo_Fgrp.DataSource = FgrpNameList; //설비군명 바인딩
			cbo_Fgrp.DisplayMember = "FacGrp_Name";
			cbo_Fgrp.ValueMember = "FacGrp_Code";
			cbo_Enable.Items.Add("전체");
			cbo_Enable.Items.Add("Y");
			cbo_Enable.Items.Add("N");
			cbo_OutSourcing.Items.Add("전체");
			cbo_OutSourcing.Items.Add("Y");
			cbo_OutSourcing.Items.Add("N");

			cbo_Fgrp.SelectedIndex = cbo_Enable.SelectedIndex = cbo_OutSourcing.SelectedIndex = 0;
			#endregion
			#endregion

			#region 설비군 부분
			#region 데이터그리드뷰 셋팅
			dgv_FacGrpList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "설비군코드", "FacGrp_Code", 102);
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "설비군명", "FacGrp_Name");
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "사용여부", "FacGrp_Enable", 87, true, DataGridViewContentAlignment.MiddleCenter);
			CommonUtil.AddGridTextColumn(dgv_FacGrpList, "설명", "FacGrp_Description", 300);
			#endregion
			#endregion

			#region 설비 부분
			#region 데이터그리드뷰 셋팅
			dgv_FacList.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_FacList, "설비군코드", "FacGrp_Code", 10, false); //2
			CommonUtil.AddGridTextColumn(dgv_FacList, "설비코드", "Fac_Code", 90); //3
			CommonUtil.AddGridTextColumn(dgv_FacList, "설비명", "Fac_Name", 160); //4
			CommonUtil.AddGridTextColumn(dgv_FacList, "사용여부", "Fac_Enable", 87, true, DataGridViewContentAlignment.MiddleCenter); //5
			CommonUtil.AddGridTextColumn(dgv_FacList, "외부여부", "Fac_Outsourcing", 87, true, DataGridViewContentAlignment.MiddleCenter); //6
			CommonUtil.AddGridTextColumn(dgv_FacList, "사진경로", "Fac_ImgPath", 200); //7
			CommonUtil.AddGridTextColumn(dgv_FacList, "소진창고", "Fac_MaterialWareHouse"); //8
			CommonUtil.AddGridTextColumn(dgv_FacList, "양품창고", "Fac_GoodsWareHouse"); //9
			CommonUtil.AddGridTextColumn(dgv_FacList, "불량창고", "Fac_FaultyWareHouse"); //10
			CommonUtil.AddGridTextColumn(dgv_FacList, "설명", "Fac_Note", 200); //11
			#endregion
			#endregion

			GetFgrpList();
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

		private void btn_search_Click(object sender, EventArgs e) //검색버튼
		{
			string limit, fgrp, enable, outsourcing;
			limit = enable = fgrp = outsourcing = string.Empty;

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();

			if (cbo_Enable.SelectedIndex > 0)
			{
				enable = cbo_Enable.SelectedItem.ToString();
			}

			if (cbo_OutSourcing.SelectedIndex > 0)
			{
				outsourcing = cbo_OutSourcing.SelectedItem.ToString();
			}

			if (cbo_Fgrp.SelectedIndex > 0)
			{
				fgrp = cbo_Fgrp.SelectedValue.ToString();
			}

			FacilityService service = new FacilityService();
			FacList = service.GetFacilityList(limit, fgrp, enable, outsourcing);
			service.Dispose();

			dgv_FacList.DataSource = FacList;

			if (FacList != null && FacList.Count > 0)
			{
				searchControl1.Getdata(dgv_FacList);
				sortControl1.Getdata(dgv_FacList);
				gb_detail.Enabled = true;
			}
		}

		#region 설비군 부분

		private void btn_FacGrpAdd_Click(object sender, EventArgs e)
		{
			FacilityInfo_NEW_GroupPopUp pop = new FacilityInfo_NEW_GroupPopUp();
			pop.ThisMode = FacilityInfo_NEW_GroupPopUp.Mode.Insert;
			pop.StartPosition = FormStartPosition.CenterParent;
			FacilityGroupVO vo;

			if (pop.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("설비군 등록에 성공했습니다.");
				vo = pop.VO;
				GetFgrpList();
				
			}
		}
		private void dgv_FacGrpList_CellContentClick(object sender, DataGridViewCellEventArgs e) //수정버튼
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == 1)
			{
				FacilityGroupVO vo = new FacilityGroupVO
				{
					FacGrp_Code = dgv_FacGrpList["FacGrp_Code", e.RowIndex].Value.ToString(),
					FacGrp_Name = dgv_FacGrpList["FacGrp_Name", e.RowIndex].Value.ToString(),
					FacGrp_Enable = dgv_FacGrpList["FacGrp_Enable", e.RowIndex].Value.ToString(),
					//FacGrp_Description = (dgv_FacGrpList["FacGrp_Description", e.RowIndex].Value.ToString() == null) ? "" : dgv_FacGrpList["FacGrp_Description", e.RowIndex].Value.ToString()
				};

				FacilityInfo_NEW_GroupPopUp pop = new FacilityInfo_NEW_GroupPopUp();
				pop.ThisMode = FacilityInfo_NEW_GroupPopUp.Mode.Update;
				pop.VO = vo;
				pop.StartPosition = FormStartPosition.CenterParent;

				if (pop.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("성공적으로 수정되었습니다.");
					GetFgrpList();
				}
				else
				{
					GetFgrpList();
				}
			}
		}
		private void dgv_FacGrpList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			string fgrpCode = dgv_FacGrpList["FacGrp_Code", e.RowIndex].Value.ToString();

			FacilityService service = new FacilityService();
			FacList = service.GetFacilityList(fgrpCode);
			service.Dispose();

			dgv_FacList.DataSource = FacList;
		}
		#endregion

		#region 설비 부분

		private void btn_add_Click(object sender, EventArgs e)
		{
			FacilityInfo_NEWPopUp pop = new FacilityInfo_NEWPopUp();
			pop.ThisMode = FacilityInfo_NEWPopUp.Mode.Insert;
			pop.StartPosition = FormStartPosition.CenterParent;
			FacilityVO vo;

			if (pop.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("성공적으로 등록되었습니다.");
				vo = pop.VO;
			}
		}
		private void dgv_FacList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == 1)
			{
				FacilityVO vo = new FacilityVO
				{
					FacGrp_Code = dgv_FacList["FacGrp_Code", e.RowIndex].Value.ToString(),
					Fac_Code = dgv_FacList["Fac_Code", e.RowIndex].Value.ToString(),
					Fac_Name = dgv_FacList["Fac_Name", e.RowIndex].Value.ToString(),
					Fac_Enable = dgv_FacList["Fac_Enable", e.RowIndex].Value.ToString(),
					Fac_Outsourcing = dgv_FacList["Fac_Outsourcing", e.RowIndex].Value.ToString(),
					Fac_ImgPath = dgv_FacList["Fac_ImgPath", e.RowIndex].Value == null ? null : dgv_FacList["Fac_ImgPath", e.RowIndex].Value.ToString(),
					Fac_MaterialWareHouse = dgv_FacList["Fac_MaterialWareHouse", e.RowIndex].Value == null ? null : dgv_FacList["Fac_MaterialWareHouse", e.RowIndex].Value.ToString(),
					Fac_GoodsWareHouse = dgv_FacList["Fac_GoodsWareHouse", e.RowIndex].Value == null ? null : dgv_FacList["Fac_GoodsWareHouse", e.RowIndex].Value.ToString(),
					Fac_FaultyWareHouse = dgv_FacList["Fac_FaultyWareHouse", e.RowIndex].Value == null ? null : dgv_FacList["Fac_FaultyWareHouse", e.RowIndex].Value.ToString(),
					Fac_Note = dgv_FacList["Fac_Note", e.RowIndex].Value == null ? null : dgv_FacList["Fac_Note", e.RowIndex].Value.ToString()
				};

				FacilityInfo_NEWPopUp pop = new FacilityInfo_NEWPopUp();
				pop.ThisMode = FacilityInfo_NEWPopUp.Mode.Update;
				pop.VO = vo;
				pop.StartPosition = FormStartPosition.CenterParent;

				if (pop.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("성공적으로 수정되었습니다.");
					RefreshFacList();
				}
				else
				{
					RefreshFacList();
				}
			}
		}
		#endregion

		#endregion

		#region 메서드

		private void GetFgrpList()
		{
			FacilityService service = new FacilityService();
			FacGrpList = service.GetFacilityGroupList();
			dgv_FacGrpList.DataSource = FacGrpList;
		}

		private void RefreshFacList()
		{
			FacilityService service = new FacilityService();
			FacList = service.GetFacilityList();
			dgv_FacList.DataSource = FacList;
		}


		#endregion  

		
	}
}
