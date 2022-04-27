namespace OdataFluentUI.ViewModels;

public class EntityTypeConfigModel
{
    /// <summary>
    /// 名称
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    [Required]
    public string DisplayName { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Entity主键
    /// </summary>
    public List<string> Keys { get; set; }

    public List<EntityTypeConfigProperty> Properties { get; set; }
}

