using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BalinVV.Sprint7.Project.V3.Lib;

namespace Tyuiu.BalinVV.Sprint7.Project.V3
{
    public partial class AddNewData : Form
    {
        public AddNewData()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path1 = @"..\DataSprint7\Teacher.csv";
        string path2 = @"..\DataSprint7\Classroom.csv";
        string path3 = @"..\DataSprint7\Department.csv";
        string path4 = @"..\DataSprint7\Lesson.csv";


        //Кнопка "Преподаватель" *****************************************************************************************************************
        private void AddNewData_Load(object sender, EventArgs e)
        {
            int x = 1 + ds.GetCountRows(path1);
            textBoxIDTeach_BVV.Text = Convert.ToString(x);
        }
        private void textBoxFIOTeach_KDR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (!IsValidInput(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxFIOTeach_BVV_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFIOTeach_BVV.Text.Length == 2 || textBoxFIOTeach_BVV.Text.Length == 4 || textBoxFIOTeach_BVV.Text.Length == 6)
            {
                if (textBoxFIOTeach_BVV.Text.Last() != '.')
                {
                    textBoxFIOTeach_BVV.Text = textBoxFIOTeach_BVV.Text.Insert(textBoxFIOTeach_BVV.Text.Length - 1, ".");
                    textBoxFIOTeach_BVV.SelectionStart = textBoxFIOTeach_BVV.Text.Length;
                }
            }
        }
        private bool IsValidInput(char inputChar)
        {
            return Char.IsLetter(inputChar) || inputChar == '.';
        }

        private void buttonAddNewTeach_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDTeach_BVV.Text == "" || textBoxFIOTeach_BVV.Text == "" || textBoxFIOTeach_BVV.Text.Length != 5 || textBoxNumberTeach_BVV.Text == "" || textBoxWorkTeach_BVV.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDTeach_BVV.Text == "")
                    {
                        MessageBox.Show("ID пуст! Пожалуйста перезайдите на страницу \"Преподаватели\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDTeach_BVV.Text}", $"{textBoxFIOTeach_BVV.Text}", $"{textBoxNumberTeach_BVV.Text}",
                    $"{textBoxWorkTeach_BVV.Text}"};
                    bool completed = ds.AddNewData(path1, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxFIOTeach_BVV.Clear();
                    textBoxNumberTeach_BVV.Clear();
                    textBoxWorkTeach_BVV.Clear();
                    textBoxIDTeach_BVV.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLoadTeacher_BVV_Click(object sender, EventArgs e)
        {
            int x = 1 + ds.GetCountRows(path1);
            textBoxIDTeach_BVV.Text = Convert.ToString(x);
            groupBoxTeach_BVV.Visible = true;
            groupBoxAudi_BVV.Visible = false;
            groupBoxPred_BVV.Visible = false;
            groupBoxKaf_BVV.Visible = false;
        }

        //Кнопка "Аудитории" *****************************************************************************************************************
        private void buttonLoadClass_BVV_Click(object sender, EventArgs e)
        {
            groupBoxPred_BVV.Visible = false;
            groupBoxKaf_BVV.Visible = false;
            groupBoxTeach_BVV.Visible = false;
            groupBoxAudi_BVV.Visible = true;
            int x = 1 + ds.GetCountRows(path2);
            textBoxIDAudi_BVV.Text = Convert.ToString(x);
        }
        private void buttonABVVudi_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDAudi_BVV.Text == "" || textBoxNumAudi_BVV.Text == "" || textBoxNameAudi_BVV.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDAudi_BVV.Text == "")
                    {
                        MessageBox.Show("ID пуст, Пожалуйста перезайдите на страницу \"Аудитории\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDAudi_BVV.Text}", $"{textBoxNumAudi_BVV.Text}", $"{textBoxNameAudi_BVV.Text}" };
                    bool completed = ds.AddNewData(path2, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxNumAudi_BVV.Clear();
                    textBoxNameAudi_BVV.Clear();
                    textBoxIDAudi_BVV.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка "Кафедры" *******************************************************************************************************************
        private void buttonLoadDepartment_BVV_Click(object sender, EventArgs e)
        {
            groupBoxTeach_BVV.Visible = false;
            groupBoxAudi_BVV.Visible = false;
            groupBoxKaf_BVV.Visible = true;
            groupBoxPred_BVV.Visible = false;
            int x = 1 + ds.GetCountRows(path3);
            textBoxIDKaf_BVV.Text = Convert.ToString(x);
        }
        private void buttonAddKaf_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDKaf_BVV.Text == "" || textBoxNumZKaf_BVV.Text == "" || textBoxNameKaf_BVV.Text == "")
                {
                    MessageBox.Show("Введите все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDKaf_BVV.Text == "")
                    {
                        MessageBox.Show("ID пуст, Пожалуйста перезайдите на страницу \"Кафедры\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDKaf_BVV.Text}", $"{textBoxNumZKaf_BVV.Text}", $"{textBoxNameKaf_BVV.Text}" };
                    bool completed = ds.AddNewData(path3, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxIDKaf_BVV.Clear();
                    textBoxNumZKaf_BVV.Clear();
                    textBoxNameKaf_BVV.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Кнопка "Предметы" ******************************************************************************************************************
        private void buttonLoadLesson_BVV_Click(object sender, EventArgs e)
        {
            groupBoxTeach_BVV.Visible = false;
            groupBoxAudi_BVV.Visible = false;
            groupBoxKaf_BVV.Visible = false;
            groupBoxPred_BVV.Visible = true;
            int x = 1 + ds.GetCountRows(path4);
            textBoxIDPred_BVV.Text = Convert.ToString(x);
        }
        private void buttonAddPred_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxIDPred_BVV.Text == "" || textBoxNamePred_BVV.Text == "" || textBoxKolPred_BVV.Text == ""
                    || textBoxClassPred_BVV.Text == "" ||
                    textBoxTypePred_BVV.Text == "" || textBoxTypePred_BVV.Text != "Экзамен" && textBoxTypePred_BVV.Text != "Зачет")
                {
                    MessageBox.Show("Вы не заполнили все данные или допустили ошибку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBoxIDPred_BVV.Text == "")
                    {
                        MessageBox.Show("ID пуст! Пожалуйста перезайдите на страницу \"Предметы\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (textBoxTypePred_BVV.Text != "" && (textBoxTypePred_BVV.Text != "Экзамен" || textBoxTypePred_BVV.Text != "Зачет"))
                    {
                        MessageBox.Show("В поле \"Тип контроля\" вы допустили ошибку, Тип контроля может быть лишь: \"Экзамен\" или \"Зачет\" ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string[] row = new string[] { $"{textBoxIDPred_BVV.Text}", $"{textBoxNamePred_BVV.Text}",
                        $"{textBoxKolPred_BVV.Text}", $"{textBoxTypePred_BVV.Text}", $"{textBoxClassPred_BVV.Text}" };
                    bool completed = ds.AddNewData(path4, row);
                    if (completed)
                    {
                        MessageBox.Show("Данные добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    textBoxIDPred_BVV.Clear();
                    textBoxNamePred_BVV.Clear();
                    textBoxKolPred_BVV.Clear();
                    textBoxTypePred_BVV.Clear();
                    textBoxClassPred_BVV.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Другие функции *********************************************************************************************************************

        private void buttonManagement_BVV_Click(object sender, EventArgs e)
        {
            Management manag = new Management();
            manag.ShowDialog();
        }
        private void textBoxKolPred_BVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxCyrillic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void groupBoxPred_BVV_Enter(object sender, EventArgs e)
        {

        }
    }

}
