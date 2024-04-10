using Coursework2.Enums;

namespace Coursework2.Models.Staff;

public class Doctor: IStaff
{
    public Guid StaffId { get; set; }
    public string Name { get; set; }
    public GenderEnum Gender { get; set; }
    
    public ProfessionEnum Profession { get; set; }

    public Doctor(Guid id, string name, GenderEnum gender, ProfessionEnum profession)
    {
        Name = name;
        Gender = gender;
        StaffId = id;
        Profession = profession;
    }
    
}