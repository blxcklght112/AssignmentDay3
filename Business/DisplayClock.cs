using CSDay3_ClockApp.Events;

namespace CSDay3_ClockApp.Business
{
    public class DisplayClock
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(TimeHasChanged);
        }

        private void TimeHasChanged(object clock, TimeInfoEventArgs args)
        {
            Console.WriteLine($"{args.hour}:{args.minute}:{args.second}");
        }
    }
}