﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewForm
{
    public partial class Form1 : Form
    {
        public Form1()
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
