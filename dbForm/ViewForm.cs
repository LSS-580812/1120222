using dbForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbForm
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void BindData()
        {
            var context = new ContactsModel();
            var list = context.ContactsTable.ToList();
            dataGridView1.DataSource = list;
        }
    }
}
