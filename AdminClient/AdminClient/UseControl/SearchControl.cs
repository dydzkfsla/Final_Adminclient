using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AdminClient
{
    public partial class SearchControl : UserControl
    {
        class BaindingKey
        {
            public string Display { get; set; }
            public string Value { get; set; }
            public Type type { get; set; }
            public BaindingKey()
            {

            }

            public BaindingKey(string display, string value)
            {
                Display = display;
                Value = value;
            }

            public BaindingKey(string display, string value, Type type) : this(display, value)
            {
                this.type = type;
            }
        }

        class Selectitem
        {
            public string Display { get; set; }
            public int Value { get; set; }

            public Selectitem()
            {

            }

            public Selectitem(string display, int value)
            {
                Display = display;
                Value = value;
            }
        }

        List<BaindingKey> items = new List<BaindingKey>();

        dynamic DataList;
        dynamic temp;
        DataGridView dgv;

        public event EventHandler SearchClick
        { 
            add 
            {
                btn_Search.Click += value;
            }
            remove
            {
                btn_Search.Click -= value;
            }
        }

        public SearchControl()
        {
            InitializeComponent();

            cbo_key.DisplayMember = "Display";
            cbo_key.ValueMember = "Value";

            List<Selectitem> select = new List<Selectitem>()
            { new Selectitem("선택" ,0), new Selectitem("Text" ,1), new Selectitem("%Text" ,2), new Selectitem("Text%" ,3), new Selectitem("%Text%" ,4) };
            cbo_keyword.DisplayMember = "Display";
            cbo_keyword.ValueMember = "Value";
            cbo_keyword.DataSource = select;
        }

        public void Getdata(DataGridView dgv)
        {
            this.dgv = dgv;

            DataList = dgv.DataSource;
            foreach (DataGridViewColumn dc in dgv.Columns)
            {
                if (dc is DataGridViewTextBoxColumn && dc.Visible)
                {
                    Type type = DataList[0].GetType(); //vo
                    Type addType = null;
                    foreach (PropertyInfo prop in type.GetProperties()) //선택한 prop값에따라
                    {
                        if (prop.Name == dc.DataPropertyName)
                        {
                            addType = prop.PropertyType;
                        }
                    }

                    items.Add(new BaindingKey(dc.HeaderText, dc.DataPropertyName, addType));
                }
            }
            items.Insert(0, new BaindingKey("선택", "", typeof(string)));
            cbo_key.DataSource = items;
        }

        private bool Stringcompare(string value, string search)//string 과 선택에 따른 value 바인딩
        {
            switch (cbo_keyword.SelectedValue)
            {
                case 1:
                    return value.Equals(search);
                case 2:
                    return search == value.Right(search.Length);
                case 3:
                    return search == value.Left(search.Length);
                case 4:
                    return value.Contains(search);
                default:
                    return false;
            }
        }

        private void SelectStringToSearch()
        {
            Type type1 = DataList.GetType();
            temp = Activator.CreateInstance(type1); //list<vo>

            foreach(dynamic item in DataList)
            {
                Type type = item.GetType();
                string value = string.Empty;            //선택한 값
                string search = txt_keyword.Text.Trim();//검색 값
                foreach (PropertyInfo prop in type.GetProperties()) //선택한 prop값에따라
                {
                    if (prop.Name == ((BaindingKey)cbo_key.SelectedItem).Value)
                    {
                        value = prop.GetValue(item).ToString();
                    }
                }
                if (Stringcompare(value, search))
                {
                    temp.Add(item);
                }
            }
        }

        private void SelectIntToSearch()
        {
            Type type1 = DataList.GetType();
            temp = Activator.CreateInstance(type1);

            foreach (dynamic item in DataList)
            {
                Type type = item.GetType();
                int value = -9999;            //선택한 값
                int IntFrom = Convert.ToInt32(txt_IntFrom.Text.Trim());//검색 값
                int IntTo = Convert.ToInt32(txt_IntTo.Text.Trim());
                foreach (PropertyInfo prop in type.GetProperties()) //선택한 prop값에따라
                {
                    if (prop.Name == ((BaindingKey)cbo_key.SelectedItem).Value)
                    {
                        value = Convert.ToInt32(prop.GetValue(item));
                    }
                }
                if (IntFrom <= value && value <= IntTo)
                {
                    temp.Add(item);
                }
            }
        }

        private void SelectDateTimeToSearch()
        {
            Type type1 = DataList.GetType();
            temp = Activator.CreateInstance(type1);

            foreach (dynamic item in DataList)
            {
                Type type = item.GetType();
                DateTime value = new DateTime(9998, 12, 10);            //선택한 값
                DateTime IntFrom = dtp_From.Value;//검색 값
                DateTime IntTo = dtp_to.Value;
                foreach (PropertyInfo prop in type.GetProperties()) //선택한 prop값에따라
                {
                    if (prop.Name == ((BaindingKey)cbo_key.SelectedItem).Value)
                    {
                        value = Convert.ToDateTime(prop.GetValue(item));
                    }
                }
                if (IntFrom <= value && value <= IntTo)
                {
                    temp.Add(item);
                }
            }
        }

        private void cbo_key_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_keyword.SelectedItem != null)
            {
                BaindingKey item = (BaindingKey)cbo_key.SelectedItem;

                if (item.type == typeof(int) || item.type == typeof(decimal))
                {
                    pnl_DateTime.Visible = false;
                    pnl_int.Visible = true;
                    pnl_string.Visible = false;
                }
                else if (item.type == typeof(string) )
                {

                    pnl_DateTime.Visible = false;
                    pnl_int.Visible = false;
                    pnl_string.Visible = true;
                }
                else if (item.type == typeof(DateTime))
                {
                    pnl_DateTime.Visible = true;
                    pnl_int.Visible = false;
                    pnl_string.Visible = false;
                }
                else
                {
                    pnl_DateTime.Visible = false;
                    pnl_int.Visible = false;
                    pnl_string.Visible = true;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (cbo_key.SelectedIndex > 0 && cbo_keyword.SelectedIndex > 0 && !string.IsNullOrWhiteSpace(txt_keyword.Text) && DataList != null && pnl_string.Visible)
            {
                SelectStringToSearch();
                dgv.DataSource = temp;
            }
            else if (cbo_key.SelectedIndex > 0 && !string.IsNullOrWhiteSpace(txt_IntFrom.Text) && !string.IsNullOrWhiteSpace(txt_IntTo.Text) && DataList != null && pnl_int.Visible)
            {
                SelectIntToSearch();
                dgv.DataSource = temp;
            }
            else if (cbo_key.SelectedIndex > 0 && pnl_DateTime.Visible)
            {
                SelectDateTimeToSearch();
                dgv.DataSource = temp;
            }
            else
            {
                dgv.DataSource = DataList;
                return;
            }
        }
    }
}
