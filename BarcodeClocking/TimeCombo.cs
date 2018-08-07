using System;

namespace BarcodeClocking {
    internal class TimeCombo {
        public string clockedIn {
            get;
            set;
        }

        public string clockedOut {
            get;
            set;
        }

        public TimeCombo() {
            clockedIn = default(string);
            clockedOut = default(string);
        }

        public TimeCombo(System.DateTime timeIn, System.DateTime timeOut) {
            clockedIn = timeIn.ToString(StringFormats.sqlTimeFormat);
            clockedOut = timeOut.ToString(StringFormats.sqlTimeFormat);
        }

        public TimeCombo(string timeIn, string timeOut) {
            clockedIn = System.DateTime.FromBinary(long.Parse(timeIn)).ToString(StringFormats.sqlTimeFormat);
            if (timeOut != "")
                clockedOut = System.DateTime.FromBinary(long.Parse(timeOut)).ToString(StringFormats.sqlTimeFormat);
            else
                clockedOut = timeOut;
        }

        public override string ToString() {
            return clockedIn + "\t" + clockedOut + "\r\n";
        }
    }
}
