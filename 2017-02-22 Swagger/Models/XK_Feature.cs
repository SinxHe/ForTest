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
    
    public partial class XK_Feature
    {
        public int FeatureID { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureIntro { get; set; }
        public Nullable<int> Hits { get; set; }
        public int SortID { get; set; }
        public Nullable<int> PageSize { get; set; }
        public Nullable<int> TemplateID { get; set; }
        public string Template { get; set; }
        public System.DateTime AddTime { get; set; }
        public Nullable<int> AddUserID { get; set; }
        public string AddUserName { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> UpdateUserID { get; set; }
        public string UpdateUserName { get; set; }
        public Nullable<System.DateTime> ShowTime { get; set; }
        public Nullable<int> ChannelID { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> FeatureTypeID { get; set; }
        public Nullable<int> VersionID { get; set; }
        public Nullable<int> IsTemplate { get; set; }
        public Nullable<int> IsHot { get; set; }
        public Nullable<int> IsElite { get; set; }
        public Nullable<int> IsPublish { get; set; }
        public string ImageAddress { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public string SchoolName { get; set; }
        public string Keywords { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public Nullable<int> IsBoutique { get; set; }
        public Nullable<int> FeatureSource { get; set; }
    }
}
