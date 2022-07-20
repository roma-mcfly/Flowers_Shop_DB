using FlowersShop_DB.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersShop_DB
{
    public partial class AllTables : Form
    {
        flowersDBEntities context;
        int activeTb = 0;

        public AllTables()
        {
            InitializeComponent();
            context = new flowersDBEntities();
            Reload();
        }

        public int ActiveTable
        {
            get
            {
                return activeTb;
            }
            set
            {
                activeTb = value;
            }
        }

        private void Reload()
        {
            buyDGV.Rows.Clear();
            typesDGV.Rows.Clear();
            flowersDGV.Rows.Clear();

            var buy = context.buy_tb.ToList();
            var flowers = context.flower_tb.ToList();
            var types = context.type_tb.ToList();

            foreach (var item in buy)
            {
                var flower = context.flower_tb
              .Where(c => c.id_f == item.idF_b)
              .FirstOrDefault();

                buyDGV.Rows.Add(item.id_b, flower.name_f, item.count_b, item.date_b, item.sale_b);
            }
            foreach (var item in types)
            {
                typesDGV.Rows.Add(item.name_t, item.colour_t, item.term_t, item.availability_t, item.photo_t);
            }
            foreach (var item in flowers)
            {
                var type = context.type_tb
              .Where(c => c.id_t == item.idT_f)
              .FirstOrDefault();

                flowersDGV.Rows.Add(item.name_f, type.name_t, item.cost_f, item.availability_f, item.count_f);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm_form = new MainForm();
            mainForm_form.Show();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Add add_form = new Add();
            int countRows = 0;

            if (tabControl1.SelectedIndex == 0)
            {
                for (int i = 0; i < buyDGV.Rows.Count; i++)
                {
                    countRows++;
                }
                var flowers = context.flower_tb.ToList();
                foreach (var item in flowers)
                {
                    add_form.cb1.Items.Add(item.name_f);
                }
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                for (int i = 0; i < typesDGV.Rows.Count; i++)
                {
                    countRows++;
                }
            }
            else
            {
                for (int i = 0; i < flowersDGV.Rows.Count; i++)
                {
                    countRows++;
                }
                var types = context.type_tb.ToList();
                foreach (var item in types)
                {
                    add_form.cb1.Items.Add(item.name_t);
                }
            }
            ///
            this.Hide();
            add_form.CountRows = countRows;
            add_form.ActiveTable = tabControl1.SelectedIndex;
            add_form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            Delete delete_form = new Delete();
            delete_form.ActiveTable = tabControl1.SelectedIndex;
            ///
            this.Hide();
            delete_form.Show();
        }

        private void AllTables_Load(object sender, EventArgs e)
        {
            Reload();
            tabControl1.SelectedIndex = activeTb;
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Requests requests_form = new Requests();
            requests_form.Show();
        }
    }
}
