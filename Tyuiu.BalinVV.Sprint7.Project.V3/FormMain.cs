using System.Diagnostics;
using Tyuiu.BalinVV.Sprint7.Project.V3.Lib;
namespace Tyuiu.BalinVV.Sprint7.Project.V3
{
    
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint7.Project.V3\Tyuiu.BalinVV.Sprint7.Project.V3\bin\DataSprint7";
        string path1 = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint7.Project.V3\Tyuiu.BalinVV.Sprint7.Project.V3\bin\DataSprint7\Teacher.csv";
        string path2 = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint7.Project.V3\Tyuiu.BalinVV.Sprint7.Project.V3\bin\DataSprint7\Classroom.csv";
        string path3 = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint7.Project.V3\Tyuiu.BalinVV.Sprint7.Project.V3\bin\DataSprint7\Department.csv";
        string path4 = @"C:\Users\Пользователь\source\repos\Tyuiu.BalinVV.Sprint7.Project.V3\Tyuiu.BalinVV.Sprint7.Project.V3\bin.\DataSprint7\Lesson.csv";

        DataService ds = new DataService();

        private void dataGridViewOut_BVV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        //Пространство "Преподавателии"********************************************************************************
        private void buttonLoadTeacher_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataMatrix = ds.GetData(path1);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_BVV.RowCount = rows;
                dataGridViewOut_BVV.ColumnCount = columns;

                dataGridViewOut_BVV.Columns[0].HeaderText = "ID";
                dataGridViewOut_BVV.Columns[1].HeaderText = "ФИО преподавателя";
                dataGridViewOut_BVV.Columns[2].HeaderText = "Номер преподавателя";
                dataGridViewOut_BVV.Columns[3].HeaderText = "Должность преподавателя";


                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_BVV.Columns[i].Width = 160;
                    dataGridViewOut_BVV.Columns[0].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_BVV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buttonRed_BVV.Visible = true;
            buttonChekFileTeacher_BVV.Visible = true;
            buttonKol_BVV.Visible = true;
            groupBoxFunc_BVV.Visible = true;
            groupBoxKolPre_BVV.Visible = false;
            groupBoxRed_BVV.Visible = true;
            buttonAddTeach_BVV.Visible = true;
            buttonSaveTeachers_BVV.Visible = false;
            panelLeftAudi_BVV.Visible = false;
            buttonRed_BVV.Visible = true;
            buttonSaveTeachers_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonCansel_BVV.Visible = false;
            panelLeftPred_BVV.Visible = false;
        }

        private void buttonOpenFile_BVV_Click(object sender, EventArgs e)
        {
            string[] PathCsv = Directory.GetFiles(openFilePath, "*.csv");

            if (PathCsv.Length > 0)
            {
                Process.Start("explorer.exe", openFilePath);
            }
            else
            {
                MessageBox.Show("В выбранной папке нет файлов с расширением .csv", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonChekFileTeacher_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path1;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveTeachers_BVV_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();

            for (int i = 0; i < dataGridViewOut_BVV.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_BVV.ColumnCount];

                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_BVV.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке,  удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_BVV.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path1, data);

            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            buttonLoadTeacher_BVV.PerformClick();
            buttonRed_BVV.Visible = true;
            buttonSaveTeachers_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonCansel_BVV.Visible = false;
        }
        private void buttonRed_BVV_Click(object sender, EventArgs e)
        {
            dataGridViewOut_BVV.ReadOnly = false;
            buttonSaveTeachers_BVV.Visible = true;
            buttonRed_BVV.Visible = false;
            buttonCansel_BVV.Visible = true; ;
        }
        private void buttonCansel_BVV_Click(object sender, EventArgs e)
        {
            buttonRed_BVV.Visible = true;
            buttonSaveTeachers_BVV.Visible = false;
            buttonCansel_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonLoadTeacher_BVV.PerformClick();
        }
        private void buttonSumTeacher_BVV_Click(object sender, EventArgs e)
        {
            int rows = ds.GetCountRows(path1);

            textBoxSum_BVV.Text = Convert.ToString(rows);
        }
        private void buttonKol_BVV_Click(object sender, EventArgs e)
        {
            groupBoxKolTeach_BVV.Visible = true;
            buttonSumTeacher_BVV.Visible = true;
            textBoxSum_BVV.Visible = true;
        }
        private void buttonAddTeach_BVV_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }

        //Пространство "Аудитория"********************************************************************************
        private void buttonLoadClass_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataMatrix = ds.GetData(path2);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_BVV.RowCount = rows;
                dataGridViewOut_BVV.ColumnCount = columns;

                dataGridViewOut_BVV.Columns[0].HeaderText = "ID";
                dataGridViewOut_BVV.Columns[1].HeaderText = "Номер аудитории";
                dataGridViewOut_BVV.Columns[2].HeaderText = "Назавание аудитории";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_BVV.Columns[i].Width = 160;
                    dataGridViewOut_BVV.Columns[0].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_BVV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelLeftKaf_BVV.Visible = false;
            panelLeftAudi_BVV.Visible = true;
            panelLeftPred_BVV.Visible = false;
            groupBoxKolPre_BVV.Visible = false;
            groupBoxKolTeach_BVV.Visible = false;
        }
        private void buttonChekFileAudi_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path2;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveAudi_BVV_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();
            for (int i = 0; i < dataGridViewOut_BVV.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_BVV.ColumnCount];

                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_BVV.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке, удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_BVV.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path2, data);

            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonLoadClass_BVV.PerformClick();
            buttonRedAudi_BVV.Visible = true;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonCansaleAudi_BVV.Visible = false;
            buttonSaveAudi_BVV.Visible = false;
        }
        private void buttonRedAudi_BVV_Click(object sender, EventArgs e)
        {
            buttonRedAudi_BVV.Visible = false;
            buttonSaveAudi_BVV.Visible = true;
            dataGridViewOut_BVV.ReadOnly = false;
            buttonCansaleAudi_BVV.Visible = true;
            buttonLoadClass_BVV.PerformClick();
        }
        private void buttonABVVudi_BVV_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }
        private void buttonCansaleAudi_BVV_Click(object sender, EventArgs e)
        {
            buttonRedAudi_BVV.Visible = true;
            buttonSaveAudi_BVV.Visible = false;
            buttonCansaleAudi_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonLoadClass_BVV.PerformClick();
        }

        //Пространство "Кафедры"********************************************************************************
        private void buttonLoadDepartment_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataMatrix = ds.GetData(path3);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_BVV.RowCount = rows;
                dataGridViewOut_BVV.ColumnCount = columns;

                dataGridViewOut_BVV.Columns[0].HeaderText = "ID";
                dataGridViewOut_BVV.Columns[1].HeaderText = "Название кафедры";
                dataGridViewOut_BVV.Columns[2].HeaderText = "Номер зав. кафедры";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_BVV.Columns[i].Width = 160;
                    dataGridViewOut_BVV.Columns[0].Width = 40;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_BVV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            panelLeftKaf_BVV.Visible = true;
            panelLeftAudi_BVV.Visible = true;
            panelLeftPred_BVV.Visible = false;
            groupBoxKolPre_BVV.Visible = false;
            groupBoxKolTeach_BVV.Visible = false;
        }
        private void buttonChekFileKaf_BVV_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path3;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonRedKaf_BVV_Click(object sender, EventArgs e)
        {
            buttonRedKaf_BVV.Visible = false;
            buttonSaveKaf_BVV.Visible = true;
            dataGridViewOut_BVV.ReadOnly = false;
            buttonCansaleKaf_BVV.Visible = true;
            buttonLoadDepartment_BVV.PerformClick();
        }
        private void buttonSaveKaf_BVV_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();
            for (int i = 0; i < dataGridViewOut_BVV.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_BVV.ColumnCount];
                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_BVV.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке, удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_BVV.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path3, data);
            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonLoadDepartment_BVV.PerformClick();
            buttonRedKaf_BVV.Visible = true;
            buttonSaveKaf_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonCansaleKaf_BVV.Visible = false;
        }
        private void buttonCansaleKaf_BVV_Click(object sender, EventArgs e)
        {
            buttonRedKaf_BVV.Visible = true;
            buttonSaveKaf_BVV.Visible = false;
            buttonCansaleKaf_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonLoadDepartment_BVV.PerformClick();
        }
        private void buttonAddKaf_BVV_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }

        //Пространство "Предметы"********************************************************************************
        private void buttonLoadLesson_BVV_Click(object sender, EventArgs e)
        {
            groupBoxKolPre_BVV.Visible = false;
            groupBoxKolTeach_BVV.Visible = false;
            panelLeftButton_BVV.Visible = true;
            panelLeftAudi_BVV.Visible = true;
            panelLeftKaf_BVV.Visible = true;
            panelLeftPred_BVV.Visible = true;

            try
            {
                string[,] DataMatrix = ds.GetData(path4);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewOut_BVV.RowCount = rows;
                dataGridViewOut_BVV.ColumnCount = columns;

                dataGridViewOut_BVV.Columns[0].HeaderText = "ID";
                dataGridViewOut_BVV.Columns[1].HeaderText = "Название предмета";
                dataGridViewOut_BVV.Columns[2].HeaderText = "Кол-во часов за семестр";
                dataGridViewOut_BVV.Columns[3].HeaderText = "Тип контроля";
                dataGridViewOut_BVV.Columns[4].HeaderText = "Раздел предмета";

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewOut_BVV.Columns[i].Width = 160;
                    dataGridViewOut_BVV.Columns[0].Width = 40;
                    dataGridViewOut_BVV.Columns[2].Width = 100;
                    dataGridViewOut_BVV.Columns[3].Width = 100;
                    dataGridViewOut_BVV.Columns[4].Width = 100;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_BVV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonFuncPred_BVV_Click(object sender, EventArgs e)
        {
            panelBottom_BVV.Visible = true;
            groupBoxKolTeach_BVV.Visible = true;
            groupBoxKolPre_BVV.Visible = true;
            textBoxKolPred_BVV.Visible = true;
            buttonSumPred_BVV.Visible = true;
            groupBoxKolPre_BVV.Text = "Общее количество учебных часов в семестре:";
            textBoxKolPred_BVV.Text = "";
        }
        private void buttonRedPred_BVV_Click(object sender, EventArgs e)
        {
            buttonRedPred_BVV.Visible = false;
            buttonSavePred_BVV.Visible = true;
            dataGridViewOut_BVV.ReadOnly = false;
            buttonCansalePred_BVV.Visible = true;
            buttonLoadLesson_BVV.PerformClick();
        }
        private void buttonSavePred_BVV_Click(object sender, EventArgs e)
        {
            List<string[]> dataList = new List<string[]>();
            for (int i = 0; i < dataGridViewOut_BVV.RowCount; i++)
            {
                bool hasEmptyValue = false;
                string[] rowData = new string[dataGridViewOut_BVV.ColumnCount];
                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    object cellValue = dataGridViewOut_BVV.Rows[i].Cells[j].Value;
                    rowData[j] = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    if (string.IsNullOrEmpty(rowData[j]))
                    {
                        hasEmptyValue = true;
                        break;
                    }
                }
                if (hasEmptyValue)
                {
                    DialogResult result = MessageBox.Show("Обнаружены пустые значения в строке, удалить эту строку?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        continue;
                    }
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                dataList.Add(rowData);
            }
            string[,] data = new string[dataList.Count, dataGridViewOut_BVV.ColumnCount];
            for (int i = 0; i < dataList.Count; i++)
            {
                for (int j = 0; j < dataGridViewOut_BVV.ColumnCount; j++)
                {
                    data[i, j] = dataList[i][j];
                }
            }
            bool save = ds.UpData(path4, data);
            if (save)
            {
                MessageBox.Show("Таблица обновлена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            buttonLoadLesson_BVV.PerformClick();
            buttonRedPred_BVV.Visible = true;
            buttonSavePred_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonCansalePred_BVV.Visible = false;
        }
        private void buttonChekFilePred_BVV_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process csv = new System.Diagnostics.Process();
                csv.StartInfo.FileName = "Excel.exe";
                csv.StartInfo.Arguments = path4;
                csv.Start();
            }
            catch
            {
                MessageBox.Show("Сбой открытия файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAddPred_BVV_Click(object sender, EventArgs e)
        {
            AddNewData add = new AddNewData();
            add.ShowDialog();
        }
        private void buttonCansalePred_BVV_Click(object sender, EventArgs e)
        {
            buttonRedPred_BVV.Visible = true;
            buttonSavePred_BVV.Visible = false;
            buttonCansalePred_BVV.Visible = false;
            dataGridViewOut_BVV.ReadOnly = true;
            buttonLoadLesson_BVV.PerformClick();
        }
        private void buttonSumPred_BVV_Click(object sender, EventArgs e)
        {
            if (groupBoxKolPre_BVV.Text == "Общее количество учебных часов в семестре:")
            {
                string[,] DataMatrix = ds.GetData(path4);
                int[] res = ds.GetAllHours(DataMatrix);
                double sum = 0;
                for (int i = 0; i < res.Length; i++)
                {
                    sum += res[i];
                }
                textBoxKolPred_BVV.Text = Convert.ToString(sum);
            }
            if (groupBoxKolPre_BVV.Text == "Минимальное количество часов по предмету:")
            {
                string[,] DataMatrix = ds.GetData(path4);
                int[] res = ds.GetAllHours(DataMatrix);
                int min = ds.MinValue(res);
                textBoxKolPred_BVV.Text = Convert.ToString(min);
            }
            if (groupBoxKolPre_BVV.Text == "Максимальное количество часов по предмету:")
            {
                string[,] DataMatrix = ds.GetData(path4);
                int[] res = ds.GetAllHours(DataMatrix);
                int max = ds.MaxValue(res);
                textBoxKolPred_BVV.Text = Convert.ToString(max);
            }
        }

        private void buttonMinPred_BVV_Click(object sender, EventArgs e)
        {
            groupBoxKolPre_BVV.Text = "Минимальное количество часов по предмету:";
            textBoxKolPred_BVV.Text = "";
            panelBottom_BVV.Visible = true;
            groupBoxKolTeach_BVV.Visible = true;
            groupBoxKolPre_BVV.Visible = true;
            textBoxKolPred_BVV.Visible = true;
            buttonSumPred_BVV.Visible = true;
        }
        private void buttonMaxPred_BVV_Click(object sender, EventArgs e)
        {
            groupBoxKolPre_BVV.Text = "Максимальное количество часов по предмету:";
            textBoxKolPred_BVV.Text = "";
            panelBottom_BVV.Visible = true;
            groupBoxKolTeach_BVV.Visible = true;
            groupBoxKolPre_BVV.Visible = true;
            textBoxKolPred_BVV.Visible = true;
            buttonSumPred_BVV.Visible = true;
        }
        private void buttonGraphTech_BVV_Click(object sender, EventArgs e)
        {
            Func func = new Func();
            func.ShowDialog();
        }


        private void buttonManagement_BVV_Click(object sender, EventArgs e)
        {
            Management manag = new Management();
            manag.ShowDialog();
        }

        private void buttonInfo_BVV_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxKolPre_BVV_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxKolTeach_BVV_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSum_BVV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
