using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppPlatform.Model.Models
{
    
    public class App
  
   {
        [Key]
        [Required]
        [DisplayName("Ӧ�ñ��")]
        public int App_ID { get; set; }//����

        
        [Required]
        [DisplayName("Ӧ������")]
        public string App_Name { get; set; }

        
        [Required]
        [DisplayName("Ӧ��Logo")]
        public byte[] App_Logo { get; set; }

        [Required]
        [DisplayName("Ӧ������")]
        public string App_Description { get; set; }

        [Url]
        [Required]
        [DisplayName("Ӧ�õ�ַ")]
        public string App_url { get; set; }

        [Required]
        [DisplayName("�������")]
        public long App_BrowseNum { get; set; }

        [Required]
        [DisplayName("���ش���")]
        public long App_DownNum { get; set; }

        [Required]
        [DisplayName("Ӧ�ý���")]
        public byte[] App_Gragh { get; set; }

        [Required]
        [DisplayName("�ϴ�ʱ��")]
        
        public System.DateTime AppUpdate_Time { get; set; }

        [Required]
        [DisplayName("״̬")]
        public bool App_State { get; set; }

        [DisplayName("��ע")]
        public string App_Option { get; set; }

        public ICollection<App_AppClass> App_AppClasses { get; set; }//��������
        public ICollection<App_Role> App_Roles { get; set; } //��������
        public ICollection<Internal_Authorization> Internal_Authorizations { get; set; } //��������
        public ICollection<Enterprise_App> Enterprise_Apps { get; set; } //��������

       
    }
}
