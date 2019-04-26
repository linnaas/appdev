using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CanteenWebApplication.Models;
using System.Dynamic;
using CanteenWebApplication.DAO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace CanteenWebApplication.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Login");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult OrderDummy(Food f)
        {
            string mCon = ConfigurationManager.ConnectionStrings["ConnectionForAll"].ConnectionString;
            MySqlConnection mySqlCon = new MySqlConnection(mCon);
            string qString = "Select * from food";
            MySqlCommand mysqlCom = new MySqlCommand(qString);
            mysqlCom.Connection = mySqlCon;
            mySqlCon.Open();
            MySqlDataReader dataReader = mysqlCom.ExecuteReader();
            List<Food> foodies = new List<Food>();
            if(dataReader.HasRows)
            {
                while(dataReader.Read())
                {
                    var foodDetails = new Food();
                    
                    foodDetails.food_id = dataReader.GetInt32("food_id");
                    foodDetails.food_name = dataReader["food_name"].ToString();
                    foodDetails.enabled = (bool)dataReader["enabled"];
                    foodDetails.price = dataReader.GetInt32(dataReader.GetOrdinal("price").ToString());
                    foodDetails.image_id = dataReader.IsDBNull(4) ? 0 : dataReader.GetInt32("image_id");
                    foodDetails.description = dataReader["description"].ToString();
                    foodies.Add(foodDetails);       
                    
                }
                f.foodinfo = foodies;
                mySqlCon.Close();
                
            }
            return View("OrderDummy",f);
        }
        /*
        [HttpPost]
        public ActionResult OrderCookieW(string cookiename, string cookievalue, bool isPersistent)
        {
           // CookieOptions cookies;
            return View();
        }

        public ActionResult OrderCookieR()
        {
            return View();
        }

        CanteenDBContext c;

        public OrderController()
        {
            c = new CanteenDBContext();
            
        }

        public JsonResult SaveOrder(order_list order, food f)
        {
            c.Orders.Add(order);
            foreach (var item in f)
            {
                item.OrderId = order.order_id;
                c.f.Add(item);
            }
            c.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        */

    }
}
