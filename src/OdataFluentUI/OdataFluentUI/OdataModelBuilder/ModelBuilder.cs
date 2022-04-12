namespace OdataFluentUI.OdataModelBuilder;

public class ModelBuilder
{
    public static IEdmModel GetEdmModel()
    {
        var builder = new ODataConventionModelBuilder();
        builder.Namespace = "Warehouse";
        builder.ContainerName = "WarehouseContainer";

        builder.EntitySet<Material>(nameof(Material));
        builder.EntitySet<Inventory>(nameof(Inventory));
        return builder.GetEdmModel();
    }
}
