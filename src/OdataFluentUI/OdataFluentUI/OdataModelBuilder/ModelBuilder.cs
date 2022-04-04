namespace OdataFluentUI.OdataModelBuilder;

public class ModelBuilder
{
    public static IEdmModel GetEdmModel()
    {
        var builder = new ODataConventionModelBuilder();
        builder.Namespace = "AdventureWorks";
        builder.ContainerName = "AdventureWorksContainer";

        builder.EntitySet<ErrorLog>("ErrorLog");

        builder.EntitySet<WorkOrder>("WorkOrder");
        //builder.EntitySet<WorkOrderRouting>("WorkOrderRoutings");
        return builder.GetEdmModel();
    }
}
