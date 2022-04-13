using Microsoft.EntityFrameworkCore;

namespace OdataFluentUI.Data
{
    public class WarehouseContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }

        public DbSet<Inventory> Inventorys { get; set; }

        public DbSet<StorageRack> StorageRacks { get; set; }

        public DbSet<CargoSpace> CargoSpaces { get; set; }

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
            // 设置复合主键
            modelBuilder.Entity<Inventory>()
                        .HasKey(c => new { c.MaterialId, c.Batch });

            modelBuilder.Entity<Material>().HasData(GenerateMaterials());
            modelBuilder.Entity<StorageRack>().HasData(GenerateStorageRacks());

        }

        /// <summary>
        /// 生成种子数据
        /// </summary>
        /// <returns></returns>
        private static List<Material> GenerateMaterials()
        {
            List<Material> materials = new();
            int minMaterialClassification = Enum.GetValues(typeof(MaterialClassification)).Cast<int>().Min();
            int maxMaterialClassification = Enum.GetValues(typeof(MaterialClassification)).Cast<int>().Max();
            int minUnit=Enum.GetValues(typeof(Unit)).Cast<int>().Min();
            int maxUnit = Enum.GetValues(typeof(Unit)).Cast<int>().Max();
            for (int i = 1000; i < 2000; i++)
            {
                Material material = new()
                {
                    MaterialId = i,
                    MaterialCode=$"Code-{i}",
                    MaterialName=$"Name-{i}",
                    MaterialModel=$"Model-{i}",
                    MaterialSpecification=$"Specification-{i}",
                    MaterialClassification = (MaterialClassification)new Random().Next(minMaterialClassification, maxMaterialClassification+1),
                    Unit=(Unit)new Random().Next(minUnit, maxUnit + 1),
                    IsAvailable=i%2==0
                };
                materials.Add(material);
            }
            return materials;
        } 

        /// <summary>
        /// 生成种子数据
        /// </summary>
        /// <returns></returns>
        private static List<StorageRack> GenerateStorageRacks()
        {
            List<StorageRack> storageRacks = new();
            for(int i = 1000; i < 2000; i++)
            {
                StorageRack storageRack = new()
                {
                    StorageRackId=i,
                    StorageRackName=$"Name-{i}",
                    StorageRackCode=$"Code-{i}",
                    StorageRackSpecification=$"Specification-{i}",
                    StorageRackModel=$"Model-{i}",
                    Remark=$"Remark-{i}"
                };
                storageRacks.Add(storageRack);
            }
            return storageRacks;
        }
    }
}
