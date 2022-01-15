using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach
{
    class StudentsList
    {
        public List<Profile> list;
        public int Count { get { return list.Count; } }
        public StudentsList()
        {
            list = new List<Profile>();
        }
        public Profile this[int ind]
        {
            get { return list[ind]; }
            set { list[ind] = value; }
        }
        public void Add(Profile value) { list.Add(value); }
        public void Remove(Profile value) { list.Remove(value); }
        public void DownloadFileToList(string file)
        {
            string[] strings = File.ReadAllLines(file);
            list = new List<Profile>();
            for (int i = 0; i < strings.Length; i++)
            {
                Profile Profile = new Profile();
                string[] str = strings[i].Split(';');

                Profile.LastName = str[0];
                Profile.FirstName = str[1];
                Profile.SecondName = str[2];
                Profile.Sex = str[3];

                Profile.BirthDate = DateTime.Parse(str[4]);
                Profile.Address = str[5];
                Profile.PhoneNumber = str[6];
                Profile.Passport = Convert.ToInt32(str[7]);
                Profile.Parent = str[8];

                Profile.Speciality = str[9];
                Profile.YearOfEntrance = Convert.ToInt32(str[10]);
                Profile.Group = Convert.ToInt32(str[11]);

                Profile.EducationType = str[12];
                Profile.PaymentType = str[13];

                list.Add(Profile);
            }
        }
        public void SaveListToFile(string file)
        {
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < list.Count; i++)
            {
                string str = "";
                str += list[i].LastName + ";";
                str += list[i].FirstName + ";";
                str += list[i].SecondName + ";";
                str += list[i].Sex + ";";

                str += list[i].BirthDate + ";";
                str += list[i].Address + ";";
                str += list[i].PhoneNumber + ";";
                str += list[i].Passport + ";";
                str += list[i].Parent + ";";

                str += list[i].Speciality + ";";
                str += list[i].YearOfEntrance + ";";
                str += list[i].Group + ";";

                str += list[i].EducationType + ";";
                str += list[i].PaymentType + ";";
                writer.WriteLine(str);
            }
            writer.Close();
        }
        public List<Profile> Filter(string speciality, int yearOfEntrance, int group, string educationType, string paymentType)
        {
            List<Profile> fList = new List<Profile>();
            for (int i = 0; i < list.Count; i++)
            {
                if (speciality != "")
                    if (speciality.ToLower() != list[i].Speciality.ToLower())
                        continue;
                if (yearOfEntrance != 0)
                    if (yearOfEntrance != list[i].YearOfEntrance)
                        continue;
                if (group != 0)
                    if (group != list[i].Group)
                        continue;
                
                if (educationType != "")
                    if (educationType.ToLower() != list[i].EducationType.ToLower())
                        continue;
                if (paymentType != "")
                    if (paymentType.ToLower() != list[i].PaymentType.ToLower())
                        continue;
                fList.Add(list[i]);
            }
            return fList;
        }
        public void SortList()
        {
            for (int i = 0; i < list.Count; i++)
                for (int j = 0; j < list.Count-i-1; j++)
                    if (list[j].LastName.CompareTo(list[j+1].LastName) > 0)
                    {
                        Profile glass = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = glass;
                    }
        }
        
        public void SaveListOfNamesAs(string file)
        {
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < list.Count; i++)
            {
                string str = "";
                str += list[i].LastName + " ";
                str += list[i].FirstName + " ";
                str += list[i].SecondName + " ";
                writer.WriteLine(str);
            }
            writer.Close();
        }
        public void SaveProfilesAs(string file)
        {
            StreamWriter writer = new StreamWriter(file);
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine("ПІБ: " + list[i].LastName + " " + list[i].FirstName + " " + list[i].SecondName);
                writer.WriteLine("Стать: " + list[i].Sex);
                writer.WriteLine("Дата народження: " + list[i].BirthDate.ToShortDateString());
                writer.WriteLine("Домашня адреса: " + list[i].Address);
                writer.WriteLine("Телефон" + list[i].PhoneNumber);
                writer.WriteLine("Паспорт серія №: " + list[i].Passport);
                writer.WriteLine("Довірений родич/опікун: " + list[i].Parent);
                writer.WriteLine($"Група: {list[i].Speciality}-{Convert.ToString(list[i].YearOfEntrance).Substring(2)}-{list[i].Group}");
                writer.WriteLine("Форма навчання: " + list[i].EducationType);
                writer.WriteLine("Форма оплати: " + list[i].PaymentType);
                
                writer.WriteLine();
            }
            writer.Close();
        }
    }
}
