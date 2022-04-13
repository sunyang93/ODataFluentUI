using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 物料
    /// </summary>
    [Comment("物料")]
    [Index(nameof(MaterialCode), IsUnique = true)]
   
    public class Material : BaseEntity
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        [Comment("主键Id")]
        public int MaterialId { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        [Required]
        [MaxLength(50)]
        [Comment("物料编码")]
        public string MaterialCode { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Comment("物料名称")]
        public string MaterialName { get; set; }

        /// <summary>
        /// 物料规格
        /// </summary>
        [MaxLength(200)]
        [Comment("物料规格")]
        public string MaterialSpecification { get; set; }

        /// <summary>
        /// 物料型号
        /// </summary>
        [Required]
        [MaxLength(100)]
        [Comment("物料型号")]
        public string MaterialModel { get; set; }

        /// <summary>
        /// 物料分类
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        [Comment("物料分类")]
        public MaterialClassification MaterialClassification { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [Column(TypeName = "varchar(10)")]
        [Comment("计量单位")]
        public Unit Unit { get; set; }
    }

    /// <summary>
    /// 物料分类
    /// </summary>
    public enum MaterialClassification
    {
        /// <summary>
        /// 原料
        /// </summary>
        Raw=1,
        /// <summary>
        /// 辅料
        /// </summary>
        Accessories
    }

    /// <summary>
    /// 计量单位
    /// </summary>
    public enum Unit { 
        /// <summary>
        /// 千克
        /// </summary>
        KG=1,
        /// <summary>
        /// 米
        /// </summary>
        M,
        /// <summary>
        /// 包
        /// </summary>
        PKG,
        /// <summary>
        /// 个
        /// </summary>
        PCS
    }


}
