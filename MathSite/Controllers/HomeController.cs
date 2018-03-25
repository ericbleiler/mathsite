using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MathSite.Models;
using System.Web.Mvc.Html;

namespace MathSite.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewUser()
        {
            return View();
        }
        public ActionResult CreateUser(string UserName, string Password, string Password1)
        {
           

            DBConnection DB = new DBConnection();

            DB.CreateUser(UserName, Password, Password1);
            Response.Cookies["currentUser"].Value = UserName;
            Response.Cookies["currentUser"].Expires = DateTime.Now.AddDays(.05);

            HttpCookie aCookie = new HttpCookie("lastVisit");
            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(.05);
            Response.Cookies.Add(aCookie);


            return RedirectToAction("GetUserName");
        }
        public ActionResult GetUserName(string name, string pass)
        {
            DBConnection aConnection = new DBConnection();
            string aUserName;
            aUserName = aConnection.GetUserName(name, pass);
            ViewBag.UserName = aUserName;

            Response.Cookies["currentUser"].Value = name;
            Response.Cookies["currentUser"].Expires = DateTime.Now.AddDays(.05);

            HttpCookie aCookie = new HttpCookie("lastVisit");
            aCookie.Value = DateTime.Now.ToString();
            aCookie.Expires = DateTime.Now.AddDays(.05);
            Response.Cookies.Add(aCookie);


            if (aUserName != "false") { return View(); }
            else{ return RedirectToAction("Index"); }
        }
        public ActionResult AddAddition(int num1, int num2, int user, int correct, int questionNum, string userName, int addLevel)
        {

            
                ViewBag.num1 = num1;
                ViewBag.num2 = num2;
                ViewBag.user = user;
                ViewBag.correct = correct;
                ViewBag.counter = questionNum;
                ViewBag.QuestionNumber = questionNum;
                ViewBag.UserName = userName;

            DBConnection aConnection = new DBConnection();

           

              aConnection.AddAddition(num1, num2, user, correct, questionNum, userName, addLevel);
              //ViewBag.QuestionNumber = Addition1(userName);

         string aSql = "INSERT INTO Addition(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
                aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + user + ", " + correct + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";
          
            
            ViewBag.Sql = aSql;
            
            return RedirectToAction("Addition1");
        }
        public ActionResult AddSubtraction(int num1, int num2, int user, int correct, int questionNum, string userName, int addLevel)
        {


            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.user = user;
            ViewBag.correct = correct;
            ViewBag.counter = questionNum;

            DBConnection aConnection = new DBConnection();
            aConnection.AddSubtraction(num1, num2, user, correct, questionNum, userName, addLevel);

            string aSql = "INSERT INTO Subtraction(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
            aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + user + ", " + correct + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";


            ViewBag.Sql = aSql;

            return RedirectToAction("Subtraction1");
        }
        public ActionResult AddMultiplication(int num1, int num2, int user, int correct, int questionNum, string userName, int addLevel)
        {


            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.user = user;
            ViewBag.correct = correct;
            ViewBag.counter = questionNum;

            DBConnection aConnection = new DBConnection();
            aConnection.AddMultiplication(num1, num2, user, correct, questionNum, userName, addLevel);

            string aSql = "INSERT INTO Multiplication(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
            aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + user + ", " + correct + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";


            ViewBag.Sql = aSql;

            return RedirectToAction("Multiplication1");
        }
        public ActionResult AddDivision(int num1, int num2, int user, int correct, int questionNum, string userName, int addLevel)
        {


            ViewBag.num1 = num1;
            ViewBag.num2 = num2;
            ViewBag.user = user;
            ViewBag.correct = correct;
            ViewBag.counter = questionNum;

            DBConnection aConnection = new DBConnection();
            aConnection.AddDivision(num1, num2, user, correct, questionNum, userName, addLevel);

            string aSql = "INSERT INTO Division(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
            aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + user + ", " + correct + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";


            ViewBag.Sql = aSql;

            return RedirectToAction("Division1");
        }

        public ActionResult Addition1(string user)
        {

            DBConnection aConnection = new DBConnection();
       
            ViewBag.QuestionNumber = aConnection.Addition1(user);
            ViewBag.UserName = user;

            return View();
        }
        public ActionResult Addition2()
        {
            return View();
        }
        public ActionResult Addition3()
        {
            return View();
        }
        public ActionResult Subtraction1()
        {
            return View();
        }
        public ActionResult Subtraction2()
        {
            return View();
        }
        public ActionResult Subtraction3()
        {
            return View();
        }
        public ActionResult Multiplication1()
        {
            return View();
        }
        public ActionResult Multiplication2()
        {
            return View();
        }
        public ActionResult Multiplication3()
        {
            return View();
        }
        public ActionResult Division1()
        {
            return View();
        }
        public ActionResult Division2()
        {
            return View();
        }
        public ActionResult Division3()
        {
            return View();
        }

        public ActionResult Result()
        {
            /*
            DBConnection aConnection = new DBConnection();
            List<Result> listResults = null;
            listResults = aConnection.Result();
            ViewBag.aListResults = listResults;
            */
            return View();
        }
        public ActionResult StartAdd1()
        {
          

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       
    }
}