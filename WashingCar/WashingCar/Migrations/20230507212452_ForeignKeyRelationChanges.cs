using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WashingCar.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyRelationChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Vehicles_VehicleId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_vehicleDetails_VehicleDetailId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Services_VehicleId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "VehicleDetailId",
                table: "Vehicles",
                newName: "ServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_VehicleDetailId",
                table: "Vehicles",
                newName: "IX_Vehicles_ServiceId");

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "vehicleDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicleDetails_VehicleId",
                table: "vehicleDetails",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_vehicleDetails_Vehicles_VehicleId",
                table: "vehicleDetails",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Services_ServiceId",
                table: "Vehicles",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vehicleDetails_Vehicles_VehicleId",
                table: "vehicleDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Services_ServiceId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_vehicleDetails_VehicleId",
                table: "vehicleDetails");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "vehicleDetails");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Vehicles",
                newName: "VehicleDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ServiceId",
                table: "Vehicles",
                newName: "IX_Vehicles_VehicleDetailId");

            migrationBuilder.AddColumn<Guid>(
                name: "VehicleId",
                table: "Services",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_VehicleId",
                table: "Services",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Vehicles_VehicleId",
                table: "Services",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_vehicleDetails_VehicleDetailId",
                table: "Vehicles",
                column: "VehicleDetailId",
                principalTable: "vehicleDetails",
                principalColumn: "Id");
        }
    }
}
