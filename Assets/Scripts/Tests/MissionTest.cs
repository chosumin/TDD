using NUnit.Framework;

public class MissionTest
{
    [Test]
    public void RewardTest()
    {
        DailyMission2 mission = new DailyMission2(new TestRequester());
        
        //보상 요청
        mission.RequestReward();
        
        //보상 처리가 되었는지 확인
        Assert.IsTrue(mission.Missions[0].IsRewarded);
    }

    //DailyMission은 모델인데, Request를 하게되면 컨트롤러의 역할까지 수행함
    //단일 책임을 위해 이를 나눠볼까..해서 RewardTest2처럼 리팩토링함
    //1. '단일 책임을 위하여 리팩토링한다'라는 생각이 맞는지
    //2. 아래의 리팩토링은 잘되었는지
    //확신이 안든다.
    
    //partial 클래스와 nested 클래스를 사용
    //partial 클래스가 생겨서, DailyMission의 크기가 늘어났나?
    //Model, Controller 관계가 명확해짐?
    
    [Test]
    public void RewardTest2()
    {
        DailyMission mission = new DailyMission();
        
        //보상 요청
        IRewardRequester requester = DailyMission.CreateRequester(1, mission);
        requester.Request();
        
        //보상 처리가 되었는지 확인
        Assert.IsTrue(mission.Missions[0].IsRewarded);
    }
}
