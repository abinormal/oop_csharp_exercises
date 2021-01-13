using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        bool IsAsleep { get; }
        void GoToSleep();
        void WakeUp();
    }
    public class DomesticCat : ICat
    {
        private bool _IsAsleep = false;

        public bool IsAsleep => _IsAsleep;
        public void GoToSleep()
        {
            _IsAsleep = true;
        }
        public void WakeUp()
        {
            _IsAsleep = false;
        }
    }

}
