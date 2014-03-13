using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPlatform.Model.Models
{
    public partial class Enterprise
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [DisplayName("��ҵ������")]
        public int Enterprise_ID { get; set; }

        [Required]
        [DisplayName("��ҵ����")]
        public string Enterprise_Name { get; set; }

       
        [DisplayName("��ҵ����")]
        public string Enterprise_Rep { get; set; }

        [Required]
        [DisplayName("��ҵ�ڲ����")]
        public string Enterprise_Code { get; set; }

        
        [DisplayName("��ҵ��־ͼ��")]
        public byte[] Enterprise_Logo { get; set; }

        
        [DisplayName("��ҵ��ģ")]
        public int Enterprise_Scale { get; set; }

        
        [DisplayName("��ҵ����ʡ��")]
        public string Enterprise_Province { get; set; }

       
        [DisplayName("��ҵ���ڳ���")]
        public string Enterprise_City { get; set; }

       
        [DisplayName("��ҵ��ַ")]
        public string Enterprise_Addr { get; set; }

       
        [DisplayName("�ʱ�")]
        public string Enterprise_ZipCode { get; set; }

       
        [Phone]
        [DisplayName("��ҵ�绰 ")]
        public string Enterprise_Tel { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("��ҵ����")]
        public string Enterprise_Email { get; set; }

        [Required]
        [DisplayName("������֤")]
        public bool Checked { get; set; }

        
        [DisplayName("��ҵ����")]
        public string Enterprise_Fax { get; set; }
        [DisplayName("��ҵ�Ż�")]
        public string Enterprise_Site { get; set; }
        
        [DisplayName("��ҵ����ʱ��")]
        public Nullable<System.DateTime> EnterPrise_Create_Time { get; set; }

        [DisplayName("��ҵ����")]
        public string Enterprise_Description { get; set; }

        [DisplayName("��ҵ��ע")]
        public string Enterprise_Option { get; set; }

        public ICollection<Enterprise_EnterpriseClass> Enterprise_EnterpriseClasses { get; set; }//��������
        public ICollection<InternalOrganization>InternalOrganizations { get; set; }//��������
       
        public ICollection<Role> Roles { get; set; }//��������
        public ICollection<Enterprise_App> Enterprise_Apps { get; set; }//��������
    }
}
