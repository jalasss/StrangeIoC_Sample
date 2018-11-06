using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public interface IScoreService {

    void requestScore(string url);
    void onReceveScroe();

    IEventDispatcher eventDispatcher { get; set; }
}
