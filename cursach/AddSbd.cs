using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cursach
{
    public partial class AddSbd : Form
    {
        public Profile Profile;
        public AddSbd()
        {
            InitializeComponent();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            Profile = Profile ?? new Profile();
            string exStr = "";

            if (LastName_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Прізвище' має містити мінімум 2 літери \n";
            else
                Profile.LastName = LastName_maskedTextBox.Text;

            if (FirstName_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Ім'я' має містити мінімум 2 літери \n";
            else
                Profile.FirstName = FirstName_maskedTextBox.Text;

            if (SecondName_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Побатькові' має містити мінімум 2 літери \n";
            else
                Profile.SecondName = SecondName_maskedTextBox.Text;

            if (Sex_comboBox.Text == "")
                exStr += "Поле 'Стать' має бути заповнено \n";
            else
                Profile.Sex = Sex_comboBox.Text;

            if (BirthDate_date.Value >= DateTime.Now)
                exStr += "Поле 'Дата народження' має містити дату, меншу за сьогоднішню \n";
            else
                Profile.BirthDate = BirthDate_date.MinDate;

            if (Address_textBox.Text == "")
                exStr += "Поле 'Домашня адреса' має бути заповнено \n";
            else
                Profile.Address = Address_textBox.Text;

            if (PhoneNumber_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Телефонний номер' має бути заповнено \n";
            else
                Profile.PhoneNumber = PhoneNumber_maskedTextBox.Text;

            if (Passport_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Паспорт серія №' має бути заповнено \n";
            else
                Profile.Passport = Convert.ToInt32(Passport_maskedTextBox.Text);

            Profile.Parent = Parent_textBox.Text;

            if (Speciality_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Спеціальність' має містити мінімум 2 літери \n";
            else
                Profile.Speciality = Speciality_maskedTextBox.Text;

            if (YearOfEntrance_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Рік вступу' має бути заповнено \n";
            else
            {
                Profile.YearOfEntrance = Convert.ToInt32(YearOfEntrance_maskedTextBox.Text);
                if (Profile.YearOfEntrance > DateTime.Now.Year)
                    exStr += "Поле 'Рік вступу' не може містити рік із майбутнього \n";
            }

            if (Group_maskedTextBox.MaskCompleted == false)
                exStr += "Поле 'Група' має бути заповнено \n";
            else
                try { Profile.Group = Convert.ToInt32(Group_maskedTextBox.Text); }
                catch { exStr += "Поле 'Група' має бути заповнено тільки числами \n"; }

            if (EducationType_comboBox.Text == "")
                exStr += "Поле 'Форма навчання' має бути заповнено \n";
            else
                Profile.EducationType = EducationType_comboBox.Text;

            if (PaymentType_comboBox.Text == "")
                exStr += "Поле 'Форма оплати' має бути заповнено \n";
            else
                Profile.PaymentType = PaymentType_comboBox.Text;

            if(exStr != "")
            {
                MessageBox.Show(exStr, "Введена інформація містить помилки");
                DialogResult = DialogResult.None;
            }
        }
        private void AddSbd_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            
            toolTip1.SetToolTip(Accept_button, "Зберегти зміни до таблиці");
            toolTip1.SetToolTip(Return_button, "Повернутися на головну форму, введені дані будуть видалені");
            toolTip1.SetToolTip(FillInstruction_label, "Введіть дані в поля, поля із '*' мають бути заповнені обов'язково");
            
            toolTip1.SetToolTip(LastName_maskedTextBox, "Введіть прізвище студента");
            toolTip1.SetToolTip(LastName_question, "Введіть прізвище студента");

            toolTip1.SetToolTip(FirstName_maskedTextBox, "Введіть ім'я студента");
            toolTip1.SetToolTip(FirstName_question, "Введіть ім'я студента");

            toolTip1.SetToolTip(SecondName_maskedTextBox, "Введіть побатькові студента");
            toolTip1.SetToolTip(SecondName_question, "Введіть побатькові студента");

            toolTip1.SetToolTip(Sex_comboBox, "Виберіть стать студента");
            toolTip1.SetToolTip(Sex_question, "Виберіть стать студента");

            toolTip1.SetToolTip(BirthDate_date, "Введіть дату народження студента");
            toolTip1.SetToolTip(BirthDate_question, "Введіть дату народження студента");

            toolTip1.SetToolTip(Address_textBox, "Введіть адресу студента");
            toolTip1.SetToolTip(Address_question, "Введіть адресу студента");

            toolTip1.SetToolTip(PhoneNumber_maskedTextBox, "Введіть телефонний номер студента");
            toolTip1.SetToolTip(PhoneNumber_question, "Введіть телефонний номер студента");

            toolTip1.SetToolTip(Passport_maskedTextBox, "Введіть серію паспорту студента");
            toolTip1.SetToolTip(Passport_question, "Введіть серію паспорту студента");

            toolTip1.SetToolTip(Parent_textBox, "Введіть інформацію про людину, що має батьківські права/опікунство студента");
            toolTip1.SetToolTip(Parent_question, "Введіть інформацію про людину, що має батьківські права/опікунство студента");

            toolTip1.SetToolTip(Speciality_maskedTextBox, "Введіть назву спеціальності студента");
            toolTip1.SetToolTip(Speciality_question, "Введіть назву спеціальності студента");

            toolTip1.SetToolTip(YearOfEntrance_maskedTextBox, "Введіть рік вступу студента до університету");
            toolTip1.SetToolTip(YearOfEntrance_question, "Введіть рік вступу студента до університету");

            toolTip1.SetToolTip(Group_maskedTextBox, "Введіть номер групи студента");
            toolTip1.SetToolTip(Group_question, "Введіть номер групи студента");

            toolTip1.SetToolTip(EducationType_comboBox, "Виберіть форму навчання студента");
            toolTip1.SetToolTip(EducationType_question, "Виберіть форму навчання студента");

            toolTip1.SetToolTip(PaymentType_comboBox, "Виберіть тип оплати навчання студента");
            toolTip1.SetToolTip(Payment_question, "Виберіть тип оплати навчання студента");

            if (Profile == null)
            {
                YearOfEntrance_maskedTextBox.Text = DateTime.Now.Year.ToString();
                return;
            }
            try
            {
                LastName_maskedTextBox.Text = Profile.LastName;
                FirstName_maskedTextBox.Text = Profile.FirstName;
                SecondName_maskedTextBox.Text = Profile.SecondName;
                Sex_comboBox.Text = Profile.Sex;

                BirthDate_date.Value = Profile.BirthDate;
                Address_textBox.Text = Profile.Address;
                PhoneNumber_maskedTextBox.Text = Profile.PhoneNumber;
                Passport_maskedTextBox.Text = Convert.ToString(Profile.Passport);
                Parent_textBox.Text = Profile.Parent;

                SecondName_maskedTextBox.Text = Profile.Speciality;
                YearOfEntrance_maskedTextBox.Text = Profile.YearOfEntrance.ToString();
                Group_maskedTextBox.Text = Profile.Group.ToString();

                EducationType_comboBox.Text = Profile.EducationType;
                PaymentType_comboBox.Text = Profile.PaymentType;

            }
            catch
            {
                MessageBox.Show("Щось не так з вхідними данними");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені, що хочете повернутися? Введені дані будуть втрачені!", "Назад", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return;
            else
                DialogResult = DialogResult.None;
        }

        private void secondName_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть прізвище студента");
        }

        private void FirstName_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть ім'я студента");
        }

        private void LastName_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть побатькові студента");
        }

        private void Sex_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виберіть стать студента");
        }

        private void BirthDate_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть дату народження студента");
        }

        private void Address_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть адресу студента");
        }

        private void PhoneNumber_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть телефонний номер студента");
        }

        private void Passport_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть серію паспорту студента");
        }

        private void Parent_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть інформацію про людину, що має батьківські права/опікунство студента");
        }

        private void Speciality_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ведіть назву спеціальності студента");
        }

        private void YearOfEntrance_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть рік вступу студента до університету");
        }

        private void Group_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Введіть номер групи студента");
        }

        private void EducationType_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виберіть форму навчання студента");
        }

        private void Payment_question_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виберіть тип оплати навчання студента");
        }
    }
}
