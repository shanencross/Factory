using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class AddRepairLicensesSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicense_Engineers_EngineerId",
                table: "RepairLicense");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicense_Machines_MachineId",
                table: "RepairLicense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairLicense",
                table: "RepairLicense");

            migrationBuilder.RenameTable(
                name: "RepairLicense",
                newName: "RepairLicenses");

            migrationBuilder.RenameIndex(
                name: "IX_RepairLicense_MachineId",
                table: "RepairLicenses",
                newName: "IX_RepairLicenses_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_RepairLicense_EngineerId",
                table: "RepairLicenses",
                newName: "IX_RepairLicenses_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairLicenses",
                table: "RepairLicenses",
                column: "RepairLicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicenses_Engineers_EngineerId",
                table: "RepairLicenses",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicenses_Machines_MachineId",
                table: "RepairLicenses",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicenses_Engineers_EngineerId",
                table: "RepairLicenses");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicenses_Machines_MachineId",
                table: "RepairLicenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairLicenses",
                table: "RepairLicenses");

            migrationBuilder.RenameTable(
                name: "RepairLicenses",
                newName: "RepairLicense");

            migrationBuilder.RenameIndex(
                name: "IX_RepairLicenses_MachineId",
                table: "RepairLicense",
                newName: "IX_RepairLicense_MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_RepairLicenses_EngineerId",
                table: "RepairLicense",
                newName: "IX_RepairLicense_EngineerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairLicense",
                table: "RepairLicense",
                column: "RepairLicenseId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicense_Engineers_EngineerId",
                table: "RepairLicense",
                column: "EngineerId",
                principalTable: "Engineers",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicense_Machines_MachineId",
                table: "RepairLicense",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
