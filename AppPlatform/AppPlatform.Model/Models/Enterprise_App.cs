using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class Enterprise_App
    {
        [Key]
        [Required]
        public int Enterprise_App_ID { get; set; }//����

        [Required]
        [DisplayName("Ӧ�ñ��")]
        public int App_ID { get; set; }//���

        [Required]
        [DisplayName("��ҵ���")]
        public int Enterprise_ID { get; set; }//���

        [Required]
        [DisplayName("��ҵ��ɫ")]
        public string Enterprise_App_Role { get; set; }


        public App App { get; set; } //��������
        public Enterprise Enterprise { get; set; }//��������
    }
}
