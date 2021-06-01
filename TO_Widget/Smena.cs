using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_Widget
{
    [Serializable]
    public class Smena
    {
        public string LabelChange { get; private set; }
        public DateTime DurationChange { get; private set; }
        public int AmountChange { get; private set; }
        public DateTime BeginChange { get; set; }


        public Smena()
        {

        }
        public Smena(string labelChange, int amountChange, int durationHour,int durationMin, int beginHour, int beginMin)
        {
            DurationChange = new DateTime(0000, 01, 01, durationHour, durationMin, 00);
            LabelChange = labelChange;
            AmountChange = amountChange;
            BeginChange = new DateTime(0000,01,01,beginHour, beginMin,00);
        }


        public DateTime WhenEndChange()
        {
            TimeSpan endChange;
            
            DateTime actualTime = DateTime.Now;

            DateTime beginChange = new DateTime(actualTime.Year, actualTime.Month, actualTime.Day, BeginChange.Hour, BeginChange.Minute, 00);

            

            do
            {
                endChange = beginChange.AddMinutes(510) - actualTime;

            } while (endChange.Minutes>510 );



            


            return endChange;
        }



    }
}
