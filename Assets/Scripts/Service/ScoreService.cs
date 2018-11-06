using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public class ScoreService : IScoreService {

    [Inject]
    public IEventDispatcher eventDispatcher
    {
        get;set;
    }

    public void onReceveScroe()
    {

        Debug.Log("onReceiveScore");
        eventDispatcher.Dispatch(DemoServiceEvent.requestScore,1000);
    }

    public void requestScore(string url)
    {
        Debug.Log("requestScore"+url);
        onReceveScroe();
    
    }
}
