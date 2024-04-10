using Coursework2.Enums;

namespace Coursework2.Models.Staff;

public class NullStaff: IStaff
{
    public Guid StaffId { get; set; }
    public string Name { get; set; }
    public GenderEnum Gender { get; set; }
    public ProfessionEnum Profession { get; set; }
}