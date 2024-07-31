using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeEx //not DateTime cause, class can't have same name
{
    class Program
    {
        static void Main(string[] args)
        {
            //WHY ISN'T IT (namespace DateTime) WORKING?????????????????? 
            //Ans: if namespace name is same as varibale, object, name, object, or classname, it'll show error
            //Date Time datatype
            var date = new DateTime(); // creates a new object/instance of a DateTime object and assigns it to a variable named new date.
            Console.WriteLine(date);
            
            var myDate = new DateTime(2015, 6, 1); // assigned date time value
            Console.WriteLine(myDate); // assigned date and time
            
            DateTime newDate = new DateTime(); //default date time value in the new object
            Console.WriteLine(newDate); //default date and time of the system

            DateTime DateAssigned = new DateTime(2000, 12, 4); //assigned date time value in the new object
            Console.WriteLine(DateAssigned);

            DateTime toDay = DateTime.Today; //declaring DateTime instance representing the today's date
            Console.WriteLine(toDay);

            DateTime nowDay = DateTime.Now; //declaring DateTime instance representing the current date and time
            Console.WriteLine(nowDay);
            Console.WriteLine(nowDay.ToShortDateString()); // ToShortDateString() method to only show date
            Console.WriteLine(nowDay.ToShortTimeString()); // ToShortTimeString() method to only show time
            Console.WriteLine(nowDay.ToLongDateString()); // ToLongDateString() method to show detailed date
            Console.WriteLine(nowDay.ToLongTimeString()); // ToLongTimeString() method to show detailed time
            Console.WriteLine(nowDay.AddDays(5)); // to show 5 din por er date and time
            Console.WriteLine(nowDay.AddDays(-5)); // to show 5 din ager date and time
            Console.WriteLine(nowDay.AddYears(4)); // to show 4 years porer date and time
            Console.WriteLine(nowDay.AddSeconds(600000)); // to show date and time after 600000 seconds
            Console.WriteLine(nowDay.AddMonths(2));
            //weird format practice yyyy year dddd day MMM month mmm  HH hour mm minute ss second tt am/pm 
            DateTime onlydate = DateTime.Now;
            string FormattedDate = string.Format("Year is {0:yyyy}", onlydate); // this format will only show date as placeholder patter = {0:yyyy} javascripts works with this expressions
            Console.WriteLine(FormattedDate);

            string formatedatetime = string.Format("Year and month is {0: yyyy MM}", onlydate); // shows year and month only captisl M works to get this format
            Console.WriteLine(formatedatetime);

            // yyyy M d teo hobe but leading zero thakbe nah (emon hobe 2022 2 3) not emon (2022 02 03)
            string formatyearmonthdate = string.Format("Year month and date is {0:yyyy MM dd}", onlydate);// only small d works not CAPITAL D
            Console.WriteLine(formatyearmonthdate);

            string formatmonthname = string.Format("date with month week short name {0: yyyy MMM ddd}", onlydate); // 3 ta MMM and ddd dile month week day short name ashbe
            Console.WriteLine(formatmonthname);

            string formatweekname = string.Format("date with month name and weekday name {0: yyyy MMMM dddd}", onlydate); // 4 ta MMMM and dddd dile month and weekly day full name ashbe
            Console.WriteLine(formatweekname);
            // HH hour mm minute ss second tt AM/PM
            string fulldatetime = string.Format("Full date and time {0:yyyy MMMM dddd HH mm ss tt}", onlydate); // the placeholder expression is case sensitive
            Console.WriteLine(fulldatetime);

            string formatethod = string.Format("{0:yyyy dddd MMM}", onlydate);
            Console.WriteLine(formatethod);
        }
    }
}
