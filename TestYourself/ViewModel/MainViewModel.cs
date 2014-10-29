using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestYourself.Annotations;
using TestYourself.Model;

namespace TestYourself.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<StudentModel> _students;
        private StudentModel _currentStudent;

        public MainViewModel()
        {
            _students = new ObservableCollection<StudentModel>();

            StudentModel s1 = new StudentModel();
            s1.FirstName = "Monica";
            s1.LastName = "Riera";
            s1.Cpr = 123456;
            s1.Education = "Computer Science";
            _students.Add(s1);

            StudentModel s2 = new StudentModel();
            s2.FirstName = "Banu";
            s2.LastName = "Tuncer";
            s2.Cpr = 654321;
            s2.Education = "Computer Science";
            _students.Add(s2);

            StudentModel s3 = new StudentModel();
            s3.FirstName = "Kathleen";
            s3.LastName = "Vam Ramselaar";
            s3.Cpr = 112233;
            s3.Education = "Marketing";
            _students.Add(s3);
        }

        public ObservableCollection<StudentModel> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        public StudentModel CurrentStudent
        {
            get { return _currentStudent; }
            set
            {
                _currentStudent = value;
                OnPropertyChanged("CurrentStudent");
            }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
