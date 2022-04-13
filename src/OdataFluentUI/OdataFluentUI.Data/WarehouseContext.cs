using Microsoft.EntityFrameworkCore;

namespace OdataFluentUI.Data
{
    public class WarehouseContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }

        public DbSet<Inventory> Inventorys { get; set; }

        public DbSet<StorageRack> StorageRacks { get; set; }

        public DbSet<CargoSpace> CargoSpaces { get; set; }

        public DbSet<SuperEntity> SuperEntities { get; set; }

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
            modelBuilder.Entity<SuperEntity>().HasData(GenerateSuperEntitys());
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

        /// <summary>
        /// 生成种子数据
        /// </summary>
        /// <returns></returns>
        private static List<SuperEntity> GenerateSuperEntitys()
        {
            List<SuperEntity> superEntitys = new();
            for (int i = 1000; i < 2000; i++)
            {
                SuperEntity storageRack = new()
                {
                    SuperEntityId = i,
                    Property1 =$"Property1-{i}",
                    Property2 = $"Property2-{i}",
                    Property3 = $"Property3-{i}",
                    Property4 = $"Property4-{i}",
                    Property5 = $"Property5-{i}",
                    Property6 = $"Property6-{i}",
                    Property7 = $"Property7-{i}",
                    Property8 = $"Property8-{i}",
                    Property9 = $"Property9-{i}",
                    Property10 = $"Property10-{i}",
                    Property11 = i,
                    Property12 = i,
                    Property13 = i,
                    Property14 = i,
                    Property15 = i,
                    Property16 = i,
                    Property17 = i,
                    Property18 = i,
                    Property19 = i,
                    Property20 = i,
                    Property21 = true,
                    Property22 = true,
                    Property23 = true,
                    Property24 = true,
                    Property25 = true,
                    Property26 = false,
                    Property27 = false,
                    Property28 = false,
                    Property29 = false,
                    Property30 = false,
                    Property31 = (decimal)Math.Round(new Random().NextDouble()*1000,4),
                    Property32 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property33 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property34 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property35 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property36 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property37 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property38 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property39 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property40 = (decimal)Math.Round(new Random().NextDouble() * 1000, 4),
                    Property41 = new DateOnly(2022,1,1),
                    Property42 = new DateOnly(2022, 2, 1),
                    Property43 = new DateOnly(2022, 3, 1),
                    Property44 = new DateOnly(2022, 4, 1),
                    Property45 = new DateOnly(2022, 5, 1),
                    Property46 = new DateOnly(2022, 6, 1),
                    Property47 = new DateOnly(2022, 7, 1),
                    Property48 = new DateOnly(2022, 8, 1),
                    Property49 = new DateOnly(2022, 9, 1),
                    Property50 = new DateOnly(2022, 10, 1),
                    Property51 = Guid.NewGuid(),
                    Property52 = Guid.NewGuid(),
                    Property53 = Guid.NewGuid(),
                    Property54 = Guid.NewGuid(),
                    Property55 = Guid.NewGuid(),
                    Property56 = Guid.NewGuid(),
                    Property57 = Guid.NewGuid(),
                    Property58 = Guid.NewGuid(),
                    Property59 = Guid.NewGuid(),
                    Property60 = Guid.NewGuid(),
                };
                superEntitys.Add(storageRack);
            }
            return superEntitys;
        }
    }
}
