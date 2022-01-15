using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursach
{
    public class Profile
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Sex { get; set; }

        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Passport { get; set; }
        public string Parent { get; set; }

        public string Speciality { get; set; }
        public int YearOfEntrance { get; set; }
        public int Group { get; set; }

        public string EducationType { get; set; } //Форма обучения (очная/заочная/ускореная)
        public string PaymentType { get; set; }
        public static bool Validate(string field)
        {
            foreach (var i in field)
                if (!(char.IsLetter(i)))
                    return false;
            return true;
        }
    }
}
