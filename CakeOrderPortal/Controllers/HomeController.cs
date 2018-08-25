using CakeOrderPortal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;



namespace CakeOrderPortal.Controllers
{
    public class HomeController : Controller
    {
        private CakeDeliveryModel db = new CakeDeliveryModel();
        public ActionResult Index()
        {
            return View();
        }



        //GET:Home/Order_Cake
        public ActionResult Order_Cake()
        {
            ViewBag.Message = "Cake Order Page.";
            CakeOrderDetail cakeOrderInformation = new CakeOrderDetail();

            //Get All Countries
            var countries = GetCountries();
            cakeOrderInformation.countries = GetSelectListItems(countries);
            return View(cakeOrderInformation);
        }


        // POST: CakeOrderInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Order_Cake([Bind(Include = "LastName,CakeName,CakeType,Weight,DeliveryDate,DeliveryTime,FirstName,StreetNumber,Address,City,Province,Country,PostalCode")] CakeOrderDetail cakeOrderInformation)
        {

            if (ModelState.IsValid)
            {
                db.CakeOrderDetails.Add(cakeOrderInformation);
                MultipleView multipleView = new MultipleView();
               //db.SaveChanges();
                //ViewBag.OrderId = cakeOrderInformation.OrderId;
                return RedirectToAction("Payment", cakeOrderInformation);

            }
            var countries = GetCountries();
            cakeOrderInformation.countries = GetSelectListItems(countries);

            return View(cakeOrderInformation);

        }

        //GET:Home/Payment
        public ActionResult Payment(CakeOrderDetail cakeOrderInformation)
        {
            ViewBag.Message = "Payment Page.";
            MultipleView multipleView = new MultipleView();
            multipleView.Address = cakeOrderInformation.Address;
            multipleView.CakeName = cakeOrderInformation.CakeName;
            multipleView.CakeType = cakeOrderInformation.CakeType;
            multipleView.City = cakeOrderInformation.City;
            multipleView.Country = cakeOrderInformation.Country;
            multipleView.DeliveryDate = cakeOrderInformation.DeliveryDate;
            multipleView.DeliveryTime = cakeOrderInformation.DeliveryTime;
            multipleView.FirstName = cakeOrderInformation.FirstName;
            multipleView.LastName = cakeOrderInformation.LastName;
            multipleView.PostalCode = cakeOrderInformation.PostalCode;
            multipleView.Province = cakeOrderInformation.Province;
            multipleView.StreetNumber = cakeOrderInformation.StreetNumber;
            multipleView.Weight = cakeOrderInformation.Weight;
            return View(multipleView);
        }


        // POST: PaymentInformations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Payment([Bind(Include = "EmailAddress,CreditCardType,PhoneNumber,Name,CreditCardNumber,ExpirationDate")] PaymentInformation paymentInformation , CakeOrderDetail cakeOrderInformation)
        {
            if (ModelState.IsValid)
            {
                db.PaymentInformations.Add(paymentInformation);
                db.CakeOrderDetails.Add(cakeOrderInformation);
                db.SaveChanges();
            }
            return RedirectToAction("Success", paymentInformation);
        }

        // GET: CakeDeliveryDetails/Edit/5
        public ActionResult Edit(MultipleView multipleView)
        {
            if (multipleView == null)
            {
                return HttpNotFound();
            }
            CakeOrderDetail cakeOrderInformation = new CakeOrderDetail();
            cakeOrderInformation.Address = multipleView.Address;
            cakeOrderInformation.CakeName = multipleView.CakeName;
            cakeOrderInformation.CakeType = multipleView.CakeType;
            cakeOrderInformation.City = multipleView.City;
            cakeOrderInformation.Country= multipleView.Country;
            cakeOrderInformation.DeliveryDate = multipleView.DeliveryDate;
            cakeOrderInformation.DeliveryTime = multipleView.DeliveryTime;
            cakeOrderInformation.FirstName = multipleView.FirstName;
            cakeOrderInformation.LastName = multipleView.LastName;
            cakeOrderInformation.PostalCode = multipleView.PostalCode;
            cakeOrderInformation.Province = multipleView.Province;
            cakeOrderInformation.StreetNumber = multipleView.StreetNumber;
            cakeOrderInformation.Weight = multipleView.Weight;
            var countries = GetCountries();
            cakeOrderInformation.countries = GetSelectListItems(countries);
            return View(cakeOrderInformation);
        }

        // POST: CakeDeliveryDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LastName,CakeName,CakeType,Weight,DeliveryDate,DeliveryTime,FirstName,StreetNumber,Address,City,Province,Country,PostalCode")] CakeOrderDetail cakeOrderInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cakeOrderInformation).State = EntityState.Modified;
                return RedirectToAction("Payment", cakeOrderInformation);
            }
            var countries = GetCountries();
            cakeOrderInformation.countries = GetSelectListItems(countries);
            return View(cakeOrderInformation);
        }

        public ActionResult Success(PaymentInformation paymentInformation)
        {
            if(paymentInformation.Name == null)
                {
                return HttpNotFound();
                }

            return View(paymentInformation);
        }

        // GET: CakeOrderDetails/Details/5
        public ActionResult Details(MultipleView multipleView)
        {
            if (multipleView == null)
            {
                return HttpNotFound();
            }
            return View(multipleView);
        }


        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private IEnumerable<string> GetCountries()
        {
            return new List<string>
            {
                "Canada",
                "US"
            }
            ;
        }

        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }
            return selectList;
        }

    }
}




