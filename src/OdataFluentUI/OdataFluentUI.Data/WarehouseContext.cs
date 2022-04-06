using Microsoft.EntityFrameworkCore;

namespace OdataFluentUI.Data
{
    public class WarehouseContext : DbContext
    {
        public WarehouseContext()
        {

        }

        public WarehouseContext(DbContextOptions<WarehouseContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Material>().HasData(GenerateMaterials());
        }

        /// <summary>
        /// 生成种子数据
        /// </summary>
        /// <returns></returns>
        private List<Material> GenerateMaterials()
        {
            List<Material> materials = new List<Material>();
            int minMaterialClassification = Enum.GetValues(typeof(MaterialClassification)).Cast<int>().Min();
            int maxMaterialClassification = Enum.GetValues(typeof(MaterialClassification)).Cast<int>().Max();
            int minUnit=Enum.GetValues(typeof(Unit)).Cast<int>().Min();
            int maxUnit = Enum.GetValues(typeof(Unit)).Cast<int>().Max();
            for (int i = 10000; i < 20000; i++)
            {
                Material material = new Material()
                {
                    MaterialId = i,
                    MaterialCode=$"Code-{i}",
                    MaterialName=$"Name-{i}",
                    MaterialModel=$"Model-{i}",
                    MaterialSpecification=$"Spec-{i}",
                    MaterialClassification = (MaterialClassification)new Random().Next(minMaterialClassification, maxMaterialClassification+1),
                    Unit=(Unit)new Random().Next(minUnit, maxUnit + 1),
                    IsAvailable=i%2==0
                };
                materials.Add(material);
            }
            return materials;
        }

        public DbSet<Material> Materials { get; set; }
    }
}
