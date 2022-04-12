using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdataFluentUI.Data
{
    /// <summary>
    /// 物料
    /// </summary>
    [Index(nameof(MaterialCode), IsUnique = true)]
    public class Material
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int MaterialId { get; set; }

        /// <summary>
        /// 物料编码
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string MaterialCode { get; set; }

        /// <summary>
        /// 物料名称
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string MaterialName { get; set; }

        /// <summary>
        /// 物料规格
        /// </summary>
        [MaxLength(200)]
        public string MaterialSpecification { get; set; }

        /// <summary>
        /// 物料型号
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string MaterialModel { get; set; }

        /// <summary>
        /// 物料分类
        /// </summary>
        [Column(TypeName = "varchar(20)")]
        public MaterialClassification MaterialClassification { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [Column(TypeName = "varchar(10)")]
        public Unit Unit { get; set; }

        /// <summary>
        /// 可用状态
        /// </summary>
        [DefaultValue(true)]
        public bool IsAvailable { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
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
