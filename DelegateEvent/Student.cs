using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEvent
{
  public class Student
    {
        public string Name { get; set; }
        public int Result { get; set; }
        public Student(string name,int result)
        {
            Name = name;
            Result = result;
        }
        public event Action<bool> Notify;
        public void MethodNotify()
        {
            if (Result > 65)
            {
                Notify(true);
            }
            else 
            {
                Notify(false);
            }
        }

    }
}
