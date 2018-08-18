using System;

namespace Class
{
    public class order
    {
        public int ordernum { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Brand { get; set; }
        public String Contacts { get; set; }
        public int Quantity { get; set; }
        public String DateEntered { get; set; }
        public String DateOrdered { get; set; }
        public String DateRecieved { get; set; }

    }

    public class brand
    {
        public String ManufacName { get; set; }

    }

    public class contactsinfo
    {
        public String Name { get; set; }
        public float BaseCurve { get; set; }
        public float Diameter { get; set; }

    }
}
