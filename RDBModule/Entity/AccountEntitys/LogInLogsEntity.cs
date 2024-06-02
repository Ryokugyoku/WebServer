using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WebServer.DBModule.Entity.AccountEntitys
{
    public class LogInLogsEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// 「0」の時はログイン
        /// 「1」の時はログアウト
        /// </summary>
        [Required]
        public byte LoginStatus {  get; set; }

        /// <summary>
        /// ログの日時が登録されている
        /// </summary>
        [Required]
        public DateTime LoginDate {  get; set; }

        [Required]
        public OsType LoginOs {  get; set; }

        [Required]
        public BrowserType LoginBrowser { get; set; }

        [Required]
        [ForeignKey("AccountId")]
        public AccountInfoEntity? AccountInfoEntity { get; set; }

    }

    public enum OsType
    {
        MacOs = 1,
        IOs = 2,
        Android = 3,
        Windows = 4,
        Others = 5,
    }

    public enum BrowserType
    {
        Edge = 1,
        Chrome = 2,
        Safari = 3,
        Firefox = 4,
        Others = 5
    }
}
