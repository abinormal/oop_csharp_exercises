using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        bool IsAsleep { get; }
        string Setting { get; }
        void GoToSleep();
        void WakeUp();
    }
    public class DomesticCat : ICat
    {
        private bool Sleep = false;
        public bool IsAsleep => Sleep;
        public string Setting => "domestic";
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
