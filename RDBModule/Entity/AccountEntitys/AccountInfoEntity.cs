using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebServer.DBModule.Entity.AccountEntitys
{
    /// <summary>
    /// アカウント管理用テーブル
    /// </summary>
    [Table("AccountInfo")]
    public class AccountInfoEntity
    {
        /// <summary>
        /// アカウントを一意に特定するためのID
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AccountId { get; set; }

        [Required]
        [MaxLength(50)]
        public int Name { get; set; }

        [Required]
        [MaxLength(50)]
        public int AlphabetName { get; set; }

        [Required]
        [MaxLength(255)]
        public string? EmailAddress { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Password { get; set; }
    }
}
