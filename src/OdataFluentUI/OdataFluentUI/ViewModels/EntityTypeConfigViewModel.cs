using MessagePack;

namespace OdataFluentUI.ViewModels;

[MessagePackObject]
public class EntityTypeConfigViewModel
{
    /// <summary>
    /// 主键Id
    /// </summary>
    [MessagePack.Key("id")]
    public string Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    [MessagePack.Key("name")]
    public string Name { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    [MessagePack.Key("displayName")]
    public string DisplayName { get; set; }
}

