//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureBank.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class AccountDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountDetail()
        {
            this.BeneficiaryDetails = new HashSet<BeneficiaryDetail>();
            this.TransactionDetails = new HashSet<TransactionDetail>();
            this.TransactionDetails1 = new HashSet<TransactionDetail>();
        }

        [DataMember]
        public Nullable<int> CID { get; set; }
        [DataMember]
        public long AccountNumber { get; set; }
        [DataMember]
        public string Accounttype { get; set; }
        [DataMember]
        public Nullable<double> AccountBalance { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string TransactionPassword { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeneficiaryDetail> BeneficiaryDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails1 { get; set; }
    }
}
