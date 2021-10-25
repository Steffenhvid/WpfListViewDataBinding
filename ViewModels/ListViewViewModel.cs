using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WPFListViewDataBinding.Models;

namespace WPFListViewDataBinding.ViewModels
{
    public class ListViewViewModel : ObservableObject
    {
        private string colOneHeader;

        public string ColOneHeader
        {
            get => colOneHeader;
            set => SetProperty(ref colOneHeader, value);
        }


        private ObservableCollection<Person> people;

        public ObservableCollection<Person> People
        {
            get { return people; }
            set { SetProperty(ref people, value); }
        }


        private ObservableCollection<Person> selectedPeople;

        public ObservableCollection<Person> SelectedPeople
        {
            get => selectedPeople;
            set => SetProperty(ref selectedPeople, value);
        }

        public ListViewViewModel()
        {
            ColOneHeader = "First Column Name!";

            SelectedPeople = new ObservableCollection<Person>();
            SelectedPeople.Add(new Person());
            SelectedPeople.Add(new Person());

            People = new ObservableCollection<Person>();
            var Person1 = new Person { Age = 12, Name = "Carsten", NickName = "Hurrycane" };
            var Person2 = new Person { Age = 15, Name = "Henning", NickName = "BumbleBee" };

            People.Add(Person1);
            People.Add(Person2);

        }
    }
}
