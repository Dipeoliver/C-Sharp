using System;
using System.Collections.Generic;


namespace Exercicio_de_Conjuntos.Entities
{
    class Courses
    {
        public int UserId { get; set; }
        public string Course { get; set; }

        public override int GetHashCode()
        {
            return UserId.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            if(!(obj is Courses))
            {
                return false;
            }
            Courses other = obj as Courses;

            return UserId.Equals(other.UserId);
        }
    }
}
