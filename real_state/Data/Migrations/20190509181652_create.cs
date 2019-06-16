using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace real_state.Data.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buyer_Details",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HOUSE_Id = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    STATE = table.Column<string>(nullable: true),
                    Zip_code = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Estimated_Value = table.Column<float>(nullable: false),
                    LastSale_Amount = table.Column<string>(nullable: true),
                    LastSale_Date = table.Column<DateTime>(nullable: false),
                    EstAuctionAmt = table.Column<float>(nullable: false),
                    AuctionDate = table.Column<DateTime>(nullable: false),
                    AuctionToValue = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Lot = table.Column<int>(nullable: false),
                    SqFt = table.Column<int>(nullable: false),
                    Baths = table.Column<int>(nullable: false),
                    Beds = table.Column<int>(nullable: false),
                    Fireplaces = table.Column<int>(nullable: false),
                    Rooms = table.Column<int>(nullable: false),
                    Stories = table.Column<int>(nullable: false),
                    YearBuilt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer_Details", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyer_Details");
        }
    }
}
