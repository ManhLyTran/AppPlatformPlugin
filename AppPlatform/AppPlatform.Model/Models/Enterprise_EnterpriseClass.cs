using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Enterprise_EnterpriseClass
    {


        [Key]
        [Required]
        public int Enterprise_EnterpriseClass_ID { get; set; }//����

        [Required]
        [DisplayName("��ҵ���")]
        public int Enterprise_ID { get; set; }//���

        [Required]
        [DisplayName("������")]
        public int EnterpriseClass_ID { get; set; }//���


        public Enterprise Enterprise { get; set; }//��������
        public EnterpriseClass EnterpriseClass { get; set; }//��������

    }
}
