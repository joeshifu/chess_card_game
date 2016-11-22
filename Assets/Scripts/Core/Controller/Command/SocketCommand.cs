using System;
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
                string str = String.Format("接收：ProtoId：{0}，数据内容字节数(不含包头)：{1}", buffer.Key, buffer.Value.ToBytes().Length);
                Debug.Log(str);
                Util.CallMethod("Network", "OnSocket", buffer.Key, buffer.Value);
                break;
        }
    }
}
