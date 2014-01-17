using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class App_Role
    {
        [Key]
        [Required]
        public int App_Role_ID { get; set; }//����

        [Required]
        [DisplayName("��ɫID")]
        public int Role_ID { get; set; }//���

        [Required]
        [DisplayName("AppID")]
        public int App_ID { get; set; }//���

        [DisplayName("ʹ��Ȩ��")]
        public Nullable<bool> Use_right { get; set; }

        [DisplayName("����Ȩ��")]
        public Nullable<bool> Manage_right { get; set; }

        public Role Role { get; set; }//��������
        public App App { get; set; }//��������
    }

}
