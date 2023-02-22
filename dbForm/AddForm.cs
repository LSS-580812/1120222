using dbForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbForm
{
    public partial class AddForm : Form
    {
        ContactsTable ct = new ContactsTable();
        public AddForm()
        {
            InitializeComponent();
        }

        private void btn_Append_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable()
            {
                UserName = textBox1.Text.Trim(),
                Address = textBox2.Text.Trim(),
                Phone = textBox3.Text.Trim()
            };
            try
            {
                ContactsModel context = new ContactsModel();
                context.ContactsTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearTextBoxes();
            }
            catch (Exception ex)
            { MessageBox.Show($"發生錯誤 {ex.ToString()}"); }
        }

        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

    }


    
}
