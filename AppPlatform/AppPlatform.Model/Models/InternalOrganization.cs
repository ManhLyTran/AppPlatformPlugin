using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class InternalOrganization
    {
        [Key]
        [Required]
        [DisplayName("���ű��")]
        public int InternalOrganization_ID { get; set; }
        [Required]
        [DisplayName("��ҵ���")]
        public int Enterprise_ID { get; set; }
        [Required]
        [DisplayName("��������")]
        public string InternalOrganization_Name { get; set; }
        [DisplayName("����")]
        public string InternalOrganization_Desc { get; set; }
        [DisplayName("�ϼ�����")]
        public Nullable<int> InternalOrganization_PID { get; set; }
        [DisplayName("��ע")]
        public string InternalOrganization_Note { get; set; }

        public Enterprise Enterprise { get; set; }//��������
        public ICollection<User_InternalOrganization> User_InternalOrganiaztions { get; set; }//��������
    }
}
