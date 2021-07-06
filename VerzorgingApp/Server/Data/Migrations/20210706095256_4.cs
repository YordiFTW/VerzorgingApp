using Microsoft.EntityFrameworkCore.Migrations;

namespace VerzorgingApp.Server.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_People_SupervisorId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_SupervisorId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "People");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupervisorId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_SupervisorId",
                table: "People",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_People_People_SupervisorId",
                table: "People",
                column: "SupervisorId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
