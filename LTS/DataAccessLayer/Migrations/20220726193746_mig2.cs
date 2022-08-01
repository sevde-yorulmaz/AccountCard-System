using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountCardGroupId",
                table: "AccountCardSubGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountCardGroupId",
                table: "AccountCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountCardKindId",
                table: "AccountCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountCardSubGroupId",
                table: "AccountCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AccountCardTypeId",
                table: "AccountCards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AccountCardSubGroups_AccountCardGroupId",
                table: "AccountCardSubGroups",
                column: "AccountCardGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCards_AccountCardGroupId",
                table: "AccountCards",
                column: "AccountCardGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCards_AccountCardKindId",
                table: "AccountCards",
                column: "AccountCardKindId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCards_AccountCardSubGroupId",
                table: "AccountCards",
                column: "AccountCardSubGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountCards_AccountCardTypeId",
                table: "AccountCards",
                column: "AccountCardTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCards_AccountCardGroups_AccountCardGroupId",
                table: "AccountCards",
                column: "AccountCardGroupId",
                principalTable: "AccountCardGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCards_AccountCardKinds_AccountCardKindId",
                table: "AccountCards",
                column: "AccountCardKindId",
                principalTable: "AccountCardKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCards_AccountCardSubGroups_AccountCardSubGroupId",
                table: "AccountCards",
                column: "AccountCardSubGroupId",
                principalTable: "AccountCardSubGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCards_AccountCardTypes_AccountCardTypeId",
                table: "AccountCards",
                column: "AccountCardTypeId",
                principalTable: "AccountCardTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountCardSubGroups_AccountCardGroups_AccountCardGroupId",
                table: "AccountCardSubGroups",
                column: "AccountCardGroupId",
                principalTable: "AccountCardGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountCards_AccountCardGroups_AccountCardGroupId",
                table: "AccountCards");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountCards_AccountCardKinds_AccountCardKindId",
                table: "AccountCards");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountCards_AccountCardSubGroups_AccountCardSubGroupId",
                table: "AccountCards");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountCards_AccountCardTypes_AccountCardTypeId",
                table: "AccountCards");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountCardSubGroups_AccountCardGroups_AccountCardGroupId",
                table: "AccountCardSubGroups");

            migrationBuilder.DropIndex(
                name: "IX_AccountCardSubGroups_AccountCardGroupId",
                table: "AccountCardSubGroups");

            migrationBuilder.DropIndex(
                name: "IX_AccountCards_AccountCardGroupId",
                table: "AccountCards");

            migrationBuilder.DropIndex(
                name: "IX_AccountCards_AccountCardKindId",
                table: "AccountCards");

            migrationBuilder.DropIndex(
                name: "IX_AccountCards_AccountCardSubGroupId",
                table: "AccountCards");

            migrationBuilder.DropIndex(
                name: "IX_AccountCards_AccountCardTypeId",
                table: "AccountCards");

            migrationBuilder.DropColumn(
                name: "AccountCardGroupId",
                table: "AccountCardSubGroups");

            migrationBuilder.DropColumn(
                name: "AccountCardGroupId",
                table: "AccountCards");

            migrationBuilder.DropColumn(
                name: "AccountCardKindId",
                table: "AccountCards");

            migrationBuilder.DropColumn(
                name: "AccountCardSubGroupId",
                table: "AccountCards");

            migrationBuilder.DropColumn(
                name: "AccountCardTypeId",
                table: "AccountCards");
        }
    }
}
