using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.PopUp
{
    public partial class FacilityPopUp : AdminClient.BaseForm.EmpFormTemp
    {
        public enum Mode { Insert, Update } // Insert : 등록, Update : 수정
        Mode mode;
        FacilityVO vo;
        string userID = Global.Global.employees.Emp_Code;
        List<ComboFgrpNameVO> FgrpNameList;
        List<ComboWHNameVO> MWHNameList;
        List<ComboWHNameVO> GWHNameList;
        List<ComboWHNameVO> FWHNameList;

        public FacilityVO VO { get { return vo; } set { vo = value; } }
        public Mode ThisMode { set { mode = value; } }

        public FacilityPopUp()
        {
            InitializeComponent();

            #region 콤보박스 셋팅
            ComboBindingService service = new ComboBindingService();
            FgrpNameList = service.BindingFgrpName();
            MWHNameList = service.BindingWHName();
            GWHNameList = service.BindingWHName();
            FWHNameList = service.BindingWHName();
            service.Dispose();

            cbo_FgrpCode.DataSource = FgrpNameList; //설비군명 바인딩
            cbo_FgrpCode.DisplayMember = "FacGrp_Name";
            cbo_FgrpCode.ValueMember = "FacGrp_Code";
            cbo_FacMWH.DataSource = MWHNameList; //창고명 바인딩
            cbo_FacMWH.DisplayMember = "WH_Name";
            cbo_FacMWH.ValueMember = "WH_Code";
            cbo_FacGWH.DataSource = GWHNameList; //창고명 바인딩
            cbo_FacGWH.DisplayMember = "WH_Name";
            cbo_FacGWH.ValueMember = "WH_Code";
            cbo_FacFWH.DataSource = FWHNameList; //창고명 바인딩
            cbo_FacFWH.DisplayMember = "WH_Name";
            cbo_FacFWH.ValueMember = "WH_Code";

            cbo_FacEnable.Items.Add("Y");
            cbo_FacEnable.Items.Add("N");
            cbo_FacOutsourcing.Items.Add("Y");
            cbo_FacOutsourcing.Items.Add("N");
            cbo_FacEnable.SelectedIndex = cbo_FacOutsourcing.SelectedIndex = 0;

			#endregion
		}

		private void FacilityPopUp_Load(object sender, EventArgs e)
        {
            #region 기초 셋팅
            if (mode == Mode.Insert)
            {
                lbl_Title.Text = "설비등록";
                 
                txt_FacCode.Enabled = false;
                txt_FacCode.Text = "자동입력";

            }
           

            #endregion
        }

        private void btn_FileSearch_Click(object sender, EventArgs e)
		{
            OpenFileDialog dlg = new OpenFileDialog();
            //항상 오픈파일 다이알로그 전에 필터설정 먼저 해주자
            dlg.Filter = "Images Files(*.jpg;*.gif;*.jpeg;*.png;*.bmp;*.jfif)|*.jpg;*.gif;*.jpeg;*.png;*.bmp;*.jfif";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_FilePath.Text = dlg.FileName;

                pb_FacPicture.Image = Image.FromFile(dlg.FileName);
                pb_FacPicture.SizeMode = PictureBoxSizeMode.Zoom;
                pb_FacPicture.Tag = dlg.FileName;
            }
        }

		private void btn_Save_Click(object sender, EventArgs e) //저장버튼
		{
            //유효성체크
            if (!ChkTextBox())
            {
                MessageBox.Show("노란색 항목은 필수입력 입니다.");
                return;
            }

            string localFile = pb_FacPicture.Tag.ToString();
            string sExt = localFile.Substring(localFile.LastIndexOf("."));
            string newFileName = txt_FacName.Text + sExt;
            Imagedata data = new Imagedata();
            data.image = CommonUtil.ImageToByte(pb_FacPicture.Image);
            data.filename = newFileName;
            ServiceHelp serviceHelp = new ServiceHelp();
            ApiMessage result = serviceHelp.PostApiCallerNone("Images/Upload", data);
            if (result.ResultCode == "S")
                MessageBox.Show("이미지 저장 성공");

            if (mode == Mode.Insert)
            {
                vo = new FacilityVO
                {
                    FacGrp_Code = cbo_FgrpCode.SelectedValue.ToString(),
                    Fac_Name = txt_FacName.Text,
                    Fac_Enable = cbo_FacEnable.SelectedItem.ToString(),
                    Fac_Outsourcing = cbo_FacOutsourcing.SelectedItem.ToString(),
                    Fac_ImgPath = newFileName,
                    Fac_MaterialWareHouse = cbo_FacMWH.SelectedValue.ToString(),
                    Fac_GoodsWareHouse = cbo_FacGWH.SelectedValue.ToString(),
                    Fac_FaultyWareHouse = cbo_FacFWH.SelectedValue.ToString(),
                    Fac_Note = txt_Note.Text
                };

                FacilityService service = new FacilityService();
                if (service.AddFacility(userID, vo))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("설비 등록중 오류가 발생했습니다. 다시 시도하여 주십시오.");
                    return;
                }
            }
        }

        #region 메서드

        #region 텍스트박스 유효성체크
        private bool ChkTextBox()
        {
            bool ChkTextBox = true;

            CommonUtil.ControlAction<Panel, TextBox>(panel1, (x) =>
            {
                if (string.IsNullOrWhiteSpace(x.Text.Trim()))
                {
                    ChkTextBox = false;
                }
            });
            return ChkTextBox;
        }
        #endregion

        #endregion
    }
}
