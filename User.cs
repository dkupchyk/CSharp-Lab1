using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kupchyk01{
    class User{

        private DateTime _dateOfBirth;
        private int _age;
        private string _sighWest;
        private string _sighChina;
        private string[] _chinaSigns = { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string SighWest
        {
            get { return _sighWest; }
            set { _sighWest = value; }
        }

        public string SighChina
        {
            get { return _sighChina; }
            set { _sighChina = value; }
        }

        //public string CalcChineseHorosc()
        //{
        //    int index = Math.Abs(_dateOfBirth.Year - 1900) % 12;
        //    return _chinaSigns[index];
        //}

        //public string CalcWesternHorosc()
        //{
        //    int month = _dateOfBirth.Month;
        //    int day = _dateOfBirth.Day;

        //    switch (month)
        //    {
        //        case 01 when day >= 20:
        //        case 02 when day <= 18:
        //            _sighWest = "Aquarius";
        //            break;
        //        case 02 when day >= 19:
        //        case 03 when day <= 20:
        //            _sighWest = "Pisces";
        //            break;
        //        case 03 when day >= 21:
        //        case 04 when day <= 19:
        //            _sighWest = "Aries";
        //            break;
        //        case 04 when day >= 20:
        //        case 05 when day <= 20:
        //            _sighWest = "Taurus";
        //            break;
        //        case 05 when day >= 21:
        //        case 06 when day <= 20:
        //            _sighWest = "Gemini";
        //            break;
        //        case 06 when day >= 21:
        //        case 07 when day <= 22:
        //            _sighWest = "Cancer";
        //            break;
        //        case 07 when day >= 23:
        //        case 08 when day <= 22:
        //            _sighWest = "Leo";
        //            break;
        //        case 08 when day >= 23:
        //        case 09 when day <= 22:
        //            _sighWest = "Virgo";
        //            break;
        //        case 09 when day >= 23:
        //        case 10 when day <= 22:
        //            _sighWest = "Libra";
        //            break;
        //        case 10 when day >= 23:
        //        case 11 when day <= 21:
        //            _sighWest = "Scorpio";
        //            break;
        //        case 11 when day >= 22:
        //        case 12 when day <= 21:
        //            _sighWest = "Sagittarius";
        //            break;
        //        case 12 when day >= 22:
        //        case 01 when day <= 19:
        //            _sighWest = "Capricorn";
        //            break;
        //    }

        //    return _sighWest;
        //}

        public string CalcChineseHorosc()
        {
            string[] zodiacSigns = { "Криса", "Бик", "Тигр", "Кролик", "Дракон", "Змія", "Кінь", "Коза", "Мавпа", "Півень", "Собака", "Свиня" };

            return zodiacSigns[(_dateOfBirth.Year - 4) % 12];
        }
        public string CalcWesternHorosc()
        {
            DateTime dateToCheck = _dateOfBirth;
            string zod = "";
            string[] zodiacSigns = { "Овен", "Телець", "Близнюки", "Paк", "Лев", "Діва", "Терези", "Скорпіон", "Стрілець", "Козоріг", "Водолій", "Риби" };
            if ((dateToCheck.Month == 3 && dateToCheck.Day >= 21) || (dateToCheck.Month == 4 && dateToCheck.Day <= 20))
            {
                zod = zodiacSigns[0];
            }
            else if ((dateToCheck.Month == 4 && dateToCheck.Day >= 21) || (dateToCheck.Month == 5 && dateToCheck.Day <= 20))
            {
                zod = zodiacSigns[1];
            }
            else if ((dateToCheck.Month == 5 && dateToCheck.Day >= 21) || (dateToCheck.Month == 6 && dateToCheck.Day <= 21))
            {
                zod = zodiacSigns[2];
            }
            else if ((dateToCheck.Month == 6 && dateToCheck.Day >= 22) || (dateToCheck.Month == 7 && dateToCheck.Day <= 22))
            {
                zod = zodiacSigns[3];
            }
            else if ((dateToCheck.Month == 7 && dateToCheck.Day >= 23) || (dateToCheck.Month == 8 && dateToCheck.Day <= 23))
            {
                zod = zodiacSigns[4];
            }
            else if ((dateToCheck.Month == 8 && dateToCheck.Day >= 24) || (dateToCheck.Month == 9 && dateToCheck.Day <= 22))
            {
                zod = zodiacSigns[5];
            }
            else if ((dateToCheck.Month == 9 && dateToCheck.Day >= 23) || (dateToCheck.Month == 10 && dateToCheck.Day <= 23))
            {
                zod = zodiacSigns[6];
            }
            else if ((dateToCheck.Month == 10 && dateToCheck.Day >= 24) || (dateToCheck.Month == 11 && dateToCheck.Day <= 22))
            {
                zod = zodiacSigns[7];
            }
            else if ((dateToCheck.Month == 11 && dateToCheck.Day >= 23) || (dateToCheck.Month == 12 && dateToCheck.Day <= 21))
            {
                zod = zodiacSigns[8];
            }
            else if ((dateToCheck.Month == 12 && dateToCheck.Day >= 22) || (dateToCheck.Month == 1 && dateToCheck.Day <= 20))
            {
                zod = zodiacSigns[9];
            }
            else if ((dateToCheck.Month == 1 && dateToCheck.Day >= 21) || (dateToCheck.Month == 2 && dateToCheck.Day <= 20))
            {
                zod = zodiacSigns[10];
            }
            else if ((dateToCheck.Month == 2 && dateToCheck.Day >= 21) || (dateToCheck.Month == 3 && dateToCheck.Day <= 20))
            {
                zod = zodiacSigns[11];
            }
            return zod;
        }

    }
}
