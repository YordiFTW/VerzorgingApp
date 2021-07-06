using Microsoft.EntityFrameworkCore.Migrations;

namespace VerzorgingApp.Server.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_CaretakerId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_CaretakerId",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "CaretakerId",
                table: "People",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaretakerId1",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_CaretakerId1",
                table: "People",
                column: "CaretakerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_CaretakerId1",
                table: "People",
                column: "CaretakerId1",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_CaretakerId1",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_CaretakerId1",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CaretakerId1",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "CaretakerId",
                table: "People",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
