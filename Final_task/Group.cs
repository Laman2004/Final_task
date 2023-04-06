using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_task
{
    internal class Group
    {
        public string no;
        public string teacherName;
        public int studentCount;
        public string No
        {
            get => this.no;
            set
            {
                int upperCount = 0;
                int digitCount = 0;

                foreach (var item in value)
                {
                    if (char.IsUpper(item))
                        upperCount++;
                    else if (char.IsDigit(item))
                        digitCount++;

                    if (!string.IsNullOrWhiteSpace(value) && upperCount == 3 && digitCount == 3)
                        this.no = value;
                }
            }
        }
        public string TeacherName
        {
            get=> this.teacherName;
            set
            {
                if(CheckFullName(value))
                        this.teacherName = value;
                
            }
        }
        public int StudentCount
        {
            get=> this.studentCount;
            private set 
            { 
                if(students.Length>=0 && students.Length<=20)
                this.studentCount = students.Length; 
            }
        }
        private Student[] students=new Student[0];
        public Student[] GetAllStudent()
        {
            return students;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length+1);
            students[students.Length - 1] = student;
            this.studentCount++;
        }
        public Student SearchStudent(string name)
        {
            int count = 0;
            foreach(Student student in GetAllStudent())
            {
                string[] arr=student.ToString().Split(' ');
                foreach(var item in arr)
                {
                    if(item==name)
                    count++;
                    if(count==1)
                        return student;
                }
            }
            return null;
            //Space(ref name);
            //int i, j;
            //var str = Array.IndexOf(students, (object)name);
            //if (str >= 0)
            //{
            //    Student[] student = new Student[students.Length - 1];
            //    for (i = 0, j = 0; i < students.Length; i++)
            //    {
            //        if (i != str) { continue; }
            //        student[j] = students[i];
            //        j++;
            //    }
            //    return student;
            //}
            //return students;

        }
        public string GetInfo()
        {
            return $"GroupNo : {No} - Teacher Name : {TeacherName} - Student Count : {StudentCount}";
        }
        public void Space(ref string name)
        {
            StringBuilder stringBuilder= new StringBuilder();
            for (int i = 0; i < name.Length; i++)
            {
                if (stringBuilder.ToString()==name)
                {
                    stringBuilder.Append(name[i]);
                }
            }
            name = stringBuilder.ToString();
        }
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
        //public void RemoveStudent(string name)
        //{
        //    //int i, j;
            
        //  for(int i = 0; i < students.Length; i++)
        //    {
        //        if (students[i] ==(object)name) { students[i] = null; }
        //        for (int x = 0; x < students.Length - i; x++)
        //        {
        //            i = i + 1;
        //            students[i - 1] = students[i];
        //        }
        //        students.Length = students.Length - 1;
        //    }
        //}
        public bool Remove( ref string value) // Easy to do for strings too.
        {
            bool found = false;
            for (int i = 0; i < students.Length; ++i)
            {
                if (found)
                {
                    students[i - 1] = students[i];
                }
                else if (students[i] == (object)value)
                {
                    found = true;
                }
            }
            return found;
        }
        //var str=Array.IndexOf(students, (object)name);
        //if (str >= 0)
        //{
        //    Student[] student=new Student[students.Length-1];
        //    for ( i = 0, j = 0; i < students.Length; i++){
        //        if (i == str) { continue; }
        //        student[j] = students[i]; 
        //        j++;
        //    }
        //    return student;
        //}
        //return students;
        //foreach
        public void Delete(string name) { 
        //{
        //   ;
        //    string[] array = students.ToString().Split(' ');
        //   foreach(var item in array)
        //    {
        //        if (item != name)
        //        {
        //            continue;
        //        }
        //    }
        //   return students.ToString();
        int index=Array.IndexOf(students, (object)name);
            if (index != -1)
            {
                Student[] student=new Student[students.Length-1];
                for(int i=0; i<index; i++)
                {
                    student[i] = (Student)students[i];
                }
                for (int i=index; i < student.Length; i++)
                {
                    student[i] = students[i + 1];
                }
                Array.Resize(ref students, students.Length-1);
            }
            
        }
   
        
    }
    }
    
    

