using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Role
    {
        [Key]
        [Required]
        [DisplayName("��ɫ���")]
        public int Role_ID { get; set; }
        [Required]
        [DisplayName("��ҵ���")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("��ɫ����")]
        public string Role_Name { get; set; }
        [DisplayName("��ɫ����")]
        public string Role_Description { get; set; }
        [DisplayName("��ɫ��ע")]
        public string Role_Option { get; set; }

        public Enterprise Enterprise { get; set; }//��������
        public ICollection<User_Role> User_Roles { get; set; }//��������
        public ICollection<App_Role> App_Roles { get; set; }//��������
    }
}
