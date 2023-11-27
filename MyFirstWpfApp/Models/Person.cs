using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWpfApp.Models
{
    /*
        ObservableObject 추상클래스 상속
        ObservableObject 클래스는 위에 Nuget 패키지로 설치한 CommunityToolkit.Mvvm 라이브러리
        속한 추상 클래스이며 INotifyPropertyChanged와 INotifyPropertyChanging이라는 인터페이스를 상속
        즉, ObervableObject 상속을 통해 Model에 선언된 변수들의 변화를 체크할 수 있다. 
     */
    internal class Person : ObservableObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            { SetProperty(ref _id, value);}
        }

        private string? _name;
        public string? Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value);}
        }

        private bool _gender;
        public bool Gender
        {
            get { return _gender; }
            set { SetProperty(ref _gender, value);}
        }
    }
}
