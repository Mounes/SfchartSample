using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
namespace syncFuctionApp_Charts
{
    public class ViewModel
    {
        
        public List<DataModel> dataBar1 { get; set; }
        public List<DataModel> dataBar2 { get; set; }

        public ViewModel()
        {
            dataBar1 = new List<DataModel>()
            {
                new DataModel("Books",133),
                new DataModel("Movies",420),
                new DataModel("Music",500),
                new DataModel("Games",312)
            };
            dataBar2 = new List<DataModel>()
            {
                new DataModel("Books",10),
                new DataModel("Movies",20),
                new DataModel("Music",70),
                new DataModel("Games",120)
            };
        }

        public class DataModel
        {
            public string Category { get; set; }
            public double Sales { get; set; }
            public DataModel(string category , double sales)
            {
                Category = category;
                Sales = sales;
            }
        }
    }
}
