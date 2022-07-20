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
    public partial class Question : Form
    {
        flowersDBEntities context = new flowersDBEntities();

        int activeTb = 0;
        string removeVl = "";
        string addVl = "";
        int typeQuest = 0;

        public Question()
        {
            InitializeComponent();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            if (typeQuest == 1)
            {
                this.Hide();
                ///
                Delete delete_form = new Delete();
                delete_form.ActiveTable = activeTb;
                delete_form.Show();
            }
            else
            {
                this.Hide();
                Delete delete_form = new Delete();
                delete_form.ActiveTable = activeTb;
                delete_form.Show();
            }
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

        public string RemoveValue
        {
            get
            {
                return removeVl;
            }
            set
            {
                removeVl = value;
            }
        }

        public string AddValue
        {
            get
            {
                return addVl;
            }
            set
            {
                addVl = value;
            }
        }

        public int TypeQuestion
        {
            get
            {
                return typeQuest;
            }
            set
            {
                typeQuest = value;
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (typeQuest == 1)
            {
                this.Hide();
                Add add_form = new Add();
                add_form.ActiveTable = 1;
                add_form.NewType = addVl;
                add_form.Show();
            }
            else if (typeQuest == 2)
            {
                var type = context.type_tb
                 .Where(c => c.name_t == addVl)
                 .FirstOrDefault();
                var item = context.type_tb.Find(type.id_t);

                item.availability_t = true;
                context.SaveChanges();
                AllTables allTables_form = new AllTables();
                this.Hide();
                allTables_form.ActiveTable = 1;
                allTables_form.Show();

                MessageBox.Show("Вид снова доступен!");
            }
            else if (typeQuest == 3)
            {
                var type = context.type_tb
             .Where(c => c.name_t == addVl)
             .FirstOrDefault();
                var item = context.type_tb.Find(type.id_t);

                item.availability_t = false;
                context.SaveChanges();
                AllTables allTables_form = new AllTables();
                this.Hide();
                allTables_form.ActiveTable = 1;
                allTables_form.Show();

                MessageBox.Show("Вид больше не доступен!");
            }
            else
            {
                if (activeTb == 0)
                {
                    int removeId = Convert.ToInt32(removeVl);
                    var buy = context.buy_tb
                   .Where(c => c.id_b == removeId)
                   .FirstOrDefault();

                    var item = context.buy_tb.Find(buy.id_b);
                    context.buy_tb.Remove(item);
                    context.SaveChanges();
                    AllTables allTables_form = new AllTables();
                    allTables_form.Hide();
                    this.Hide();
                    allTables_form.ActiveTable = 0;
                    allTables_form.Show();

                    MessageBox.Show("Покупка успешно удалёна!");
                }
                else if (activeTb == 1)
                {                   
                    var type = context.type_tb
                 .Where(c => c.name_t == removeVl)
                 .FirstOrDefault();

                    var item = context.type_tb.Find(type.id_t);
                    context.type_tb.Remove(item);
                    context.SaveChanges();
                    AllTables allTables_form = new AllTables();
                    this.Hide();
                    allTables_form.ActiveTable = 1;
                    allTables_form.Show();

                    MessageBox.Show("Вид успешно удалён!");
                }
                else
                {
                    var flower = context.flower_tb
                .Where(c => c.name_f == removeVl)
                .FirstOrDefault();

                    var item = context.flower_tb.Find(flower.id_f);
                    context.flower_tb.Remove(item);
                    context.SaveChanges();
                    AllTables allTables_form = new AllTables();
                    this.Hide();
                    allTables_form.ActiveTable = 2;
                    allTables_form.Show();

                    MessageBox.Show("Цветок успешно удалён!");
                }
            }
        }

        private void Question_Load(object sender, EventArgs e)
        {
            if (typeQuest == 1)
            {
                lb1.Text = "Вид не существует!";
                lb2.Text = "Хотите добавить?";
                valuelb.Text = addVl;
            }
            else if (typeQuest == 2)
            {
                lb1.Text = "Вид не доступен!";
                lb2.Text = "Хотите сделать его доступным?";
                valuelb.Text = addVl;
            }
            else if (typeQuest == 3)
            {
                lb1.Text = "Вид доступен!";
                lb2.Text = "Хотите сделать его не доступным?";
                valuelb.Text = addVl;
            }
            else
            {
                valuelb.Text = removeVl;
                if (activeTb == 0)
                {
                    lb2.Text = "хотите удалить покупку:";
                }
                else if (activeTb == 1)
                {
                    lb2.Text = "хотите удалить вид:";
                }
                else if (activeTb == 2)
                {
                    lb2.Text = "хотите удалить цветок:";
                }
            }
        }
    }
}
