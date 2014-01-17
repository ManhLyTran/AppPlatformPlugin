using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Group
    {
        [Key]
        [Required]
        [DisplayName("����ID")]
        public int Group_ID { get; set; }//����
        [Required]
        [DisplayName("��������")]
        public string Group_Name { get; set; }
        [DisplayName("��������")]
        public string Group_Desc { get; set; }
        [DisplayName("��ע")]
        public string Group_Note { get; set; }

        public ICollection<User_Group> User_Groups { get; set; }//��������

        public ICollection<Group_Function> Group_Function { get; set; }
    }
}
