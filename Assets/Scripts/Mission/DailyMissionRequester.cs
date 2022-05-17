public interface IRewardRequester
{
    void Request();
}

public partial class DailyMission
{
    public static IRewardRequester CreateRequester(int type, DailyMission dailyMission)
    {
        return type switch
        {
            1 => new TestRequester(dailyMission),
            2 => new Requester(dailyMission),
            _ => new TestRequester(dailyMission)
        };
    }
    
    //가짜 컨트롤러
    private class TestRequester : IRewardRequester
    {
        private readonly DailyMission _dailyMission;
    
        public TestRequester(DailyMission dailyMission)
        {
            _dailyMission = dailyMission;
        }
    
        public void Request()
        {
            var missions = _dailyMission.Missions;
            _dailyMission.Reward(missions);
        }
    }

    //실제 컨트롤러
    private class Requester : IRewardRequester
    {
        private readonly DailyMission _dailyMission;
    
        public Requester(DailyMission dailyMission)
        {
            _dailyMission = dailyMission;
        }
    
        public void Request()
        {
            var missions = _dailyMission.Missions;
            _dailyMission.Reward(missions);
        }
    }   
}