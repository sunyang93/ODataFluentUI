using OdataFluentUI.Data.Models;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace OdataFluentUI.OdataModelBuilder
{
    public class ModelBuilder
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.Namespace = "AdventureWorks";
            builder.ContainerName = "AdventureWorksContainer";

            builder.EntitySet<WorkOrder>("WorkOrders");
            builder.EntitySet<WorkOrderRouting>("WorkOrderRoutings");
            return builder.GetEdmModel();
        }
    }
}
