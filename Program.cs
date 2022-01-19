using CSDay3_ClockApp.Business;
using CSDay3_ClockApp.Events;

namespace CSDay3_ClockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock view = new DisplayClock();
            view.Subscribe(clock);
            LogClockToFile log = new LogClockToFile();
            log.Subscribe(clock);
            clock.Run();
        }
    }
}