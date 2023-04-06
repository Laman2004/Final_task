using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_task
{
    internal class Student
    {
        public string fullName;
        public double avgPoint;
        public string FullName { 
            get=>this.fullName;
            set
            {
                if(CheckFullName(value))
                this.fullName = value;
            }
        }
        public double AvgPoint
        {
            get=> this.avgPoint;
            set
            {
                if(value>=0 && value<=100)
                    this.avgPoint = value;
            }
        }
        public string GetInfo()
        {
            return $"FullName : {FullName} - AvgPoint : {AvgPoint}";
        }
        //private void Space(ref string fullname)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    bool Index=false;
        //    for(int i=0; i < fullname.Length;)
        //    {
        //        if(stringBuilder.ToString().Length>0 && stringBuilder.ToString()[stringBuilder.Length-1] != ' ' || fullname[i]!=' ')
        //        {
        //            stringBuilder.Append(fullname[i]);
        //        }
        //        else if (!Index)
        //        {
        //            stringBuilder.Append(fullname[i]);
        //            Index = true;
        //        }
        //    }
        //    fullname = stringBuilder.ToString();
        //}
        private bool CheckFullName(string fullname)
        {
            //Space(ref fullname);
            string[] array = fullname.Split(' ');
            int count = 0;
            foreach (var item in array)
            {
                if (char.IsUpper(item[0]))
                    count++;
                if (count == 2) { return true; }
            }
            return false;
        }

    }
}
