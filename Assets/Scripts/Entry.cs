using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Bright.Serialization;
using cfg;
using SimpleJSON;
using UnityEngine;

public class Entry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadConfig();
    }

    Tables tables;
    void LoadConfig()
    {
        var tablesCtor = typeof(cfg.Tables).GetConstructors()[0];
        var loaderReturnType = tablesCtor.GetParameters()[0].ParameterType.GetGenericArguments()[1];
        // 根据cfg.Tables的构造函数的Loader的返回值类型决定使用json还是ByteBuf Loader
        System.Delegate loader = loaderReturnType == typeof(ByteBuf) ?
            new System.Func<string, ByteBuf>(LoadByteBuf)
            : (System.Delegate)new System.Func<string, JSONNode>(LoadJson);
        tables = (cfg.Tables)tablesCtor.Invoke(new object[] {loader});
        
        TestSimple();
        TestList();
    }
    
    private  JSONNode LoadJson(string file)
    {
        return JSON.Parse(File.ReadAllText($"{Application.dataPath}/../GenerateDatas/json/{file}.json", System.Text.Encoding.UTF8));
    }

    private  ByteBuf LoadByteBuf(string file)
    {
        return new ByteBuf(File.ReadAllBytes($"{Application.dataPath}/../GenerateDatas/bin/{file}.bytes"));
    }

    void TestSimple()
    {
        Debug.Log("-----------TestSimple start");
        var reward = tables.TbReward.Get(1);
        Debug.Log(reward.ToString());
        Debug.Log("-----------TestSimple end");
    }

    void TestList()
    {
        Debug.Log("-----------TestList start");
        var item = tables.TbListTest.Get(1);
        var str = string.Join(",", item.Name);
        Debug.Log(str);
        Debug.Log("-----------TestList end");
    }
}