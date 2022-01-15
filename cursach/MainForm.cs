using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace cursach
{
    public partial class MainForm : Form
    {
        private StudentsList subordinatesList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSbd addSbd = new AddSbd();
            var result = addSbd.ShowDialog();
            if (result != DialogResult.OK)
                return;

            subordinatesList.Add(addSbd.Profile);
            UpdateGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dataGridView1.SelectedRows; // Найти профиль, который 
                Profile profile = rows[0].DataBoundItem as Profile; // относится к выбранному ряду
                AddSbd addSbd = new AddSbd { Profile = profile };
                var result = addSbd.ShowDialog(); // Открываем форму редактирования
                if (result != DialogResult.OK)
                    return;
                UpdateGrid();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Необхідно обрати профіль");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            subordinatesList = new StudentsList();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = subordinatesList.list;
            сохранитьToolStripMenuItem.Enabled = false;
            foreach (DataGridViewColumn i in dataGridView1.Columns)
                i.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);

            try  { subordinatesList.DownloadFileToList("Properties.Resources.last"); }
            catch { }

            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(Add_button, "Створити новий профіль студента");
            toolTip1.SetToolTip(Edit_button, "Змінити вибраний профіль студента");
            toolTip1.SetToolTip(Delete_button, "Видалити вибраний профіль студента");

            toolTip1.SetToolTip(openedFileName_question, "Шлях до відкритого файлу");
            toolTip1.SetToolTip(openedFileName, "Шлях до відкритого файлу");

            toolTip1.SetToolTip(Search_question, "Введіть дані для пошуку");
            toolTip1.SetToolTip(Search_button, "Введіть дані для пошуку");

            toolTip1.SetToolTip(Filter_question, "Вивести інформацію з урахуванням фільтрів");
            toolTip1.SetToolTip(Filter_button, "Вивести інформацію з урахуванням фільтрів");

            var width = dataGridView1.Size.Width / 3;
            var height = 50;
            Add_button.Size = new Size(width, height);
            Edit_button.Size = new Size(width, height);
            Delete_button.Size = new Size(width, height);

            Add_button.Location = new System.Drawing.Point(dataGridView1.Location.X, dataGridView1.Location.Y + dataGridView1.Size.Height);
            Edit_button.Location = new System.Drawing.Point(Add_button.Location.X + Add_button.Size.Width, dataGridView1.Location.Y + dataGridView1.Size.Height);
            Delete_button.Location = new System.Drawing.Point(Edit_button.Location.X + Edit_button.Size.Width, dataGridView1.Location.Y + dataGridView1.Size.Height);
            
            UpdateGrid();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try { subordinatesList.DownloadFileToList(openFileDialog1.FileName); }
            catch { MessageBox.Show("Неможливо відкрити цей файл"); return; }

            openedFileName.Text = openFileDialog1.FileName;
            сохранитьToolStripMenuItem.Enabled = true;
            UpdateGrid();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                subordinatesList.SaveListToFile(openedFileName.Text);
                MessageBox.Show("Файл збережено за адресою: " + saveFileDialog1.FileName);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ФільтруватиButton_Click(object sender, EventArgs e)
        {
            string speciality = Speciality_maskedTextBox.Text;
            int yearOfEntrrance = 0;
            if (YearOfEntrance_maskedTextBox.Text != "")
                yearOfEntrrance = Convert.ToInt32(YearOfEntrance_maskedTextBox.Text);
            int group = 0;
            if(Group_maskedTextBox.Text != "")
                group = Convert.ToInt32(Group_maskedTextBox.Text);
            string educationType = EducationType_comboBox.Text;
            string paymentType = PaymentType_comboBox.Text;
            dataGridView1.DataSource = subordinatesList.Filter(speciality, yearOfEntrrance, group, educationType, paymentType); ;
        }

        private void resetFiltersButton_Click(object sender, EventArgs e)
        {
            Speciality_maskedTextBox.Text = "";
            YearOfEntrance_maskedTextBox.Text = "";
            Group_maskedTextBox.Text = "";
            EducationType_comboBox.SelectedIndex = -1;
            EducationType_comboBox.Text = "";
            PaymentType_comboBox.SelectedIndex = -1;
            PaymentType_comboBox.Text = "";
            UpdateGrid();
        }
        public void UpdateGrid() // Очищаем таблицу и заново заполняем из списка
        {
            subordinatesList.SortList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = subordinatesList.list;
            //dataGridView2.DataSource = subordinatesList.list;
        }
        
        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dataGridView1.SelectedRows;               // Найти профиль, который 
                Profile profile = rows[0].DataBoundItem as Profile; //    Относится к выбранному ряду
                if (MessageBox.Show("Ви впевнені, що хочете видалити вибрані профілі", "Видилити", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                subordinatesList.Remove(profile);
                UpdateGrid();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Необхідно обрати один або декілька профілей");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "")
                return;
            dataGridView1.ReadOnly = false;
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1[j, i].FormattedValue.ToString().Trim().Contains(searchTextBox.Text.Trim()))
                        dataGridView1.Rows[i].Selected = true;
            dataGridView1.ReadOnly = true;
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }
            try 
            {
                subordinatesList.SaveListToFile(saveFileDialog1.FileName);
                MessageBox.Show("Файл збережено за адресою: " + saveFileDialog1.FileName);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return; }
            subordinatesList.DownloadFileToList(saveFileDialog1.FileName);
            сохранитьToolStripMenuItem.Enabled = true;
            openedFileName.Text = saveFileDialog1.FileName;
        }

        private void новийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openedFileName.Text = "";
            subordinatesList = new StudentsList();
            UpdateGrid();
            сохранитьToolStripMenuItem.Enabled = false;
        }

        private void зберегтиВибраніЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsList chosen = new StudentsList();
            var rows = dataGridView1.SelectedRows;
            if(rows.Count == 0)
            {
                MessageBox.Show("Необхідно вибрати профілі для збереження");
                return;
            }
            for (int i = 0; i < rows.Count; i++)
                chosen.Add(rows[i].DataBoundItem as Profile);
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }
            try 
            { 
                chosen.SaveListToFile(saveFileDialog1.FileName);
                MessageBox.Show("Файл збережено за адресою: " + saveFileDialog1.FileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            subordinatesList.DownloadFileToList(saveFileDialog1.FileName);
            сохранитьToolStripMenuItem.Enabled = true;
            openedFileName.Text = saveFileDialog1.FileName;
            UpdateGrid();
        }

        private void списокФІОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsList chosen = new StudentsList();
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Необхідно вибрати профілі для збереження");
                return;
            }
            for (int i = 0; i < rows.Count; i++)
                chosen.Add(rows[i].DataBoundItem as Profile);
            chosen.SortList();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }
            try 
            { 
                chosen.SaveListOfNamesAs(saveFileDialog1.FileName);
                MessageBox.Show("Звіт створено за адресою: " + saveFileDialog1.FileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void вибраніПрофіліToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsList chosen = new StudentsList();
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                MessageBox.Show("Необхідно вибрати профілі для збереження");
                return;
            }
            for (int i = 0; i < rows.Count; i++)
                chosen.Add(rows[i].DataBoundItem as Profile);
            chosen.SortList();
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }
            try 
            { 
                chosen.SaveProfilesAs(saveFileDialog1.FileName);
                MessageBox.Show("Звіт створено за адресою: " + saveFileDialog1.FileName);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { subordinatesList.SaveListToFile("Properties.Resources.last"); }
            catch { }
            var result = MessageBox.Show("Чи хочете ви зберегти введені дані?", "Закрити програму", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                if (сохранитьToolStripMenuItem.Enabled)
                {
                    try
                    {
                        subordinatesList.SaveListToFile(openedFileName.Text);
                        MessageBox.Show("Файл збережено за адресою: " + saveFileDialog1.FileName);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() != DialogResult.OK) { return; }
                    try
                    {
                        subordinatesList.SaveListToFile(saveFileDialog1.FileName);
                        MessageBox.Show("Файл збережено за адресою: " + saveFileDialog1.FileName);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); return; }
                    subordinatesList.DownloadFileToList(saveFileDialog1.FileName);
                    сохранитьToolStripMenuItem.Enabled = true;
                    openedFileName.Text = saveFileDialog1.FileName;
                }
            }
            else if (result == DialogResult.No)
                return;
            else if (result == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть дані для пошуку");
        }

        private void openedFileName_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В цьому полі записаний шлях файлу, відкритого в таблиці");
        }

        private void Filter_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Так можна вивести інформацію з урахуванням фільтрів");
        }

        private void Speciality_button_Click(object sender, EventArgs e)
        {
            Speciality_maskedTextBox.Text = "";
        }

        private void YearOfEntrance_button_Click(object sender, EventArgs e)
        {
            YearOfEntrance_maskedTextBox.Text = "";
        }

        private void Grroup_button_Click(object sender, EventArgs e)
        {
            Group_maskedTextBox.Text = "";
        }

        private void EducationType_button_Click(object sender, EventArgs e)
        {
            EducationType_comboBox.SelectedIndex = -1;
            EducationType_comboBox.Text = "";
        }

        private void PaymentType_button_Click(object sender, EventArgs e)
        {
            PaymentType_comboBox.SelectedIndex = -1;
            PaymentType_comboBox.Text = "";
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            AddSbd addSbd = new AddSbd();
            var result = addSbd.ShowDialog();
            if (result != DialogResult.OK)
                return;

            subordinatesList.Add(addSbd.Profile);
            UpdateGrid();
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dataGridView1.SelectedRows; // Найти профиль, который 
                Profile profile = rows[0].DataBoundItem as Profile; // относится к выбранному ряду
                AddSbd addSbd = new AddSbd { Profile = profile };
                var result = addSbd.ShowDialog(); // Открываем форму редактирования
                if (result != DialogResult.OK)
                    return;
                UpdateGrid();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Необхідно обрати профіль");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = dataGridView1.SelectedRows;               // Найти профиль, который 
                Profile profile = rows[0].DataBoundItem as Profile; //    Относится к выбранному ряду
                if (MessageBox.Show("Ви впевнені, що хочете видалити вибрані профілі", "Видилити", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                subordinatesList.Remove(profile);
                UpdateGrid();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Необхідно обрати один або декілька профілей");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void допомогаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }
    }
}
