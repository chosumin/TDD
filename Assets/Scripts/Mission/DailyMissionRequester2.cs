using System.Collections.Generic;

public interface IRewardRequester2
{
    public void Request(List<Mission> mission);
}

//가짜 컨트롤러
public class TestRequester : IRewardRequester2
{
    public void Request(List<Mission> mission)
    {
    }
}