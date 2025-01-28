using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public Duration(int _seconds)
        {
            Hours = _seconds / 3600;
            Minutes = _seconds / 60;
            Seconds = _seconds % 60;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {

            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) +
                     (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);

            int hours = totalSeconds / 3600;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return new Duration(hours, minutes, seconds);

        }

        public static Duration operator +(Duration d1, int secounds)
        {

            int totalSeconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) +
                     (secounds);

            int hours = totalSeconds / 3600;
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return new Duration(hours, minutes, seconds);

        }
        public static Duration operator +(int seconds, Duration d1)
        {
            return d1 + seconds;
        }


        public static Duration operator ++(Duration d)
        {
            d.Minutes += 1;
            if (d.Minutes >= 60)
            {
                d.Minutes = 0;
                d.Hours += 1;
            }
            return d;
        }

        public static Duration operator --(Duration d)
        {
            d.Minutes -= 1;
            if (d.Minutes < 0)
            {
                d.Minutes = 59;
                d.Hours -= 1;
            }
            return d;
        }


        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            int resultSeconds = totalSeconds1 - totalSeconds2;
            return new Duration(resultSeconds);
        }


        public static bool operator >(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 > totalSeconds2;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 < totalSeconds2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 <= totalSeconds2;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalSeconds1 >= totalSeconds2;
        }

        public static bool operator true(Duration d)
        {
            return d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0;
        }

        public static bool operator false(Duration d)
        {
            return !(d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0);
        }


        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        public override string ToString()
        {
            return $"Duration: {Hours} Hours, {Minutes} Minutes, {Seconds} Seconds";
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            Duration other = obj as Duration; // obj as Duration is a cast
            return (Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds);
        }

        public override int GetHashCode()
        {
            int HashCode = Hours * 5;
            HashCode ^= Minutes * 7;
            HashCode ^= Seconds * 11;
            return HashCode;
        }
    }
}
