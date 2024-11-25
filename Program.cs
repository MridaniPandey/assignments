using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calenderview
{
   
class CalendarView
        {
            static void Main()
            {
                //Assuming the month is of 30 days
                int daysInMonth = 30;

                // Assuming month starts on Wednesday and sun=0...
                int startDay = 3;    

                // Calculating the total number of weeks required
                int weeks = (int)Math.Ceiling((daysInMonth + startDay) / 7.0);

                //Creating a jagged array for the weeks
                int[][] calendar = new int[weeks][];

                //Filling  the jagged array with days
                int currentDay = 1;
                for (int i = 0; i < weeks; i++)
                {
                     // Each week has 7 days
                    calendar[i] = new int[7]; 
                    for (int j = 0; j < 7; j++)
                    {
                        if ((i == 0 && j < startDay) || currentDay > daysInMonth)
                        {
                            // Empty day (outside the current month)
                            calendar[i][j] = 0;
                        }
                        else
                        {
                            calendar[i][j] = currentDay++;
                        }
                    }
                }

                // Printing
                Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
                foreach (var week in calendar)
                {
                    foreach (var day in week)
                    {
                        if (day == 0)
                        // if emppty day
                        Console.Write("    "); 
                        else
                            Console.Write($"{day,3} "); 
                    }
                    Console.WriteLine();
                }
            }
        }

    }


