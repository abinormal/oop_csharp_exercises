using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        bool IsAsleep { get; }
        string Setting { get; }
        int AverageHeight { get; }
        void GoToSleep();
        void WakeUp();
    }
    public class DomesticCat : ICat
    {
        private bool Sleep = false;
        public bool IsAsleep => Sleep;
        public string Setting => "domestic";
        public int AverageHeight => 23;
        public void GoToSleep()
        {
            Sleep = true;
        }
        public void WakeUp()
        {
            Sleep = false;
        }
    }

}
