//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.list
{
public sealed partial class ListTest :  Bright.Config.BeanBase 
{
    public ListTest(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        {int n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Name = new System.Collections.Generic.List<string>(n0);for(var i0 = 0 ; i0 < n0 ; i0++) { string _e0;  _e0 = _buf.ReadString(); Name.Add(_e0);}}
        PostInit();
    }

    public static ListTest DeserializeListTest(ByteBuf _buf)
    {
        return new list.ListTest(_buf);
    }

    public int Id { get; private set; }
    public System.Collections.Generic.List<string> Name { get; private set; }

    public const int __ID__ = 1401053632;
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
        + "Name:" + Bright.Common.StringUtil.CollectionToString(Name) + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}