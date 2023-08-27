﻿using melakify.Entities.Behind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MelakifyMind.Behind
{
    public class Folder
    {
        public string Date { get; set; }
        public string ReminderCount
        {
            get
            {
                return $"{Reminders.Count} یادآور";
            }
        }

        public SolidColorBrush ImportantColor
        {
            get
            {
                SolidColorBrush brush = new SolidColorBrush();
                int i = 0;
                foreach (var item in Reminders)
                {
                    if (item.IsImportant == "مهم")
                    {
                        i++;
                    }
                    else
                    {
                        
                    }
                }

                if (i > 0)
                {
                    brush = System.Windows.Media.Brushes.IndianRed;
                }
                else
                {
                    brush = System.Windows.Media.Brushes.White;
                }

                return brush;
            }
        }

        public string ReminderImportant
        {
            get
            {
                int i = 0;
                bool isIt = false;
                foreach (var item in Reminders)
                {
                    if (item.IsImportant == "مهم")
                    {
                        isIt = true;
                        i = i + 1;
                    }
                    else
                    {
                        
                    }
                }
                
                if (i > 0)
                {
                    return $"({i} یادآور مهم)";
                }
                else
                {
                    return "";
                }
            }
        }
        public ICollection<Reminder> Reminders { get; set; }
    }
}
