using Coursework2.Models.Staff;

namespace Coursework2.Models.Repositories.Staff;

public interface IStaffRepository
{
    public void CreateStaff(IStaff staff);
    public List<IStaff> GetStaff();
}