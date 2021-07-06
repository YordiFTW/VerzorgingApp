using Microsoft.EntityFrameworkCore.Migrations;

namespace VerzorgingApp.Server.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_ElderId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "ElderId",
                table: "People",
                newName: "CaretakerId");

            migrationBuilder.RenameIndex(
                name: "IX_People_ElderId",
                table: "People",
                newName: "IX_People_CaretakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_CaretakerId",
                table: "People",
                column: "CaretakerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_CaretakerId",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "CaretakerId",
                table: "People",
                newName: "ElderId");

            migrationBuilder.RenameIndex(
                name: "IX_People_CaretakerId",
                table: "People",
                newName: "IX_People_ElderId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_ElderId",
                table: "People",
                column: "ElderId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
