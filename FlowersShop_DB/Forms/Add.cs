using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace FlowersShop_DB.Forms
{
    public partial class Add : Form
    {
        flowersDBEntities context;
        int activeTb = 0;
        int countRowsTb = 0;
        string pictureName = "";
        string newTp = "";

        public Add()
        {
            InitializeComponent();
            context = new flowersDBEntities();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AllTables allTables_form = new AllTables();
            this.Hide();
            allTables_form.Show();
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

        public int CountRows
        {
            get
            {
                return countRowsTb;
            }
            set
            {
                countRowsTb = value;
            }
        }

        public string NewType
        {
            get
            {
                return newTp;
            }
            set
            {
                newTp = value;
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (ActiveTable == 0)
            {
                tbNamelb.Text = "Покупки";
                lb1.Text = "Цветок:";
                lb2.Text = "Кол-во:";
                lb3.Text = "Дата покупки:";
                lb4.Text = "Скидка:";
                lb5.Visible = false;
                tb5.Visible = false;
                tb3.Visible = false;
                checkBox1.Visible = false;
                tb1.Visible = false;
            }
            else if (ActiveTable == 1)
            {
                tbNamelb.Text = "Виды цветов";
                lb1.Text = "Название вида:";
                lb2.Text = "Цвет:";
                lb3.Text = "Срок реализации:";
                lb4.Text = "Доступность:";
                lb5.Text = "Фото:";
                tb1.Text = newTp;
                tb4.Visible = false;
                addPhotoBtn.Visible = true;
                dateTimePicker1.Visible = false;
                cb1.Visible = false;
            }
            else
            {
                tbNamelb.Text = "Цветы";
                lb1.Text = "Вид:";
                lb2.Text = "Цветок:";
                lb3.Text = "Цена:";
                lb4.Text = "Доступность:";
                lb5.Text = "Кол-во:";
                tb4.Visible = false;
                dateTimePicker1.Visible = false;
                searchBtn.Visible = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool availability = false;

            if (CountRows == 0)
            {
                CountRows = 1;
            }

            if (ActiveTable == 0)
            {
                var checkId = context.buy_tb
               .Where(c => c.id_b == CountRows)
               .FirstOrDefault();
                if (checkId != null)
                {
                    CountRows -= 1;
                    var newcheckId = context.buy_tb
                   .Where(c => c.id_b == CountRows)
                   .FirstOrDefault();
                    if (newcheckId != null)
                    {
                        CountRows += 2;
                    }
                }
                else
                {
                    int n;
                    if ((int.TryParse(cb1.Text, out n)) || (!int.TryParse(tb4.Text, out n)) || (!int.TryParse(tb2.Text, out n))
                       || (cb1.Text == "") || (tb4.Text == "") || (tb2.Text == ""))
                    {
                        MessageBox.Show("Поля заполнены не верно!");
                    }
                    else
                    {
                        var checkFlowerExist = context.flower_tb
                       .Where(c => c.name_f == cb1.Text)
                       .FirstOrDefault();

                        if (checkFlowerExist.availability_f == true)
                        {
                            if (checkFlowerExist != null)
                            {
                                buy_tb newBuy = new buy_tb()
                                {
                                    id_b = CountRows,
                                    idF_b = checkFlowerExist.id_f,
                                    count_b = Convert.ToInt32(tb2.Text),
                                    date_b = dateTimePicker1.Value,
                                    sale_b = Convert.ToInt32(tb4.Text)
                                };

                                context.buy_tb.Add(newBuy);
                                context.SaveChanges();

                                AllTables allTables_form = new AllTables();
                                this.Hide();
                                allTables_form.ActiveTable = 0;
                                allTables_form.Show();

                                MessageBox.Show("Покупка успешно совершена!");

                                cb1.Text = "";
                                tb2.Clear();
                                tb4.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Такого цветка нет!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Данный цветок не доступен!");
                        }                    
                    }
                }
            }
            else if (ActiveTable == 1)
            {
                var checkId = context.type_tb
               .Where(c => c.id_t == CountRows)
               .FirstOrDefault();
                if (checkId != null)
                {
                    CountRows -= 1;
                    var newcheckId = context.type_tb
                   .Where(c => c.id_t == CountRows)
                   .FirstOrDefault();
                    if (newcheckId != null)
                    {
                        CountRows += 2;
                    }
                }
                else
                {
                    int n;
                    if ((int.TryParse(tb1.Text, out n)) || (int.TryParse(tb2.Text, out n)) || (!int.TryParse(tb3.Text, out n)) || (pictureName == ""))
                    {
                        MessageBox.Show("Поля заполнены не верно!");
                    }
                    else
                    {
                        var checkTypeExist = context.type_tb
                       .Where(c => c.name_t == tb1.Text)
                       .FirstOrDefault();

                        if (checkTypeExist == null)
                        {
                            if (checkBox1.Checked)
                            {
                                availability = true;
                            }
                            else
                            {
                                availability = false;
                            }

                            type_tb newType = new type_tb()
                            {
                                id_t = CountRows,
                                name_t = tb1.Text,
                                colour_t = tb2.Text,
                                term_t = Convert.ToInt32(tb3.Text),
                                availability_t = availability,
                                photo_t = tb5.Text
                                //изменить на загрузку из диалогового окна
                            };

                            context.type_tb.Add(newType);
                            context.SaveChanges();

                            AllTables allTables_form = new AllTables();
                            this.Hide();
                            allTables_form.ActiveTable = 1;
                            allTables_form.Show();

                            MessageBox.Show("Вид успешно добавлен!");

                            tb1.Clear();
                            tb2.Clear();
                            tb3.Clear();
                            checkBox1.Checked = false;
                            tb5.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Такой вид уже существует!");
                        }
                    }
                }
            }
            else
            {
                var checkId = context.flower_tb
               .Where(c => c.id_f == CountRows)
               .FirstOrDefault();
                if (checkId != null)
                {
                    CountRows -= 1;
                    var newcheckId = context.flower_tb
                   .Where(c => c.id_f == CountRows)
                   .FirstOrDefault();
                    if (newcheckId != null)
                    {
                        CountRows += 2;
                    }
                }
                else
                {
                    int n;
                    if ((int.TryParse(tb1.Text, out n)) || (int.TryParse(cb1.Text, out n)) || (!int.TryParse(tb3.Text, out n)) || (!int.TryParse(tb5.Text, out n))
                        || (tb2.Text == "") || (cb1.Text == "") || (tb3.Text == "") || (tb5.Text == ""))
                    {
                        MessageBox.Show("Поля заполнены не верно!");
                    }
                    else
                    {
                        var checkFlowerExist = context.flower_tb
                   .Where(c => c.name_f == tb1.Text)
                   .FirstOrDefault();
                        if (checkFlowerExist == null)
                        {
                            if (checkBox1.Checked)
                            {
                                availability = true;
                            }
                            else
                            {
                                availability = false;
                            }
                            var checkType = context.type_tb
                           .Where(c => c.name_t == cb1.Text)
                           .FirstOrDefault();

                            if (checkType != null)
                            {
                                flower_tb newFlower = new flower_tb()
                                {
                                    id_f = CountRows,
                                    name_f = tb2.Text,
                                    idT_f = checkType.id_t,
                                    cost_f = Convert.ToInt32(tb3.Text),
                                    availability_f = availability,
                                    count_f = Convert.ToInt32(tb5.Text)
                                };

                                context.flower_tb.Add(newFlower);
                                context.SaveChanges();

                                AllTables allTables_form = new AllTables();
                                this.Hide();
                                allTables_form.ActiveTable = 2;
                                allTables_form.Show();

                                MessageBox.Show("Цветок успешно добавлен!");

                                cb1.Text = "";
                                tb2.Clear();
                                tb3.Clear();
                                checkBox1.Checked = false;
                                tb5.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Такого вида нет!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Такой цветок уже существует!");
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    pictureName = open_dialog.FileName;
                    tb5.Text = open_dialog.FileName; ;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var checkType = context.type_tb
               .Where(c => c.name_t == cb1.Text)
               .FirstOrDefault();

            if (cb1.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else if (checkType != null)
            {
                MessageBox.Show("Такой вид существует!");
            }
            else if (checkType == null)
            {
                Question question_form = new Question();
                question_form.TypeQuestion = 1;
                question_form.AddValue = cb1.Text;
                question_form.Show();
            }
        }
    }
}
