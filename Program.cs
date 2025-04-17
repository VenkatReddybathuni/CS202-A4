using System;
using System.Threading;

namespace AlarmConsoleApp
{
    class AlarmClock
    {
        public delegate void AlarmEventHandler();

        // Declare an event based on the delegate (Publisher part)
        public event AlarmEventHandler raiseAlarm;

        public void CheckTime(DateTime targetTime)
        {
            Console.WriteLine("Waiting for the target time...");

            while (true)
            {
                DateTime currentTime = DateTime.Now;

                if (currentTime.Hour == targetTime.Hour &&
                    currentTime.Minute == targetTime.Minute &&
                    currentTime.Second == targetTime.Second)
                {
                    // Raise the event (notify subscribers)
                    raiseAlarm?.Invoke();
                    break;
                }

                Thread.Sleep(1000); 
            }
        }

        // Event handler method (Subscriber part)
        public void Ring_alarm()
        {
            Console.WriteLine("Alarm ringing! Time matched.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter time in HH:MM:SS format: ");
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime targetTime))
            {
                AlarmClock clock = new AlarmClock();

                // Subscribe the Ring_alarm method to the raiseAlarm event
                clock.raiseAlarm += clock.Ring_alarm;

                clock.CheckTime(targetTime);
            }
            else
            {
                Console.WriteLine("Invalid time format.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); 
        }
    }
}
