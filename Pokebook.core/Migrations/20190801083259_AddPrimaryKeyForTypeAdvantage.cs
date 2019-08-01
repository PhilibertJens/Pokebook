using Microsoft.EntityFrameworkCore.Migrations;

namespace Pokebook.core.Migrations
{
    public partial class AddPrimaryKeyForTypeAdvantage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeAdvantages",
                table: "TypeAdvantages");

            migrationBuilder.DropIndex(
                name: "IX_TypeAdvantages_AdvantageTypeId",
                table: "TypeAdvantages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeAdvantages",
                table: "TypeAdvantages",
                columns: new[] { "AdvantageTypeId", "DisadvantageTypeId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeAdvantages",
                table: "TypeAdvantages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeAdvantages",
                table: "TypeAdvantages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TypeAdvantages_AdvantageTypeId",
                table: "TypeAdvantages",
                column: "AdvantageTypeId");
        }
    }
}
