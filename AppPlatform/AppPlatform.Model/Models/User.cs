using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class User
    {
        [Key]
        [Required]
        [DisplayName("�û�������")]
        public int User_PrimaryKey;

        [Required]
        [DisplayName("�û����")]
        public int User_ID { get; set; }
        [Required]
        [DisplayName("��ҵ���")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("����")]
        public string Password { get; set; }
        [Required]
        [DisplayName("")]
        public int User_Code { get; set; }
        [Required]
        [DisplayName("�û�����")]
        public string User_Name { get; set; }
        [Required]
        [DisplayName("")]
        public string User_Card { get; set; }
        [Required]
        [DisplayName("�û���Ƭ")]
        public byte[] User_Photo { get; set; }
        [DisplayName("�û�����")]
        public Nullable<System.DateTime> User_Birthday { get; set; }
        [Required]
        [DisplayName("�û���������")]
        public string User_Depart { get; set; }
        [Required]
        [DisplayName("�û�ְλ")]
        public string User_Position { get; set; }
        [DisplayName("")]
        public string User_Position_Des { get; set; }
        [Required]
        [DisplayName("�û��Ա�")]
        public bool User_Sex { get; set; }
        [Required]
        [Phone]
        [DisplayName("�û��ֻ���")]
        public string User_Tel { get; set; }
        [DisplayName("�û���ַ")]
        public string User_Addr { get; set; }
        [Required]
        [EmailAddress]
        [DisplayName("�û�����")]
        public string User_Email { get; set; }
        [Required]
        [DisplayName("")]
        public bool User_State { get; set; }
        [Required]
        [DisplayName("�û�����ʱ��")]
        public System.DateTime User_Create_Time { get; set; }
        [DisplayName("�û���ע")]
        public string User_Option { get; set; }

        public ICollection<User_Group> User_Groups { get; set; }//��������
        public ICollection<User_Role> User_Roles { get; set; }//��������
        public ICollection<User_InternalOrganization> User_InternalOrganizations { get; set; }//��������
        public ICollection<User_Internal_Authorization> User_Internal_Authorizations { get; set; }//��������
        public ICollection<User_Task> User_Tasks { get; set; }//��������
       
    }
}
