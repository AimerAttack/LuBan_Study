//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.item
{
public sealed partial class Reward :  Bright.Config.BeanBase 
{
    public Reward(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name = _buf.ReadString();
        PostInit();
    }

    public static Reward DeserializeReward(ByteBuf _buf)
    {
        return new item.Reward(_buf);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }

    public const int __ID__ = -1878566262;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}