using System;
using System.Collections.Generic;

namespace Class
{
    public class order
    {
        public int ordernum { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public int Dob { get; set; }
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
    public static class contactsList
    {
        public static List<contactsinfo> cList = new List<contactsinfo>();

    }

    public static class brandList
    {
        public static List<brand> bList = new List<brand>();
    }
    

    public class contactsinfo:brand
    {
        public String Name { get; set; }
        public float BaseCurve { get; set; }
        public float Diameter { get; set; }

    }
}
