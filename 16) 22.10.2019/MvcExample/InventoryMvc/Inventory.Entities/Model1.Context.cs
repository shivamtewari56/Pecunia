﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class companyEntities : DbContext
    {
        public companyEntities()
            : base("name=companyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Products { get; set; }
    
        public virtual int usp_CreateProduct(Nullable<System.Guid> productID, string productName, Nullable<decimal> unitPrice)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(System.Guid));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var unitPriceParameter = unitPrice.HasValue ?
                new ObjectParameter("UnitPrice", unitPrice) :
                new ObjectParameter("UnitPrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CreateProduct", productIDParameter, productNameParameter, unitPriceParameter);
        }
    
        public virtual int usp_DeleteProduct(Nullable<System.Guid> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DeleteProduct", productIDParameter);
        }
    
        public virtual ObjectResult<Product> usp_GetProductByProductID(Nullable<System.Guid> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("usp_GetProductByProductID", productIDParameter);
        }
    
        public virtual ObjectResult<Product> usp_GetProductByProductID(Nullable<System.Guid> productID, MergeOption mergeOption)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("usp_GetProductByProductID", mergeOption, productIDParameter);
        }
    
        public virtual ObjectResult<Product> usp_GetProducts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("usp_GetProducts");
        }
    
        public virtual ObjectResult<Product> usp_GetProducts(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Product>("usp_GetProducts", mergeOption);
        }
    
        public virtual int usp_UpdateProduct(Nullable<System.Guid> productID, string productName, Nullable<decimal> unitPrice)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(System.Guid));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var unitPriceParameter = unitPrice.HasValue ?
                new ObjectParameter("UnitPrice", unitPrice) :
                new ObjectParameter("UnitPrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_UpdateProduct", productIDParameter, productNameParameter, unitPriceParameter);
        }
    }
}
