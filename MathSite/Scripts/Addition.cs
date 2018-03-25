using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathSite.Models
{ 
    public class Addition : System.Web.Services.WebService
    {
    
    private int counter = 1;
    private bool correct = false;
    private int num1, num2 = 0;
    private int[] resultArray1 = new int[10];
    private int[] resultArray2 = new int[10];
    private int[] answerArray = new int[10];
    private int[] yourAnswerArray = new int[10];


        [WebMethod(EnableSession = true)]
        public static void Done(string ids)
        {
            String a = ids;

            // Do whatever processing you want
        }
    }
}

