using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class User_Group
    {
        [Key]
        [Required]
        [DisplayName("�û�����ID")]
        public int User_Group_ID { get; set; }
        [Required]
        [DisplayName("����ID")]
        public int Group_ID { get; set; }
        [Required]
        [DisplayName("�û�ID")]
        public int User_ID { get; set; }

        public User User { get; set; }//��������
        public Group Group { get; set; }//��������
    }
}
