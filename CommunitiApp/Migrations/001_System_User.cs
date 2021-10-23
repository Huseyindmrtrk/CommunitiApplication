using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;

namespace CommunitiApp.Migrations
{
    [Migration(1)]
    public class _001_System_User : Migration
    {
        public override void Down()
        {
            Delete.Table("SystemUser");

        }
        public override void Up()
        {
            Create.Table("SystemUser")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("UserType").AsString().WithDefaultValue(0)
                .WithColumn("Email").AsString(256)
                .WithColumn("PasswordHash").AsString(256)
                .WithColumn("NameSurname").AsString(128)
                .WithColumn("ActivationDate").AsDateTime()
                .WithColumn("IsDeleted").AsBoolean().WithDefaultValue(0);

        }
    }
}