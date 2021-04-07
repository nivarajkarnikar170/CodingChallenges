using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class AgreeyaCodility
    {
        public static int solution(int Y, string A, string B, string W) 
        {
            if (Y <= 0 || String.IsNullOrEmpty(A) || String.IsNullOrEmpty(B) || String.IsNullOrEmpty(W))
                return 0;

            var startDayInMonth = (int)Enum.Parse(typeof(days), W);
            var endDayInMonth = 0;

            var monthStrtEnd = new List<(int month, int days, int start, int end)>();

            for (int i = 1; i <= 12; i++)
            {
                int daysInMonth = i % 2 != 0 ? 31 : 30;
                if (i == 2)
                    daysInMonth = Y % 4 == 0 ? 29 : 28;

                switch (daysInMonth) 
                {
                    case 28:
                        endDayInMonth = startDayInMonth == 1 ? 7 : startDayInMonth - 1;
                        break;
                    case 29:
                        endDayInMonth = startDayInMonth;
                        break;
                    case 30:
                        endDayInMonth = startDayInMonth == 7 ? 1 : startDayInMonth + 1;
                        break;
                    case 31:

                        endDayInMonth = startDayInMonth == 6 ? 1 : (startDayInMonth == 7 ? 2: startDayInMonth + 2);
                        break;
                    default:
                        break;                        
                }

                var t = (i, daysInMonth, startDayInMonth, endDayInMonth);
                monthStrtEnd.Add(t);

                //reset for next month;
                startDayInMonth = endDayInMonth == 7 ? 1 : endDayInMonth + 1;
                endDayInMonth = 0;                
            }


            var monthA = (int)Enum.Parse(typeof(months), A);
            var monthB = (int)Enum.Parse(typeof(months), B);

            var totalVacDays = 0;
            var vacMonthStartDay = monthStrtEnd.Find(t => t.month == monthA).start;

            for (int i = monthA; i <= monthB; i++) 
            {
                totalVacDays += monthStrtEnd.Find(t => t.month == i).days;
            }

            var daysToSubtractFromFirstWeek = 0;
            if (vacMonthStartDay != 1) {
                daysToSubtractFromFirstWeek = 7 - (vacMonthStartDay - 1);
            }

            totalVacDays -= daysToSubtractFromFirstWeek;
            //vacMonthStartDay = 1; //reset to where monday is

            return totalVacDays / 7;

        }

        enum days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        enum months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}

