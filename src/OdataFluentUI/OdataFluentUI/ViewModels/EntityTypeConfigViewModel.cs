using MessagePack;

namespace OdataFluentUI.ViewModels;

[MessagePackObject]
public class EntityTypeConfigViewModel
{
    /// <summary>
    /// 主键Id
    /// </summary>
    [MessagePack.Key("id")]
    //[MessagePack.Key(0)]
    public string Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    [MessagePack.Key("name")]
    //[MessagePack.Key(1)]
    public string Name { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    [MessagePack.Key("displayName")]
    //[MessagePack.Key(2)]
    public string DisplayName { get; set; }
}

