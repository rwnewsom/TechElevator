using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_Web_Services_GET_lecture
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stars { get; set; }
        public int RoomsAvailable { get; set; }
        public int CostPerNight { get; set; }
    }
}
