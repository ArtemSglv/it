using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IT
{
    public partial class OrdersForm : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;

        public OrdersForm()
        {
            InitializeComponent();
            GetOrders();
            dataGridView.DataSource = ds.Tables[0];
            dataGridView.Columns[0].Visible = false;
        }

        private void GetOrders()
        {
            string sql = "SELECT o.id as 'ID заказа',o.client_name as 'Клиент',o.tech_name as 'Техника',o.status as 'Статус', u.name as 'Мастер', "+
                                                         "o.payment_status as 'Статус оплаты' FROM orders o join users u on o.master = u.id_user " +
                                                         "where u.role = (select id from roles where role = 'master'); ";
            mySqlDataAdapter = new MySqlDataAdapter(sql, DB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EditOrderForm(dataGridView.SelectedRows[0].Cells[0].Value.ToString()).Show();
        }
    }
}
