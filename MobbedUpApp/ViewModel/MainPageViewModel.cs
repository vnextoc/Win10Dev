using System.Collections.ObjectModel;

namespace MobbedUpApp.ViewModel 
{
    public class MainPageViewModel 
    {
        public MainPageViewModel() 
        {
            Items = new ObservableCollection<MeetupViewModel>();
            var data = new DAL.SampleRepository();
            var results = data.GetResults;
            foreach( var item in results ) {
                Items.Add(new MeetupViewModel { Title = item.name});
            }

        }

        public ObservableCollection<MeetupViewModel> Items { get; set; }

    }

    public class MeetupViewModel 
    {
        public string Title { get; set; }

    }
}
