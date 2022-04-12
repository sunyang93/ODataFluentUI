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

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1000, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(818), true, 1, "Code-1000", "Model-1000", "Name-1000", "Spec-1000", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1001, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(908), false, 1, "Code-1001", "Model-1001", "Name-1001", "Spec-1001", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1002, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(924), true, 2, "Code-1002", "Model-1002", "Name-1002", "Spec-1002", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1003, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(929), false, 2, "Code-1003", "Model-1003", "Name-1003", "Spec-1003", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1004, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(936), true, 1, "Code-1004", "Model-1004", "Name-1004", "Spec-1004", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1005, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(945), false, 1, "Code-1005", "Model-1005", "Name-1005", "Spec-1005", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1006, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(951), true, 2, "Code-1006", "Model-1006", "Name-1006", "Spec-1006", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1007, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(957), false, 2, "Code-1007", "Model-1007", "Name-1007", "Spec-1007", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1008, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(963), true, 2, "Code-1008", "Model-1008", "Name-1008", "Spec-1008", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1009, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(969), false, 2, "Code-1009", "Model-1009", "Name-1009", "Spec-1009", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1010, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(975), true, 2, "Code-1010", "Model-1010", "Name-1010", "Spec-1010", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1011, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(980), false, 1, "Code-1011", "Model-1011", "Name-1011", "Spec-1011", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1012, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1026), true, 1, "Code-1012", "Model-1012", "Name-1012", "Spec-1012", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1013, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1032), false, 2, "Code-1013", "Model-1013", "Name-1013", "Spec-1013", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1014, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1039), true, 1, "Code-1014", "Model-1014", "Name-1014", "Spec-1014", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1015, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1043), false, 1, "Code-1015", "Model-1015", "Name-1015", "Spec-1015", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1016, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1049), true, 2, "Code-1016", "Model-1016", "Name-1016", "Spec-1016", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1017, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1055), false, 1, "Code-1017", "Model-1017", "Name-1017", "Spec-1017", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1018, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1062), true, 1, "Code-1018", "Model-1018", "Name-1018", "Spec-1018", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1019, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1067), false, 2, "Code-1019", "Model-1019", "Name-1019", "Spec-1019", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1020, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1073), true, 1, "Code-1020", "Model-1020", "Name-1020", "Spec-1020", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1021, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1077), false, 2, "Code-1021", "Model-1021", "Name-1021", "Spec-1021", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1022, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1084), true, 2, "Code-1022", "Model-1022", "Name-1022", "Spec-1022", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1023, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1089), false, 2, "Code-1023", "Model-1023", "Name-1023", "Spec-1023", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1024, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1095), true, 2, "Code-1024", "Model-1024", "Name-1024", "Spec-1024", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1025, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1099), false, 1, "Code-1025", "Model-1025", "Name-1025", "Spec-1025", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1026, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1105), true, 1, "Code-1026", "Model-1026", "Name-1026", "Spec-1026", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1027, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1110), false, 1, "Code-1027", "Model-1027", "Name-1027", "Spec-1027", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1028, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1116), true, 2, "Code-1028", "Model-1028", "Name-1028", "Spec-1028", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1029, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1120), false, 2, "Code-1029", "Model-1029", "Name-1029", "Spec-1029", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1030, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1126), true, 2, "Code-1030", "Model-1030", "Name-1030", "Spec-1030", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1031, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1131), false, 1, "Code-1031", "Model-1031", "Name-1031", "Spec-1031", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1032, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1176), true, 1, "Code-1032", "Model-1032", "Name-1032", "Spec-1032", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1033, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1183), false, 2, "Code-1033", "Model-1033", "Name-1033", "Spec-1033", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1034, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1190), true, 1, "Code-1034", "Model-1034", "Name-1034", "Spec-1034", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1035, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1195), false, 2, "Code-1035", "Model-1035", "Name-1035", "Spec-1035", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1036, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1201), true, 2, "Code-1036", "Model-1036", "Name-1036", "Spec-1036", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1037, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1206), false, 2, "Code-1037", "Model-1037", "Name-1037", "Spec-1037", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1038, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1212), true, 2, "Code-1038", "Model-1038", "Name-1038", "Spec-1038", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1039, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1217), false, 2, "Code-1039", "Model-1039", "Name-1039", "Spec-1039", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1040, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1223), true, 1, "Code-1040", "Model-1040", "Name-1040", "Spec-1040", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1041, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1228), false, 2, "Code-1041", "Model-1041", "Name-1041", "Spec-1041", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1042, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1235), true, 2, "Code-1042", "Model-1042", "Name-1042", "Spec-1042", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1043, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1239), false, 2, "Code-1043", "Model-1043", "Name-1043", "Spec-1043", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1044, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1245), true, 1, "Code-1044", "Model-1044", "Name-1044", "Spec-1044", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1045, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1249), false, 2, "Code-1045", "Model-1045", "Name-1045", "Spec-1045", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1046, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1256), true, 2, "Code-1046", "Model-1046", "Name-1046", "Spec-1046", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1047, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1261), false, 2, "Code-1047", "Model-1047", "Name-1047", "Spec-1047", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1048, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1267), true, 1, "Code-1048", "Model-1048", "Name-1048", "Spec-1048", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1049, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1272), false, 2, "Code-1049", "Model-1049", "Name-1049", "Spec-1049", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1050, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1278), true, 2, "Code-1050", "Model-1050", "Name-1050", "Spec-1050", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1051, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1348), false, 2, "Code-1051", "Model-1051", "Name-1051", "Spec-1051", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1052, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1355), true, 1, "Code-1052", "Model-1052", "Name-1052", "Spec-1052", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1053, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1360), false, 1, "Code-1053", "Model-1053", "Name-1053", "Spec-1053", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1054, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1366), true, 2, "Code-1054", "Model-1054", "Name-1054", "Spec-1054", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1055, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1371), false, 2, "Code-1055", "Model-1055", "Name-1055", "Spec-1055", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1056, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1377), true, 2, "Code-1056", "Model-1056", "Name-1056", "Spec-1056", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1057, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1381), false, 1, "Code-1057", "Model-1057", "Name-1057", "Spec-1057", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1058, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1388), true, 1, "Code-1058", "Model-1058", "Name-1058", "Spec-1058", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1059, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1392), false, 2, "Code-1059", "Model-1059", "Name-1059", "Spec-1059", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1060, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1398), true, 1, "Code-1060", "Model-1060", "Name-1060", "Spec-1060", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1061, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1402), false, 1, "Code-1061", "Model-1061", "Name-1061", "Spec-1061", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1062, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1409), true, 1, "Code-1062", "Model-1062", "Name-1062", "Spec-1062", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1063, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1414), false, 2, "Code-1063", "Model-1063", "Name-1063", "Spec-1063", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1064, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1422), true, 1, "Code-1064", "Model-1064", "Name-1064", "Spec-1064", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1065, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1431), false, 2, "Code-1065", "Model-1065", "Name-1065", "Spec-1065", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1066, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1438), true, 1, "Code-1066", "Model-1066", "Name-1066", "Spec-1066", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1067, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1443), false, 2, "Code-1067", "Model-1067", "Name-1067", "Spec-1067", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1068, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1449), true, 2, "Code-1068", "Model-1068", "Name-1068", "Spec-1068", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1069, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1490), false, 2, "Code-1069", "Model-1069", "Name-1069", "Spec-1069", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1070, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1498), true, 2, "Code-1070", "Model-1070", "Name-1070", "Spec-1070", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1071, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1502), false, 1, "Code-1071", "Model-1071", "Name-1071", "Spec-1071", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1072, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1508), true, 2, "Code-1072", "Model-1072", "Name-1072", "Spec-1072", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1073, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1513), false, 2, "Code-1073", "Model-1073", "Name-1073", "Spec-1073", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1074, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1519), true, 2, "Code-1074", "Model-1074", "Name-1074", "Spec-1074", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1075, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1524), false, 2, "Code-1075", "Model-1075", "Name-1075", "Spec-1075", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1076, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1530), true, 2, "Code-1076", "Model-1076", "Name-1076", "Spec-1076", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1077, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1535), false, 1, "Code-1077", "Model-1077", "Name-1077", "Spec-1077", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1078, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1541), true, 1, "Code-1078", "Model-1078", "Name-1078", "Spec-1078", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1079, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1546), false, 2, "Code-1079", "Model-1079", "Name-1079", "Spec-1079", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1080, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1552), true, 1, "Code-1080", "Model-1080", "Name-1080", "Spec-1080", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1081, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1556), false, 1, "Code-1081", "Model-1081", "Name-1081", "Spec-1081", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1082, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1562), true, 1, "Code-1082", "Model-1082", "Name-1082", "Spec-1082", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1083, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1566), false, 1, "Code-1083", "Model-1083", "Name-1083", "Spec-1083", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1084, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1573), true, 1, "Code-1084", "Model-1084", "Name-1084", "Spec-1084", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1085, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1577), false, 2, "Code-1085", "Model-1085", "Name-1085", "Spec-1085", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1086, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1583), true, 2, "Code-1086", "Model-1086", "Name-1086", "Spec-1086", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1087, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1588), false, 2, "Code-1087", "Model-1087", "Name-1087", "Spec-1087", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1088, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1594), true, 1, "Code-1088", "Model-1088", "Name-1088", "Spec-1088", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1089, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1634), false, 2, "Code-1089", "Model-1089", "Name-1089", "Spec-1089", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1090, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1641), true, 1, "Code-1090", "Model-1090", "Name-1090", "Spec-1090", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1091, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1647), false, 1, "Code-1091", "Model-1091", "Name-1091", "Spec-1091", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1092, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1653), true, 2, "Code-1092", "Model-1092", "Name-1092", "Spec-1092", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1093, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1657), false, 2, "Code-1093", "Model-1093", "Name-1093", "Spec-1093", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1094, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1665), true, 2, "Code-1094", "Model-1094", "Name-1094", "Spec-1094", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1095, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1669), false, 2, "Code-1095", "Model-1095", "Name-1095", "Spec-1095", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1096, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1675), true, 2, "Code-1096", "Model-1096", "Name-1096", "Spec-1096", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1097, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1680), false, 1, "Code-1097", "Model-1097", "Name-1097", "Spec-1097", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1098, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1686), true, 2, "Code-1098", "Model-1098", "Name-1098", "Spec-1098", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1099, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1690), false, 1, "Code-1099", "Model-1099", "Name-1099", "Spec-1099", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1100, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1698), true, 1, "Code-1100", "Model-1100", "Name-1100", "Spec-1100", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1101, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1702), false, 1, "Code-1101", "Model-1101", "Name-1101", "Spec-1101", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1102, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1708), true, 1, "Code-1102", "Model-1102", "Name-1102", "Spec-1102", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1103, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1713), false, 2, "Code-1103", "Model-1103", "Name-1103", "Spec-1103", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1104, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1719), true, 1, "Code-1104", "Model-1104", "Name-1104", "Spec-1104", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1105, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1723), false, 1, "Code-1105", "Model-1105", "Name-1105", "Spec-1105", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1106, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1730), true, 1, "Code-1106", "Model-1106", "Name-1106", "Spec-1106", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1107, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1734), false, 1, "Code-1107", "Model-1107", "Name-1107", "Spec-1107", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1108, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1741), true, 1, "Code-1108", "Model-1108", "Name-1108", "Spec-1108", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1109, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1745), false, 2, "Code-1109", "Model-1109", "Name-1109", "Spec-1109", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1110, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1794), true, 2, "Code-1110", "Model-1110", "Name-1110", "Spec-1110", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1111, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1799), false, 1, "Code-1111", "Model-1111", "Name-1111", "Spec-1111", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1112, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1805), true, 1, "Code-1112", "Model-1112", "Name-1112", "Spec-1112", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1113, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1810), false, 1, "Code-1113", "Model-1113", "Name-1113", "Spec-1113", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1114, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1816), true, 2, "Code-1114", "Model-1114", "Name-1114", "Spec-1114", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1115, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1820), false, 1, "Code-1115", "Model-1115", "Name-1115", "Spec-1115", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1116, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1826), true, 2, "Code-1116", "Model-1116", "Name-1116", "Spec-1116", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1117, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1831), false, 1, "Code-1117", "Model-1117", "Name-1117", "Spec-1117", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1118, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1837), true, 1, "Code-1118", "Model-1118", "Name-1118", "Spec-1118", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1119, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1841), false, 2, "Code-1119", "Model-1119", "Name-1119", "Spec-1119", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1120, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1849), true, 1, "Code-1120", "Model-1120", "Name-1120", "Spec-1120", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1121, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1853), false, 1, "Code-1121", "Model-1121", "Name-1121", "Spec-1121", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1122, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1859), true, 1, "Code-1122", "Model-1122", "Name-1122", "Spec-1122", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1123, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1864), false, 2, "Code-1123", "Model-1123", "Name-1123", "Spec-1123", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1124, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1870), true, 2, "Code-1124", "Model-1124", "Name-1124", "Spec-1124", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1125, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1874), false, 2, "Code-1125", "Model-1125", "Name-1125", "Spec-1125", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1126, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1881), true, 2, "Code-1126", "Model-1126", "Name-1126", "Spec-1126", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1127, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1885), false, 2, "Code-1127", "Model-1127", "Name-1127", "Spec-1127", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1128, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1891), true, 1, "Code-1128", "Model-1128", "Name-1128", "Spec-1128", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1129, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1933), false, 1, "Code-1129", "Model-1129", "Name-1129", "Spec-1129", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1130, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1940), true, 2, "Code-1130", "Model-1130", "Name-1130", "Spec-1130", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1131, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1944), false, 1, "Code-1131", "Model-1131", "Name-1131", "Spec-1131", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1132, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1951), true, 1, "Code-1132", "Model-1132", "Name-1132", "Spec-1132", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1133, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1955), false, 2, "Code-1133", "Model-1133", "Name-1133", "Spec-1133", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1134, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1961), true, 1, "Code-1134", "Model-1134", "Name-1134", "Spec-1134", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1135, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1966), false, 2, "Code-1135", "Model-1135", "Name-1135", "Spec-1135", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1136, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1972), true, 2, "Code-1136", "Model-1136", "Name-1136", "Spec-1136", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1137, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1976), false, 1, "Code-1137", "Model-1137", "Name-1137", "Spec-1137", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1138, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1983), true, 1, "Code-1138", "Model-1138", "Name-1138", "Spec-1138", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1139, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1987), false, 2, "Code-1139", "Model-1139", "Name-1139", "Spec-1139", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1140, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1993), true, 1, "Code-1140", "Model-1140", "Name-1140", "Spec-1140", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1141, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(1997), false, 2, "Code-1141", "Model-1141", "Name-1141", "Spec-1141", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1142, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2004), true, 2, "Code-1142", "Model-1142", "Name-1142", "Spec-1142", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1143, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2008), false, 2, "Code-1143", "Model-1143", "Name-1143", "Spec-1143", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1144, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2014), true, 2, "Code-1144", "Model-1144", "Name-1144", "Spec-1144", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1145, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2019), false, 1, "Code-1145", "Model-1145", "Name-1145", "Spec-1145", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1146, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2063), true, 1, "Code-1146", "Model-1146", "Name-1146", "Spec-1146", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1147, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2068), false, 1, "Code-1147", "Model-1147", "Name-1147", "Spec-1147", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1148, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2074), true, 1, "Code-1148", "Model-1148", "Name-1148", "Spec-1148", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1149, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2078), false, 2, "Code-1149", "Model-1149", "Name-1149", "Spec-1149", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1150, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2085), true, 2, "Code-1150", "Model-1150", "Name-1150", "Spec-1150", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1151, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2089), false, 1, "Code-1151", "Model-1151", "Name-1151", "Spec-1151", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1152, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2096), true, 1, "Code-1152", "Model-1152", "Name-1152", "Spec-1152", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1153, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2101), false, 2, "Code-1153", "Model-1153", "Name-1153", "Spec-1153", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1154, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2107), true, 1, "Code-1154", "Model-1154", "Name-1154", "Spec-1154", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1155, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2111), false, 2, "Code-1155", "Model-1155", "Name-1155", "Spec-1155", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1156, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2117), true, 1, "Code-1156", "Model-1156", "Name-1156", "Spec-1156", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1157, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2122), false, 2, "Code-1157", "Model-1157", "Name-1157", "Spec-1157", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1158, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2128), true, 1, "Code-1158", "Model-1158", "Name-1158", "Spec-1158", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1159, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2132), false, 2, "Code-1159", "Model-1159", "Name-1159", "Spec-1159", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1160, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2138), true, 2, "Code-1160", "Model-1160", "Name-1160", "Spec-1160", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1161, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2143), false, 2, "Code-1161", "Model-1161", "Name-1161", "Spec-1161", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1162, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2149), true, 1, "Code-1162", "Model-1162", "Name-1162", "Spec-1162", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1163, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2154), false, 2, "Code-1163", "Model-1163", "Name-1163", "Spec-1163", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1164, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2160), true, 2, "Code-1164", "Model-1164", "Name-1164", "Spec-1164", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1165, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2164), false, 1, "Code-1165", "Model-1165", "Name-1165", "Spec-1165", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1166, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2209), true, 1, "Code-1166", "Model-1166", "Name-1166", "Spec-1166", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1167, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2214), false, 2, "Code-1167", "Model-1167", "Name-1167", "Spec-1167", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1168, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2221), true, 2, "Code-1168", "Model-1168", "Name-1168", "Spec-1168", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1169, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2226), false, 1, "Code-1169", "Model-1169", "Name-1169", "Spec-1169", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1170, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2232), true, 2, "Code-1170", "Model-1170", "Name-1170", "Spec-1170", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1171, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2237), false, 1, "Code-1171", "Model-1171", "Name-1171", "Spec-1171", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1172, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2243), true, 1, "Code-1172", "Model-1172", "Name-1172", "Spec-1172", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1173, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2247), false, 1, "Code-1173", "Model-1173", "Name-1173", "Spec-1173", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1174, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2253), true, 2, "Code-1174", "Model-1174", "Name-1174", "Spec-1174", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1175, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2257), false, 2, "Code-1175", "Model-1175", "Name-1175", "Spec-1175", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1176, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2264), true, 1, "Code-1176", "Model-1176", "Name-1176", "Spec-1176", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1177, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2268), false, 2, "Code-1177", "Model-1177", "Name-1177", "Spec-1177", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1178, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2274), true, 1, "Code-1178", "Model-1178", "Name-1178", "Spec-1178", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1179, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2279), false, 1, "Code-1179", "Model-1179", "Name-1179", "Spec-1179", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1180, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2285), true, 1, "Code-1180", "Model-1180", "Name-1180", "Spec-1180", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1181, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2289), false, 2, "Code-1181", "Model-1181", "Name-1181", "Spec-1181", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1182, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2295), true, 1, "Code-1182", "Model-1182", "Name-1182", "Spec-1182", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1183, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2299), false, 1, "Code-1183", "Model-1183", "Name-1183", "Spec-1183", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1184, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2305), true, 1, "Code-1184", "Model-1184", "Name-1184", "Spec-1184", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1185, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2310), false, 1, "Code-1185", "Model-1185", "Name-1185", "Spec-1185", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1186, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2351), true, 1, "Code-1186", "Model-1186", "Name-1186", "Spec-1186", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1187, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2358), false, 1, "Code-1187", "Model-1187", "Name-1187", "Spec-1187", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1188, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2365), true, 1, "Code-1188", "Model-1188", "Name-1188", "Spec-1188", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1189, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2369), false, 1, "Code-1189", "Model-1189", "Name-1189", "Spec-1189", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1190, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2375), true, 2, "Code-1190", "Model-1190", "Name-1190", "Spec-1190", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1191, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2380), false, 1, "Code-1191", "Model-1191", "Name-1191", "Spec-1191", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1192, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2386), true, 2, "Code-1192", "Model-1192", "Name-1192", "Spec-1192", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1193, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2390), false, 2, "Code-1193", "Model-1193", "Name-1193", "Spec-1193", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1194, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2396), true, 2, "Code-1194", "Model-1194", "Name-1194", "Spec-1194", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1195, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2400), false, 1, "Code-1195", "Model-1195", "Name-1195", "Spec-1195", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1196, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2407), true, 1, "Code-1196", "Model-1196", "Name-1196", "Spec-1196", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1197, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2411), false, 1, "Code-1197", "Model-1197", "Name-1197", "Spec-1197", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1198, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2417), true, 1, "Code-1198", "Model-1198", "Name-1198", "Spec-1198", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1199, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2422), false, 2, "Code-1199", "Model-1199", "Name-1199", "Spec-1199", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1200, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2428), true, 2, "Code-1200", "Model-1200", "Name-1200", "Spec-1200", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1201, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2432), false, 1, "Code-1201", "Model-1201", "Name-1201", "Spec-1201", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1202, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2439), true, 1, "Code-1202", "Model-1202", "Name-1202", "Spec-1202", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1203, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2444), false, 1, "Code-1203", "Model-1203", "Name-1203", "Spec-1203", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1204, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2450), true, 2, "Code-1204", "Model-1204", "Name-1204", "Spec-1204", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1205, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2454), false, 1, "Code-1205", "Model-1205", "Name-1205", "Spec-1205", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1206, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2461), true, 2, "Code-1206", "Model-1206", "Name-1206", "Spec-1206", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1207, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2517), false, 2, "Code-1207", "Model-1207", "Name-1207", "Spec-1207", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1208, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2523), true, 2, "Code-1208", "Model-1208", "Name-1208", "Spec-1208", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1209, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2528), false, 1, "Code-1209", "Model-1209", "Name-1209", "Spec-1209", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1210, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2534), true, 2, "Code-1210", "Model-1210", "Name-1210", "Spec-1210", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1211, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2539), false, 1, "Code-1211", "Model-1211", "Name-1211", "Spec-1211", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1212, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2545), true, 2, "Code-1212", "Model-1212", "Name-1212", "Spec-1212", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1213, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2550), false, 2, "Code-1213", "Model-1213", "Name-1213", "Spec-1213", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1214, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2556), true, 1, "Code-1214", "Model-1214", "Name-1214", "Spec-1214", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1215, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2560), false, 2, "Code-1215", "Model-1215", "Name-1215", "Spec-1215", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1216, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2566), true, 1, "Code-1216", "Model-1216", "Name-1216", "Spec-1216", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1217, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2571), false, 1, "Code-1217", "Model-1217", "Name-1217", "Spec-1217", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1218, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2578), true, 2, "Code-1218", "Model-1218", "Name-1218", "Spec-1218", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1219, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2583), false, 1, "Code-1219", "Model-1219", "Name-1219", "Spec-1219", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1220, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2589), true, 1, "Code-1220", "Model-1220", "Name-1220", "Spec-1220", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1221, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2593), false, 1, "Code-1221", "Model-1221", "Name-1221", "Spec-1221", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1222, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2599), true, 1, "Code-1222", "Model-1222", "Name-1222", "Spec-1222", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1223, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2604), false, 1, "Code-1223", "Model-1223", "Name-1223", "Spec-1223", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1224, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2610), true, 1, "Code-1224", "Model-1224", "Name-1224", "Spec-1224", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1225, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2614), false, 2, "Code-1225", "Model-1225", "Name-1225", "Spec-1225", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1226, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2621), true, 2, "Code-1226", "Model-1226", "Name-1226", "Spec-1226", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1227, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2663), false, 1, "Code-1227", "Model-1227", "Name-1227", "Spec-1227", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1228, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2669), true, 1, "Code-1228", "Model-1228", "Name-1228", "Spec-1228", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1229, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2674), false, 2, "Code-1229", "Model-1229", "Name-1229", "Spec-1229", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1230, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2680), true, 1, "Code-1230", "Model-1230", "Name-1230", "Spec-1230", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1231, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2685), false, 1, "Code-1231", "Model-1231", "Name-1231", "Spec-1231", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1232, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2691), true, 2, "Code-1232", "Model-1232", "Name-1232", "Spec-1232", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1233, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2695), false, 2, "Code-1233", "Model-1233", "Name-1233", "Spec-1233", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1234, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2701), true, 2, "Code-1234", "Model-1234", "Name-1234", "Spec-1234", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1235, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2705), false, 1, "Code-1235", "Model-1235", "Name-1235", "Spec-1235", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1236, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2712), true, 1, "Code-1236", "Model-1236", "Name-1236", "Spec-1236", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1237, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2717), false, 1, "Code-1237", "Model-1237", "Name-1237", "Spec-1237", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1238, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2723), true, 1, "Code-1238", "Model-1238", "Name-1238", "Spec-1238", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1239, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2727), false, 1, "Code-1239", "Model-1239", "Name-1239", "Spec-1239", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1240, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2733), true, 1, "Code-1240", "Model-1240", "Name-1240", "Spec-1240", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1241, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2737), false, 1, "Code-1241", "Model-1241", "Name-1241", "Spec-1241", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1242, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2743), true, 2, "Code-1242", "Model-1242", "Name-1242", "Spec-1242", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1243, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2748), false, 2, "Code-1243", "Model-1243", "Name-1243", "Spec-1243", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1244, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2754), true, 2, "Code-1244", "Model-1244", "Name-1244", "Spec-1244", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1245, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2759), false, 2, "Code-1245", "Model-1245", "Name-1245", "Spec-1245", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1246, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2765), true, 1, "Code-1246", "Model-1246", "Name-1246", "Spec-1246", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1247, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2769), false, 2, "Code-1247", "Model-1247", "Name-1247", "Spec-1247", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1248, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2818), true, 1, "Code-1248", "Model-1248", "Name-1248", "Spec-1248", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1249, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2823), false, 2, "Code-1249", "Model-1249", "Name-1249", "Spec-1249", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1250, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2829), true, 2, "Code-1250", "Model-1250", "Name-1250", "Spec-1250", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1251, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2833), false, 1, "Code-1251", "Model-1251", "Name-1251", "Spec-1251", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1252, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2839), true, 1, "Code-1252", "Model-1252", "Name-1252", "Spec-1252", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1253, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2844), false, 2, "Code-1253", "Model-1253", "Name-1253", "Spec-1253", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1254, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2850), true, 1, "Code-1254", "Model-1254", "Name-1254", "Spec-1254", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1255, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2854), false, 1, "Code-1255", "Model-1255", "Name-1255", "Spec-1255", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1256, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2860), true, 1, "Code-1256", "Model-1256", "Name-1256", "Spec-1256", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1257, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2870), false, 1, "Code-1257", "Model-1257", "Name-1257", "Spec-1257", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1258, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2972), true, 2, "Code-1258", "Model-1258", "Name-1258", "Spec-1258", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1259, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2977), false, 1, "Code-1259", "Model-1259", "Name-1259", "Spec-1259", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1260, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2985), true, 1, "Code-1260", "Model-1260", "Name-1260", "Spec-1260", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1261, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2989), false, 2, "Code-1261", "Model-1261", "Name-1261", "Spec-1261", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1262, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(2995), true, 2, "Code-1262", "Model-1262", "Name-1262", "Spec-1262", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1263, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3000), false, 1, "Code-1263", "Model-1263", "Name-1263", "Spec-1263", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1264, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3007), true, 1, "Code-1264", "Model-1264", "Name-1264", "Spec-1264", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1265, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3012), false, 2, "Code-1265", "Model-1265", "Name-1265", "Spec-1265", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1266, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3018), true, 2, "Code-1266", "Model-1266", "Name-1266", "Spec-1266", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1267, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3022), false, 2, "Code-1267", "Model-1267", "Name-1267", "Spec-1267", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1268, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3028), true, 1, "Code-1268", "Model-1268", "Name-1268", "Spec-1268", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1269, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3033), false, 1, "Code-1269", "Model-1269", "Name-1269", "Spec-1269", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1270, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3039), true, 1, "Code-1270", "Model-1270", "Name-1270", "Spec-1270", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1271, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3043), false, 1, "Code-1271", "Model-1271", "Name-1271", "Spec-1271", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1272, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3049), true, 1, "Code-1272", "Model-1272", "Name-1272", "Spec-1272", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1273, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3054), false, 1, "Code-1273", "Model-1273", "Name-1273", "Spec-1273", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1274, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3061), true, 2, "Code-1274", "Model-1274", "Name-1274", "Spec-1274", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1275, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3065), false, 1, "Code-1275", "Model-1275", "Name-1275", "Spec-1275", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1276, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3071), true, 1, "Code-1276", "Model-1276", "Name-1276", "Spec-1276", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1277, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3075), false, 1, "Code-1277", "Model-1277", "Name-1277", "Spec-1277", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1278, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3161), true, 2, "Code-1278", "Model-1278", "Name-1278", "Spec-1278", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1279, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3168), false, 2, "Code-1279", "Model-1279", "Name-1279", "Spec-1279", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1280, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3174), true, 2, "Code-1280", "Model-1280", "Name-1280", "Spec-1280", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1281, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3179), false, 2, "Code-1281", "Model-1281", "Name-1281", "Spec-1281", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1282, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3186), true, 1, "Code-1282", "Model-1282", "Name-1282", "Spec-1282", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1283, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3190), false, 2, "Code-1283", "Model-1283", "Name-1283", "Spec-1283", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1284, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3196), true, 1, "Code-1284", "Model-1284", "Name-1284", "Spec-1284", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1285, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3201), false, 1, "Code-1285", "Model-1285", "Name-1285", "Spec-1285", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1286, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3207), true, 2, "Code-1286", "Model-1286", "Name-1286", "Spec-1286", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1287, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3211), false, 2, "Code-1287", "Model-1287", "Name-1287", "Spec-1287", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1288, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3218), true, 1, "Code-1288", "Model-1288", "Name-1288", "Spec-1288", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1289, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3222), false, 1, "Code-1289", "Model-1289", "Name-1289", "Spec-1289", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1290, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3228), true, 2, "Code-1290", "Model-1290", "Name-1290", "Spec-1290", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1291, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3232), false, 1, "Code-1291", "Model-1291", "Name-1291", "Spec-1291", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1292, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3238), true, 2, "Code-1292", "Model-1292", "Name-1292", "Spec-1292", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1293, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3243), false, 1, "Code-1293", "Model-1293", "Name-1293", "Spec-1293", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1294, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3249), true, 2, "Code-1294", "Model-1294", "Name-1294", "Spec-1294", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1295, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3253), false, 1, "Code-1295", "Model-1295", "Name-1295", "Spec-1295", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1296, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3259), true, 1, "Code-1296", "Model-1296", "Name-1296", "Spec-1296", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1297, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3263), false, 1, "Code-1297", "Model-1297", "Name-1297", "Spec-1297", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1298, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3269), true, 1, "Code-1298", "Model-1298", "Name-1298", "Spec-1298", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1299, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3310), false, 1, "Code-1299", "Model-1299", "Name-1299", "Spec-1299", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1300, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3317), true, 1, "Code-1300", "Model-1300", "Name-1300", "Spec-1300", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1301, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3323), false, 1, "Code-1301", "Model-1301", "Name-1301", "Spec-1301", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1302, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3329), true, 1, "Code-1302", "Model-1302", "Name-1302", "Spec-1302", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1303, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3333), false, 2, "Code-1303", "Model-1303", "Name-1303", "Spec-1303", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1304, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3340), true, 2, "Code-1304", "Model-1304", "Name-1304", "Spec-1304", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1305, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3344), false, 1, "Code-1305", "Model-1305", "Name-1305", "Spec-1305", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1306, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3350), true, 2, "Code-1306", "Model-1306", "Name-1306", "Spec-1306", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1307, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3355), false, 2, "Code-1307", "Model-1307", "Name-1307", "Spec-1307", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1308, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3362), true, 2, "Code-1308", "Model-1308", "Name-1308", "Spec-1308", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1309, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3366), false, 2, "Code-1309", "Model-1309", "Name-1309", "Spec-1309", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1310, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3372), true, 2, "Code-1310", "Model-1310", "Name-1310", "Spec-1310", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1311, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3377), false, 2, "Code-1311", "Model-1311", "Name-1311", "Spec-1311", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1312, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3383), true, 2, "Code-1312", "Model-1312", "Name-1312", "Spec-1312", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1313, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3388), false, 2, "Code-1313", "Model-1313", "Name-1313", "Spec-1313", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1314, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3394), true, 1, "Code-1314", "Model-1314", "Name-1314", "Spec-1314", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1315, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3398), false, 1, "Code-1315", "Model-1315", "Name-1315", "Spec-1315", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1316, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3404), true, 1, "Code-1316", "Model-1316", "Name-1316", "Spec-1316", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1317, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3408), false, 2, "Code-1317", "Model-1317", "Name-1317", "Spec-1317", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1318, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3414), true, 1, "Code-1318", "Model-1318", "Name-1318", "Spec-1318", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1319, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3457), false, 2, "Code-1319", "Model-1319", "Name-1319", "Spec-1319", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1320, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3464), true, 1, "Code-1320", "Model-1320", "Name-1320", "Spec-1320", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1321, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3468), false, 2, "Code-1321", "Model-1321", "Name-1321", "Spec-1321", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1322, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3474), true, 2, "Code-1322", "Model-1322", "Name-1322", "Spec-1322", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1323, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3479), false, 1, "Code-1323", "Model-1323", "Name-1323", "Spec-1323", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1324, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3485), true, 1, "Code-1324", "Model-1324", "Name-1324", "Spec-1324", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1325, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3489), false, 1, "Code-1325", "Model-1325", "Name-1325", "Spec-1325", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1326, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3496), true, 1, "Code-1326", "Model-1326", "Name-1326", "Spec-1326", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1327, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3500), false, 2, "Code-1327", "Model-1327", "Name-1327", "Spec-1327", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1328, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3506), true, 1, "Code-1328", "Model-1328", "Name-1328", "Spec-1328", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1329, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3512), false, 1, "Code-1329", "Model-1329", "Name-1329", "Spec-1329", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1330, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3518), true, 1, "Code-1330", "Model-1330", "Name-1330", "Spec-1330", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1331, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3522), false, 1, "Code-1331", "Model-1331", "Name-1331", "Spec-1331", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1332, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3528), true, 1, "Code-1332", "Model-1332", "Name-1332", "Spec-1332", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1333, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3533), false, 2, "Code-1333", "Model-1333", "Name-1333", "Spec-1333", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1334, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3541), true, 1, "Code-1334", "Model-1334", "Name-1334", "Spec-1334", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1335, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3545), false, 2, "Code-1335", "Model-1335", "Name-1335", "Spec-1335", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1336, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3551), true, 1, "Code-1336", "Model-1336", "Name-1336", "Spec-1336", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1337, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3556), false, 2, "Code-1337", "Model-1337", "Name-1337", "Spec-1337", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1338, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3562), true, 2, "Code-1338", "Model-1338", "Name-1338", "Spec-1338", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1339, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3602), false, 2, "Code-1339", "Model-1339", "Name-1339", "Spec-1339", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1340, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3610), true, 2, "Code-1340", "Model-1340", "Name-1340", "Spec-1340", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1341, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3614), false, 1, "Code-1341", "Model-1341", "Name-1341", "Spec-1341", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1342, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3620), true, 2, "Code-1342", "Model-1342", "Name-1342", "Spec-1342", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1343, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3625), false, 1, "Code-1343", "Model-1343", "Name-1343", "Spec-1343", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1344, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3631), true, 2, "Code-1344", "Model-1344", "Name-1344", "Spec-1344", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1345, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3636), false, 1, "Code-1345", "Model-1345", "Name-1345", "Spec-1345", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1346, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3642), true, 1, "Code-1346", "Model-1346", "Name-1346", "Spec-1346", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1347, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3646), false, 1, "Code-1347", "Model-1347", "Name-1347", "Spec-1347", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1348, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3652), true, 2, "Code-1348", "Model-1348", "Name-1348", "Spec-1348", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1349, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3657), false, 2, "Code-1349", "Model-1349", "Name-1349", "Spec-1349", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1350, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3663), true, 1, "Code-1350", "Model-1350", "Name-1350", "Spec-1350", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1351, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3667), false, 1, "Code-1351", "Model-1351", "Name-1351", "Spec-1351", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1352, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3673), true, 1, "Code-1352", "Model-1352", "Name-1352", "Spec-1352", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1353, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3678), false, 2, "Code-1353", "Model-1353", "Name-1353", "Spec-1353", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1354, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3684), true, 1, "Code-1354", "Model-1354", "Name-1354", "Spec-1354", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1355, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3689), false, 1, "Code-1355", "Model-1355", "Name-1355", "Spec-1355", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1356, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3696), true, 1, "Code-1356", "Model-1356", "Name-1356", "Spec-1356", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1357, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3700), false, 2, "Code-1357", "Model-1357", "Name-1357", "Spec-1357", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1358, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3706), true, 1, "Code-1358", "Model-1358", "Name-1358", "Spec-1358", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1359, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3711), false, 1, "Code-1359", "Model-1359", "Name-1359", "Spec-1359", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1360, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3753), true, 2, "Code-1360", "Model-1360", "Name-1360", "Spec-1360", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1361, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3758), false, 2, "Code-1361", "Model-1361", "Name-1361", "Spec-1361", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1362, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3765), true, 2, "Code-1362", "Model-1362", "Name-1362", "Spec-1362", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1363, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3769), false, 1, "Code-1363", "Model-1363", "Name-1363", "Spec-1363", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1364, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3775), true, 2, "Code-1364", "Model-1364", "Name-1364", "Spec-1364", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1365, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3780), false, 1, "Code-1365", "Model-1365", "Name-1365", "Spec-1365", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1366, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3786), true, 1, "Code-1366", "Model-1366", "Name-1366", "Spec-1366", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1367, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3791), false, 2, "Code-1367", "Model-1367", "Name-1367", "Spec-1367", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1368, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3797), true, 2, "Code-1368", "Model-1368", "Name-1368", "Spec-1368", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1369, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3801), false, 1, "Code-1369", "Model-1369", "Name-1369", "Spec-1369", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1370, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3808), true, 1, "Code-1370", "Model-1370", "Name-1370", "Spec-1370", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1371, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3812), false, 1, "Code-1371", "Model-1371", "Name-1371", "Spec-1371", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1372, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3818), true, 1, "Code-1372", "Model-1372", "Name-1372", "Spec-1372", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1373, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3823), false, 2, "Code-1373", "Model-1373", "Name-1373", "Spec-1373", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1374, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3829), true, 2, "Code-1374", "Model-1374", "Name-1374", "Spec-1374", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1375, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3834), false, 1, "Code-1375", "Model-1375", "Name-1375", "Spec-1375", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1376, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3840), true, 1, "Code-1376", "Model-1376", "Name-1376", "Spec-1376", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1377, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3844), false, 2, "Code-1377", "Model-1377", "Name-1377", "Spec-1377", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1378, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3851), true, 1, "Code-1378", "Model-1378", "Name-1378", "Spec-1378", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1379, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3856), false, 1, "Code-1379", "Model-1379", "Name-1379", "Spec-1379", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1380, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3927), true, 2, "Code-1380", "Model-1380", "Name-1380", "Spec-1380", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1381, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3932), false, 1, "Code-1381", "Model-1381", "Name-1381", "Spec-1381", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1382, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3939), true, 2, "Code-1382", "Model-1382", "Name-1382", "Spec-1382", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1383, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3943), false, 2, "Code-1383", "Model-1383", "Name-1383", "Spec-1383", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1384, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3950), true, 1, "Code-1384", "Model-1384", "Name-1384", "Spec-1384", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1385, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3954), false, 2, "Code-1385", "Model-1385", "Name-1385", "Spec-1385", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1386, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3960), true, 1, "Code-1386", "Model-1386", "Name-1386", "Spec-1386", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1387, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3965), false, 2, "Code-1387", "Model-1387", "Name-1387", "Spec-1387", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1388, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3971), true, 2, "Code-1388", "Model-1388", "Name-1388", "Spec-1388", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1389, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3976), false, 2, "Code-1389", "Model-1389", "Name-1389", "Spec-1389", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1390, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3982), true, 2, "Code-1390", "Model-1390", "Name-1390", "Spec-1390", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1391, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3987), false, 1, "Code-1391", "Model-1391", "Name-1391", "Spec-1391", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1392, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3994), true, 1, "Code-1392", "Model-1392", "Name-1392", "Spec-1392", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1393, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(3998), false, 2, "Code-1393", "Model-1393", "Name-1393", "Spec-1393", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1394, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4004), true, 2, "Code-1394", "Model-1394", "Name-1394", "Spec-1394", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1395, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4008), false, 1, "Code-1395", "Model-1395", "Name-1395", "Spec-1395", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1396, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4014), true, 2, "Code-1396", "Model-1396", "Name-1396", "Spec-1396", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1397, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4018), false, 1, "Code-1397", "Model-1397", "Name-1397", "Spec-1397", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1398, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4025), true, 2, "Code-1398", "Model-1398", "Name-1398", "Spec-1398", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1399, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4029), false, 2, "Code-1399", "Model-1399", "Name-1399", "Spec-1399", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1400, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4035), true, 2, "Code-1400", "Model-1400", "Name-1400", "Spec-1400", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1401, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4076), false, 1, "Code-1401", "Model-1401", "Name-1401", "Spec-1401", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1402, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4083), true, 2, "Code-1402", "Model-1402", "Name-1402", "Spec-1402", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1403, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4087), false, 2, "Code-1403", "Model-1403", "Name-1403", "Spec-1403", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1404, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4094), true, 2, "Code-1404", "Model-1404", "Name-1404", "Spec-1404", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1405, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4099), false, 2, "Code-1405", "Model-1405", "Name-1405", "Spec-1405", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1406, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4105), true, 2, "Code-1406", "Model-1406", "Name-1406", "Spec-1406", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1407, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4109), false, 2, "Code-1407", "Model-1407", "Name-1407", "Spec-1407", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1408, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4115), true, 1, "Code-1408", "Model-1408", "Name-1408", "Spec-1408", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1409, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4120), false, 1, "Code-1409", "Model-1409", "Name-1409", "Spec-1409", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1410, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4126), true, 2, "Code-1410", "Model-1410", "Name-1410", "Spec-1410", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1411, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4131), false, 2, "Code-1411", "Model-1411", "Name-1411", "Spec-1411", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1412, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4137), true, 2, "Code-1412", "Model-1412", "Name-1412", "Spec-1412", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1413, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4141), false, 1, "Code-1413", "Model-1413", "Name-1413", "Spec-1413", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1414, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4147), true, 1, "Code-1414", "Model-1414", "Name-1414", "Spec-1414", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1415, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4151), false, 2, "Code-1415", "Model-1415", "Name-1415", "Spec-1415", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1416, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4157), true, 1, "Code-1416", "Model-1416", "Name-1416", "Spec-1416", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1417, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4162), false, 2, "Code-1417", "Model-1417", "Name-1417", "Spec-1417", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1418, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4169), true, 2, "Code-1418", "Model-1418", "Name-1418", "Spec-1418", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1419, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4173), false, 2, "Code-1419", "Model-1419", "Name-1419", "Spec-1419", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1420, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4180), true, 1, "Code-1420", "Model-1420", "Name-1420", "Spec-1420", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1421, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4219), false, 1, "Code-1421", "Model-1421", "Name-1421", "Spec-1421", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1422, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4226), true, 2, "Code-1422", "Model-1422", "Name-1422", "Spec-1422", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1423, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4230), false, 1, "Code-1423", "Model-1423", "Name-1423", "Spec-1423", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1424, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4236), true, 1, "Code-1424", "Model-1424", "Name-1424", "Spec-1424", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1425, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4241), false, 1, "Code-1425", "Model-1425", "Name-1425", "Spec-1425", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1426, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4246), true, 1, "Code-1426", "Model-1426", "Name-1426", "Spec-1426", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1427, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4251), false, 2, "Code-1427", "Model-1427", "Name-1427", "Spec-1427", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1428, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4258), true, 1, "Code-1428", "Model-1428", "Name-1428", "Spec-1428", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1429, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4262), false, 1, "Code-1429", "Model-1429", "Name-1429", "Spec-1429", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1430, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4268), true, 1, "Code-1430", "Model-1430", "Name-1430", "Spec-1430", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1431, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4273), false, 1, "Code-1431", "Model-1431", "Name-1431", "Spec-1431", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1432, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4279), true, 1, "Code-1432", "Model-1432", "Name-1432", "Spec-1432", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1433, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4284), false, 1, "Code-1433", "Model-1433", "Name-1433", "Spec-1433", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1434, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4290), true, 2, "Code-1434", "Model-1434", "Name-1434", "Spec-1434", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1435, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4294), false, 1, "Code-1435", "Model-1435", "Name-1435", "Spec-1435", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1436, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4300), true, 2, "Code-1436", "Model-1436", "Name-1436", "Spec-1436", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1437, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4304), false, 1, "Code-1437", "Model-1437", "Name-1437", "Spec-1437", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1438, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4310), true, 1, "Code-1438", "Model-1438", "Name-1438", "Spec-1438", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1439, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4315), false, 2, "Code-1439", "Model-1439", "Name-1439", "Spec-1439", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1440, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4321), true, 1, "Code-1440", "Model-1440", "Name-1440", "Spec-1440", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1441, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4359), false, 2, "Code-1441", "Model-1441", "Name-1441", "Spec-1441", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1442, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4367), true, 1, "Code-1442", "Model-1442", "Name-1442", "Spec-1442", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1443, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4371), false, 2, "Code-1443", "Model-1443", "Name-1443", "Spec-1443", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1444, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4377), true, 1, "Code-1444", "Model-1444", "Name-1444", "Spec-1444", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1445, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4382), false, 2, "Code-1445", "Model-1445", "Name-1445", "Spec-1445", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1446, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4388), true, 1, "Code-1446", "Model-1446", "Name-1446", "Spec-1446", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1447, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4393), false, 1, "Code-1447", "Model-1447", "Name-1447", "Spec-1447", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1448, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4399), true, 2, "Code-1448", "Model-1448", "Name-1448", "Spec-1448", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1449, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4403), false, 2, "Code-1449", "Model-1449", "Name-1449", "Spec-1449", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1450, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4409), true, 1, "Code-1450", "Model-1450", "Name-1450", "Spec-1450", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1451, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4414), false, 1, "Code-1451", "Model-1451", "Name-1451", "Spec-1451", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1452, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4420), true, 2, "Code-1452", "Model-1452", "Name-1452", "Spec-1452", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1453, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4424), false, 1, "Code-1453", "Model-1453", "Name-1453", "Spec-1453", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1454, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4430), true, 1, "Code-1454", "Model-1454", "Name-1454", "Spec-1454", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1455, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4435), false, 1, "Code-1455", "Model-1455", "Name-1455", "Spec-1455", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1456, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4442), true, 2, "Code-1456", "Model-1456", "Name-1456", "Spec-1456", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1457, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4446), false, 1, "Code-1457", "Model-1457", "Name-1457", "Spec-1457", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1458, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4452), true, 1, "Code-1458", "Model-1458", "Name-1458", "Spec-1458", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1459, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4457), false, 2, "Code-1459", "Model-1459", "Name-1459", "Spec-1459", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1460, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4462), true, 1, "Code-1460", "Model-1460", "Name-1460", "Spec-1460", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1461, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4467), false, 2, "Code-1461", "Model-1461", "Name-1461", "Spec-1461", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1462, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4509), true, 2, "Code-1462", "Model-1462", "Name-1462", "Spec-1462", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1463, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4514), false, 2, "Code-1463", "Model-1463", "Name-1463", "Spec-1463", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1464, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4521), true, 1, "Code-1464", "Model-1464", "Name-1464", "Spec-1464", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1465, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4525), false, 2, "Code-1465", "Model-1465", "Name-1465", "Spec-1465", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1466, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4531), true, 1, "Code-1466", "Model-1466", "Name-1466", "Spec-1466", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1467, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4536), false, 1, "Code-1467", "Model-1467", "Name-1467", "Spec-1467", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1468, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4542), true, 2, "Code-1468", "Model-1468", "Name-1468", "Spec-1468", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1469, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4546), false, 1, "Code-1469", "Model-1469", "Name-1469", "Spec-1469", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1470, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4552), true, 2, "Code-1470", "Model-1470", "Name-1470", "Spec-1470", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1471, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4556), false, 2, "Code-1471", "Model-1471", "Name-1471", "Spec-1471", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1472, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4562), true, 1, "Code-1472", "Model-1472", "Name-1472", "Spec-1472", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1473, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4567), false, 2, "Code-1473", "Model-1473", "Name-1473", "Spec-1473", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1474, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4573), true, 2, "Code-1474", "Model-1474", "Name-1474", "Spec-1474", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1475, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4578), false, 1, "Code-1475", "Model-1475", "Name-1475", "Spec-1475", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1476, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4584), true, 1, "Code-1476", "Model-1476", "Name-1476", "Spec-1476", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1477, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4588), false, 1, "Code-1477", "Model-1477", "Name-1477", "Spec-1477", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1478, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4595), true, 2, "Code-1478", "Model-1478", "Name-1478", "Spec-1478", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1479, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4599), false, 2, "Code-1479", "Model-1479", "Name-1479", "Spec-1479", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1480, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4605), true, 2, "Code-1480", "Model-1480", "Name-1480", "Spec-1480", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1481, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4610), false, 2, "Code-1481", "Model-1481", "Name-1481", "Spec-1481", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1482, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4650), true, 2, "Code-1482", "Model-1482", "Name-1482", "Spec-1482", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1483, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4656), false, 2, "Code-1483", "Model-1483", "Name-1483", "Spec-1483", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1484, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4662), true, 2, "Code-1484", "Model-1484", "Name-1484", "Spec-1484", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1485, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4667), false, 1, "Code-1485", "Model-1485", "Name-1485", "Spec-1485", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1486, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4673), true, 2, "Code-1486", "Model-1486", "Name-1486", "Spec-1486", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1487, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4677), false, 2, "Code-1487", "Model-1487", "Name-1487", "Spec-1487", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1488, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4683), true, 1, "Code-1488", "Model-1488", "Name-1488", "Spec-1488", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1489, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4687), false, 2, "Code-1489", "Model-1489", "Name-1489", "Spec-1489", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1490, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4693), true, 1, "Code-1490", "Model-1490", "Name-1490", "Spec-1490", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1491, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4698), false, 1, "Code-1491", "Model-1491", "Name-1491", "Spec-1491", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1492, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4704), true, 2, "Code-1492", "Model-1492", "Name-1492", "Spec-1492", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1493, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4708), false, 1, "Code-1493", "Model-1493", "Name-1493", "Spec-1493", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1494, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4715), true, 2, "Code-1494", "Model-1494", "Name-1494", "Spec-1494", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1495, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4719), false, 1, "Code-1495", "Model-1495", "Name-1495", "Spec-1495", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1496, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4725), true, 1, "Code-1496", "Model-1496", "Name-1496", "Spec-1496", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1497, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4729), false, 2, "Code-1497", "Model-1497", "Name-1497", "Spec-1497", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1498, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4735), true, 2, "Code-1498", "Model-1498", "Name-1498", "Spec-1498", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1499, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4740), false, 2, "Code-1499", "Model-1499", "Name-1499", "Spec-1499", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1500, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4746), true, 2, "Code-1500", "Model-1500", "Name-1500", "Spec-1500", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1501, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4750), false, 2, "Code-1501", "Model-1501", "Name-1501", "Spec-1501", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1502, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4757), true, 1, "Code-1502", "Model-1502", "Name-1502", "Spec-1502", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1503, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4796), false, 1, "Code-1503", "Model-1503", "Name-1503", "Spec-1503", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1504, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4802), true, 1, "Code-1504", "Model-1504", "Name-1504", "Spec-1504", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1505, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4807), false, 2, "Code-1505", "Model-1505", "Name-1505", "Spec-1505", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1506, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4813), true, 1, "Code-1506", "Model-1506", "Name-1506", "Spec-1506", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1507, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4817), false, 2, "Code-1507", "Model-1507", "Name-1507", "Spec-1507", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1508, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4823), true, 1, "Code-1508", "Model-1508", "Name-1508", "Spec-1508", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1509, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4827), false, 1, "Code-1509", "Model-1509", "Name-1509", "Spec-1509", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1510, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4835), true, 1, "Code-1510", "Model-1510", "Name-1510", "Spec-1510", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1511, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4840), false, 1, "Code-1511", "Model-1511", "Name-1511", "Spec-1511", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1512, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4849), true, 1, "Code-1512", "Model-1512", "Name-1512", "Spec-1512", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1513, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4922), false, 1, "Code-1513", "Model-1513", "Name-1513", "Spec-1513", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1514, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4929), true, 1, "Code-1514", "Model-1514", "Name-1514", "Spec-1514", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1515, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4934), false, 1, "Code-1515", "Model-1515", "Name-1515", "Spec-1515", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1516, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4940), true, 1, "Code-1516", "Model-1516", "Name-1516", "Spec-1516", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1517, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4944), false, 1, "Code-1517", "Model-1517", "Name-1517", "Spec-1517", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1518, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4951), true, 1, "Code-1518", "Model-1518", "Name-1518", "Spec-1518", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1519, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4956), false, 2, "Code-1519", "Model-1519", "Name-1519", "Spec-1519", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1520, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4962), true, 2, "Code-1520", "Model-1520", "Name-1520", "Spec-1520", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1521, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4967), false, 2, "Code-1521", "Model-1521", "Name-1521", "Spec-1521", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1522, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(4973), true, 2, "Code-1522", "Model-1522", "Name-1522", "Spec-1522", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1523, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5012), false, 1, "Code-1523", "Model-1523", "Name-1523", "Spec-1523", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1524, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5018), true, 2, "Code-1524", "Model-1524", "Name-1524", "Spec-1524", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1525, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5024), false, 2, "Code-1525", "Model-1525", "Name-1525", "Spec-1525", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1526, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5030), true, 1, "Code-1526", "Model-1526", "Name-1526", "Spec-1526", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1527, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5034), false, 1, "Code-1527", "Model-1527", "Name-1527", "Spec-1527", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1528, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5040), true, 1, "Code-1528", "Model-1528", "Name-1528", "Spec-1528", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1529, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5045), false, 2, "Code-1529", "Model-1529", "Name-1529", "Spec-1529", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1530, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5051), true, 2, "Code-1530", "Model-1530", "Name-1530", "Spec-1530", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1531, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5055), false, 2, "Code-1531", "Model-1531", "Name-1531", "Spec-1531", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1532, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5061), true, 2, "Code-1532", "Model-1532", "Name-1532", "Spec-1532", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1533, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5065), false, 2, "Code-1533", "Model-1533", "Name-1533", "Spec-1533", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1534, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5071), true, 1, "Code-1534", "Model-1534", "Name-1534", "Spec-1534", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1535, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5076), false, 1, "Code-1535", "Model-1535", "Name-1535", "Spec-1535", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1536, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5082), true, 2, "Code-1536", "Model-1536", "Name-1536", "Spec-1536", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1537, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5087), false, 2, "Code-1537", "Model-1537", "Name-1537", "Spec-1537", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1538, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5094), true, 1, "Code-1538", "Model-1538", "Name-1538", "Spec-1538", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1539, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5098), false, 1, "Code-1539", "Model-1539", "Name-1539", "Spec-1539", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1540, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5104), true, 2, "Code-1540", "Model-1540", "Name-1540", "Spec-1540", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1541, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5108), false, 2, "Code-1541", "Model-1541", "Name-1541", "Spec-1541", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1542, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5114), true, 1, "Code-1542", "Model-1542", "Name-1542", "Spec-1542", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1543, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5119), false, 1, "Code-1543", "Model-1543", "Name-1543", "Spec-1543", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1544, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5160), true, 2, "Code-1544", "Model-1544", "Name-1544", "Spec-1544", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1545, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5165), false, 1, "Code-1545", "Model-1545", "Name-1545", "Spec-1545", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1546, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5172), true, 2, "Code-1546", "Model-1546", "Name-1546", "Spec-1546", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1547, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5176), false, 1, "Code-1547", "Model-1547", "Name-1547", "Spec-1547", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1548, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5183), true, 2, "Code-1548", "Model-1548", "Name-1548", "Spec-1548", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1549, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5187), false, 1, "Code-1549", "Model-1549", "Name-1549", "Spec-1549", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1550, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5193), true, 2, "Code-1550", "Model-1550", "Name-1550", "Spec-1550", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1551, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5198), false, 2, "Code-1551", "Model-1551", "Name-1551", "Spec-1551", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1552, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5204), true, 2, "Code-1552", "Model-1552", "Name-1552", "Spec-1552", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1553, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5209), false, 2, "Code-1553", "Model-1553", "Name-1553", "Spec-1553", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1554, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5216), true, 2, "Code-1554", "Model-1554", "Name-1554", "Spec-1554", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1555, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5220), false, 2, "Code-1555", "Model-1555", "Name-1555", "Spec-1555", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1556, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5226), true, 2, "Code-1556", "Model-1556", "Name-1556", "Spec-1556", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1557, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5231), false, 2, "Code-1557", "Model-1557", "Name-1557", "Spec-1557", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1558, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5237), true, 1, "Code-1558", "Model-1558", "Name-1558", "Spec-1558", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1559, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5241), false, 2, "Code-1559", "Model-1559", "Name-1559", "Spec-1559", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1560, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5247), true, 1, "Code-1560", "Model-1560", "Name-1560", "Spec-1560", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1561, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5251), false, 2, "Code-1561", "Model-1561", "Name-1561", "Spec-1561", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1562, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5258), true, 1, "Code-1562", "Model-1562", "Name-1562", "Spec-1562", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1563, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5262), false, 1, "Code-1563", "Model-1563", "Name-1563", "Spec-1563", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1564, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5303), true, 2, "Code-1564", "Model-1564", "Name-1564", "Spec-1564", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1565, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5307), false, 2, "Code-1565", "Model-1565", "Name-1565", "Spec-1565", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1566, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5314), true, 2, "Code-1566", "Model-1566", "Name-1566", "Spec-1566", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1567, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5318), false, 2, "Code-1567", "Model-1567", "Name-1567", "Spec-1567", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1568, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5324), true, 2, "Code-1568", "Model-1568", "Name-1568", "Spec-1568", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1569, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5328), false, 1, "Code-1569", "Model-1569", "Name-1569", "Spec-1569", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1570, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5334), true, 1, "Code-1570", "Model-1570", "Name-1570", "Spec-1570", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1571, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5339), false, 1, "Code-1571", "Model-1571", "Name-1571", "Spec-1571", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1572, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5345), true, 2, "Code-1572", "Model-1572", "Name-1572", "Spec-1572", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1573, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5350), false, 2, "Code-1573", "Model-1573", "Name-1573", "Spec-1573", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1574, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5356), true, 1, "Code-1574", "Model-1574", "Name-1574", "Spec-1574", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1575, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5360), false, 2, "Code-1575", "Model-1575", "Name-1575", "Spec-1575", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1576, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5367), true, 1, "Code-1576", "Model-1576", "Name-1576", "Spec-1576", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1577, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5371), false, 1, "Code-1577", "Model-1577", "Name-1577", "Spec-1577", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1578, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5377), true, 2, "Code-1578", "Model-1578", "Name-1578", "Spec-1578", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1579, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5381), false, 2, "Code-1579", "Model-1579", "Name-1579", "Spec-1579", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1580, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5388), true, 1, "Code-1580", "Model-1580", "Name-1580", "Spec-1580", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1581, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5392), false, 1, "Code-1581", "Model-1581", "Name-1581", "Spec-1581", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1582, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5399), true, 1, "Code-1582", "Model-1582", "Name-1582", "Spec-1582", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1583, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5403), false, 1, "Code-1583", "Model-1583", "Name-1583", "Spec-1583", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1584, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5446), true, 2, "Code-1584", "Model-1584", "Name-1584", "Spec-1584", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1585, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5452), false, 2, "Code-1585", "Model-1585", "Name-1585", "Spec-1585", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1586, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5458), true, 2, "Code-1586", "Model-1586", "Name-1586", "Spec-1586", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1587, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5462), false, 1, "Code-1587", "Model-1587", "Name-1587", "Spec-1587", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1588, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5468), true, 1, "Code-1588", "Model-1588", "Name-1588", "Spec-1588", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1589, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5474), false, 2, "Code-1589", "Model-1589", "Name-1589", "Spec-1589", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1590, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5480), true, 1, "Code-1590", "Model-1590", "Name-1590", "Spec-1590", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1591, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5485), false, 2, "Code-1591", "Model-1591", "Name-1591", "Spec-1591", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1592, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5491), true, 2, "Code-1592", "Model-1592", "Name-1592", "Spec-1592", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1593, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5495), false, 1, "Code-1593", "Model-1593", "Name-1593", "Spec-1593", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1594, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5501), true, 1, "Code-1594", "Model-1594", "Name-1594", "Spec-1594", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1595, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5538), false, 2, "Code-1595", "Model-1595", "Name-1595", "Spec-1595", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1596, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5549), true, 2, "Code-1596", "Model-1596", "Name-1596", "Spec-1596", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1597, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5558), false, 1, "Code-1597", "Model-1597", "Name-1597", "Spec-1597", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1598, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5567), true, 2, "Code-1598", "Model-1598", "Name-1598", "Spec-1598", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1599, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5574), false, 2, "Code-1599", "Model-1599", "Name-1599", "Spec-1599", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1600, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5585), true, 2, "Code-1600", "Model-1600", "Name-1600", "Spec-1600", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1601, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5593), false, 1, "Code-1601", "Model-1601", "Name-1601", "Spec-1601", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1602, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5604), true, 1, "Code-1602", "Model-1602", "Name-1602", "Spec-1602", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1603, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5612), false, 2, "Code-1603", "Model-1603", "Name-1603", "Spec-1603", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1604, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5623), true, 1, "Code-1604", "Model-1604", "Name-1604", "Spec-1604", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1605, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5682), false, 1, "Code-1605", "Model-1605", "Name-1605", "Spec-1605", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1606, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5692), true, 1, "Code-1606", "Model-1606", "Name-1606", "Spec-1606", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1607, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5696), false, 2, "Code-1607", "Model-1607", "Name-1607", "Spec-1607", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1608, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5702), true, 1, "Code-1608", "Model-1608", "Name-1608", "Spec-1608", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1609, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5706), false, 1, "Code-1609", "Model-1609", "Name-1609", "Spec-1609", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1610, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5712), true, 1, "Code-1610", "Model-1610", "Name-1610", "Spec-1610", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1611, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5717), false, 2, "Code-1611", "Model-1611", "Name-1611", "Spec-1611", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1612, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5723), true, 1, "Code-1612", "Model-1612", "Name-1612", "Spec-1612", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1613, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5727), false, 2, "Code-1613", "Model-1613", "Name-1613", "Spec-1613", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1614, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5734), true, 2, "Code-1614", "Model-1614", "Name-1614", "Spec-1614", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1615, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5739), false, 2, "Code-1615", "Model-1615", "Name-1615", "Spec-1615", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1616, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5745), true, 1, "Code-1616", "Model-1616", "Name-1616", "Spec-1616", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1617, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5749), false, 1, "Code-1617", "Model-1617", "Name-1617", "Spec-1617", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1618, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5755), true, 1, "Code-1618", "Model-1618", "Name-1618", "Spec-1618", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1619, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5759), false, 2, "Code-1619", "Model-1619", "Name-1619", "Spec-1619", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1620, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5766), true, 2, "Code-1620", "Model-1620", "Name-1620", "Spec-1620", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1621, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5770), false, 1, "Code-1621", "Model-1621", "Name-1621", "Spec-1621", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1622, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5776), true, 1, "Code-1622", "Model-1622", "Name-1622", "Spec-1622", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1623, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5780), false, 2, "Code-1623", "Model-1623", "Name-1623", "Spec-1623", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1624, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5786), true, 1, "Code-1624", "Model-1624", "Name-1624", "Spec-1624", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1625, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5825), false, 1, "Code-1625", "Model-1625", "Name-1625", "Spec-1625", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1626, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5832), true, 1, "Code-1626", "Model-1626", "Name-1626", "Spec-1626", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1627, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5836), false, 1, "Code-1627", "Model-1627", "Name-1627", "Spec-1627", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1628, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5842), true, 1, "Code-1628", "Model-1628", "Name-1628", "Spec-1628", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1629, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5846), false, 1, "Code-1629", "Model-1629", "Name-1629", "Spec-1629", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1630, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5852), true, 2, "Code-1630", "Model-1630", "Name-1630", "Spec-1630", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1631, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5857), false, 2, "Code-1631", "Model-1631", "Name-1631", "Spec-1631", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1632, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5863), true, 2, "Code-1632", "Model-1632", "Name-1632", "Spec-1632", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1633, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5867), false, 1, "Code-1633", "Model-1633", "Name-1633", "Spec-1633", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1634, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5873), true, 1, "Code-1634", "Model-1634", "Name-1634", "Spec-1634", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1635, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5878), false, 2, "Code-1635", "Model-1635", "Name-1635", "Spec-1635", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1636, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5884), true, 2, "Code-1636", "Model-1636", "Name-1636", "Spec-1636", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1637, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5889), false, 1, "Code-1637", "Model-1637", "Name-1637", "Spec-1637", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1638, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5895), true, 1, "Code-1638", "Model-1638", "Name-1638", "Spec-1638", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1639, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5899), false, 1, "Code-1639", "Model-1639", "Name-1639", "Spec-1639", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1640, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5906), true, 1, "Code-1640", "Model-1640", "Name-1640", "Spec-1640", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1641, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5911), false, 2, "Code-1641", "Model-1641", "Name-1641", "Spec-1641", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1642, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5917), true, 1, "Code-1642", "Model-1642", "Name-1642", "Spec-1642", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1643, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5921), false, 1, "Code-1643", "Model-1643", "Name-1643", "Spec-1643", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1644, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5928), true, 2, "Code-1644", "Model-1644", "Name-1644", "Spec-1644", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1645, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5932), false, 1, "Code-1645", "Model-1645", "Name-1645", "Spec-1645", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1646, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5973), true, 1, "Code-1646", "Model-1646", "Name-1646", "Spec-1646", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1647, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5978), false, 2, "Code-1647", "Model-1647", "Name-1647", "Spec-1647", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1648, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5984), true, 2, "Code-1648", "Model-1648", "Name-1648", "Spec-1648", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1649, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5989), false, 2, "Code-1649", "Model-1649", "Name-1649", "Spec-1649", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1650, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5995), true, 2, "Code-1650", "Model-1650", "Name-1650", "Spec-1650", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1651, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(5999), false, 2, "Code-1651", "Model-1651", "Name-1651", "Spec-1651", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1652, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6006), true, 1, "Code-1652", "Model-1652", "Name-1652", "Spec-1652", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1653, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6010), false, 2, "Code-1653", "Model-1653", "Name-1653", "Spec-1653", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1654, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6016), true, 2, "Code-1654", "Model-1654", "Name-1654", "Spec-1654", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1655, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6020), false, 2, "Code-1655", "Model-1655", "Name-1655", "Spec-1655", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1656, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6026), true, 2, "Code-1656", "Model-1656", "Name-1656", "Spec-1656", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1657, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6030), false, 2, "Code-1657", "Model-1657", "Name-1657", "Spec-1657", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1658, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6036), true, 1, "Code-1658", "Model-1658", "Name-1658", "Spec-1658", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1659, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6041), false, 2, "Code-1659", "Model-1659", "Name-1659", "Spec-1659", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1660, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6047), true, 1, "Code-1660", "Model-1660", "Name-1660", "Spec-1660", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1661, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6052), false, 2, "Code-1661", "Model-1661", "Name-1661", "Spec-1661", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1662, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6058), true, 1, "Code-1662", "Model-1662", "Name-1662", "Spec-1662", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1663, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6063), false, 1, "Code-1663", "Model-1663", "Name-1663", "Spec-1663", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1664, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6069), true, 2, "Code-1664", "Model-1664", "Name-1664", "Spec-1664", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1665, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6073), false, 2, "Code-1665", "Model-1665", "Name-1665", "Spec-1665", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1666, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6099), true, 1, "Code-1666", "Model-1666", "Name-1666", "Spec-1666", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1667, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6104), false, 1, "Code-1667", "Model-1667", "Name-1667", "Spec-1667", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1668, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6110), true, 2, "Code-1668", "Model-1668", "Name-1668", "Spec-1668", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1669, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6115), false, 2, "Code-1669", "Model-1669", "Name-1669", "Spec-1669", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1670, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6121), true, 1, "Code-1670", "Model-1670", "Name-1670", "Spec-1670", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1671, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6126), false, 2, "Code-1671", "Model-1671", "Name-1671", "Spec-1671", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1672, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6132), true, 2, "Code-1672", "Model-1672", "Name-1672", "Spec-1672", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1673, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6136), false, 1, "Code-1673", "Model-1673", "Name-1673", "Spec-1673", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1674, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6142), true, 2, "Code-1674", "Model-1674", "Name-1674", "Spec-1674", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1675, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6147), false, 1, "Code-1675", "Model-1675", "Name-1675", "Spec-1675", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1676, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6154), true, 1, "Code-1676", "Model-1676", "Name-1676", "Spec-1676", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1677, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6158), false, 2, "Code-1677", "Model-1677", "Name-1677", "Spec-1677", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1678, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6166), true, 1, "Code-1678", "Model-1678", "Name-1678", "Spec-1678", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1679, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6171), false, 1, "Code-1679", "Model-1679", "Name-1679", "Spec-1679", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1680, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6177), true, 1, "Code-1680", "Model-1680", "Name-1680", "Spec-1680", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1681, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6182), false, 2, "Code-1681", "Model-1681", "Name-1681", "Spec-1681", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1682, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6188), true, 1, "Code-1682", "Model-1682", "Name-1682", "Spec-1682", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1683, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6192), false, 1, "Code-1683", "Model-1683", "Name-1683", "Spec-1683", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1684, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6198), true, 2, "Code-1684", "Model-1684", "Name-1684", "Spec-1684", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1685, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6202), false, 2, "Code-1685", "Model-1685", "Name-1685", "Spec-1685", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1686, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6256), true, 2, "Code-1686", "Model-1686", "Name-1686", "Spec-1686", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1687, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6262), false, 2, "Code-1687", "Model-1687", "Name-1687", "Spec-1687", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1688, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6268), true, 2, "Code-1688", "Model-1688", "Name-1688", "Spec-1688", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1689, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6272), false, 2, "Code-1689", "Model-1689", "Name-1689", "Spec-1689", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1690, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6278), true, 2, "Code-1690", "Model-1690", "Name-1690", "Spec-1690", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1691, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6282), false, 2, "Code-1691", "Model-1691", "Name-1691", "Spec-1691", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1692, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6288), true, 1, "Code-1692", "Model-1692", "Name-1692", "Spec-1692", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1693, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6293), false, 2, "Code-1693", "Model-1693", "Name-1693", "Spec-1693", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1694, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6299), true, 1, "Code-1694", "Model-1694", "Name-1694", "Spec-1694", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1695, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6303), false, 2, "Code-1695", "Model-1695", "Name-1695", "Spec-1695", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1696, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6309), true, 1, "Code-1696", "Model-1696", "Name-1696", "Spec-1696", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1697, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6314), false, 1, "Code-1697", "Model-1697", "Name-1697", "Spec-1697", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1698, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6319), true, 1, "Code-1698", "Model-1698", "Name-1698", "Spec-1698", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1699, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6324), false, 2, "Code-1699", "Model-1699", "Name-1699", "Spec-1699", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1700, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6330), true, 1, "Code-1700", "Model-1700", "Name-1700", "Spec-1700", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1701, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6334), false, 2, "Code-1701", "Model-1701", "Name-1701", "Spec-1701", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1702, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6341), true, 2, "Code-1702", "Model-1702", "Name-1702", "Spec-1702", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1703, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6345), false, 1, "Code-1703", "Model-1703", "Name-1703", "Spec-1703", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1704, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6351), true, 1, "Code-1704", "Model-1704", "Name-1704", "Spec-1704", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1705, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6356), false, 2, "Code-1705", "Model-1705", "Name-1705", "Spec-1705", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1706, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6362), true, 1, "Code-1706", "Model-1706", "Name-1706", "Spec-1706", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1707, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6401), false, 1, "Code-1707", "Model-1707", "Name-1707", "Spec-1707", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1708, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6407), true, 2, "Code-1708", "Model-1708", "Name-1708", "Spec-1708", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1709, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6412), false, 1, "Code-1709", "Model-1709", "Name-1709", "Spec-1709", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1710, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6419), true, 1, "Code-1710", "Model-1710", "Name-1710", "Spec-1710", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1711, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6424), false, 2, "Code-1711", "Model-1711", "Name-1711", "Spec-1711", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1712, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6431), true, 2, "Code-1712", "Model-1712", "Name-1712", "Spec-1712", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1713, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6435), false, 1, "Code-1713", "Model-1713", "Name-1713", "Spec-1713", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1714, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6442), true, 1, "Code-1714", "Model-1714", "Name-1714", "Spec-1714", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1715, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6446), false, 1, "Code-1715", "Model-1715", "Name-1715", "Spec-1715", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1716, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6453), true, 1, "Code-1716", "Model-1716", "Name-1716", "Spec-1716", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1717, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6457), false, 2, "Code-1717", "Model-1717", "Name-1717", "Spec-1717", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1718, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6464), true, 1, "Code-1718", "Model-1718", "Name-1718", "Spec-1718", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1719, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6468), false, 2, "Code-1719", "Model-1719", "Name-1719", "Spec-1719", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1720, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6474), true, 1, "Code-1720", "Model-1720", "Name-1720", "Spec-1720", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1721, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6478), false, 2, "Code-1721", "Model-1721", "Name-1721", "Spec-1721", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1722, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6484), true, 1, "Code-1722", "Model-1722", "Name-1722", "Spec-1722", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1723, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6490), false, 1, "Code-1723", "Model-1723", "Name-1723", "Spec-1723", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1724, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6496), true, 1, "Code-1724", "Model-1724", "Name-1724", "Spec-1724", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1725, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6501), false, 2, "Code-1725", "Model-1725", "Name-1725", "Spec-1725", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1726, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6507), true, 2, "Code-1726", "Model-1726", "Name-1726", "Spec-1726", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1727, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6551), false, 2, "Code-1727", "Model-1727", "Name-1727", "Spec-1727", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1728, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6558), true, 2, "Code-1728", "Model-1728", "Name-1728", "Spec-1728", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1729, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6562), false, 1, "Code-1729", "Model-1729", "Name-1729", "Spec-1729", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1730, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6568), true, 2, "Code-1730", "Model-1730", "Name-1730", "Spec-1730", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1731, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6573), false, 2, "Code-1731", "Model-1731", "Name-1731", "Spec-1731", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1732, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6579), true, 1, "Code-1732", "Model-1732", "Name-1732", "Spec-1732", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1733, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6584), false, 2, "Code-1733", "Model-1733", "Name-1733", "Spec-1733", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1734, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6590), true, 1, "Code-1734", "Model-1734", "Name-1734", "Spec-1734", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1735, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6594), false, 2, "Code-1735", "Model-1735", "Name-1735", "Spec-1735", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1736, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6600), true, 1, "Code-1736", "Model-1736", "Name-1736", "Spec-1736", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1737, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6604), false, 1, "Code-1737", "Model-1737", "Name-1737", "Spec-1737", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1738, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6610), true, 2, "Code-1738", "Model-1738", "Name-1738", "Spec-1738", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1739, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6615), false, 1, "Code-1739", "Model-1739", "Name-1739", "Spec-1739", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1740, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6621), true, 2, "Code-1740", "Model-1740", "Name-1740", "Spec-1740", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1741, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6625), false, 2, "Code-1741", "Model-1741", "Name-1741", "Spec-1741", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1742, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6633), true, 2, "Code-1742", "Model-1742", "Name-1742", "Spec-1742", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1743, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6637), false, 1, "Code-1743", "Model-1743", "Name-1743", "Spec-1743", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1744, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6644), true, 1, "Code-1744", "Model-1744", "Name-1744", "Spec-1744", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1745, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6648), false, 2, "Code-1745", "Model-1745", "Name-1745", "Spec-1745", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1746, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6654), true, 2, "Code-1746", "Model-1746", "Name-1746", "Spec-1746", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1747, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6659), false, 1, "Code-1747", "Model-1747", "Name-1747", "Spec-1747", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1748, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6700), true, 2, "Code-1748", "Model-1748", "Name-1748", "Spec-1748", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1749, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6705), false, 2, "Code-1749", "Model-1749", "Name-1749", "Spec-1749", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1750, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6711), true, 1, "Code-1750", "Model-1750", "Name-1750", "Spec-1750", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1751, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6716), false, 2, "Code-1751", "Model-1751", "Name-1751", "Spec-1751", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1752, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6722), true, 2, "Code-1752", "Model-1752", "Name-1752", "Spec-1752", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1753, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6727), false, 1, "Code-1753", "Model-1753", "Name-1753", "Spec-1753", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1754, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6733), true, 1, "Code-1754", "Model-1754", "Name-1754", "Spec-1754", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1755, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6738), false, 2, "Code-1755", "Model-1755", "Name-1755", "Spec-1755", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1756, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6745), true, 1, "Code-1756", "Model-1756", "Name-1756", "Spec-1756", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1757, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6749), false, 1, "Code-1757", "Model-1757", "Name-1757", "Spec-1757", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1758, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6756), true, 2, "Code-1758", "Model-1758", "Name-1758", "Spec-1758", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1759, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6761), false, 1, "Code-1759", "Model-1759", "Name-1759", "Spec-1759", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1760, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6767), true, 2, "Code-1760", "Model-1760", "Name-1760", "Spec-1760", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1761, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6772), false, 2, "Code-1761", "Model-1761", "Name-1761", "Spec-1761", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1762, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6778), true, 2, "Code-1762", "Model-1762", "Name-1762", "Spec-1762", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1763, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6783), false, 1, "Code-1763", "Model-1763", "Name-1763", "Spec-1763", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1764, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6789), true, 1, "Code-1764", "Model-1764", "Name-1764", "Spec-1764", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1765, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6793), false, 1, "Code-1765", "Model-1765", "Name-1765", "Spec-1765", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1766, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6799), true, 1, "Code-1766", "Model-1766", "Name-1766", "Spec-1766", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1767, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6804), false, 2, "Code-1767", "Model-1767", "Name-1767", "Spec-1767", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1768, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6849), true, 1, "Code-1768", "Model-1768", "Name-1768", "Spec-1768", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1769, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6854), false, 1, "Code-1769", "Model-1769", "Name-1769", "Spec-1769", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1770, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6860), true, 2, "Code-1770", "Model-1770", "Name-1770", "Spec-1770", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1771, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6864), false, 2, "Code-1771", "Model-1771", "Name-1771", "Spec-1771", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1772, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6870), true, 1, "Code-1772", "Model-1772", "Name-1772", "Spec-1772", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1773, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6874), false, 2, "Code-1773", "Model-1773", "Name-1773", "Spec-1773", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1774, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6881), true, 1, "Code-1774", "Model-1774", "Name-1774", "Spec-1774", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1775, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6885), false, 2, "Code-1775", "Model-1775", "Name-1775", "Spec-1775", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1776, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6891), true, 2, "Code-1776", "Model-1776", "Name-1776", "Spec-1776", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1777, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6895), false, 1, "Code-1777", "Model-1777", "Name-1777", "Spec-1777", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1778, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6901), true, 1, "Code-1778", "Model-1778", "Name-1778", "Spec-1778", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1779, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6906), false, 2, "Code-1779", "Model-1779", "Name-1779", "Spec-1779", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1780, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6912), true, 1, "Code-1780", "Model-1780", "Name-1780", "Spec-1780", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1781, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6916), false, 1, "Code-1781", "Model-1781", "Name-1781", "Spec-1781", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1782, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6922), true, 1, "Code-1782", "Model-1782", "Name-1782", "Spec-1782", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1783, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6927), false, 1, "Code-1783", "Model-1783", "Name-1783", "Spec-1783", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1784, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6933), true, 2, "Code-1784", "Model-1784", "Name-1784", "Spec-1784", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1785, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6937), false, 1, "Code-1785", "Model-1785", "Name-1785", "Spec-1785", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1786, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6943), true, 1, "Code-1786", "Model-1786", "Name-1786", "Spec-1786", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1787, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6947), false, 1, "Code-1787", "Model-1787", "Name-1787", "Spec-1787", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1788, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6988), true, 1, "Code-1788", "Model-1788", "Name-1788", "Spec-1788", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1789, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(6993), false, 2, "Code-1789", "Model-1789", "Name-1789", "Spec-1789", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1790, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7000), true, 2, "Code-1790", "Model-1790", "Name-1790", "Spec-1790", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1791, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7004), false, 1, "Code-1791", "Model-1791", "Name-1791", "Spec-1791", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1792, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7010), true, 2, "Code-1792", "Model-1792", "Name-1792", "Spec-1792", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1793, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7014), false, 2, "Code-1793", "Model-1793", "Name-1793", "Spec-1793", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1794, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7021), true, 2, "Code-1794", "Model-1794", "Name-1794", "Spec-1794", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1795, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7025), false, 1, "Code-1795", "Model-1795", "Name-1795", "Spec-1795", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1796, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7031), true, 1, "Code-1796", "Model-1796", "Name-1796", "Spec-1796", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1797, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7035), false, 1, "Code-1797", "Model-1797", "Name-1797", "Spec-1797", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1798, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7041), true, 2, "Code-1798", "Model-1798", "Name-1798", "Spec-1798", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1799, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7046), false, 1, "Code-1799", "Model-1799", "Name-1799", "Spec-1799", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1800, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7052), true, 2, "Code-1800", "Model-1800", "Name-1800", "Spec-1800", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1801, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7056), false, 1, "Code-1801", "Model-1801", "Name-1801", "Spec-1801", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1802, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7062), true, 1, "Code-1802", "Model-1802", "Name-1802", "Spec-1802", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1803, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7066), false, 1, "Code-1803", "Model-1803", "Name-1803", "Spec-1803", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1804, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7072), true, 1, "Code-1804", "Model-1804", "Name-1804", "Spec-1804", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1805, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7077), false, 2, "Code-1805", "Model-1805", "Name-1805", "Spec-1805", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1806, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7083), true, 2, "Code-1806", "Model-1806", "Name-1806", "Spec-1806", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1807, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7087), false, 2, "Code-1807", "Model-1807", "Name-1807", "Spec-1807", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1808, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7093), true, 1, "Code-1808", "Model-1808", "Name-1808", "Spec-1808", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1809, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7133), false, 2, "Code-1809", "Model-1809", "Name-1809", "Spec-1809", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1810, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7140), true, 2, "Code-1810", "Model-1810", "Name-1810", "Spec-1810", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1811, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7145), false, 1, "Code-1811", "Model-1811", "Name-1811", "Spec-1811", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1812, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7151), true, 1, "Code-1812", "Model-1812", "Name-1812", "Spec-1812", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1813, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7155), false, 1, "Code-1813", "Model-1813", "Name-1813", "Spec-1813", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1814, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7162), true, 2, "Code-1814", "Model-1814", "Name-1814", "Spec-1814", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1815, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7166), false, 1, "Code-1815", "Model-1815", "Name-1815", "Spec-1815", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1816, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7172), true, 1, "Code-1816", "Model-1816", "Name-1816", "Spec-1816", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1817, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7176), false, 1, "Code-1817", "Model-1817", "Name-1817", "Spec-1817", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1818, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7182), true, 1, "Code-1818", "Model-1818", "Name-1818", "Spec-1818", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1819, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7187), false, 2, "Code-1819", "Model-1819", "Name-1819", "Spec-1819", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1820, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7193), true, 2, "Code-1820", "Model-1820", "Name-1820", "Spec-1820", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1821, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7197), false, 2, "Code-1821", "Model-1821", "Name-1821", "Spec-1821", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1822, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7203), true, 1, "Code-1822", "Model-1822", "Name-1822", "Spec-1822", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1823, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7207), false, 1, "Code-1823", "Model-1823", "Name-1823", "Spec-1823", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1824, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7213), true, 1, "Code-1824", "Model-1824", "Name-1824", "Spec-1824", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1825, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7218), false, 1, "Code-1825", "Model-1825", "Name-1825", "Spec-1825", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1826, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7225), true, 1, "Code-1826", "Model-1826", "Name-1826", "Spec-1826", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1827, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7229), false, 1, "Code-1827", "Model-1827", "Name-1827", "Spec-1827", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1828, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7235), true, 1, "Code-1828", "Model-1828", "Name-1828", "Spec-1828", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1829, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7274), false, 2, "Code-1829", "Model-1829", "Name-1829", "Spec-1829", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1830, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7282), true, 1, "Code-1830", "Model-1830", "Name-1830", "Spec-1830", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1831, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7286), false, 2, "Code-1831", "Model-1831", "Name-1831", "Spec-1831", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1832, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7292), true, 2, "Code-1832", "Model-1832", "Name-1832", "Spec-1832", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1833, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7297), false, 2, "Code-1833", "Model-1833", "Name-1833", "Spec-1833", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1834, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7303), true, 1, "Code-1834", "Model-1834", "Name-1834", "Spec-1834", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1835, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7307), false, 1, "Code-1835", "Model-1835", "Name-1835", "Spec-1835", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1836, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7313), true, 2, "Code-1836", "Model-1836", "Name-1836", "Spec-1836", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1837, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7318), false, 2, "Code-1837", "Model-1837", "Name-1837", "Spec-1837", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1838, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7324), true, 2, "Code-1838", "Model-1838", "Name-1838", "Spec-1838", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1839, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7328), false, 1, "Code-1839", "Model-1839", "Name-1839", "Spec-1839", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1840, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7335), true, 1, "Code-1840", "Model-1840", "Name-1840", "Spec-1840", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1841, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7339), false, 1, "Code-1841", "Model-1841", "Name-1841", "Spec-1841", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1842, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7345), true, 1, "Code-1842", "Model-1842", "Name-1842", "Spec-1842", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1843, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7350), false, 2, "Code-1843", "Model-1843", "Name-1843", "Spec-1843", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1844, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7356), true, 2, "Code-1844", "Model-1844", "Name-1844", "Spec-1844", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1845, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7360), false, 2, "Code-1845", "Model-1845", "Name-1845", "Spec-1845", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1846, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7366), true, 2, "Code-1846", "Model-1846", "Name-1846", "Spec-1846", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1847, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7371), false, 2, "Code-1847", "Model-1847", "Name-1847", "Spec-1847", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1848, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7377), true, 1, "Code-1848", "Model-1848", "Name-1848", "Spec-1848", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1849, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7381), false, 2, "Code-1849", "Model-1849", "Name-1849", "Spec-1849", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1850, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7434), true, 2, "Code-1850", "Model-1850", "Name-1850", "Spec-1850", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1851, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7439), false, 2, "Code-1851", "Model-1851", "Name-1851", "Spec-1851", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1852, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7446), true, 1, "Code-1852", "Model-1852", "Name-1852", "Spec-1852", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1853, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7450), false, 1, "Code-1853", "Model-1853", "Name-1853", "Spec-1853", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1854, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7456), true, 1, "Code-1854", "Model-1854", "Name-1854", "Spec-1854", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1855, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7460), false, 2, "Code-1855", "Model-1855", "Name-1855", "Spec-1855", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1856, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7467), true, 2, "Code-1856", "Model-1856", "Name-1856", "Spec-1856", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1857, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7471), false, 2, "Code-1857", "Model-1857", "Name-1857", "Spec-1857", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1858, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7477), true, 2, "Code-1858", "Model-1858", "Name-1858", "Spec-1858", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1859, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7481), false, 1, "Code-1859", "Model-1859", "Name-1859", "Spec-1859", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1860, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7487), true, 2, "Code-1860", "Model-1860", "Name-1860", "Spec-1860", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1861, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7492), false, 2, "Code-1861", "Model-1861", "Name-1861", "Spec-1861", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1862, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7498), true, 2, "Code-1862", "Model-1862", "Name-1862", "Spec-1862", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1863, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7502), false, 1, "Code-1863", "Model-1863", "Name-1863", "Spec-1863", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1864, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7508), true, 2, "Code-1864", "Model-1864", "Name-1864", "Spec-1864", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1865, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7513), false, 2, "Code-1865", "Model-1865", "Name-1865", "Spec-1865", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1866, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7519), true, 1, "Code-1866", "Model-1866", "Name-1866", "Spec-1866", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1867, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7523), false, 1, "Code-1867", "Model-1867", "Name-1867", "Spec-1867", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1868, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7529), true, 1, "Code-1868", "Model-1868", "Name-1868", "Spec-1868", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1869, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7534), false, 1, "Code-1869", "Model-1869", "Name-1869", "Spec-1869", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1870, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7574), true, 1, "Code-1870", "Model-1870", "Name-1870", "Spec-1870", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1871, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7579), false, 1, "Code-1871", "Model-1871", "Name-1871", "Spec-1871", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1872, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7585), true, 1, "Code-1872", "Model-1872", "Name-1872", "Spec-1872", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1873, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7589), false, 1, "Code-1873", "Model-1873", "Name-1873", "Spec-1873", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1874, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7595), true, 2, "Code-1874", "Model-1874", "Name-1874", "Spec-1874", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1875, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7600), false, 1, "Code-1875", "Model-1875", "Name-1875", "Spec-1875", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1876, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7606), true, 1, "Code-1876", "Model-1876", "Name-1876", "Spec-1876", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1877, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7611), false, 2, "Code-1877", "Model-1877", "Name-1877", "Spec-1877", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1878, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7618), true, 1, "Code-1878", "Model-1878", "Name-1878", "Spec-1878", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1879, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7622), false, 1, "Code-1879", "Model-1879", "Name-1879", "Spec-1879", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1880, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7628), true, 1, "Code-1880", "Model-1880", "Name-1880", "Spec-1880", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1881, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7632), false, 2, "Code-1881", "Model-1881", "Name-1881", "Spec-1881", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1882, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7638), true, 1, "Code-1882", "Model-1882", "Name-1882", "Spec-1882", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1883, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7642), false, 1, "Code-1883", "Model-1883", "Name-1883", "Spec-1883", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1884, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7648), true, 2, "Code-1884", "Model-1884", "Name-1884", "Spec-1884", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1885, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7653), false, 2, "Code-1885", "Model-1885", "Name-1885", "Spec-1885", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1886, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7659), true, 1, "Code-1886", "Model-1886", "Name-1886", "Spec-1886", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1887, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7663), false, 2, "Code-1887", "Model-1887", "Name-1887", "Spec-1887", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1888, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7669), true, 1, "Code-1888", "Model-1888", "Name-1888", "Spec-1888", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1889, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7674), false, 2, "Code-1889", "Model-1889", "Name-1889", "Spec-1889", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1890, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7680), true, 2, "Code-1890", "Model-1890", "Name-1890", "Spec-1890", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1891, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7719), false, 1, "Code-1891", "Model-1891", "Name-1891", "Spec-1891", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1892, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7726), true, 2, "Code-1892", "Model-1892", "Name-1892", "Spec-1892", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1893, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7730), false, 2, "Code-1893", "Model-1893", "Name-1893", "Spec-1893", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1894, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7736), true, 1, "Code-1894", "Model-1894", "Name-1894", "Spec-1894", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1895, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7740), false, 2, "Code-1895", "Model-1895", "Name-1895", "Spec-1895", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1896, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7746), true, 2, "Code-1896", "Model-1896", "Name-1896", "Spec-1896", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1897, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7751), false, 2, "Code-1897", "Model-1897", "Name-1897", "Spec-1897", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1898, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7757), true, 2, "Code-1898", "Model-1898", "Name-1898", "Spec-1898", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1899, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7761), false, 2, "Code-1899", "Model-1899", "Name-1899", "Spec-1899", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1900, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7767), true, 1, "Code-1900", "Model-1900", "Name-1900", "Spec-1900", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1901, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7771), false, 1, "Code-1901", "Model-1901", "Name-1901", "Spec-1901", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1902, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7777), true, 2, "Code-1902", "Model-1902", "Name-1902", "Spec-1902", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1903, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7782), false, 1, "Code-1903", "Model-1903", "Name-1903", "Spec-1903", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1904, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7788), true, 2, "Code-1904", "Model-1904", "Name-1904", "Spec-1904", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1905, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7792), false, 2, "Code-1905", "Model-1905", "Name-1905", "Spec-1905", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1906, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7799), true, 1, "Code-1906", "Model-1906", "Name-1906", "Spec-1906", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1907, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7803), false, 1, "Code-1907", "Model-1907", "Name-1907", "Spec-1907", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1908, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7809), true, 1, "Code-1908", "Model-1908", "Name-1908", "Spec-1908", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1909, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7814), false, 1, "Code-1909", "Model-1909", "Name-1909", "Spec-1909", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1910, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7820), true, 1, "Code-1910", "Model-1910", "Name-1910", "Spec-1910", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1911, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7859), false, 2, "Code-1911", "Model-1911", "Name-1911", "Spec-1911", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1912, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7866), true, 2, "Code-1912", "Model-1912", "Name-1912", "Spec-1912", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1913, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7870), false, 1, "Code-1913", "Model-1913", "Name-1913", "Spec-1913", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1914, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7876), true, 2, "Code-1914", "Model-1914", "Name-1914", "Spec-1914", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1915, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7880), false, 2, "Code-1915", "Model-1915", "Name-1915", "Spec-1915", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1916, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7886), true, 1, "Code-1916", "Model-1916", "Name-1916", "Spec-1916", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1917, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7891), false, 1, "Code-1917", "Model-1917", "Name-1917", "Spec-1917", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1918, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7897), true, 1, "Code-1918", "Model-1918", "Name-1918", "Spec-1918", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1919, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7901), false, 1, "Code-1919", "Model-1919", "Name-1919", "Spec-1919", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1920, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7908), true, 2, "Code-1920", "Model-1920", "Name-1920", "Spec-1920", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1921, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7913), false, 1, "Code-1921", "Model-1921", "Name-1921", "Spec-1921", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1922, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7919), true, 1, "Code-1922", "Model-1922", "Name-1922", "Spec-1922", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1923, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7923), false, 2, "Code-1923", "Model-1923", "Name-1923", "Spec-1923", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1924, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7930), true, 1, "Code-1924", "Model-1924", "Name-1924", "Spec-1924", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1925, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7934), false, 2, "Code-1925", "Model-1925", "Name-1925", "Spec-1925", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1926, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7940), true, 1, "Code-1926", "Model-1926", "Name-1926", "Spec-1926", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1927, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7945), false, 2, "Code-1927", "Model-1927", "Name-1927", "Spec-1927", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1928, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7951), true, 2, "Code-1928", "Model-1928", "Name-1928", "Spec-1928", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1929, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7955), false, 2, "Code-1929", "Model-1929", "Name-1929", "Spec-1929", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1930, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7961), true, 1, "Code-1930", "Model-1930", "Name-1930", "Spec-1930", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1931, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(7999), false, 1, "Code-1931", "Model-1931", "Name-1931", "Spec-1931", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1932, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8007), true, 1, "Code-1932", "Model-1932", "Name-1932", "Spec-1932", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1933, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8011), false, 2, "Code-1933", "Model-1933", "Name-1933", "Spec-1933", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1934, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8017), true, 1, "Code-1934", "Model-1934", "Name-1934", "Spec-1934", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1935, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8022), false, 1, "Code-1935", "Model-1935", "Name-1935", "Spec-1935", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1936, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8028), true, 2, "Code-1936", "Model-1936", "Name-1936", "Spec-1936", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1937, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8032), false, 2, "Code-1937", "Model-1937", "Name-1937", "Spec-1937", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1938, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8038), true, 2, "Code-1938", "Model-1938", "Name-1938", "Spec-1938", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1939, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8043), false, 1, "Code-1939", "Model-1939", "Name-1939", "Spec-1939", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1940, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8049), true, 1, "Code-1940", "Model-1940", "Name-1940", "Spec-1940", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1941, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8053), false, 1, "Code-1941", "Model-1941", "Name-1941", "Spec-1941", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1942, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8060), true, 1, "Code-1942", "Model-1942", "Name-1942", "Spec-1942", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1943, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8064), false, 1, "Code-1943", "Model-1943", "Name-1943", "Spec-1943", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1944, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8070), true, 1, "Code-1944", "Model-1944", "Name-1944", "Spec-1944", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1945, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8075), false, 2, "Code-1945", "Model-1945", "Name-1945", "Spec-1945", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1946, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8081), true, 1, "Code-1946", "Model-1946", "Name-1946", "Spec-1946", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1947, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8085), false, 2, "Code-1947", "Model-1947", "Name-1947", "Spec-1947", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1948, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8091), true, 1, "Code-1948", "Model-1948", "Name-1948", "Spec-1948", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1949, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8095), false, 2, "Code-1949", "Model-1949", "Name-1949", "Spec-1949", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1950, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8102), true, 1, "Code-1950", "Model-1950", "Name-1950", "Spec-1950", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1951, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8106), false, 2, "Code-1951", "Model-1951", "Name-1951", "Spec-1951", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1952, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8159), true, 2, "Code-1952", "Model-1952", "Name-1952", "Spec-1952", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1953, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8164), false, 1, "Code-1953", "Model-1953", "Name-1953", "Spec-1953", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1954, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8170), true, 2, "Code-1954", "Model-1954", "Name-1954", "Spec-1954", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1955, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8175), false, 1, "Code-1955", "Model-1955", "Name-1955", "Spec-1955", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1956, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8181), true, 2, "Code-1956", "Model-1956", "Name-1956", "Spec-1956", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1957, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8185), false, 1, "Code-1957", "Model-1957", "Name-1957", "Spec-1957", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1958, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8191), true, 1, "Code-1958", "Model-1958", "Name-1958", "Spec-1958", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1959, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8195), false, 2, "Code-1959", "Model-1959", "Name-1959", "Spec-1959", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1960, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8201), true, 2, "Code-1960", "Model-1960", "Name-1960", "Spec-1960", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1961, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8205), false, 2, "Code-1961", "Model-1961", "Name-1961", "Spec-1961", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1962, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8211), true, 1, "Code-1962", "Model-1962", "Name-1962", "Spec-1962", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1963, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8216), false, 1, "Code-1963", "Model-1963", "Name-1963", "Spec-1963", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1964, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8222), true, 2, "Code-1964", "Model-1964", "Name-1964", "Spec-1964", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1965, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8226), false, 2, "Code-1965", "Model-1965", "Name-1965", "Spec-1965", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1966, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8232), true, 1, "Code-1966", "Model-1966", "Name-1966", "Spec-1966", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1967, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8237), false, 1, "Code-1967", "Model-1967", "Name-1967", "Spec-1967", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1968, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8243), true, 1, "Code-1968", "Model-1968", "Name-1968", "Spec-1968", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1969, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8248), false, 1, "Code-1969", "Model-1969", "Name-1969", "Spec-1969", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1970, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8254), true, 2, "Code-1970", "Model-1970", "Name-1970", "Spec-1970", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1971, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8258), false, 2, "Code-1971", "Model-1971", "Name-1971", "Spec-1971", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1972, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8310), true, 2, "Code-1972", "Model-1972", "Name-1972", "Spec-1972", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1973, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8316), false, 2, "Code-1973", "Model-1973", "Name-1973", "Spec-1973", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1974, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8322), true, 1, "Code-1974", "Model-1974", "Name-1974", "Spec-1974", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1975, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8326), false, 1, "Code-1975", "Model-1975", "Name-1975", "Spec-1975", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1976, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8332), true, 1, "Code-1976", "Model-1976", "Name-1976", "Spec-1976", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1977, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8336), false, 2, "Code-1977", "Model-1977", "Name-1977", "Spec-1977", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1978, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8343), true, 2, "Code-1978", "Model-1978", "Name-1978", "Spec-1978", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1979, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8347), false, 1, "Code-1979", "Model-1979", "Name-1979", "Spec-1979", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1980, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8353), true, 2, "Code-1980", "Model-1980", "Name-1980", "Spec-1980", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1981, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8357), false, 1, "Code-1981", "Model-1981", "Name-1981", "Spec-1981", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1982, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8363), true, 1, "Code-1982", "Model-1982", "Name-1982", "Spec-1982", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1983, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8368), false, 2, "Code-1983", "Model-1983", "Name-1983", "Spec-1983", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1984, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8374), true, 2, "Code-1984", "Model-1984", "Name-1984", "Spec-1984", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1985, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8378), false, 2, "Code-1985", "Model-1985", "Name-1985", "Spec-1985", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1986, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8384), true, 1, "Code-1986", "Model-1986", "Name-1986", "Spec-1986", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1987, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8389), false, 2, "Code-1987", "Model-1987", "Name-1987", "Spec-1987", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1988, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8396), true, 1, "Code-1988", "Model-1988", "Name-1988", "Spec-1988", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1989, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8400), false, 1, "Code-1989", "Model-1989", "Name-1989", "Spec-1989", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1990, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8406), true, 1, "Code-1990", "Model-1990", "Name-1990", "Spec-1990", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1991, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8410), false, 1, "Code-1991", "Model-1991", "Name-1991", "Spec-1991", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1992, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8416), true, 2, "Code-1992", "Model-1992", "Name-1992", "Spec-1992", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1993, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8455), false, 1, "Code-1993", "Model-1993", "Name-1993", "Spec-1993", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1994, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8462), true, 1, "Code-1994", "Model-1994", "Name-1994", "Spec-1994", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1995, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8466), false, 2, "Code-1995", "Model-1995", "Name-1995", "Spec-1995", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1996, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8472), true, 1, "Code-1996", "Model-1996", "Name-1996", "Spec-1996", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1997, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8476), false, 2, "Code-1997", "Model-1997", "Name-1997", "Spec-1997", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1998, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8482), true, 2, "Code-1998", "Model-1998", "Name-1998", "Spec-1998", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1999, new DateTime(2022, 4, 12, 2, 54, 26, 613, DateTimeKind.Utc).AddTicks(8486), false, 2, "Code-1999", "Model-1999", "Name-1999", "Spec-1999", 2, null });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialCode",
                table: "Materials",
                column: "MaterialCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
