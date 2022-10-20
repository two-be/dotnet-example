﻿using NetFrameworkEf.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkEf.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserInfo> Users { get; set; }
    }

    public class NpgSqlConfiguration : DbConfiguration
    {
        public NpgSqlConfiguration()
        {
            var name = "Npgsql";

            SetProviderFactory(providerInvariantName: name, providerFactory: NpgsqlFactory.Instance);

            SetProviderServices(providerInvariantName: name, provider: NpgsqlServices.Instance);

            SetDefaultConnectionFactory(connectionFactory: new NpgsqlConnectionFactory());
        }
    }
}
