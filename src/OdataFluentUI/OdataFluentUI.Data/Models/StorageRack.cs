using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 货架
    /// </summary>
    [Index(nameof(StorageRackCode), IsUnique = true)]
    [Comment("货架")]
    public class StorageRack : BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [Comment("主键Id")]
        public int StorageRackId { get; set; }

        /// <summary>
        /// 货架名称
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Comment("货架名称")]
        public string StorageRackName { get; set; }

        /// <summary>
        /// 货架编码
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Comment("货架编码")]
        public string StorageRackCode { get; set; }

        /// <summary>
        /// 货架规格
        /// </summary>
        [MaxLength(200)]
        [Comment("货架规格")]
        public string StorageRackSpecification { get; set; }

        /// <summary>
        /// 货架型号
        /// </summary>
        [MaxLength(100)]
        [Comment("货架型号")]
        public string StorageRackModel { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [MaxLength(500)]
        [Comment("备注")]
        public string Remark { get; set; }

        /// <summary>
        /// 货架的所有货位
        /// </summary>
        public ICollection<CargoSpace> CargoSpaces { get; set; }

        public StorageRack()
        {
            this.CargoSpaces = new HashSet<CargoSpace>();
        }
    }
}
