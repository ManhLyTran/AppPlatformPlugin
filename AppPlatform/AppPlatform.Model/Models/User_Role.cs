using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class User_Role
    {
        [Key]
        [Required]
        [DisplayName("")]
        public int User_Role_ID { get; set; }
        [Required]
        [DisplayName("��ɫ���")]
        public int RoleList_ID { get; set; }
        [Required]
        [DisplayName("�û����")]
        public int User_ID { get; set; }

        public User User { get; set; }//��������
        public Role Role { get; set; }//��������
    }
}
