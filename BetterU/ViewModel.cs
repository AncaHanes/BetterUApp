using BetterU.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterU
{
    class ViewModel
    {
        public IReadOnlyList<LandAreaItem> LandAreas { get; }
       
        public ViewModel()
        {
            var vb= App.Database.GetCountVBAsync();
            var count1 = vb.Result.Count;

            vb = App.Database.GetCountBAsync();
            var count2 = vb.Result.Count;

            vb = App.Database.GetCountSSAsync();
            var count3 = vb.Result.Count;

            vb = App.Database.GetCountQGAsync();
            var count4 = vb.Result.Count;

            vb = App.Database.GetCountFAsync();
            var count5 = vb.Result.Count;

            LandAreas = new List<LandAreaItem>() { 
            new LandAreaItem("Very Bad", count1),
            new LandAreaItem("Bad", count2),
            new LandAreaItem("So and so", count3),
            new LandAreaItem("Quite good", count4),
            new LandAreaItem("Fantastic", count5),
            
        };
        }
    }

    class LandAreaItem
    {
        public string CountryName { get; }
        public double Area { get; }

        public LandAreaItem(string countryName, double area)
        {
            this.CountryName = countryName;
            this.Area = area;
        }
    }
}

