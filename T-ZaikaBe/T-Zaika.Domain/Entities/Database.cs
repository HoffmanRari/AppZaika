using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Domain.Entities
{
    public class T_USER : EntityBase
    {
       
        public string USER_NAME { set; get; }
        public string FULL_NAME { set; get; }
        public string USER_PASSWORD { set; get; }
        public string USER_EMAIL { set; get; }

        public string PHONE_NUMBER { set; get; }
        public DateTime USER_CREATION_DATE { set; get; }
        public DateTime? USER_UPDATE_DATE { set; get; }
        public Boolean USER_STATUS { set; get; }

        public virtual ICollection<T_USER_ROLES> T_USER_ROLES { get; set; }
        public T_USER()
        {
            T_USER_ROLES = new List<T_USER_ROLES>();
        }
    }


    public class T_USER_ROLES : EntityBase
    {
        public DateTime DATE_ASSIGNATION { get; set; }
        public long? USER_ID { get; set; }
        public virtual T_USER T_USER { get; set; }
        
        public long? ROLE_ID { get; set; }
        public virtual T_ROLES T_ROLES { get; set; }
    }
    public class T_ROLES : EntityBase
    {
        public string ROLE_NAME { set; get; }
        public virtual ICollection<T_USER_ROLES> T_USER_ROLES { get; set; }
        public virtual ICollection<T_ROLE_SECURITIES> T_ROLE_SECURITIES { get; set; }
        public T_ROLES()
        {
            T_ROLE_SECURITIES = new List<T_ROLE_SECURITIES>();
            T_USER_ROLES = new List<T_USER_ROLES>();
        }
    }

    public class T_SECURITY : EntityBase
    {
        public string SECURITY_NAME { set; get; }
        public virtual ICollection<T_ROLE_SECURITIES> T_ROLE_SECURITIES { get; set; }
        public T_SECURITY()
        {
            T_ROLE_SECURITIES = new List<T_ROLE_SECURITIES>();
        }
    }

    public class T_ROLE_SECURITIES : EntityBase
    {

        public DateTime ASSIGNATION_DATE { get; set; }
        public long? SECURITY_ID { get; set; }
        public virtual T_SECURITY T_SECURITY { get; set; }
        public long? ROLE_ID { get; set; }
        public virtual T_ROLES T_ROLES { get; set; }

    }

    public class T_ZAIKABE_MEMBERS : EntityBase
    {
        public string FIRST_NAME { set; get; }
        public string LAST_NAME { set; get; }
        public int PHONE { set; get; }

        public DateTime CREATION_DATE { set; get; }

        public long? PARISH_ID { get; set; }
        public virtual T_PARISHS T_PARISHS { get; set; }

        public long? GROUP_ID { get; set; }
        public virtual T_MEMBER_GROUPS T_MEMBER_GROUPS { get; set; }

        public long? RESPONSABILITY_ID { get; set; }
        public virtual T_MEMBER_RESPONSABILITIES T_MEMBER_RESPONSABILITIES { get; set; }

        public virtual ICollection<T_EXPENSE_MANAGEMENTS> T_EXPENSE_MANAGEMENT { get; set; }

        public virtual ICollection<T_USER_ASSIGN_PROGRAMMS> T_USER_ASSIGN_PROGRAMMS { get; set; }

        public virtual ICollection<T_MEMBER_PLACES> T_MEMBER_PLACES { get; set; }

        public virtual ICollection<T_CONTRIBUTIONS> T_CONTRIBUTIONS { get; set; }

        public T_ZAIKABE_MEMBERS()
        {
            T_EXPENSE_MANAGEMENT = new List<T_EXPENSE_MANAGEMENTS>();
            T_USER_ASSIGN_PROGRAMMS = new List<T_USER_ASSIGN_PROGRAMMS>();
            T_MEMBER_PLACES = new List<T_MEMBER_PLACES>();
            T_CONTRIBUTIONS = new List<T_CONTRIBUTIONS>();
        }

    }

    public class T_PARISHS : EntityBase
    {
        public string PARISH_NAME { set; get; }
        public long? DISTRICT_ID { get; set; }
        public virtual T_DISTRICTS T_DISTRICTS { get; set; }
        public virtual ICollection<T_ZAIKABE_MEMBERS> T_ZAIKABE_MEMBERS { get; set; }

        public T_PARISHS()
        {
            T_ZAIKABE_MEMBERS = new List<T_ZAIKABE_MEMBERS>();
        }
    }

    public class T_DISTRICTS : EntityBase
    {
        public string DISTRICT_NAME { set; get; }

        public virtual ICollection<T_PARISHS> T_PARISHS { get; set; }

        public T_DISTRICTS()
        {
            T_PARISHS = new List<T_PARISHS>();
        }
    }

    public class T_MEMBER_RESPONSABILITIES : EntityBase
    {
        public string RESPONSABILITY_NAME { set; get; }

        public virtual ICollection<T_ZAIKABE_MEMBERS> T_ZAIKABE_MEMBERS { get; set; }

        public T_MEMBER_RESPONSABILITIES()
        {
            T_ZAIKABE_MEMBERS = new List<T_ZAIKABE_MEMBERS>();
        }
    }

    public class T_ZAIKABE_PROGRAMMES : EntityBase
    {
        public string PROGRAMME_NAME { set; get; }
        public DateTime PROGRAMME_DATE { set; get; }
        public string START_TIME { set; get; }
        public string END_TIME { set; get; }
        public string DURATION { set; get; }
        public virtual ICollection<T_USER_ASSIGN_PROGRAMMS> T_USER_ASSIGN_PROGRAMMS { get; set; }
        public T_ZAIKABE_PROGRAMMES()
        {
            T_USER_ASSIGN_PROGRAMMS = new List<T_USER_ASSIGN_PROGRAMMS>();
        }
    }


    public class T_USER_ASSIGN_PROGRAMMS : EntityBase
    {
        public DateTime DATE { get; set; }
        public long? MEMBER_ID { get; set; }
        public virtual T_ZAIKABE_MEMBERS T_ZAIKABE_MEMBERS { get; set; }

        public long? PROGRAMME_ID { get; set; }
        public virtual T_ZAIKABE_PROGRAMMES T_ZAIKABE_PROGRAMMES { get; set; }

    }
    public class T_ZAIKABE_FUNDING : EntityBase
    {
        public string DESCRIPTION { get; set; }
        public float? AMOUNT { get; set; }

        public string HELPER { get; set; }

        public DateTime FOUNDING_DATE { get; set; }
    }

    public class T_LODGMENTS : EntityBase
    {
        public string LODGMENT_NAME { get; set; }
        public int PLACE_NUMBER { get; set; }
        public int LODGMENT_CATEGORY { get; set; }

        public virtual ICollection<T_MEMBER_PLACES> T_MEMBER_PLACES { get; set; }

        public T_LODGMENTS()
        {
            T_MEMBER_PLACES = new List<T_MEMBER_PLACES>();
        }
    }

    public class T_MEMBER_PLACES : EntityBase
    {
        public DateTime ASSIGNATION_DATE { get; set; }

        public long? MEMBER_ID { get; set; }
        public virtual T_ZAIKABE_MEMBERS T_ZAIKABE_MEMBERS { get; set; }

        public long? LODGMENT_ID { get; set; }
        public virtual T_LODGMENTS T_LODGMENTS { get; set; }

    }

    public class T_CONTRIBUTIONS : EntityBase
    {
        public float AMOUNT_PAID { get; set; }
        public float REMAINING_AMOUNT { get; set; }
        public string PAYMENT_STATUS { get; set; }
        public DateTime DATE { get; set; }

        public long? MEMBER_ID { get; set; }
        public virtual T_ZAIKABE_MEMBERS T_ZAIKABE_MEMBERS { get; set; }
        public long? CONTRIBUTION_TYPE_ID { get; set; }
        public virtual T_CONTRIBUTION_TYPES T_CONTRIBUTION_TYPES { get; set; }

    }

    public class T_CONTRIBUTION_TYPES : EntityBase
    {
        public string CONTRIBUTION_TYPE_NAME { get; set; }// cotisation:paroisse, district, membres
        public float AMOUNT { get; set; }

        public virtual ICollection<T_CONTRIBUTIONS> T_CONTRIBUTIONS { get; set; }

        public T_CONTRIBUTION_TYPES()
        {
            T_CONTRIBUTIONS = new List<T_CONTRIBUTIONS>();
        }
    }

    public class T_MEMBER_GROUPS : EntityBase
    {
        public string GROUP_NAME { get; set; }
        public virtual ICollection<T_ZAIKABE_MEMBERS> T_ZAIKABE_MEMBERS { get; set; }

        public T_MEMBER_GROUPS()
        {
            T_ZAIKABE_MEMBERS = new List<T_ZAIKABE_MEMBERS>();
        }
    }

    public class T_EXPENSE_MANAGEMENTS : EntityBase
    {
        public string DESCRIPTION { get; set; }//description de la depense
        public string REASON { get; set; }//motif de la demande
        public float AMOUNT { get; set; }
        public DateTime DATE { get; set; }

        public long? MEMBER_ID { get; set; }
        public virtual T_ZAIKABE_MEMBERS T_ZAIKABE_MEMBERS { get; set; }

    }
}
