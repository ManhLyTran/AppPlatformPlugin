using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPlatform.Model.Models
{
    public partial class App_AppClass
    {

        [Key]
        [Required]
        [DisplayName("Ӧ�÷�����")]
        public int App_AppClass_ID { get; set; }//����

        [Required]
        [DisplayName("Ӧ�ñ��")]
        public int App_ID { get; set; } //���

        [Required]
        [DisplayName("������")]
        public int AppClass_ID { get; set; }//���

        public App App { get; set; }//��������
        public AppClass AppClass { get; set; }//��������
    }
}
