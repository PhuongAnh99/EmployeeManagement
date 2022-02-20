using System.ComponentModel.DataAnnotations;

namespace EmployeeManage.Models
{
    public class Employee : BaseModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }
        public DateTime DateOfJoining { get; set; }
        public virtual Department Department { get; set; }
    }
}