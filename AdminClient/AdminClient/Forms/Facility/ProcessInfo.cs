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
	public partial class ProcessInfo : AdminClient.BaseForm.FormSerchListSplitTemp
	{
		string userID = Global.Global.employees.Emp_Code;
		List<ProcessVO> PcsList;
		List<ProcessDetailVO> PDlist;
		public ProcessInfo()
		{
			InitializeComponent();

			#region 기초셋팅
			nu_limit.Enabled = false;
			gb_detail.Enabled = false;
			#endregion

			#region 데이터그리드뷰 셋팅
			dgv_Process.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_Process, "공정코드", "Pcs_Code");
			CommonUtil.AddGridTextColumn(dgv_Process, "공정이름", "Pcs_Name");
			CommonUtil.AddGridTextColumn(dgv_Process, "사용여부", "Pcs_State");

			dgv_ProcessDetail.SetGridColumn();
			CommonUtil.AddGridTextColumn(dgv_ProcessDetail, "공정코드", "Pcs_Code");
			CommonUtil.AddGridTextColumn(dgv_ProcessDetail, "세부공정코드", "PcsD_Code");
			CommonUtil.AddGridTextColumn(dgv_ProcessDetail, "세부공정이름", "PcsD_Name");
			CommonUtil.AddGridTextColumn(dgv_ProcessDetail, "사용여부", "PcsD_State");
			#endregion

			#region 콤보박스 셋팅
			cbo_State.Items.Add("전체");
			cbo_State.Items.Add("Y");
			cbo_State.Items.Add("N");

			cbo_State.SelectedIndex = 0;
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
		private void btn_search_Click(object sender, EventArgs e)
		{
			string limit, state;
			limit = state = string.Empty;

			if (chk_limit.Checked)
				limit = nu_limit.Value.ToString();
			if(cbo_State.SelectedIndex > 0)
			{
				state = cbo_State.SelectedItem.ToString();
			}
			ProcessService service = new ProcessService();
			PcsList = service.GetPcsList(limit, state);
			service.Dispose();

			dgv_Process.DataSource = PcsList;

			if (PcsList != null && PcsList.Count > 0)
			{
				searchControl1.Getdata(dgv_Process);
				sortControl1.Getdata(dgv_Process);
				gb_detail.Enabled = true;
			}
		}
		private void btn_add_Click(object sender, EventArgs e)
		{
			ProcessInfo_PopUp pop = new ProcessInfo_PopUp();
			pop.ThisMode = ProcessInfo_PopUp.Mode.Insert;
			pop.StartPosition = FormStartPosition.CenterParent;
			ProcessVO vo;

			if(pop.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("성공적으로 등록되었습니다.");
				vo = pop.VO;
				RefreshPcsList();
			}
		}
		private void dgv_Process_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == 1)
			{
				ProcessVO vo = new ProcessVO
				{
					Pcs_Code = dgv_Process["Pcs_Code", e.RowIndex].Value.ToString(),
					Pcs_Name = dgv_Process["Pcs_Name", e.RowIndex].Value.ToString(),
					Pcs_State = dgv_Process["Pcs_State", e.RowIndex].Value.ToString(),
					
				};

				ProcessInfo_PopUp pop = new ProcessInfo_PopUp();
				pop.ThisMode = ProcessInfo_PopUp.Mode.Update;
				pop.VO = vo;
				pop.StartPosition = FormStartPosition.CenterParent;

				if (pop.ShowDialog() == DialogResult.OK)
				{
					MessageBox.Show("수정이 성공적으로 완료되었습니다.");
					RefreshPcsList();
				}
			}
		}
		private void dgv_Process_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			string code = dgv_Process["Pcs_Code", e.RowIndex].Value.ToString();

			ProcessService service = new ProcessService();
			PDlist = service.GetPDList(code);
			service.Dispose();

			dgv_ProcessDetail.DataSource = PDlist;
		}
		#endregion

		#region 메서드
		public void RefreshPcsList() //수주목록 새로고침을 위한 메서드
		{
			ProcessService service = new ProcessService();
			PcsList = service.RefreshPcsList();
			service.Dispose();

			dgv_Process.DataSource = PcsList;
		}


		#endregion

		
	}
}
