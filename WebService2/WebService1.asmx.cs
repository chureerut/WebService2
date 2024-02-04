using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string firstname, string lastname)
        {
            return string.Format("Hello World {0} {1}", firstname, lastname);
        }

        [WebMethod]
        public string Calculator(int firstvalue, int secondvalue, string operation)
        {
            float result = 0;
            switch (operation)
            {
                case "+":
                    result = firstvalue + secondvalue;
                    break;
                case "-":
                    result = firstvalue - secondvalue;
                    break;
                case "*":
                    result = firstvalue * secondvalue;
                    break;
                case "/":
                    result = firstvalue / secondvalue;
                    break;

            }

            return result.ToString();
        }
        [WebMethod]
        public Product[] Products(string gender)
        {
            List<Product> all = new List<Product>();

            Product prdList1 = new Product();
            prdList1.Name = "chureerut";
            prdList1.LastName = "dachpala";
            prdList1.Gender = "Female";
            all.Add(prdList1);

            Product prdList2 = new Product();
            prdList2.Name = "chureerut2";
            prdList2.LastName = "dachpala2";
            prdList2.Gender = "Male";
            all.Add(prdList2);

            Product prdList3 = new Product();
            prdList3.Name = "chureerut3";
            prdList3.LastName = "dachpala3";
            prdList3.Gender = "Female";
            all.Add(prdList3);

            return all.Where(prd => prd.Gender == gender).ToArray();
        }
    }
}
