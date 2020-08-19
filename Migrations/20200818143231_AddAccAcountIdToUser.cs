using Microsoft.EntityFrameworkCore.Migrations;

namespace ERP.Migrations
{
    public partial class AddAccAcountIdToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccAccountAccountId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccAcountId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AccAccountAccountId",
                table: "AspNetUsers",
                column: "AccAccountAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ACC_Account_AccAccountAccountId",
                table: "AspNetUsers",
                column: "AccAccountAccountId",
                principalTable: "ACC_Account",
                principalColumn: "AccountId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ACC_Account_AccAccountAccountId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AccAccountAccountId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccAccountAccountId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AccAcountId",
                table: "AspNetUsers");
        }
    }
}
