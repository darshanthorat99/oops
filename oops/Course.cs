using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Course
    {
        private int cid;
        private string name;
        private float fee;

        public void GetValues(int c, string n, float s)
        {
            cid = c;
            name = n;
            fee = s;
        }
        public string ShowValues()
        {
            return $"Course id:   {cid}\ncourse name :{name}\nfee   {fee} ";
        }
    }
}
