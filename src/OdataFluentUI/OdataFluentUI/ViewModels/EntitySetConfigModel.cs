namespace OdataFluentUI.ViewModels;

public class EntitySetConfigModel
{
    /// <summary>
    /// 名称
    /// </summary>
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
    /// 是否可见
    /// </summary>
    public bool IsVisible { get; set; }

    public List<EntitySetConfigProperty> Properties { get; set; }
}

