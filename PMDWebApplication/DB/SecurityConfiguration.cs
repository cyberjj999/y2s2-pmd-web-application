//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMDWebApplication.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SecurityConfiguration
    {
        public int Id { get; set; }
        public int Password_Length { get; set; }
        public bool RequireNonLetterOrDigit { get; set; }
        public bool RequireDigit { get; set; }
        public bool RequireLowercase { get; set; }
        public bool RequireUppercase { get; set; }
        public int Password_Attempts { get; set; }
        public int LockoutDuration { get; set; }
        public int InactiveDuration { get; set; }
        public int PasswordExpiry { get; set; }
    }
}
