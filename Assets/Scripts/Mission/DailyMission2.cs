using System.Collections.Generic;

//모델
public class DailyMission2
{
    public List<Mission> Missions { get; } = new List<Mission>();

    private readonly IRewardRequester2 _rewardRequester;

    public DailyMission2(IRewardRequester2 requester)
    {
        for (int i = 0; i < 20; ++i)
        {
            Missions.Add(new Mission());
        }
        
        _rewardRequester = requester;
    }

    public void RequestReward()
    {
        _rewardRequester.Request(Missions);
        Reward(Missions);
    }

    private void Reward(List<Mission> missions)
    {
        foreach (var mission in missions)
        {
            mission.IsRewarded = true;
        }
    }
}
