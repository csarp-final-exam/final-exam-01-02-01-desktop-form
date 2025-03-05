using CommunityToolkit.Mvvm.ComponentModel;
using KretaProject.Models;
using KretaProject.Repos;
using System.Collections.ObjectModel;

namespace KretaProject.ViewModels
{
    public partial class SchoolClassViewModel : ObservableObject
    {
        private readonly SchoolClassRepo _repo;

        [ObservableProperty]
        private ObservableCollection<SchoolClass> _schoolClasses;

        public SchoolClassViewModel()
        {
            _repo = new SchoolClassRepo();
            SchoolClasses = new ObservableCollection<SchoolClass>
            { 
                new SchoolClass("9.a") { Id = 1 },
                new SchoolClass("9.b") { Id = 2 },
                new SchoolClass("10.a") { Id = 3 },
                new SchoolClass("10.b") { Id = 4 },
                new SchoolClass("11.a") { Id = 5 }
            };
        }
    }
}
