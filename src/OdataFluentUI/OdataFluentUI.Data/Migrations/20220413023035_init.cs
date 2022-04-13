using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdataFluentUI.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MaterialName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MaterialSpecification = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    MaterialModel = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    MaterialClassification = table.Column<int>(type: "varchar(20)", nullable: false),
                    Unit = table.Column<int>(type: "varchar(10)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "StorageRacks",
                columns: table => new
                {
                    StorageRackId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StorageRackName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    StorageRackCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    StorageRackSpecification = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    StorageRackModel = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Remark = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageRacks", x => x.StorageRackId);
                });

            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false),
                    Batch = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Number = table.Column<ulong>(type: "INTEGER", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => new { x.MaterialId, x.Batch });
                    table.ForeignKey(
                        name: "FK_Inventorys_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CargoSpaces",
                columns: table => new
                {
                    CargoSpaceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CargoSpaceCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    MaxAvailableSpace = table.Column<uint>(type: "INTEGER", nullable: false),
                    StorageRackId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoSpaces", x => x.CargoSpaceId);
                    table.ForeignKey(
                        name: "FK_CargoSpaces_StorageRacks_StorageRackId",
                        column: x => x.StorageRackId,
                        principalTable: "StorageRacks",
                        principalColumn: "StorageRackId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1000, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2050), true, 1, "Code-1000", "Model-1000", "Name-1000", "Specification-1000", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1001, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2146), false, 2, "Code-1001", "Model-1001", "Name-1001", "Specification-1001", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1002, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2163), true, 2, "Code-1002", "Model-1002", "Name-1002", "Specification-1002", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1003, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2168), false, 1, "Code-1003", "Model-1003", "Name-1003", "Specification-1003", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1004, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2174), true, 2, "Code-1004", "Model-1004", "Name-1004", "Specification-1004", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1005, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2181), false, 1, "Code-1005", "Model-1005", "Name-1005", "Specification-1005", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1006, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2187), true, 1, "Code-1006", "Model-1006", "Name-1006", "Specification-1006", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1007, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2192), false, 2, "Code-1007", "Model-1007", "Name-1007", "Specification-1007", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1008, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2198), true, 1, "Code-1008", "Model-1008", "Name-1008", "Specification-1008", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1009, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2202), false, 1, "Code-1009", "Model-1009", "Name-1009", "Specification-1009", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1010, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2209), true, 1, "Code-1010", "Model-1010", "Name-1010", "Specification-1010", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1011, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2219), false, 1, "Code-1011", "Model-1011", "Name-1011", "Specification-1011", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1012, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2226), true, 2, "Code-1012", "Model-1012", "Name-1012", "Specification-1012", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1013, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2230), false, 1, "Code-1013", "Model-1013", "Name-1013", "Specification-1013", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1014, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2236), true, 2, "Code-1014", "Model-1014", "Name-1014", "Specification-1014", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1015, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2240), false, 2, "Code-1015", "Model-1015", "Name-1015", "Specification-1015", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1016, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2246), true, 1, "Code-1016", "Model-1016", "Name-1016", "Specification-1016", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1017, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2251), false, 1, "Code-1017", "Model-1017", "Name-1017", "Specification-1017", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1018, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2257), true, 2, "Code-1018", "Model-1018", "Name-1018", "Specification-1018", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1019, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2261), false, 1, "Code-1019", "Model-1019", "Name-1019", "Specification-1019", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1020, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2267), true, 2, "Code-1020", "Model-1020", "Name-1020", "Specification-1020", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1021, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2271), false, 1, "Code-1021", "Model-1021", "Name-1021", "Specification-1021", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1022, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2276), true, 1, "Code-1022", "Model-1022", "Name-1022", "Specification-1022", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1023, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2280), false, 1, "Code-1023", "Model-1023", "Name-1023", "Specification-1023", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1024, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2286), true, 1, "Code-1024", "Model-1024", "Name-1024", "Specification-1024", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1025, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2290), false, 1, "Code-1025", "Model-1025", "Name-1025", "Specification-1025", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1026, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2295), true, 1, "Code-1026", "Model-1026", "Name-1026", "Specification-1026", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1027, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2299), false, 2, "Code-1027", "Model-1027", "Name-1027", "Specification-1027", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1028, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2304), true, 1, "Code-1028", "Model-1028", "Name-1028", "Specification-1028", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1029, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2312), false, 1, "Code-1029", "Model-1029", "Name-1029", "Specification-1029", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1030, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2318), true, 2, "Code-1030", "Model-1030", "Name-1030", "Specification-1030", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1031, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2322), false, 2, "Code-1031", "Model-1031", "Name-1031", "Specification-1031", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1032, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2327), true, 2, "Code-1032", "Model-1032", "Name-1032", "Specification-1032", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1033, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2332), false, 2, "Code-1033", "Model-1033", "Name-1033", "Specification-1033", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1034, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2338), true, 2, "Code-1034", "Model-1034", "Name-1034", "Specification-1034", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1035, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2343), false, 1, "Code-1035", "Model-1035", "Name-1035", "Specification-1035", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1036, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2348), true, 1, "Code-1036", "Model-1036", "Name-1036", "Specification-1036", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1037, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2352), false, 2, "Code-1037", "Model-1037", "Name-1037", "Specification-1037", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1038, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2357), true, 1, "Code-1038", "Model-1038", "Name-1038", "Specification-1038", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1039, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2361), false, 1, "Code-1039", "Model-1039", "Name-1039", "Specification-1039", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1040, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2367), true, 2, "Code-1040", "Model-1040", "Name-1040", "Specification-1040", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1041, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2371), false, 1, "Code-1041", "Model-1041", "Name-1041", "Specification-1041", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1042, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2376), true, 2, "Code-1042", "Model-1042", "Name-1042", "Specification-1042", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1043, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2381), false, 2, "Code-1043", "Model-1043", "Name-1043", "Specification-1043", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1044, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2386), true, 1, "Code-1044", "Model-1044", "Name-1044", "Specification-1044", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1045, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2390), false, 1, "Code-1045", "Model-1045", "Name-1045", "Specification-1045", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1046, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2396), true, 1, "Code-1046", "Model-1046", "Name-1046", "Specification-1046", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1047, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2403), false, 1, "Code-1047", "Model-1047", "Name-1047", "Specification-1047", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1048, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2409), true, 2, "Code-1048", "Model-1048", "Name-1048", "Specification-1048", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1049, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2412), false, 1, "Code-1049", "Model-1049", "Name-1049", "Specification-1049", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1050, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2418), true, 2, "Code-1050", "Model-1050", "Name-1050", "Specification-1050", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1051, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2422), false, 2, "Code-1051", "Model-1051", "Name-1051", "Specification-1051", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1052, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2428), true, 2, "Code-1052", "Model-1052", "Name-1052", "Specification-1052", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1053, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2432), false, 2, "Code-1053", "Model-1053", "Name-1053", "Specification-1053", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1054, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2438), true, 1, "Code-1054", "Model-1054", "Name-1054", "Specification-1054", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1055, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2442), false, 2, "Code-1055", "Model-1055", "Name-1055", "Specification-1055", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1056, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2448), true, 1, "Code-1056", "Model-1056", "Name-1056", "Specification-1056", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1057, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2451), false, 2, "Code-1057", "Model-1057", "Name-1057", "Specification-1057", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1058, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2457), true, 2, "Code-1058", "Model-1058", "Name-1058", "Specification-1058", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1059, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2461), false, 2, "Code-1059", "Model-1059", "Name-1059", "Specification-1059", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1060, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2466), true, 2, "Code-1060", "Model-1060", "Name-1060", "Specification-1060", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1061, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2470), false, 1, "Code-1061", "Model-1061", "Name-1061", "Specification-1061", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1062, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2476), true, 1, "Code-1062", "Model-1062", "Name-1062", "Specification-1062", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1063, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2480), false, 1, "Code-1063", "Model-1063", "Name-1063", "Specification-1063", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1064, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2486), true, 2, "Code-1064", "Model-1064", "Name-1064", "Specification-1064", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1065, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2493), false, 1, "Code-1065", "Model-1065", "Name-1065", "Specification-1065", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1066, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2500), true, 2, "Code-1066", "Model-1066", "Name-1066", "Specification-1066", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1067, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2504), false, 2, "Code-1067", "Model-1067", "Name-1067", "Specification-1067", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1068, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2510), true, 2, "Code-1068", "Model-1068", "Name-1068", "Specification-1068", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1069, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2515), false, 2, "Code-1069", "Model-1069", "Name-1069", "Specification-1069", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1070, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2521), true, 1, "Code-1070", "Model-1070", "Name-1070", "Specification-1070", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1071, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2525), false, 2, "Code-1071", "Model-1071", "Name-1071", "Specification-1071", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1072, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2530), true, 1, "Code-1072", "Model-1072", "Name-1072", "Specification-1072", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1073, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2534), false, 1, "Code-1073", "Model-1073", "Name-1073", "Specification-1073", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1074, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2540), true, 2, "Code-1074", "Model-1074", "Name-1074", "Specification-1074", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1075, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2543), false, 1, "Code-1075", "Model-1075", "Name-1075", "Specification-1075", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1076, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2549), true, 2, "Code-1076", "Model-1076", "Name-1076", "Specification-1076", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1077, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2553), false, 2, "Code-1077", "Model-1077", "Name-1077", "Specification-1077", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1078, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2558), true, 1, "Code-1078", "Model-1078", "Name-1078", "Specification-1078", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1079, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2562), false, 1, "Code-1079", "Model-1079", "Name-1079", "Specification-1079", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1080, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2567), true, 2, "Code-1080", "Model-1080", "Name-1080", "Specification-1080", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1081, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2572), false, 1, "Code-1081", "Model-1081", "Name-1081", "Specification-1081", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1082, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2581), true, 1, "Code-1082", "Model-1082", "Name-1082", "Specification-1082", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1083, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2585), false, 1, "Code-1083", "Model-1083", "Name-1083", "Specification-1083", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1084, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2591), true, 2, "Code-1084", "Model-1084", "Name-1084", "Specification-1084", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1085, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2595), false, 2, "Code-1085", "Model-1085", "Name-1085", "Specification-1085", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1086, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2601), true, 1, "Code-1086", "Model-1086", "Name-1086", "Specification-1086", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1087, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2605), false, 1, "Code-1087", "Model-1087", "Name-1087", "Specification-1087", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1088, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2610), true, 1, "Code-1088", "Model-1088", "Name-1088", "Specification-1088", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1089, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2614), false, 2, "Code-1089", "Model-1089", "Name-1089", "Specification-1089", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1090, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2619), true, 1, "Code-1090", "Model-1090", "Name-1090", "Specification-1090", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1091, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2624), false, 1, "Code-1091", "Model-1091", "Name-1091", "Specification-1091", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1092, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2629), true, 1, "Code-1092", "Model-1092", "Name-1092", "Specification-1092", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1093, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2633), false, 2, "Code-1093", "Model-1093", "Name-1093", "Specification-1093", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1094, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2639), true, 1, "Code-1094", "Model-1094", "Name-1094", "Specification-1094", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1095, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2642), false, 1, "Code-1095", "Model-1095", "Name-1095", "Specification-1095", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1096, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2648), true, 2, "Code-1096", "Model-1096", "Name-1096", "Specification-1096", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1097, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2652), false, 2, "Code-1097", "Model-1097", "Name-1097", "Specification-1097", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1098, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2657), true, 2, "Code-1098", "Model-1098", "Name-1098", "Specification-1098", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1099, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2661), false, 2, "Code-1099", "Model-1099", "Name-1099", "Specification-1099", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1100, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2667), true, 1, "Code-1100", "Model-1100", "Name-1100", "Specification-1100", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1101, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2674), false, 2, "Code-1101", "Model-1101", "Name-1101", "Specification-1101", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1102, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2680), true, 2, "Code-1102", "Model-1102", "Name-1102", "Specification-1102", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1103, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2684), false, 2, "Code-1103", "Model-1103", "Name-1103", "Specification-1103", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1104, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2689), true, 1, "Code-1104", "Model-1104", "Name-1104", "Specification-1104", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1105, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2693), false, 1, "Code-1105", "Model-1105", "Name-1105", "Specification-1105", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1106, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2699), true, 2, "Code-1106", "Model-1106", "Name-1106", "Specification-1106", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1107, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2703), false, 1, "Code-1107", "Model-1107", "Name-1107", "Specification-1107", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1108, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2708), true, 1, "Code-1108", "Model-1108", "Name-1108", "Specification-1108", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1109, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2712), false, 2, "Code-1109", "Model-1109", "Name-1109", "Specification-1109", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1110, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2718), true, 1, "Code-1110", "Model-1110", "Name-1110", "Specification-1110", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1111, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2721), false, 2, "Code-1111", "Model-1111", "Name-1111", "Specification-1111", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1112, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2727), true, 1, "Code-1112", "Model-1112", "Name-1112", "Specification-1112", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1113, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2731), false, 1, "Code-1113", "Model-1113", "Name-1113", "Specification-1113", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1114, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2736), true, 2, "Code-1114", "Model-1114", "Name-1114", "Specification-1114", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1115, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2740), false, 2, "Code-1115", "Model-1115", "Name-1115", "Specification-1115", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1116, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2745), true, 2, "Code-1116", "Model-1116", "Name-1116", "Specification-1116", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1117, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2749), false, 1, "Code-1117", "Model-1117", "Name-1117", "Specification-1117", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1118, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2755), true, 1, "Code-1118", "Model-1118", "Name-1118", "Specification-1118", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1119, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2759), false, 2, "Code-1119", "Model-1119", "Name-1119", "Specification-1119", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1120, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2925), true, 1, "Code-1120", "Model-1120", "Name-1120", "Specification-1120", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1121, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2929), false, 1, "Code-1121", "Model-1121", "Name-1121", "Specification-1121", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1122, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2935), true, 2, "Code-1122", "Model-1122", "Name-1122", "Specification-1122", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1123, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2939), false, 2, "Code-1123", "Model-1123", "Name-1123", "Specification-1123", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1124, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2944), true, 2, "Code-1124", "Model-1124", "Name-1124", "Specification-1124", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1125, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2948), false, 2, "Code-1125", "Model-1125", "Name-1125", "Specification-1125", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1126, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2954), true, 2, "Code-1126", "Model-1126", "Name-1126", "Specification-1126", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1127, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2958), false, 2, "Code-1127", "Model-1127", "Name-1127", "Specification-1127", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1128, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2964), true, 2, "Code-1128", "Model-1128", "Name-1128", "Specification-1128", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1129, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2969), false, 2, "Code-1129", "Model-1129", "Name-1129", "Specification-1129", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1130, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2975), true, 2, "Code-1130", "Model-1130", "Name-1130", "Specification-1130", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1131, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2979), false, 1, "Code-1131", "Model-1131", "Name-1131", "Specification-1131", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1132, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2985), true, 2, "Code-1132", "Model-1132", "Name-1132", "Specification-1132", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1133, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2989), false, 1, "Code-1133", "Model-1133", "Name-1133", "Specification-1133", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1134, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(2998), true, 2, "Code-1134", "Model-1134", "Name-1134", "Specification-1134", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1135, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3002), false, 2, "Code-1135", "Model-1135", "Name-1135", "Specification-1135", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1136, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3008), true, 1, "Code-1136", "Model-1136", "Name-1136", "Specification-1136", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1137, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3011), false, 1, "Code-1137", "Model-1137", "Name-1137", "Specification-1137", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1138, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3017), true, 1, "Code-1138", "Model-1138", "Name-1138", "Specification-1138", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1139, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3021), false, 1, "Code-1139", "Model-1139", "Name-1139", "Specification-1139", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1140, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3026), true, 1, "Code-1140", "Model-1140", "Name-1140", "Specification-1140", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1141, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3030), false, 2, "Code-1141", "Model-1141", "Name-1141", "Specification-1141", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1142, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3036), true, 1, "Code-1142", "Model-1142", "Name-1142", "Specification-1142", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1143, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3040), false, 1, "Code-1143", "Model-1143", "Name-1143", "Specification-1143", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1144, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3045), true, 1, "Code-1144", "Model-1144", "Name-1144", "Specification-1144", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1145, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3049), false, 2, "Code-1145", "Model-1145", "Name-1145", "Specification-1145", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1146, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3055), true, 1, "Code-1146", "Model-1146", "Name-1146", "Specification-1146", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1147, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3059), false, 1, "Code-1147", "Model-1147", "Name-1147", "Specification-1147", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1148, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3064), true, 2, "Code-1148", "Model-1148", "Name-1148", "Specification-1148", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1149, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3068), false, 1, "Code-1149", "Model-1149", "Name-1149", "Specification-1149", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1150, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3074), true, 1, "Code-1150", "Model-1150", "Name-1150", "Specification-1150", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1151, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3078), false, 2, "Code-1151", "Model-1151", "Name-1151", "Specification-1151", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1152, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3083), true, 2, "Code-1152", "Model-1152", "Name-1152", "Specification-1152", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1153, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3091), false, 2, "Code-1153", "Model-1153", "Name-1153", "Specification-1153", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1154, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3096), true, 2, "Code-1154", "Model-1154", "Name-1154", "Specification-1154", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1155, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3100), false, 1, "Code-1155", "Model-1155", "Name-1155", "Specification-1155", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1156, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3106), true, 1, "Code-1156", "Model-1156", "Name-1156", "Specification-1156", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1157, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3109), false, 2, "Code-1157", "Model-1157", "Name-1157", "Specification-1157", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1158, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3115), true, 2, "Code-1158", "Model-1158", "Name-1158", "Specification-1158", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1159, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3119), false, 1, "Code-1159", "Model-1159", "Name-1159", "Specification-1159", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1160, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3125), true, 1, "Code-1160", "Model-1160", "Name-1160", "Specification-1160", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1161, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3129), false, 1, "Code-1161", "Model-1161", "Name-1161", "Specification-1161", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1162, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3134), true, 1, "Code-1162", "Model-1162", "Name-1162", "Specification-1162", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1163, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3138), false, 1, "Code-1163", "Model-1163", "Name-1163", "Specification-1163", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1164, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3144), true, 1, "Code-1164", "Model-1164", "Name-1164", "Specification-1164", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1165, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3148), false, 2, "Code-1165", "Model-1165", "Name-1165", "Specification-1165", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1166, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3153), true, 1, "Code-1166", "Model-1166", "Name-1166", "Specification-1166", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1167, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3157), false, 2, "Code-1167", "Model-1167", "Name-1167", "Specification-1167", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1168, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3163), true, 1, "Code-1168", "Model-1168", "Name-1168", "Specification-1168", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1169, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3167), false, 2, "Code-1169", "Model-1169", "Name-1169", "Specification-1169", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1170, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3172), true, 2, "Code-1170", "Model-1170", "Name-1170", "Specification-1170", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1171, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3176), false, 1, "Code-1171", "Model-1171", "Name-1171", "Specification-1171", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1172, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3185), true, 2, "Code-1172", "Model-1172", "Name-1172", "Specification-1172", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1173, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3189), false, 1, "Code-1173", "Model-1173", "Name-1173", "Specification-1173", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1174, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3194), true, 2, "Code-1174", "Model-1174", "Name-1174", "Specification-1174", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1175, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3198), false, 2, "Code-1175", "Model-1175", "Name-1175", "Specification-1175", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1176, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3204), true, 2, "Code-1176", "Model-1176", "Name-1176", "Specification-1176", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1177, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3207), false, 1, "Code-1177", "Model-1177", "Name-1177", "Specification-1177", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1178, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3213), true, 1, "Code-1178", "Model-1178", "Name-1178", "Specification-1178", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1179, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3217), false, 2, "Code-1179", "Model-1179", "Name-1179", "Specification-1179", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1180, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3222), true, 2, "Code-1180", "Model-1180", "Name-1180", "Specification-1180", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1181, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3227), false, 2, "Code-1181", "Model-1181", "Name-1181", "Specification-1181", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1182, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3232), true, 1, "Code-1182", "Model-1182", "Name-1182", "Specification-1182", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1183, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3236), false, 1, "Code-1183", "Model-1183", "Name-1183", "Specification-1183", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1184, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3242), true, 2, "Code-1184", "Model-1184", "Name-1184", "Specification-1184", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1185, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3246), false, 2, "Code-1185", "Model-1185", "Name-1185", "Specification-1185", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1186, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3252), true, 2, "Code-1186", "Model-1186", "Name-1186", "Specification-1186", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1187, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3256), false, 1, "Code-1187", "Model-1187", "Name-1187", "Specification-1187", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1188, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3261), true, 1, "Code-1188", "Model-1188", "Name-1188", "Specification-1188", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1189, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3265), false, 2, "Code-1189", "Model-1189", "Name-1189", "Specification-1189", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1190, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3270), true, 1, "Code-1190", "Model-1190", "Name-1190", "Specification-1190", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1191, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3277), false, 1, "Code-1191", "Model-1191", "Name-1191", "Specification-1191", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1192, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3283), true, 1, "Code-1192", "Model-1192", "Name-1192", "Specification-1192", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1193, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3287), false, 2, "Code-1193", "Model-1193", "Name-1193", "Specification-1193", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1194, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3292), true, 2, "Code-1194", "Model-1194", "Name-1194", "Specification-1194", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1195, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3296), false, 1, "Code-1195", "Model-1195", "Name-1195", "Specification-1195", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1196, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3302), true, 2, "Code-1196", "Model-1196", "Name-1196", "Specification-1196", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1197, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3306), false, 1, "Code-1197", "Model-1197", "Name-1197", "Specification-1197", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1198, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3311), true, 2, "Code-1198", "Model-1198", "Name-1198", "Specification-1198", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1199, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3315), false, 1, "Code-1199", "Model-1199", "Name-1199", "Specification-1199", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1200, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3320), true, 2, "Code-1200", "Model-1200", "Name-1200", "Specification-1200", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1201, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3324), false, 2, "Code-1201", "Model-1201", "Name-1201", "Specification-1201", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1202, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3330), true, 1, "Code-1202", "Model-1202", "Name-1202", "Specification-1202", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1203, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3334), false, 2, "Code-1203", "Model-1203", "Name-1203", "Specification-1203", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1204, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3340), true, 1, "Code-1204", "Model-1204", "Name-1204", "Specification-1204", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1205, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3343), false, 2, "Code-1205", "Model-1205", "Name-1205", "Specification-1205", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1206, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3349), true, 1, "Code-1206", "Model-1206", "Name-1206", "Specification-1206", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1207, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3353), false, 1, "Code-1207", "Model-1207", "Name-1207", "Specification-1207", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1208, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3359), true, 1, "Code-1208", "Model-1208", "Name-1208", "Specification-1208", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1209, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3363), false, 1, "Code-1209", "Model-1209", "Name-1209", "Specification-1209", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1210, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3371), true, 2, "Code-1210", "Model-1210", "Name-1210", "Specification-1210", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1211, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3375), false, 1, "Code-1211", "Model-1211", "Name-1211", "Specification-1211", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1212, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3381), true, 1, "Code-1212", "Model-1212", "Name-1212", "Specification-1212", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1213, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3384), false, 1, "Code-1213", "Model-1213", "Name-1213", "Specification-1213", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1214, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3390), true, 1, "Code-1214", "Model-1214", "Name-1214", "Specification-1214", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1215, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3394), false, 1, "Code-1215", "Model-1215", "Name-1215", "Specification-1215", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1216, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3399), true, 1, "Code-1216", "Model-1216", "Name-1216", "Specification-1216", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1217, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3404), false, 1, "Code-1217", "Model-1217", "Name-1217", "Specification-1217", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1218, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3409), true, 2, "Code-1218", "Model-1218", "Name-1218", "Specification-1218", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1219, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3414), false, 1, "Code-1219", "Model-1219", "Name-1219", "Specification-1219", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1220, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3419), true, 1, "Code-1220", "Model-1220", "Name-1220", "Specification-1220", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1221, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3423), false, 1, "Code-1221", "Model-1221", "Name-1221", "Specification-1221", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1222, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3428), true, 1, "Code-1222", "Model-1222", "Name-1222", "Specification-1222", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1223, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3432), false, 2, "Code-1223", "Model-1223", "Name-1223", "Specification-1223", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1224, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3438), true, 2, "Code-1224", "Model-1224", "Name-1224", "Specification-1224", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1225, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3442), false, 2, "Code-1225", "Model-1225", "Name-1225", "Specification-1225", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1226, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3447), true, 2, "Code-1226", "Model-1226", "Name-1226", "Specification-1226", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1227, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3451), false, 1, "Code-1227", "Model-1227", "Name-1227", "Specification-1227", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1228, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3456), true, 2, "Code-1228", "Model-1228", "Name-1228", "Specification-1228", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1229, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3464), false, 2, "Code-1229", "Model-1229", "Name-1229", "Specification-1229", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1230, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3469), true, 2, "Code-1230", "Model-1230", "Name-1230", "Specification-1230", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1231, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3474), false, 1, "Code-1231", "Model-1231", "Name-1231", "Specification-1231", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1232, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3479), true, 1, "Code-1232", "Model-1232", "Name-1232", "Specification-1232", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1233, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3483), false, 2, "Code-1233", "Model-1233", "Name-1233", "Specification-1233", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1234, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3489), true, 1, "Code-1234", "Model-1234", "Name-1234", "Specification-1234", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1235, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3493), false, 1, "Code-1235", "Model-1235", "Name-1235", "Specification-1235", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1236, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3498), true, 2, "Code-1236", "Model-1236", "Name-1236", "Specification-1236", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1237, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3502), false, 2, "Code-1237", "Model-1237", "Name-1237", "Specification-1237", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1238, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3508), true, 2, "Code-1238", "Model-1238", "Name-1238", "Specification-1238", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1239, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3512), false, 1, "Code-1239", "Model-1239", "Name-1239", "Specification-1239", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1240, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3517), true, 1, "Code-1240", "Model-1240", "Name-1240", "Specification-1240", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1241, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3521), false, 1, "Code-1241", "Model-1241", "Name-1241", "Specification-1241", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1242, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3527), true, 1, "Code-1242", "Model-1242", "Name-1242", "Specification-1242", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1243, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3530), false, 1, "Code-1243", "Model-1243", "Name-1243", "Specification-1243", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1244, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3536), true, 1, "Code-1244", "Model-1244", "Name-1244", "Specification-1244", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1245, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3540), false, 1, "Code-1245", "Model-1245", "Name-1245", "Specification-1245", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1246, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3545), true, 1, "Code-1246", "Model-1246", "Name-1246", "Specification-1246", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1247, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3549), false, 2, "Code-1247", "Model-1247", "Name-1247", "Specification-1247", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1248, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3559), true, 1, "Code-1248", "Model-1248", "Name-1248", "Specification-1248", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1249, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3563), false, 1, "Code-1249", "Model-1249", "Name-1249", "Specification-1249", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1250, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3568), true, 2, "Code-1250", "Model-1250", "Name-1250", "Specification-1250", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1251, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3572), false, 1, "Code-1251", "Model-1251", "Name-1251", "Specification-1251", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1252, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3577), true, 2, "Code-1252", "Model-1252", "Name-1252", "Specification-1252", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1253, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3581), false, 1, "Code-1253", "Model-1253", "Name-1253", "Specification-1253", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1254, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3586), true, 1, "Code-1254", "Model-1254", "Name-1254", "Specification-1254", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1255, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3591), false, 2, "Code-1255", "Model-1255", "Name-1255", "Specification-1255", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1256, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3596), true, 1, "Code-1256", "Model-1256", "Name-1256", "Specification-1256", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1257, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3604), false, 1, "Code-1257", "Model-1257", "Name-1257", "Specification-1257", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1258, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3611), true, 2, "Code-1258", "Model-1258", "Name-1258", "Specification-1258", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1259, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3615), false, 1, "Code-1259", "Model-1259", "Name-1259", "Specification-1259", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1260, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3621), true, 2, "Code-1260", "Model-1260", "Name-1260", "Specification-1260", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1261, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3625), false, 1, "Code-1261", "Model-1261", "Name-1261", "Specification-1261", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1262, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3631), true, 2, "Code-1262", "Model-1262", "Name-1262", "Specification-1262", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1263, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3635), false, 2, "Code-1263", "Model-1263", "Name-1263", "Specification-1263", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1264, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3640), true, 1, "Code-1264", "Model-1264", "Name-1264", "Specification-1264", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1265, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3644), false, 2, "Code-1265", "Model-1265", "Name-1265", "Specification-1265", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1266, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3650), true, 1, "Code-1266", "Model-1266", "Name-1266", "Specification-1266", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1267, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3654), false, 2, "Code-1267", "Model-1267", "Name-1267", "Specification-1267", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1268, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3659), true, 1, "Code-1268", "Model-1268", "Name-1268", "Specification-1268", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1269, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3663), false, 2, "Code-1269", "Model-1269", "Name-1269", "Specification-1269", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1270, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3669), true, 1, "Code-1270", "Model-1270", "Name-1270", "Specification-1270", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1271, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3673), false, 1, "Code-1271", "Model-1271", "Name-1271", "Specification-1271", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1272, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3679), true, 2, "Code-1272", "Model-1272", "Name-1272", "Specification-1272", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1273, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3683), false, 2, "Code-1273", "Model-1273", "Name-1273", "Specification-1273", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1274, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3689), true, 1, "Code-1274", "Model-1274", "Name-1274", "Specification-1274", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1275, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3693), false, 1, "Code-1275", "Model-1275", "Name-1275", "Specification-1275", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1276, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3702), true, 2, "Code-1276", "Model-1276", "Name-1276", "Specification-1276", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1277, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3706), false, 1, "Code-1277", "Model-1277", "Name-1277", "Specification-1277", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1278, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3712), true, 1, "Code-1278", "Model-1278", "Name-1278", "Specification-1278", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1279, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3715), false, 1, "Code-1279", "Model-1279", "Name-1279", "Specification-1279", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1280, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3721), true, 1, "Code-1280", "Model-1280", "Name-1280", "Specification-1280", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1281, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3725), false, 1, "Code-1281", "Model-1281", "Name-1281", "Specification-1281", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1282, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3731), true, 1, "Code-1282", "Model-1282", "Name-1282", "Specification-1282", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1283, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3735), false, 1, "Code-1283", "Model-1283", "Name-1283", "Specification-1283", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1284, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3740), true, 1, "Code-1284", "Model-1284", "Name-1284", "Specification-1284", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1285, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3744), false, 2, "Code-1285", "Model-1285", "Name-1285", "Specification-1285", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1286, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3749), true, 1, "Code-1286", "Model-1286", "Name-1286", "Specification-1286", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1287, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3753), false, 2, "Code-1287", "Model-1287", "Name-1287", "Specification-1287", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1288, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3759), true, 1, "Code-1288", "Model-1288", "Name-1288", "Specification-1288", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1289, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3763), false, 1, "Code-1289", "Model-1289", "Name-1289", "Specification-1289", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1290, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3768), true, 1, "Code-1290", "Model-1290", "Name-1290", "Specification-1290", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1291, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3772), false, 2, "Code-1291", "Model-1291", "Name-1291", "Specification-1291", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1292, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3777), true, 2, "Code-1292", "Model-1292", "Name-1292", "Specification-1292", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1293, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3781), false, 1, "Code-1293", "Model-1293", "Name-1293", "Specification-1293", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1294, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3787), true, 1, "Code-1294", "Model-1294", "Name-1294", "Specification-1294", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1295, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3794), false, 2, "Code-1295", "Model-1295", "Name-1295", "Specification-1295", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1296, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3799), true, 2, "Code-1296", "Model-1296", "Name-1296", "Specification-1296", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1297, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3803), false, 1, "Code-1297", "Model-1297", "Name-1297", "Specification-1297", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1298, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3809), true, 1, "Code-1298", "Model-1298", "Name-1298", "Specification-1298", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1299, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3813), false, 1, "Code-1299", "Model-1299", "Name-1299", "Specification-1299", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1300, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3818), true, 2, "Code-1300", "Model-1300", "Name-1300", "Specification-1300", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1301, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3822), false, 2, "Code-1301", "Model-1301", "Name-1301", "Specification-1301", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1302, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3827), true, 1, "Code-1302", "Model-1302", "Name-1302", "Specification-1302", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1303, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3831), false, 1, "Code-1303", "Model-1303", "Name-1303", "Specification-1303", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1304, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3837), true, 1, "Code-1304", "Model-1304", "Name-1304", "Specification-1304", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1305, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3841), false, 2, "Code-1305", "Model-1305", "Name-1305", "Specification-1305", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1306, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3846), true, 1, "Code-1306", "Model-1306", "Name-1306", "Specification-1306", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1307, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3850), false, 2, "Code-1307", "Model-1307", "Name-1307", "Specification-1307", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1308, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3855), true, 2, "Code-1308", "Model-1308", "Name-1308", "Specification-1308", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1309, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3859), false, 2, "Code-1309", "Model-1309", "Name-1309", "Specification-1309", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1310, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3865), true, 2, "Code-1310", "Model-1310", "Name-1310", "Specification-1310", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1311, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3869), false, 1, "Code-1311", "Model-1311", "Name-1311", "Specification-1311", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1312, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3874), true, 1, "Code-1312", "Model-1312", "Name-1312", "Specification-1312", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1313, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3878), false, 1, "Code-1313", "Model-1313", "Name-1313", "Specification-1313", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1314, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3887), true, 1, "Code-1314", "Model-1314", "Name-1314", "Specification-1314", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1315, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3891), false, 1, "Code-1315", "Model-1315", "Name-1315", "Specification-1315", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1316, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3896), true, 2, "Code-1316", "Model-1316", "Name-1316", "Specification-1316", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1317, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3900), false, 2, "Code-1317", "Model-1317", "Name-1317", "Specification-1317", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1318, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3905), true, 1, "Code-1318", "Model-1318", "Name-1318", "Specification-1318", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1319, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3909), false, 2, "Code-1319", "Model-1319", "Name-1319", "Specification-1319", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1320, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3915), true, 2, "Code-1320", "Model-1320", "Name-1320", "Specification-1320", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1321, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3919), false, 2, "Code-1321", "Model-1321", "Name-1321", "Specification-1321", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1322, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3925), true, 2, "Code-1322", "Model-1322", "Name-1322", "Specification-1322", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1323, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3928), false, 2, "Code-1323", "Model-1323", "Name-1323", "Specification-1323", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1324, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3934), true, 1, "Code-1324", "Model-1324", "Name-1324", "Specification-1324", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1325, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3938), false, 1, "Code-1325", "Model-1325", "Name-1325", "Specification-1325", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1326, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3944), true, 2, "Code-1326", "Model-1326", "Name-1326", "Specification-1326", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1327, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3948), false, 2, "Code-1327", "Model-1327", "Name-1327", "Specification-1327", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1328, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3953), true, 2, "Code-1328", "Model-1328", "Name-1328", "Specification-1328", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1329, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3957), false, 1, "Code-1329", "Model-1329", "Name-1329", "Specification-1329", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1330, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3962), true, 2, "Code-1330", "Model-1330", "Name-1330", "Specification-1330", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1331, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3966), false, 2, "Code-1331", "Model-1331", "Name-1331", "Specification-1331", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1332, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3971), true, 1, "Code-1332", "Model-1332", "Name-1332", "Specification-1332", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1333, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3978), false, 2, "Code-1333", "Model-1333", "Name-1333", "Specification-1333", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1334, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3984), true, 2, "Code-1334", "Model-1334", "Name-1334", "Specification-1334", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1335, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3988), false, 2, "Code-1335", "Model-1335", "Name-1335", "Specification-1335", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1336, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3993), true, 2, "Code-1336", "Model-1336", "Name-1336", "Specification-1336", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1337, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(3997), false, 2, "Code-1337", "Model-1337", "Name-1337", "Specification-1337", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1338, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4003), true, 1, "Code-1338", "Model-1338", "Name-1338", "Specification-1338", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1339, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4006), false, 2, "Code-1339", "Model-1339", "Name-1339", "Specification-1339", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1340, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4012), true, 2, "Code-1340", "Model-1340", "Name-1340", "Specification-1340", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1341, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4016), false, 2, "Code-1341", "Model-1341", "Name-1341", "Specification-1341", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1342, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4021), true, 1, "Code-1342", "Model-1342", "Name-1342", "Specification-1342", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1343, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4025), false, 1, "Code-1343", "Model-1343", "Name-1343", "Specification-1343", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1344, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4031), true, 2, "Code-1344", "Model-1344", "Name-1344", "Specification-1344", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1345, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4035), false, 1, "Code-1345", "Model-1345", "Name-1345", "Specification-1345", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1346, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4040), true, 2, "Code-1346", "Model-1346", "Name-1346", "Specification-1346", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1347, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4044), false, 2, "Code-1347", "Model-1347", "Name-1347", "Specification-1347", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1348, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4049), true, 2, "Code-1348", "Model-1348", "Name-1348", "Specification-1348", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1349, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4053), false, 2, "Code-1349", "Model-1349", "Name-1349", "Specification-1349", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1350, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4059), true, 2, "Code-1350", "Model-1350", "Name-1350", "Specification-1350", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1351, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4066), false, 2, "Code-1351", "Model-1351", "Name-1351", "Specification-1351", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1352, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4072), true, 2, "Code-1352", "Model-1352", "Name-1352", "Specification-1352", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1353, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4076), false, 1, "Code-1353", "Model-1353", "Name-1353", "Specification-1353", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1354, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4082), true, 1, "Code-1354", "Model-1354", "Name-1354", "Specification-1354", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1355, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4086), false, 2, "Code-1355", "Model-1355", "Name-1355", "Specification-1355", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1356, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4091), true, 2, "Code-1356", "Model-1356", "Name-1356", "Specification-1356", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1357, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4095), false, 2, "Code-1357", "Model-1357", "Name-1357", "Specification-1357", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1358, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4101), true, 2, "Code-1358", "Model-1358", "Name-1358", "Specification-1358", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1359, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4105), false, 1, "Code-1359", "Model-1359", "Name-1359", "Specification-1359", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1360, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4110), true, 1, "Code-1360", "Model-1360", "Name-1360", "Specification-1360", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1361, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4114), false, 1, "Code-1361", "Model-1361", "Name-1361", "Specification-1361", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1362, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4119), true, 1, "Code-1362", "Model-1362", "Name-1362", "Specification-1362", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1363, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4123), false, 2, "Code-1363", "Model-1363", "Name-1363", "Specification-1363", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1364, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4129), true, 1, "Code-1364", "Model-1364", "Name-1364", "Specification-1364", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1365, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4132), false, 2, "Code-1365", "Model-1365", "Name-1365", "Specification-1365", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1366, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4138), true, 1, "Code-1366", "Model-1366", "Name-1366", "Specification-1366", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1367, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4142), false, 2, "Code-1367", "Model-1367", "Name-1367", "Specification-1367", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1368, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4148), true, 1, "Code-1368", "Model-1368", "Name-1368", "Specification-1368", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1369, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4151), false, 1, "Code-1369", "Model-1369", "Name-1369", "Specification-1369", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1370, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4160), true, 2, "Code-1370", "Model-1370", "Name-1370", "Specification-1370", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1371, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4164), false, 1, "Code-1371", "Model-1371", "Name-1371", "Specification-1371", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1372, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4170), true, 1, "Code-1372", "Model-1372", "Name-1372", "Specification-1372", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1373, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4174), false, 1, "Code-1373", "Model-1373", "Name-1373", "Specification-1373", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1374, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4179), true, 1, "Code-1374", "Model-1374", "Name-1374", "Specification-1374", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1375, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4183), false, 1, "Code-1375", "Model-1375", "Name-1375", "Specification-1375", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1376, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4189), true, 1, "Code-1376", "Model-1376", "Name-1376", "Specification-1376", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1377, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4193), false, 1, "Code-1377", "Model-1377", "Name-1377", "Specification-1377", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1378, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4199), true, 2, "Code-1378", "Model-1378", "Name-1378", "Specification-1378", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1379, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4203), false, 2, "Code-1379", "Model-1379", "Name-1379", "Specification-1379", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1380, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4208), true, 1, "Code-1380", "Model-1380", "Name-1380", "Specification-1380", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1381, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4212), false, 1, "Code-1381", "Model-1381", "Name-1381", "Specification-1381", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1382, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4218), true, 2, "Code-1382", "Model-1382", "Name-1382", "Specification-1382", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1383, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4222), false, 1, "Code-1383", "Model-1383", "Name-1383", "Specification-1383", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1384, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4227), true, 2, "Code-1384", "Model-1384", "Name-1384", "Specification-1384", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1385, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4231), false, 1, "Code-1385", "Model-1385", "Name-1385", "Specification-1385", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1386, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4237), true, 1, "Code-1386", "Model-1386", "Name-1386", "Specification-1386", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1387, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4241), false, 1, "Code-1387", "Model-1387", "Name-1387", "Specification-1387", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1388, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4246), true, 2, "Code-1388", "Model-1388", "Name-1388", "Specification-1388", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1389, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4255), false, 1, "Code-1389", "Model-1389", "Name-1389", "Specification-1389", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1390, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4261), true, 2, "Code-1390", "Model-1390", "Name-1390", "Specification-1390", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1391, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4265), false, 1, "Code-1391", "Model-1391", "Name-1391", "Specification-1391", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1392, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4270), true, 2, "Code-1392", "Model-1392", "Name-1392", "Specification-1392", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1393, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4274), false, 2, "Code-1393", "Model-1393", "Name-1393", "Specification-1393", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1394, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4279), true, 2, "Code-1394", "Model-1394", "Name-1394", "Specification-1394", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1395, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4283), false, 2, "Code-1395", "Model-1395", "Name-1395", "Specification-1395", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1396, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4288), true, 2, "Code-1396", "Model-1396", "Name-1396", "Specification-1396", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1397, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4292), false, 2, "Code-1397", "Model-1397", "Name-1397", "Specification-1397", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1398, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4297), true, 2, "Code-1398", "Model-1398", "Name-1398", "Specification-1398", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1399, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4301), false, 1, "Code-1399", "Model-1399", "Name-1399", "Specification-1399", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1400, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4307), true, 2, "Code-1400", "Model-1400", "Name-1400", "Specification-1400", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1401, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4311), false, 1, "Code-1401", "Model-1401", "Name-1401", "Specification-1401", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1402, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4316), true, 1, "Code-1402", "Model-1402", "Name-1402", "Specification-1402", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1403, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4320), false, 2, "Code-1403", "Model-1403", "Name-1403", "Specification-1403", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1404, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4325), true, 1, "Code-1404", "Model-1404", "Name-1404", "Specification-1404", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1405, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4329), false, 1, "Code-1405", "Model-1405", "Name-1405", "Specification-1405", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1406, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4335), true, 1, "Code-1406", "Model-1406", "Name-1406", "Specification-1406", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1407, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4339), false, 2, "Code-1407", "Model-1407", "Name-1407", "Specification-1407", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1408, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4347), true, 1, "Code-1408", "Model-1408", "Name-1408", "Specification-1408", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1409, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4351), false, 1, "Code-1409", "Model-1409", "Name-1409", "Specification-1409", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1410, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4357), true, 2, "Code-1410", "Model-1410", "Name-1410", "Specification-1410", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1411, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4361), false, 2, "Code-1411", "Model-1411", "Name-1411", "Specification-1411", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1412, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4367), true, 2, "Code-1412", "Model-1412", "Name-1412", "Specification-1412", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1413, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4371), false, 2, "Code-1413", "Model-1413", "Name-1413", "Specification-1413", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1414, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4376), true, 2, "Code-1414", "Model-1414", "Name-1414", "Specification-1414", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1415, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4380), false, 1, "Code-1415", "Model-1415", "Name-1415", "Specification-1415", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1416, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4385), true, 1, "Code-1416", "Model-1416", "Name-1416", "Specification-1416", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1417, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4389), false, 2, "Code-1417", "Model-1417", "Name-1417", "Specification-1417", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1418, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4395), true, 2, "Code-1418", "Model-1418", "Name-1418", "Specification-1418", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1419, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4399), false, 1, "Code-1419", "Model-1419", "Name-1419", "Specification-1419", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1420, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4404), true, 1, "Code-1420", "Model-1420", "Name-1420", "Specification-1420", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1421, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4408), false, 1, "Code-1421", "Model-1421", "Name-1421", "Specification-1421", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1422, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4414), true, 2, "Code-1422", "Model-1422", "Name-1422", "Specification-1422", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1423, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4418), false, 2, "Code-1423", "Model-1423", "Name-1423", "Specification-1423", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1424, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4424), true, 2, "Code-1424", "Model-1424", "Name-1424", "Specification-1424", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1425, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4428), false, 2, "Code-1425", "Model-1425", "Name-1425", "Specification-1425", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1426, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4433), true, 2, "Code-1426", "Model-1426", "Name-1426", "Specification-1426", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1427, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4441), false, 2, "Code-1427", "Model-1427", "Name-1427", "Specification-1427", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1428, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4446), true, 1, "Code-1428", "Model-1428", "Name-1428", "Specification-1428", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1429, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4450), false, 2, "Code-1429", "Model-1429", "Name-1429", "Specification-1429", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1430, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4456), true, 1, "Code-1430", "Model-1430", "Name-1430", "Specification-1430", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1431, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4461), false, 2, "Code-1431", "Model-1431", "Name-1431", "Specification-1431", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1432, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4466), true, 2, "Code-1432", "Model-1432", "Name-1432", "Specification-1432", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1433, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4470), false, 2, "Code-1433", "Model-1433", "Name-1433", "Specification-1433", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1434, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4476), true, 2, "Code-1434", "Model-1434", "Name-1434", "Specification-1434", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1435, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4480), false, 1, "Code-1435", "Model-1435", "Name-1435", "Specification-1435", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1436, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4485), true, 1, "Code-1436", "Model-1436", "Name-1436", "Specification-1436", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1437, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4489), false, 1, "Code-1437", "Model-1437", "Name-1437", "Specification-1437", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1438, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4495), true, 1, "Code-1438", "Model-1438", "Name-1438", "Specification-1438", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1439, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4498), false, 1, "Code-1439", "Model-1439", "Name-1439", "Specification-1439", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1440, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4504), true, 1, "Code-1440", "Model-1440", "Name-1440", "Specification-1440", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1441, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4508), false, 2, "Code-1441", "Model-1441", "Name-1441", "Specification-1441", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1442, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4513), true, 1, "Code-1442", "Model-1442", "Name-1442", "Specification-1442", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1443, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4517), false, 2, "Code-1443", "Model-1443", "Name-1443", "Specification-1443", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1444, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4523), true, 2, "Code-1444", "Model-1444", "Name-1444", "Specification-1444", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1445, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4526), false, 1, "Code-1445", "Model-1445", "Name-1445", "Specification-1445", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1446, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4535), true, 1, "Code-1446", "Model-1446", "Name-1446", "Specification-1446", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1447, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4539), false, 1, "Code-1447", "Model-1447", "Name-1447", "Specification-1447", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1448, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4544), true, 1, "Code-1448", "Model-1448", "Name-1448", "Specification-1448", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1449, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4548), false, 1, "Code-1449", "Model-1449", "Name-1449", "Specification-1449", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1450, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4554), true, 1, "Code-1450", "Model-1450", "Name-1450", "Specification-1450", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1451, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4557), false, 1, "Code-1451", "Model-1451", "Name-1451", "Specification-1451", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1452, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4563), true, 1, "Code-1452", "Model-1452", "Name-1452", "Specification-1452", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1453, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4567), false, 1, "Code-1453", "Model-1453", "Name-1453", "Specification-1453", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1454, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4573), true, 1, "Code-1454", "Model-1454", "Name-1454", "Specification-1454", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1455, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4577), false, 1, "Code-1455", "Model-1455", "Name-1455", "Specification-1455", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1456, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4582), true, 1, "Code-1456", "Model-1456", "Name-1456", "Specification-1456", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1457, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4586), false, 2, "Code-1457", "Model-1457", "Name-1457", "Specification-1457", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1458, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4591), true, 2, "Code-1458", "Model-1458", "Name-1458", "Specification-1458", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1459, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4595), false, 1, "Code-1459", "Model-1459", "Name-1459", "Specification-1459", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1460, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4601), true, 1, "Code-1460", "Model-1460", "Name-1460", "Specification-1460", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1461, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4605), false, 2, "Code-1461", "Model-1461", "Name-1461", "Specification-1461", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1462, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4610), true, 2, "Code-1462", "Model-1462", "Name-1462", "Specification-1462", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1463, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4614), false, 2, "Code-1463", "Model-1463", "Name-1463", "Specification-1463", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1464, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4620), true, 2, "Code-1464", "Model-1464", "Name-1464", "Specification-1464", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1465, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4627), false, 2, "Code-1465", "Model-1465", "Name-1465", "Specification-1465", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1466, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4633), true, 2, "Code-1466", "Model-1466", "Name-1466", "Specification-1466", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1467, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4637), false, 1, "Code-1467", "Model-1467", "Name-1467", "Specification-1467", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1468, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4642), true, 1, "Code-1468", "Model-1468", "Name-1468", "Specification-1468", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1469, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4646), false, 2, "Code-1469", "Model-1469", "Name-1469", "Specification-1469", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1470, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4652), true, 1, "Code-1470", "Model-1470", "Name-1470", "Specification-1470", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1471, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4656), false, 2, "Code-1471", "Model-1471", "Name-1471", "Specification-1471", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1472, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4661), true, 2, "Code-1472", "Model-1472", "Name-1472", "Specification-1472", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1473, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4665), false, 2, "Code-1473", "Model-1473", "Name-1473", "Specification-1473", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1474, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4671), true, 2, "Code-1474", "Model-1474", "Name-1474", "Specification-1474", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1475, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4675), false, 2, "Code-1475", "Model-1475", "Name-1475", "Specification-1475", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1476, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4680), true, 2, "Code-1476", "Model-1476", "Name-1476", "Specification-1476", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1477, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4684), false, 2, "Code-1477", "Model-1477", "Name-1477", "Specification-1477", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1478, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4690), true, 2, "Code-1478", "Model-1478", "Name-1478", "Specification-1478", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1479, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4694), false, 1, "Code-1479", "Model-1479", "Name-1479", "Specification-1479", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1480, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4699), true, 1, "Code-1480", "Model-1480", "Name-1480", "Specification-1480", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1481, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4703), false, 1, "Code-1481", "Model-1481", "Name-1481", "Specification-1481", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1482, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4709), true, 2, "Code-1482", "Model-1482", "Name-1482", "Specification-1482", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1483, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4713), false, 1, "Code-1483", "Model-1483", "Name-1483", "Specification-1483", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1484, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4723), true, 2, "Code-1484", "Model-1484", "Name-1484", "Specification-1484", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1485, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4726), false, 1, "Code-1485", "Model-1485", "Name-1485", "Specification-1485", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1486, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4732), true, 1, "Code-1486", "Model-1486", "Name-1486", "Specification-1486", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1487, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4735), false, 2, "Code-1487", "Model-1487", "Name-1487", "Specification-1487", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1488, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4741), true, 1, "Code-1488", "Model-1488", "Name-1488", "Specification-1488", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1489, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4745), false, 2, "Code-1489", "Model-1489", "Name-1489", "Specification-1489", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1490, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4751), true, 1, "Code-1490", "Model-1490", "Name-1490", "Specification-1490", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1491, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4755), false, 1, "Code-1491", "Model-1491", "Name-1491", "Specification-1491", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1492, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4760), true, 1, "Code-1492", "Model-1492", "Name-1492", "Specification-1492", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1493, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4764), false, 2, "Code-1493", "Model-1493", "Name-1493", "Specification-1493", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1494, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4770), true, 2, "Code-1494", "Model-1494", "Name-1494", "Specification-1494", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1495, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4774), false, 1, "Code-1495", "Model-1495", "Name-1495", "Specification-1495", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1496, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4779), true, 1, "Code-1496", "Model-1496", "Name-1496", "Specification-1496", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1497, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4783), false, 2, "Code-1497", "Model-1497", "Name-1497", "Specification-1497", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1498, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4788), true, 1, "Code-1498", "Model-1498", "Name-1498", "Specification-1498", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1499, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4792), false, 1, "Code-1499", "Model-1499", "Name-1499", "Specification-1499", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1500, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4798), true, 1, "Code-1500", "Model-1500", "Name-1500", "Specification-1500", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1501, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4802), false, 1, "Code-1501", "Model-1501", "Name-1501", "Specification-1501", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1502, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4807), true, 2, "Code-1502", "Model-1502", "Name-1502", "Specification-1502", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1503, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4814), false, 2, "Code-1503", "Model-1503", "Name-1503", "Specification-1503", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1504, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4820), true, 2, "Code-1504", "Model-1504", "Name-1504", "Specification-1504", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1505, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4824), false, 2, "Code-1505", "Model-1505", "Name-1505", "Specification-1505", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1506, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4829), true, 1, "Code-1506", "Model-1506", "Name-1506", "Specification-1506", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1507, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4833), false, 1, "Code-1507", "Model-1507", "Name-1507", "Specification-1507", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1508, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4838), true, 1, "Code-1508", "Model-1508", "Name-1508", "Specification-1508", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1509, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4842), false, 2, "Code-1509", "Model-1509", "Name-1509", "Specification-1509", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1510, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4847), true, 1, "Code-1510", "Model-1510", "Name-1510", "Specification-1510", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1511, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4851), false, 1, "Code-1511", "Model-1511", "Name-1511", "Specification-1511", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1512, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4857), true, 1, "Code-1512", "Model-1512", "Name-1512", "Specification-1512", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1513, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4866), false, 2, "Code-1513", "Model-1513", "Name-1513", "Specification-1513", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1514, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4872), true, 1, "Code-1514", "Model-1514", "Name-1514", "Specification-1514", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1515, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4876), false, 1, "Code-1515", "Model-1515", "Name-1515", "Specification-1515", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1516, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4882), true, 2, "Code-1516", "Model-1516", "Name-1516", "Specification-1516", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1517, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4886), false, 2, "Code-1517", "Model-1517", "Name-1517", "Specification-1517", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1518, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4892), true, 1, "Code-1518", "Model-1518", "Name-1518", "Specification-1518", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1519, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4896), false, 2, "Code-1519", "Model-1519", "Name-1519", "Specification-1519", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1520, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4901), true, 2, "Code-1520", "Model-1520", "Name-1520", "Specification-1520", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1521, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4906), false, 2, "Code-1521", "Model-1521", "Name-1521", "Specification-1521", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1522, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4914), true, 1, "Code-1522", "Model-1522", "Name-1522", "Specification-1522", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1523, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4918), false, 2, "Code-1523", "Model-1523", "Name-1523", "Specification-1523", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1524, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4923), true, 1, "Code-1524", "Model-1524", "Name-1524", "Specification-1524", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1525, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4927), false, 1, "Code-1525", "Model-1525", "Name-1525", "Specification-1525", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1526, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4932), true, 1, "Code-1526", "Model-1526", "Name-1526", "Specification-1526", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1527, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4936), false, 2, "Code-1527", "Model-1527", "Name-1527", "Specification-1527", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1528, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4941), true, 1, "Code-1528", "Model-1528", "Name-1528", "Specification-1528", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1529, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4945), false, 2, "Code-1529", "Model-1529", "Name-1529", "Specification-1529", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1530, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4951), true, 2, "Code-1530", "Model-1530", "Name-1530", "Specification-1530", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1531, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4955), false, 2, "Code-1531", "Model-1531", "Name-1531", "Specification-1531", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1532, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4961), true, 1, "Code-1532", "Model-1532", "Name-1532", "Specification-1532", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1533, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4965), false, 1, "Code-1533", "Model-1533", "Name-1533", "Specification-1533", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1534, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4970), true, 2, "Code-1534", "Model-1534", "Name-1534", "Specification-1534", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1535, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4974), false, 2, "Code-1535", "Model-1535", "Name-1535", "Specification-1535", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1536, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4979), true, 1, "Code-1536", "Model-1536", "Name-1536", "Specification-1536", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1537, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4984), false, 2, "Code-1537", "Model-1537", "Name-1537", "Specification-1537", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1538, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4989), true, 1, "Code-1538", "Model-1538", "Name-1538", "Specification-1538", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1539, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4993), false, 1, "Code-1539", "Model-1539", "Name-1539", "Specification-1539", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1540, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(4999), true, 2, "Code-1540", "Model-1540", "Name-1540", "Specification-1540", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1541, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5005), false, 1, "Code-1541", "Model-1541", "Name-1541", "Specification-1541", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1542, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5011), true, 2, "Code-1542", "Model-1542", "Name-1542", "Specification-1542", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1543, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5015), false, 2, "Code-1543", "Model-1543", "Name-1543", "Specification-1543", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1544, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5020), true, 2, "Code-1544", "Model-1544", "Name-1544", "Specification-1544", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1545, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5024), false, 2, "Code-1545", "Model-1545", "Name-1545", "Specification-1545", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1546, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5029), true, 1, "Code-1546", "Model-1546", "Name-1546", "Specification-1546", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1547, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5033), false, 1, "Code-1547", "Model-1547", "Name-1547", "Specification-1547", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1548, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5038), true, 1, "Code-1548", "Model-1548", "Name-1548", "Specification-1548", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1549, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5042), false, 2, "Code-1549", "Model-1549", "Name-1549", "Specification-1549", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1550, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5048), true, 1, "Code-1550", "Model-1550", "Name-1550", "Specification-1550", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1551, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5052), false, 2, "Code-1551", "Model-1551", "Name-1551", "Specification-1551", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1552, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5057), true, 1, "Code-1552", "Model-1552", "Name-1552", "Specification-1552", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1553, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5061), false, 2, "Code-1553", "Model-1553", "Name-1553", "Specification-1553", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1554, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5067), true, 1, "Code-1554", "Model-1554", "Name-1554", "Specification-1554", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1555, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5071), false, 2, "Code-1555", "Model-1555", "Name-1555", "Specification-1555", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1556, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5076), true, 2, "Code-1556", "Model-1556", "Name-1556", "Specification-1556", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1557, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5080), false, 2, "Code-1557", "Model-1557", "Name-1557", "Specification-1557", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1558, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5086), true, 2, "Code-1558", "Model-1558", "Name-1558", "Specification-1558", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1559, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5092), false, 2, "Code-1559", "Model-1559", "Name-1559", "Specification-1559", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1560, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5098), true, 2, "Code-1560", "Model-1560", "Name-1560", "Specification-1560", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1561, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5102), false, 1, "Code-1561", "Model-1561", "Name-1561", "Specification-1561", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1562, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5108), true, 1, "Code-1562", "Model-1562", "Name-1562", "Specification-1562", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1563, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5112), false, 2, "Code-1563", "Model-1563", "Name-1563", "Specification-1563", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1564, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5117), true, 2, "Code-1564", "Model-1564", "Name-1564", "Specification-1564", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1565, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5121), false, 1, "Code-1565", "Model-1565", "Name-1565", "Specification-1565", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1566, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5127), true, 1, "Code-1566", "Model-1566", "Name-1566", "Specification-1566", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1567, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5131), false, 1, "Code-1567", "Model-1567", "Name-1567", "Specification-1567", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1568, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5136), true, 2, "Code-1568", "Model-1568", "Name-1568", "Specification-1568", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1569, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5140), false, 2, "Code-1569", "Model-1569", "Name-1569", "Specification-1569", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1570, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5145), true, 1, "Code-1570", "Model-1570", "Name-1570", "Specification-1570", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1571, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5149), false, 2, "Code-1571", "Model-1571", "Name-1571", "Specification-1571", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1572, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5155), true, 1, "Code-1572", "Model-1572", "Name-1572", "Specification-1572", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1573, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5159), false, 2, "Code-1573", "Model-1573", "Name-1573", "Specification-1573", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1574, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5164), true, 1, "Code-1574", "Model-1574", "Name-1574", "Specification-1574", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1575, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5168), false, 2, "Code-1575", "Model-1575", "Name-1575", "Specification-1575", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1576, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5174), true, 1, "Code-1576", "Model-1576", "Name-1576", "Specification-1576", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1577, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5178), false, 1, "Code-1577", "Model-1577", "Name-1577", "Specification-1577", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1578, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5186), true, 2, "Code-1578", "Model-1578", "Name-1578", "Specification-1578", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1579, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5190), false, 1, "Code-1579", "Model-1579", "Name-1579", "Specification-1579", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1580, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5196), true, 2, "Code-1580", "Model-1580", "Name-1580", "Specification-1580", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1581, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5200), false, 2, "Code-1581", "Model-1581", "Name-1581", "Specification-1581", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1582, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5205), true, 1, "Code-1582", "Model-1582", "Name-1582", "Specification-1582", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1583, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5209), false, 2, "Code-1583", "Model-1583", "Name-1583", "Specification-1583", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1584, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5215), true, 1, "Code-1584", "Model-1584", "Name-1584", "Specification-1584", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1585, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5219), false, 2, "Code-1585", "Model-1585", "Name-1585", "Specification-1585", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1586, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5224), true, 1, "Code-1586", "Model-1586", "Name-1586", "Specification-1586", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1587, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5228), false, 1, "Code-1587", "Model-1587", "Name-1587", "Specification-1587", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1588, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5234), true, 2, "Code-1588", "Model-1588", "Name-1588", "Specification-1588", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1589, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5238), false, 2, "Code-1589", "Model-1589", "Name-1589", "Specification-1589", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1590, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5243), true, 1, "Code-1590", "Model-1590", "Name-1590", "Specification-1590", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1591, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5247), false, 2, "Code-1591", "Model-1591", "Name-1591", "Specification-1591", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1592, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5252), true, 2, "Code-1592", "Model-1592", "Name-1592", "Specification-1592", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1593, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5256), false, 1, "Code-1593", "Model-1593", "Name-1593", "Specification-1593", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1594, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5262), true, 1, "Code-1594", "Model-1594", "Name-1594", "Specification-1594", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1595, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5266), false, 1, "Code-1595", "Model-1595", "Name-1595", "Specification-1595", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1596, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5272), true, 1, "Code-1596", "Model-1596", "Name-1596", "Specification-1596", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1597, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5279), false, 2, "Code-1597", "Model-1597", "Name-1597", "Specification-1597", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1598, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5284), true, 2, "Code-1598", "Model-1598", "Name-1598", "Specification-1598", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1599, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5288), false, 2, "Code-1599", "Model-1599", "Name-1599", "Specification-1599", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1600, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5294), true, 2, "Code-1600", "Model-1600", "Name-1600", "Specification-1600", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1601, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5298), false, 2, "Code-1601", "Model-1601", "Name-1601", "Specification-1601", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1602, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5303), true, 1, "Code-1602", "Model-1602", "Name-1602", "Specification-1602", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1603, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5307), false, 1, "Code-1603", "Model-1603", "Name-1603", "Specification-1603", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1604, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5312), true, 1, "Code-1604", "Model-1604", "Name-1604", "Specification-1604", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1605, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5316), false, 2, "Code-1605", "Model-1605", "Name-1605", "Specification-1605", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1606, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5322), true, 1, "Code-1606", "Model-1606", "Name-1606", "Specification-1606", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1607, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5326), false, 1, "Code-1607", "Model-1607", "Name-1607", "Specification-1607", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1608, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5331), true, 1, "Code-1608", "Model-1608", "Name-1608", "Specification-1608", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1609, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5335), false, 1, "Code-1609", "Model-1609", "Name-1609", "Specification-1609", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1610, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5340), true, 1, "Code-1610", "Model-1610", "Name-1610", "Specification-1610", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1611, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5344), false, 2, "Code-1611", "Model-1611", "Name-1611", "Specification-1611", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1612, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5350), true, 2, "Code-1612", "Model-1612", "Name-1612", "Specification-1612", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1613, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5353), false, 1, "Code-1613", "Model-1613", "Name-1613", "Specification-1613", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1614, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5359), true, 2, "Code-1614", "Model-1614", "Name-1614", "Specification-1614", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1615, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5363), false, 2, "Code-1615", "Model-1615", "Name-1615", "Specification-1615", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1616, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5372), true, 1, "Code-1616", "Model-1616", "Name-1616", "Specification-1616", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1617, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5375), false, 2, "Code-1617", "Model-1617", "Name-1617", "Specification-1617", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1618, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5381), true, 1, "Code-1618", "Model-1618", "Name-1618", "Specification-1618", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1619, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5385), false, 1, "Code-1619", "Model-1619", "Name-1619", "Specification-1619", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1620, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5391), true, 2, "Code-1620", "Model-1620", "Name-1620", "Specification-1620", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1621, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5395), false, 2, "Code-1621", "Model-1621", "Name-1621", "Specification-1621", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1622, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5400), true, 1, "Code-1622", "Model-1622", "Name-1622", "Specification-1622", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1623, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5404), false, 2, "Code-1623", "Model-1623", "Name-1623", "Specification-1623", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1624, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5410), true, 1, "Code-1624", "Model-1624", "Name-1624", "Specification-1624", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1625, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5413), false, 1, "Code-1625", "Model-1625", "Name-1625", "Specification-1625", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1626, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5419), true, 2, "Code-1626", "Model-1626", "Name-1626", "Specification-1626", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1627, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5423), false, 2, "Code-1627", "Model-1627", "Name-1627", "Specification-1627", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1628, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5429), true, 1, "Code-1628", "Model-1628", "Name-1628", "Specification-1628", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1629, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5433), false, 2, "Code-1629", "Model-1629", "Name-1629", "Specification-1629", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1630, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5438), true, 2, "Code-1630", "Model-1630", "Name-1630", "Specification-1630", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1631, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5442), false, 2, "Code-1631", "Model-1631", "Name-1631", "Specification-1631", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1632, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5447), true, 1, "Code-1632", "Model-1632", "Name-1632", "Specification-1632", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1633, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5451), false, 2, "Code-1633", "Model-1633", "Name-1633", "Specification-1633", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1634, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5457), true, 1, "Code-1634", "Model-1634", "Name-1634", "Specification-1634", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1635, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5464), false, 2, "Code-1635", "Model-1635", "Name-1635", "Specification-1635", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1636, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5470), true, 2, "Code-1636", "Model-1636", "Name-1636", "Specification-1636", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1637, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5474), false, 1, "Code-1637", "Model-1637", "Name-1637", "Specification-1637", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1638, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5479), true, 2, "Code-1638", "Model-1638", "Name-1638", "Specification-1638", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1639, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5483), false, 2, "Code-1639", "Model-1639", "Name-1639", "Specification-1639", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1640, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5489), true, 1, "Code-1640", "Model-1640", "Name-1640", "Specification-1640", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1641, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5492), false, 1, "Code-1641", "Model-1641", "Name-1641", "Specification-1641", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1642, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5498), true, 1, "Code-1642", "Model-1642", "Name-1642", "Specification-1642", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1643, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5502), false, 2, "Code-1643", "Model-1643", "Name-1643", "Specification-1643", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1644, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5507), true, 1, "Code-1644", "Model-1644", "Name-1644", "Specification-1644", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1645, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5511), false, 1, "Code-1645", "Model-1645", "Name-1645", "Specification-1645", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1646, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5517), true, 1, "Code-1646", "Model-1646", "Name-1646", "Specification-1646", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1647, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5521), false, 2, "Code-1647", "Model-1647", "Name-1647", "Specification-1647", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1648, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5526), true, 2, "Code-1648", "Model-1648", "Name-1648", "Specification-1648", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1649, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5530), false, 2, "Code-1649", "Model-1649", "Name-1649", "Specification-1649", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1650, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5535), true, 1, "Code-1650", "Model-1650", "Name-1650", "Specification-1650", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1651, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5539), false, 2, "Code-1651", "Model-1651", "Name-1651", "Specification-1651", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1652, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5544), true, 2, "Code-1652", "Model-1652", "Name-1652", "Specification-1652", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1653, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5548), false, 2, "Code-1653", "Model-1653", "Name-1653", "Specification-1653", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1654, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5556), true, 2, "Code-1654", "Model-1654", "Name-1654", "Specification-1654", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1655, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5560), false, 2, "Code-1655", "Model-1655", "Name-1655", "Specification-1655", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1656, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5566), true, 2, "Code-1656", "Model-1656", "Name-1656", "Specification-1656", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1657, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5570), false, 1, "Code-1657", "Model-1657", "Name-1657", "Specification-1657", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1658, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5575), true, 2, "Code-1658", "Model-1658", "Name-1658", "Specification-1658", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1659, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5579), false, 2, "Code-1659", "Model-1659", "Name-1659", "Specification-1659", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1660, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5585), true, 1, "Code-1660", "Model-1660", "Name-1660", "Specification-1660", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1661, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5588), false, 2, "Code-1661", "Model-1661", "Name-1661", "Specification-1661", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1662, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5594), true, 1, "Code-1662", "Model-1662", "Name-1662", "Specification-1662", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1663, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5598), false, 2, "Code-1663", "Model-1663", "Name-1663", "Specification-1663", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1664, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5603), true, 2, "Code-1664", "Model-1664", "Name-1664", "Specification-1664", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1665, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5608), false, 1, "Code-1665", "Model-1665", "Name-1665", "Specification-1665", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1666, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5613), true, 2, "Code-1666", "Model-1666", "Name-1666", "Specification-1666", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1667, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5617), false, 2, "Code-1667", "Model-1667", "Name-1667", "Specification-1667", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1668, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5623), true, 2, "Code-1668", "Model-1668", "Name-1668", "Specification-1668", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1669, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5627), false, 2, "Code-1669", "Model-1669", "Name-1669", "Specification-1669", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1670, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5632), true, 2, "Code-1670", "Model-1670", "Name-1670", "Specification-1670", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1671, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5636), false, 1, "Code-1671", "Model-1671", "Name-1671", "Specification-1671", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1672, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5641), true, 1, "Code-1672", "Model-1672", "Name-1672", "Specification-1672", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1673, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5648), false, 1, "Code-1673", "Model-1673", "Name-1673", "Specification-1673", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1674, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5654), true, 2, "Code-1674", "Model-1674", "Name-1674", "Specification-1674", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1675, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5657), false, 2, "Code-1675", "Model-1675", "Name-1675", "Specification-1675", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1676, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5663), true, 1, "Code-1676", "Model-1676", "Name-1676", "Specification-1676", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1677, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5667), false, 1, "Code-1677", "Model-1677", "Name-1677", "Specification-1677", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1678, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5673), true, 1, "Code-1678", "Model-1678", "Name-1678", "Specification-1678", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1679, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5677), false, 1, "Code-1679", "Model-1679", "Name-1679", "Specification-1679", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1680, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5682), true, 1, "Code-1680", "Model-1680", "Name-1680", "Specification-1680", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1681, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5686), false, 1, "Code-1681", "Model-1681", "Name-1681", "Specification-1681", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1682, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5692), true, 2, "Code-1682", "Model-1682", "Name-1682", "Specification-1682", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1683, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5696), false, 1, "Code-1683", "Model-1683", "Name-1683", "Specification-1683", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1684, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5701), true, 2, "Code-1684", "Model-1684", "Name-1684", "Specification-1684", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1685, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5705), false, 2, "Code-1685", "Model-1685", "Name-1685", "Specification-1685", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1686, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5711), true, 1, "Code-1686", "Model-1686", "Name-1686", "Specification-1686", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1687, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5715), false, 1, "Code-1687", "Model-1687", "Name-1687", "Specification-1687", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1688, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5721), true, 1, "Code-1688", "Model-1688", "Name-1688", "Specification-1688", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1689, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5725), false, 1, "Code-1689", "Model-1689", "Name-1689", "Specification-1689", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1690, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5730), true, 1, "Code-1690", "Model-1690", "Name-1690", "Specification-1690", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1691, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5735), false, 1, "Code-1691", "Model-1691", "Name-1691", "Specification-1691", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1692, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5743), true, 2, "Code-1692", "Model-1692", "Name-1692", "Specification-1692", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1693, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5747), false, 1, "Code-1693", "Model-1693", "Name-1693", "Specification-1693", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1694, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5753), true, 1, "Code-1694", "Model-1694", "Name-1694", "Specification-1694", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1695, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5757), false, 2, "Code-1695", "Model-1695", "Name-1695", "Specification-1695", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1696, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5762), true, 2, "Code-1696", "Model-1696", "Name-1696", "Specification-1696", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1697, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5766), false, 1, "Code-1697", "Model-1697", "Name-1697", "Specification-1697", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1698, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5771), true, 2, "Code-1698", "Model-1698", "Name-1698", "Specification-1698", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1699, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5775), false, 1, "Code-1699", "Model-1699", "Name-1699", "Specification-1699", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1700, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5781), true, 1, "Code-1700", "Model-1700", "Name-1700", "Specification-1700", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1701, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5785), false, 2, "Code-1701", "Model-1701", "Name-1701", "Specification-1701", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1702, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5790), true, 2, "Code-1702", "Model-1702", "Name-1702", "Specification-1702", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1703, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5794), false, 1, "Code-1703", "Model-1703", "Name-1703", "Specification-1703", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1704, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5800), true, 2, "Code-1704", "Model-1704", "Name-1704", "Specification-1704", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1705, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5804), false, 2, "Code-1705", "Model-1705", "Name-1705", "Specification-1705", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1706, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5809), true, 2, "Code-1706", "Model-1706", "Name-1706", "Specification-1706", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1707, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5813), false, 2, "Code-1707", "Model-1707", "Name-1707", "Specification-1707", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1708, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5818), true, 1, "Code-1708", "Model-1708", "Name-1708", "Specification-1708", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1709, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5822), false, 2, "Code-1709", "Model-1709", "Name-1709", "Specification-1709", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1710, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5828), true, 1, "Code-1710", "Model-1710", "Name-1710", "Specification-1710", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1711, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5836), false, 1, "Code-1711", "Model-1711", "Name-1711", "Specification-1711", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1712, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5842), true, 1, "Code-1712", "Model-1712", "Name-1712", "Specification-1712", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1713, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5846), false, 1, "Code-1713", "Model-1713", "Name-1713", "Specification-1713", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1714, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5851), true, 2, "Code-1714", "Model-1714", "Name-1714", "Specification-1714", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1715, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5855), false, 2, "Code-1715", "Model-1715", "Name-1715", "Specification-1715", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1716, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5860), true, 2, "Code-1716", "Model-1716", "Name-1716", "Specification-1716", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1717, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5864), false, 1, "Code-1717", "Model-1717", "Name-1717", "Specification-1717", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1718, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5870), true, 2, "Code-1718", "Model-1718", "Name-1718", "Specification-1718", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1719, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5874), false, 1, "Code-1719", "Model-1719", "Name-1719", "Specification-1719", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1720, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5879), true, 2, "Code-1720", "Model-1720", "Name-1720", "Specification-1720", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1721, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5883), false, 2, "Code-1721", "Model-1721", "Name-1721", "Specification-1721", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1722, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5889), true, 2, "Code-1722", "Model-1722", "Name-1722", "Specification-1722", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1723, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5893), false, 1, "Code-1723", "Model-1723", "Name-1723", "Specification-1723", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1724, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5899), true, 2, "Code-1724", "Model-1724", "Name-1724", "Specification-1724", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1725, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5903), false, 1, "Code-1725", "Model-1725", "Name-1725", "Specification-1725", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1726, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5908), true, 1, "Code-1726", "Model-1726", "Name-1726", "Specification-1726", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1727, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5912), false, 1, "Code-1727", "Model-1727", "Name-1727", "Specification-1727", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1728, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5917), true, 2, "Code-1728", "Model-1728", "Name-1728", "Specification-1728", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1729, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5921), false, 1, "Code-1729", "Model-1729", "Name-1729", "Specification-1729", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1730, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5931), true, 1, "Code-1730", "Model-1730", "Name-1730", "Specification-1730", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1731, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5935), false, 1, "Code-1731", "Model-1731", "Name-1731", "Specification-1731", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1732, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5940), true, 1, "Code-1732", "Model-1732", "Name-1732", "Specification-1732", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1733, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5944), false, 1, "Code-1733", "Model-1733", "Name-1733", "Specification-1733", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1734, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5950), true, 2, "Code-1734", "Model-1734", "Name-1734", "Specification-1734", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1735, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5954), false, 1, "Code-1735", "Model-1735", "Name-1735", "Specification-1735", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1736, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5960), true, 2, "Code-1736", "Model-1736", "Name-1736", "Specification-1736", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1737, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5964), false, 2, "Code-1737", "Model-1737", "Name-1737", "Specification-1737", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1738, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5969), true, 1, "Code-1738", "Model-1738", "Name-1738", "Specification-1738", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1739, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5973), false, 2, "Code-1739", "Model-1739", "Name-1739", "Specification-1739", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1740, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5979), true, 2, "Code-1740", "Model-1740", "Name-1740", "Specification-1740", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1741, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5983), false, 2, "Code-1741", "Model-1741", "Name-1741", "Specification-1741", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1742, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5988), true, 1, "Code-1742", "Model-1742", "Name-1742", "Specification-1742", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1743, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5992), false, 1, "Code-1743", "Model-1743", "Name-1743", "Specification-1743", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1744, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(5998), true, 2, "Code-1744", "Model-1744", "Name-1744", "Specification-1744", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1745, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6002), false, 2, "Code-1745", "Model-1745", "Name-1745", "Specification-1745", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1746, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6007), true, 1, "Code-1746", "Model-1746", "Name-1746", "Specification-1746", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1747, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6012), false, 1, "Code-1747", "Model-1747", "Name-1747", "Specification-1747", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1748, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6020), true, 1, "Code-1748", "Model-1748", "Name-1748", "Specification-1748", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1749, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6024), false, 2, "Code-1749", "Model-1749", "Name-1749", "Specification-1749", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1750, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6030), true, 1, "Code-1750", "Model-1750", "Name-1750", "Specification-1750", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1751, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6034), false, 1, "Code-1751", "Model-1751", "Name-1751", "Specification-1751", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1752, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6039), true, 1, "Code-1752", "Model-1752", "Name-1752", "Specification-1752", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1753, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6043), false, 2, "Code-1753", "Model-1753", "Name-1753", "Specification-1753", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1754, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6049), true, 1, "Code-1754", "Model-1754", "Name-1754", "Specification-1754", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1755, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6053), false, 2, "Code-1755", "Model-1755", "Name-1755", "Specification-1755", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1756, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6058), true, 2, "Code-1756", "Model-1756", "Name-1756", "Specification-1756", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1757, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6062), false, 1, "Code-1757", "Model-1757", "Name-1757", "Specification-1757", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1758, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6067), true, 1, "Code-1758", "Model-1758", "Name-1758", "Specification-1758", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1759, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6071), false, 1, "Code-1759", "Model-1759", "Name-1759", "Specification-1759", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1760, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6077), true, 1, "Code-1760", "Model-1760", "Name-1760", "Specification-1760", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1761, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6081), false, 1, "Code-1761", "Model-1761", "Name-1761", "Specification-1761", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1762, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6086), true, 2, "Code-1762", "Model-1762", "Name-1762", "Specification-1762", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1763, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6090), false, 2, "Code-1763", "Model-1763", "Name-1763", "Specification-1763", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1764, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6095), true, 1, "Code-1764", "Model-1764", "Name-1764", "Specification-1764", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1765, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6099), false, 1, "Code-1765", "Model-1765", "Name-1765", "Specification-1765", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1766, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6105), true, 1, "Code-1766", "Model-1766", "Name-1766", "Specification-1766", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1767, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6112), false, 2, "Code-1767", "Model-1767", "Name-1767", "Specification-1767", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1768, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6118), true, 1, "Code-1768", "Model-1768", "Name-1768", "Specification-1768", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1769, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6122), false, 2, "Code-1769", "Model-1769", "Name-1769", "Specification-1769", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1770, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6127), true, 2, "Code-1770", "Model-1770", "Name-1770", "Specification-1770", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1771, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6131), false, 2, "Code-1771", "Model-1771", "Name-1771", "Specification-1771", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1772, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6136), true, 2, "Code-1772", "Model-1772", "Name-1772", "Specification-1772", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1773, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6140), false, 1, "Code-1773", "Model-1773", "Name-1773", "Specification-1773", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1774, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6145), true, 1, "Code-1774", "Model-1774", "Name-1774", "Specification-1774", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1775, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6150), false, 1, "Code-1775", "Model-1775", "Name-1775", "Specification-1775", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1776, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6155), true, 1, "Code-1776", "Model-1776", "Name-1776", "Specification-1776", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1777, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6159), false, 1, "Code-1777", "Model-1777", "Name-1777", "Specification-1777", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1778, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6164), true, 1, "Code-1778", "Model-1778", "Name-1778", "Specification-1778", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1779, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6168), false, 1, "Code-1779", "Model-1779", "Name-1779", "Specification-1779", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1780, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6174), true, 1, "Code-1780", "Model-1780", "Name-1780", "Specification-1780", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1781, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6178), false, 2, "Code-1781", "Model-1781", "Name-1781", "Specification-1781", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1782, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6183), true, 2, "Code-1782", "Model-1782", "Name-1782", "Specification-1782", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1783, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6187), false, 2, "Code-1783", "Model-1783", "Name-1783", "Specification-1783", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1784, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6192), true, 2, "Code-1784", "Model-1784", "Name-1784", "Specification-1784", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1785, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6196), false, 1, "Code-1785", "Model-1785", "Name-1785", "Specification-1785", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1786, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6204), true, 1, "Code-1786", "Model-1786", "Name-1786", "Specification-1786", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1787, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6208), false, 1, "Code-1787", "Model-1787", "Name-1787", "Specification-1787", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1788, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6213), true, 2, "Code-1788", "Model-1788", "Name-1788", "Specification-1788", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1789, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6217), false, 2, "Code-1789", "Model-1789", "Name-1789", "Specification-1789", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1790, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6223), true, 2, "Code-1790", "Model-1790", "Name-1790", "Specification-1790", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1791, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6227), false, 2, "Code-1791", "Model-1791", "Name-1791", "Specification-1791", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1792, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6232), true, 2, "Code-1792", "Model-1792", "Name-1792", "Specification-1792", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1793, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6236), false, 1, "Code-1793", "Model-1793", "Name-1793", "Specification-1793", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1794, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6242), true, 1, "Code-1794", "Model-1794", "Name-1794", "Specification-1794", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1795, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6246), false, 1, "Code-1795", "Model-1795", "Name-1795", "Specification-1795", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1796, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6251), true, 2, "Code-1796", "Model-1796", "Name-1796", "Specification-1796", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1797, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6255), false, 2, "Code-1797", "Model-1797", "Name-1797", "Specification-1797", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1798, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6261), true, 2, "Code-1798", "Model-1798", "Name-1798", "Specification-1798", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1799, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6264), false, 2, "Code-1799", "Model-1799", "Name-1799", "Specification-1799", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1800, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6270), true, 1, "Code-1800", "Model-1800", "Name-1800", "Specification-1800", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1801, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6274), false, 2, "Code-1801", "Model-1801", "Name-1801", "Specification-1801", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1802, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6279), true, 2, "Code-1802", "Model-1802", "Name-1802", "Specification-1802", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1803, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6283), false, 1, "Code-1803", "Model-1803", "Name-1803", "Specification-1803", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1804, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6289), true, 2, "Code-1804", "Model-1804", "Name-1804", "Specification-1804", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1805, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6296), false, 2, "Code-1805", "Model-1805", "Name-1805", "Specification-1805", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1806, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6301), true, 2, "Code-1806", "Model-1806", "Name-1806", "Specification-1806", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1807, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6305), false, 1, "Code-1807", "Model-1807", "Name-1807", "Specification-1807", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1808, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6310), true, 1, "Code-1808", "Model-1808", "Name-1808", "Specification-1808", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1809, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6314), false, 2, "Code-1809", "Model-1809", "Name-1809", "Specification-1809", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1810, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6320), true, 1, "Code-1810", "Model-1810", "Name-1810", "Specification-1810", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1811, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6324), false, 2, "Code-1811", "Model-1811", "Name-1811", "Specification-1811", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1812, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6329), true, 1, "Code-1812", "Model-1812", "Name-1812", "Specification-1812", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1813, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6333), false, 1, "Code-1813", "Model-1813", "Name-1813", "Specification-1813", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1814, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6339), true, 1, "Code-1814", "Model-1814", "Name-1814", "Specification-1814", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1815, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6343), false, 1, "Code-1815", "Model-1815", "Name-1815", "Specification-1815", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1816, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6349), true, 1, "Code-1816", "Model-1816", "Name-1816", "Specification-1816", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1817, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6353), false, 1, "Code-1817", "Model-1817", "Name-1817", "Specification-1817", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1818, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6358), true, 2, "Code-1818", "Model-1818", "Name-1818", "Specification-1818", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1819, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6362), false, 1, "Code-1819", "Model-1819", "Name-1819", "Specification-1819", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1820, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6368), true, 1, "Code-1820", "Model-1820", "Name-1820", "Specification-1820", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1821, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6372), false, 2, "Code-1821", "Model-1821", "Name-1821", "Specification-1821", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1822, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6377), true, 2, "Code-1822", "Model-1822", "Name-1822", "Specification-1822", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1823, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6381), false, 1, "Code-1823", "Model-1823", "Name-1823", "Specification-1823", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1824, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6390), true, 1, "Code-1824", "Model-1824", "Name-1824", "Specification-1824", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1825, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6394), false, 2, "Code-1825", "Model-1825", "Name-1825", "Specification-1825", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1826, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6399), true, 1, "Code-1826", "Model-1826", "Name-1826", "Specification-1826", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1827, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6403), false, 2, "Code-1827", "Model-1827", "Name-1827", "Specification-1827", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1828, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6408), true, 2, "Code-1828", "Model-1828", "Name-1828", "Specification-1828", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1829, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6412), false, 1, "Code-1829", "Model-1829", "Name-1829", "Specification-1829", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1830, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6418), true, 2, "Code-1830", "Model-1830", "Name-1830", "Specification-1830", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1831, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6422), false, 2, "Code-1831", "Model-1831", "Name-1831", "Specification-1831", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1832, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6427), true, 1, "Code-1832", "Model-1832", "Name-1832", "Specification-1832", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1833, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6431), false, 1, "Code-1833", "Model-1833", "Name-1833", "Specification-1833", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1834, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6436), true, 2, "Code-1834", "Model-1834", "Name-1834", "Specification-1834", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1835, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6440), false, 2, "Code-1835", "Model-1835", "Name-1835", "Specification-1835", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1836, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6446), true, 2, "Code-1836", "Model-1836", "Name-1836", "Specification-1836", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1837, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6450), false, 1, "Code-1837", "Model-1837", "Name-1837", "Specification-1837", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1838, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6455), true, 1, "Code-1838", "Model-1838", "Name-1838", "Specification-1838", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1839, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6459), false, 1, "Code-1839", "Model-1839", "Name-1839", "Specification-1839", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1840, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6465), true, 1, "Code-1840", "Model-1840", "Name-1840", "Specification-1840", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1841, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6469), false, 2, "Code-1841", "Model-1841", "Name-1841", "Specification-1841", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1842, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6474), true, 1, "Code-1842", "Model-1842", "Name-1842", "Specification-1842", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1843, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6481), false, 2, "Code-1843", "Model-1843", "Name-1843", "Specification-1843", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1844, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6487), true, 2, "Code-1844", "Model-1844", "Name-1844", "Specification-1844", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1845, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6490), false, 1, "Code-1845", "Model-1845", "Name-1845", "Specification-1845", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1846, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6496), true, 2, "Code-1846", "Model-1846", "Name-1846", "Specification-1846", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1847, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6500), false, 2, "Code-1847", "Model-1847", "Name-1847", "Specification-1847", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1848, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6505), true, 1, "Code-1848", "Model-1848", "Name-1848", "Specification-1848", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1849, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6509), false, 1, "Code-1849", "Model-1849", "Name-1849", "Specification-1849", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1850, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6515), true, 2, "Code-1850", "Model-1850", "Name-1850", "Specification-1850", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1851, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6519), false, 1, "Code-1851", "Model-1851", "Name-1851", "Specification-1851", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1852, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6524), true, 1, "Code-1852", "Model-1852", "Name-1852", "Specification-1852", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1853, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6528), false, 1, "Code-1853", "Model-1853", "Name-1853", "Specification-1853", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1854, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6533), true, 1, "Code-1854", "Model-1854", "Name-1854", "Specification-1854", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1855, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6537), false, 1, "Code-1855", "Model-1855", "Name-1855", "Specification-1855", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1856, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6542), true, 2, "Code-1856", "Model-1856", "Name-1856", "Specification-1856", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1857, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6546), false, 2, "Code-1857", "Model-1857", "Name-1857", "Specification-1857", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1858, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6552), true, 2, "Code-1858", "Model-1858", "Name-1858", "Specification-1858", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1859, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6556), false, 2, "Code-1859", "Model-1859", "Name-1859", "Specification-1859", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1860, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6562), true, 1, "Code-1860", "Model-1860", "Name-1860", "Specification-1860", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1861, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6565), false, 1, "Code-1861", "Model-1861", "Name-1861", "Specification-1861", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1862, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6574), true, 1, "Code-1862", "Model-1862", "Name-1862", "Specification-1862", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1863, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6578), false, 1, "Code-1863", "Model-1863", "Name-1863", "Specification-1863", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1864, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6583), true, 2, "Code-1864", "Model-1864", "Name-1864", "Specification-1864", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1865, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6587), false, 2, "Code-1865", "Model-1865", "Name-1865", "Specification-1865", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1866, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6593), true, 1, "Code-1866", "Model-1866", "Name-1866", "Specification-1866", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1867, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6597), false, 2, "Code-1867", "Model-1867", "Name-1867", "Specification-1867", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1868, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6603), true, 1, "Code-1868", "Model-1868", "Name-1868", "Specification-1868", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1869, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6607), false, 2, "Code-1869", "Model-1869", "Name-1869", "Specification-1869", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1870, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6612), true, 2, "Code-1870", "Model-1870", "Name-1870", "Specification-1870", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1871, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6616), false, 2, "Code-1871", "Model-1871", "Name-1871", "Specification-1871", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1872, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6622), true, 2, "Code-1872", "Model-1872", "Name-1872", "Specification-1872", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1873, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6626), false, 1, "Code-1873", "Model-1873", "Name-1873", "Specification-1873", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1874, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6631), true, 1, "Code-1874", "Model-1874", "Name-1874", "Specification-1874", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1875, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6635), false, 1, "Code-1875", "Model-1875", "Name-1875", "Specification-1875", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1876, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6640), true, 2, "Code-1876", "Model-1876", "Name-1876", "Specification-1876", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1877, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6644), false, 1, "Code-1877", "Model-1877", "Name-1877", "Specification-1877", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1878, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6650), true, 2, "Code-1878", "Model-1878", "Name-1878", "Specification-1878", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1879, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6654), false, 2, "Code-1879", "Model-1879", "Name-1879", "Specification-1879", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1880, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6659), true, 1, "Code-1880", "Model-1880", "Name-1880", "Specification-1880", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1881, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6666), false, 1, "Code-1881", "Model-1881", "Name-1881", "Specification-1881", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1882, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6672), true, 1, "Code-1882", "Model-1882", "Name-1882", "Specification-1882", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1883, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6676), false, 1, "Code-1883", "Model-1883", "Name-1883", "Specification-1883", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1884, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6682), true, 2, "Code-1884", "Model-1884", "Name-1884", "Specification-1884", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1885, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6686), false, 2, "Code-1885", "Model-1885", "Name-1885", "Specification-1885", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1886, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6691), true, 2, "Code-1886", "Model-1886", "Name-1886", "Specification-1886", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1887, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6695), false, 1, "Code-1887", "Model-1887", "Name-1887", "Specification-1887", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1888, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6700), true, 2, "Code-1888", "Model-1888", "Name-1888", "Specification-1888", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1889, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6704), false, 2, "Code-1889", "Model-1889", "Name-1889", "Specification-1889", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1890, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6710), true, 2, "Code-1890", "Model-1890", "Name-1890", "Specification-1890", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1891, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6714), false, 1, "Code-1891", "Model-1891", "Name-1891", "Specification-1891", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1892, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6719), true, 1, "Code-1892", "Model-1892", "Name-1892", "Specification-1892", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1893, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6723), false, 1, "Code-1893", "Model-1893", "Name-1893", "Specification-1893", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1894, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6729), true, 2, "Code-1894", "Model-1894", "Name-1894", "Specification-1894", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1895, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6733), false, 1, "Code-1895", "Model-1895", "Name-1895", "Specification-1895", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1896, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6738), true, 2, "Code-1896", "Model-1896", "Name-1896", "Specification-1896", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1897, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6742), false, 1, "Code-1897", "Model-1897", "Name-1897", "Specification-1897", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1898, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6747), true, 1, "Code-1898", "Model-1898", "Name-1898", "Specification-1898", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1899, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6752), false, 1, "Code-1899", "Model-1899", "Name-1899", "Specification-1899", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1900, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6760), true, 2, "Code-1900", "Model-1900", "Name-1900", "Specification-1900", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1901, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6764), false, 2, "Code-1901", "Model-1901", "Name-1901", "Specification-1901", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1902, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6770), true, 1, "Code-1902", "Model-1902", "Name-1902", "Specification-1902", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1903, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6773), false, 1, "Code-1903", "Model-1903", "Name-1903", "Specification-1903", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1904, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6779), true, 2, "Code-1904", "Model-1904", "Name-1904", "Specification-1904", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1905, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6783), false, 1, "Code-1905", "Model-1905", "Name-1905", "Specification-1905", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1906, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6788), true, 1, "Code-1906", "Model-1906", "Name-1906", "Specification-1906", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1907, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6793), false, 1, "Code-1907", "Model-1907", "Name-1907", "Specification-1907", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1908, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6798), true, 1, "Code-1908", "Model-1908", "Name-1908", "Specification-1908", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1909, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6802), false, 2, "Code-1909", "Model-1909", "Name-1909", "Specification-1909", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1910, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6807), true, 1, "Code-1910", "Model-1910", "Name-1910", "Specification-1910", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1911, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6811), false, 1, "Code-1911", "Model-1911", "Name-1911", "Specification-1911", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1912, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6817), true, 2, "Code-1912", "Model-1912", "Name-1912", "Specification-1912", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1913, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6820), false, 2, "Code-1913", "Model-1913", "Name-1913", "Specification-1913", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1914, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6826), true, 2, "Code-1914", "Model-1914", "Name-1914", "Specification-1914", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1915, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6830), false, 1, "Code-1915", "Model-1915", "Name-1915", "Specification-1915", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1916, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6835), true, 1, "Code-1916", "Model-1916", "Name-1916", "Specification-1916", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1917, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6839), false, 2, "Code-1917", "Model-1917", "Name-1917", "Specification-1917", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1918, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6844), true, 1, "Code-1918", "Model-1918", "Name-1918", "Specification-1918", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1919, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6851), false, 1, "Code-1919", "Model-1919", "Name-1919", "Specification-1919", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1920, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6857), true, 1, "Code-1920", "Model-1920", "Name-1920", "Specification-1920", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1921, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6860), false, 1, "Code-1921", "Model-1921", "Name-1921", "Specification-1921", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1922, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6866), true, 1, "Code-1922", "Model-1922", "Name-1922", "Specification-1922", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1923, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6870), false, 2, "Code-1923", "Model-1923", "Name-1923", "Specification-1923", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1924, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6875), true, 1, "Code-1924", "Model-1924", "Name-1924", "Specification-1924", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1925, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6879), false, 1, "Code-1925", "Model-1925", "Name-1925", "Specification-1925", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1926, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6885), true, 2, "Code-1926", "Model-1926", "Name-1926", "Specification-1926", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1927, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6888), false, 1, "Code-1927", "Model-1927", "Name-1927", "Specification-1927", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1928, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6894), true, 2, "Code-1928", "Model-1928", "Name-1928", "Specification-1928", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1929, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6898), false, 2, "Code-1929", "Model-1929", "Name-1929", "Specification-1929", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1930, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6903), true, 1, "Code-1930", "Model-1930", "Name-1930", "Specification-1930", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1931, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6907), false, 2, "Code-1931", "Model-1931", "Name-1931", "Specification-1931", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1932, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6913), true, 1, "Code-1932", "Model-1932", "Name-1932", "Specification-1932", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1933, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6917), false, 1, "Code-1933", "Model-1933", "Name-1933", "Specification-1933", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1934, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6922), true, 2, "Code-1934", "Model-1934", "Name-1934", "Specification-1934", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1935, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6926), false, 1, "Code-1935", "Model-1935", "Name-1935", "Specification-1935", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1936, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6932), true, 1, "Code-1936", "Model-1936", "Name-1936", "Specification-1936", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1937, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6936), false, 1, "Code-1937", "Model-1937", "Name-1937", "Specification-1937", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1938, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6944), true, 2, "Code-1938", "Model-1938", "Name-1938", "Specification-1938", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1939, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6948), false, 2, "Code-1939", "Model-1939", "Name-1939", "Specification-1939", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1940, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6953), true, 1, "Code-1940", "Model-1940", "Name-1940", "Specification-1940", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1941, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6957), false, 1, "Code-1941", "Model-1941", "Name-1941", "Specification-1941", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1942, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6963), true, 1, "Code-1942", "Model-1942", "Name-1942", "Specification-1942", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1943, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6967), false, 1, "Code-1943", "Model-1943", "Name-1943", "Specification-1943", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1944, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6972), true, 2, "Code-1944", "Model-1944", "Name-1944", "Specification-1944", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1945, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6976), false, 2, "Code-1945", "Model-1945", "Name-1945", "Specification-1945", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1946, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6982), true, 1, "Code-1946", "Model-1946", "Name-1946", "Specification-1946", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1947, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6985), false, 1, "Code-1947", "Model-1947", "Name-1947", "Specification-1947", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1948, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6991), true, 1, "Code-1948", "Model-1948", "Name-1948", "Specification-1948", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1949, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(6995), false, 1, "Code-1949", "Model-1949", "Name-1949", "Specification-1949", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1950, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7000), true, 1, "Code-1950", "Model-1950", "Name-1950", "Specification-1950", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1951, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7004), false, 1, "Code-1951", "Model-1951", "Name-1951", "Specification-1951", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1952, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7010), true, 1, "Code-1952", "Model-1952", "Name-1952", "Specification-1952", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1953, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7014), false, 2, "Code-1953", "Model-1953", "Name-1953", "Specification-1953", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1954, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7019), true, 1, "Code-1954", "Model-1954", "Name-1954", "Specification-1954", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1955, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7023), false, 1, "Code-1955", "Model-1955", "Name-1955", "Specification-1955", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1956, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7032), true, 2, "Code-1956", "Model-1956", "Name-1956", "Specification-1956", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1957, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7036), false, 2, "Code-1957", "Model-1957", "Name-1957", "Specification-1957", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1958, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7041), true, 2, "Code-1958", "Model-1958", "Name-1958", "Specification-1958", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1959, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7045), false, 1, "Code-1959", "Model-1959", "Name-1959", "Specification-1959", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1960, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7051), true, 2, "Code-1960", "Model-1960", "Name-1960", "Specification-1960", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1961, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7055), false, 1, "Code-1961", "Model-1961", "Name-1961", "Specification-1961", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1962, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7060), true, 1, "Code-1962", "Model-1962", "Name-1962", "Specification-1962", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1963, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7064), false, 2, "Code-1963", "Model-1963", "Name-1963", "Specification-1963", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1964, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7069), true, 1, "Code-1964", "Model-1964", "Name-1964", "Specification-1964", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1965, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7073), false, 2, "Code-1965", "Model-1965", "Name-1965", "Specification-1965", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1966, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7078), true, 2, "Code-1966", "Model-1966", "Name-1966", "Specification-1966", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1967, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7082), false, 2, "Code-1967", "Model-1967", "Name-1967", "Specification-1967", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1968, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7088), true, 1, "Code-1968", "Model-1968", "Name-1968", "Specification-1968", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1969, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7092), false, 1, "Code-1969", "Model-1969", "Name-1969", "Specification-1969", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1970, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7097), true, 1, "Code-1970", "Model-1970", "Name-1970", "Specification-1970", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1971, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7101), false, 2, "Code-1971", "Model-1971", "Name-1971", "Specification-1971", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1972, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7107), true, 1, "Code-1972", "Model-1972", "Name-1972", "Specification-1972", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1973, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7111), false, 2, "Code-1973", "Model-1973", "Name-1973", "Specification-1973", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1974, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7116), true, 1, "Code-1974", "Model-1974", "Name-1974", "Specification-1974", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1975, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7123), false, 2, "Code-1975", "Model-1975", "Name-1975", "Specification-1975", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1976, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7129), true, 1, "Code-1976", "Model-1976", "Name-1976", "Specification-1976", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1977, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7133), false, 1, "Code-1977", "Model-1977", "Name-1977", "Specification-1977", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1978, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7138), true, 2, "Code-1978", "Model-1978", "Name-1978", "Specification-1978", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1979, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7142), false, 1, "Code-1979", "Model-1979", "Name-1979", "Specification-1979", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1980, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7148), true, 1, "Code-1980", "Model-1980", "Name-1980", "Specification-1980", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1981, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7151), false, 2, "Code-1981", "Model-1981", "Name-1981", "Specification-1981", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1982, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7157), true, 2, "Code-1982", "Model-1982", "Name-1982", "Specification-1982", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1983, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7161), false, 2, "Code-1983", "Model-1983", "Name-1983", "Specification-1983", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1984, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7167), true, 2, "Code-1984", "Model-1984", "Name-1984", "Specification-1984", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1985, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7171), false, 2, "Code-1985", "Model-1985", "Name-1985", "Specification-1985", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1986, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7176), true, 1, "Code-1986", "Model-1986", "Name-1986", "Specification-1986", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1987, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7180), false, 1, "Code-1987", "Model-1987", "Name-1987", "Specification-1987", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1988, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7185), true, 2, "Code-1988", "Model-1988", "Name-1988", "Specification-1988", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1989, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7189), false, 1, "Code-1989", "Model-1989", "Name-1989", "Specification-1989", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1990, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7194), true, 2, "Code-1990", "Model-1990", "Name-1990", "Specification-1990", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1991, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7198), false, 2, "Code-1991", "Model-1991", "Name-1991", "Specification-1991", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1992, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7204), true, 1, "Code-1992", "Model-1992", "Name-1992", "Specification-1992", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1993, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7208), false, 1, "Code-1993", "Model-1993", "Name-1993", "Specification-1993", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1994, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7216), true, 1, "Code-1994", "Model-1994", "Name-1994", "Specification-1994", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1995, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7222), false, 1, "Code-1995", "Model-1995", "Name-1995", "Specification-1995", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1996, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7227), true, 1, "Code-1996", "Model-1996", "Name-1996", "Specification-1996", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1997, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7231), false, 2, "Code-1997", "Model-1997", "Name-1997", "Specification-1997", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1998, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7236), true, 2, "Code-1998", "Model-1998", "Name-1998", "Specification-1998", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1999, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7240), false, 1, "Code-1999", "Model-1999", "Name-1999", "Specification-1999", 4, null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1000, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7483), true, "Remark-1000", "Code-1000", "Model-1000", "Name-1000", "Specification-1000", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1001, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7494), true, "Remark-1001", "Code-1001", "Model-1001", "Name-1001", "Specification-1001", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1002, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7497), true, "Remark-1002", "Code-1002", "Model-1002", "Name-1002", "Specification-1002", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1003, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7501), true, "Remark-1003", "Code-1003", "Model-1003", "Name-1003", "Specification-1003", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1004, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7504), true, "Remark-1004", "Code-1004", "Model-1004", "Name-1004", "Specification-1004", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1005, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7508), true, "Remark-1005", "Code-1005", "Model-1005", "Name-1005", "Specification-1005", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1006, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7511), true, "Remark-1006", "Code-1006", "Model-1006", "Name-1006", "Specification-1006", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1007, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7514), true, "Remark-1007", "Code-1007", "Model-1007", "Name-1007", "Specification-1007", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1008, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7517), true, "Remark-1008", "Code-1008", "Model-1008", "Name-1008", "Specification-1008", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1009, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7520), true, "Remark-1009", "Code-1009", "Model-1009", "Name-1009", "Specification-1009", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1010, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7523), true, "Remark-1010", "Code-1010", "Model-1010", "Name-1010", "Specification-1010", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1011, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7526), true, "Remark-1011", "Code-1011", "Model-1011", "Name-1011", "Specification-1011", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1012, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7532), true, "Remark-1012", "Code-1012", "Model-1012", "Name-1012", "Specification-1012", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1013, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7535), true, "Remark-1013", "Code-1013", "Model-1013", "Name-1013", "Specification-1013", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1014, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7537), true, "Remark-1014", "Code-1014", "Model-1014", "Name-1014", "Specification-1014", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1015, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7540), true, "Remark-1015", "Code-1015", "Model-1015", "Name-1015", "Specification-1015", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1016, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7543), true, "Remark-1016", "Code-1016", "Model-1016", "Name-1016", "Specification-1016", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1017, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7546), true, "Remark-1017", "Code-1017", "Model-1017", "Name-1017", "Specification-1017", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1018, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7549), true, "Remark-1018", "Code-1018", "Model-1018", "Name-1018", "Specification-1018", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1019, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7552), true, "Remark-1019", "Code-1019", "Model-1019", "Name-1019", "Specification-1019", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1020, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7555), true, "Remark-1020", "Code-1020", "Model-1020", "Name-1020", "Specification-1020", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1021, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7558), true, "Remark-1021", "Code-1021", "Model-1021", "Name-1021", "Specification-1021", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1022, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7560), true, "Remark-1022", "Code-1022", "Model-1022", "Name-1022", "Specification-1022", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1023, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7563), true, "Remark-1023", "Code-1023", "Model-1023", "Name-1023", "Specification-1023", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1024, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7566), true, "Remark-1024", "Code-1024", "Model-1024", "Name-1024", "Specification-1024", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1025, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7569), true, "Remark-1025", "Code-1025", "Model-1025", "Name-1025", "Specification-1025", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1026, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7571), true, "Remark-1026", "Code-1026", "Model-1026", "Name-1026", "Specification-1026", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1027, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7574), true, "Remark-1027", "Code-1027", "Model-1027", "Name-1027", "Specification-1027", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1028, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7577), true, "Remark-1028", "Code-1028", "Model-1028", "Name-1028", "Specification-1028", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1029, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7579), true, "Remark-1029", "Code-1029", "Model-1029", "Name-1029", "Specification-1029", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1030, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7582), true, "Remark-1030", "Code-1030", "Model-1030", "Name-1030", "Specification-1030", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1031, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7587), true, "Remark-1031", "Code-1031", "Model-1031", "Name-1031", "Specification-1031", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1032, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7591), true, "Remark-1032", "Code-1032", "Model-1032", "Name-1032", "Specification-1032", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1033, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7594), true, "Remark-1033", "Code-1033", "Model-1033", "Name-1033", "Specification-1033", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1034, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7597), true, "Remark-1034", "Code-1034", "Model-1034", "Name-1034", "Specification-1034", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1035, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7600), true, "Remark-1035", "Code-1035", "Model-1035", "Name-1035", "Specification-1035", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1036, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7603), true, "Remark-1036", "Code-1036", "Model-1036", "Name-1036", "Specification-1036", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1037, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7605), true, "Remark-1037", "Code-1037", "Model-1037", "Name-1037", "Specification-1037", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1038, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7608), true, "Remark-1038", "Code-1038", "Model-1038", "Name-1038", "Specification-1038", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1039, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7611), true, "Remark-1039", "Code-1039", "Model-1039", "Name-1039", "Specification-1039", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1040, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7614), true, "Remark-1040", "Code-1040", "Model-1040", "Name-1040", "Specification-1040", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1041, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7617), true, "Remark-1041", "Code-1041", "Model-1041", "Name-1041", "Specification-1041", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1042, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7619), true, "Remark-1042", "Code-1042", "Model-1042", "Name-1042", "Specification-1042", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1043, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7622), true, "Remark-1043", "Code-1043", "Model-1043", "Name-1043", "Specification-1043", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1044, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7625), true, "Remark-1044", "Code-1044", "Model-1044", "Name-1044", "Specification-1044", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1045, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7627), true, "Remark-1045", "Code-1045", "Model-1045", "Name-1045", "Specification-1045", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1046, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7630), true, "Remark-1046", "Code-1046", "Model-1046", "Name-1046", "Specification-1046", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1047, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7633), true, "Remark-1047", "Code-1047", "Model-1047", "Name-1047", "Specification-1047", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1048, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7636), true, "Remark-1048", "Code-1048", "Model-1048", "Name-1048", "Specification-1048", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1049, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7639), true, "Remark-1049", "Code-1049", "Model-1049", "Name-1049", "Specification-1049", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1050, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7645), true, "Remark-1050", "Code-1050", "Model-1050", "Name-1050", "Specification-1050", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1051, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7647), true, "Remark-1051", "Code-1051", "Model-1051", "Name-1051", "Specification-1051", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1052, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7650), true, "Remark-1052", "Code-1052", "Model-1052", "Name-1052", "Specification-1052", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1053, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7653), true, "Remark-1053", "Code-1053", "Model-1053", "Name-1053", "Specification-1053", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1054, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7655), true, "Remark-1054", "Code-1054", "Model-1054", "Name-1054", "Specification-1054", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1055, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7658), true, "Remark-1055", "Code-1055", "Model-1055", "Name-1055", "Specification-1055", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1056, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7661), true, "Remark-1056", "Code-1056", "Model-1056", "Name-1056", "Specification-1056", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1057, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7664), true, "Remark-1057", "Code-1057", "Model-1057", "Name-1057", "Specification-1057", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1058, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7666), true, "Remark-1058", "Code-1058", "Model-1058", "Name-1058", "Specification-1058", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1059, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7669), true, "Remark-1059", "Code-1059", "Model-1059", "Name-1059", "Specification-1059", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1060, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7672), true, "Remark-1060", "Code-1060", "Model-1060", "Name-1060", "Specification-1060", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1061, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7674), true, "Remark-1061", "Code-1061", "Model-1061", "Name-1061", "Specification-1061", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1062, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7677), true, "Remark-1062", "Code-1062", "Model-1062", "Name-1062", "Specification-1062", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1063, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7680), true, "Remark-1063", "Code-1063", "Model-1063", "Name-1063", "Specification-1063", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1064, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7682), true, "Remark-1064", "Code-1064", "Model-1064", "Name-1064", "Specification-1064", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1065, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7686), true, "Remark-1065", "Code-1065", "Model-1065", "Name-1065", "Specification-1065", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1066, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7689), true, "Remark-1066", "Code-1066", "Model-1066", "Name-1066", "Specification-1066", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1067, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7692), true, "Remark-1067", "Code-1067", "Model-1067", "Name-1067", "Specification-1067", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1068, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7698), true, "Remark-1068", "Code-1068", "Model-1068", "Name-1068", "Specification-1068", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1069, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7701), true, "Remark-1069", "Code-1069", "Model-1069", "Name-1069", "Specification-1069", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1070, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7703), true, "Remark-1070", "Code-1070", "Model-1070", "Name-1070", "Specification-1070", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1071, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7706), true, "Remark-1071", "Code-1071", "Model-1071", "Name-1071", "Specification-1071", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1072, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7709), true, "Remark-1072", "Code-1072", "Model-1072", "Name-1072", "Specification-1072", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1073, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7712), true, "Remark-1073", "Code-1073", "Model-1073", "Name-1073", "Specification-1073", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1074, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7715), true, "Remark-1074", "Code-1074", "Model-1074", "Name-1074", "Specification-1074", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1075, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7717), true, "Remark-1075", "Code-1075", "Model-1075", "Name-1075", "Specification-1075", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1076, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7720), true, "Remark-1076", "Code-1076", "Model-1076", "Name-1076", "Specification-1076", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1077, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7723), true, "Remark-1077", "Code-1077", "Model-1077", "Name-1077", "Specification-1077", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1078, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7726), true, "Remark-1078", "Code-1078", "Model-1078", "Name-1078", "Specification-1078", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1079, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7729), true, "Remark-1079", "Code-1079", "Model-1079", "Name-1079", "Specification-1079", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1080, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7731), true, "Remark-1080", "Code-1080", "Model-1080", "Name-1080", "Specification-1080", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1081, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7734), true, "Remark-1081", "Code-1081", "Model-1081", "Name-1081", "Specification-1081", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1082, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7736), true, "Remark-1082", "Code-1082", "Model-1082", "Name-1082", "Specification-1082", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1083, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7739), true, "Remark-1083", "Code-1083", "Model-1083", "Name-1083", "Specification-1083", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1084, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7742), true, "Remark-1084", "Code-1084", "Model-1084", "Name-1084", "Specification-1084", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1085, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7744), true, "Remark-1085", "Code-1085", "Model-1085", "Name-1085", "Specification-1085", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1086, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7747), true, "Remark-1086", "Code-1086", "Model-1086", "Name-1086", "Specification-1086", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1087, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7750), true, "Remark-1087", "Code-1087", "Model-1087", "Name-1087", "Specification-1087", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1088, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7756), true, "Remark-1088", "Code-1088", "Model-1088", "Name-1088", "Specification-1088", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1089, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7759), true, "Remark-1089", "Code-1089", "Model-1089", "Name-1089", "Specification-1089", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1090, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7762), true, "Remark-1090", "Code-1090", "Model-1090", "Name-1090", "Specification-1090", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1091, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7764), true, "Remark-1091", "Code-1091", "Model-1091", "Name-1091", "Specification-1091", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1092, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7767), true, "Remark-1092", "Code-1092", "Model-1092", "Name-1092", "Specification-1092", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1093, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7770), true, "Remark-1093", "Code-1093", "Model-1093", "Name-1093", "Specification-1093", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1094, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7772), true, "Remark-1094", "Code-1094", "Model-1094", "Name-1094", "Specification-1094", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1095, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7775), true, "Remark-1095", "Code-1095", "Model-1095", "Name-1095", "Specification-1095", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1096, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7778), true, "Remark-1096", "Code-1096", "Model-1096", "Name-1096", "Specification-1096", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1097, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7780), true, "Remark-1097", "Code-1097", "Model-1097", "Name-1097", "Specification-1097", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1098, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7783), true, "Remark-1098", "Code-1098", "Model-1098", "Name-1098", "Specification-1098", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1099, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7786), true, "Remark-1099", "Code-1099", "Model-1099", "Name-1099", "Specification-1099", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1100, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7789), true, "Remark-1100", "Code-1100", "Model-1100", "Name-1100", "Specification-1100", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1101, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7792), true, "Remark-1101", "Code-1101", "Model-1101", "Name-1101", "Specification-1101", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1102, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7794), true, "Remark-1102", "Code-1102", "Model-1102", "Name-1102", "Specification-1102", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1103, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7797), true, "Remark-1103", "Code-1103", "Model-1103", "Name-1103", "Specification-1103", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1104, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7800), true, "Remark-1104", "Code-1104", "Model-1104", "Name-1104", "Specification-1104", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1105, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7803), true, "Remark-1105", "Code-1105", "Model-1105", "Name-1105", "Specification-1105", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1106, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7805), true, "Remark-1106", "Code-1106", "Model-1106", "Name-1106", "Specification-1106", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1107, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7808), true, "Remark-1107", "Code-1107", "Model-1107", "Name-1107", "Specification-1107", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1108, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7814), true, "Remark-1108", "Code-1108", "Model-1108", "Name-1108", "Specification-1108", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1109, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7817), true, "Remark-1109", "Code-1109", "Model-1109", "Name-1109", "Specification-1109", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1110, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7819), true, "Remark-1110", "Code-1110", "Model-1110", "Name-1110", "Specification-1110", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1111, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7822), true, "Remark-1111", "Code-1111", "Model-1111", "Name-1111", "Specification-1111", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1112, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7825), true, "Remark-1112", "Code-1112", "Model-1112", "Name-1112", "Specification-1112", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1113, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7827), true, "Remark-1113", "Code-1113", "Model-1113", "Name-1113", "Specification-1113", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1114, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7830), true, "Remark-1114", "Code-1114", "Model-1114", "Name-1114", "Specification-1114", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1115, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7833), true, "Remark-1115", "Code-1115", "Model-1115", "Name-1115", "Specification-1115", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1116, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7836), true, "Remark-1116", "Code-1116", "Model-1116", "Name-1116", "Specification-1116", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1117, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7838), true, "Remark-1117", "Code-1117", "Model-1117", "Name-1117", "Specification-1117", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1118, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7841), true, "Remark-1118", "Code-1118", "Model-1118", "Name-1118", "Specification-1118", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1119, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7844), true, "Remark-1119", "Code-1119", "Model-1119", "Name-1119", "Specification-1119", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1120, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7847), true, "Remark-1120", "Code-1120", "Model-1120", "Name-1120", "Specification-1120", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1121, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7849), true, "Remark-1121", "Code-1121", "Model-1121", "Name-1121", "Specification-1121", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1122, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7852), true, "Remark-1122", "Code-1122", "Model-1122", "Name-1122", "Specification-1122", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1123, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7855), true, "Remark-1123", "Code-1123", "Model-1123", "Name-1123", "Specification-1123", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1124, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7858), true, "Remark-1124", "Code-1124", "Model-1124", "Name-1124", "Specification-1124", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1125, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7861), true, "Remark-1125", "Code-1125", "Model-1125", "Name-1125", "Specification-1125", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1126, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7863), true, "Remark-1126", "Code-1126", "Model-1126", "Name-1126", "Specification-1126", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1127, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7866), true, "Remark-1127", "Code-1127", "Model-1127", "Name-1127", "Specification-1127", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1128, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7872), true, "Remark-1128", "Code-1128", "Model-1128", "Name-1128", "Specification-1128", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1129, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7876), true, "Remark-1129", "Code-1129", "Model-1129", "Name-1129", "Specification-1129", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1130, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7879), true, "Remark-1130", "Code-1130", "Model-1130", "Name-1130", "Specification-1130", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1131, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7882), true, "Remark-1131", "Code-1131", "Model-1131", "Name-1131", "Specification-1131", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1132, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7885), true, "Remark-1132", "Code-1132", "Model-1132", "Name-1132", "Specification-1132", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1133, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7888), true, "Remark-1133", "Code-1133", "Model-1133", "Name-1133", "Specification-1133", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1134, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7891), true, "Remark-1134", "Code-1134", "Model-1134", "Name-1134", "Specification-1134", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1135, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7893), true, "Remark-1135", "Code-1135", "Model-1135", "Name-1135", "Specification-1135", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1136, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7896), true, "Remark-1136", "Code-1136", "Model-1136", "Name-1136", "Specification-1136", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1137, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7899), true, "Remark-1137", "Code-1137", "Model-1137", "Name-1137", "Specification-1137", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1138, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7902), true, "Remark-1138", "Code-1138", "Model-1138", "Name-1138", "Specification-1138", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1139, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7904), true, "Remark-1139", "Code-1139", "Model-1139", "Name-1139", "Specification-1139", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1140, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7907), true, "Remark-1140", "Code-1140", "Model-1140", "Name-1140", "Specification-1140", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1141, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7910), true, "Remark-1141", "Code-1141", "Model-1141", "Name-1141", "Specification-1141", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1142, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7913), true, "Remark-1142", "Code-1142", "Model-1142", "Name-1142", "Specification-1142", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1143, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7921), true, "Remark-1143", "Code-1143", "Model-1143", "Name-1143", "Specification-1143", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1144, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7923), true, "Remark-1144", "Code-1144", "Model-1144", "Name-1144", "Specification-1144", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1145, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7926), true, "Remark-1145", "Code-1145", "Model-1145", "Name-1145", "Specification-1145", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1146, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7929), true, "Remark-1146", "Code-1146", "Model-1146", "Name-1146", "Specification-1146", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1147, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7932), true, "Remark-1147", "Code-1147", "Model-1147", "Name-1147", "Specification-1147", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1148, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7935), true, "Remark-1148", "Code-1148", "Model-1148", "Name-1148", "Specification-1148", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1149, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7938), true, "Remark-1149", "Code-1149", "Model-1149", "Name-1149", "Specification-1149", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1150, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7941), true, "Remark-1150", "Code-1150", "Model-1150", "Name-1150", "Specification-1150", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1151, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7943), true, "Remark-1151", "Code-1151", "Model-1151", "Name-1151", "Specification-1151", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1152, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7946), true, "Remark-1152", "Code-1152", "Model-1152", "Name-1152", "Specification-1152", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1153, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7949), true, "Remark-1153", "Code-1153", "Model-1153", "Name-1153", "Specification-1153", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1154, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7952), true, "Remark-1154", "Code-1154", "Model-1154", "Name-1154", "Specification-1154", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1155, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7954), true, "Remark-1155", "Code-1155", "Model-1155", "Name-1155", "Specification-1155", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1156, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7957), true, "Remark-1156", "Code-1156", "Model-1156", "Name-1156", "Specification-1156", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1157, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7960), true, "Remark-1157", "Code-1157", "Model-1157", "Name-1157", "Specification-1157", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1158, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7962), true, "Remark-1158", "Code-1158", "Model-1158", "Name-1158", "Specification-1158", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1159, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7965), true, "Remark-1159", "Code-1159", "Model-1159", "Name-1159", "Specification-1159", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1160, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7968), true, "Remark-1160", "Code-1160", "Model-1160", "Name-1160", "Specification-1160", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1161, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7971), true, "Remark-1161", "Code-1161", "Model-1161", "Name-1161", "Specification-1161", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1162, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7973), true, "Remark-1162", "Code-1162", "Model-1162", "Name-1162", "Specification-1162", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1163, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7983), true, "Remark-1163", "Code-1163", "Model-1163", "Name-1163", "Specification-1163", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1164, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7985), true, "Remark-1164", "Code-1164", "Model-1164", "Name-1164", "Specification-1164", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1165, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7988), true, "Remark-1165", "Code-1165", "Model-1165", "Name-1165", "Specification-1165", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1166, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7991), true, "Remark-1166", "Code-1166", "Model-1166", "Name-1166", "Specification-1166", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1167, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7994), true, "Remark-1167", "Code-1167", "Model-1167", "Name-1167", "Specification-1167", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1168, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7996), true, "Remark-1168", "Code-1168", "Model-1168", "Name-1168", "Specification-1168", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1169, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(7999), true, "Remark-1169", "Code-1169", "Model-1169", "Name-1169", "Specification-1169", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1170, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8002), true, "Remark-1170", "Code-1170", "Model-1170", "Name-1170", "Specification-1170", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1171, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8005), true, "Remark-1171", "Code-1171", "Model-1171", "Name-1171", "Specification-1171", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1172, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8007), true, "Remark-1172", "Code-1172", "Model-1172", "Name-1172", "Specification-1172", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1173, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8010), true, "Remark-1173", "Code-1173", "Model-1173", "Name-1173", "Specification-1173", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1174, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8013), true, "Remark-1174", "Code-1174", "Model-1174", "Name-1174", "Specification-1174", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1175, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8015), true, "Remark-1175", "Code-1175", "Model-1175", "Name-1175", "Specification-1175", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1176, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8018), true, "Remark-1176", "Code-1176", "Model-1176", "Name-1176", "Specification-1176", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1177, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8021), true, "Remark-1177", "Code-1177", "Model-1177", "Name-1177", "Specification-1177", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1178, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8023), true, "Remark-1178", "Code-1178", "Model-1178", "Name-1178", "Specification-1178", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1179, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8026), true, "Remark-1179", "Code-1179", "Model-1179", "Name-1179", "Specification-1179", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1180, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8029), true, "Remark-1180", "Code-1180", "Model-1180", "Name-1180", "Specification-1180", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1181, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8032), true, "Remark-1181", "Code-1181", "Model-1181", "Name-1181", "Specification-1181", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1182, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8035), true, "Remark-1182", "Code-1182", "Model-1182", "Name-1182", "Specification-1182", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1183, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8041), true, "Remark-1183", "Code-1183", "Model-1183", "Name-1183", "Specification-1183", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1184, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8044), true, "Remark-1184", "Code-1184", "Model-1184", "Name-1184", "Specification-1184", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1185, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8047), true, "Remark-1185", "Code-1185", "Model-1185", "Name-1185", "Specification-1185", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1186, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8049), true, "Remark-1186", "Code-1186", "Model-1186", "Name-1186", "Specification-1186", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1187, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8052), true, "Remark-1187", "Code-1187", "Model-1187", "Name-1187", "Specification-1187", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1188, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8055), true, "Remark-1188", "Code-1188", "Model-1188", "Name-1188", "Specification-1188", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1189, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8057), true, "Remark-1189", "Code-1189", "Model-1189", "Name-1189", "Specification-1189", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1190, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8060), true, "Remark-1190", "Code-1190", "Model-1190", "Name-1190", "Specification-1190", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1191, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8105), true, "Remark-1191", "Code-1191", "Model-1191", "Name-1191", "Specification-1191", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1192, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8110), true, "Remark-1192", "Code-1192", "Model-1192", "Name-1192", "Specification-1192", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1193, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8116), true, "Remark-1193", "Code-1193", "Model-1193", "Name-1193", "Specification-1193", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1194, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8120), true, "Remark-1194", "Code-1194", "Model-1194", "Name-1194", "Specification-1194", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1195, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8125), true, "Remark-1195", "Code-1195", "Model-1195", "Name-1195", "Specification-1195", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1196, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8130), true, "Remark-1196", "Code-1196", "Model-1196", "Name-1196", "Specification-1196", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1197, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8135), true, "Remark-1197", "Code-1197", "Model-1197", "Name-1197", "Specification-1197", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1198, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8141), true, "Remark-1198", "Code-1198", "Model-1198", "Name-1198", "Specification-1198", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1199, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8146), true, "Remark-1199", "Code-1199", "Model-1199", "Name-1199", "Specification-1199", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1200, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8151), true, "Remark-1200", "Code-1200", "Model-1200", "Name-1200", "Specification-1200", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1201, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8157), true, "Remark-1201", "Code-1201", "Model-1201", "Name-1201", "Specification-1201", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1202, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8162), true, "Remark-1202", "Code-1202", "Model-1202", "Name-1202", "Specification-1202", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1203, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8172), true, "Remark-1203", "Code-1203", "Model-1203", "Name-1203", "Specification-1203", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1204, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8177), true, "Remark-1204", "Code-1204", "Model-1204", "Name-1204", "Specification-1204", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1205, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8181), true, "Remark-1205", "Code-1205", "Model-1205", "Name-1205", "Specification-1205", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1206, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8186), true, "Remark-1206", "Code-1206", "Model-1206", "Name-1206", "Specification-1206", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1207, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8190), true, "Remark-1207", "Code-1207", "Model-1207", "Name-1207", "Specification-1207", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1208, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8195), true, "Remark-1208", "Code-1208", "Model-1208", "Name-1208", "Specification-1208", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1209, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8199), true, "Remark-1209", "Code-1209", "Model-1209", "Name-1209", "Specification-1209", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1210, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8202), true, "Remark-1210", "Code-1210", "Model-1210", "Name-1210", "Specification-1210", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1211, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8204), true, "Remark-1211", "Code-1211", "Model-1211", "Name-1211", "Specification-1211", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1212, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8207), true, "Remark-1212", "Code-1212", "Model-1212", "Name-1212", "Specification-1212", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1213, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8210), true, "Remark-1213", "Code-1213", "Model-1213", "Name-1213", "Specification-1213", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1214, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8213), true, "Remark-1214", "Code-1214", "Model-1214", "Name-1214", "Specification-1214", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1215, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8215), true, "Remark-1215", "Code-1215", "Model-1215", "Name-1215", "Specification-1215", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1216, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8218), true, "Remark-1216", "Code-1216", "Model-1216", "Name-1216", "Specification-1216", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1217, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8220), true, "Remark-1217", "Code-1217", "Model-1217", "Name-1217", "Specification-1217", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1218, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8223), true, "Remark-1218", "Code-1218", "Model-1218", "Name-1218", "Specification-1218", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1219, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8226), true, "Remark-1219", "Code-1219", "Model-1219", "Name-1219", "Specification-1219", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1220, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8229), true, "Remark-1220", "Code-1220", "Model-1220", "Name-1220", "Specification-1220", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1221, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8232), true, "Remark-1221", "Code-1221", "Model-1221", "Name-1221", "Specification-1221", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1222, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8234), true, "Remark-1222", "Code-1222", "Model-1222", "Name-1222", "Specification-1222", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1223, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8241), true, "Remark-1223", "Code-1223", "Model-1223", "Name-1223", "Specification-1223", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1224, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8243), true, "Remark-1224", "Code-1224", "Model-1224", "Name-1224", "Specification-1224", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1225, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8246), true, "Remark-1225", "Code-1225", "Model-1225", "Name-1225", "Specification-1225", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1226, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8249), true, "Remark-1226", "Code-1226", "Model-1226", "Name-1226", "Specification-1226", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1227, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8251), true, "Remark-1227", "Code-1227", "Model-1227", "Name-1227", "Specification-1227", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1228, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8254), true, "Remark-1228", "Code-1228", "Model-1228", "Name-1228", "Specification-1228", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1229, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8257), true, "Remark-1229", "Code-1229", "Model-1229", "Name-1229", "Specification-1229", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1230, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8259), true, "Remark-1230", "Code-1230", "Model-1230", "Name-1230", "Specification-1230", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1231, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8262), true, "Remark-1231", "Code-1231", "Model-1231", "Name-1231", "Specification-1231", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1232, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8265), true, "Remark-1232", "Code-1232", "Model-1232", "Name-1232", "Specification-1232", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1233, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8267), true, "Remark-1233", "Code-1233", "Model-1233", "Name-1233", "Specification-1233", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1234, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8270), true, "Remark-1234", "Code-1234", "Model-1234", "Name-1234", "Specification-1234", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1235, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8273), true, "Remark-1235", "Code-1235", "Model-1235", "Name-1235", "Specification-1235", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1236, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8275), true, "Remark-1236", "Code-1236", "Model-1236", "Name-1236", "Specification-1236", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1237, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8278), true, "Remark-1237", "Code-1237", "Model-1237", "Name-1237", "Specification-1237", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1238, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8281), true, "Remark-1238", "Code-1238", "Model-1238", "Name-1238", "Specification-1238", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1239, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8284), true, "Remark-1239", "Code-1239", "Model-1239", "Name-1239", "Specification-1239", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1240, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8286), true, "Remark-1240", "Code-1240", "Model-1240", "Name-1240", "Specification-1240", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1241, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8289), true, "Remark-1241", "Code-1241", "Model-1241", "Name-1241", "Specification-1241", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1242, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8292), true, "Remark-1242", "Code-1242", "Model-1242", "Name-1242", "Specification-1242", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1243, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8626), true, "Remark-1243", "Code-1243", "Model-1243", "Name-1243", "Specification-1243", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1244, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8629), true, "Remark-1244", "Code-1244", "Model-1244", "Name-1244", "Specification-1244", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1245, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8632), true, "Remark-1245", "Code-1245", "Model-1245", "Name-1245", "Specification-1245", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1246, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8635), true, "Remark-1246", "Code-1246", "Model-1246", "Name-1246", "Specification-1246", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1247, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8638), true, "Remark-1247", "Code-1247", "Model-1247", "Name-1247", "Specification-1247", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1248, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8641), true, "Remark-1248", "Code-1248", "Model-1248", "Name-1248", "Specification-1248", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1249, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8643), true, "Remark-1249", "Code-1249", "Model-1249", "Name-1249", "Specification-1249", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1250, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8646), true, "Remark-1250", "Code-1250", "Model-1250", "Name-1250", "Specification-1250", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1251, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8649), true, "Remark-1251", "Code-1251", "Model-1251", "Name-1251", "Specification-1251", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1252, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8652), true, "Remark-1252", "Code-1252", "Model-1252", "Name-1252", "Specification-1252", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1253, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8655), true, "Remark-1253", "Code-1253", "Model-1253", "Name-1253", "Specification-1253", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1254, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8658), true, "Remark-1254", "Code-1254", "Model-1254", "Name-1254", "Specification-1254", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1255, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8661), true, "Remark-1255", "Code-1255", "Model-1255", "Name-1255", "Specification-1255", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1256, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8664), true, "Remark-1256", "Code-1256", "Model-1256", "Name-1256", "Specification-1256", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1257, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8672), true, "Remark-1257", "Code-1257", "Model-1257", "Name-1257", "Specification-1257", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1258, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8675), true, "Remark-1258", "Code-1258", "Model-1258", "Name-1258", "Specification-1258", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1259, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8678), true, "Remark-1259", "Code-1259", "Model-1259", "Name-1259", "Specification-1259", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1260, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8681), true, "Remark-1260", "Code-1260", "Model-1260", "Name-1260", "Specification-1260", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1261, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8684), true, "Remark-1261", "Code-1261", "Model-1261", "Name-1261", "Specification-1261", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1262, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8686), true, "Remark-1262", "Code-1262", "Model-1262", "Name-1262", "Specification-1262", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1263, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8689), true, "Remark-1263", "Code-1263", "Model-1263", "Name-1263", "Specification-1263", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1264, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8692), true, "Remark-1264", "Code-1264", "Model-1264", "Name-1264", "Specification-1264", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1265, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8695), true, "Remark-1265", "Code-1265", "Model-1265", "Name-1265", "Specification-1265", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1266, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8698), true, "Remark-1266", "Code-1266", "Model-1266", "Name-1266", "Specification-1266", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1267, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8701), true, "Remark-1267", "Code-1267", "Model-1267", "Name-1267", "Specification-1267", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1268, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8704), true, "Remark-1268", "Code-1268", "Model-1268", "Name-1268", "Specification-1268", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1269, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8707), true, "Remark-1269", "Code-1269", "Model-1269", "Name-1269", "Specification-1269", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1270, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8710), true, "Remark-1270", "Code-1270", "Model-1270", "Name-1270", "Specification-1270", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1271, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8713), true, "Remark-1271", "Code-1271", "Model-1271", "Name-1271", "Specification-1271", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1272, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8716), true, "Remark-1272", "Code-1272", "Model-1272", "Name-1272", "Specification-1272", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1273, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8722), true, "Remark-1273", "Code-1273", "Model-1273", "Name-1273", "Specification-1273", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1274, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8725), true, "Remark-1274", "Code-1274", "Model-1274", "Name-1274", "Specification-1274", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1275, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8728), true, "Remark-1275", "Code-1275", "Model-1275", "Name-1275", "Specification-1275", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1276, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8731), true, "Remark-1276", "Code-1276", "Model-1276", "Name-1276", "Specification-1276", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1277, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8734), true, "Remark-1277", "Code-1277", "Model-1277", "Name-1277", "Specification-1277", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1278, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8738), true, "Remark-1278", "Code-1278", "Model-1278", "Name-1278", "Specification-1278", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1279, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8741), true, "Remark-1279", "Code-1279", "Model-1279", "Name-1279", "Specification-1279", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1280, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8744), true, "Remark-1280", "Code-1280", "Model-1280", "Name-1280", "Specification-1280", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1281, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8747), true, "Remark-1281", "Code-1281", "Model-1281", "Name-1281", "Specification-1281", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1282, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8750), true, "Remark-1282", "Code-1282", "Model-1282", "Name-1282", "Specification-1282", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1283, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8752), true, "Remark-1283", "Code-1283", "Model-1283", "Name-1283", "Specification-1283", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1284, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8755), true, "Remark-1284", "Code-1284", "Model-1284", "Name-1284", "Specification-1284", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1285, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8758), true, "Remark-1285", "Code-1285", "Model-1285", "Name-1285", "Specification-1285", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1286, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8761), true, "Remark-1286", "Code-1286", "Model-1286", "Name-1286", "Specification-1286", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1287, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8764), true, "Remark-1287", "Code-1287", "Model-1287", "Name-1287", "Specification-1287", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1288, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8767), true, "Remark-1288", "Code-1288", "Model-1288", "Name-1288", "Specification-1288", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1289, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8770), true, "Remark-1289", "Code-1289", "Model-1289", "Name-1289", "Specification-1289", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1290, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8773), true, "Remark-1290", "Code-1290", "Model-1290", "Name-1290", "Specification-1290", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1291, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8776), true, "Remark-1291", "Code-1291", "Model-1291", "Name-1291", "Specification-1291", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1292, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8779), true, "Remark-1292", "Code-1292", "Model-1292", "Name-1292", "Specification-1292", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1293, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8785), true, "Remark-1293", "Code-1293", "Model-1293", "Name-1293", "Specification-1293", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1294, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8788), true, "Remark-1294", "Code-1294", "Model-1294", "Name-1294", "Specification-1294", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1295, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8791), true, "Remark-1295", "Code-1295", "Model-1295", "Name-1295", "Specification-1295", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1296, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8794), true, "Remark-1296", "Code-1296", "Model-1296", "Name-1296", "Specification-1296", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1297, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8797), true, "Remark-1297", "Code-1297", "Model-1297", "Name-1297", "Specification-1297", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1298, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8800), true, "Remark-1298", "Code-1298", "Model-1298", "Name-1298", "Specification-1298", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1299, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8803), true, "Remark-1299", "Code-1299", "Model-1299", "Name-1299", "Specification-1299", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1300, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8806), true, "Remark-1300", "Code-1300", "Model-1300", "Name-1300", "Specification-1300", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1301, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8809), true, "Remark-1301", "Code-1301", "Model-1301", "Name-1301", "Specification-1301", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1302, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8811), true, "Remark-1302", "Code-1302", "Model-1302", "Name-1302", "Specification-1302", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1303, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8814), true, "Remark-1303", "Code-1303", "Model-1303", "Name-1303", "Specification-1303", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1304, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8818), true, "Remark-1304", "Code-1304", "Model-1304", "Name-1304", "Specification-1304", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1305, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8821), true, "Remark-1305", "Code-1305", "Model-1305", "Name-1305", "Specification-1305", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1306, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8823), true, "Remark-1306", "Code-1306", "Model-1306", "Name-1306", "Specification-1306", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1307, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8826), true, "Remark-1307", "Code-1307", "Model-1307", "Name-1307", "Specification-1307", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1308, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8829), true, "Remark-1308", "Code-1308", "Model-1308", "Name-1308", "Specification-1308", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1309, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8832), true, "Remark-1309", "Code-1309", "Model-1309", "Name-1309", "Specification-1309", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1310, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8835), true, "Remark-1310", "Code-1310", "Model-1310", "Name-1310", "Specification-1310", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1311, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8838), true, "Remark-1311", "Code-1311", "Model-1311", "Name-1311", "Specification-1311", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1312, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8841), true, "Remark-1312", "Code-1312", "Model-1312", "Name-1312", "Specification-1312", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1313, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8847), true, "Remark-1313", "Code-1313", "Model-1313", "Name-1313", "Specification-1313", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1314, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8850), true, "Remark-1314", "Code-1314", "Model-1314", "Name-1314", "Specification-1314", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1315, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8853), true, "Remark-1315", "Code-1315", "Model-1315", "Name-1315", "Specification-1315", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1316, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8856), true, "Remark-1316", "Code-1316", "Model-1316", "Name-1316", "Specification-1316", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1317, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8859), true, "Remark-1317", "Code-1317", "Model-1317", "Name-1317", "Specification-1317", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1318, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8862), true, "Remark-1318", "Code-1318", "Model-1318", "Name-1318", "Specification-1318", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1319, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8865), true, "Remark-1319", "Code-1319", "Model-1319", "Name-1319", "Specification-1319", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1320, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8868), true, "Remark-1320", "Code-1320", "Model-1320", "Name-1320", "Specification-1320", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1321, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8871), true, "Remark-1321", "Code-1321", "Model-1321", "Name-1321", "Specification-1321", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1322, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8874), true, "Remark-1322", "Code-1322", "Model-1322", "Name-1322", "Specification-1322", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1323, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8877), true, "Remark-1323", "Code-1323", "Model-1323", "Name-1323", "Specification-1323", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1324, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8880), true, "Remark-1324", "Code-1324", "Model-1324", "Name-1324", "Specification-1324", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1325, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8883), true, "Remark-1325", "Code-1325", "Model-1325", "Name-1325", "Specification-1325", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1326, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8886), true, "Remark-1326", "Code-1326", "Model-1326", "Name-1326", "Specification-1326", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1327, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8889), true, "Remark-1327", "Code-1327", "Model-1327", "Name-1327", "Specification-1327", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1328, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8891), true, "Remark-1328", "Code-1328", "Model-1328", "Name-1328", "Specification-1328", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1329, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8895), true, "Remark-1329", "Code-1329", "Model-1329", "Name-1329", "Specification-1329", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1330, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8898), true, "Remark-1330", "Code-1330", "Model-1330", "Name-1330", "Specification-1330", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1331, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8901), true, "Remark-1331", "Code-1331", "Model-1331", "Name-1331", "Specification-1331", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1332, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8903), true, "Remark-1332", "Code-1332", "Model-1332", "Name-1332", "Specification-1332", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1333, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8910), true, "Remark-1333", "Code-1333", "Model-1333", "Name-1333", "Specification-1333", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1334, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8913), true, "Remark-1334", "Code-1334", "Model-1334", "Name-1334", "Specification-1334", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1335, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8916), true, "Remark-1335", "Code-1335", "Model-1335", "Name-1335", "Specification-1335", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1336, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8919), true, "Remark-1336", "Code-1336", "Model-1336", "Name-1336", "Specification-1336", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1337, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8922), true, "Remark-1337", "Code-1337", "Model-1337", "Name-1337", "Specification-1337", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1338, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8926), true, "Remark-1338", "Code-1338", "Model-1338", "Name-1338", "Specification-1338", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1339, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8928), true, "Remark-1339", "Code-1339", "Model-1339", "Name-1339", "Specification-1339", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1340, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8931), true, "Remark-1340", "Code-1340", "Model-1340", "Name-1340", "Specification-1340", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1341, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8934), true, "Remark-1341", "Code-1341", "Model-1341", "Name-1341", "Specification-1341", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1342, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8938), true, "Remark-1342", "Code-1342", "Model-1342", "Name-1342", "Specification-1342", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1343, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8941), true, "Remark-1343", "Code-1343", "Model-1343", "Name-1343", "Specification-1343", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1344, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8943), true, "Remark-1344", "Code-1344", "Model-1344", "Name-1344", "Specification-1344", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1345, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8946), true, "Remark-1345", "Code-1345", "Model-1345", "Name-1345", "Specification-1345", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1346, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8949), true, "Remark-1346", "Code-1346", "Model-1346", "Name-1346", "Specification-1346", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1347, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8952), true, "Remark-1347", "Code-1347", "Model-1347", "Name-1347", "Specification-1347", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1348, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8955), true, "Remark-1348", "Code-1348", "Model-1348", "Name-1348", "Specification-1348", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1349, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8958), true, "Remark-1349", "Code-1349", "Model-1349", "Name-1349", "Specification-1349", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1350, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8961), true, "Remark-1350", "Code-1350", "Model-1350", "Name-1350", "Specification-1350", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1351, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8964), true, "Remark-1351", "Code-1351", "Model-1351", "Name-1351", "Specification-1351", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1352, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8967), true, "Remark-1352", "Code-1352", "Model-1352", "Name-1352", "Specification-1352", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1353, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8973), true, "Remark-1353", "Code-1353", "Model-1353", "Name-1353", "Specification-1353", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1354, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8976), true, "Remark-1354", "Code-1354", "Model-1354", "Name-1354", "Specification-1354", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1355, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8979), true, "Remark-1355", "Code-1355", "Model-1355", "Name-1355", "Specification-1355", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1356, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8982), true, "Remark-1356", "Code-1356", "Model-1356", "Name-1356", "Specification-1356", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1357, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8985), true, "Remark-1357", "Code-1357", "Model-1357", "Name-1357", "Specification-1357", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1358, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8988), true, "Remark-1358", "Code-1358", "Model-1358", "Name-1358", "Specification-1358", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1359, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8991), true, "Remark-1359", "Code-1359", "Model-1359", "Name-1359", "Specification-1359", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1360, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8993), true, "Remark-1360", "Code-1360", "Model-1360", "Name-1360", "Specification-1360", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1361, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8996), true, "Remark-1361", "Code-1361", "Model-1361", "Name-1361", "Specification-1361", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1362, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(8999), true, "Remark-1362", "Code-1362", "Model-1362", "Name-1362", "Specification-1362", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1363, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9002), true, "Remark-1363", "Code-1363", "Model-1363", "Name-1363", "Specification-1363", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1364, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9005), true, "Remark-1364", "Code-1364", "Model-1364", "Name-1364", "Specification-1364", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1365, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9008), true, "Remark-1365", "Code-1365", "Model-1365", "Name-1365", "Specification-1365", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1366, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9011), true, "Remark-1366", "Code-1366", "Model-1366", "Name-1366", "Specification-1366", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1367, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9014), true, "Remark-1367", "Code-1367", "Model-1367", "Name-1367", "Specification-1367", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1368, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9016), true, "Remark-1368", "Code-1368", "Model-1368", "Name-1368", "Specification-1368", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1369, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9019), true, "Remark-1369", "Code-1369", "Model-1369", "Name-1369", "Specification-1369", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1370, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9022), true, "Remark-1370", "Code-1370", "Model-1370", "Name-1370", "Specification-1370", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1371, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9025), true, "Remark-1371", "Code-1371", "Model-1371", "Name-1371", "Specification-1371", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1372, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9028), true, "Remark-1372", "Code-1372", "Model-1372", "Name-1372", "Specification-1372", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1373, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9034), true, "Remark-1373", "Code-1373", "Model-1373", "Name-1373", "Specification-1373", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1374, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9038), true, "Remark-1374", "Code-1374", "Model-1374", "Name-1374", "Specification-1374", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1375, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9041), true, "Remark-1375", "Code-1375", "Model-1375", "Name-1375", "Specification-1375", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1376, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9043), true, "Remark-1376", "Code-1376", "Model-1376", "Name-1376", "Specification-1376", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1377, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9046), true, "Remark-1377", "Code-1377", "Model-1377", "Name-1377", "Specification-1377", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1378, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9049), true, "Remark-1378", "Code-1378", "Model-1378", "Name-1378", "Specification-1378", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1379, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9052), true, "Remark-1379", "Code-1379", "Model-1379", "Name-1379", "Specification-1379", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1380, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9055), true, "Remark-1380", "Code-1380", "Model-1380", "Name-1380", "Specification-1380", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1381, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9058), true, "Remark-1381", "Code-1381", "Model-1381", "Name-1381", "Specification-1381", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1382, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9061), true, "Remark-1382", "Code-1382", "Model-1382", "Name-1382", "Specification-1382", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1383, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9064), true, "Remark-1383", "Code-1383", "Model-1383", "Name-1383", "Specification-1383", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1384, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9067), true, "Remark-1384", "Code-1384", "Model-1384", "Name-1384", "Specification-1384", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1385, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9070), true, "Remark-1385", "Code-1385", "Model-1385", "Name-1385", "Specification-1385", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1386, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9072), true, "Remark-1386", "Code-1386", "Model-1386", "Name-1386", "Specification-1386", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1387, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9075), true, "Remark-1387", "Code-1387", "Model-1387", "Name-1387", "Specification-1387", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1388, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9078), true, "Remark-1388", "Code-1388", "Model-1388", "Name-1388", "Specification-1388", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1389, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9081), true, "Remark-1389", "Code-1389", "Model-1389", "Name-1389", "Specification-1389", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1390, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9084), true, "Remark-1390", "Code-1390", "Model-1390", "Name-1390", "Specification-1390", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1391, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9433), true, "Remark-1391", "Code-1391", "Model-1391", "Name-1391", "Specification-1391", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1392, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9436), true, "Remark-1392", "Code-1392", "Model-1392", "Name-1392", "Specification-1392", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1393, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9442), true, "Remark-1393", "Code-1393", "Model-1393", "Name-1393", "Specification-1393", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1394, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9445), true, "Remark-1394", "Code-1394", "Model-1394", "Name-1394", "Specification-1394", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1395, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9448), true, "Remark-1395", "Code-1395", "Model-1395", "Name-1395", "Specification-1395", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1396, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9451), true, "Remark-1396", "Code-1396", "Model-1396", "Name-1396", "Specification-1396", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1397, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9453), true, "Remark-1397", "Code-1397", "Model-1397", "Name-1397", "Specification-1397", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1398, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9456), true, "Remark-1398", "Code-1398", "Model-1398", "Name-1398", "Specification-1398", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1399, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9459), true, "Remark-1399", "Code-1399", "Model-1399", "Name-1399", "Specification-1399", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1400, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9462), true, "Remark-1400", "Code-1400", "Model-1400", "Name-1400", "Specification-1400", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1401, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9465), true, "Remark-1401", "Code-1401", "Model-1401", "Name-1401", "Specification-1401", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1402, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9467), true, "Remark-1402", "Code-1402", "Model-1402", "Name-1402", "Specification-1402", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1403, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9470), true, "Remark-1403", "Code-1403", "Model-1403", "Name-1403", "Specification-1403", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1404, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9472), true, "Remark-1404", "Code-1404", "Model-1404", "Name-1404", "Specification-1404", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1405, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9475), true, "Remark-1405", "Code-1405", "Model-1405", "Name-1405", "Specification-1405", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1406, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9478), true, "Remark-1406", "Code-1406", "Model-1406", "Name-1406", "Specification-1406", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1407, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9481), true, "Remark-1407", "Code-1407", "Model-1407", "Name-1407", "Specification-1407", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1408, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9483), true, "Remark-1408", "Code-1408", "Model-1408", "Name-1408", "Specification-1408", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1409, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9486), true, "Remark-1409", "Code-1409", "Model-1409", "Name-1409", "Specification-1409", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1410, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9489), true, "Remark-1410", "Code-1410", "Model-1410", "Name-1410", "Specification-1410", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1411, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9491), true, "Remark-1411", "Code-1411", "Model-1411", "Name-1411", "Specification-1411", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1412, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9494), true, "Remark-1412", "Code-1412", "Model-1412", "Name-1412", "Specification-1412", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1413, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9502), true, "Remark-1413", "Code-1413", "Model-1413", "Name-1413", "Specification-1413", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1414, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9505), true, "Remark-1414", "Code-1414", "Model-1414", "Name-1414", "Specification-1414", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1415, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9508), true, "Remark-1415", "Code-1415", "Model-1415", "Name-1415", "Specification-1415", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1416, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9511), true, "Remark-1416", "Code-1416", "Model-1416", "Name-1416", "Specification-1416", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1417, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9514), true, "Remark-1417", "Code-1417", "Model-1417", "Name-1417", "Specification-1417", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1418, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9516), true, "Remark-1418", "Code-1418", "Model-1418", "Name-1418", "Specification-1418", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1419, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9519), true, "Remark-1419", "Code-1419", "Model-1419", "Name-1419", "Specification-1419", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1420, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9522), true, "Remark-1420", "Code-1420", "Model-1420", "Name-1420", "Specification-1420", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1421, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9525), true, "Remark-1421", "Code-1421", "Model-1421", "Name-1421", "Specification-1421", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1422, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9527), true, "Remark-1422", "Code-1422", "Model-1422", "Name-1422", "Specification-1422", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1423, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9530), true, "Remark-1423", "Code-1423", "Model-1423", "Name-1423", "Specification-1423", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1424, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9533), true, "Remark-1424", "Code-1424", "Model-1424", "Name-1424", "Specification-1424", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1425, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9535), true, "Remark-1425", "Code-1425", "Model-1425", "Name-1425", "Specification-1425", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1426, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9538), true, "Remark-1426", "Code-1426", "Model-1426", "Name-1426", "Specification-1426", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1427, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9540), true, "Remark-1427", "Code-1427", "Model-1427", "Name-1427", "Specification-1427", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1428, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9543), true, "Remark-1428", "Code-1428", "Model-1428", "Name-1428", "Specification-1428", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1429, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9546), true, "Remark-1429", "Code-1429", "Model-1429", "Name-1429", "Specification-1429", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1430, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9549), true, "Remark-1430", "Code-1430", "Model-1430", "Name-1430", "Specification-1430", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1431, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9551), true, "Remark-1431", "Code-1431", "Model-1431", "Name-1431", "Specification-1431", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1432, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9554), true, "Remark-1432", "Code-1432", "Model-1432", "Name-1432", "Specification-1432", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1433, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9575), true, "Remark-1433", "Code-1433", "Model-1433", "Name-1433", "Specification-1433", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1434, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9578), true, "Remark-1434", "Code-1434", "Model-1434", "Name-1434", "Specification-1434", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1435, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9580), true, "Remark-1435", "Code-1435", "Model-1435", "Name-1435", "Specification-1435", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1436, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9583), true, "Remark-1436", "Code-1436", "Model-1436", "Name-1436", "Specification-1436", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1437, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9586), true, "Remark-1437", "Code-1437", "Model-1437", "Name-1437", "Specification-1437", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1438, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9588), true, "Remark-1438", "Code-1438", "Model-1438", "Name-1438", "Specification-1438", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1439, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9591), true, "Remark-1439", "Code-1439", "Model-1439", "Name-1439", "Specification-1439", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1440, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9594), true, "Remark-1440", "Code-1440", "Model-1440", "Name-1440", "Specification-1440", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1441, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9596), true, "Remark-1441", "Code-1441", "Model-1441", "Name-1441", "Specification-1441", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1442, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9599), true, "Remark-1442", "Code-1442", "Model-1442", "Name-1442", "Specification-1442", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1443, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9602), true, "Remark-1443", "Code-1443", "Model-1443", "Name-1443", "Specification-1443", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1444, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9604), true, "Remark-1444", "Code-1444", "Model-1444", "Name-1444", "Specification-1444", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1445, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9607), true, "Remark-1445", "Code-1445", "Model-1445", "Name-1445", "Specification-1445", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1446, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9610), true, "Remark-1446", "Code-1446", "Model-1446", "Name-1446", "Specification-1446", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1447, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9612), true, "Remark-1447", "Code-1447", "Model-1447", "Name-1447", "Specification-1447", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1448, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9615), true, "Remark-1448", "Code-1448", "Model-1448", "Name-1448", "Specification-1448", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1449, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9617), true, "Remark-1449", "Code-1449", "Model-1449", "Name-1449", "Specification-1449", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1450, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9620), true, "Remark-1450", "Code-1450", "Model-1450", "Name-1450", "Specification-1450", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1451, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9623), true, "Remark-1451", "Code-1451", "Model-1451", "Name-1451", "Specification-1451", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1452, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9625), true, "Remark-1452", "Code-1452", "Model-1452", "Name-1452", "Specification-1452", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1453, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9632), true, "Remark-1453", "Code-1453", "Model-1453", "Name-1453", "Specification-1453", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1454, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9634), true, "Remark-1454", "Code-1454", "Model-1454", "Name-1454", "Specification-1454", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1455, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9637), true, "Remark-1455", "Code-1455", "Model-1455", "Name-1455", "Specification-1455", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1456, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9640), true, "Remark-1456", "Code-1456", "Model-1456", "Name-1456", "Specification-1456", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1457, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9642), true, "Remark-1457", "Code-1457", "Model-1457", "Name-1457", "Specification-1457", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1458, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9645), true, "Remark-1458", "Code-1458", "Model-1458", "Name-1458", "Specification-1458", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1459, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9648), true, "Remark-1459", "Code-1459", "Model-1459", "Name-1459", "Specification-1459", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1460, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9651), true, "Remark-1460", "Code-1460", "Model-1460", "Name-1460", "Specification-1460", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1461, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9653), true, "Remark-1461", "Code-1461", "Model-1461", "Name-1461", "Specification-1461", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1462, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9656), true, "Remark-1462", "Code-1462", "Model-1462", "Name-1462", "Specification-1462", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1463, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9659), true, "Remark-1463", "Code-1463", "Model-1463", "Name-1463", "Specification-1463", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1464, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9661), true, "Remark-1464", "Code-1464", "Model-1464", "Name-1464", "Specification-1464", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1465, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9664), true, "Remark-1465", "Code-1465", "Model-1465", "Name-1465", "Specification-1465", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1466, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9667), true, "Remark-1466", "Code-1466", "Model-1466", "Name-1466", "Specification-1466", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1467, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9669), true, "Remark-1467", "Code-1467", "Model-1467", "Name-1467", "Specification-1467", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1468, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9672), true, "Remark-1468", "Code-1468", "Model-1468", "Name-1468", "Specification-1468", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1469, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9674), true, "Remark-1469", "Code-1469", "Model-1469", "Name-1469", "Specification-1469", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1470, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9677), true, "Remark-1470", "Code-1470", "Model-1470", "Name-1470", "Specification-1470", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1471, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9680), true, "Remark-1471", "Code-1471", "Model-1471", "Name-1471", "Specification-1471", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1472, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9683), true, "Remark-1472", "Code-1472", "Model-1472", "Name-1472", "Specification-1472", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1473, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9689), true, "Remark-1473", "Code-1473", "Model-1473", "Name-1473", "Specification-1473", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1474, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9691), true, "Remark-1474", "Code-1474", "Model-1474", "Name-1474", "Specification-1474", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1475, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9694), true, "Remark-1475", "Code-1475", "Model-1475", "Name-1475", "Specification-1475", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1476, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9696), true, "Remark-1476", "Code-1476", "Model-1476", "Name-1476", "Specification-1476", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1477, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9699), true, "Remark-1477", "Code-1477", "Model-1477", "Name-1477", "Specification-1477", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1478, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9702), true, "Remark-1478", "Code-1478", "Model-1478", "Name-1478", "Specification-1478", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1479, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9705), true, "Remark-1479", "Code-1479", "Model-1479", "Name-1479", "Specification-1479", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1480, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9707), true, "Remark-1480", "Code-1480", "Model-1480", "Name-1480", "Specification-1480", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1481, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9710), true, "Remark-1481", "Code-1481", "Model-1481", "Name-1481", "Specification-1481", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1482, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9713), true, "Remark-1482", "Code-1482", "Model-1482", "Name-1482", "Specification-1482", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1483, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9716), true, "Remark-1483", "Code-1483", "Model-1483", "Name-1483", "Specification-1483", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1484, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9718), true, "Remark-1484", "Code-1484", "Model-1484", "Name-1484", "Specification-1484", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1485, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9721), true, "Remark-1485", "Code-1485", "Model-1485", "Name-1485", "Specification-1485", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1486, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9724), true, "Remark-1486", "Code-1486", "Model-1486", "Name-1486", "Specification-1486", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1487, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9726), true, "Remark-1487", "Code-1487", "Model-1487", "Name-1487", "Specification-1487", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1488, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9729), true, "Remark-1488", "Code-1488", "Model-1488", "Name-1488", "Specification-1488", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1489, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9732), true, "Remark-1489", "Code-1489", "Model-1489", "Name-1489", "Specification-1489", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1490, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9734), true, "Remark-1490", "Code-1490", "Model-1490", "Name-1490", "Specification-1490", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1491, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9737), true, "Remark-1491", "Code-1491", "Model-1491", "Name-1491", "Specification-1491", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1492, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9740), true, "Remark-1492", "Code-1492", "Model-1492", "Name-1492", "Specification-1492", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1493, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9746), true, "Remark-1493", "Code-1493", "Model-1493", "Name-1493", "Specification-1493", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1494, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9748), true, "Remark-1494", "Code-1494", "Model-1494", "Name-1494", "Specification-1494", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1495, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9751), true, "Remark-1495", "Code-1495", "Model-1495", "Name-1495", "Specification-1495", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1496, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9754), true, "Remark-1496", "Code-1496", "Model-1496", "Name-1496", "Specification-1496", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1497, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9756), true, "Remark-1497", "Code-1497", "Model-1497", "Name-1497", "Specification-1497", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1498, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9759), true, "Remark-1498", "Code-1498", "Model-1498", "Name-1498", "Specification-1498", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1499, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9762), true, "Remark-1499", "Code-1499", "Model-1499", "Name-1499", "Specification-1499", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1500, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9765), true, "Remark-1500", "Code-1500", "Model-1500", "Name-1500", "Specification-1500", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1501, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9767), true, "Remark-1501", "Code-1501", "Model-1501", "Name-1501", "Specification-1501", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1502, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9770), true, "Remark-1502", "Code-1502", "Model-1502", "Name-1502", "Specification-1502", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1503, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9772), true, "Remark-1503", "Code-1503", "Model-1503", "Name-1503", "Specification-1503", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1504, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9775), true, "Remark-1504", "Code-1504", "Model-1504", "Name-1504", "Specification-1504", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1505, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9778), true, "Remark-1505", "Code-1505", "Model-1505", "Name-1505", "Specification-1505", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1506, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9780), true, "Remark-1506", "Code-1506", "Model-1506", "Name-1506", "Specification-1506", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1507, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9783), true, "Remark-1507", "Code-1507", "Model-1507", "Name-1507", "Specification-1507", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1508, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9786), true, "Remark-1508", "Code-1508", "Model-1508", "Name-1508", "Specification-1508", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1509, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9788), true, "Remark-1509", "Code-1509", "Model-1509", "Name-1509", "Specification-1509", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1510, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9791), true, "Remark-1510", "Code-1510", "Model-1510", "Name-1510", "Specification-1510", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1511, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9793), true, "Remark-1511", "Code-1511", "Model-1511", "Name-1511", "Specification-1511", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1512, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9796), true, "Remark-1512", "Code-1512", "Model-1512", "Name-1512", "Specification-1512", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1513, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9812), true, "Remark-1513", "Code-1513", "Model-1513", "Name-1513", "Specification-1513", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1514, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9815), true, "Remark-1514", "Code-1514", "Model-1514", "Name-1514", "Specification-1514", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1515, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9818), true, "Remark-1515", "Code-1515", "Model-1515", "Name-1515", "Specification-1515", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1516, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9821), true, "Remark-1516", "Code-1516", "Model-1516", "Name-1516", "Specification-1516", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1517, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9823), true, "Remark-1517", "Code-1517", "Model-1517", "Name-1517", "Specification-1517", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1518, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9826), true, "Remark-1518", "Code-1518", "Model-1518", "Name-1518", "Specification-1518", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1519, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9829), true, "Remark-1519", "Code-1519", "Model-1519", "Name-1519", "Specification-1519", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1520, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9831), true, "Remark-1520", "Code-1520", "Model-1520", "Name-1520", "Specification-1520", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1521, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9834), true, "Remark-1521", "Code-1521", "Model-1521", "Name-1521", "Specification-1521", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1522, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9837), true, "Remark-1522", "Code-1522", "Model-1522", "Name-1522", "Specification-1522", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1523, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9840), true, "Remark-1523", "Code-1523", "Model-1523", "Name-1523", "Specification-1523", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1524, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9843), true, "Remark-1524", "Code-1524", "Model-1524", "Name-1524", "Specification-1524", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1525, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9845), true, "Remark-1525", "Code-1525", "Model-1525", "Name-1525", "Specification-1525", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1526, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9848), true, "Remark-1526", "Code-1526", "Model-1526", "Name-1526", "Specification-1526", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1527, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9850), true, "Remark-1527", "Code-1527", "Model-1527", "Name-1527", "Specification-1527", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1528, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9853), true, "Remark-1528", "Code-1528", "Model-1528", "Name-1528", "Specification-1528", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1529, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9856), true, "Remark-1529", "Code-1529", "Model-1529", "Name-1529", "Specification-1529", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1530, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9858), true, "Remark-1530", "Code-1530", "Model-1530", "Name-1530", "Specification-1530", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1531, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9861), true, "Remark-1531", "Code-1531", "Model-1531", "Name-1531", "Specification-1531", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1532, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9864), true, "Remark-1532", "Code-1532", "Model-1532", "Name-1532", "Specification-1532", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1533, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9870), true, "Remark-1533", "Code-1533", "Model-1533", "Name-1533", "Specification-1533", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1534, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9873), true, "Remark-1534", "Code-1534", "Model-1534", "Name-1534", "Specification-1534", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1535, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9876), true, "Remark-1535", "Code-1535", "Model-1535", "Name-1535", "Specification-1535", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1536, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9879), true, "Remark-1536", "Code-1536", "Model-1536", "Name-1536", "Specification-1536", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1537, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9882), true, "Remark-1537", "Code-1537", "Model-1537", "Name-1537", "Specification-1537", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1538, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9888), true, "Remark-1538", "Code-1538", "Model-1538", "Name-1538", "Specification-1538", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1539, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9890), true, "Remark-1539", "Code-1539", "Model-1539", "Name-1539", "Specification-1539", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1540, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9893), true, "Remark-1540", "Code-1540", "Model-1540", "Name-1540", "Specification-1540", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1541, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9896), true, "Remark-1541", "Code-1541", "Model-1541", "Name-1541", "Specification-1541", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1542, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9898), true, "Remark-1542", "Code-1542", "Model-1542", "Name-1542", "Specification-1542", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1543, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9901), true, "Remark-1543", "Code-1543", "Model-1543", "Name-1543", "Specification-1543", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1544, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9904), true, "Remark-1544", "Code-1544", "Model-1544", "Name-1544", "Specification-1544", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1545, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9907), true, "Remark-1545", "Code-1545", "Model-1545", "Name-1545", "Specification-1545", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1546, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9909), true, "Remark-1546", "Code-1546", "Model-1546", "Name-1546", "Specification-1546", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1547, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9912), true, "Remark-1547", "Code-1547", "Model-1547", "Name-1547", "Specification-1547", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1548, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9915), true, "Remark-1548", "Code-1548", "Model-1548", "Name-1548", "Specification-1548", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1549, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9918), true, "Remark-1549", "Code-1549", "Model-1549", "Name-1549", "Specification-1549", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1550, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9920), true, "Remark-1550", "Code-1550", "Model-1550", "Name-1550", "Specification-1550", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1551, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9923), true, "Remark-1551", "Code-1551", "Model-1551", "Name-1551", "Specification-1551", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1552, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9926), true, "Remark-1552", "Code-1552", "Model-1552", "Name-1552", "Specification-1552", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1553, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9932), true, "Remark-1553", "Code-1553", "Model-1553", "Name-1553", "Specification-1553", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1554, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9935), true, "Remark-1554", "Code-1554", "Model-1554", "Name-1554", "Specification-1554", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1555, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9938), true, "Remark-1555", "Code-1555", "Model-1555", "Name-1555", "Specification-1555", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1556, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9941), true, "Remark-1556", "Code-1556", "Model-1556", "Name-1556", "Specification-1556", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1557, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9943), true, "Remark-1557", "Code-1557", "Model-1557", "Name-1557", "Specification-1557", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1558, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9946), true, "Remark-1558", "Code-1558", "Model-1558", "Name-1558", "Specification-1558", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1559, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9949), true, "Remark-1559", "Code-1559", "Model-1559", "Name-1559", "Specification-1559", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1560, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9952), true, "Remark-1560", "Code-1560", "Model-1560", "Name-1560", "Specification-1560", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1561, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9954), true, "Remark-1561", "Code-1561", "Model-1561", "Name-1561", "Specification-1561", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1562, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9957), true, "Remark-1562", "Code-1562", "Model-1562", "Name-1562", "Specification-1562", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1563, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9959), true, "Remark-1563", "Code-1563", "Model-1563", "Name-1563", "Specification-1563", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1564, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9962), true, "Remark-1564", "Code-1564", "Model-1564", "Name-1564", "Specification-1564", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1565, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9965), true, "Remark-1565", "Code-1565", "Model-1565", "Name-1565", "Specification-1565", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1566, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9968), true, "Remark-1566", "Code-1566", "Model-1566", "Name-1566", "Specification-1566", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1567, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9971), true, "Remark-1567", "Code-1567", "Model-1567", "Name-1567", "Specification-1567", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1568, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9973), true, "Remark-1568", "Code-1568", "Model-1568", "Name-1568", "Specification-1568", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1569, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9976), true, "Remark-1569", "Code-1569", "Model-1569", "Name-1569", "Specification-1569", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1570, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9979), true, "Remark-1570", "Code-1570", "Model-1570", "Name-1570", "Specification-1570", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1571, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9981), true, "Remark-1571", "Code-1571", "Model-1571", "Name-1571", "Specification-1571", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1572, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9984), true, "Remark-1572", "Code-1572", "Model-1572", "Name-1572", "Specification-1572", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1573, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9989), true, "Remark-1573", "Code-1573", "Model-1573", "Name-1573", "Specification-1573", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1574, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9993), true, "Remark-1574", "Code-1574", "Model-1574", "Name-1574", "Specification-1574", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1575, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9996), true, "Remark-1575", "Code-1575", "Model-1575", "Name-1575", "Specification-1575", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1576, new DateTime(2022, 4, 13, 2, 30, 35, 302, DateTimeKind.Utc).AddTicks(9998), true, "Remark-1576", "Code-1576", "Model-1576", "Name-1576", "Specification-1576", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1577, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1), true, "Remark-1577", "Code-1577", "Model-1577", "Name-1577", "Specification-1577", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1578, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(4), true, "Remark-1578", "Code-1578", "Model-1578", "Name-1578", "Specification-1578", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1579, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(6), true, "Remark-1579", "Code-1579", "Model-1579", "Name-1579", "Specification-1579", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1580, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(9), true, "Remark-1580", "Code-1580", "Model-1580", "Name-1580", "Specification-1580", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1581, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(12), true, "Remark-1581", "Code-1581", "Model-1581", "Name-1581", "Specification-1581", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1582, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(15), true, "Remark-1582", "Code-1582", "Model-1582", "Name-1582", "Specification-1582", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1583, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(17), true, "Remark-1583", "Code-1583", "Model-1583", "Name-1583", "Specification-1583", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1584, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(20), true, "Remark-1584", "Code-1584", "Model-1584", "Name-1584", "Specification-1584", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1585, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(23), true, "Remark-1585", "Code-1585", "Model-1585", "Name-1585", "Specification-1585", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1586, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(25), true, "Remark-1586", "Code-1586", "Model-1586", "Name-1586", "Specification-1586", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1587, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(28), true, "Remark-1587", "Code-1587", "Model-1587", "Name-1587", "Specification-1587", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1588, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(31), true, "Remark-1588", "Code-1588", "Model-1588", "Name-1588", "Specification-1588", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1589, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(33), true, "Remark-1589", "Code-1589", "Model-1589", "Name-1589", "Specification-1589", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1590, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(36), true, "Remark-1590", "Code-1590", "Model-1590", "Name-1590", "Specification-1590", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1591, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(39), true, "Remark-1591", "Code-1591", "Model-1591", "Name-1591", "Specification-1591", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1592, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(42), true, "Remark-1592", "Code-1592", "Model-1592", "Name-1592", "Specification-1592", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1593, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(49), true, "Remark-1593", "Code-1593", "Model-1593", "Name-1593", "Specification-1593", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1594, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(51), true, "Remark-1594", "Code-1594", "Model-1594", "Name-1594", "Specification-1594", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1595, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(54), true, "Remark-1595", "Code-1595", "Model-1595", "Name-1595", "Specification-1595", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1596, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(57), true, "Remark-1596", "Code-1596", "Model-1596", "Name-1596", "Specification-1596", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1597, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(59), true, "Remark-1597", "Code-1597", "Model-1597", "Name-1597", "Specification-1597", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1598, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(62), true, "Remark-1598", "Code-1598", "Model-1598", "Name-1598", "Specification-1598", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1599, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(65), true, "Remark-1599", "Code-1599", "Model-1599", "Name-1599", "Specification-1599", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1600, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(68), true, "Remark-1600", "Code-1600", "Model-1600", "Name-1600", "Specification-1600", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1601, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(70), true, "Remark-1601", "Code-1601", "Model-1601", "Name-1601", "Specification-1601", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1602, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(73), true, "Remark-1602", "Code-1602", "Model-1602", "Name-1602", "Specification-1602", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1603, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(76), true, "Remark-1603", "Code-1603", "Model-1603", "Name-1603", "Specification-1603", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1604, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(79), true, "Remark-1604", "Code-1604", "Model-1604", "Name-1604", "Specification-1604", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1605, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(81), true, "Remark-1605", "Code-1605", "Model-1605", "Name-1605", "Specification-1605", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1606, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(84), true, "Remark-1606", "Code-1606", "Model-1606", "Name-1606", "Specification-1606", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1607, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(87), true, "Remark-1607", "Code-1607", "Model-1607", "Name-1607", "Specification-1607", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1608, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(89), true, "Remark-1608", "Code-1608", "Model-1608", "Name-1608", "Specification-1608", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1609, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(92), true, "Remark-1609", "Code-1609", "Model-1609", "Name-1609", "Specification-1609", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1610, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(95), true, "Remark-1610", "Code-1610", "Model-1610", "Name-1610", "Specification-1610", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1611, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(98), true, "Remark-1611", "Code-1611", "Model-1611", "Name-1611", "Specification-1611", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1612, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(100), true, "Remark-1612", "Code-1612", "Model-1612", "Name-1612", "Specification-1612", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1613, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(107), true, "Remark-1613", "Code-1613", "Model-1613", "Name-1613", "Specification-1613", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1614, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(110), true, "Remark-1614", "Code-1614", "Model-1614", "Name-1614", "Specification-1614", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1615, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(113), true, "Remark-1615", "Code-1615", "Model-1615", "Name-1615", "Specification-1615", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1616, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(115), true, "Remark-1616", "Code-1616", "Model-1616", "Name-1616", "Specification-1616", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1617, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(118), true, "Remark-1617", "Code-1617", "Model-1617", "Name-1617", "Specification-1617", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1618, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(120), true, "Remark-1618", "Code-1618", "Model-1618", "Name-1618", "Specification-1618", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1619, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(123), true, "Remark-1619", "Code-1619", "Model-1619", "Name-1619", "Specification-1619", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1620, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(126), true, "Remark-1620", "Code-1620", "Model-1620", "Name-1620", "Specification-1620", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1621, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(128), true, "Remark-1621", "Code-1621", "Model-1621", "Name-1621", "Specification-1621", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1622, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(131), true, "Remark-1622", "Code-1622", "Model-1622", "Name-1622", "Specification-1622", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1623, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(134), true, "Remark-1623", "Code-1623", "Model-1623", "Name-1623", "Specification-1623", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1624, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(137), true, "Remark-1624", "Code-1624", "Model-1624", "Name-1624", "Specification-1624", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1625, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(139), true, "Remark-1625", "Code-1625", "Model-1625", "Name-1625", "Specification-1625", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1626, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(142), true, "Remark-1626", "Code-1626", "Model-1626", "Name-1626", "Specification-1626", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1627, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(145), true, "Remark-1627", "Code-1627", "Model-1627", "Name-1627", "Specification-1627", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1628, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(147), true, "Remark-1628", "Code-1628", "Model-1628", "Name-1628", "Specification-1628", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1629, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(150), true, "Remark-1629", "Code-1629", "Model-1629", "Name-1629", "Specification-1629", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1630, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(153), true, "Remark-1630", "Code-1630", "Model-1630", "Name-1630", "Specification-1630", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1631, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(155), true, "Remark-1631", "Code-1631", "Model-1631", "Name-1631", "Specification-1631", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1632, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(158), true, "Remark-1632", "Code-1632", "Model-1632", "Name-1632", "Specification-1632", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1633, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(163), true, "Remark-1633", "Code-1633", "Model-1633", "Name-1633", "Specification-1633", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1634, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(166), true, "Remark-1634", "Code-1634", "Model-1634", "Name-1634", "Specification-1634", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1635, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(169), true, "Remark-1635", "Code-1635", "Model-1635", "Name-1635", "Specification-1635", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1636, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(172), true, "Remark-1636", "Code-1636", "Model-1636", "Name-1636", "Specification-1636", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1637, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(174), true, "Remark-1637", "Code-1637", "Model-1637", "Name-1637", "Specification-1637", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1638, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(177), true, "Remark-1638", "Code-1638", "Model-1638", "Name-1638", "Specification-1638", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1639, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(180), true, "Remark-1639", "Code-1639", "Model-1639", "Name-1639", "Specification-1639", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1640, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(182), true, "Remark-1640", "Code-1640", "Model-1640", "Name-1640", "Specification-1640", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1641, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(185), true, "Remark-1641", "Code-1641", "Model-1641", "Name-1641", "Specification-1641", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1642, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(188), true, "Remark-1642", "Code-1642", "Model-1642", "Name-1642", "Specification-1642", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1643, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(190), true, "Remark-1643", "Code-1643", "Model-1643", "Name-1643", "Specification-1643", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1644, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(193), true, "Remark-1644", "Code-1644", "Model-1644", "Name-1644", "Specification-1644", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1645, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(196), true, "Remark-1645", "Code-1645", "Model-1645", "Name-1645", "Specification-1645", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1646, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(198), true, "Remark-1646", "Code-1646", "Model-1646", "Name-1646", "Specification-1646", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1647, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(201), true, "Remark-1647", "Code-1647", "Model-1647", "Name-1647", "Specification-1647", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1648, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(203), true, "Remark-1648", "Code-1648", "Model-1648", "Name-1648", "Specification-1648", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1649, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(206), true, "Remark-1649", "Code-1649", "Model-1649", "Name-1649", "Specification-1649", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1650, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(209), true, "Remark-1650", "Code-1650", "Model-1650", "Name-1650", "Specification-1650", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1651, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(212), true, "Remark-1651", "Code-1651", "Model-1651", "Name-1651", "Specification-1651", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1652, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(214), true, "Remark-1652", "Code-1652", "Model-1652", "Name-1652", "Specification-1652", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1653, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(220), true, "Remark-1653", "Code-1653", "Model-1653", "Name-1653", "Specification-1653", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1654, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(223), true, "Remark-1654", "Code-1654", "Model-1654", "Name-1654", "Specification-1654", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1655, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(225), true, "Remark-1655", "Code-1655", "Model-1655", "Name-1655", "Specification-1655", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1656, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(228), true, "Remark-1656", "Code-1656", "Model-1656", "Name-1656", "Specification-1656", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1657, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(231), true, "Remark-1657", "Code-1657", "Model-1657", "Name-1657", "Specification-1657", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1658, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(233), true, "Remark-1658", "Code-1658", "Model-1658", "Name-1658", "Specification-1658", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1659, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(236), true, "Remark-1659", "Code-1659", "Model-1659", "Name-1659", "Specification-1659", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1660, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(239), true, "Remark-1660", "Code-1660", "Model-1660", "Name-1660", "Specification-1660", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1661, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(242), true, "Remark-1661", "Code-1661", "Model-1661", "Name-1661", "Specification-1661", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1662, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(244), true, "Remark-1662", "Code-1662", "Model-1662", "Name-1662", "Specification-1662", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1663, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(247), true, "Remark-1663", "Code-1663", "Model-1663", "Name-1663", "Specification-1663", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1664, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(249), true, "Remark-1664", "Code-1664", "Model-1664", "Name-1664", "Specification-1664", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1665, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(252), true, "Remark-1665", "Code-1665", "Model-1665", "Name-1665", "Specification-1665", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1666, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(255), true, "Remark-1666", "Code-1666", "Model-1666", "Name-1666", "Specification-1666", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1667, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(257), true, "Remark-1667", "Code-1667", "Model-1667", "Name-1667", "Specification-1667", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1668, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(260), true, "Remark-1668", "Code-1668", "Model-1668", "Name-1668", "Specification-1668", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1669, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(263), true, "Remark-1669", "Code-1669", "Model-1669", "Name-1669", "Specification-1669", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1670, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(265), true, "Remark-1670", "Code-1670", "Model-1670", "Name-1670", "Specification-1670", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1671, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(268), true, "Remark-1671", "Code-1671", "Model-1671", "Name-1671", "Specification-1671", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1672, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(271), true, "Remark-1672", "Code-1672", "Model-1672", "Name-1672", "Specification-1672", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1673, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(277), true, "Remark-1673", "Code-1673", "Model-1673", "Name-1673", "Specification-1673", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1674, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(280), true, "Remark-1674", "Code-1674", "Model-1674", "Name-1674", "Specification-1674", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1675, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(282), true, "Remark-1675", "Code-1675", "Model-1675", "Name-1675", "Specification-1675", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1676, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(285), true, "Remark-1676", "Code-1676", "Model-1676", "Name-1676", "Specification-1676", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1677, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(288), true, "Remark-1677", "Code-1677", "Model-1677", "Name-1677", "Specification-1677", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1678, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(290), true, "Remark-1678", "Code-1678", "Model-1678", "Name-1678", "Specification-1678", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1679, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(293), true, "Remark-1679", "Code-1679", "Model-1679", "Name-1679", "Specification-1679", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1680, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(295), true, "Remark-1680", "Code-1680", "Model-1680", "Name-1680", "Specification-1680", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1681, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(298), true, "Remark-1681", "Code-1681", "Model-1681", "Name-1681", "Specification-1681", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1682, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(301), true, "Remark-1682", "Code-1682", "Model-1682", "Name-1682", "Specification-1682", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1683, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(304), true, "Remark-1683", "Code-1683", "Model-1683", "Name-1683", "Specification-1683", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1684, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(306), true, "Remark-1684", "Code-1684", "Model-1684", "Name-1684", "Specification-1684", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1685, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(309), true, "Remark-1685", "Code-1685", "Model-1685", "Name-1685", "Specification-1685", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1686, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(311), true, "Remark-1686", "Code-1686", "Model-1686", "Name-1686", "Specification-1686", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1687, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(314), true, "Remark-1687", "Code-1687", "Model-1687", "Name-1687", "Specification-1687", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1688, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(317), true, "Remark-1688", "Code-1688", "Model-1688", "Name-1688", "Specification-1688", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1689, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(319), true, "Remark-1689", "Code-1689", "Model-1689", "Name-1689", "Specification-1689", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1690, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(322), true, "Remark-1690", "Code-1690", "Model-1690", "Name-1690", "Specification-1690", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1691, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(325), true, "Remark-1691", "Code-1691", "Model-1691", "Name-1691", "Specification-1691", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1692, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(327), true, "Remark-1692", "Code-1692", "Model-1692", "Name-1692", "Specification-1692", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1693, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(335), true, "Remark-1693", "Code-1693", "Model-1693", "Name-1693", "Specification-1693", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1694, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(338), true, "Remark-1694", "Code-1694", "Model-1694", "Name-1694", "Specification-1694", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1695, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(340), true, "Remark-1695", "Code-1695", "Model-1695", "Name-1695", "Specification-1695", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1696, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(343), true, "Remark-1696", "Code-1696", "Model-1696", "Name-1696", "Specification-1696", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1697, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(346), true, "Remark-1697", "Code-1697", "Model-1697", "Name-1697", "Specification-1697", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1698, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(348), true, "Remark-1698", "Code-1698", "Model-1698", "Name-1698", "Specification-1698", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1699, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(351), true, "Remark-1699", "Code-1699", "Model-1699", "Name-1699", "Specification-1699", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1700, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(354), true, "Remark-1700", "Code-1700", "Model-1700", "Name-1700", "Specification-1700", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1701, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(357), true, "Remark-1701", "Code-1701", "Model-1701", "Name-1701", "Specification-1701", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1702, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(359), true, "Remark-1702", "Code-1702", "Model-1702", "Name-1702", "Specification-1702", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1703, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(362), true, "Remark-1703", "Code-1703", "Model-1703", "Name-1703", "Specification-1703", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1704, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(365), true, "Remark-1704", "Code-1704", "Model-1704", "Name-1704", "Specification-1704", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1705, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(367), true, "Remark-1705", "Code-1705", "Model-1705", "Name-1705", "Specification-1705", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1706, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(370), true, "Remark-1706", "Code-1706", "Model-1706", "Name-1706", "Specification-1706", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1707, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(372), true, "Remark-1707", "Code-1707", "Model-1707", "Name-1707", "Specification-1707", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1708, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(375), true, "Remark-1708", "Code-1708", "Model-1708", "Name-1708", "Specification-1708", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1709, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(379), true, "Remark-1709", "Code-1709", "Model-1709", "Name-1709", "Specification-1709", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1710, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(381), true, "Remark-1710", "Code-1710", "Model-1710", "Name-1710", "Specification-1710", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1711, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(384), true, "Remark-1711", "Code-1711", "Model-1711", "Name-1711", "Specification-1711", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1712, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(387), true, "Remark-1712", "Code-1712", "Model-1712", "Name-1712", "Specification-1712", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1713, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(392), true, "Remark-1713", "Code-1713", "Model-1713", "Name-1713", "Specification-1713", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1714, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(395), true, "Remark-1714", "Code-1714", "Model-1714", "Name-1714", "Specification-1714", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1715, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(398), true, "Remark-1715", "Code-1715", "Model-1715", "Name-1715", "Specification-1715", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1716, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(400), true, "Remark-1716", "Code-1716", "Model-1716", "Name-1716", "Specification-1716", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1717, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(403), true, "Remark-1717", "Code-1717", "Model-1717", "Name-1717", "Specification-1717", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1718, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(406), true, "Remark-1718", "Code-1718", "Model-1718", "Name-1718", "Specification-1718", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1719, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(408), true, "Remark-1719", "Code-1719", "Model-1719", "Name-1719", "Specification-1719", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1720, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(411), true, "Remark-1720", "Code-1720", "Model-1720", "Name-1720", "Specification-1720", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1721, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(414), true, "Remark-1721", "Code-1721", "Model-1721", "Name-1721", "Specification-1721", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1722, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(416), true, "Remark-1722", "Code-1722", "Model-1722", "Name-1722", "Specification-1722", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1723, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(419), true, "Remark-1723", "Code-1723", "Model-1723", "Name-1723", "Specification-1723", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1724, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(422), true, "Remark-1724", "Code-1724", "Model-1724", "Name-1724", "Specification-1724", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1725, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(424), true, "Remark-1725", "Code-1725", "Model-1725", "Name-1725", "Specification-1725", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1726, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(427), true, "Remark-1726", "Code-1726", "Model-1726", "Name-1726", "Specification-1726", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1727, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(429), true, "Remark-1727", "Code-1727", "Model-1727", "Name-1727", "Specification-1727", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1728, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(432), true, "Remark-1728", "Code-1728", "Model-1728", "Name-1728", "Specification-1728", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1729, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(435), true, "Remark-1729", "Code-1729", "Model-1729", "Name-1729", "Specification-1729", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1730, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(437), true, "Remark-1730", "Code-1730", "Model-1730", "Name-1730", "Specification-1730", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1731, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(440), true, "Remark-1731", "Code-1731", "Model-1731", "Name-1731", "Specification-1731", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1732, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(443), true, "Remark-1732", "Code-1732", "Model-1732", "Name-1732", "Specification-1732", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1733, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(448), true, "Remark-1733", "Code-1733", "Model-1733", "Name-1733", "Specification-1733", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1734, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(451), true, "Remark-1734", "Code-1734", "Model-1734", "Name-1734", "Specification-1734", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1735, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(454), true, "Remark-1735", "Code-1735", "Model-1735", "Name-1735", "Specification-1735", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1736, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(457), true, "Remark-1736", "Code-1736", "Model-1736", "Name-1736", "Specification-1736", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1737, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(460), true, "Remark-1737", "Code-1737", "Model-1737", "Name-1737", "Specification-1737", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1738, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(462), true, "Remark-1738", "Code-1738", "Model-1738", "Name-1738", "Specification-1738", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1739, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(465), true, "Remark-1739", "Code-1739", "Model-1739", "Name-1739", "Specification-1739", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1740, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(468), true, "Remark-1740", "Code-1740", "Model-1740", "Name-1740", "Specification-1740", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1741, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(471), true, "Remark-1741", "Code-1741", "Model-1741", "Name-1741", "Specification-1741", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1742, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(473), true, "Remark-1742", "Code-1742", "Model-1742", "Name-1742", "Specification-1742", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1743, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(476), true, "Remark-1743", "Code-1743", "Model-1743", "Name-1743", "Specification-1743", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1744, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(478), true, "Remark-1744", "Code-1744", "Model-1744", "Name-1744", "Specification-1744", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1745, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(481), true, "Remark-1745", "Code-1745", "Model-1745", "Name-1745", "Specification-1745", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1746, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(484), true, "Remark-1746", "Code-1746", "Model-1746", "Name-1746", "Specification-1746", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1747, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(486), true, "Remark-1747", "Code-1747", "Model-1747", "Name-1747", "Specification-1747", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1748, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(489), true, "Remark-1748", "Code-1748", "Model-1748", "Name-1748", "Specification-1748", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1749, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(492), true, "Remark-1749", "Code-1749", "Model-1749", "Name-1749", "Specification-1749", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1750, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(494), true, "Remark-1750", "Code-1750", "Model-1750", "Name-1750", "Specification-1750", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1751, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(497), true, "Remark-1751", "Code-1751", "Model-1751", "Name-1751", "Specification-1751", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1752, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(500), true, "Remark-1752", "Code-1752", "Model-1752", "Name-1752", "Specification-1752", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1753, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(506), true, "Remark-1753", "Code-1753", "Model-1753", "Name-1753", "Specification-1753", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1754, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(508), true, "Remark-1754", "Code-1754", "Model-1754", "Name-1754", "Specification-1754", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1755, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(511), true, "Remark-1755", "Code-1755", "Model-1755", "Name-1755", "Specification-1755", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1756, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(514), true, "Remark-1756", "Code-1756", "Model-1756", "Name-1756", "Specification-1756", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1757, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(516), true, "Remark-1757", "Code-1757", "Model-1757", "Name-1757", "Specification-1757", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1758, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(519), true, "Remark-1758", "Code-1758", "Model-1758", "Name-1758", "Specification-1758", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1759, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(522), true, "Remark-1759", "Code-1759", "Model-1759", "Name-1759", "Specification-1759", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1760, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(524), true, "Remark-1760", "Code-1760", "Model-1760", "Name-1760", "Specification-1760", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1761, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(527), true, "Remark-1761", "Code-1761", "Model-1761", "Name-1761", "Specification-1761", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1762, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(530), true, "Remark-1762", "Code-1762", "Model-1762", "Name-1762", "Specification-1762", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1763, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(532), true, "Remark-1763", "Code-1763", "Model-1763", "Name-1763", "Specification-1763", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1764, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(535), true, "Remark-1764", "Code-1764", "Model-1764", "Name-1764", "Specification-1764", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1765, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(538), true, "Remark-1765", "Code-1765", "Model-1765", "Name-1765", "Specification-1765", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1766, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(540), true, "Remark-1766", "Code-1766", "Model-1766", "Name-1766", "Specification-1766", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1767, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(543), true, "Remark-1767", "Code-1767", "Model-1767", "Name-1767", "Specification-1767", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1768, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(546), true, "Remark-1768", "Code-1768", "Model-1768", "Name-1768", "Specification-1768", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1769, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(548), true, "Remark-1769", "Code-1769", "Model-1769", "Name-1769", "Specification-1769", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1770, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(551), true, "Remark-1770", "Code-1770", "Model-1770", "Name-1770", "Specification-1770", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1771, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(554), true, "Remark-1771", "Code-1771", "Model-1771", "Name-1771", "Specification-1771", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1772, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(556), true, "Remark-1772", "Code-1772", "Model-1772", "Name-1772", "Specification-1772", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1773, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(564), true, "Remark-1773", "Code-1773", "Model-1773", "Name-1773", "Specification-1773", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1774, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(567), true, "Remark-1774", "Code-1774", "Model-1774", "Name-1774", "Specification-1774", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1775, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(569), true, "Remark-1775", "Code-1775", "Model-1775", "Name-1775", "Specification-1775", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1776, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(572), true, "Remark-1776", "Code-1776", "Model-1776", "Name-1776", "Specification-1776", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1777, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(574), true, "Remark-1777", "Code-1777", "Model-1777", "Name-1777", "Specification-1777", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1778, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(577), true, "Remark-1778", "Code-1778", "Model-1778", "Name-1778", "Specification-1778", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1779, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(580), true, "Remark-1779", "Code-1779", "Model-1779", "Name-1779", "Specification-1779", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1780, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(582), true, "Remark-1780", "Code-1780", "Model-1780", "Name-1780", "Specification-1780", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1781, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(585), true, "Remark-1781", "Code-1781", "Model-1781", "Name-1781", "Specification-1781", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1782, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(588), true, "Remark-1782", "Code-1782", "Model-1782", "Name-1782", "Specification-1782", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1783, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(590), true, "Remark-1783", "Code-1783", "Model-1783", "Name-1783", "Specification-1783", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1784, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(593), true, "Remark-1784", "Code-1784", "Model-1784", "Name-1784", "Specification-1784", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1785, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(596), true, "Remark-1785", "Code-1785", "Model-1785", "Name-1785", "Specification-1785", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1786, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(598), true, "Remark-1786", "Code-1786", "Model-1786", "Name-1786", "Specification-1786", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1787, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(601), true, "Remark-1787", "Code-1787", "Model-1787", "Name-1787", "Specification-1787", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1788, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(604), true, "Remark-1788", "Code-1788", "Model-1788", "Name-1788", "Specification-1788", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1789, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(606), true, "Remark-1789", "Code-1789", "Model-1789", "Name-1789", "Specification-1789", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1790, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(609), true, "Remark-1790", "Code-1790", "Model-1790", "Name-1790", "Specification-1790", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1791, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(611), true, "Remark-1791", "Code-1791", "Model-1791", "Name-1791", "Specification-1791", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1792, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(614), true, "Remark-1792", "Code-1792", "Model-1792", "Name-1792", "Specification-1792", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1793, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(620), true, "Remark-1793", "Code-1793", "Model-1793", "Name-1793", "Specification-1793", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1794, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(622), true, "Remark-1794", "Code-1794", "Model-1794", "Name-1794", "Specification-1794", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1795, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(625), true, "Remark-1795", "Code-1795", "Model-1795", "Name-1795", "Specification-1795", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1796, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(628), true, "Remark-1796", "Code-1796", "Model-1796", "Name-1796", "Specification-1796", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1797, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(630), true, "Remark-1797", "Code-1797", "Model-1797", "Name-1797", "Specification-1797", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1798, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(633), true, "Remark-1798", "Code-1798", "Model-1798", "Name-1798", "Specification-1798", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1799, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(636), true, "Remark-1799", "Code-1799", "Model-1799", "Name-1799", "Specification-1799", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1800, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(639), true, "Remark-1800", "Code-1800", "Model-1800", "Name-1800", "Specification-1800", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1801, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(641), true, "Remark-1801", "Code-1801", "Model-1801", "Name-1801", "Specification-1801", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1802, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(644), true, "Remark-1802", "Code-1802", "Model-1802", "Name-1802", "Specification-1802", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1803, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(646), true, "Remark-1803", "Code-1803", "Model-1803", "Name-1803", "Specification-1803", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1804, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(649), true, "Remark-1804", "Code-1804", "Model-1804", "Name-1804", "Specification-1804", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1805, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(652), true, "Remark-1805", "Code-1805", "Model-1805", "Name-1805", "Specification-1805", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1806, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(654), true, "Remark-1806", "Code-1806", "Model-1806", "Name-1806", "Specification-1806", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1807, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(657), true, "Remark-1807", "Code-1807", "Model-1807", "Name-1807", "Specification-1807", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1808, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(660), true, "Remark-1808", "Code-1808", "Model-1808", "Name-1808", "Specification-1808", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1809, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(662), true, "Remark-1809", "Code-1809", "Model-1809", "Name-1809", "Specification-1809", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1810, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(665), true, "Remark-1810", "Code-1810", "Model-1810", "Name-1810", "Specification-1810", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1811, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(667), true, "Remark-1811", "Code-1811", "Model-1811", "Name-1811", "Specification-1811", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1812, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(670), true, "Remark-1812", "Code-1812", "Model-1812", "Name-1812", "Specification-1812", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1813, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(676), true, "Remark-1813", "Code-1813", "Model-1813", "Name-1813", "Specification-1813", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1814, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(679), true, "Remark-1814", "Code-1814", "Model-1814", "Name-1814", "Specification-1814", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1815, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(681), true, "Remark-1815", "Code-1815", "Model-1815", "Name-1815", "Specification-1815", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1816, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(684), true, "Remark-1816", "Code-1816", "Model-1816", "Name-1816", "Specification-1816", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1817, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(687), true, "Remark-1817", "Code-1817", "Model-1817", "Name-1817", "Specification-1817", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1818, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(689), true, "Remark-1818", "Code-1818", "Model-1818", "Name-1818", "Specification-1818", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1819, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(692), true, "Remark-1819", "Code-1819", "Model-1819", "Name-1819", "Specification-1819", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1820, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(694), true, "Remark-1820", "Code-1820", "Model-1820", "Name-1820", "Specification-1820", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1821, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(697), true, "Remark-1821", "Code-1821", "Model-1821", "Name-1821", "Specification-1821", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1822, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(700), true, "Remark-1822", "Code-1822", "Model-1822", "Name-1822", "Specification-1822", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1823, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(703), true, "Remark-1823", "Code-1823", "Model-1823", "Name-1823", "Specification-1823", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1824, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(705), true, "Remark-1824", "Code-1824", "Model-1824", "Name-1824", "Specification-1824", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1825, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(708), true, "Remark-1825", "Code-1825", "Model-1825", "Name-1825", "Specification-1825", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1826, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(711), true, "Remark-1826", "Code-1826", "Model-1826", "Name-1826", "Specification-1826", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1827, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(713), true, "Remark-1827", "Code-1827", "Model-1827", "Name-1827", "Specification-1827", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1828, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(716), true, "Remark-1828", "Code-1828", "Model-1828", "Name-1828", "Specification-1828", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1829, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(719), true, "Remark-1829", "Code-1829", "Model-1829", "Name-1829", "Specification-1829", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1830, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(721), true, "Remark-1830", "Code-1830", "Model-1830", "Name-1830", "Specification-1830", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1831, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(724), true, "Remark-1831", "Code-1831", "Model-1831", "Name-1831", "Specification-1831", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1832, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(727), true, "Remark-1832", "Code-1832", "Model-1832", "Name-1832", "Specification-1832", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1833, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(732), true, "Remark-1833", "Code-1833", "Model-1833", "Name-1833", "Specification-1833", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1834, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(735), true, "Remark-1834", "Code-1834", "Model-1834", "Name-1834", "Specification-1834", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1835, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(738), true, "Remark-1835", "Code-1835", "Model-1835", "Name-1835", "Specification-1835", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1836, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(741), true, "Remark-1836", "Code-1836", "Model-1836", "Name-1836", "Specification-1836", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1837, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(743), true, "Remark-1837", "Code-1837", "Model-1837", "Name-1837", "Specification-1837", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1838, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(746), true, "Remark-1838", "Code-1838", "Model-1838", "Name-1838", "Specification-1838", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1839, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(749), true, "Remark-1839", "Code-1839", "Model-1839", "Name-1839", "Specification-1839", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1840, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(752), true, "Remark-1840", "Code-1840", "Model-1840", "Name-1840", "Specification-1840", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1841, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(755), true, "Remark-1841", "Code-1841", "Model-1841", "Name-1841", "Specification-1841", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1842, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(757), true, "Remark-1842", "Code-1842", "Model-1842", "Name-1842", "Specification-1842", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1843, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(760), true, "Remark-1843", "Code-1843", "Model-1843", "Name-1843", "Specification-1843", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1844, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(763), true, "Remark-1844", "Code-1844", "Model-1844", "Name-1844", "Specification-1844", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1845, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(766), true, "Remark-1845", "Code-1845", "Model-1845", "Name-1845", "Specification-1845", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1846, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(769), true, "Remark-1846", "Code-1846", "Model-1846", "Name-1846", "Specification-1846", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1847, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(771), true, "Remark-1847", "Code-1847", "Model-1847", "Name-1847", "Specification-1847", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1848, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(774), true, "Remark-1848", "Code-1848", "Model-1848", "Name-1848", "Specification-1848", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1849, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(777), true, "Remark-1849", "Code-1849", "Model-1849", "Name-1849", "Specification-1849", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1850, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(780), true, "Remark-1850", "Code-1850", "Model-1850", "Name-1850", "Specification-1850", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1851, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(782), true, "Remark-1851", "Code-1851", "Model-1851", "Name-1851", "Specification-1851", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1852, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(785), true, "Remark-1852", "Code-1852", "Model-1852", "Name-1852", "Specification-1852", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1853, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(792), true, "Remark-1853", "Code-1853", "Model-1853", "Name-1853", "Specification-1853", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1854, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(795), true, "Remark-1854", "Code-1854", "Model-1854", "Name-1854", "Specification-1854", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1855, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(798), true, "Remark-1855", "Code-1855", "Model-1855", "Name-1855", "Specification-1855", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1856, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(801), true, "Remark-1856", "Code-1856", "Model-1856", "Name-1856", "Specification-1856", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1857, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(803), true, "Remark-1857", "Code-1857", "Model-1857", "Name-1857", "Specification-1857", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1858, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(806), true, "Remark-1858", "Code-1858", "Model-1858", "Name-1858", "Specification-1858", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1859, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(809), true, "Remark-1859", "Code-1859", "Model-1859", "Name-1859", "Specification-1859", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1860, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(811), true, "Remark-1860", "Code-1860", "Model-1860", "Name-1860", "Specification-1860", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1861, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(814), true, "Remark-1861", "Code-1861", "Model-1861", "Name-1861", "Specification-1861", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1862, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(817), true, "Remark-1862", "Code-1862", "Model-1862", "Name-1862", "Specification-1862", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1863, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(819), true, "Remark-1863", "Code-1863", "Model-1863", "Name-1863", "Specification-1863", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1864, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(822), true, "Remark-1864", "Code-1864", "Model-1864", "Name-1864", "Specification-1864", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1865, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(825), true, "Remark-1865", "Code-1865", "Model-1865", "Name-1865", "Specification-1865", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1866, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(828), true, "Remark-1866", "Code-1866", "Model-1866", "Name-1866", "Specification-1866", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1867, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(830), true, "Remark-1867", "Code-1867", "Model-1867", "Name-1867", "Specification-1867", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1868, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(833), true, "Remark-1868", "Code-1868", "Model-1868", "Name-1868", "Specification-1868", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1869, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(836), true, "Remark-1869", "Code-1869", "Model-1869", "Name-1869", "Specification-1869", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1870, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(839), true, "Remark-1870", "Code-1870", "Model-1870", "Name-1870", "Specification-1870", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1871, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(842), true, "Remark-1871", "Code-1871", "Model-1871", "Name-1871", "Specification-1871", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1872, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(845), true, "Remark-1872", "Code-1872", "Model-1872", "Name-1872", "Specification-1872", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1873, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(850), true, "Remark-1873", "Code-1873", "Model-1873", "Name-1873", "Specification-1873", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1874, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(853), true, "Remark-1874", "Code-1874", "Model-1874", "Name-1874", "Specification-1874", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1875, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(856), true, "Remark-1875", "Code-1875", "Model-1875", "Name-1875", "Specification-1875", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1876, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(859), true, "Remark-1876", "Code-1876", "Model-1876", "Name-1876", "Specification-1876", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1877, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(861), true, "Remark-1877", "Code-1877", "Model-1877", "Name-1877", "Specification-1877", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1878, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(864), true, "Remark-1878", "Code-1878", "Model-1878", "Name-1878", "Specification-1878", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1879, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(867), true, "Remark-1879", "Code-1879", "Model-1879", "Name-1879", "Specification-1879", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1880, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(869), true, "Remark-1880", "Code-1880", "Model-1880", "Name-1880", "Specification-1880", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1881, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(872), true, "Remark-1881", "Code-1881", "Model-1881", "Name-1881", "Specification-1881", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1882, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(875), true, "Remark-1882", "Code-1882", "Model-1882", "Name-1882", "Specification-1882", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1883, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(877), true, "Remark-1883", "Code-1883", "Model-1883", "Name-1883", "Specification-1883", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1884, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(880), true, "Remark-1884", "Code-1884", "Model-1884", "Name-1884", "Specification-1884", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1885, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(882), true, "Remark-1885", "Code-1885", "Model-1885", "Name-1885", "Specification-1885", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1886, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(885), true, "Remark-1886", "Code-1886", "Model-1886", "Name-1886", "Specification-1886", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1887, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(888), true, "Remark-1887", "Code-1887", "Model-1887", "Name-1887", "Specification-1887", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1888, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(890), true, "Remark-1888", "Code-1888", "Model-1888", "Name-1888", "Specification-1888", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1889, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(893), true, "Remark-1889", "Code-1889", "Model-1889", "Name-1889", "Specification-1889", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1890, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(896), true, "Remark-1890", "Code-1890", "Model-1890", "Name-1890", "Specification-1890", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1891, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(898), true, "Remark-1891", "Code-1891", "Model-1891", "Name-1891", "Specification-1891", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1892, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(901), true, "Remark-1892", "Code-1892", "Model-1892", "Name-1892", "Specification-1892", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1893, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(906), true, "Remark-1893", "Code-1893", "Model-1893", "Name-1893", "Specification-1893", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1894, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(910), true, "Remark-1894", "Code-1894", "Model-1894", "Name-1894", "Specification-1894", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1895, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(912), true, "Remark-1895", "Code-1895", "Model-1895", "Name-1895", "Specification-1895", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1896, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(915), true, "Remark-1896", "Code-1896", "Model-1896", "Name-1896", "Specification-1896", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1897, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(918), true, "Remark-1897", "Code-1897", "Model-1897", "Name-1897", "Specification-1897", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1898, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(920), true, "Remark-1898", "Code-1898", "Model-1898", "Name-1898", "Specification-1898", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1899, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(923), true, "Remark-1899", "Code-1899", "Model-1899", "Name-1899", "Specification-1899", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1900, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(926), true, "Remark-1900", "Code-1900", "Model-1900", "Name-1900", "Specification-1900", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1901, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(929), true, "Remark-1901", "Code-1901", "Model-1901", "Name-1901", "Specification-1901", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1902, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(931), true, "Remark-1902", "Code-1902", "Model-1902", "Name-1902", "Specification-1902", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1903, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(934), true, "Remark-1903", "Code-1903", "Model-1903", "Name-1903", "Specification-1903", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1904, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(936), true, "Remark-1904", "Code-1904", "Model-1904", "Name-1904", "Specification-1904", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1905, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(939), true, "Remark-1905", "Code-1905", "Model-1905", "Name-1905", "Specification-1905", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1906, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(942), true, "Remark-1906", "Code-1906", "Model-1906", "Name-1906", "Specification-1906", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1907, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(944), true, "Remark-1907", "Code-1907", "Model-1907", "Name-1907", "Specification-1907", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1908, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(947), true, "Remark-1908", "Code-1908", "Model-1908", "Name-1908", "Specification-1908", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1909, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(950), true, "Remark-1909", "Code-1909", "Model-1909", "Name-1909", "Specification-1909", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1910, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(952), true, "Remark-1910", "Code-1910", "Model-1910", "Name-1910", "Specification-1910", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1911, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(955), true, "Remark-1911", "Code-1911", "Model-1911", "Name-1911", "Specification-1911", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1912, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(958), true, "Remark-1912", "Code-1912", "Model-1912", "Name-1912", "Specification-1912", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1913, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(964), true, "Remark-1913", "Code-1913", "Model-1913", "Name-1913", "Specification-1913", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1914, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(967), true, "Remark-1914", "Code-1914", "Model-1914", "Name-1914", "Specification-1914", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1915, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(969), true, "Remark-1915", "Code-1915", "Model-1915", "Name-1915", "Specification-1915", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1916, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(972), true, "Remark-1916", "Code-1916", "Model-1916", "Name-1916", "Specification-1916", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1917, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(975), true, "Remark-1917", "Code-1917", "Model-1917", "Name-1917", "Specification-1917", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1918, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(977), true, "Remark-1918", "Code-1918", "Model-1918", "Name-1918", "Specification-1918", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1919, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(980), true, "Remark-1919", "Code-1919", "Model-1919", "Name-1919", "Specification-1919", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1920, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(983), true, "Remark-1920", "Code-1920", "Model-1920", "Name-1920", "Specification-1920", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1921, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(986), true, "Remark-1921", "Code-1921", "Model-1921", "Name-1921", "Specification-1921", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1922, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(989), true, "Remark-1922", "Code-1922", "Model-1922", "Name-1922", "Specification-1922", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1923, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(991), true, "Remark-1923", "Code-1923", "Model-1923", "Name-1923", "Specification-1923", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1924, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(994), true, "Remark-1924", "Code-1924", "Model-1924", "Name-1924", "Specification-1924", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1925, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(997), true, "Remark-1925", "Code-1925", "Model-1925", "Name-1925", "Specification-1925", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1926, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(999), true, "Remark-1926", "Code-1926", "Model-1926", "Name-1926", "Specification-1926", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1927, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1002), true, "Remark-1927", "Code-1927", "Model-1927", "Name-1927", "Specification-1927", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1928, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1005), true, "Remark-1928", "Code-1928", "Model-1928", "Name-1928", "Specification-1928", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1929, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1008), true, "Remark-1929", "Code-1929", "Model-1929", "Name-1929", "Specification-1929", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1930, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1010), true, "Remark-1930", "Code-1930", "Model-1930", "Name-1930", "Specification-1930", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1931, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1013), true, "Remark-1931", "Code-1931", "Model-1931", "Name-1931", "Specification-1931", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1932, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1016), true, "Remark-1932", "Code-1932", "Model-1932", "Name-1932", "Specification-1932", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1933, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1021), true, "Remark-1933", "Code-1933", "Model-1933", "Name-1933", "Specification-1933", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1934, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1025), true, "Remark-1934", "Code-1934", "Model-1934", "Name-1934", "Specification-1934", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1935, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1027), true, "Remark-1935", "Code-1935", "Model-1935", "Name-1935", "Specification-1935", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1936, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1030), true, "Remark-1936", "Code-1936", "Model-1936", "Name-1936", "Specification-1936", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1937, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1033), true, "Remark-1937", "Code-1937", "Model-1937", "Name-1937", "Specification-1937", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1938, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1036), true, "Remark-1938", "Code-1938", "Model-1938", "Name-1938", "Specification-1938", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1939, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1039), true, "Remark-1939", "Code-1939", "Model-1939", "Name-1939", "Specification-1939", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1940, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1041), true, "Remark-1940", "Code-1940", "Model-1940", "Name-1940", "Specification-1940", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1941, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1044), true, "Remark-1941", "Code-1941", "Model-1941", "Name-1941", "Specification-1941", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1942, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1047), true, "Remark-1942", "Code-1942", "Model-1942", "Name-1942", "Specification-1942", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1943, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1050), true, "Remark-1943", "Code-1943", "Model-1943", "Name-1943", "Specification-1943", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1944, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1052), true, "Remark-1944", "Code-1944", "Model-1944", "Name-1944", "Specification-1944", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1945, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1055), true, "Remark-1945", "Code-1945", "Model-1945", "Name-1945", "Specification-1945", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1946, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1058), true, "Remark-1946", "Code-1946", "Model-1946", "Name-1946", "Specification-1946", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1947, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1061), true, "Remark-1947", "Code-1947", "Model-1947", "Name-1947", "Specification-1947", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1948, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1063), true, "Remark-1948", "Code-1948", "Model-1948", "Name-1948", "Specification-1948", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1949, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1067), true, "Remark-1949", "Code-1949", "Model-1949", "Name-1949", "Specification-1949", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1950, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1070), true, "Remark-1950", "Code-1950", "Model-1950", "Name-1950", "Specification-1950", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1951, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1072), true, "Remark-1951", "Code-1951", "Model-1951", "Name-1951", "Specification-1951", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1952, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1075), true, "Remark-1952", "Code-1952", "Model-1952", "Name-1952", "Specification-1952", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1953, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1081), true, "Remark-1953", "Code-1953", "Model-1953", "Name-1953", "Specification-1953", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1954, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1084), true, "Remark-1954", "Code-1954", "Model-1954", "Name-1954", "Specification-1954", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1955, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1087), true, "Remark-1955", "Code-1955", "Model-1955", "Name-1955", "Specification-1955", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1956, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1089), true, "Remark-1956", "Code-1956", "Model-1956", "Name-1956", "Specification-1956", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1957, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1092), true, "Remark-1957", "Code-1957", "Model-1957", "Name-1957", "Specification-1957", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1958, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1095), true, "Remark-1958", "Code-1958", "Model-1958", "Name-1958", "Specification-1958", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1959, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1098), true, "Remark-1959", "Code-1959", "Model-1959", "Name-1959", "Specification-1959", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1960, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1100), true, "Remark-1960", "Code-1960", "Model-1960", "Name-1960", "Specification-1960", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1961, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1103), true, "Remark-1961", "Code-1961", "Model-1961", "Name-1961", "Specification-1961", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1962, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1106), true, "Remark-1962", "Code-1962", "Model-1962", "Name-1962", "Specification-1962", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1963, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1108), true, "Remark-1963", "Code-1963", "Model-1963", "Name-1963", "Specification-1963", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1964, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1111), true, "Remark-1964", "Code-1964", "Model-1964", "Name-1964", "Specification-1964", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1965, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1114), true, "Remark-1965", "Code-1965", "Model-1965", "Name-1965", "Specification-1965", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1966, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1116), true, "Remark-1966", "Code-1966", "Model-1966", "Name-1966", "Specification-1966", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1967, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1119), true, "Remark-1967", "Code-1967", "Model-1967", "Name-1967", "Specification-1967", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1968, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1122), true, "Remark-1968", "Code-1968", "Model-1968", "Name-1968", "Specification-1968", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1969, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1124), true, "Remark-1969", "Code-1969", "Model-1969", "Name-1969", "Specification-1969", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1970, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1127), true, "Remark-1970", "Code-1970", "Model-1970", "Name-1970", "Specification-1970", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1971, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1130), true, "Remark-1971", "Code-1971", "Model-1971", "Name-1971", "Specification-1971", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1972, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1133), true, "Remark-1972", "Code-1972", "Model-1972", "Name-1972", "Specification-1972", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1973, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1138), true, "Remark-1973", "Code-1973", "Model-1973", "Name-1973", "Specification-1973", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1974, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1141), true, "Remark-1974", "Code-1974", "Model-1974", "Name-1974", "Specification-1974", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1975, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1145), true, "Remark-1975", "Code-1975", "Model-1975", "Name-1975", "Specification-1975", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1976, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1147), true, "Remark-1976", "Code-1976", "Model-1976", "Name-1976", "Specification-1976", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1977, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1150), true, "Remark-1977", "Code-1977", "Model-1977", "Name-1977", "Specification-1977", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1978, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1153), true, "Remark-1978", "Code-1978", "Model-1978", "Name-1978", "Specification-1978", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1979, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1156), true, "Remark-1979", "Code-1979", "Model-1979", "Name-1979", "Specification-1979", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1980, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1158), true, "Remark-1980", "Code-1980", "Model-1980", "Name-1980", "Specification-1980", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1981, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1161), true, "Remark-1981", "Code-1981", "Model-1981", "Name-1981", "Specification-1981", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1982, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1164), true, "Remark-1982", "Code-1982", "Model-1982", "Name-1982", "Specification-1982", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1983, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1166), true, "Remark-1983", "Code-1983", "Model-1983", "Name-1983", "Specification-1983", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1984, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1169), true, "Remark-1984", "Code-1984", "Model-1984", "Name-1984", "Specification-1984", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1985, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1172), true, "Remark-1985", "Code-1985", "Model-1985", "Name-1985", "Specification-1985", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1986, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1174), true, "Remark-1986", "Code-1986", "Model-1986", "Name-1986", "Specification-1986", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1987, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1177), true, "Remark-1987", "Code-1987", "Model-1987", "Name-1987", "Specification-1987", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1988, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1180), true, "Remark-1988", "Code-1988", "Model-1988", "Name-1988", "Specification-1988", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1989, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1182), true, "Remark-1989", "Code-1989", "Model-1989", "Name-1989", "Specification-1989", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1990, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1185), true, "Remark-1990", "Code-1990", "Model-1990", "Name-1990", "Specification-1990", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1991, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1188), true, "Remark-1991", "Code-1991", "Model-1991", "Name-1991", "Specification-1991", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1992, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1190), true, "Remark-1992", "Code-1992", "Model-1992", "Name-1992", "Specification-1992", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1993, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1196), true, "Remark-1993", "Code-1993", "Model-1993", "Name-1993", "Specification-1993", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1994, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1199), true, "Remark-1994", "Code-1994", "Model-1994", "Name-1994", "Specification-1994", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1995, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1202), true, "Remark-1995", "Code-1995", "Model-1995", "Name-1995", "Specification-1995", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1996, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1204), true, "Remark-1996", "Code-1996", "Model-1996", "Name-1996", "Specification-1996", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1997, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1207), true, "Remark-1997", "Code-1997", "Model-1997", "Name-1997", "Specification-1997", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1998, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1209), true, "Remark-1998", "Code-1998", "Model-1998", "Name-1998", "Specification-1998", null });

            migrationBuilder.InsertData(
                table: "StorageRacks",
                columns: new[] { "StorageRackId", "CreateTime", "IsAvailable", "Remark", "StorageRackCode", "StorageRackModel", "StorageRackName", "StorageRackSpecification", "UpdateTime" },
                values: new object[] { 1999, new DateTime(2022, 4, 13, 2, 30, 35, 303, DateTimeKind.Utc).AddTicks(1212), true, "Remark-1999", "Code-1999", "Model-1999", "Name-1999", "Specification-1999", null });

            migrationBuilder.CreateIndex(
                name: "IX_CargoSpaces_StorageRackId_CargoSpaceCode",
                table: "CargoSpaces",
                columns: new[] { "StorageRackId", "CargoSpaceCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialCode",
                table: "Materials",
                column: "MaterialCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StorageRacks_StorageRackCode",
                table: "StorageRacks",
                column: "StorageRackCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoSpaces");

            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.DropTable(
                name: "StorageRacks");

            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
