namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sinhvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.sinhvien",
                c => new
                    {
                        MaSV = c.Int(nullable: false, identity: true),
                        TenSV = c.String(),
                        namsinh = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaSV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.sinhvien");
        }
    }
}
