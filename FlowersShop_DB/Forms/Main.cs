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
    public partial class MainForm : Form
    {
        flowersDBEntities context;
        int positionGlobal = 1;

        public MainForm()
        {
            InitializeComponent();
            context = new flowersDBEntities();

            var buy = context.buy_tb.ToList();
            var flowers = context.flower_tb.ToList();
            var types = context.type_tb.ToList();

            Print(positionGlobal);
            Reload();
        }

        private void Print(int position)
        {
            positionGlobal = CheckPosition(position);

           // label1.Text = Convert.ToString(positionGlobal);

            var type = context.type_tb
          .Where(c => c.id_t == positionGlobal)
          .FirstOrDefault();

            if (type != null)
            {
                namelb.Text = type.name_t;
                colorlb.Text = type.colour_t;
                termlb.Text = Convert.ToString(type.term_t);
                photoPb.BackgroundImage = Image.FromFile(type.photo_t);

                if (type.availability_t == true)
                {
                    availabilityPb.Image = Image.FromFile("yes.png");
                }
                else
                {
                    availabilityPb.Image = Image.FromFile("no.png");
                }
            }
        }

        private int CheckPosition(int position)
        {
            if (position < 1)
            {
                position = context.type_tb.Count();
            }
            else if (position > context.type_tb.Count())
            {
                position = 1;
            }
            return position;
        }

        private void Reload()
        {
            flowersDGV.Rows.Clear();

            var flowers = context.flower_tb.ToList();

            foreach (var item in flowers)
            {
                if (item.idT_f == positionGlobal)
                {
                    var type = context.type_tb
                  .Where(c => c.id_t == item.idT_f)
                  .FirstOrDefault();

                    flowersDGV.Rows.Add(item.name_f, type.name_t, item.cost_f, item.availability_f, item.count_f);
                }
            }
        }

        private void alltbBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllTables allTables_form = new AllTables();
            allTables_form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            positionGlobal++;
            Print(positionGlobal);
            Reload();
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            positionGlobal--;
            Print(positionGlobal);
            Reload();
        }
    }
}
