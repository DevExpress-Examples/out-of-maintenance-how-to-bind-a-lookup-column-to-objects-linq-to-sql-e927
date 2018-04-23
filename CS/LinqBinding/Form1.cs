using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqBinding {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        NorthwindDataContext context = new NorthwindDataContext();

        private void Form1_Load(object sender, EventArgs e) {
            BindingSource products = new BindingSource(context.Products, "");
            BindingSource categories = new BindingSource(context.Categories, "");
            repositoryItemLookUpEdit1.DataSource = categories;
            gridControl1.DataSource = products;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            context.SubmitChanges();
        }
    }
}
