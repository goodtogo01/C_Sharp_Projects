using System;

namespace OOPs_Pillers_Concepts
{
    public class StopWatch {
        private DateTime _startWatch;
        private int _stopWatch;

        public Boolean start = true;

        public void ClockStart() {
                     
                var timeSpan = DateTime.Today - _startWatch;
                var stopedTime = timeSpan.TotalSeconds / 60;
            Console.WriteLine("Time is : "+stopedTime);

        }
       
        





    }
}
