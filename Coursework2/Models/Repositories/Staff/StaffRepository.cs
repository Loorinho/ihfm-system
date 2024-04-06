using Coursework2.Enums;
using Coursework2.Models.Staff;

namespace Coursework2.Models.Repositories.Staff;

public class StaffRepository: IStaffRepository
{
    private readonly List<IStaff> _staff = new();

    public StaffRepository()
    {
        _staff.Add(new Doctor(Guid.NewGuid(), "Loor Jacobson", GenderEnum.Male));
        _staff.Add(new Doctor(Guid.NewGuid(), "Ziggy Dee", GenderEnum.Female));
    }
    
    public void CreateStaff(IStaff staff)
    {
        _staff.Add(staff);
    }

    public List<IStaff> GetStaff()
    {
        return _staff.ToList();
    }
}