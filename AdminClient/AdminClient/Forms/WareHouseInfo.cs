using AdminClient.Service;
using AdminClientVO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdminClient.Forms
{
	public partial class WareHouseInfo : AdminClient.BaseForm.FormSerchListThreeSplitTemp
	{
        List<ComboWhVO> cbolist;

		public WareHouseInfo()
		{
			InitializeComponent();
		}

        private void WareHouseInfo_Load(object sender, EventArgs e)
        {
			gb_detail.Enabled = false;

            #region 콤보박스 세팅
            WareHouseService service = new WareHouseService();

            #endregion

            #region dgv셋팅

            #endregion
        }
    }
}
