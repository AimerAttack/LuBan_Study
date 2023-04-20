//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace cfg.i18n
{
public sealed partial class Lang :  Bright.Config.BeanBase 
{
    public Lang(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name_l10n_key = _buf.ReadString(); Name = _buf.ReadString();
        PostInit();
    }

    public static Lang DeserializeLang(ByteBuf _buf)
    {
        return new i18n.Lang(_buf);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Name_l10n_key { get; }

    public const int __ID__ = 48850910;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Dictionary<string, object> _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Name = translator(Name_l10n_key, Name);
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