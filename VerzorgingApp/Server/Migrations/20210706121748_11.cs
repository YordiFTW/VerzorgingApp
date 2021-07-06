using Microsoft.EntityFrameworkCore.Migrations;

namespace VerzorgingApp.Server.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElderId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_ElderId",
                table: "People",
                column: "ElderId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_ElderId",
                table: "People",
                column: "ElderId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_ElderId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ElderId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ElderId",
                table: "People");
        }
    }
}
