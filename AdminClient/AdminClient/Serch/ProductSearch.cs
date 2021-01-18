using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AdminClientDAC;

namespace AdminClient.Serch
{
    public partial class ProductSearch : AdminClient.BaseForm.FormSearchTemp
    {
        public ProductSearch()
        {
            InitializeComponent();
            Class1 class1 = new Class1();
            string com = class1.Test();
        }
    }
}
