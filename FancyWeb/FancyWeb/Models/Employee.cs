//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FancyWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public byte[] EmployeePassword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GUID { get; set; }
        public string VerificationCode { get; set; }
        public bool Gender { get; set; }
        public int RegionID { get; set; }
        public string Address { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public string TaxID { get; set; }
        public bool Admin { get; set; }
        public Nullable<int> PhotoID { get; set; }
        public bool Enabled { get; set; }
        public int RoleID { get; set; }
    
        public virtual Photo Photo { get; set; }
        public virtual Role Role { get; set; }
        public virtual Region Region { get; set; }
    }
}
