using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

public class StartCommand : Command {

    //当ContextEvent.START命令被执行是，默认调用Execute
    public override void Execute()
    {
        Debug.Log("StartCommand Execute");
    }
}
