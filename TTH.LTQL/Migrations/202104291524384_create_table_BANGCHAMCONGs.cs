namespace TTH.LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_BANGCHAMCONGs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BANGCHAMCONGs",
                c => new
                    {
                        MaCC = c.String(nullable: false, maxLength: 50, unicode: false),
                        MaNV = c.String(),
                        TenNV = c.String(),
                        SoNgayNghi = c.Single(nullable: false),
                        SoNgayDiLam = c.Single(nullable: false),
                        TongNgayCong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.MaCC);
            
            CreateTable(
                "dbo.DUANs",
                c => new
                    {
                        MaDuAn = c.String(nullable: false, maxLength: 50, unicode: false),
                        TenDuAn = c.String(),
                        MaNhanVien = c.String(),
                        Ngaybatdau = c.DateTime(nullable: false),
                        Ngaygiahan = c.DateTime(nullable: false),
                        Ngayketthuc = c.DateTime(nullable: false),
                        SoLuong = c.String(),
                        DonGia = c.String(),
                        ChietKhau = c.String(),
                    })
                .PrimaryKey(t => t.MaDuAn);
            
            CreateTable(
                "dbo.KHENTHUONG-KYLUATs",
                c => new
                    {
                        SoQD = c.Int(nullable: false, identity: true),
                        TenNV = c.String(),
                        MaNV = c.String(),
                        LyDo = c.String(),
                        HinhThuc = c.String(),
                        SoTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SoQD);
            
            CreateTable(
                "dbo.TRINHDO-CMs",
                c => new
                    {
                        STT = c.Int(nullable: false, identity: true),
                        TenNV = c.String(),
                        MaNV = c.String(),
                        TDCM = c.String(),
                        TDNN = c.String(),
                    })
                .PrimaryKey(t => t.STT);
            
            AddColumn("dbo.NHANVIENs", "BANGCHAMCONGs_MaCC", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.NHANVIENs", "DUANs_MaDuAn", c => c.String(maxLength: 50, unicode: false));
            AddColumn("dbo.NHANVIENs", "KHENTHUONG_KYLUATs_SoQD", c => c.Int());
            AddColumn("dbo.NHANVIENs", "TRINHDO_CMs_STT", c => c.Int());
            CreateIndex("dbo.NHANVIENs", "BANGCHAMCONGs_MaCC");
            CreateIndex("dbo.NHANVIENs", "DUANs_MaDuAn");
            CreateIndex("dbo.NHANVIENs", "KHENTHUONG_KYLUATs_SoQD");
            CreateIndex("dbo.NHANVIENs", "TRINHDO_CMs_STT");
            AddForeignKey("dbo.NHANVIENs", "BANGCHAMCONGs_MaCC", "dbo.BANGCHAMCONGs", "MaCC");
            AddForeignKey("dbo.NHANVIENs", "DUANs_MaDuAn", "dbo.DUANs", "MaDuAn");
            AddForeignKey("dbo.NHANVIENs", "KHENTHUONG_KYLUATs_SoQD", "dbo.KHENTHUONG-KYLUATs", "SoQD");
            AddForeignKey("dbo.NHANVIENs", "TRINHDO_CMs_STT", "dbo.TRINHDO-CMs", "STT");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NHANVIENs", "TRINHDO_CMs_STT", "dbo.TRINHDO-CMs");
            DropForeignKey("dbo.NHANVIENs", "KHENTHUONG_KYLUATs_SoQD", "dbo.KHENTHUONG-KYLUATs");
            DropForeignKey("dbo.NHANVIENs", "DUANs_MaDuAn", "dbo.DUANs");
            DropForeignKey("dbo.NHANVIENs", "BANGCHAMCONGs_MaCC", "dbo.BANGCHAMCONGs");
            DropIndex("dbo.NHANVIENs", new[] { "TRINHDO_CMs_STT" });
            DropIndex("dbo.NHANVIENs", new[] { "KHENTHUONG_KYLUATs_SoQD" });
            DropIndex("dbo.NHANVIENs", new[] { "DUANs_MaDuAn" });
            DropIndex("dbo.NHANVIENs", new[] { "BANGCHAMCONGs_MaCC" });
            DropColumn("dbo.NHANVIENs", "TRINHDO_CMs_STT");
            DropColumn("dbo.NHANVIENs", "KHENTHUONG_KYLUATs_SoQD");
            DropColumn("dbo.NHANVIENs", "DUANs_MaDuAn");
            DropColumn("dbo.NHANVIENs", "BANGCHAMCONGs_MaCC");
            DropTable("dbo.TRINHDO-CMs");
            DropTable("dbo.KHENTHUONG-KYLUATs");
            DropTable("dbo.DUANs");
            DropTable("dbo.BANGCHAMCONGs");
        }
    }
}
