﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AutoCareSQLSERVER : DbContext
    {
        public AutoCareSQLSERVER()
            : base("name=AutoCareSQLSERVER")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<TimKiemXe_Result> TimKiemXe(string bienSo, Nullable<int> idCongTy)
        {
            var bienSoParameter = bienSo != null ?
                new ObjectParameter("bienSo", bienSo) :
                new ObjectParameter("bienSo", typeof(string));
    
            var idCongTyParameter = idCongTy.HasValue ?
                new ObjectParameter("IdCongTy", idCongTy) :
                new ObjectParameter("IdCongTy", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemXe_Result>("TimKiemXe", bienSoParameter, idCongTyParameter);
        }
    }
}