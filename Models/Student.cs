using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int StudentId { get; set; }
    public string Description { get; set; }

    public int DepartmentId { get; set; }

    public virtual Department Department { get; set; }
    // assign this - viewbag - pass the departments collection and use the dropdown to set this - have to create the departments before students
    // Create and Read for dpt
    public virtual ICollection<CourseStudent> JoinEntities { get;}
  }
}