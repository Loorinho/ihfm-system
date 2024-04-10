using Coursework2.Enums;

namespace Coursework2.Models.Staff;

public abstract class StaffFactory
{

    public static IStaff CreateStaff(string type, string name, GenderEnum gender, ProfessionEnum profession )
    {
        var staffId = Guid.NewGuid();

        switch (type)
        {
            case "doctor":
                return new Doctor(staffId, name, gender, profession);
            
            default:
                return new NullStaff();
                
        }

    }
    
}