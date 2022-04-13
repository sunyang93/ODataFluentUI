using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 库存
    /// </summary>
    [Comment("库存")]
    public class Inventory : BaseEntity
    {
        /// <summary>
        /// 物料Id
        /// </summary>
        [Key]
        [Comment("物料Id")]
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
        [Comment("批次")]
        public string Batch { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [Comment("库存数量")]
        public ulong Number { get; set; }
    }
}
