namespace TTH.LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.THONGTINs",
                c => new
                    {
                        ThongtinID = c.String(nullable: false, maxLength: 128),
                        Tieude = c.String(),
                        NoiDung = c.String(),
                    })
                .PrimaryKey(t => t.ThongtinID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.THONGTINs");
        }
    }
}
