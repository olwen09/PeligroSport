using Microsoft.EntityFrameworkCore.Migrations;

namespace PeligroSport.Core.Migrations
{
    public partial class relationshipsusuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BillingAddress_BillingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShippingAddresses_ShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingAddressId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BillingAddressId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BillingAddress_BillingAddressId",
                table: "AspNetUsers",
                column: "BillingAddressId",
                principalTable: "BillingAddress",
                principalColumn: "BillingAddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShippingAddresses_ShippingAddressId",
                table: "AspNetUsers",
                column: "ShippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "ShippingAddressId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_BillingAddress_BillingAddressId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShippingAddresses_ShippingAddressId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "ShippingAddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillingAddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AddressId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Address_AddressId",
                table: "AspNetUsers",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_BillingAddress_BillingAddressId",
                table: "AspNetUsers",
                column: "BillingAddressId",
                principalTable: "BillingAddress",
                principalColumn: "BillingAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShippingAddresses_ShippingAddressId",
                table: "AspNetUsers",
                column: "ShippingAddressId",
                principalTable: "ShippingAddresses",
                principalColumn: "ShippingAddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
