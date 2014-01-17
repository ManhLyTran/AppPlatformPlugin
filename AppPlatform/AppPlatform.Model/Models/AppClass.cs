using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class AppClass
    {
        [Key]
        [Required]
        [DisplayName("������")]
        public int AppClass_ID { get; set; }//����

        [Required]
        [MaxLength(20)]
        [DisplayName("��������")]
        public string AppClass_Name { get; set; }

        [DisplayName("��ע")]
        public string AppClass_Note { get; set; }

        public ICollection<App_AppClass> App_AppClass { get; set; }//��������
    }
}
