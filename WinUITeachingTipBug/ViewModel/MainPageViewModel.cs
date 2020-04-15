using Prism.Mvvm;
using System.Collections.ObjectModel;
using WinUITeachingTipBug.Service;

namespace WinUITeachingTipBug.ViewModel
{
    public class TestModel : BindableBase
    {
        private string _name;

        public string Name 
        { get => _name; set => SetProperty(ref _name, value); }

        private bool _rightClickOpen;
        public bool RightClickOpen { get => _rightClickOpen; set => SetProperty(ref _rightClickOpen, value); }
    }
    public class MainPageViewModel : BindableBase
    {
        
        public MainPageViewModel()
        {
            
        }

        public DataService Service
        {
            get => DataService.Instance;
        }
    }
}
