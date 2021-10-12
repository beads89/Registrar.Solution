using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntities = new HashSet<CourseStudent>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; } // "Intro to Programming", "Advanced Databases"

    // public string Department { get; set; } "CS" - add a table eventually get from an actual database join table or database property
    public int CourseNumber { get; set;}  //101, 102, 201, 202, 499
    // update controller? view?


    public virtual ICollection<CourseStudent> JoinEntities { get; set; }
  }
}