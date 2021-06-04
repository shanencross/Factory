using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class MakeDbContextSetNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicense_Engineer_EngineerId",
                table: "RepairLicense");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicense_Machine_MachineId",
                table: "RepairLicense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machine",
                table: "Machine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer");

            migrationBuilder.RenameTable(
                name: "Machine",
                newName: "Machines");

            migrationBuilder.RenameTable(
                name: "Engineer",
                newName: "Engineers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machines",
                table: "Machines",
                column: "MachineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineers",
                table: "Engineers",
                column: "EngineerId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicense_Engineers_EngineerId",
                table: "RepairLicense");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairLicense_Machines_MachineId",
                table: "RepairLicense");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Machines",
                table: "Machines");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Engineers",
                table: "Engineers");

            migrationBuilder.RenameTable(
                name: "Machines",
                newName: "Machine");

            migrationBuilder.RenameTable(
                name: "Engineers",
                newName: "Engineer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Machine",
                table: "Machine",
                column: "MachineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Engineer",
                table: "Engineer",
                column: "EngineerId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicense_Engineer_EngineerId",
                table: "RepairLicense",
                column: "EngineerId",
                principalTable: "Engineer",
                principalColumn: "EngineerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairLicense_Machine_MachineId",
                table: "RepairLicense",
                column: "MachineId",
                principalTable: "Machine",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
