namespace OdataFluentUI.OdataModelBuilder;

public class ModelBuilder
{
    public static IEdmModel GetEdmModel()
    {
        ODataConventionModelBuilder? builder = new ODataConventionModelBuilder();
        builder.Namespace = "Warehouse";
        builder.ContainerName = "WarehouseContainer";

        builder.EntitySet<Material>(nameof(Material));
        builder.EntitySet<Inventory>(nameof(Inventory));
        builder.EntitySet<StorageRack>(nameof(StorageRack));
        builder.EntitySet<CargoSpace>(nameof(CargoSpace));

        return builder.GetEdmModel();
    }
}
