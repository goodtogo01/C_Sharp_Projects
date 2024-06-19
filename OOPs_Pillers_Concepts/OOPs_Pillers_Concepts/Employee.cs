namespace OOPs_Pillers_Concepts
{
    public class Employee {


        private int _ssn;
        private char _sex;


        public void SetSSN(int ssn) { 
            _ssn = ssn;
        }
        public int GetSSN() { 
           return _ssn; 
        }
        public void SetSEX(char sex) {
            _sex = sex;
           }
        public char GetSEX() {
            return _sex;
            }
    }
}
