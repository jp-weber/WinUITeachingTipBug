using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUITeachingTipBug.ViewModel;

namespace WinUITeachingTipBug.Service
{
    public class DataService
    {
        [ThreadStatic]
        private static DataService _instance;
        public ObservableCollection<TestModel> Collection;

        public static DataService Instance => _instance ?? (_instance = new DataService());

        public DataService()
        {
            Collection = new ObservableCollection<TestModel>();
            Collection.Add(new TestModel() { Name = "TestA" });
            Collection.Add(new TestModel() { Name = "TestB" });
            Collection.Add(new TestModel() { Name = "TestC" });
            Collection.Add(new TestModel() { Name = "TestD" });
            Collection.Add(new TestModel() { Name = "TestE" });
            Collection.Add(new TestModel() { Name = "TestF" });
            Collection.Add(new TestModel() { Name = "TestG" });
        }
    }
}
