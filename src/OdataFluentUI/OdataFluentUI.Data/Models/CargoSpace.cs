using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 货位
    /// </summary>
    [Index(nameof(StorageRackId), nameof(CargoSpaceCode), IsUnique = true)]
    [Comment("货位")]
    public class CargoSpace : BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [Comment("主键Id")]
        public int CargoSpaceId { get; set; }

        /// <summary>
        /// 货位编码
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Comment("货位编码")]
        public string CargoSpaceCode { get; set; }

        /// <summary>
        /// 最大可用空间
        /// </summary>
        [Comment("最大可用空间")]
        public uint MaxAvailableSpace { get; set; }

        /// <summary>
        /// 货架Id
        /// </summary>
        [Comment("货架Id")]
        public int StorageRackId { get; set; }

        /// <summary>
        /// 货架
        /// </summary>
        public StorageRack StorageRack { get; set; }    
    }
}
