using System;

namespace HW24._1
{
    public interface ITrip
    {
        void Cost();
        void Time();
    }

    public class Bicycle : ITrip
    {
        public void Cost()
        {
            Console.WriteLine("Cost for Trip: Free");
        }

        public void Time()
        {
            Console.WriteLine("Time: 3 days");
        }
    }

    public class Bus : ITrip
    {
        public void Cost()
        {
            Console.WriteLine("Cost for Trip: $50");
        }

        public void Time()
        {
            Console.WriteLine("Time: 14 hours");
        }
    }

    public class Taxi : ITrip
    {
        public void Cost()
        {
            Console.WriteLine("Cost for Trip: $700");
        }

        public void Time()
        {
            Console.WriteLine("Time: 8 hours");
        }
    }

    public class Plane : ITrip
    {
        public void Cost()
        {
            Console.WriteLine("Cost for Trip: $120");
        }

        public void Time()
        {
            Console.WriteLine("Time: 2 hours");
        }
    }

    public class Traveler
    {
        public ITrip Travel {get; set;}
        public Traveler(ITrip _trip)
        {
            Travel = _trip;
        }
        public void TravelersTime()
        {
            Travel.Time();
        }
        public void TravelersCost()
        {
            Travel.Cost();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Traveler traveler1 = new Traveler(new Plane());
            Traveler traveler2 = new Traveler(new Taxi());
            traveler1.TravelersCost();
            traveler2.TravelersTime();
        }
    }
}
