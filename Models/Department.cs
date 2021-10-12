using System.Collections.Generic;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Students = new HashSet<Student>();
    }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
    //list 
    public virtual ICollection<Student> Students { get; set; }
  }
}