﻿using System.Data.Common;
using Abp.Zero.EntityFramework;
using WorkOrder.Authorization.Roles;
using WorkOrder.MultiTenancy;
using WorkOrder.Users;

namespace WorkOrder.EntityFramework
{
    public class WorkOrderDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public WorkOrderDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in WorkOrderDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of WorkOrderDbContext since ABP automatically handles it.
         */
        public WorkOrderDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public WorkOrderDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
