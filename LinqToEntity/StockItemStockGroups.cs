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
    
    public partial class StockItemStockGroups
    {
        public int StockItemStockGroupID { get; set; }
        public int StockItemID { get; set; }
        public int StockGroupID { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime LastEditedWhen { get; set; }
    
        public virtual People People { get; set; }
        public virtual StockGroups StockGroups { get; set; }
        public virtual StockItems StockItems { get; set; }
    }
}