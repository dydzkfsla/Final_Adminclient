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
	public partial class DemandPlan : AdminClient.BaseForm.FormSerchListTemp
	{

		List<(string name, string text)> temp = new List<(string name, string text)>();


		public DemandPlan()
		{


			InitializeComponent();
			temp.Add(("text", "text"));
			temp.Add(("text", "text"));
			temp.Add(("text", "text"));
			temp.Add(("text", "text"));
			temp.Add(("text", "text"));

			customDataGridView1.Columns[0].Frozen = true;
			customDataGridView1.DataSource = temp;
		}
	}
}
