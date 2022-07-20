using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowersShop_DB.Forms
{
    public partial class Delete : Form
    {
        flowersDBEntities context = new flowersDBEntities();
        int activeTb;

        public Delete()
        {
            InitializeComponent();
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

        private void removeFalseBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ///
            AllTables allTables_form = new AllTables();
            allTables_form.ActiveTable = activeTb;
            allTables_form.Show();
        }

        private void removeTrueBtn_Click(object sender, EventArgs e)
        {
            bool checkExist = false;

            if (activeTb == 0)
            {
                int removeId = Convert.ToInt32(removetb.Text);
                var buy = context.buy_tb
               .Where(c => c.id_b == removeId)
               .FirstOrDefault();
                if (buy != null)
                {
                    checkExist = true;
                }
                else
                {
                    MessageBox.Show("Такой покупки нет!");
                }
            }
            else if (activeTb == 1)
            {
                var type = context.type_tb
             .Where(c => c.name_t == removetb.Text)
             .FirstOrDefault();
                if (type != null)
                {
                    checkExist = true;
                }
                else
                {
                    MessageBox.Show("Такого вида нет!");
                }
            }
            else
            {
                var flower = context.flower_tb
            .Where(c => c.name_f == removetb.Text)
            .FirstOrDefault();
                if (flower != null)
                {
                    checkExist = true;
                }
                else
                {
                    MessageBox.Show("Такого цветка нет!");
                }
            }

            if (checkExist == true)
            {
                Question question_form = new Question();
                this.Hide();
                question_form.ActiveTable = activeTb;
                question_form.RemoveValue = removetb.Text;
                question_form.Show();
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            if (activeTb == 0)
            {
                removelb.Text = "Введите ID:";
            }
            else if (activeTb == 1)
            {
                removelb.Text = "Введите вид:";
                changeBtn.Visible = true;
            }
            else if (activeTb == 2)
            {
                removelb.Text = "Введите цветок:";
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            bool checkExist = false;

            var type = context.type_tb
         .Where(c => c.name_t == removetb.Text)
         .FirstOrDefault();
            if ((type != null) && (type.availability_t == false))
            {
                Question question_form = new Question();
                question_form.TypeQuestion = 2;
                question_form.AddValue = type.name_t;
                question_form.Show();
            }
            else if ((type != null) && (type.availability_t == true))
            {
                Question question_form = new Question();
                question_form.TypeQuestion = 3;
                question_form.AddValue = type.name_t;
                question_form.Show();
            }
            else if (type != null)
            {
                checkExist = true;
            }
            else
            {
                MessageBox.Show("Такого вида нет!");
            }

            if (checkExist == true)
            {
                Question question_form = new Question();
                this.Hide();
                question_form.ActiveTable = activeTb;
                question_form.RemoveValue = removetb.Text;
                question_form.Show();
            }
        }
    }
}
