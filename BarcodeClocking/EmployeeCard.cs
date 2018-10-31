using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BarcodeClocking {
    class EmployeeCard {
        public string employeeID;
        public string firstName;
        public string lastName;
        public string middle;
        public string rate;
        public string employeeType;

        public List<TimeCombo> timeStampsOld = new List<TimeCombo>();

        public EmployeeCard(string id, string fN, string lN, string m, string r, string eT) {
            employeeID = id;
            firstName = fN;
            lastName = lN;
            middle = m;
            rate = r;
            employeeType = eT;

            LoadTimeStamps();
        }

        public static explicit operator EmployeeCard(object[] objs) {
            // converts array of objects to EmployeeCard to improve readability in other areas
            // of the code (especially FormGenerate)

            if (objs.Length < 6) {
                throw new InvalidCastException(String.Format("Object array must have 6 elements to cast to EmployeeCard (got {0}).", objs.Length));
            }

            String[] fields = objs.Select(obj => obj.ToString()).ToArray();
            return new EmployeeCard(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]);
        }

        private void LoadTimeStamps() {
            try {
                string[] array = File.ReadAllLines(employeeID + ".txt");

                for (int i = 0; i < array.Length; i++) {
                    string text = array[i];
                    string[] entry = text.Split("\t".ToCharArray());

                    if (entry.Length > 1) {
                        timeStampsOld.Add(new TimeCombo(entry[0], entry[1]));
                    } else if (entry.Length == 1) {
                        timeStampsOld.Add(new TimeCombo(entry[0], ""));
                    }
                }
            } catch (Exception err) {
                File.WriteAllText("employeeCard-" + employeeID + ".txt", "ImportEmployeeCardError: " + err.Message + "\r\n\r\n");
            }
        }
    }
}
