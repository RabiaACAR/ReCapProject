using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Eklendi";
        public static string ProductNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar listelendi";

        public static string CustomerAdded = "Müşteri EKlendi.";

        public static string CustomerDeleted { get; internal set; }
        public static object CustomerListed { get; internal set; }
        public static string CustomerUpdated { get; internal set; }
        public static string RentalInvalid { get; internal set; }
        public static string RentalAdded { get; internal set; }
        public static string RentalDeleted { get; internal set; }
        public static string RentalListed { get; internal set; }
        public static string RentalUpdated { get; internal set; }
    }
}
