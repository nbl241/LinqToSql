﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WideWorldImportersEntities : DbContext
    {
        public WideWorldImportersEntities()
            : base("name=WideWorldImportersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<StateProvinces> StateProvinces { get; set; }
        public virtual DbSet<SystemParameters> SystemParameters { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<Formation> Formation { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<PurchaseOrderLines> PurchaseOrderLines { get; set; }
        public virtual DbSet<PurchaseOrders> PurchaseOrders { get; set; }
        public virtual DbSet<SupplierCategories> SupplierCategories { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SupplierTransactions> SupplierTransactions { get; set; }
        public virtual DbSet<BuyingGroups> BuyingGroups { get; set; }
        public virtual DbSet<CustomerCategories> CustomerCategories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomerTransactions> CustomerTransactions { get; set; }
        public virtual DbSet<InvoiceLines> InvoiceLines { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<OrderLines> OrderLines { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<SpecialDeals> SpecialDeals { get; set; }
        public virtual DbSet<ColdRoomTemperatures> ColdRoomTemperatures { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<PackageTypes> PackageTypes { get; set; }
        public virtual DbSet<StockGroups> StockGroups { get; set; }
        public virtual DbSet<StockItemHoldings> StockItemHoldings { get; set; }
        public virtual DbSet<StockItems> StockItems { get; set; }
        public virtual DbSet<StockItemStockGroups> StockItemStockGroups { get; set; }
        public virtual DbSet<StockItemTransactions> StockItemTransactions { get; set; }
        public virtual DbSet<VehicleTemperatures> VehicleTemperatures { get; set; }
        public virtual DbSet<Cities_Archive> Cities_Archive { get; set; }
        public virtual DbSet<Countries_Archive> Countries_Archive { get; set; }
        public virtual DbSet<DeliveryMethods_Archive> DeliveryMethods_Archive { get; set; }
        public virtual DbSet<PaymentMethods_Archive> PaymentMethods_Archive { get; set; }
        public virtual DbSet<People_Archive> People_Archive { get; set; }
        public virtual DbSet<StateProvinces_Archive> StateProvinces_Archive { get; set; }
        public virtual DbSet<TransactionTypes_Archive> TransactionTypes_Archive { get; set; }
        public virtual DbSet<SupplierCategories_Archive> SupplierCategories_Archive { get; set; }
        public virtual DbSet<Suppliers_Archive> Suppliers_Archive { get; set; }
        public virtual DbSet<BuyingGroups_Archive> BuyingGroups_Archive { get; set; }
        public virtual DbSet<CustomerCategories_Archive> CustomerCategories_Archive { get; set; }
        public virtual DbSet<Customers_Archive> Customers_Archive { get; set; }
        public virtual DbSet<ColdRoomTemperatures_Archive> ColdRoomTemperatures_Archive { get; set; }
        public virtual DbSet<Colors_Archive> Colors_Archive { get; set; }
        public virtual DbSet<PackageTypes_Archive> PackageTypes_Archive { get; set; }
        public virtual DbSet<StockGroups_Archive> StockGroups_Archive { get; set; }
        public virtual DbSet<StockItems_Archive> StockItems_Archive { get; set; }
        public virtual DbSet<NewCustomers> NewCustomers { get; set; }
    }
}
