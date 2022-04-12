using System.ComponentModel.DataAnnotations;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 货位
    /// </summary>
    public class CargoSpace : BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int CargoSpaceId { get; set; }

        /// <summary>
        /// 货位编码
        /// </summary>
        [MaxLength(50)]
        public string CargoSpaceCode { get; set; }

        /// <summary>
        /// 最大可用空间
        /// </summary>
        public uint MaxAvailableSpace { get; set; }

        /// <summary>
        /// 货架Id
        /// </summary>
        public int StorageRackId { get; set; }
    }
}
