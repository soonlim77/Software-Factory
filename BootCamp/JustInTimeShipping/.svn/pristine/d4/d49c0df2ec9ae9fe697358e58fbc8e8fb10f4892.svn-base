using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace JustInTimeShippingWeb.Models
{
    public class CreateShippingRequestViewModel
    {
        // User feedback
        public string Message { get; set; }

        // Values for drop downs
        public List<SelectListItem> PackageTypes { get; set; }
        public List<SelectListItem> LetterTypes { get; set; }
        public List<SelectListItem> DeliveryTypes { get; set; }

        public long Id { get; set; }

        // Drop down selections
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
        public string OName { get; set; }
        public string OStreet { get; set; }
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