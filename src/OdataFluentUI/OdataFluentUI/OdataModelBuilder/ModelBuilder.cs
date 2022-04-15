namespace OdataFluentUI.OdataModelBuilder;

public class ModelBuilder
{
    public static IEdmModel GetEdmModel()
    {
        ODataConventionModelBuilder? builder = new();
        builder.Namespace = "Warehouse";
        builder.ContainerName = "WarehouseContainer";

        builder.EntitySet<Material>("Materials");
        builder.EntitySet<Inventory>("Inventories");
        builder.EntitySet<StorageRack>("StorageRacks");
        builder.EntitySet<CargoSpace>("CargoSpaces");

        builder.EntitySet<SuperEntity>("SuperEntities");

        return builder.GetEdmModel();
    }
}
