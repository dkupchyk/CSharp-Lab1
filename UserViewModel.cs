using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Kupchyk01
{
    public class UserViewModel : INotifyPropertyChanged{

        private User _user = new User();
        private RelayCommand<object> _calcAge;

        public DateTime DateOfBirth
        {
            set {
                _user.DateOfBirth = value;
                OnPropertyChanged();
            }
        }
        public int Age
        {
            get { return _user.Age; }
            set {
                _user.Age = value;
                OnPropertyChanged();
            }
        }
        public string SighWest
        {
            get { return _user.SighWest; }
            set {
                _user.SighWest = value;
                OnPropertyChanged();
            }
        }

        public string SighChina
        {
            get { return _user.SighChina; }
            set {
                _user.SighChina = value;
                OnPropertyChanged();
            }
        }

        private async void Calculate(){

            await Task.Run(() => Thread.Sleep(1000));

            if (_user.DateOfBirth.Year < DateTime.Today.Year - 135  || _user.DateOfBirth > DateTime.Today)
            {
                MessageBox.Show("Неправильно введена дата!\n Введіть ще раз.");
               
            }
            else
            {
                if (_user.DateOfBirth.Day == DateTime.Today.Day && _user.DateOfBirth.Month == DateTime.Today.Month)
                {
                    MessageBox.Show("З ДНЕМ НАРОЖЕННЯ!\n" +
                        "Дозволь тебе сьогодні привітати,\n" +
                        "Бо день такий буває раз на рік,\n" +
                        "Здоров'я, щастя щиро побажати,\n" +
                        "На все життя, на довгий - довгий вік!\n" +
                        "До сотні літ дожить без горя і журби,\n" +
                        "Від гір, від сонця, від калини\n" +
                        "Всіх благ земних – з роси й води\n" +
                        "Бажаємо тобі всі ми!");
                }
                _user.Age = (DateTime.Today - _user.DateOfBirth).Days / 365;
                _user.SighWest = _user.CalcWesternHorosc();
                _user.SighChina = _user.CalcChineseHorosc();

                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(SighWest));
                OnPropertyChanged(nameof(SighChina));
            }

        }


        public RelayCommand<object> CalcAge
        {
            get
            {
                return _calcAge ?? (_calcAge = new RelayCommand<object>(o =>
                        Calculate(), o => CanExecuteCommand()));
            }
        }

        private bool CanExecuteCommand()
        {
            return !string.IsNullOrWhiteSpace(_user.DateOfBirth.ToString());
        }


        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
