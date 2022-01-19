using CSDay3_ClockApp.Events;

namespace CSDay3_ClockApp.Business
{
    public class LogClockToFile
    {
        public void Subscribe(Clock clock)
        {
            clock.SecondChange += new Clock.SecondChangeHandler(ClockToFile);
        }
        public void ClockToFile(object clock, TimeInfoEventArgs timeInfo)
        {
            using (FileStream stream = File.Open("./Log1.txt", FileMode.Append))
            {
                string outputString = String.Format($"Time : {timeInfo.hour}:{timeInfo.minute}:{timeInfo.second}");

                byte[] bytes = new System.Text.UTF8Encoding(true).GetBytes(outputString + "\n");
                stream.Write(bytes, 0, bytes.Length);
            }

            using (StreamWriter writer = new StreamWriter("./Log2.txt", true))
            {
                string outputString = String.Format($"Time : {timeInfo.hour}:{timeInfo.minute}:{timeInfo.second}");
                writer.WriteLine(outputString);
            }
        }
    }
}