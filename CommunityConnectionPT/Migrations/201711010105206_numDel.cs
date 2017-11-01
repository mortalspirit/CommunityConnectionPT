namespace CommunityConnectionPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class numDel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "PhoneNum");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "PhoneNum", c => c.String());
        }
    }
}
