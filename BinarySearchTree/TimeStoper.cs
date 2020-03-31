using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class TimeStoper
    {
        private DateTime StartTime { get; set; }
        private TimeSpan TimeSpan { get; set; } 
        public void start()
        {
            StartTime = DateTime.Now;
        }
        public void stop()
        {
            TimeSpan = DateTime.Now - StartTime;
        }
        public string getSpan()
        {
            return TimeSpan.ToString();
        }
    }
}
