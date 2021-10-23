using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace CommunitiApp.Migrations
{
    [Migration(2)]
    public class _002_Communiti_SubCommuniti_Subtitle : Migration
    {
        public override void Down()
        {
            Delete.Table("Subtitle");
            Delete.Table("SubCommuniti");
            Delete.Table("Communiti");
        }
        public override void Up()
        {
            Create.Table("Communiti")
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("CommunitiName").AsString(256)
               .WithColumn("IsDeleted").AsBoolean().WithDefaultValue(0);

            Create.Table("SubCommuniti")
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("CommunitiRef").AsInt32().ForeignKey("Communiti", "Id")
               .WithColumn("SubCommunitiName").AsString(256)
               .WithColumn("IsDeleted").AsBoolean().WithDefaultValue(0);

            Create.Table("SubTitle")
              .WithColumn("Id").AsInt32().PrimaryKey().Identity()
              .WithColumn("SubCommunitiRef").AsInt32().ForeignKey("SubCommuniti", "Id")
              .WithColumn("SubTitleName").AsString(256)
              .WithColumn("IsDeleted").AsBoolean().WithDefaultValue(0);
        }
    }
}