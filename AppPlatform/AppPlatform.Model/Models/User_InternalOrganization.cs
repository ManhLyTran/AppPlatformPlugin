using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppPlatform.Model.Models
{
    public partial class User_InternalOrganization
    {
        [Key]
        [Required]
        [DisplayName("�û����ű��")]
        public int User_InternalOrganization_ID { get; set; }
        [Required]
        [DisplayName("�û����")]
        public int User_ID { get; set; }
        [Required]
        [DisplayName("���ű��")]
        public int InternalOrganization_ID { get; set; }

        public User User { get; set; }//��������
        public InternalOrganization InternalOrganization { get; set; }//��������
    }
}
