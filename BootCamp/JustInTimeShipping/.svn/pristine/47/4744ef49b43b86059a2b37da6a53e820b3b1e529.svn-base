using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustInTimeShippingWeb.Models;
using JustInTimeShippingWeb.Helpers;
using JustInTimeShippingCore;

namespace JustInTimeShippingWeb.Controllers
{
    public class KioskController : Controller
    {
        //
        // GET: /Kiosk/
        private void PopulateDropDowns(CreateShippingRequestViewModel request)//, string packageType = "B", string letterType = "Plain", string deliveryType = "G")
        {
            request.PackageTypes = new List<SelectListItem>();
            request.PackageTypes.Add(new SelectListItem() { Text = "Box", Value = "B", Selected = true });
            request.PackageTypes.Add(new SelectListItem() { Text = "Letter", Value = "L", Selected = false });

            request.LetterTypes = new List<SelectListItem>();
            request.LetterTypes.Add(new SelectListItem() { Text = "Plain", Value = "Plain", Selected = true });
            request.LetterTypes.Add(new SelectListItem() { Text = "Fire Proof", Value = "Fire_Proof", Selected = false });
            request.LetterTypes.Add(new SelectListItem() { Text = "Weather Proof", Value = "Weather_Proof", Selected = false });

            request.DeliveryTypes = new List<SelectListItem>();
            request.DeliveryTypes.Add(new SelectListItem() { Text = "Air", Value = "Air", Selected = true });
            request.DeliveryTypes.Add(new SelectListItem() { Text = "Ground", Value = "Ground", Selected = false });
            request.DeliveryTypes.Add(new SelectListItem() { Text = "Rail", Value = "Rail", Selected = false });
        }

        public ActionResult Default()
        {
            return RedirectToAction("Main");
        }

        public ActionResult Main(string packageType, string deliveryType, string message = "")
        {
            var request = new CreateShippingRequestViewModel();

            PopulateDropDowns(request);//, packageType: packageType, deliveryType: deliveryType);

            // If you want to push a message to the user
            request.Message = message;

            request.Id = 0;

            // If you want to provide defaulted values
            request.IsInsured = true;
            request.Height = 0;
            request.Width = 0;
            request.Depth = 0;

            request.OName = "Name...";
            request.OStreet = "Stree...";
            request.OCity = "City...";
            request.OState = "State...";
            request.OPostalCode = "Postal Code...";

            request.DName = "Name...";
            request.DStreet = "Street...";
            request.DCity = "City...";
            request.DState = "State...";
            request.DPostalCode = "Postal Code...";

            return View(request);
        }

        public ActionResult Submit(CreateShippingRequestViewModel request, string packageType, string deliveryType)
        {
            IResult result;

            ShippingDetailInfo detail = ViewModelHelper.ConvertToShippingDetail(request);
            JustInTimeShippingFacade handler = JustInTimeShippingFacade.GetInstance();
            result = handler.Execute(detail);

            if (!result.IsSuccess)
            {
                PopulateDropDowns(request);

                request.Message = result.Message;

                return View("Main", request);
            }
            else
            {
                return View("Review", ViewModelHelper.ConvertToShippingConfirmation(detail));
            }
        }

        public ActionResult DeliveryConfirmed(ShippingConfirmation model)
        {
            // Process delivery and send the package

            return View("Confirmation", model);
        }

        public ActionResult CancelDelivery(ShippingConfirmation model)
        {
            return View();
        }
    }
}
