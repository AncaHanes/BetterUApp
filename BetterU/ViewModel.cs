using BetterU.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterU
{
    class ViewModel
    {
        public IReadOnlyList<WellbeingItem> WellbeingAreas { get; }
       
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

            WellbeingAreas = new List<WellbeingItem>() { 
            new WellbeingItem("Very Bad", count1),
            new WellbeingItem("Bad", count2),
            new WellbeingItem("So and so", count3),
            new WellbeingItem("Quite good", count4),
            new WellbeingItem("Fantastic", count5),
            
        };
        }
    }

    class WellbeingItem
    {
        public string Name { get; }
        public double Area { get; }

        public WellbeingItem(string name, double area)
        {
            this.Name = name;
            this.Area = area;
        }
    }
}

