//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suppliers_Archive
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int SupplierCategoryID { get; set; }
        public int PrimaryContactPersonID { get; set; }
        public int AlternateContactPersonID { get; set; }
        public Nullable<int> DeliveryMethodID { get; set; }
        public int DeliveryCityID { get; set; }
        public int PostalCityID { get; set; }
        public string SupplierReference { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountBranch { get; set; }
        public string BankAccountCode { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankInternationalCode { get; set; }
        public int PaymentDays { get; set; }
        public string InternalComments { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string WebsiteURL { get; set; }
        public string DeliveryAddressLine1 { get; set; }
        public string DeliveryAddressLine2 { get; set; }
        public string DeliveryPostalCode { get; set; }
        public System.Data.Entity.Spatial.DbGeography DeliveryLocation { get; set; }
        public string PostalAddressLine1 { get; set; }
        public string PostalAddressLine2 { get; set; }
        public string PostalPostalCode { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
    }
}