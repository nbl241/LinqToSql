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
    
    public partial class StockItemTransactions
    {
        public int StockItemTransactionID { get; set; }
        public int StockItemID { get; set; }
        public int TransactionTypeID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> InvoiceID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> PurchaseOrderID { get; set; }
        public System.DateTime TransactionOccurredWhen { get; set; }
        public decimal Quantity { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }
    
        public virtual People People { get; set; }
        public virtual TransactionTypes TransactionTypes { get; set; }
        public virtual PurchaseOrders PurchaseOrders { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Customers Customers { get; set; }
        public virtual Invoices Invoices { get; set; }
        public virtual StockItems StockItems { get; set; }
    }
}
