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
            LandAreas = new List<LandAreaItem>() {
            new LandAreaItem("Very Bad", 2),
            new LandAreaItem("Bad", 2),
            new LandAreaItem("So and so", 1),
            new LandAreaItem("Quite good", 4),
            new LandAreaItem("Fantastic", 1),
            
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

