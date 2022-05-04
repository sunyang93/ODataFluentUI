namespace OdataFluentUI.ViewModels;

public class EntitySetConfigViewModel 
{
    /// <summary>
    /// 主键Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 显示名称
    /// </summary>
    public string DisplayName { get; set; }

    public EntityTypeConfig EntityTypeConfig { get; set; }
}

