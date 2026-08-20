using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace OopsConsoleApp7PM
{
    class Employeee
    {
        private int _eid;
        private string _ename;

        private int _esal;

        public void SetEmployee(int _eid, string _ename, int _esal)
        {

            this._eid = _eid;
            this._ename = _ename;
            this._esal = _esal;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID : {_eid}\tEmployee Name : {_ename}\tEmployee Salary : {_esal}");
        }


    }
    internal class Class13
    {
        public static void Main()
        {
            Employeee p = new Employeee();

            p.SetEmployee(111,"kiran",50000);
            p.GetEmployee();

        }
    }
}
