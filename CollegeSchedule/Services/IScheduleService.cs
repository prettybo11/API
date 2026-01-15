using CollegeSchedule.DTO;
namespace CollegeSchedule.Services
{
    public interface IScheduleService
    {
        Task<List<ScheduleByDateDto>> GetScheduleForGroup(string groupName, DateTime
        startDate, DateTime endDate);
    }
}