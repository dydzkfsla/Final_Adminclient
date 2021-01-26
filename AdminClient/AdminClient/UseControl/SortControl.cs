using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class SortControl : UserControl
    {
        class BaindingKey
        {
            public string Display { get; set; }
            public string Value { get; set; }

            public BaindingKey()
            {

            }

            public BaindingKey(string display, string value)
            {
                Display = display;
                Value = value;
            }
        }

        dynamic dgv;
        dynamic DataList;

        List<BaindingKey> items;

        Type VoType;
        PropertyInfo select;

        public SortControl()
        {
            InitializeComponent();
        }

        public void Getdata(DataGridView dgv)
        {
            items = new List<BaindingKey>();
            this.dgv = dgv;

            DataList = dgv.DataSource;
            foreach (DataGridViewColumn dc in dgv.Columns)
            {
                if (dc is DataGridViewTextBoxColumn)
                {
                    Type type = DataList[0].GetType();
                    foreach (PropertyInfo prop in type.GetProperties()) //선택한 prop값에따라
                    {
                        if (prop.Name == dc.DataPropertyName)
                        {
                            items.Add(new BaindingKey(dc.HeaderText, dc.DataPropertyName));
                        }
                    }
                }
            }
            items.Insert(0, new BaindingKey("선택", ""));

            cbo_Sortkey.DisplayMember = "Display";
            cbo_Sortkey.ValueMember = "Value";
            cbo_Sortkey.DataSource = items.ToList();
        }

        private void btn_SortPrice_Click(object sender, EventArgs e)
        {
            if (!(cbo_Sortkey.SelectedIndex > 0))
                return;
            dynamic list = DataList.ToArray(); //데이터 소스를가져옴

            QuickSort(list, 0, list.Length - 1);

            dynamic data = Activator.CreateInstance(DataList.GetType());

            foreach(dynamic item in list)
            {
                data.Add(item);
            }

            dgv.DataSource = data; //해당 값을 바인딩
        }

        private int Partition(dynamic array, int left, int right)
        {
            dynamic pivot = array[left]; //VO
            VoType = pivot.GetType();
            int low = left + 1;
            int high = right;

            foreach (PropertyInfo info in VoType.GetProperties())
            {
                if (info.Name == cbo_Sortkey.SelectedValue.ToString()) //선택한 프로퍼티
                {
                    select = info;
                }
            }
            dynamic Maxvalue;
            dynamic Minvalue;
            if (select.PropertyType.Name != "String")
            {
                Maxvalue = select.PropertyType.GetField("MaxValue").GetValue(VoType);
                Minvalue = select.PropertyType.GetField("MinValue").GetValue(VoType);
            }
            else
            {
                Maxvalue = "힇힇힇힇힇힇힇힇힇힇힇힇힇힇힇힇";
                Minvalue = "AAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            }

            dynamic pivotValue = select.GetValue(pivot);
            dynamic Value;
            while (low <= high) // 교차되기 전까지 반복한다 
            {
                if (rd_ascending.Checked)
                {
                    if (pivotValue == null)
                    {
                        pivotValue = Maxvalue;
                    }

                    while (low <= right) // 피벗보다 큰 값을 찾는 과정 
                    {
                        Value = select.GetValue(array[low]) == null ? Maxvalue : select.GetValue(array[low]);

                        if (!(pivotValue.CompareTo(Value) >= 0))
                        {
                            break;
                        }

                        low++; // low를 오른쪽으로 이동 
                    }
                    while (high >= (left + 1)) // 피벗보다 작은 값을 찾는 과정 
                    {
                        Value = select.GetValue(array[high]) == null ? Maxvalue : select.GetValue(array[high]);

                        if (!(pivotValue.CompareTo(Value) <= 0))
                        {
                            break;
                        }
                        high--; // high를 왼쪽으로 이동
                    }
                }
                else
                {
                    if (pivotValue == null)
                    {
                        pivotValue = Minvalue;
                    }

                    while (low <= right) // 피벗보다 큰 값을 찾는 과정 
                    {
                        Value = select.GetValue(array[low]) == null ? Minvalue : select.GetValue(array[low]);
                        if (!(pivotValue.CompareTo(Value) <= 0))
                        {
                            break;
                        }
                        low++; // low를 오른쪽으로 이동 
                    }
                    while (high >= (left + 1)) // 피벗보다 작은 값을 찾는 과정 
                    {
                        Value = select.GetValue(array[high]) == null ? Minvalue : select.GetValue(array[high]);

                        if (!(pivotValue.CompareTo(Value) >= 0))
                        {
                            break;
                        }
                        high--; // high를 왼쪽으로 이동
                    }
                }
                if (low <= high)// 교차되지 않은 상태이면 스왑 과정 실행 
                {
                    Swap(array, low, high); //low와 high를 스왑 
                }
            }
            Swap(array, left, high); // 피벗과 high가 가리키는 대상을 교환 
            return high;  // 옮겨진 피벗의 위치정보를 반환 
        }

        void QuickSort(dynamic array, int left, int right)
        {
            if (left <= right)
            {
                int pivot = Partition(array, left, right); // 둘로 나누어서
                QuickSort(array, left, pivot - 1); // 왼쪽 영역을 정렬한다.
                QuickSort(array, pivot + 1, right); // 오른쪽 영역을 정렬한다.
            }
        }

        public void Swap(dynamic array, int left, int right)
        {
            dynamic temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
