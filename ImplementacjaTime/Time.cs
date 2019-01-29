using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacjaTime
{
    struct  Time : IEquatable<Time> , IComparable<Time>
    {
        private readonly byte hours;
        private readonly byte minutes;
        private readonly byte seconds;
      

        public Time(byte hours, byte minutes, byte seconds)
        {
         
            this.hours = (byte)(hours % 24);
            this.minutes = (byte)(minutes % 60);
            this.seconds = (byte)(seconds % 60);    
        }

        public Time(byte hours, byte minutes)
        {
          

            this.hours = (byte)(hours % 24);
            this.minutes = (byte)(minutes % 60);
            this.seconds = 0;
        }

        public Time(byte hours )
        {
 
            this.hours = (byte)(hours % 24);
            this.minutes = 0;
            this.seconds = 0;
        }

        //public Time(string time)
        //{
        //    string[] splitted = time.Split(':');


        //    this.hours =  Encoding.ASCII.get;
            

        //}


        public override string ToString()
        {
            
                return $"{hours}:{minutes}:{seconds}";
        }

        public bool Equals(Time other)
        {
            return (this.hours == other.hours) && (this.minutes == other.minutes) && (this.seconds == other.seconds);
        }

        public int CompareTo(Time other)
        {
            if (this.hours > other.hours) return 1;
            else if (this.hours == other.hours && this.minutes > other.minutes) return 1;
            else if (this.hours == other.hours && this.minutes == other.minutes && this.seconds > other.seconds) return 1;
            else if (this.Equals(other)) return 0;
            else return -1;
        }

        public static Time operator +(Time lewy, Time prawy)
        {
            

            if ((lewy.hours + prawy.hours) > 23)
                //throw new ArgumentOutOfRangeException();
                return new Time((byte)(lewy.hours + prawy.hours %24), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));
            if ((byte)(lewy.seconds + prawy.seconds) == 60)
                if ((byte)(lewy.minutes + prawy.minutes) == 60)
                 return new Time((byte)(lewy.hours + prawy.hours + 1), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));
            if ((byte)(lewy.seconds + prawy.seconds) == 60)
                return new Time((byte)(lewy.hours + prawy.hours ), (byte)(lewy.minutes + prawy.minutes + 1), (byte)(lewy.seconds + prawy.seconds));

            return new Time();
            //return new Time((byte)(lewy.hours + prawy.hours), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));

        }

        //public static Time operator -(Time lewy, Time prawy)
        //{


        //    if ((lewy.hours - prawy.hours) > 23)
        //        //throw new ArgumentOutOfRangeException();
        //        return new Time((byte)(lewy.hours - prawy.hours % 24), (byte)(lewy.minutes - prawy.minutes), (byte)(lewy.seconds - prawy.seconds));
        //    if ((byte)(lewy.seconds + prawy.seconds) == 60)
        //        if ((byte)(lewy.minutes + prawy.minutes) == 60)
        //            return new Time((byte)(lewy.hours + prawy.hours + 1), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));
        //    if ((byte)(lewy.seconds + prawy.seconds) == 60)
        //        return new Time((byte)(lewy.hours + prawy.hours), (byte)(lewy.minutes + prawy.minutes + 1), (byte)(lewy.seconds + prawy.seconds));

        //    return new Time();
        //    //return new Time((byte)(lewy.hours + prawy.hours), (byte)(lewy.minutes + prawy.minutes), (byte)(lewy.seconds + prawy.seconds));

        //}

        public static bool operator ==(Time lewy, Time prawy)
        {
            return lewy.Equals(prawy);
        }
        public static bool operator !=(Time lewy, Time prawy)
        {
            return !lewy.Equals(prawy);
        }

        public static bool operator >(Time lewy, Time prawy)
        {
            if (lewy.CompareTo(prawy) == 1)
                return true;
            if (lewy.CompareTo(prawy) == -1)
                return false;
            return false;
        }

        public static bool operator <(Time lewy, Time prawy)
        {
            if (lewy.CompareTo(prawy) == 1)
                return false;
            if (lewy.CompareTo(prawy) == -1)
                return true;
            return false;
        }

        //public static bool operator >=(Time lewy, Time prawy)
        //{
        //    if (lewy.CompareTo(prawy) == 1)
        //        return true;
        //    if (lewy.CompareTo(prawy) == -1)
        //        return false;
        //}

    }
}
