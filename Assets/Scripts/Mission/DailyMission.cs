using System.Collections.Generic;

public class Mission
{
    public bool IsRewarded;
}

//모델
public partial class DailyMission
{
    public List<Mission> Missions { get; } = new List<Mission>();

    public DailyMission()
    {
        for (int i = 0; i < 20; ++i)
        {
            Missions.Add(new Mission());
        }
    }

    private void Reward(List<Mission> missions)
    {
        foreach (var mission in missions)
        {
            mission.IsRewarded = true;
        }
    }
}
