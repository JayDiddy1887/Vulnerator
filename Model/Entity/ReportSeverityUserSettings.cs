using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vulnerator.Model.Entity
{
    public class ReportSeverityUserSettings : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReportSeverityUserSettings()
        { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ReportSeverityUserSettings_ID { get; set; }
        
        [Required]
        public long RequiredReport_ID { get; set; }
        
        [Required]
        public virtual RequiredReport RequiredReport { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string ReportCatI { get; set; }
        
        [Required]
        [StringLength(50)]
        public string ReportCatII { get; set; }
        
        [Required]
        [StringLength(50)]
        public string ReportCatIII { get; set; }
        
        [Required]
        [StringLength(50)]
        public string ReportCatIV { get; set; }
    }
}