
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;

public class CubeMediator : Mediator {
    [Inject]
    public CubeView cubeView { get; set; }

    [Inject(ContextKeys.CONTEXT_DISPATCHER)]
    public IEventDispatcher disPatcher { get; set; }

    public override void OnRegister()
    {
        Debug.Log("OnRegister");
        cubeView.Init();

        disPatcher.AddListener(DemoMediatorEvent.ScoreChange ,OnScoreChange);
        disPatcher.Dispatch(DemoCommandEvent.RequestScore);
    }

    public void OnScoreChange(IEvent evt) {

        cubeView.updateScore((int)evt.data);
        Debug.Log("OnScoreChange");
    }

    public override void OnRemove()
    {
        disPatcher.RemoveListener(DemoMediatorEvent.ScoreChange, OnScoreChange);
    }
}
