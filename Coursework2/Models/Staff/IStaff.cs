using Coursework2.Enums;

namespace Coursework2.Models.Staff;

public interface IStaff
{
    public Guid StaffId { get; set; }
    public string Name { get; set; }
    public GenderEnum Gender { get; set; }
    // public string Type { get; set; }
}