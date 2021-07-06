using Microsoft.EntityFrameworkCore.Migrations;

namespace VerzorgingApp.Server.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_CaretakerId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_CaretakerId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CaretakerId",
                table: "People");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CaretakerId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_CaretakerId",
                table: "People",
                column: "CaretakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_CaretakerId",
                table: "People",
                column: "CaretakerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
