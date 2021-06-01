using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_Widget
{
    [Serializable]
    public class Eqipment
    {
        
        public string EqipType { get; private set; }
        public string EqipName { get; private set; }
        public string EqipInfo { get; private set; }
        public bool WeekInsp { get; private set; }
        public bool MonthInsp { get; private set; }
        public DateTime LastWeekInsp { get; private set; }
        public DateTime LastMonthInsp { get; private set; }
        public string WhoDidInsp { get; private set; }


        public Eqipment()
        {

        }
        public Eqipment(string eqipType, string eqipName,bool weekInsp = true,bool monthInsp = true)
        {
            EqipType = eqipType;
            EqipName = eqipName;
            EqipInfo = "Інформація відсутня";
            WeekInsp = weekInsp;
            MonthInsp = monthInsp;
            LastWeekInsp = new DateTime();
            LastMonthInsp = new DateTime();
            WhoDidInsp = "Інформація відсутня";

        }




    }
}
