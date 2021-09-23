using System;


namespace Equal_GetHashCode.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email{ get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Employee))
                return false;
            Employee other = obj as Employee;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
