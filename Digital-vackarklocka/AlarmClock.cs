using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_vackarklocka
{

    // 1. Create the clockclass.
    class AlarmClock
    {

        // 2. Declare variables.
        private int _hour;
        private int _minute;
        private int _alarmHour;
        private int _alarmMinute;

        private string _presentation;


        // 3. Properties
        public int Hour
        {
            get { return _hour; }
            set { 
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
                }
        }

        public int Minute
        {
            get { return _minute; }
            set {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
                }
        }

        public int AlarmHour
        {
            get { return _alarmHour; }
            set {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                } 
                _alarmHour = value;
            }
        }

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                } 
                _alarmMinute = value;
            }
        }


        // 4. Standard constructor.
        public AlarmClock():this(0, 0)
        {

        }

        // 5. Other methods.
        public AlarmClock(int hour, int minute):this(hour, minute, 0, 0)
        {
            
        }

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        {
            _hour = hour;
            _minute = minute;

            _alarmHour = alarmHour;
            _alarmMinute = alarmMinute;
        }


        public bool TickTock()
        {

            if (_minute < 59)
            {
                Minute++;
            }

            else 
            {
                _minute = 0;
                _hour++;
            }

            if (_hour > 23)
            {
                _hour = 0;
            }
            
            if (_alarmHour == _hour && _alarmMinute == _minute)
            {
                return true;
            }
            return false;
        }

        public string ToString()
        {
            _presentation = String.Format("{0, 5}:{1:D2} <{2}:{3:D2}>", _hour, _minute, _alarmHour, _alarmMinute);
            return _presentation;
        }
    }
}
