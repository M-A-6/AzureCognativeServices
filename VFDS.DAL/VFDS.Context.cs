﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VFDS.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class VFDSEntities : DbContext
    {
        public VFDSEntities()
            : base("name=VFDSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MetaData> MetaDatas { get; set; }
    
        public virtual ObjectResult<spGetPosts_Result> spGetPosts(Nullable<int> displayLength, Nullable<int> displayStart, Nullable<int> sortCol, string sortDir, string search)
        {
            var displayLengthParameter = displayLength.HasValue ?
                new ObjectParameter("DisplayLength", displayLength) :
                new ObjectParameter("DisplayLength", typeof(int));
    
            var displayStartParameter = displayStart.HasValue ?
                new ObjectParameter("DisplayStart", displayStart) :
                new ObjectParameter("DisplayStart", typeof(int));
    
            var sortColParameter = sortCol.HasValue ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(int));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            var searchParameter = search != null ?
                new ObjectParameter("Search", search) :
                new ObjectParameter("Search", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPosts_Result>("spGetPosts", displayLengthParameter, displayStartParameter, sortColParameter, sortDirParameter, searchParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spUserNameExists(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spUserNameExists", userNameParameter);
        }
    }
}