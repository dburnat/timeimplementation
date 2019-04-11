using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{
    /// <summary>
    /// The main TimePeriod struct.
    /// Contains different methods for performing basic calculations. 
    /// 
    /// </summary>
    public struct TimePeriod : IEquatable<TimePeriod>, IComparable<TimePeriod>
    {
        public readonly long hours;
        public readonly long minutes;
        public readonly long seconds;
        /// <summary>
        /// Basic constructor that takes three arguments, 
        /// used to create a TimePeriod object with a specific hour, minutes and seconds.
        /// </summary>
        /// <param name="hours"> A long. If it's bigger than 24 a modulo operation is used. </param>
        /// <param name="minutes">A long. If it's bigger than 60 a modulo operation is used.</param>
        /// <param name="seconds">A long. If it's bigger than 60 a modulo operation is used.</param>
        public TimePeriod(long hours, long minutes, long seconds)
        {
      
            this.hours = hours % 24;
            this.minutes = minutes % 60;
            this.seconds = seconds % 60;
        }
        /// <summary>
        /// Constructor that takes two arguments, 
        /// used to create a TimePeriod object with a specific hour, minutes and seconds.
        /// </summary>
        /// <param name="hours"> A long. If it's bigger than 24 a modulo operation is used. </param>
        /// <param name="minutes">A long. If it's bigger than 60 a modulo operation is used.</param>
        public TimePeriod(long hours, long minutes)
        {


            this.hours = hours % 24;
            this.minutes = minutes % 60;
            this.seconds = 0;
        }
        /// <summary>
        /// Constructor that takes one arguments, 
        /// used to create a TimePeriod object with a specific hour, minutes and seconds.
        /// </summary>
        /// <param name="hours"> A long. If it's bigger than 24 a modulo operation is used. </param>
        public TimePeriod(long hours)
        {

            this.hours = hours % 24;
            this.minutes = 0;
            this.seconds = 0;
        }
        /// <summary>
        /// Constructor that takes two Time objects and creates an object equal to the difference between them
        /// </summary>
        /// <param name="time1">First time object</param>
        /// <param name="time2">Second time object</param>
        public TimePeriod(Time time1, Time time2)
        {
            this.hours = time1.hours - time2.hours % 24;
            this.minutes = time1.minutes - time2.minutes;
            this.seconds = time1.seconds - time2.seconds;
        }
        /// <summary>
        /// Overrided ToString() method that suits TimePeriod struct
        /// </summary>
        /// <returns> A string in from of HH:MM:SS</returns>
        public override string ToString()
        {
            return $"{hours}:{minutes}:{seconds}";
        }
        /// <summary>
        /// Overrided Equals() method
        /// </summary>
        /// <param name="other"></param>
        /// <returns> Returns a bool value whether two TimePeriod objects are equal</returns>
        public bool Equals(TimePeriod other)
        {
            return (this.hours == other.hours) && (this.minutes == other.minutes) && (this.seconds == other.seconds);
        }
        /// <summary>
        /// Overrided CompareTo() method
        /// </summary>
        /// <param name="other"></param>
        /// <returns> Returns 1 if object is greater, returns 0 if objects are equal, returns -1 if object is smaller</returns>
        public int CompareTo(TimePeriod other)
        {
            if (this.hours > other.hours) return 1;
            else if (this.hours == other.hours && this.minutes > other.minutes) return 1;
            else if (this.hours == other.hours && this.minutes == other.minutes && this.seconds > other.seconds) return 1;
            else if (this.Equals(other)) return 0;
            else return -1;
        }
        /// <summary>
        /// Overrided + operator
        /// </summary>
        /// <param name="lewy">First object</param>
        /// <param name="prawy">Second object</param>
        /// <returns>The sum of two TimePeriod objects </returns>
        public static TimePeriod operator+(TimePeriod lewy, TimePeriod prawy)
        {
            return new TimePeriod(lewy.hours + prawy.hours, lewy.minutes + prawy.minutes, lewy.seconds + prawy.seconds);
        }
        /// <summary>
        /// Overrided - operator
        /// </summary>
        /// <param name="lewy">First object</param>
        /// <param name="prawy">Second object</param>
        /// <returns>The difference between two TimePeriod objects</returns>
        public static TimePeriod operator -(TimePeriod lewy, TimePeriod prawy)
        {
            if ((lewy.hours - prawy.hours) < 0)
                //throw new ArgumentOutOfRangeException();
                return new TimePeriod(((lewy.hours - prawy.hours ) % 24), (lewy.minutes - prawy.minutes), (lewy.seconds - prawy.seconds));
            if ((lewy.minutes - prawy.minutes) < 0 && (lewy.seconds - prawy.seconds) < 0)
                return new TimePeriod(((lewy.hours - prawy.hours + 23) % 24), ((lewy.minutes - prawy.minutes + 59) % 60), ((lewy.seconds - prawy.seconds + 60) % 60));
            if ((lewy.minutes - prawy.minutes) < 0)
                return new TimePeriod(((lewy.hours - prawy.hours + 23) % 24), ((lewy.minutes - prawy.minutes + 60) % 60), (lewy.seconds - prawy.seconds));
            if ((lewy.seconds - prawy.seconds) < 0)
                return new TimePeriod((lewy.hours - prawy.hours % 24), ((lewy.minutes - prawy.minutes - 1) % 60), ((lewy.seconds - prawy.seconds + 60) % 60));
            //if ((lewy.seconds + prawy.seconds) == 60)
            //    return new Time((lewy.hours + prawy.hours), (lewy.minutes + prawy.minutes + 1), (lewy.seconds + prawy.seconds));


            return new TimePeriod((lewy.hours - prawy.hours), (lewy.minutes - prawy.minutes), (lewy.seconds - prawy.seconds));   
        }
        /// <summary>
        /// Method used to add TimePeriod object to TimePeriod object.
        /// </summary>
        /// <param name="other">TimePeriod object</param>
        /// <returns>TimePeriod object that is sum of two TimePeriod objects</returns>
        public TimePeriod Plus(TimePeriod other)
        {
            return new TimePeriod((hours + other.hours), (minutes + other.minutes), (seconds + other.seconds));
        }
        /// <summary>
        /// Static method used to add TimePeriod object to TimePeriod object.
        /// </summary>
        /// <param name="time">TimePeriod object</param>
        /// <param name="other">TimePeriod object</param>
        /// <returns>TimePeriod object that is sum of two TimePeriod objects</returns>
        public static TimePeriod Plus(TimePeriod time, TimePeriod other)
        {
            return new TimePeriod((time.hours + other.hours), (time.minutes + other.minutes), (time.seconds + other.seconds));
        }
        /// <summary>
        /// Overrided == operator
        /// </summary>
        /// <param name="lewy">First TimePeriod object</param>
        /// <param name="prawy">Second TimePeriod object</param>
        /// <returns>Returns a bool value whether two TimePeriod objects are equal</returns>
        public static bool operator ==(TimePeriod lewy, TimePeriod prawy)
        {
            return lewy.Equals(prawy);
        }
        /// <summary>
        /// Overrided != operator
        /// </summary>
        /// <param name="lewy">First TimePeriod object</param>
        /// <param name="prawy">Second TimePeriod object</param>
        /// <returns>Returns a bool value whether two TimePeriod objects are not equal</returns>
        public static bool operator !=(TimePeriod lewy, TimePeriod prawy)
        {
            return !lewy.Equals(prawy);
        }
        /// <summary>
        /// Overrided > operator
        /// </summary>
        /// <param name="lewy">First TimePeriod object</param>
        /// <param name="prawy">Second TimePeriod object</param>
        /// <returns>Returns a bool value whether first TimePeriod object is greater than second one</returns>
        public static bool operator >(TimePeriod lewy, TimePeriod prawy)
        {
            if (lewy.CompareTo(prawy) == 1)
                return true;
            if (lewy.CompareTo(prawy) == -1)
                return false;
            return false;
        }
        /// <summary>
        /// Overrider smaller than operator
        /// </summary>
        /// <param name="lewy">First TimePeriod object</param>
        /// <param name="prawy">Second TimePeriod object</param>
        /// <returns>Returns a bool value whether first TimePeriod object is lesser than second one</returns>
        public static bool operator <(TimePeriod lewy, TimePeriod prawy)
        {
            if (lewy.CompareTo(prawy) == 1)
                return false;
            if (lewy.CompareTo(prawy) == -1)
                return true;
            return false;
        }
        /// <summary>
        /// Overrided >= operator
        /// </summary>
        /// <param name="lewy">First TimePeriod object</param>
        /// <param name="prawy">Second TimePeriod object</param>
        /// <returns>Returns a bool value whether first TimePeriod object is greater or equal to second one</returns>
        public static bool operator >=(TimePeriod lewy, TimePeriod prawy)
        {
            if (lewy.CompareTo(prawy) == 1 || lewy.CompareTo(prawy) == 0)
                return true;
            if (lewy.CompareTo(prawy) == -1)
                return false;
            return false;
        }
        /// <summary>
        /// Overrided Smaller or Equal operator 
        /// </summary>
        /// <param name="lewy">First TimePeriod object</param>
        /// <param name="prawy">Second TimePeriod object</param>
        /// <returns>Returns a bool value whether first TimePeriod object is smaller or equal to second one</returns>
        public static bool operator <=(TimePeriod lewy, TimePeriod prawy)
        {
            if (lewy.CompareTo(prawy) == -1 || lewy.CompareTo(prawy) == 0)
                return true;
            if (lewy.CompareTo(prawy) == 1)
                return false;
            return false;
        }
    }
}
