using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT
{
    public partial class EditOrderForm : Form
    {
        string id;
        public EditOrderForm(string order_id)
        {
            InitializeComponent();
            id = order_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ps = comboBox_payment.SelectedItem.ToString() == "Да"?1:0;
            DB.Update("update orders set status='"+comboBox_status.SelectedItem.ToString()+"', payment_status= "+ps+" where id="+id);
        }
    }
}
