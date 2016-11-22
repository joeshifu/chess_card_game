using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;

using dword = System.UInt32;
using word = System.UInt16;
using tchar = System.Char;
using longlong = System.Int64;
using System.Runtime.InteropServices;

public class GameUtils
{
    private static GameUtils inst;

    public static GameUtils Inst
    {
        get
        {
            if (inst == null)
            {
                inst = new GameUtils();
            }
            return inst;
        }
    }

    //获取平台类型
    public int GetLogonType()
    {
#if UNITY_ANDROID
        return 2;
#elif UNITY_IPHONE
		return 1;
#elif UNITY_STANDALONE_WIN
        return 3;
#else
			return 0;
#endif
    }

    //获取本地IP
    public UInt32 GetIP()
    {
        IPAddress ipAddr = null;
        IPAddress[] arrIP = Dns.GetHostAddresses(Dns.GetHostName());
        foreach (IPAddress ip in arrIP)
        {
            if (System.Net.Sockets.AddressFamily.InterNetwork.Equals(ip.AddressFamily))
            {
                ipAddr = ip;
            }
            else if (System.Net.Sockets.AddressFamily.InterNetworkV6.Equals(ip.AddressFamily))
            {
                ipAddr = ip;
            }
        }
        return BitConverter.ToUInt32(ipAddr.GetAddressBytes(), 0);
    }

    //获取大厅版本，目前写死
    public dword GetPlazaVersion()
    {
        return GetProcessVersion(13, 0, 3);

        // return 101646339;//Convert.ToUInt32(((PRODUCT_VER) << 24) + (((cbMainVer)) << 16) + ((cbSubVer) << 8) + (cbBuildVer));
    }

    //获取框架版本
    public dword GetFrameVersion()
    {
        return GetProcessVersion(6, 0, 3);
    }

    //模块版本
    public dword GetProcessVersion(byte cbMainVer, byte cbSubVer, byte cbBuildVer)
    {
        return (dword)(
            (((byte)(GameDefine.PRODUCT_VER)) << 24) +
            (((byte)(cbMainVer)) << 16) +
            ((byte)(cbSubVer) << 8)) +
            ((byte)(cbBuildVer));
    }

    //获取标示
    public byte GetValidateFlags()
    {
        return GameMessages.MB_VALIDATE_FLAGS | GameMessages.LOW_VER_VALIDATE_FLAGS;
    }

    //字符串转MD5
    public tchar[] GetMD5Chars(string strText)
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] encryptedBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(strText));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            sb.AppendFormat("{0:x2}", encryptedBytes[i]);
        }
        return sb.ToString().ToUpper().ToCharArray();
    }

    //字符串转MD5
    public string GetMD5String(string strText)
    {
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
        byte[] encryptedBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(strText));
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            sb.AppendFormat("{0:x2}", encryptedBytes[i]);
        }
        return sb.ToString();
    }

    public string GetMachineIDs()
    {
        return "b1a6afedf9cbc767ac8ff04fe997655a";
    }
}
