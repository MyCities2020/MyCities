using System.Collections.Generic;

namespace MyCities.Models
{
    public class Location
    {

        public int LocationId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public IEnumerable<Location> LocationList { get; set; }
        public Location(int locid, string title, string desc, double latitude, double longitude)
        {
            this.LocationId = locid;
            this.Title = title;
            this.Description = desc;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }

    public class LocationLists
    {
        public IEnumerable<Location> LocationList { get; set; }
    }

}

