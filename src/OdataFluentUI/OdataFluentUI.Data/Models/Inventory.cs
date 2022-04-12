using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 库存
    /// </summary>
    public class Inventory : BaseEntity
    {
        /// <summary>
        /// 物料Id
        /// </summary>
        [Key]
        public int MaterialId { get; set; }

        /// <summary>
        /// 物料
        /// </summary>
        public Material Material { get; set; }

        /// <summary>
        /// 批次
        /// </summary>
        [Key]
        [MaxLength(50)]
        public string Batch { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public ulong Number { get; set; }
    }
}
