using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Internal_Authorization
    {
        [Key]
        [Required]
        [DisplayName("App�ڲ�Ȩ��ID")]
        public int Internal_Authorization_ID { get; set; }//����

        [Required]
        [DisplayName("Ӧ�ñ��")]
        public int App_ID { get; set; }//���

        [Required]
        [DisplayName("Ȩ������")]
        public string Internal_Authorization_Name { get; set; }

        [Required]
        [DisplayName("Ȩ������")]
        public string nternal_Authorization_Desc { get; set; }

 
        [DisplayName("��ע")]
        public string Internal_Authorization_Note { get; set; }

        public App App { get; set; }//��������
        public ICollection<User_Internal_Authorization> User_Internal_Authorizations { get; set; }//��������
    }
}
