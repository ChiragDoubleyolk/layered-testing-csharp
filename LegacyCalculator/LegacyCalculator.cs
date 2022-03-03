using System;
using System.Collections.Generic;
using System.Linq;

namespace Gas
{
   public partial class LegacyCalculator
   {
      public IPlannedStart Calculate(List<DateTime> dates, int requiredDays = 1)
      {
         PlannedStart plannedStart = new PlannedStart { StartTime = DateTime.MinValue, Count = 0 };

         // check if dates no items then return early
         if (dates.Count == 0)
         {
            return plannedStart;
         }                  
         
         DateTime startingDayOfFirstWeek = dates.Min();
         // add a week 
         DateTime startingDayOfSecondWeek = startingDayOfFirstWeek.AddDays(7);
         // Calculating ending day of second week
         DateTime endingDayOfSecondWeek = startingDayOfSecondWeek.AddDays(7);

         dates = dates.Where(x => x > startingDayOfFirstWeek && x < endingDayOfSecondWeek).ToList();
         int countsForFirstWeek = dates
            .Where(x => x > startingDayOfFirstWeek && x < startingDayOfSecondWeek) // add a week
            .Count()
            ;
         
         int countsForSecondWeek = dates
            .Where(x => x > startingDayOfSecondWeek && x < endingDayOfSecondWeek) // add a week
            .Count()
            ;

         if (countsForSecondWeek > countsForFirstWeek && countsForSecondWeek >= requiredDays)
         {
            plannedStart = new PlannedStart { StartTime = startingDayOfSecondWeek, Count = countsForSecondWeek };
         }
         return plannedStart;
      }
   }
}
