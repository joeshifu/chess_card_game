using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LuaFramework;

public class SocketCommand : ControllerCommand
{
    public override void Execute(IMessage message)
    {
        object data = message.Body;
        if (data == null) return;
        KeyValuePair<int, ByteBuffer> buffer = (KeyValuePair<int, ByteBuffer>)data;
        switch (buffer.Key)
		{
            default:
                Debug.LogError("MsgId:"+buffer.Key + "MsgSize:"+buffer.Value.ToBytes().Length);
                Util.CallMethod("Network", "OnSocket", buffer.Key, buffer.Value);
                break;
        }
    }
}
