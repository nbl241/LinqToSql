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
    
    public partial class Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customers()
        {
            this.Customers1 = new HashSet<Customers>();
            this.CustomerTransactions = new HashSet<CustomerTransactions>();
            this.Invoices = new HashSet<Invoices>();
            this.Invoices1 = new HashSet<Invoices>();
            this.Orders = new HashSet<Orders>();
            this.SpecialDeals = new HashSet<SpecialDeals>();
            this.StockItemTransactions = new HashSet<StockItemTransactions>();
        }
    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int BillToCustomerID { get; set; }
        public int CustomerCategoryID { get; set; }
        public Nullable<int> BuyingGroupID { get; set; }
        public int PrimaryContactPersonID { get; set; }
        public Nullable<int> AlternateContactPersonID { get; set; }
        public int DeliveryMethodID { get; set; }
        public int DeliveryCityID { get; set; }
        public int PostalCityID { get; set; }
        public Nullable<decimal> CreditLimit { get; set; }
        public System.DateTime AccountOpenedDate { get; set; }
        public decimal StandardDiscountPercentage { get; set; }
        public bool IsStatementSent { get; set; }
        public bool IsOnCreditHold { get; set; }
        public int PaymentDays { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string DeliveryRun { get; set; }
        public string RunPosition { get; set; }
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
    
        public virtual Cities Cities { get; set; }
        public virtual Cities Cities1 { get; set; }
        public virtual DeliveryMethods DeliveryMethods { get; set; }
        public virtual People People { get; set; }
        public virtual People People1 { get; set; }
        public virtual People People2 { get; set; }
        public virtual BuyingGroups BuyingGroups { get; set; }
        public virtual CustomerCategories CustomerCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers1 { get; set; }
        public virtual Customers Customers2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTransactions> CustomerTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoices> Invoices1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpecialDeals> SpecialDeals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockItemTransactions> StockItemTransactions { get; set; }
    }
}
