using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{

    /// <summary>
    /// The main Time struct.
    /// Contains different methods for performing basic calculations. 
    /// 
    /// </summary>
    public struct  Time : IEquatable<Time> , IComparable<Time>
    {
        
        public readonly byte hours;
        public readonly byte minutes;
        public readonly byte seconds;

        /// <summary>
        /// Basic constructor that takes three arguments, 
        /// used to create a Time object with a specific hour, minutes and seconds.
        /// </summary>
        /// <param name="hours"> A byte. If it's bigger than 24 a modulo operation is used. </param>
        /// <param name="minutes">A byte. If it's bigger than 60 a modulo operation is used.</param>
        /// <param name="seconds">A byte. If it's bigger than 60 a modulo operation is used.</param>
        public Time(byte hours, byte minutes, byte seconds)
        {
         
            this.hours = (byte)(hours % 24);
            this.minutes = (byte)(minutes % 60);
            this.seconds = (byte)(seconds % 60);    
        }

        /// <summary>
        /// Constructor that takes two arguments, 
        /// used to create a Time object with a specific hour and minutes. Value of seconds is 0.
        /// </summary>
        /// <param name="hours"> A byte. If it's bigger than 24 a modulo operation is used. </param>
        /// <param name="minutes">A byte. If it's bigger than 60 a modulo operation is used.</param>
        public Time(byte hours, byte minutes)
        {
          

            this.hours = (byte)(hours % 24);
            this.minutes = (byte)(minutes % 60);
            this.seconds = 0;
        }
        /// <summary>
        /// Constructor that takes two arguments, 
        /// used to create a Time object with a specific hour. Value of minutes and seconds is 0.
        /// </summary>
        /// <param name="hours"> A byte. If it's bigger than 24 a modulo operation is used. </param>
        public Time(byte hours )
        {
 
            this.hours = (byte)(hours % 24);
            this.minutes = 0;
            this.seconds = 0;
        }



        //public Time(string time)
        //{
        //    string[] splitted = time.Split(':');


        //    this.hours = (byte)(splitted[0]);


        //}

        /// <summary>
        /// Overrided ToString() method that suits Time struct
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
        /// <returns> Returns a bool value whether two Times are equal</returns>
        public bool Equals(Time other)
        {
            return (this.hours == other.hours) && (this.minutes == other.minutes) && (this.seconds == other.seconds);
        }
        /// <summary>
        /// Overrided CompareTo() method
        /// </summary>
        /// <param name="other"></param>
        /// <returns> Returns 1 if object is greater, returns 0 if objects are equal, returns -1 if object is smaller</returns>
        public int CompareTo(Time other)
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
        /// <returns>The sum of two Time objects </returns>
        public static Time operator +(Time lewy, Time prawy)
        {
            

            if ((lewy.hours + prawy.hours) > 23)
                //throw new ArgumentOutOfRangeException();
                return new Time((byte)(lewy.hours + prawy.hours %24), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));
            if ((byte)(lewy.seconds + prawy.seconds) == 60)
                if ((byte)(lewy.minutes + prawy.minutes) == 60)
                 return new Time((byte)(lewy.hours + prawy.hours + 1), (byte)(lewy.minutes + prawy.minutes + 1), (byte)(lewy.seconds + prawy.seconds));
            if ((byte)(lewy.seconds + prawy.seconds) == 60)
                return new Time((byte)(lewy.hours + prawy.hours ), (byte)(lewy.minutes + prawy.minutes + 1), (byte)(lewy.seconds + prawy.seconds));

            return new Time((byte)(lewy.hours + prawy.hours), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));
            //return new Time((byte)(lewy.hours + prawy.hours), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));

        }
        /// <summary>
        /// Overrided - operator
        /// </summary>
        /// <param name="lewy">First object</param>
        /// <param name="prawy">Second object</param>
        /// <returns>The difference between two Time objects</returns>
        public static Time operator -(Time lewy, Time prawy)
        {


            if ((lewy.hours - prawy.hours) < 0)
                //throw new ArgumentOutOfRangeException();
                return new Time((byte)((lewy.hours - prawy.hours + 24) % 24 ), (byte)(lewy.minutes - prawy.minutes), (byte)(lewy.seconds - prawy.seconds));
            if ((lewy.minutes - prawy.minutes) < 0 && (lewy.seconds - prawy.seconds) < 0)
                return new Time((byte)((lewy.hours - prawy.hours  +23) % 24), (byte)((lewy.minutes - prawy.minutes + 59 ) % 60), (byte)((lewy.seconds - prawy.seconds + 60) % 60));
            if ((lewy.minutes - prawy.minutes) < 0)
                return new Time((byte)((lewy.hours - prawy.hours +23) % 24), (byte)((lewy.minutes - prawy.minutes + 60) % 60), (byte)(lewy.seconds - prawy.seconds));
            if ((lewy.seconds - prawy.seconds) < 0)
                return new Time((byte)(lewy.hours - prawy.hours % 24), (byte)((lewy.minutes - prawy.minutes -1) % 60 ), (byte)((lewy.seconds - prawy.seconds+60) % 60));
            //if ((byte)(lewy.seconds + prawy.seconds) == 60)
            //    return new Time((byte)(lewy.hours + prawy.hours), (byte)(lewy.minutes + prawy.minutes + 1), (byte)(lewy.seconds + prawy.seconds));


            return new Time((byte)(lewy.hours - prawy.hours), (byte)(lewy.minutes - prawy.minutes), (byte)(lewy.seconds - prawy.seconds));

        }

        
        /// <summary>
        /// Method used to add TimePeriod object to Time object.
        /// </summary>
        /// <param name="other">TimePeriod object</param>
        /// <returns>Time object that is sum of Time object and TimePeriod object</returns>
        public Time Plus(TimePeriod other)
        {
            return new Time((byte)(hours + other.hours), (byte)(minutes + other.minutes), (byte)(seconds + other.seconds));
        }
        /// <summary>
        /// Static method used to add TimePeriod object to Time object.
        /// </summary>
        /// <param name="time">Time object</param>
        /// <param name="other">TimePeriod object</param>
        /// <returns>Time object that is sum of Time object and TimePeriod object</returns>
        public static Time Plus(Time time,TimePeriod other)
        {
            return new Time((byte)(time.hours + other.hours), (byte)(time.minutes + other.minutes), (byte)(time.seconds + other.seconds));
        }
        /// <summary>
        /// Overrided == operator
        /// </summary>
        /// <param name="lewy">First time object</param>
        /// <param name="prawy">Second time object</param>
        /// <returns>Returns a bool value whether two Times are equal</returns>
        public static bool operator ==(Time lewy, Time prawy)
        {
            return lewy.Equals(prawy);
        }
        /// <summary>
        /// Overrided != operator
        /// </summary>
        /// <param name="lewy">First time object</param>
        /// <param name="prawy">Second time object</param>
        /// <returns>Returns a bool value whether two Times are not equal</returns>
        public static bool operator !=(Time lewy, Time prawy)
        {
            return !lewy.Equals(prawy);
        }

        /// <summary>
        /// Overrided > operator
        /// </summary>
        /// <param name="lewy">First time object</param>
        /// <param name="prawy">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is greater than second one</returns>
        public static bool operator >(Time lewy, Time prawy)
        {
            if (lewy.CompareTo(prawy) == 1)
                return true;
            if (lewy.CompareTo(prawy) == -1)
                return false;
            return false;
        }
        /// <summary>
        /// Overrided smaller operator
        /// </summary>
        /// <param name="lewy">First time object</param>
        /// <param name="prawy">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is smaller than second one</returns>
        public static bool operator <(Time lewy, Time prawy)
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
        /// <param name="lewy">First time object</param>
        /// <param name="prawy">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is greater or equal to second one</returns>
        public static bool operator >=(Time lewy, Time prawy)
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
        /// <param name="lewy">First time object</param>
        /// <param name="prawy">Second time object</param>
        /// <returns>Returns a bool value whether first Time object is smaller or equal to second one</returns>
        public static bool operator <=(Time lewy, Time prawy)
        {
            if (lewy.CompareTo(prawy) == -1 || lewy.CompareTo(prawy) == 0)
                return true;
            if (lewy.CompareTo(prawy) == 1)
                return false;
            return false;
        }

    }
}
