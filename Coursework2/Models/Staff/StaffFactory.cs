using Coursework2.Enums;

namespace Coursework2.Models.Staff;

public abstract class StaffFactory
{

    public static IStaff CreateStaff(StaffEnum type, string name, GenderEnum gender, ProfessionEnum profession )
    {
        var staffId = Guid.NewGuid();

        Console.WriteLine(type);

        switch (type)
        {
            case StaffEnum.Doctor:
                return new Doctor(staffId, name, gender, profession);
            case StaffEnum.Nurse:
                return new Nurse(staffId, name, gender, profession);
            
            default:
                return new NullStaff();
                
        }

    }
    
}