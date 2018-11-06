using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public class RequestScoreCommand : EventCommand {
    [Inject]
    public IScoreService scoreService { get; set; }
    [Inject]
    public ScoreModel scoreModel { get; set; }

    public override void Execute()
    {
        Retain();   //命令可能会被销毁，调用该方法保持当前对象
        Debug.Log("RequestScoreCommand Execute");
        scoreService.eventDispatcher.AddListener(DemoServiceEvent.requestScore,OnComplete);
        scoreService.requestScore("1234541325423454");
    }
    public void OnComplete(IEvent evt) {
        Debug.Log("RequestScoreCommand OnComplete");
        scoreModel.score = (int)evt.data;
        scoreService.eventDispatcher.RemoveListener(DemoServiceEvent.requestScore,OnComplete); //移除，成对的
        dispatcher.Dispatch(DemoMediatorEvent.ScoreChange,evt.data);
        Release();  //释放当前对象
    }
}
