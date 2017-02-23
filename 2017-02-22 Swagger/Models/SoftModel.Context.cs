﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZxxkEntities : DbContext
    {
        public ZxxkEntities()
            : base("name=ZxxkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_WeekLog> Admin_WeekLog { get; set; }
        public virtual DbSet<Area_Province> Area_Province { get; set; }
        public virtual DbSet<B_Appraise> B_Appraise { get; set; }
        public virtual DbSet<B_AppraiseReply> B_AppraiseReply { get; set; }
        public virtual DbSet<B_RecordType> B_RecordType { get; set; }
        public virtual DbSet<BJ_EliteCon> BJ_EliteCon { get; set; }
        public virtual DbSet<CID_Ana> CID_Ana { get; set; }
        public virtual DbSet<CID_AnaType> CID_AnaType { get; set; }
        public virtual DbSet<CID_ApprovalFlow> CID_ApprovalFlow { get; set; }
        public virtual DbSet<CID_ApprovalStep> CID_ApprovalStep { get; set; }
        public virtual DbSet<CID_BackType> CID_BackType { get; set; }
        public virtual DbSet<CID_CollectType> CID_CollectType { get; set; }
        public virtual DbSet<CID_ExamType> CID_ExamType { get; set; }
        public virtual DbSet<CID_FeatureType> CID_FeatureType { get; set; }
        public virtual DbSet<CID_FlowStepOper> CID_FlowStepOper { get; set; }
        public virtual DbSet<CID_FlowStepRule> CID_FlowStepRule { get; set; }
        public virtual DbSet<CID_Group> CID_Group { get; set; }
        public virtual DbSet<CID_GroupPaperType> CID_GroupPaperType { get; set; }
        public virtual DbSet<CID_Operator> CID_Operator { get; set; }
        public virtual DbSet<CID_SchoolType> CID_SchoolType { get; set; }
        public virtual DbSet<CID_ScoreType> CID_ScoreType { get; set; }
        public virtual DbSet<CID_SoftContentManage> CID_SoftContentManage { get; set; }
        public virtual DbSet<CID_SoftDataManage> CID_SoftDataManage { get; set; }
        public virtual DbSet<CID_UserIdentity> CID_UserIdentity { get; set; }
        public virtual DbSet<Cl_Admin> Cl_Admin { get; set; }
        public virtual DbSet<Cl_Announce> Cl_Announce { get; set; }
        public virtual DbSet<Cl_ApprovalInfo> Cl_ApprovalInfo { get; set; }
        public virtual DbSet<Cl_ApprovalOperInfo> Cl_ApprovalOperInfo { get; set; }
        public virtual DbSet<Cl_Article> Cl_Article { get; set; }
        public virtual DbSet<Cl_ArticleHitsLog> Cl_ArticleHitsLog { get; set; }
        public virtual DbSet<Cl_ArticleInnerLink> Cl_ArticleInnerLink { get; set; }
        public virtual DbSet<Cl_ArticleRecycleBin> Cl_ArticleRecycleBin { get; set; }
        public virtual DbSet<Cl_ArticleUnPass> Cl_ArticleUnPass { get; set; }
        public virtual DbSet<Cl_BackInfo> Cl_BackInfo { get; set; }
        public virtual DbSet<Cl_BankrollItem> Cl_BankrollItem { get; set; }
        public virtual DbSet<Cl_BigExamCollect> Cl_BigExamCollect { get; set; }
        public virtual DbSet<Cl_BigExamCollectOpinion> Cl_BigExamCollectOpinion { get; set; }
        public virtual DbSet<Cl_Channel> Cl_Channel { get; set; }
        public virtual DbSet<Cl_ChannelVersion> Cl_ChannelVersion { get; set; }
        public virtual DbSet<Cl_ChargeLog> Cl_ChargeLog { get; set; }
        public virtual DbSet<Cl_Class> Cl_Class { get; set; }
        public virtual DbSet<Cl_Collect> Cl_Collect { get; set; }
        public virtual DbSet<Cl_CollectOpinion> Cl_CollectOpinion { get; set; }
        public virtual DbSet<Cl_CollectOpinionFile> Cl_CollectOpinionFile { get; set; }
        public virtual DbSet<Cl_CollectOpinionRewardLog> Cl_CollectOpinionRewardLog { get; set; }
        public virtual DbSet<Cl_CollectRewordStatics> Cl_CollectRewordStatics { get; set; }
        public virtual DbSet<Cl_CollectUserMoods> Cl_CollectUserMoods { get; set; }
        public virtual DbSet<Cl_Comment> Cl_Comment { get; set; }
        public virtual DbSet<Cl_CommentV2> Cl_CommentV2 { get; set; }
        public virtual DbSet<Cl_DeliverItem> Cl_DeliverItem { get; set; }
        public virtual DbSet<Cl_DeliverType> Cl_DeliverType { get; set; }
        public virtual DbSet<Cl_Diary> Cl_Diary { get; set; }
        public virtual DbSet<Cl_DiaryComment> Cl_DiaryComment { get; set; }
        public virtual DbSet<Cl_DiaryCommentReply> Cl_DiaryCommentReply { get; set; }
        public virtual DbSet<Cl_DiaryPhrase> Cl_DiaryPhrase { get; set; }
        public virtual DbSet<Cl_Discuss> Cl_Discuss { get; set; }
        public virtual DbSet<Cl_DiscussLabel> Cl_DiscussLabel { get; set; }
        public virtual DbSet<Cl_DiscussPraise> Cl_DiscussPraise { get; set; }
        public virtual DbSet<Cl_DiscussReply> Cl_DiscussReply { get; set; }
        public virtual DbSet<Cl_Favorite> Cl_Favorite { get; set; }
        public virtual DbSet<Cl_GroupPapers> Cl_GroupPapers { get; set; }
        public virtual DbSet<Cl_Guest> Cl_Guest { get; set; }
        public virtual DbSet<Cl_GuestNew> Cl_GuestNew { get; set; }
        public virtual DbSet<Cl_GuestReply> Cl_GuestReply { get; set; }
        public virtual DbSet<Cl_ImgUpdate> Cl_ImgUpdate { get; set; }
        public virtual DbSet<Cl_IndexSoft> Cl_IndexSoft { get; set; }
        public virtual DbSet<Cl_Inform> Cl_Inform { get; set; }
        public virtual DbSet<Cl_Js> Cl_Js { get; set; }
        public virtual DbSet<Cl_JsSort> Cl_JsSort { get; set; }
        public virtual DbSet<Cl_Keyword> Cl_Keyword { get; set; }
        public virtual DbSet<Cl_Label> Cl_Label { get; set; }
        public virtual DbSet<Cl_LabelSort> Cl_LabelSort { get; set; }
        public virtual DbSet<Cl_LookRecord> Cl_LookRecord { get; set; }
        public virtual DbSet<Cl_MainVersion> Cl_MainVersion { get; set; }
        public virtual DbSet<Cl_Movie> Cl_Movie { get; set; }
        public virtual DbSet<Cl_Order> Cl_Order { get; set; }
        public virtual DbSet<Cl_OrderItem> Cl_OrderItem { get; set; }
        public virtual DbSet<Cl_Page> Cl_Page { get; set; }
        public virtual DbSet<Cl_PageItem> Cl_PageItem { get; set; }
        public virtual DbSet<Cl_PassIP> Cl_PassIP { get; set; }
        public virtual DbSet<Cl_Payment> Cl_Payment { get; set; }
        public virtual DbSet<Cl_Photo> Cl_Photo { get; set; }
        public virtual DbSet<Cl_PrivateAna> Cl_PrivateAna { get; set; }
        public virtual DbSet<Cl_Product> Cl_Product { get; set; }
        public virtual DbSet<Cl_ProductRecycleBin> Cl_ProductRecycleBin { get; set; }
        public virtual DbSet<Cl_QuickPayCard> Cl_QuickPayCard { get; set; }
        public virtual DbSet<Cl_RelationChapter> Cl_RelationChapter { get; set; }
        public virtual DbSet<Cl_RelationNode> Cl_RelationNode { get; set; }
        public virtual DbSet<Cl_Role> Cl_Role { get; set; }
        public virtual DbSet<Cl_ScoreInfo> Cl_ScoreInfo { get; set; }
        public virtual DbSet<Cl_SearchXmlData> Cl_SearchXmlData { get; set; }
        public virtual DbSet<Cl_Server> Cl_Server { get; set; }
        public virtual DbSet<Cl_ServerItem> Cl_ServerItem { get; set; }
        public virtual DbSet<Cl_Setup> Cl_Setup { get; set; }
        public virtual DbSet<Cl_Soft> Cl_Soft { get; set; }
        public virtual DbSet<Cl_SoftApproval> Cl_SoftApproval { get; set; }
        public virtual DbSet<Cl_SoftRecycleBin> Cl_SoftRecycleBin { get; set; }
        public virtual DbSet<Cl_SoftUnPass> Cl_SoftUnPass { get; set; }
        public virtual DbSet<Cl_SoftVideoPlayCount> Cl_SoftVideoPlayCount { get; set; }
        public virtual DbSet<Cl_SouGouSearchDataXml> Cl_SouGouSearchDataXml { get; set; }
        public virtual DbSet<Cl_Special> Cl_Special { get; set; }
        public virtual DbSet<Cl_SystemAction> Cl_SystemAction { get; set; }
        public virtual DbSet<Cl_Tag> Cl_Tag { get; set; }
        public virtual DbSet<Cl_TagCategory> Cl_TagCategory { get; set; }
        public virtual DbSet<Cl_TeacherAuth> Cl_TeacherAuth { get; set; }
        public virtual DbSet<Cl_TeacherCard> Cl_TeacherCard { get; set; }
        public virtual DbSet<Cl_TeacherCensorLog> Cl_TeacherCensorLog { get; set; }
        public virtual DbSet<Cl_UpFileLog> Cl_UpFileLog { get; set; }
        public virtual DbSet<Cl_UserCz> Cl_UserCz { get; set; }
        public virtual DbSet<Cl_UserGroup> Cl_UserGroup { get; set; }
        public virtual DbSet<Cl_UserGroupLog> Cl_UserGroupLog { get; set; }
        public virtual DbSet<Cl_UserSoftRAP> Cl_UserSoftRAP { get; set; }
        public virtual DbSet<Cl_VideoStatistic> Cl_VideoStatistic { get; set; }
        public virtual DbSet<Cl_Vote> Cl_Vote { get; set; }
        public virtual DbSet<ClD_Grade> ClD_Grade { get; set; }
        public virtual DbSet<ClD_SoftCate> ClD_SoftCate { get; set; }
        public virtual DbSet<ClD_SoftType> ClD_SoftType { get; set; }
        public virtual DbSet<ClD_TeacherRole> ClD_TeacherRole { get; set; }
        public virtual DbSet<ClD_Version> ClD_Version { get; set; }
        public virtual DbSet<CZ_Article> CZ_Article { get; set; }
        public virtual DbSet<CZ_ArticleRecycleBin> CZ_ArticleRecycleBin { get; set; }
        public virtual DbSet<CZ_ArticleUnPass> CZ_ArticleUnPass { get; set; }
        public virtual DbSet<CZ_Soft> CZ_Soft { get; set; }
        public virtual DbSet<CZ_SoftRecycleBin> CZ_SoftRecycleBin { get; set; }
        public virtual DbSet<CZ_SoftUnPass> CZ_SoftUnPass { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<GK_Subject> GK_Subject { get; set; }
        public virtual DbSet<GK_SubjectArea> GK_SubjectArea { get; set; }
        public virtual DbSet<GZ_Article> GZ_Article { get; set; }
        public virtual DbSet<GZ_ArticleRecycleBin> GZ_ArticleRecycleBin { get; set; }
        public virtual DbSet<GZ_ArticleUnPass> GZ_ArticleUnPass { get; set; }
        public virtual DbSet<GZ_Soft> GZ_Soft { get; set; }
        public virtual DbSet<GZ_SoftRecycleBin> GZ_SoftRecycleBin { get; set; }
        public virtual DbSet<GZ_SoftUnPass> GZ_SoftUnPass { get; set; }
        public virtual DbSet<HD_Raffle> HD_Raffle { get; set; }
        public virtual DbSet<HD_RaffleLog> HD_RaffleLog { get; set; }
        public virtual DbSet<LuceneTrigger_Soft_ForCMS> LuceneTrigger_Soft_ForCMS { get; set; }
        public virtual DbSet<M_Index> M_Index { get; set; }
        public virtual DbSet<MGTrigger_Article> MGTrigger_Article { get; set; }
        public virtual DbSet<MGTrigger_ArticleForMNS> MGTrigger_ArticleForMNS { get; set; }
        public virtual DbSet<MGTrigger_ArticleRecycleBinForMNS> MGTrigger_ArticleRecycleBinForMNS { get; set; }
        public virtual DbSet<MGTrigger_FeatureForMNS> MGTrigger_FeatureForMNS { get; set; }
        public virtual DbSet<MGTrigger_SoftForMNS> MGTrigger_SoftForMNS { get; set; }
        public virtual DbSet<MGTrigger_SoftRecycleBinForMNS> MGTrigger_SoftRecycleBinForMNS { get; set; }
        public virtual DbSet<MST_Class> MST_Class { get; set; }
        public virtual DbSet<MST_RClassArticle> MST_RClassArticle { get; set; }
        public virtual DbSet<MST_RClassSoft> MST_RClassSoft { get; set; }
        public virtual DbSet<MST_TeacherClass> MST_TeacherClass { get; set; }
        public virtual DbSet<oa_Categories> oa_Categories { get; set; }
        public virtual DbSet<oa_Events> oa_Events { get; set; }
        public virtual DbSet<oa_postings> oa_postings { get; set; }
        public virtual DbSet<R_ApprovalStepOperator> R_ApprovalStepOperator { get; set; }
        public virtual DbSet<R_ArticleTag> R_ArticleTag { get; set; }
        public virtual DbSet<R_CollectRelation> R_CollectRelation { get; set; }
        public virtual DbSet<R_FeatureExtension> R_FeatureExtension { get; set; }
        public virtual DbSet<R_FeatureSoft> R_FeatureSoft { get; set; }
        public virtual DbSet<R_GroupPaperSoft> R_GroupPaperSoft { get; set; }
        public virtual DbSet<R_IdentityTemplate> R_IdentityTemplate { get; set; }
        public virtual DbSet<R_RoleAssignByTeacherAuth_TB> R_RoleAssignByTeacherAuth_TB { get; set; }
        public virtual DbSet<R_RoleAttentionByTeacherAuth_TB> R_RoleAttentionByTeacherAuth_TB { get; set; }
        public virtual DbSet<R_RoleFlow> R_RoleFlow { get; set; }
        public virtual DbSet<R_RoleSoftContentManage> R_RoleSoftContentManage { get; set; }
        public virtual DbSet<R_SoftClass> R_SoftClass { get; set; }
        public virtual DbSet<R_UserChannel> R_UserChannel { get; set; }
        public virtual DbSet<R_UserChannelClass> R_UserChannelClass { get; set; }
        public virtual DbSet<R_UserGroup> R_UserGroup { get; set; }
        public virtual DbSet<R_UserRole> R_UserRole { get; set; }
        public virtual DbSet<R_UserSoftDataManage> R_UserSoftDataManage { get; set; }
        public virtual DbSet<School_Payment> School_Payment { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<XK_BaoMing> XK_BaoMing { get; set; }
        public virtual DbSet<XK_BookPayment> XK_BookPayment { get; set; }
        public virtual DbSet<XK_CDBuy> XK_CDBuy { get; set; }
        public virtual DbSet<XK_Chapter> XK_Chapter { get; set; }
        public virtual DbSet<XK_Count> XK_Count { get; set; }
        public virtual DbSet<XK_Favorite> XK_Favorite { get; set; }
        public virtual DbSet<XK_Feature> XK_Feature { get; set; }
        public virtual DbSet<XK_FeatureSort> XK_FeatureSort { get; set; }
        public virtual DbSet<XK_Node> XK_Node { get; set; }
        public virtual DbSet<XK_Proposal> XK_Proposal { get; set; }
        public virtual DbSet<XK_Question> XK_Question { get; set; }
        public virtual DbSet<XK_QuestionSort> XK_QuestionSort { get; set; }
        public virtual DbSet<XK_RMBincomePayLog> XK_RMBincomePayLog { get; set; }
        public virtual DbSet<XK_RMBincomePayUser> XK_RMBincomePayUser { get; set; }
        public virtual DbSet<XK_Subject> XK_Subject { get; set; }
        public virtual DbSet<XK_SzxPayment> XK_SzxPayment { get; set; }
        public virtual DbSet<XK_Template> XK_Template { get; set; }
        public virtual DbSet<XK_WeekStar> XK_WeekStar { get; set; }
        public virtual DbSet<XK_Whole> XK_Whole { get; set; }
        public virtual DbSet<XK_WholeSort> XK_WholeSort { get; set; }
        public virtual DbSet<XX_Article> XX_Article { get; set; }
        public virtual DbSet<XX_ArticleRecycleBin> XX_ArticleRecycleBin { get; set; }
        public virtual DbSet<XX_ArticleUnPass> XX_ArticleUnPass { get; set; }
        public virtual DbSet<XX_Soft> XX_Soft { get; set; }
        public virtual DbSet<XX_SoftRecycleBin> XX_SoftRecycleBin { get; set; }
        public virtual DbSet<XX_SoftUnPass> XX_SoftUnPass { get; set; }
        public virtual DbSet<XY_Payment> XY_Payment { get; set; }
        public virtual DbSet<ZK_Paper> ZK_Paper { get; set; }
        public virtual DbSet<ZK_PaperArea> ZK_PaperArea { get; set; }
        public virtual DbSet<ZK_PaperYear> ZK_PaperYear { get; set; }
        public virtual DbSet<ZZ_DEL_XK_School_Del> ZZ_DEL_XK_School_Del { get; set; }
        public virtual DbSet<ZZ_DEL_XK_SchoolArea_Del> ZZ_DEL_XK_SchoolArea_Del { get; set; }
        public virtual DbSet<ZZ_DEL_XK_Version> ZZ_DEL_XK_Version { get; set; }
        public virtual DbSet<A_VersionGather> A_VersionGather { get; set; }
        public virtual DbSet<Cl_Article_20170213> Cl_Article_20170213 { get; set; }
        public virtual DbSet<Cl_Class_20170213> Cl_Class_20170213 { get; set; }
        public virtual DbSet<Cl_EditUser> Cl_EditUser { get; set; }
        public virtual DbSet<Cl_Researcher> Cl_Researcher { get; set; }
        public virtual DbSet<Cl_ResearcherSoftHits> Cl_ResearcherSoftHits { get; set; }
        public virtual DbSet<Cl_Users> Cl_Users { get; set; }
        public virtual DbSet<ClD_SoftRelation> ClD_SoftRelation { get; set; }
        public virtual DbSet<M_Article_Bak_Sync> M_Article_Bak_Sync { get; set; }
        public virtual DbSet<R_FeatureSoft_bak_20160926> R_FeatureSoft_bak_20160926 { get; set; }
    }
}