using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class EnterpriseClass
    {

        [Key]
        [Required]
        [DisplayName("������")]
        public int EnterpriseClass_ID { get; set; }//����
        [Required]
        [DisplayName("��������")]
        public string EnterpriseClass_Name { get; set; }

        [DisplayName("��ע")]
        public string EnterpriseClass_Option { get; set; }


        public ICollection<Enterprise_EnterpriseClass> Enterprise_EnterpriseClasses { get; set; }//��������
    }
}
