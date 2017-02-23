//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2017_02_22_Swagger.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cl_TeacherAuth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cl_TeacherAuth()
        {
            this.R_RoleAssignByTeacherAuth_TB = new HashSet<R_RoleAssignByTeacherAuth_TB>();
            this.R_RoleAttentionByTeacherAuth_TB = new HashSet<R_RoleAttentionByTeacherAuth_TB>();
        }
    
        public int TeacherAuthID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string TrueName { get; set; }
        public int SubjectID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> GradeID { get; set; }
        public Nullable<int> VersionID { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> CityID { get; set; }
        public Nullable<int> DistrictID { get; set; }
        public Nullable<int> AuthorID { get; set; }
        public string SchoolName { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string Censor { get; set; }
        public Nullable<System.DateTime> CensorTime { get; set; }
        public System.DateTime UpdateTime { get; set; }
        public System.DateTime AddTime { get; set; }
        public Nullable<int> Status { get; set; }
        public string ReplyContent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<R_RoleAssignByTeacherAuth_TB> R_RoleAssignByTeacherAuth_TB { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<R_RoleAttentionByTeacherAuth_TB> R_RoleAttentionByTeacherAuth_TB { get; set; }
    }
}