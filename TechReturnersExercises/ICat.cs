using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        bool IsAsleep { get; }
        string Setting { get; }
        int AverageHeight { get; }
        string Eat { get; }
        void GoToSleep();
        void WakeUp();

    }
    public class Cat
    {
        private bool Sleep = false;
        public bool IsAsleep => Sleep;
        public void GoToSleep()
        {
            Sleep = true;
        }
        public void WakeUp()
        {
            Sleep = false;
        }
    }
    public class DomesticCat : Cat, ICat
    {
        public string Setting => "domestic";
        public int AverageHeight => 23;
        public string Eat => "Purrrrrrr";
        
    }
    public class LionCat : Cat, ICat
    {
        public string Setting => "wild";
        public int AverageHeight => 1100;
        public string Eat => "Roar!!!!";
  

    }
    public class CheetahCat : Cat, ICat
    {
        public string Setting => "wild";
        public int AverageHeight => 1100;
        public string Eat => "Zzzzzzz";
    }

}
