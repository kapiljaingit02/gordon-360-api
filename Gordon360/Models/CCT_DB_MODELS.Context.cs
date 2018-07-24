﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Gordon360.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class CCTEntities1 : DbContext
{
    public CCTEntities1()
        : base("name=CCTEntities1")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<ACT_INFO> ACT_INFO { get; set; }

    public virtual DbSet<ADMIN> ADMIN { get; set; }

    public virtual DbSet<CUSTOM_PROFILE> CUSTOM_PROFILE { get; set; }

    public virtual DbSet<JNZB_ACTIVITIES> JNZB_ACTIVITIES { get; set; }

    public virtual DbSet<MEMBERSHIP> MEMBERSHIP { get; set; }

    public virtual DbSet<REQUEST> REQUEST { get; set; }

    public virtual DbSet<C360_SLIDER> C360_SLIDER { get; set; }

    public virtual DbSet<ACCOUNT> ACCOUNT { get; set; }

    public virtual DbSet<Alumni> Alumni { get; set; }

    public virtual DbSet<ChapelEvent> ChapelEvent { get; set; }

    public virtual DbSet<CM_SESSION_MSTR> CM_SESSION_MSTR { get; set; }

    public virtual DbSet<FacStaff> FacStaff { get; set; }

    public virtual DbSet<JENZ_ACT_CLUB_DEF> JENZ_ACT_CLUB_DEF { get; set; }

    public virtual DbSet<PART_DEF> PART_DEF { get; set; }

    public virtual DbSet<Student> Student { get; set; }

    public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

    public virtual DbSet<Dining_Meal_Choice_Desc> Dining_Meal_Choice_Desc { get; set; }

    public virtual DbSet<Dining_Student_Meal_Choice> Dining_Student_Meal_Choice { get; set; }


    public virtual ObjectResult<ACTIVE_CLUBS_PER_SESS_ID_Result> ACTIVE_CLUBS_PER_SESS_ID(string sESS_CDE)
    {

        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACTIVE_CLUBS_PER_SESS_ID_Result>("ACTIVE_CLUBS_PER_SESS_ID", sESS_CDEParameter);
    }


    public virtual ObjectResult<ALL_MEMBERSHIPS_Result> ALL_MEMBERSHIPS()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_MEMBERSHIPS_Result>("ALL_MEMBERSHIPS");
    }


    public virtual ObjectResult<ALL_REQUESTS_Result> ALL_REQUESTS()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_REQUESTS_Result>("ALL_REQUESTS");
    }


    public virtual ObjectResult<ALL_SUPERVISORS_Result> ALL_SUPERVISORS()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_SUPERVISORS_Result>("ALL_SUPERVISORS");
    }


    public virtual ObjectResult<LEADER_MEMBERSHIPS_PER_ACT_CDE_Result> LEADER_MEMBERSHIPS_PER_ACT_CDE(string aCT_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LEADER_MEMBERSHIPS_PER_ACT_CDE_Result>("LEADER_MEMBERSHIPS_PER_ACT_CDE", aCT_CDEParameter);
    }


    public virtual ObjectResult<MEMBERSHIPS_PER_ACT_CDE_Result> MEMBERSHIPS_PER_ACT_CDE(string aCT_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MEMBERSHIPS_PER_ACT_CDE_Result>("MEMBERSHIPS_PER_ACT_CDE", aCT_CDEParameter);
    }


    public virtual ObjectResult<MEMBERSHIPS_PER_MEMBERSHIP_ID_Result> MEMBERSHIPS_PER_MEMBERSHIP_ID(Nullable<int> mEMBERSHIP_ID)
    {

        var mEMBERSHIP_IDParameter = mEMBERSHIP_ID.HasValue ?
            new ObjectParameter("MEMBERSHIP_ID", mEMBERSHIP_ID) :
            new ObjectParameter("MEMBERSHIP_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MEMBERSHIPS_PER_MEMBERSHIP_ID_Result>("MEMBERSHIPS_PER_MEMBERSHIP_ID", mEMBERSHIP_IDParameter);
    }


    public virtual ObjectResult<MEMBERSHIPS_PER_STUDENT_ID_Result> MEMBERSHIPS_PER_STUDENT_ID(Nullable<int> sTUDENT_ID)
    {

        var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
            new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
            new ObjectParameter("STUDENT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MEMBERSHIPS_PER_STUDENT_ID_Result>("MEMBERSHIPS_PER_STUDENT_ID", sTUDENT_IDParameter);
    }


    public virtual ObjectResult<REQUEST_PER_REQUEST_ID_Result> REQUEST_PER_REQUEST_ID(Nullable<int> rEQUEST_ID)
    {

        var rEQUEST_IDParameter = rEQUEST_ID.HasValue ?
            new ObjectParameter("REQUEST_ID", rEQUEST_ID) :
            new ObjectParameter("REQUEST_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUEST_PER_REQUEST_ID_Result>("REQUEST_PER_REQUEST_ID", rEQUEST_IDParameter);
    }


    public virtual ObjectResult<REQUESTS_PER_ACT_CDE_Result> REQUESTS_PER_ACT_CDE(string aCT_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUESTS_PER_ACT_CDE_Result>("REQUESTS_PER_ACT_CDE", aCT_CDEParameter);
    }


    public virtual ObjectResult<REQUESTS_PER_STUDENT_ID_Result> REQUESTS_PER_STUDENT_ID(Nullable<int> sTUDENT_ID)
    {

        var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
            new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
            new ObjectParameter("STUDENT_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUESTS_PER_STUDENT_ID_Result>("REQUESTS_PER_STUDENT_ID", sTUDENT_IDParameter);
    }


    public virtual ObjectResult<SUPERVISOR_PER_SUP_ID_Result> SUPERVISOR_PER_SUP_ID(Nullable<int> sUP_ID)
    {

        var sUP_IDParameter = sUP_ID.HasValue ?
            new ObjectParameter("SUP_ID", sUP_ID) :
            new ObjectParameter("SUP_ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUPERVISOR_PER_SUP_ID_Result>("SUPERVISOR_PER_SUP_ID", sUP_IDParameter);
    }


    public virtual ObjectResult<SUPERVISORS_PER_ACT_CDE_Result> SUPERVISORS_PER_ACT_CDE(string aCT_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SUPERVISORS_PER_ACT_CDE_Result>("SUPERVISORS_PER_ACT_CDE", aCT_CDEParameter);
    }


    public virtual ObjectResult<EMAILS_PER_ACT_CDE_Result> EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EMAILS_PER_ACT_CDE_Result>("EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
    }


    public virtual ObjectResult<LEADER_EMAILS_PER_ACT_CDE_Result> LEADER_EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LEADER_EMAILS_PER_ACT_CDE_Result>("LEADER_EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
    }


    public virtual int SUPERVISORS_PER_ID_NUM(Nullable<int> iD_NUM)
    {

        var iD_NUMParameter = iD_NUM.HasValue ?
            new ObjectParameter("ID_NUM", iD_NUM) :
            new ObjectParameter("ID_NUM", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUPERVISORS_PER_ID_NUM", iD_NUMParameter);
    }


    public virtual int UPDATE_ACT_CLUB_DEF()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_ACT_CLUB_DEF");
    }


    public virtual int UPDATE_ACT_INFO()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_ACT_INFO");
    }


    public virtual int UPDATE_JNZB_ACTIVITIES()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_JNZB_ACTIVITIES");
    }


    public virtual ObjectResult<ADVISOR_EMAILS_PER_ACT_CDE_Result> ADVISOR_EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ADVISOR_EMAILS_PER_ACT_CDE_Result>("ADVISOR_EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
    }


    public virtual ObjectResult<DISTINCT_ACT_TYPE_Result> DISTINCT_ACT_TYPE(string sESS_CDE)
    {

        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DISTINCT_ACT_TYPE_Result>("DISTINCT_ACT_TYPE", sESS_CDEParameter);
    }


    public virtual ObjectResult<string> CURRENT_SESSION()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("CURRENT_SESSION");
    }


    public virtual ObjectResult<GRP_ADMIN_EMAILS_PER_ACT_CDE_Result> GRP_ADMIN_EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GRP_ADMIN_EMAILS_PER_ACT_CDE_Result>("GRP_ADMIN_EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
    }


    public virtual ObjectResult<ALL_EVENTS_PER_STUDENT_Result> ALL_EVENTS_PER_STUDENT(string sTU_ID, string tERM)
    {

        var sTU_IDParameter = sTU_ID != null ?
            new ObjectParameter("STU_ID", sTU_ID) :
            new ObjectParameter("STU_ID", typeof(string));


        var tERMParameter = tERM != null ?
            new ObjectParameter("TERM", tERM) :
            new ObjectParameter("TERM", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_EVENTS_PER_STUDENT_Result>("ALL_EVENTS_PER_STUDENT", sTU_IDParameter, tERMParameter);
    }


    public virtual ObjectResult<EVENTS_BY_STUDENT_ID_Result> EVENTS_BY_STUDENT_ID(string sTU_USERNAME)
    {

        var sTU_USERNAMEParameter = sTU_USERNAME != null ?
            new ObjectParameter("STU_USERNAME", sTU_USERNAME) :
            new ObjectParameter("STU_USERNAME", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EVENTS_BY_STUDENT_ID_Result>("EVENTS_BY_STUDENT_ID", sTU_USERNAMEParameter);
    }


    public virtual ObjectResult<Nullable<int>> TOTAL_CREDITS_PER_STUDENT(string sTU_ID, string tERM)
    {

        var sTU_IDParameter = sTU_ID != null ?
            new ObjectParameter("STU_ID", sTU_ID) :
            new ObjectParameter("STU_ID", typeof(string));


        var tERMParameter = tERM != null ?
            new ObjectParameter("TERM", tERM) :
            new ObjectParameter("TERM", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TOTAL_CREDITS_PER_STUDENT", sTU_IDParameter, tERMParameter);
    }


    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }


    public virtual int sp_upgraddiagrams()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }


    public virtual ObjectResult<STUDENT_EVENTS_PER_TERM_Result> STUDENT_EVENTS_PER_TERM(string sTU_ID, string tERM)
    {

        var sTU_IDParameter = sTU_ID != null ?
            new ObjectParameter("STU_ID", sTU_ID) :
            new ObjectParameter("STU_ID", typeof(string));


        var tERMParameter = tERM != null ?
            new ObjectParameter("TERM", tERM) :
            new ObjectParameter("TERM", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STUDENT_EVENTS_PER_TERM_Result>("STUDENT_EVENTS_PER_TERM", sTU_IDParameter, tERMParameter);
    }


    public virtual ObjectResult<PHOTO_INFO_PER_USER_NAME_Result> PHOTO_INFO_PER_USER_NAME(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHOTO_INFO_PER_USER_NAME_Result>("PHOTO_INFO_PER_USER_NAME", iDParameter);
    }


    public virtual int UPDATE_PHOTO_PATH(Nullable<int> iD, string fILE_PATH, string fILE_NAME)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var fILE_PATHParameter = fILE_PATH != null ?
            new ObjectParameter("FILE_PATH", fILE_PATH) :
            new ObjectParameter("FILE_PATH", typeof(string));


        var fILE_NAMEParameter = fILE_NAME != null ?
            new ObjectParameter("FILE_NAME", fILE_NAME) :
            new ObjectParameter("FILE_NAME", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_PHOTO_PATH", iDParameter, fILE_PATHParameter, fILE_NAMEParameter);
    }


    public virtual int CREATE_SOCIAL_LINKS(string uSERNAME, string fACEBOOK, string tWITTER, string iNSTAGRAM, string lINKEDIN)
    {

        var uSERNAMEParameter = uSERNAME != null ?
            new ObjectParameter("USERNAME", uSERNAME) :
            new ObjectParameter("USERNAME", typeof(string));


        var fACEBOOKParameter = fACEBOOK != null ?
            new ObjectParameter("FACEBOOK", fACEBOOK) :
            new ObjectParameter("FACEBOOK", typeof(string));


        var tWITTERParameter = tWITTER != null ?
            new ObjectParameter("TWITTER", tWITTER) :
            new ObjectParameter("TWITTER", typeof(string));


        var iNSTAGRAMParameter = iNSTAGRAM != null ?
            new ObjectParameter("INSTAGRAM", iNSTAGRAM) :
            new ObjectParameter("INSTAGRAM", typeof(string));


        var lINKEDINParameter = lINKEDIN != null ?
            new ObjectParameter("LINKEDIN", lINKEDIN) :
            new ObjectParameter("LINKEDIN", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATE_SOCIAL_LINKS", uSERNAMEParameter, fACEBOOKParameter, tWITTERParameter, iNSTAGRAMParameter, lINKEDINParameter);
    }


    public virtual ObjectResult<MEMBERSHIPS_PER_ACT_CDE_AUTHORIZED_Result> MEMBERSHIPS_PER_ACT_CDE_AUTHORIZED(string aCT_CDE, Nullable<bool> aUTHORIZED)
    {

        var aCT_CDEParameter = aCT_CDE != null ?
            new ObjectParameter("ACT_CDE", aCT_CDE) :
            new ObjectParameter("ACT_CDE", typeof(string));


        var aUTHORIZEDParameter = aUTHORIZED.HasValue ?
            new ObjectParameter("AUTHORIZED", aUTHORIZED) :
            new ObjectParameter("AUTHORIZED", typeof(bool));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MEMBERSHIPS_PER_ACT_CDE_AUTHORIZED_Result>("MEMBERSHIPS_PER_ACT_CDE_AUTHORIZED", aCT_CDEParameter, aUTHORIZEDParameter);
    }


    public virtual int UPDATE_PHONE_PRIVACY(Nullable<int> iD, string vALUE)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var vALUEParameter = vALUE != null ?
            new ObjectParameter("VALUE", vALUE) :
            new ObjectParameter("VALUE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_PHONE_PRIVACY", iDParameter, vALUEParameter);
    }


    public virtual int UPDATE_SHOW_PIC(Nullable<int> aCCOUNT_ID, string vALUE)
    {

        var aCCOUNT_IDParameter = aCCOUNT_ID.HasValue ?
            new ObjectParameter("ACCOUNT_ID", aCCOUNT_ID) :
            new ObjectParameter("ACCOUNT_ID", typeof(int));


        var vALUEParameter = vALUE != null ?
            new ObjectParameter("VALUE", vALUE) :
            new ObjectParameter("VALUE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_SHOW_PIC", aCCOUNT_IDParameter, vALUEParameter);
    }


    public virtual ObjectResult<ALL_BASIC_INFO_Result> ALL_BASIC_INFO()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_BASIC_INFO_Result>("ALL_BASIC_INFO");
    }


    public virtual int DINING_INFO_BY_STUDENT_ID(Nullable<int> sTUDENT_ID, string sESS_CDE)
    {

        var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
            new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
            new ObjectParameter("STUDENT_ID", typeof(int));


        var sESS_CDEParameter = sESS_CDE != null ?
            new ObjectParameter("SESS_CDE", sESS_CDE) :
            new ObjectParameter("SESS_CDE", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DINING_INFO_BY_STUDENT_ID", sTUDENT_IDParameter, sESS_CDEParameter);
    }

}

}

