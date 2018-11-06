using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;

public class DemoContext : MVCSContext {

    public DemoContext(MonoBehaviour view) : base(view){

    }
    //进行绑定映射
    protected override void mapBindings()
    {
        //mediator
        mediationBinder.Bind<CubeView>().To<CubeMediator>();
        //command
        commandBinder.Bind(DemoCommandEvent.RequestScore).To<RequestScoreCommand>();
        //service
        injectionBinder.Bind<IScoreService>().To<ScoreService>().ToSingleton();
        //model
        injectionBinder.Bind<ScoreModel>().To<ScoreModel>().ToSingleton();

        //绑定开始事件
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}
