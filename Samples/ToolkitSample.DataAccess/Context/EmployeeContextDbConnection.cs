﻿using System;
using System.Data.Extensions;

namespace ToolkitSample.DataAccess.Context
{
    /// <summary>
    /// This DbConnection implementation provides a ConnectionString for production.
    /// You can receive the production ConnectionString from an application configuration (app.config) if you like.
    /// </summary>
    internal class EmployeeContextDbConnection : IDbConnection
    {
        public EmployeeContextDbConnection()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
        }
        public string Name { get { return "EntityFramework.Toolkit"; } }

        public string ConnectionString
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\" + this.Name + ".mdf; Integrated Security=True;";
            }
        }
    }
}