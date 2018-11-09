using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JustInTimeShippingWeb.Models
{
    public class ShippingConfirmation
    {
        // Calculated fields
        public double PackageWeight { get; set; }
        public double DeliveryTime { get; set; }
        public double ShippingCost { get; set; }
        public string DeliveryStatus { get; set; }

        public long Id { get; set; }

        // Selected drop down values
        [Display(Name = "Package Type:")]
        public string PackageType { get; set; }
        [Display(Name = "Letter Type:")]
        public string LetterType { get; set; }
        [Display(Name = "Delivery Type:")]
        public string DeliveryType { get; set; }

        // Input values
        public bool IsInsured { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        // Origin address
        [Display(Name="From Name:")]
        public string OName { get; set; }
        [Display(Name = "From Street:")]
        public string OStreet { get; set; }
        [Display(Name = "From City:")]
        public string OCity { get; set; }
        public string OState { get; set; }
        public string OPostalCode { get; set; }

        // Destination address
        public string DName { get; set; }
        public string DStreet { get; set; }
        public string DCity { get; set; }
        public string DState { get; set; }
        public string DPostalCode { get; set; }
    }
}