namespace OdataFluentUI.ViewModels;

public class EnumTypeConfigModel
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

    public List<EnumType> Enums { get; set; }
}

