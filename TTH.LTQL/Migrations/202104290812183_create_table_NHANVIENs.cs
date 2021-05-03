namespace TTH.LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NHANVIENs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANGLUONGs",
                c => new
                    {
                        MaLuong = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(),
                        HeSoLuong = c.Single(nullable: false),
                        BacLuong = c.Single(nullable: false),
                        TongNgayCong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaLuong);
            
            CreateTable(
                "dbo.NHANVIENs",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNV = c.String(),
                        SĐT = c.Int(nullable: false),
                        DiaChi = c.String(),
                        ChucVu = c.String(),
                        PhongBan = c.String(),
                        NgaykiHD = c.DateTime(nullable: false),
                        BANGLUONGs_MaLuong = c.String(maxLength: 50, unicode: false),
                        CHUCVUs_MaCV = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.MaNV)
                .ForeignKey("dbo.BANGLUONGs", t => t.BANGLUONGs_MaLuong)
                .ForeignKey("dbo.CHUCVUs", t => t.CHUCVUs_MaCV)
                .Index(t => t.BANGLUONGs_MaLuong)
                .Index(t => t.CHUCVUs_MaCV);
            
            CreateTable(
                "dbo.CHUCVUs",
                c => new
                    {
                        MaCV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenCV = c.String(),
                    })
                .PrimaryKey(t => t.MaCV);
            
            CreateTable(
                "dbo.PHONGBANs",
                c => new
                    {
                        MaPB = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenPB = c.String(),
                        NHANVIENs_MaNV = c.String(maxLength: 128, unicode: false),
                    })
                .PrimaryKey(t => t.MaPB)
                .ForeignKey("dbo.NHANVIENs", t => t.NHANVIENs_MaNV)
                .Index(t => t.NHANVIENs_MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PHONGBANs", "NHANVIENs_MaNV", "dbo.NHANVIENs");
            DropForeignKey("dbo.NHANVIENs", "CHUCVUs_MaCV", "dbo.CHUCVUs");
            DropForeignKey("dbo.NHANVIENs", "BANGLUONGs_MaLuong", "dbo.BANGLUONGs");
            DropIndex("dbo.PHONGBANs", new[] { "NHANVIENs_MaNV" });
            DropIndex("dbo.NHANVIENs", new[] { "CHUCVUs_MaCV" });
            DropIndex("dbo.NHANVIENs", new[] { "BANGLUONGs_MaLuong" });
            DropTable("dbo.PHONGBANs");
            DropTable("dbo.CHUCVUs");
            DropTable("dbo.NHANVIENs");
            DropTable("dbo.BANGLUONGs");
        }
    }
}
