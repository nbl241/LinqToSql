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
    
    public partial class PurchaseOrderLines
    {
        public int PurchaseOrderLineID { get; set; }
        public int PurchaseOrderID { get; set; }
        public int StockItemID { get; set; }
        public int OrderedOuters { get; set; }
        public string Description { get; set; }
        public int ReceivedOuters { get; set; }
        public int PackageTypeID { get; set; }
        public Nullable<decimal> ExpectedUnitPricePerOuter { get; set; }
        public Nullable<System.DateTime> LastReceiptDate { get; set; }
        public bool IsOrderLineFinalized { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }
    
        public virtual People People { get; set; }
        public virtual PackageTypes PackageTypes { get; set; }
        public virtual PurchaseOrders PurchaseOrders { get; set; }
        public virtual StockItems StockItems { get; set; }
    }
}