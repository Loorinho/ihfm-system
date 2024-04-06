using Coursework2.Enums;

namespace Coursework2.Models.Staff;

public class Doctor: IStaff
{
    public Guid StaffId { get; set; }
    public string Name { get; set; }
    public GenderEnum Gender { get; set; }
    
    public Doctor(Guid id, string name, GenderEnum gender)
    {
        Name = name;
        Gender = gender;
        StaffId = id;
    }
    
}