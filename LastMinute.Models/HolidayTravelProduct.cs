using System;
using System.Collections.Generic;

public class HolidayTravelProduct
{
    public int  Id { get; set; }

    public string BusinessKey{ get; set; } 

    public IList<string> ImagesUrls { get; set; }

    public string DepartureAirport { get; set; }

    public DateTime DepartureDate { get; set; }

    public DateTime ReturnDate { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Schedule { get; set; }

    

}