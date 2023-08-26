namespace Personel_Management.Core.Entities
{
    public class EmployeeHour : BaseEntity
    {
        public string Start { get; set; }
        public string End { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
