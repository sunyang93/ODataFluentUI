namespace OdataFluentUI.OdataModelBuilder;

public class ModelBuilder
{
    public static IEdmModel GetEdmModel()
    {
        var builder = new ODataConventionModelBuilder();
        builder.Namespace = "AdventureWorks";
        builder.ContainerName = "AdventureWorksContainer";

        builder.EntitySet<ErrorLog>("ErrorLogs");

        builder.EntitySet<WorkOrder>("WorkOrders");
        builder.EntitySet<WorkOrderRouting>("WorkOrderRoutings");
        return builder.GetEdmModel();
    }
}
