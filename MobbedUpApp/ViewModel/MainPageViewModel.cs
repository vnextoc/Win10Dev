﻿using System;
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
                Items.Add(new MeetupViewModel { Title = item.name,
                    Address = $"{item.venue?.address_1}\r\n{item.venue?.city}, {item.venue?.state}",
                    StartTime = Convert.ToDouble(item.time).JavascriptDate().ToLocalTime()
                });
            }

        }

        public ObservableCollection<MeetupViewModel> Items { get; set; }

    }

    public class MeetupViewModel 
    {
        public string Title { get; set; }
        public string Address { get; set; }
        public DateTime StartTime { get; set; }
    }
}
