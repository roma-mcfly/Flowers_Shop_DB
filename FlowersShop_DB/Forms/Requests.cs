using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersShop_DB.Forms
{
    public partial class Requests : Form
    {
        flowersDBEntities context = new flowersDBEntities();
        static SqlTransaction tx = null;

        public Requests()
        {
            InitializeComponent();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllTables allTables = new AllTables();
            allTables.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex == 1) || (comboBox1.SelectedIndex == 3) || (comboBox1.SelectedIndex == 4) || (comboBox1.SelectedIndex == 9))
            {
                tbValue.Visible = true;
                lb1.Visible = true;
                lb6.Visible = false;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                lb6.Visible = true;
                tbValue.Visible = false;
                lb1.Visible = false;
            }
            else
            {
                tbValue.Visible = false;
                lb1.Visible = false;
                lb6.Visible = false;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            dtv.DataSource = null;
            dtv.Rows.Clear();
            dtv.Columns.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                SelectQuery("SELECT id_b, ((count_b*cost_f)-(count_b*cost_f)*(sale_b * 0.01)) as final_cost from buy_tb inner join flower_tb on buy_tb.idF_b = flower_tb.id_f");
            }

            if ((comboBox1.SelectedIndex == 1) && (tbValue.Text != ""))
            {
                SelectQuery($"SELECT name_f, cost_f, count_f, availability_f FROM buy_tb inner join flower_tb on buy_tb.idF_b = flower_tb.id_f group by availability_f, name_f, cost_f, count_f, ((count_b*cost_f)-(count_b*cost_f)*(sale_b * 0.01)) having ((count_b*cost_f)-(count_b*cost_f)*(sale_b * 0.01)) = {tbValue.Text}");
            }
            else if ((comboBox1.SelectedIndex == 1) && (tbValue.Text == ""))
            {
                MessageBox.Show("Заполните поле ввода!");
            }

            if (comboBox1.SelectedIndex == 2)
            {
                SelectQuery("select name_f from flower_tb inner join buy_tb on buy_tb.idF_b = flower_tb.id_f where count_b = (select min(count_b) from buy_tb)");
            }

            if ((comboBox1.SelectedIndex == 3) && (tbValue.Text != ""))
            {
                SelectQuery($"SELECT name_f, cost_f, term_t FROM flower_tb inner join type_tb on type_tb.id_t = flower_tb.idT_f where type_tb.term_t > {tbValue.Text}");
            }
            else if ((comboBox1.SelectedIndex == 3) && (tbValue.Text == ""))
            {
                MessageBox.Show("Заполните поле ввода!");
            }

            if ((comboBox1.SelectedIndex == 4) && (tbValue.Text != ""))
            {
                SelectQuery($"SELECT name_f, ((count_b*cost_f)-(count_b*cost_f)*(sale_b * 0.01)) as avg_cost from flower_tb inner join buy_tb on buy_tb.idF_b = flower_tb.id_f where DAY(date_b) = DAY(GETDATE()) group by name_f, ((count_b*cost_f)-(count_b*cost_f)*(sale_b * 0.01)) having ((count_b*cost_f)-(count_b*cost_f)*(sale_b * 0.01)) < {tbValue.Text}");
            }
            else if ((comboBox1.SelectedIndex == 4) && (tbValue.Text == ""))
            {
                MessageBox.Show("Заполните поле ввода!");
            }

            if (comboBox1.SelectedIndex == 5)
            {
                lb6.Text = "Кол-во: ";
                using (flowersDBEntities db = new flowersDBEntities())
                {
                    int allCount = db.buy_tb.Where(p => p.date_b == DateTime.Today)
                            .Count();
                    lb6.Text += allCount;
                }
            }

            if (comboBox1.SelectedIndex == 6)
            {
                using (flowersDBEntities db = new flowersDBEntities())
                {
                    var buys = db.buy_tb.GroupBy(p => p.date_b)
                            .Select(g => new
                            {
                                Count = g.Count(),
                                Date = g.Key
                            });
                    dtv.Columns.Add("Кол-во", "Кол-во");
                    dtv.Columns.Add("Дата", "Дата");
                    foreach (var buy in buys)
                        dtv.Rows.Add(buy.Count, buy.Date);
                }
            }

            if (comboBox1.SelectedIndex == 7)
            {
                using (flowersDBEntities db = new flowersDBEntities())
                {
                    var buys = db.buy_tb.GroupBy(p => p.date_b)
                            .Select(g => new
                            {
                                Avg = g.Average(p => p.sale_b),
                                Date = g.Key
                            }).Where(g => g.Avg > 10);
                    dtv.Columns.Add("Скидка", "Скидка");
                    dtv.Columns.Add("Дата", "Дата");
                    foreach (var buy in buys)
                        dtv.Rows.Add(buy.Avg, buy.Date);
                }
            }

            if (comboBox1.SelectedIndex == 8)
            {
                SelectQuery("SELECT name_f FROM flower_tb where id_f not in (select idF_b from buy_tb)");
            }

            if ((comboBox1.SelectedIndex == 9) && (tbValue.Text != ""))
            {
                SelectQuery($"SELECT name_t, sum(count_b) as all_count from type_tb inner join flower_tb on id_t = idT_f inner join buy_tb on idF_b = id_f where term_t = {tbValue.Text} group by name_t");
            }
            else if ((comboBox1.SelectedIndex == 9) && (tbValue.Text == ""))
            {
                MessageBox.Show("Заполните поле ввода!");
            }

            tbValue.Text = "";
        }

        private void SelectQuery(string Query)
        {

            using (SqlConnection connection = new SqlConnection(context.Database.Connection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                SqlTransaction sqlTran = connection.BeginTransaction();
                try
                {
                    cmd = new SqlCommand(Query, connection);
                    cmd.Connection = connection;
                    cmd.Transaction = sqlTran;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtv.DataSource = table;
                    cmd.ExecuteNonQuery();
                    sqlTran.Commit();

                  //  dtv.DataSource = null;
                }
                catch (Exception ee)
                {
                    sqlTran.Rollback();
                    MessageBox.Show(ee.Message, "Не удалось внести данные");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
