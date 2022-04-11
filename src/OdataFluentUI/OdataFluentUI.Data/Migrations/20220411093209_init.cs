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

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1000, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6616), true, 2, "Code-1000", "Model-1000", "Name-1000", "Spec-1000", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1001, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6691), false, 2, "Code-1001", "Model-1001", "Name-1001", "Spec-1001", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1002, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6709), true, 1, "Code-1002", "Model-1002", "Name-1002", "Spec-1002", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1003, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6715), false, 1, "Code-1003", "Model-1003", "Name-1003", "Spec-1003", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1004, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6721), true, 1, "Code-1004", "Model-1004", "Name-1004", "Spec-1004", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1005, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6727), false, 1, "Code-1005", "Model-1005", "Name-1005", "Spec-1005", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1006, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6733), true, 2, "Code-1006", "Model-1006", "Name-1006", "Spec-1006", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1007, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6737), false, 1, "Code-1007", "Model-1007", "Name-1007", "Spec-1007", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1008, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6742), true, 2, "Code-1008", "Model-1008", "Name-1008", "Spec-1008", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1009, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6747), false, 2, "Code-1009", "Model-1009", "Name-1009", "Spec-1009", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1010, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6752), true, 2, "Code-1010", "Model-1010", "Name-1010", "Spec-1010", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1011, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6795), false, 1, "Code-1011", "Model-1011", "Name-1011", "Spec-1011", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1012, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6803), true, 1, "Code-1012", "Model-1012", "Name-1012", "Spec-1012", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1013, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6808), false, 1, "Code-1013", "Model-1013", "Name-1013", "Spec-1013", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1014, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6813), true, 2, "Code-1014", "Model-1014", "Name-1014", "Spec-1014", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1015, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6817), false, 2, "Code-1015", "Model-1015", "Name-1015", "Spec-1015", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1016, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6823), true, 1, "Code-1016", "Model-1016", "Name-1016", "Spec-1016", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1017, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6828), false, 1, "Code-1017", "Model-1017", "Name-1017", "Spec-1017", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1018, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6834), true, 2, "Code-1018", "Model-1018", "Name-1018", "Spec-1018", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1019, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6838), false, 1, "Code-1019", "Model-1019", "Name-1019", "Spec-1019", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1020, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6843), true, 1, "Code-1020", "Model-1020", "Name-1020", "Spec-1020", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1021, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6847), false, 1, "Code-1021", "Model-1021", "Name-1021", "Spec-1021", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1022, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6852), true, 1, "Code-1022", "Model-1022", "Name-1022", "Spec-1022", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1023, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6856), false, 2, "Code-1023", "Model-1023", "Name-1023", "Spec-1023", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1024, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6862), true, 1, "Code-1024", "Model-1024", "Name-1024", "Spec-1024", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1025, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6866), false, 2, "Code-1025", "Model-1025", "Name-1025", "Spec-1025", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1026, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6872), true, 1, "Code-1026", "Model-1026", "Name-1026", "Spec-1026", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1027, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6876), false, 2, "Code-1027", "Model-1027", "Name-1027", "Spec-1027", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1028, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6881), true, 1, "Code-1028", "Model-1028", "Name-1028", "Spec-1028", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1029, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6885), false, 2, "Code-1029", "Model-1029", "Name-1029", "Spec-1029", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1030, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6891), true, 2, "Code-1030", "Model-1030", "Name-1030", "Spec-1030", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1031, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6929), false, 1, "Code-1031", "Model-1031", "Name-1031", "Spec-1031", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1032, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6935), true, 1, "Code-1032", "Model-1032", "Name-1032", "Spec-1032", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1033, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6940), false, 2, "Code-1033", "Model-1033", "Name-1033", "Spec-1033", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1034, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6946), true, 2, "Code-1034", "Model-1034", "Name-1034", "Spec-1034", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1035, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6950), false, 2, "Code-1035", "Model-1035", "Name-1035", "Spec-1035", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1036, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6955), true, 2, "Code-1036", "Model-1036", "Name-1036", "Spec-1036", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1037, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6959), false, 1, "Code-1037", "Model-1037", "Name-1037", "Spec-1037", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1038, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6965), true, 2, "Code-1038", "Model-1038", "Name-1038", "Spec-1038", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1039, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6969), false, 1, "Code-1039", "Model-1039", "Name-1039", "Spec-1039", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1040, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6977), true, 2, "Code-1040", "Model-1040", "Name-1040", "Spec-1040", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1041, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6981), false, 2, "Code-1041", "Model-1041", "Name-1041", "Spec-1041", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1042, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6986), true, 1, "Code-1042", "Model-1042", "Name-1042", "Spec-1042", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1043, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6990), false, 1, "Code-1043", "Model-1043", "Name-1043", "Spec-1043", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1044, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6995), true, 1, "Code-1044", "Model-1044", "Name-1044", "Spec-1044", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1045, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(6999), false, 2, "Code-1045", "Model-1045", "Name-1045", "Spec-1045", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1046, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7005), true, 1, "Code-1046", "Model-1046", "Name-1046", "Spec-1046", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1047, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7009), false, 2, "Code-1047", "Model-1047", "Name-1047", "Spec-1047", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1048, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7015), true, 2, "Code-1048", "Model-1048", "Name-1048", "Spec-1048", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1049, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7019), false, 2, "Code-1049", "Model-1049", "Name-1049", "Spec-1049", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1050, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7061), true, 2, "Code-1050", "Model-1050", "Name-1050", "Spec-1050", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1051, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7066), false, 2, "Code-1051", "Model-1051", "Name-1051", "Spec-1051", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1052, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7071), true, 2, "Code-1052", "Model-1052", "Name-1052", "Spec-1052", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1053, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7075), false, 1, "Code-1053", "Model-1053", "Name-1053", "Spec-1053", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1054, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7080), true, 1, "Code-1054", "Model-1054", "Name-1054", "Spec-1054", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1055, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7085), false, 1, "Code-1055", "Model-1055", "Name-1055", "Spec-1055", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1056, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7090), true, 1, "Code-1056", "Model-1056", "Name-1056", "Spec-1056", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1057, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7094), false, 1, "Code-1057", "Model-1057", "Name-1057", "Spec-1057", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1058, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7100), true, 1, "Code-1058", "Model-1058", "Name-1058", "Spec-1058", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1059, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7103), false, 1, "Code-1059", "Model-1059", "Name-1059", "Spec-1059", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1060, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7109), true, 1, "Code-1060", "Model-1060", "Name-1060", "Spec-1060", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1061, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7113), false, 1, "Code-1061", "Model-1061", "Name-1061", "Spec-1061", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1062, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7118), true, 1, "Code-1062", "Model-1062", "Name-1062", "Spec-1062", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1063, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7122), false, 1, "Code-1063", "Model-1063", "Name-1063", "Spec-1063", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1064, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7128), true, 1, "Code-1064", "Model-1064", "Name-1064", "Spec-1064", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1065, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7134), false, 2, "Code-1065", "Model-1065", "Name-1065", "Spec-1065", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1066, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7139), true, 1, "Code-1066", "Model-1066", "Name-1066", "Spec-1066", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1067, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7143), false, 1, "Code-1067", "Model-1067", "Name-1067", "Spec-1067", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1068, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7206), true, 2, "Code-1068", "Model-1068", "Name-1068", "Spec-1068", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1069, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7211), false, 1, "Code-1069", "Model-1069", "Name-1069", "Spec-1069", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1070, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7216), true, 2, "Code-1070", "Model-1070", "Name-1070", "Spec-1070", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1071, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7220), false, 2, "Code-1071", "Model-1071", "Name-1071", "Spec-1071", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1072, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7226), true, 2, "Code-1072", "Model-1072", "Name-1072", "Spec-1072", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1073, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7230), false, 1, "Code-1073", "Model-1073", "Name-1073", "Spec-1073", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1074, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7235), true, 2, "Code-1074", "Model-1074", "Name-1074", "Spec-1074", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1075, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7239), false, 1, "Code-1075", "Model-1075", "Name-1075", "Spec-1075", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1076, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7245), true, 1, "Code-1076", "Model-1076", "Name-1076", "Spec-1076", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1077, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7249), false, 1, "Code-1077", "Model-1077", "Name-1077", "Spec-1077", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1078, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7254), true, 1, "Code-1078", "Model-1078", "Name-1078", "Spec-1078", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1079, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7258), false, 1, "Code-1079", "Model-1079", "Name-1079", "Spec-1079", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1080, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7264), true, 1, "Code-1080", "Model-1080", "Name-1080", "Spec-1080", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1081, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7268), false, 1, "Code-1081", "Model-1081", "Name-1081", "Spec-1081", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1082, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7273), true, 1, "Code-1082", "Model-1082", "Name-1082", "Spec-1082", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1083, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7277), false, 2, "Code-1083", "Model-1083", "Name-1083", "Spec-1083", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1084, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7283), true, 2, "Code-1084", "Model-1084", "Name-1084", "Spec-1084", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1085, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7287), false, 2, "Code-1085", "Model-1085", "Name-1085", "Spec-1085", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1086, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7292), true, 2, "Code-1086", "Model-1086", "Name-1086", "Spec-1086", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1087, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7296), false, 2, "Code-1087", "Model-1087", "Name-1087", "Spec-1087", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1088, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7336), true, 1, "Code-1088", "Model-1088", "Name-1088", "Spec-1088", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1089, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7341), false, 1, "Code-1089", "Model-1089", "Name-1089", "Spec-1089", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1090, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7347), true, 1, "Code-1090", "Model-1090", "Name-1090", "Spec-1090", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1091, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7352), false, 1, "Code-1091", "Model-1091", "Name-1091", "Spec-1091", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1092, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7357), true, 2, "Code-1092", "Model-1092", "Name-1092", "Spec-1092", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1093, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7361), false, 1, "Code-1093", "Model-1093", "Name-1093", "Spec-1093", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1094, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7367), true, 2, "Code-1094", "Model-1094", "Name-1094", "Spec-1094", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1095, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7371), false, 1, "Code-1095", "Model-1095", "Name-1095", "Spec-1095", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1096, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7376), true, 2, "Code-1096", "Model-1096", "Name-1096", "Spec-1096", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1097, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7380), false, 2, "Code-1097", "Model-1097", "Name-1097", "Spec-1097", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1098, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7385), true, 2, "Code-1098", "Model-1098", "Name-1098", "Spec-1098", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1099, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7389), false, 1, "Code-1099", "Model-1099", "Name-1099", "Spec-1099", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1100, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7395), true, 1, "Code-1100", "Model-1100", "Name-1100", "Spec-1100", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1101, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7399), false, 2, "Code-1101", "Model-1101", "Name-1101", "Spec-1101", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1102, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7404), true, 1, "Code-1102", "Model-1102", "Name-1102", "Spec-1102", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1103, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7408), false, 2, "Code-1103", "Model-1103", "Name-1103", "Spec-1103", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1104, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7413), true, 2, "Code-1104", "Model-1104", "Name-1104", "Spec-1104", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1105, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7417), false, 2, "Code-1105", "Model-1105", "Name-1105", "Spec-1105", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1106, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7422), true, 1, "Code-1106", "Model-1106", "Name-1106", "Spec-1106", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1107, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7426), false, 1, "Code-1107", "Model-1107", "Name-1107", "Spec-1107", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1108, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7432), true, 2, "Code-1108", "Model-1108", "Name-1108", "Spec-1108", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1109, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7470), false, 1, "Code-1109", "Model-1109", "Name-1109", "Spec-1109", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1110, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7476), true, 2, "Code-1110", "Model-1110", "Name-1110", "Spec-1110", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1111, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7480), false, 2, "Code-1111", "Model-1111", "Name-1111", "Spec-1111", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1112, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7486), true, 2, "Code-1112", "Model-1112", "Name-1112", "Spec-1112", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1113, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7489), false, 2, "Code-1113", "Model-1113", "Name-1113", "Spec-1113", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1114, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7495), true, 2, "Code-1114", "Model-1114", "Name-1114", "Spec-1114", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1115, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7499), false, 2, "Code-1115", "Model-1115", "Name-1115", "Spec-1115", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1116, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7505), true, 1, "Code-1116", "Model-1116", "Name-1116", "Spec-1116", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1117, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7508), false, 2, "Code-1117", "Model-1117", "Name-1117", "Spec-1117", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1118, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7514), true, 2, "Code-1118", "Model-1118", "Name-1118", "Spec-1118", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1119, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7519), false, 1, "Code-1119", "Model-1119", "Name-1119", "Spec-1119", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1120, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7524), true, 1, "Code-1120", "Model-1120", "Name-1120", "Spec-1120", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1121, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7528), false, 2, "Code-1121", "Model-1121", "Name-1121", "Spec-1121", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1122, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7533), true, 2, "Code-1122", "Model-1122", "Name-1122", "Spec-1122", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1123, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7537), false, 1, "Code-1123", "Model-1123", "Name-1123", "Spec-1123", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1124, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7542), true, 1, "Code-1124", "Model-1124", "Name-1124", "Spec-1124", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1125, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7546), false, 1, "Code-1125", "Model-1125", "Name-1125", "Spec-1125", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1126, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7552), true, 1, "Code-1126", "Model-1126", "Name-1126", "Spec-1126", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1127, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7556), false, 2, "Code-1127", "Model-1127", "Name-1127", "Spec-1127", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1128, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7561), true, 2, "Code-1128", "Model-1128", "Name-1128", "Spec-1128", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1129, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7600), false, 1, "Code-1129", "Model-1129", "Name-1129", "Spec-1129", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1130, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7606), true, 2, "Code-1130", "Model-1130", "Name-1130", "Spec-1130", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1131, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7610), false, 2, "Code-1131", "Model-1131", "Name-1131", "Spec-1131", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1132, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7616), true, 2, "Code-1132", "Model-1132", "Name-1132", "Spec-1132", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1133, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7619), false, 1, "Code-1133", "Model-1133", "Name-1133", "Spec-1133", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1134, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7625), true, 2, "Code-1134", "Model-1134", "Name-1134", "Spec-1134", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1135, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7629), false, 1, "Code-1135", "Model-1135", "Name-1135", "Spec-1135", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1136, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7634), true, 1, "Code-1136", "Model-1136", "Name-1136", "Spec-1136", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1137, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7638), false, 2, "Code-1137", "Model-1137", "Name-1137", "Spec-1137", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1138, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7643), true, 2, "Code-1138", "Model-1138", "Name-1138", "Spec-1138", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1139, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7647), false, 1, "Code-1139", "Model-1139", "Name-1139", "Spec-1139", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1140, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7653), true, 2, "Code-1140", "Model-1140", "Name-1140", "Spec-1140", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1141, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7658), false, 1, "Code-1141", "Model-1141", "Name-1141", "Spec-1141", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1142, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7663), true, 1, "Code-1142", "Model-1142", "Name-1142", "Spec-1142", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1143, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7667), false, 1, "Code-1143", "Model-1143", "Name-1143", "Spec-1143", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1144, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7705), true, 2, "Code-1144", "Model-1144", "Name-1144", "Spec-1144", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1145, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7710), false, 1, "Code-1145", "Model-1145", "Name-1145", "Spec-1145", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1146, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7716), true, 1, "Code-1146", "Model-1146", "Name-1146", "Spec-1146", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1147, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7720), false, 2, "Code-1147", "Model-1147", "Name-1147", "Spec-1147", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1148, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7726), true, 1, "Code-1148", "Model-1148", "Name-1148", "Spec-1148", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1149, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7729), false, 1, "Code-1149", "Model-1149", "Name-1149", "Spec-1149", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1150, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7735), true, 2, "Code-1150", "Model-1150", "Name-1150", "Spec-1150", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1151, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7739), false, 2, "Code-1151", "Model-1151", "Name-1151", "Spec-1151", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1152, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7744), true, 2, "Code-1152", "Model-1152", "Name-1152", "Spec-1152", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1153, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7748), false, 2, "Code-1153", "Model-1153", "Name-1153", "Spec-1153", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1154, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7753), true, 2, "Code-1154", "Model-1154", "Name-1154", "Spec-1154", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1155, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7758), false, 1, "Code-1155", "Model-1155", "Name-1155", "Spec-1155", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1156, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7763), true, 2, "Code-1156", "Model-1156", "Name-1156", "Spec-1156", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1157, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7767), false, 1, "Code-1157", "Model-1157", "Name-1157", "Spec-1157", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1158, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7772), true, 1, "Code-1158", "Model-1158", "Name-1158", "Spec-1158", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1159, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7776), false, 2, "Code-1159", "Model-1159", "Name-1159", "Spec-1159", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1160, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7781), true, 2, "Code-1160", "Model-1160", "Name-1160", "Spec-1160", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1161, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7785), false, 2, "Code-1161", "Model-1161", "Name-1161", "Spec-1161", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1162, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7790), true, 2, "Code-1162", "Model-1162", "Name-1162", "Spec-1162", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1163, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7795), false, 2, "Code-1163", "Model-1163", "Name-1163", "Spec-1163", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1164, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7800), true, 1, "Code-1164", "Model-1164", "Name-1164", "Spec-1164", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1165, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7839), false, 1, "Code-1165", "Model-1165", "Name-1165", "Spec-1165", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1166, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7845), true, 1, "Code-1166", "Model-1166", "Name-1166", "Spec-1166", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1167, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7849), false, 2, "Code-1167", "Model-1167", "Name-1167", "Spec-1167", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1168, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7854), true, 1, "Code-1168", "Model-1168", "Name-1168", "Spec-1168", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1169, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7858), false, 1, "Code-1169", "Model-1169", "Name-1169", "Spec-1169", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1170, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7864), true, 2, "Code-1170", "Model-1170", "Name-1170", "Spec-1170", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1171, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7868), false, 1, "Code-1171", "Model-1171", "Name-1171", "Spec-1171", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1172, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7873), true, 2, "Code-1172", "Model-1172", "Name-1172", "Spec-1172", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1173, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7877), false, 1, "Code-1173", "Model-1173", "Name-1173", "Spec-1173", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1174, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7882), true, 1, "Code-1174", "Model-1174", "Name-1174", "Spec-1174", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1175, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7887), false, 1, "Code-1175", "Model-1175", "Name-1175", "Spec-1175", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1176, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7893), true, 1, "Code-1176", "Model-1176", "Name-1176", "Spec-1176", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1177, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7897), false, 1, "Code-1177", "Model-1177", "Name-1177", "Spec-1177", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1178, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7902), true, 1, "Code-1178", "Model-1178", "Name-1178", "Spec-1178", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1179, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7906), false, 1, "Code-1179", "Model-1179", "Name-1179", "Spec-1179", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1180, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7911), true, 2, "Code-1180", "Model-1180", "Name-1180", "Spec-1180", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1181, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7915), false, 1, "Code-1181", "Model-1181", "Name-1181", "Spec-1181", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1182, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7921), true, 1, "Code-1182", "Model-1182", "Name-1182", "Spec-1182", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1183, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7925), false, 1, "Code-1183", "Model-1183", "Name-1183", "Spec-1183", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1184, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7930), true, 1, "Code-1184", "Model-1184", "Name-1184", "Spec-1184", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1185, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7968), false, 1, "Code-1185", "Model-1185", "Name-1185", "Spec-1185", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1186, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7974), true, 1, "Code-1186", "Model-1186", "Name-1186", "Spec-1186", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1187, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7978), false, 2, "Code-1187", "Model-1187", "Name-1187", "Spec-1187", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1188, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7983), true, 2, "Code-1188", "Model-1188", "Name-1188", "Spec-1188", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1189, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7987), false, 2, "Code-1189", "Model-1189", "Name-1189", "Spec-1189", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1190, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7993), true, 1, "Code-1190", "Model-1190", "Name-1190", "Spec-1190", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1191, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(7997), false, 2, "Code-1191", "Model-1191", "Name-1191", "Spec-1191", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1192, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8002), true, 2, "Code-1192", "Model-1192", "Name-1192", "Spec-1192", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1193, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8006), false, 2, "Code-1193", "Model-1193", "Name-1193", "Spec-1193", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1194, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8012), true, 2, "Code-1194", "Model-1194", "Name-1194", "Spec-1194", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1195, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8015), false, 1, "Code-1195", "Model-1195", "Name-1195", "Spec-1195", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1196, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8021), true, 2, "Code-1196", "Model-1196", "Name-1196", "Spec-1196", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1197, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8025), false, 2, "Code-1197", "Model-1197", "Name-1197", "Spec-1197", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1198, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8030), true, 2, "Code-1198", "Model-1198", "Name-1198", "Spec-1198", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1199, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8034), false, 2, "Code-1199", "Model-1199", "Name-1199", "Spec-1199", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1200, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8039), true, 1, "Code-1200", "Model-1200", "Name-1200", "Spec-1200", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1201, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8043), false, 2, "Code-1201", "Model-1201", "Name-1201", "Spec-1201", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1202, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8048), true, 1, "Code-1202", "Model-1202", "Name-1202", "Spec-1202", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1203, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8052), false, 2, "Code-1203", "Model-1203", "Name-1203", "Spec-1203", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1204, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8058), true, 2, "Code-1204", "Model-1204", "Name-1204", "Spec-1204", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1205, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8061), false, 1, "Code-1205", "Model-1205", "Name-1205", "Spec-1205", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1206, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8102), true, 1, "Code-1206", "Model-1206", "Name-1206", "Spec-1206", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1207, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8106), false, 2, "Code-1207", "Model-1207", "Name-1207", "Spec-1207", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1208, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8112), true, 1, "Code-1208", "Model-1208", "Name-1208", "Spec-1208", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1209, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8116), false, 2, "Code-1209", "Model-1209", "Name-1209", "Spec-1209", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1210, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8121), true, 1, "Code-1210", "Model-1210", "Name-1210", "Spec-1210", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1211, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8125), false, 2, "Code-1211", "Model-1211", "Name-1211", "Spec-1211", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1212, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8131), true, 2, "Code-1212", "Model-1212", "Name-1212", "Spec-1212", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1213, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8135), false, 2, "Code-1213", "Model-1213", "Name-1213", "Spec-1213", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1214, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8140), true, 1, "Code-1214", "Model-1214", "Name-1214", "Spec-1214", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1215, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8144), false, 2, "Code-1215", "Model-1215", "Name-1215", "Spec-1215", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1216, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8150), true, 2, "Code-1216", "Model-1216", "Name-1216", "Spec-1216", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1217, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8154), false, 1, "Code-1217", "Model-1217", "Name-1217", "Spec-1217", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1218, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8159), true, 1, "Code-1218", "Model-1218", "Name-1218", "Spec-1218", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1219, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8163), false, 2, "Code-1219", "Model-1219", "Name-1219", "Spec-1219", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1220, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8168), true, 1, "Code-1220", "Model-1220", "Name-1220", "Spec-1220", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1221, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8172), false, 1, "Code-1221", "Model-1221", "Name-1221", "Spec-1221", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1222, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8178), true, 1, "Code-1222", "Model-1222", "Name-1222", "Spec-1222", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1223, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8182), false, 2, "Code-1223", "Model-1223", "Name-1223", "Spec-1223", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1224, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8187), true, 1, "Code-1224", "Model-1224", "Name-1224", "Spec-1224", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1225, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8191), false, 1, "Code-1225", "Model-1225", "Name-1225", "Spec-1225", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1226, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8245), true, 1, "Code-1226", "Model-1226", "Name-1226", "Spec-1226", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1227, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8249), false, 1, "Code-1227", "Model-1227", "Name-1227", "Spec-1227", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1228, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8255), true, 1, "Code-1228", "Model-1228", "Name-1228", "Spec-1228", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1229, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8259), false, 2, "Code-1229", "Model-1229", "Name-1229", "Spec-1229", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1230, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8265), true, 2, "Code-1230", "Model-1230", "Name-1230", "Spec-1230", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1231, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8269), false, 2, "Code-1231", "Model-1231", "Name-1231", "Spec-1231", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1232, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8275), true, 1, "Code-1232", "Model-1232", "Name-1232", "Spec-1232", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1233, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8279), false, 1, "Code-1233", "Model-1233", "Name-1233", "Spec-1233", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1234, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8285), true, 1, "Code-1234", "Model-1234", "Name-1234", "Spec-1234", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1235, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8289), false, 1, "Code-1235", "Model-1235", "Name-1235", "Spec-1235", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1236, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8294), true, 1, "Code-1236", "Model-1236", "Name-1236", "Spec-1236", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1237, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8298), false, 2, "Code-1237", "Model-1237", "Name-1237", "Spec-1237", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1238, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8304), true, 2, "Code-1238", "Model-1238", "Name-1238", "Spec-1238", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1239, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8308), false, 2, "Code-1239", "Model-1239", "Name-1239", "Spec-1239", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1240, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8313), true, 2, "Code-1240", "Model-1240", "Name-1240", "Spec-1240", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1241, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8317), false, 1, "Code-1241", "Model-1241", "Name-1241", "Spec-1241", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1242, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8323), true, 1, "Code-1242", "Model-1242", "Name-1242", "Spec-1242", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1243, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8327), false, 1, "Code-1243", "Model-1243", "Name-1243", "Spec-1243", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1244, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8332), true, 1, "Code-1244", "Model-1244", "Name-1244", "Spec-1244", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1245, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8336), false, 1, "Code-1245", "Model-1245", "Name-1245", "Spec-1245", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1246, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8374), true, 1, "Code-1246", "Model-1246", "Name-1246", "Spec-1246", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1247, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8379), false, 2, "Code-1247", "Model-1247", "Name-1247", "Spec-1247", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1248, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8385), true, 2, "Code-1248", "Model-1248", "Name-1248", "Spec-1248", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1249, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8389), false, 1, "Code-1249", "Model-1249", "Name-1249", "Spec-1249", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1250, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8395), true, 1, "Code-1250", "Model-1250", "Name-1250", "Spec-1250", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1251, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8398), false, 1, "Code-1251", "Model-1251", "Name-1251", "Spec-1251", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1252, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8404), true, 2, "Code-1252", "Model-1252", "Name-1252", "Spec-1252", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1253, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8408), false, 1, "Code-1253", "Model-1253", "Name-1253", "Spec-1253", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1254, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8413), true, 2, "Code-1254", "Model-1254", "Name-1254", "Spec-1254", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1255, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8417), false, 2, "Code-1255", "Model-1255", "Name-1255", "Spec-1255", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1256, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8422), true, 1, "Code-1256", "Model-1256", "Name-1256", "Spec-1256", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1257, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8461), false, 2, "Code-1257", "Model-1257", "Name-1257", "Spec-1257", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1258, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8467), true, 1, "Code-1258", "Model-1258", "Name-1258", "Spec-1258", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1259, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8472), false, 1, "Code-1259", "Model-1259", "Name-1259", "Spec-1259", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1260, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8478), true, 1, "Code-1260", "Model-1260", "Name-1260", "Spec-1260", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1261, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8482), false, 2, "Code-1261", "Model-1261", "Name-1261", "Spec-1261", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1262, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8487), true, 2, "Code-1262", "Model-1262", "Name-1262", "Spec-1262", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1263, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8491), false, 2, "Code-1263", "Model-1263", "Name-1263", "Spec-1263", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1264, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8496), true, 1, "Code-1264", "Model-1264", "Name-1264", "Spec-1264", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1265, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8500), false, 1, "Code-1265", "Model-1265", "Name-1265", "Spec-1265", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1266, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8506), true, 1, "Code-1266", "Model-1266", "Name-1266", "Spec-1266", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1267, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8510), false, 1, "Code-1267", "Model-1267", "Name-1267", "Spec-1267", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1268, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8516), true, 2, "Code-1268", "Model-1268", "Name-1268", "Spec-1268", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1269, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8520), false, 2, "Code-1269", "Model-1269", "Name-1269", "Spec-1269", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1270, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8525), true, 2, "Code-1270", "Model-1270", "Name-1270", "Spec-1270", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1271, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8529), false, 2, "Code-1271", "Model-1271", "Name-1271", "Spec-1271", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1272, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8535), true, 2, "Code-1272", "Model-1272", "Name-1272", "Spec-1272", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1273, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8539), false, 2, "Code-1273", "Model-1273", "Name-1273", "Spec-1273", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1274, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8544), true, 2, "Code-1274", "Model-1274", "Name-1274", "Spec-1274", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1275, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8548), false, 2, "Code-1275", "Model-1275", "Name-1275", "Spec-1275", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1276, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8554), true, 2, "Code-1276", "Model-1276", "Name-1276", "Spec-1276", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1277, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8594), false, 2, "Code-1277", "Model-1277", "Name-1277", "Spec-1277", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1278, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8601), true, 2, "Code-1278", "Model-1278", "Name-1278", "Spec-1278", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1279, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8605), false, 2, "Code-1279", "Model-1279", "Name-1279", "Spec-1279", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1280, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8610), true, 2, "Code-1280", "Model-1280", "Name-1280", "Spec-1280", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1281, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8614), false, 2, "Code-1281", "Model-1281", "Name-1281", "Spec-1281", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1282, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8620), true, 1, "Code-1282", "Model-1282", "Name-1282", "Spec-1282", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1283, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8624), false, 1, "Code-1283", "Model-1283", "Name-1283", "Spec-1283", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1284, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8630), true, 1, "Code-1284", "Model-1284", "Name-1284", "Spec-1284", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1285, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8633), false, 2, "Code-1285", "Model-1285", "Name-1285", "Spec-1285", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1286, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8639), true, 1, "Code-1286", "Model-1286", "Name-1286", "Spec-1286", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1287, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8643), false, 1, "Code-1287", "Model-1287", "Name-1287", "Spec-1287", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1288, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8649), true, 1, "Code-1288", "Model-1288", "Name-1288", "Spec-1288", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1289, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8653), false, 2, "Code-1289", "Model-1289", "Name-1289", "Spec-1289", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1290, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8659), true, 2, "Code-1290", "Model-1290", "Name-1290", "Spec-1290", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1291, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8663), false, 2, "Code-1291", "Model-1291", "Name-1291", "Spec-1291", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1292, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8668), true, 2, "Code-1292", "Model-1292", "Name-1292", "Spec-1292", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1293, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8672), false, 2, "Code-1293", "Model-1293", "Name-1293", "Spec-1293", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1294, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8677), true, 2, "Code-1294", "Model-1294", "Name-1294", "Spec-1294", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1295, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8681), false, 1, "Code-1295", "Model-1295", "Name-1295", "Spec-1295", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1296, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8686), true, 2, "Code-1296", "Model-1296", "Name-1296", "Spec-1296", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1297, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8724), false, 1, "Code-1297", "Model-1297", "Name-1297", "Spec-1297", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1298, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8730), true, 1, "Code-1298", "Model-1298", "Name-1298", "Spec-1298", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1299, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8735), false, 2, "Code-1299", "Model-1299", "Name-1299", "Spec-1299", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1300, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8740), true, 2, "Code-1300", "Model-1300", "Name-1300", "Spec-1300", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1301, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8744), false, 2, "Code-1301", "Model-1301", "Name-1301", "Spec-1301", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1302, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8749), true, 1, "Code-1302", "Model-1302", "Name-1302", "Spec-1302", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1303, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8753), false, 2, "Code-1303", "Model-1303", "Name-1303", "Spec-1303", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1304, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8759), true, 1, "Code-1304", "Model-1304", "Name-1304", "Spec-1304", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1305, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8762), false, 1, "Code-1305", "Model-1305", "Name-1305", "Spec-1305", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1306, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8768), true, 2, "Code-1306", "Model-1306", "Name-1306", "Spec-1306", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1307, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8772), false, 1, "Code-1307", "Model-1307", "Name-1307", "Spec-1307", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1308, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8777), true, 2, "Code-1308", "Model-1308", "Name-1308", "Spec-1308", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1309, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8781), false, 1, "Code-1309", "Model-1309", "Name-1309", "Spec-1309", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1310, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8786), true, 1, "Code-1310", "Model-1310", "Name-1310", "Spec-1310", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1311, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8790), false, 1, "Code-1311", "Model-1311", "Name-1311", "Spec-1311", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1312, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8796), true, 1, "Code-1312", "Model-1312", "Name-1312", "Spec-1312", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1313, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8800), false, 2, "Code-1313", "Model-1313", "Name-1313", "Spec-1313", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1314, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8805), true, 1, "Code-1314", "Model-1314", "Name-1314", "Spec-1314", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1315, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8809), false, 2, "Code-1315", "Model-1315", "Name-1315", "Spec-1315", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1316, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8814), true, 2, "Code-1316", "Model-1316", "Name-1316", "Spec-1316", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1317, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8818), false, 2, "Code-1317", "Model-1317", "Name-1317", "Spec-1317", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1318, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8858), true, 1, "Code-1318", "Model-1318", "Name-1318", "Spec-1318", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1319, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8863), false, 2, "Code-1319", "Model-1319", "Name-1319", "Spec-1319", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1320, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8868), true, 2, "Code-1320", "Model-1320", "Name-1320", "Spec-1320", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1321, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8872), false, 1, "Code-1321", "Model-1321", "Name-1321", "Spec-1321", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1322, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8878), true, 1, "Code-1322", "Model-1322", "Name-1322", "Spec-1322", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1323, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8882), false, 2, "Code-1323", "Model-1323", "Name-1323", "Spec-1323", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1324, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8887), true, 2, "Code-1324", "Model-1324", "Name-1324", "Spec-1324", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1325, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8892), false, 1, "Code-1325", "Model-1325", "Name-1325", "Spec-1325", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1326, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8897), true, 2, "Code-1326", "Model-1326", "Name-1326", "Spec-1326", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1327, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8902), false, 1, "Code-1327", "Model-1327", "Name-1327", "Spec-1327", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1328, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8907), true, 2, "Code-1328", "Model-1328", "Name-1328", "Spec-1328", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1329, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8911), false, 1, "Code-1329", "Model-1329", "Name-1329", "Spec-1329", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1330, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8917), true, 2, "Code-1330", "Model-1330", "Name-1330", "Spec-1330", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1331, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8920), false, 1, "Code-1331", "Model-1331", "Name-1331", "Spec-1331", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1332, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8926), true, 2, "Code-1332", "Model-1332", "Name-1332", "Spec-1332", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1333, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8930), false, 1, "Code-1333", "Model-1333", "Name-1333", "Spec-1333", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1334, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8936), true, 1, "Code-1334", "Model-1334", "Name-1334", "Spec-1334", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1335, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8940), false, 1, "Code-1335", "Model-1335", "Name-1335", "Spec-1335", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1336, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8945), true, 1, "Code-1336", "Model-1336", "Name-1336", "Spec-1336", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1337, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8949), false, 2, "Code-1337", "Model-1337", "Name-1337", "Spec-1337", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1338, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8989), true, 2, "Code-1338", "Model-1338", "Name-1338", "Spec-1338", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1339, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8994), false, 1, "Code-1339", "Model-1339", "Name-1339", "Spec-1339", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1340, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(8999), true, 2, "Code-1340", "Model-1340", "Name-1340", "Spec-1340", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1341, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9004), false, 2, "Code-1341", "Model-1341", "Name-1341", "Spec-1341", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1342, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9009), true, 1, "Code-1342", "Model-1342", "Name-1342", "Spec-1342", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1343, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9013), false, 2, "Code-1343", "Model-1343", "Name-1343", "Spec-1343", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1344, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9018), true, 2, "Code-1344", "Model-1344", "Name-1344", "Spec-1344", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1345, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9022), false, 2, "Code-1345", "Model-1345", "Name-1345", "Spec-1345", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1346, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9028), true, 2, "Code-1346", "Model-1346", "Name-1346", "Spec-1346", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1347, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9032), false, 2, "Code-1347", "Model-1347", "Name-1347", "Spec-1347", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1348, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9037), true, 1, "Code-1348", "Model-1348", "Name-1348", "Spec-1348", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1349, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9041), false, 2, "Code-1349", "Model-1349", "Name-1349", "Spec-1349", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1350, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9047), true, 2, "Code-1350", "Model-1350", "Name-1350", "Spec-1350", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1351, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9051), false, 1, "Code-1351", "Model-1351", "Name-1351", "Spec-1351", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1352, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9056), true, 2, "Code-1352", "Model-1352", "Name-1352", "Spec-1352", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1353, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9060), false, 1, "Code-1353", "Model-1353", "Name-1353", "Spec-1353", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1354, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9066), true, 1, "Code-1354", "Model-1354", "Name-1354", "Spec-1354", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1355, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9070), false, 1, "Code-1355", "Model-1355", "Name-1355", "Spec-1355", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1356, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9075), true, 1, "Code-1356", "Model-1356", "Name-1356", "Spec-1356", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1357, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9079), false, 1, "Code-1357", "Model-1357", "Name-1357", "Spec-1357", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1358, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9085), true, 1, "Code-1358", "Model-1358", "Name-1358", "Spec-1358", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1359, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9122), false, 2, "Code-1359", "Model-1359", "Name-1359", "Spec-1359", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1360, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9129), true, 1, "Code-1360", "Model-1360", "Name-1360", "Spec-1360", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1361, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9133), false, 2, "Code-1361", "Model-1361", "Name-1361", "Spec-1361", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1362, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9138), true, 1, "Code-1362", "Model-1362", "Name-1362", "Spec-1362", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1363, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9142), false, 2, "Code-1363", "Model-1363", "Name-1363", "Spec-1363", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1364, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9147), true, 2, "Code-1364", "Model-1364", "Name-1364", "Spec-1364", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1365, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9151), false, 2, "Code-1365", "Model-1365", "Name-1365", "Spec-1365", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1366, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9157), true, 1, "Code-1366", "Model-1366", "Name-1366", "Spec-1366", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1367, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9161), false, 2, "Code-1367", "Model-1367", "Name-1367", "Spec-1367", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1368, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9166), true, 2, "Code-1368", "Model-1368", "Name-1368", "Spec-1368", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1369, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9170), false, 2, "Code-1369", "Model-1369", "Name-1369", "Spec-1369", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1370, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9176), true, 2, "Code-1370", "Model-1370", "Name-1370", "Spec-1370", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1371, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9180), false, 1, "Code-1371", "Model-1371", "Name-1371", "Spec-1371", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1372, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9185), true, 1, "Code-1372", "Model-1372", "Name-1372", "Spec-1372", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1373, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9189), false, 2, "Code-1373", "Model-1373", "Name-1373", "Spec-1373", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1374, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9194), true, 1, "Code-1374", "Model-1374", "Name-1374", "Spec-1374", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1375, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9198), false, 2, "Code-1375", "Model-1375", "Name-1375", "Spec-1375", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1376, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9203), true, 2, "Code-1376", "Model-1376", "Name-1376", "Spec-1376", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1377, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9207), false, 2, "Code-1377", "Model-1377", "Name-1377", "Spec-1377", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1378, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9213), true, 1, "Code-1378", "Model-1378", "Name-1378", "Spec-1378", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1379, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9297), false, 2, "Code-1379", "Model-1379", "Name-1379", "Spec-1379", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1380, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9303), true, 2, "Code-1380", "Model-1380", "Name-1380", "Spec-1380", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1381, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9307), false, 1, "Code-1381", "Model-1381", "Name-1381", "Spec-1381", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1382, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9313), true, 1, "Code-1382", "Model-1382", "Name-1382", "Spec-1382", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1383, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9317), false, 2, "Code-1383", "Model-1383", "Name-1383", "Spec-1383", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1384, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9323), true, 2, "Code-1384", "Model-1384", "Name-1384", "Spec-1384", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1385, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9327), false, 1, "Code-1385", "Model-1385", "Name-1385", "Spec-1385", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1386, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9332), true, 2, "Code-1386", "Model-1386", "Name-1386", "Spec-1386", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1387, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9336), false, 1, "Code-1387", "Model-1387", "Name-1387", "Spec-1387", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1388, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9341), true, 1, "Code-1388", "Model-1388", "Name-1388", "Spec-1388", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1389, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9345), false, 1, "Code-1389", "Model-1389", "Name-1389", "Spec-1389", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1390, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9351), true, 1, "Code-1390", "Model-1390", "Name-1390", "Spec-1390", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1391, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9355), false, 1, "Code-1391", "Model-1391", "Name-1391", "Spec-1391", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1392, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9360), true, 1, "Code-1392", "Model-1392", "Name-1392", "Spec-1392", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1393, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9364), false, 2, "Code-1393", "Model-1393", "Name-1393", "Spec-1393", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1394, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9369), true, 2, "Code-1394", "Model-1394", "Name-1394", "Spec-1394", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1395, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9373), false, 2, "Code-1395", "Model-1395", "Name-1395", "Spec-1395", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1396, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9379), true, 1, "Code-1396", "Model-1396", "Name-1396", "Spec-1396", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1397, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9383), false, 1, "Code-1397", "Model-1397", "Name-1397", "Spec-1397", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1398, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9388), true, 1, "Code-1398", "Model-1398", "Name-1398", "Spec-1398", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1399, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9425), false, 2, "Code-1399", "Model-1399", "Name-1399", "Spec-1399", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1400, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9433), true, 1, "Code-1400", "Model-1400", "Name-1400", "Spec-1400", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1401, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9437), false, 2, "Code-1401", "Model-1401", "Name-1401", "Spec-1401", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1402, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9442), true, 2, "Code-1402", "Model-1402", "Name-1402", "Spec-1402", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1403, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9446), false, 1, "Code-1403", "Model-1403", "Name-1403", "Spec-1403", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1404, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9452), true, 1, "Code-1404", "Model-1404", "Name-1404", "Spec-1404", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1405, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9455), false, 1, "Code-1405", "Model-1405", "Name-1405", "Spec-1405", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1406, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9461), true, 1, "Code-1406", "Model-1406", "Name-1406", "Spec-1406", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1407, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9464), false, 2, "Code-1407", "Model-1407", "Name-1407", "Spec-1407", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1408, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9470), true, 1, "Code-1408", "Model-1408", "Name-1408", "Spec-1408", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1409, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9474), false, 2, "Code-1409", "Model-1409", "Name-1409", "Spec-1409", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1410, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9479), true, 2, "Code-1410", "Model-1410", "Name-1410", "Spec-1410", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1411, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9483), false, 1, "Code-1411", "Model-1411", "Name-1411", "Spec-1411", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1412, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9489), true, 2, "Code-1412", "Model-1412", "Name-1412", "Spec-1412", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1413, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9493), false, 1, "Code-1413", "Model-1413", "Name-1413", "Spec-1413", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1414, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9498), true, 1, "Code-1414", "Model-1414", "Name-1414", "Spec-1414", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1415, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9502), false, 2, "Code-1415", "Model-1415", "Name-1415", "Spec-1415", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1416, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9507), true, 2, "Code-1416", "Model-1416", "Name-1416", "Spec-1416", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1417, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9511), false, 2, "Code-1417", "Model-1417", "Name-1417", "Spec-1417", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1418, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9516), true, 2, "Code-1418", "Model-1418", "Name-1418", "Spec-1418", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1419, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9520), false, 2, "Code-1419", "Model-1419", "Name-1419", "Spec-1419", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1420, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9560), true, 1, "Code-1420", "Model-1420", "Name-1420", "Spec-1420", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1421, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9565), false, 1, "Code-1421", "Model-1421", "Name-1421", "Spec-1421", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1422, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9570), true, 1, "Code-1422", "Model-1422", "Name-1422", "Spec-1422", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1423, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9574), false, 1, "Code-1423", "Model-1423", "Name-1423", "Spec-1423", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1424, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9580), true, 1, "Code-1424", "Model-1424", "Name-1424", "Spec-1424", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1425, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9584), false, 1, "Code-1425", "Model-1425", "Name-1425", "Spec-1425", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1426, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9589), true, 2, "Code-1426", "Model-1426", "Name-1426", "Spec-1426", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1427, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9593), false, 1, "Code-1427", "Model-1427", "Name-1427", "Spec-1427", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1428, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9600), true, 2, "Code-1428", "Model-1428", "Name-1428", "Spec-1428", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1429, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9604), false, 2, "Code-1429", "Model-1429", "Name-1429", "Spec-1429", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1430, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9609), true, 1, "Code-1430", "Model-1430", "Name-1430", "Spec-1430", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1431, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9613), false, 1, "Code-1431", "Model-1431", "Name-1431", "Spec-1431", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1432, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9619), true, 1, "Code-1432", "Model-1432", "Name-1432", "Spec-1432", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1433, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9622), false, 1, "Code-1433", "Model-1433", "Name-1433", "Spec-1433", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1434, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9628), true, 2, "Code-1434", "Model-1434", "Name-1434", "Spec-1434", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1435, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9632), false, 2, "Code-1435", "Model-1435", "Name-1435", "Spec-1435", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1436, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9637), true, 2, "Code-1436", "Model-1436", "Name-1436", "Spec-1436", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1437, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9641), false, 1, "Code-1437", "Model-1437", "Name-1437", "Spec-1437", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1438, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9646), true, 1, "Code-1438", "Model-1438", "Name-1438", "Spec-1438", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1439, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9650), false, 1, "Code-1439", "Model-1439", "Name-1439", "Spec-1439", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1440, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9689), true, 1, "Code-1440", "Model-1440", "Name-1440", "Spec-1440", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1441, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9694), false, 1, "Code-1441", "Model-1441", "Name-1441", "Spec-1441", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1442, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9699), true, 1, "Code-1442", "Model-1442", "Name-1442", "Spec-1442", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1443, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9704), false, 2, "Code-1443", "Model-1443", "Name-1443", "Spec-1443", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1444, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9709), true, 1, "Code-1444", "Model-1444", "Name-1444", "Spec-1444", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1445, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9713), false, 1, "Code-1445", "Model-1445", "Name-1445", "Spec-1445", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1446, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9719), true, 2, "Code-1446", "Model-1446", "Name-1446", "Spec-1446", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1447, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9724), false, 2, "Code-1447", "Model-1447", "Name-1447", "Spec-1447", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1448, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9731), true, 1, "Code-1448", "Model-1448", "Name-1448", "Spec-1448", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1449, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9737), false, 1, "Code-1449", "Model-1449", "Name-1449", "Spec-1449", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1450, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9746), true, 1, "Code-1450", "Model-1450", "Name-1450", "Spec-1450", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1451, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9754), false, 2, "Code-1451", "Model-1451", "Name-1451", "Spec-1451", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1452, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9763), true, 1, "Code-1452", "Model-1452", "Name-1452", "Spec-1452", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1453, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9771), false, 2, "Code-1453", "Model-1453", "Name-1453", "Spec-1453", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1454, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9780), true, 2, "Code-1454", "Model-1454", "Name-1454", "Spec-1454", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1455, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9786), false, 2, "Code-1455", "Model-1455", "Name-1455", "Spec-1455", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1456, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9795), true, 1, "Code-1456", "Model-1456", "Name-1456", "Spec-1456", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1457, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9801), false, 2, "Code-1457", "Model-1457", "Name-1457", "Spec-1457", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1458, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9810), true, 1, "Code-1458", "Model-1458", "Name-1458", "Spec-1458", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1459, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9818), false, 2, "Code-1459", "Model-1459", "Name-1459", "Spec-1459", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1460, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9849), true, 1, "Code-1460", "Model-1460", "Name-1460", "Spec-1460", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1461, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9896), false, 2, "Code-1461", "Model-1461", "Name-1461", "Spec-1461", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1462, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9904), true, 2, "Code-1462", "Model-1462", "Name-1462", "Spec-1462", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1463, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9910), false, 1, "Code-1463", "Model-1463", "Name-1463", "Spec-1463", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1464, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9920), true, 2, "Code-1464", "Model-1464", "Name-1464", "Spec-1464", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1465, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9924), false, 1, "Code-1465", "Model-1465", "Name-1465", "Spec-1465", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1466, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9930), true, 2, "Code-1466", "Model-1466", "Name-1466", "Spec-1466", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1467, new DateTime(2022, 4, 11, 9, 32, 8, 759, DateTimeKind.Utc).AddTicks(9934), false, 2, "Code-1467", "Model-1467", "Name-1467", "Spec-1467", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1468, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(254), true, 1, "Code-1468", "Model-1468", "Name-1468", "Spec-1468", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1469, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(258), false, 1, "Code-1469", "Model-1469", "Name-1469", "Spec-1469", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1470, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(264), true, 2, "Code-1470", "Model-1470", "Name-1470", "Spec-1470", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1471, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(269), false, 2, "Code-1471", "Model-1471", "Name-1471", "Spec-1471", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1472, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(275), true, 1, "Code-1472", "Model-1472", "Name-1472", "Spec-1472", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1473, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(279), false, 2, "Code-1473", "Model-1473", "Name-1473", "Spec-1473", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1474, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(285), true, 2, "Code-1474", "Model-1474", "Name-1474", "Spec-1474", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1475, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(289), false, 1, "Code-1475", "Model-1475", "Name-1475", "Spec-1475", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1476, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(295), true, 2, "Code-1476", "Model-1476", "Name-1476", "Spec-1476", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1477, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(299), false, 1, "Code-1477", "Model-1477", "Name-1477", "Spec-1477", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1478, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(305), true, 1, "Code-1478", "Model-1478", "Name-1478", "Spec-1478", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1479, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(310), false, 1, "Code-1479", "Model-1479", "Name-1479", "Spec-1479", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1480, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(315), true, 1, "Code-1480", "Model-1480", "Name-1480", "Spec-1480", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1481, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(357), false, 1, "Code-1481", "Model-1481", "Name-1481", "Spec-1481", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1482, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(363), true, 1, "Code-1482", "Model-1482", "Name-1482", "Spec-1482", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1483, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(367), false, 1, "Code-1483", "Model-1483", "Name-1483", "Spec-1483", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1484, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(373), true, 1, "Code-1484", "Model-1484", "Name-1484", "Spec-1484", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1485, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(377), false, 2, "Code-1485", "Model-1485", "Name-1485", "Spec-1485", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1486, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(384), true, 2, "Code-1486", "Model-1486", "Name-1486", "Spec-1486", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1487, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(388), false, 2, "Code-1487", "Model-1487", "Name-1487", "Spec-1487", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1488, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(394), true, 2, "Code-1488", "Model-1488", "Name-1488", "Spec-1488", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1489, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(398), false, 1, "Code-1489", "Model-1489", "Name-1489", "Spec-1489", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1490, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(404), true, 2, "Code-1490", "Model-1490", "Name-1490", "Spec-1490", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1491, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(408), false, 1, "Code-1491", "Model-1491", "Name-1491", "Spec-1491", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1492, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(414), true, 1, "Code-1492", "Model-1492", "Name-1492", "Spec-1492", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1493, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(418), false, 1, "Code-1493", "Model-1493", "Name-1493", "Spec-1493", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1494, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(424), true, 1, "Code-1494", "Model-1494", "Name-1494", "Spec-1494", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1495, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(429), false, 2, "Code-1495", "Model-1495", "Name-1495", "Spec-1495", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1496, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(434), true, 2, "Code-1496", "Model-1496", "Name-1496", "Spec-1496", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1497, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(439), false, 1, "Code-1497", "Model-1497", "Name-1497", "Spec-1497", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1498, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(445), true, 1, "Code-1498", "Model-1498", "Name-1498", "Spec-1498", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1499, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(449), false, 2, "Code-1499", "Model-1499", "Name-1499", "Spec-1499", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1500, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(455), true, 1, "Code-1500", "Model-1500", "Name-1500", "Spec-1500", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1501, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(459), false, 1, "Code-1501", "Model-1501", "Name-1501", "Spec-1501", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1502, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(502), true, 1, "Code-1502", "Model-1502", "Name-1502", "Spec-1502", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1503, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(506), false, 2, "Code-1503", "Model-1503", "Name-1503", "Spec-1503", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1504, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(513), true, 1, "Code-1504", "Model-1504", "Name-1504", "Spec-1504", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1505, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(517), false, 2, "Code-1505", "Model-1505", "Name-1505", "Spec-1505", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1506, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(523), true, 1, "Code-1506", "Model-1506", "Name-1506", "Spec-1506", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1507, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(527), false, 1, "Code-1507", "Model-1507", "Name-1507", "Spec-1507", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1508, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(533), true, 2, "Code-1508", "Model-1508", "Name-1508", "Spec-1508", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1509, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(537), false, 2, "Code-1509", "Model-1509", "Name-1509", "Spec-1509", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1510, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(543), true, 2, "Code-1510", "Model-1510", "Name-1510", "Spec-1510", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1511, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(547), false, 1, "Code-1511", "Model-1511", "Name-1511", "Spec-1511", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1512, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(554), true, 2, "Code-1512", "Model-1512", "Name-1512", "Spec-1512", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1513, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(632), false, 1, "Code-1513", "Model-1513", "Name-1513", "Spec-1513", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1514, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(639), true, 2, "Code-1514", "Model-1514", "Name-1514", "Spec-1514", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1515, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(643), false, 2, "Code-1515", "Model-1515", "Name-1515", "Spec-1515", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1516, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(649), true, 2, "Code-1516", "Model-1516", "Name-1516", "Spec-1516", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1517, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(654), false, 2, "Code-1517", "Model-1517", "Name-1517", "Spec-1517", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1518, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(660), true, 1, "Code-1518", "Model-1518", "Name-1518", "Spec-1518", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1519, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(665), false, 2, "Code-1519", "Model-1519", "Name-1519", "Spec-1519", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1520, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(671), true, 1, "Code-1520", "Model-1520", "Name-1520", "Spec-1520", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1521, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(675), false, 1, "Code-1521", "Model-1521", "Name-1521", "Spec-1521", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1522, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(717), true, 1, "Code-1522", "Model-1522", "Name-1522", "Spec-1522", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1523, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(722), false, 1, "Code-1523", "Model-1523", "Name-1523", "Spec-1523", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1524, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(729), true, 2, "Code-1524", "Model-1524", "Name-1524", "Spec-1524", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1525, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(733), false, 1, "Code-1525", "Model-1525", "Name-1525", "Spec-1525", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1526, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(738), true, 1, "Code-1526", "Model-1526", "Name-1526", "Spec-1526", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1527, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(743), false, 2, "Code-1527", "Model-1527", "Name-1527", "Spec-1527", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1528, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(749), true, 1, "Code-1528", "Model-1528", "Name-1528", "Spec-1528", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1529, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(753), false, 2, "Code-1529", "Model-1529", "Name-1529", "Spec-1529", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1530, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(759), true, 1, "Code-1530", "Model-1530", "Name-1530", "Spec-1530", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1531, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(763), false, 2, "Code-1531", "Model-1531", "Name-1531", "Spec-1531", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1532, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(770), true, 1, "Code-1532", "Model-1532", "Name-1532", "Spec-1532", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1533, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(774), false, 2, "Code-1533", "Model-1533", "Name-1533", "Spec-1533", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1534, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(782), true, 1, "Code-1534", "Model-1534", "Name-1534", "Spec-1534", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1535, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(786), false, 2, "Code-1535", "Model-1535", "Name-1535", "Spec-1535", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1536, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(793), true, 2, "Code-1536", "Model-1536", "Name-1536", "Spec-1536", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1537, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(797), false, 1, "Code-1537", "Model-1537", "Name-1537", "Spec-1537", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1538, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(803), true, 2, "Code-1538", "Model-1538", "Name-1538", "Spec-1538", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1539, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(807), false, 1, "Code-1539", "Model-1539", "Name-1539", "Spec-1539", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1540, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(813), true, 2, "Code-1540", "Model-1540", "Name-1540", "Spec-1540", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1541, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(818), false, 1, "Code-1541", "Model-1541", "Name-1541", "Spec-1541", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1542, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(860), true, 2, "Code-1542", "Model-1542", "Name-1542", "Spec-1542", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1543, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(865), false, 2, "Code-1543", "Model-1543", "Name-1543", "Spec-1543", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1544, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(871), true, 1, "Code-1544", "Model-1544", "Name-1544", "Spec-1544", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1545, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(875), false, 1, "Code-1545", "Model-1545", "Name-1545", "Spec-1545", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1546, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(881), true, 1, "Code-1546", "Model-1546", "Name-1546", "Spec-1546", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1547, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(886), false, 1, "Code-1547", "Model-1547", "Name-1547", "Spec-1547", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1548, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(892), true, 1, "Code-1548", "Model-1548", "Name-1548", "Spec-1548", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1549, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(896), false, 2, "Code-1549", "Model-1549", "Name-1549", "Spec-1549", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1550, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(902), true, 1, "Code-1550", "Model-1550", "Name-1550", "Spec-1550", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1551, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(906), false, 2, "Code-1551", "Model-1551", "Name-1551", "Spec-1551", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1552, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(913), true, 2, "Code-1552", "Model-1552", "Name-1552", "Spec-1552", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1553, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(917), false, 1, "Code-1553", "Model-1553", "Name-1553", "Spec-1553", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1554, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(924), true, 2, "Code-1554", "Model-1554", "Name-1554", "Spec-1554", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1555, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(928), false, 2, "Code-1555", "Model-1555", "Name-1555", "Spec-1555", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1556, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(934), true, 2, "Code-1556", "Model-1556", "Name-1556", "Spec-1556", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1557, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(938), false, 2, "Code-1557", "Model-1557", "Name-1557", "Spec-1557", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1558, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(944), true, 2, "Code-1558", "Model-1558", "Name-1558", "Spec-1558", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1559, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(949), false, 1, "Code-1559", "Model-1559", "Name-1559", "Spec-1559", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1560, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(955), true, 2, "Code-1560", "Model-1560", "Name-1560", "Spec-1560", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1561, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(959), false, 2, "Code-1561", "Model-1561", "Name-1561", "Spec-1561", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1562, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(966), true, 2, "Code-1562", "Model-1562", "Name-1562", "Spec-1562", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1563, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1013), false, 2, "Code-1563", "Model-1563", "Name-1563", "Spec-1563", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1564, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1020), true, 2, "Code-1564", "Model-1564", "Name-1564", "Spec-1564", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1565, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1024), false, 2, "Code-1565", "Model-1565", "Name-1565", "Spec-1565", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1566, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1030), true, 1, "Code-1566", "Model-1566", "Name-1566", "Spec-1566", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1567, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1034), false, 1, "Code-1567", "Model-1567", "Name-1567", "Spec-1567", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1568, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1040), true, 2, "Code-1568", "Model-1568", "Name-1568", "Spec-1568", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1569, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1044), false, 1, "Code-1569", "Model-1569", "Name-1569", "Spec-1569", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1570, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1051), true, 1, "Code-1570", "Model-1570", "Name-1570", "Spec-1570", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1571, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1055), false, 2, "Code-1571", "Model-1571", "Name-1571", "Spec-1571", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1572, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1061), true, 2, "Code-1572", "Model-1572", "Name-1572", "Spec-1572", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1573, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1065), false, 2, "Code-1573", "Model-1573", "Name-1573", "Spec-1573", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1574, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1071), true, 1, "Code-1574", "Model-1574", "Name-1574", "Spec-1574", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1575, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1075), false, 2, "Code-1575", "Model-1575", "Name-1575", "Spec-1575", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1576, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1081), true, 1, "Code-1576", "Model-1576", "Name-1576", "Spec-1576", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1577, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1085), false, 2, "Code-1577", "Model-1577", "Name-1577", "Spec-1577", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1578, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1092), true, 2, "Code-1578", "Model-1578", "Name-1578", "Spec-1578", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1579, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1096), false, 1, "Code-1579", "Model-1579", "Name-1579", "Spec-1579", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1580, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1102), true, 1, "Code-1580", "Model-1580", "Name-1580", "Spec-1580", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1581, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1106), false, 2, "Code-1581", "Model-1581", "Name-1581", "Spec-1581", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1582, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1112), true, 1, "Code-1582", "Model-1582", "Name-1582", "Spec-1582", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1583, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1154), false, 1, "Code-1583", "Model-1583", "Name-1583", "Spec-1583", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1584, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1161), true, 1, "Code-1584", "Model-1584", "Name-1584", "Spec-1584", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1585, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1165), false, 1, "Code-1585", "Model-1585", "Name-1585", "Spec-1585", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1586, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1171), true, 1, "Code-1586", "Model-1586", "Name-1586", "Spec-1586", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1587, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1176), false, 2, "Code-1587", "Model-1587", "Name-1587", "Spec-1587", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1588, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1182), true, 2, "Code-1588", "Model-1588", "Name-1588", "Spec-1588", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1589, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1186), false, 2, "Code-1589", "Model-1589", "Name-1589", "Spec-1589", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1590, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1192), true, 2, "Code-1590", "Model-1590", "Name-1590", "Spec-1590", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1591, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1196), false, 1, "Code-1591", "Model-1591", "Name-1591", "Spec-1591", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1592, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1202), true, 1, "Code-1592", "Model-1592", "Name-1592", "Spec-1592", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1593, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1206), false, 1, "Code-1593", "Model-1593", "Name-1593", "Spec-1593", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1594, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1212), true, 2, "Code-1594", "Model-1594", "Name-1594", "Spec-1594", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1595, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1216), false, 2, "Code-1595", "Model-1595", "Name-1595", "Spec-1595", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1596, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1222), true, 1, "Code-1596", "Model-1596", "Name-1596", "Spec-1596", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1597, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1227), false, 2, "Code-1597", "Model-1597", "Name-1597", "Spec-1597", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1598, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1232), true, 2, "Code-1598", "Model-1598", "Name-1598", "Spec-1598", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1599, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1237), false, 1, "Code-1599", "Model-1599", "Name-1599", "Spec-1599", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1600, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1560), true, 2, "Code-1600", "Model-1600", "Name-1600", "Spec-1600", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1601, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1566), false, 1, "Code-1601", "Model-1601", "Name-1601", "Spec-1601", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1602, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1571), true, 1, "Code-1602", "Model-1602", "Name-1602", "Spec-1602", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1603, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1575), false, 1, "Code-1603", "Model-1603", "Name-1603", "Spec-1603", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1604, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1617), true, 2, "Code-1604", "Model-1604", "Name-1604", "Spec-1604", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1605, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1621), false, 1, "Code-1605", "Model-1605", "Name-1605", "Spec-1605", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1606, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1627), true, 1, "Code-1606", "Model-1606", "Name-1606", "Spec-1606", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1607, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1632), false, 2, "Code-1607", "Model-1607", "Name-1607", "Spec-1607", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1608, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1637), true, 1, "Code-1608", "Model-1608", "Name-1608", "Spec-1608", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1609, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1642), false, 2, "Code-1609", "Model-1609", "Name-1609", "Spec-1609", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1610, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1648), true, 2, "Code-1610", "Model-1610", "Name-1610", "Spec-1610", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1611, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1652), false, 1, "Code-1611", "Model-1611", "Name-1611", "Spec-1611", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1612, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1657), true, 1, "Code-1612", "Model-1612", "Name-1612", "Spec-1612", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1613, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1662), false, 2, "Code-1613", "Model-1613", "Name-1613", "Spec-1613", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1614, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1668), true, 1, "Code-1614", "Model-1614", "Name-1614", "Spec-1614", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1615, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1672), false, 1, "Code-1615", "Model-1615", "Name-1615", "Spec-1615", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1616, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1677), true, 1, "Code-1616", "Model-1616", "Name-1616", "Spec-1616", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1617, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1681), false, 2, "Code-1617", "Model-1617", "Name-1617", "Spec-1617", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1618, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1686), true, 1, "Code-1618", "Model-1618", "Name-1618", "Spec-1618", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1619, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1691), false, 2, "Code-1619", "Model-1619", "Name-1619", "Spec-1619", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1620, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1696), true, 2, "Code-1620", "Model-1620", "Name-1620", "Spec-1620", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1621, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1700), false, 1, "Code-1621", "Model-1621", "Name-1621", "Spec-1621", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1622, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1706), true, 1, "Code-1622", "Model-1622", "Name-1622", "Spec-1622", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1623, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1710), false, 1, "Code-1623", "Model-1623", "Name-1623", "Spec-1623", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1624, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1749), true, 2, "Code-1624", "Model-1624", "Name-1624", "Spec-1624", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1625, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1754), false, 1, "Code-1625", "Model-1625", "Name-1625", "Spec-1625", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1626, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1759), true, 2, "Code-1626", "Model-1626", "Name-1626", "Spec-1626", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1627, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1763), false, 1, "Code-1627", "Model-1627", "Name-1627", "Spec-1627", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1628, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1769), true, 1, "Code-1628", "Model-1628", "Name-1628", "Spec-1628", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1629, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1773), false, 2, "Code-1629", "Model-1629", "Name-1629", "Spec-1629", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1630, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1778), true, 2, "Code-1630", "Model-1630", "Name-1630", "Spec-1630", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1631, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1782), false, 2, "Code-1631", "Model-1631", "Name-1631", "Spec-1631", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1632, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1788), true, 2, "Code-1632", "Model-1632", "Name-1632", "Spec-1632", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1633, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1792), false, 1, "Code-1633", "Model-1633", "Name-1633", "Spec-1633", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1634, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1797), true, 2, "Code-1634", "Model-1634", "Name-1634", "Spec-1634", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1635, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1801), false, 2, "Code-1635", "Model-1635", "Name-1635", "Spec-1635", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1636, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1807), true, 2, "Code-1636", "Model-1636", "Name-1636", "Spec-1636", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1637, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1810), false, 1, "Code-1637", "Model-1637", "Name-1637", "Spec-1637", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1638, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1816), true, 1, "Code-1638", "Model-1638", "Name-1638", "Spec-1638", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1639, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1820), false, 2, "Code-1639", "Model-1639", "Name-1639", "Spec-1639", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1640, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1825), true, 2, "Code-1640", "Model-1640", "Name-1640", "Spec-1640", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1641, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1829), false, 1, "Code-1641", "Model-1641", "Name-1641", "Spec-1641", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1642, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1835), true, 2, "Code-1642", "Model-1642", "Name-1642", "Spec-1642", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1643, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1838), false, 1, "Code-1643", "Model-1643", "Name-1643", "Spec-1643", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1644, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1844), true, 2, "Code-1644", "Model-1644", "Name-1644", "Spec-1644", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1645, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1882), false, 1, "Code-1645", "Model-1645", "Name-1645", "Spec-1645", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1646, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1888), true, 1, "Code-1646", "Model-1646", "Name-1646", "Spec-1646", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1647, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1892), false, 1, "Code-1647", "Model-1647", "Name-1647", "Spec-1647", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1648, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1898), true, 1, "Code-1648", "Model-1648", "Name-1648", "Spec-1648", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1649, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1903), false, 1, "Code-1649", "Model-1649", "Name-1649", "Spec-1649", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1650, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1909), true, 2, "Code-1650", "Model-1650", "Name-1650", "Spec-1650", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1651, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1912), false, 1, "Code-1651", "Model-1651", "Name-1651", "Spec-1651", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1652, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1918), true, 1, "Code-1652", "Model-1652", "Name-1652", "Spec-1652", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1653, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1921), false, 2, "Code-1653", "Model-1653", "Name-1653", "Spec-1653", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1654, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1927), true, 1, "Code-1654", "Model-1654", "Name-1654", "Spec-1654", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1655, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1931), false, 2, "Code-1655", "Model-1655", "Name-1655", "Spec-1655", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1656, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1937), true, 2, "Code-1656", "Model-1656", "Name-1656", "Spec-1656", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1657, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1941), false, 1, "Code-1657", "Model-1657", "Name-1657", "Spec-1657", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1658, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1947), true, 1, "Code-1658", "Model-1658", "Name-1658", "Spec-1658", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1659, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1951), false, 2, "Code-1659", "Model-1659", "Name-1659", "Spec-1659", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1660, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1956), true, 2, "Code-1660", "Model-1660", "Name-1660", "Spec-1660", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1661, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1960), false, 1, "Code-1661", "Model-1661", "Name-1661", "Spec-1661", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1662, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1966), true, 2, "Code-1662", "Model-1662", "Name-1662", "Spec-1662", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1663, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1969), false, 2, "Code-1663", "Model-1663", "Name-1663", "Spec-1663", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1664, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1975), true, 2, "Code-1664", "Model-1664", "Name-1664", "Spec-1664", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1665, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(1998), false, 1, "Code-1665", "Model-1665", "Name-1665", "Spec-1665", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1666, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2005), true, 2, "Code-1666", "Model-1666", "Name-1666", "Spec-1666", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1667, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2009), false, 2, "Code-1667", "Model-1667", "Name-1667", "Spec-1667", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1668, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2014), true, 1, "Code-1668", "Model-1668", "Name-1668", "Spec-1668", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1669, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2018), false, 1, "Code-1669", "Model-1669", "Name-1669", "Spec-1669", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1670, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2024), true, 1, "Code-1670", "Model-1670", "Name-1670", "Spec-1670", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1671, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2028), false, 2, "Code-1671", "Model-1671", "Name-1671", "Spec-1671", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1672, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2035), true, 1, "Code-1672", "Model-1672", "Name-1672", "Spec-1672", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1673, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2039), false, 1, "Code-1673", "Model-1673", "Name-1673", "Spec-1673", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1674, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2044), true, 2, "Code-1674", "Model-1674", "Name-1674", "Spec-1674", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1675, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2049), false, 1, "Code-1675", "Model-1675", "Name-1675", "Spec-1675", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1676, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2054), true, 1, "Code-1676", "Model-1676", "Name-1676", "Spec-1676", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1677, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2058), false, 2, "Code-1677", "Model-1677", "Name-1677", "Spec-1677", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1678, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2064), true, 1, "Code-1678", "Model-1678", "Name-1678", "Spec-1678", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1679, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2068), false, 1, "Code-1679", "Model-1679", "Name-1679", "Spec-1679", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1680, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2073), true, 2, "Code-1680", "Model-1680", "Name-1680", "Spec-1680", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1681, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2078), false, 1, "Code-1681", "Model-1681", "Name-1681", "Spec-1681", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1682, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2083), true, 1, "Code-1682", "Model-1682", "Name-1682", "Spec-1682", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1683, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2087), false, 1, "Code-1683", "Model-1683", "Name-1683", "Spec-1683", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1684, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2093), true, 2, "Code-1684", "Model-1684", "Name-1684", "Spec-1684", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1685, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2142), false, 2, "Code-1685", "Model-1685", "Name-1685", "Spec-1685", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1686, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2148), true, 2, "Code-1686", "Model-1686", "Name-1686", "Spec-1686", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1687, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2152), false, 2, "Code-1687", "Model-1687", "Name-1687", "Spec-1687", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1688, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2158), true, 2, "Code-1688", "Model-1688", "Name-1688", "Spec-1688", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1689, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2162), false, 2, "Code-1689", "Model-1689", "Name-1689", "Spec-1689", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1690, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2168), true, 2, "Code-1690", "Model-1690", "Name-1690", "Spec-1690", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1691, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2172), false, 1, "Code-1691", "Model-1691", "Name-1691", "Spec-1691", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1692, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2177), true, 1, "Code-1692", "Model-1692", "Name-1692", "Spec-1692", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1693, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2181), false, 1, "Code-1693", "Model-1693", "Name-1693", "Spec-1693", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1694, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2187), true, 2, "Code-1694", "Model-1694", "Name-1694", "Spec-1694", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1695, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2191), false, 2, "Code-1695", "Model-1695", "Name-1695", "Spec-1695", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1696, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2196), true, 2, "Code-1696", "Model-1696", "Name-1696", "Spec-1696", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1697, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2201), false, 1, "Code-1697", "Model-1697", "Name-1697", "Spec-1697", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1698, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2206), true, 2, "Code-1698", "Model-1698", "Name-1698", "Spec-1698", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1699, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2210), false, 1, "Code-1699", "Model-1699", "Name-1699", "Spec-1699", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1700, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2215), true, 2, "Code-1700", "Model-1700", "Name-1700", "Spec-1700", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1701, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2219), false, 2, "Code-1701", "Model-1701", "Name-1701", "Spec-1701", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1702, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2225), true, 1, "Code-1702", "Model-1702", "Name-1702", "Spec-1702", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1703, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2229), false, 1, "Code-1703", "Model-1703", "Name-1703", "Spec-1703", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1704, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2235), true, 2, "Code-1704", "Model-1704", "Name-1704", "Spec-1704", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1705, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2239), false, 2, "Code-1705", "Model-1705", "Name-1705", "Spec-1705", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1706, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2282), true, 1, "Code-1706", "Model-1706", "Name-1706", "Spec-1706", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1707, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2286), false, 2, "Code-1707", "Model-1707", "Name-1707", "Spec-1707", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1708, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2292), true, 2, "Code-1708", "Model-1708", "Name-1708", "Spec-1708", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1709, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2296), false, 2, "Code-1709", "Model-1709", "Name-1709", "Spec-1709", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1710, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2301), true, 2, "Code-1710", "Model-1710", "Name-1710", "Spec-1710", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1711, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2305), false, 1, "Code-1711", "Model-1711", "Name-1711", "Spec-1711", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1712, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2311), true, 2, "Code-1712", "Model-1712", "Name-1712", "Spec-1712", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1713, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2314), false, 2, "Code-1713", "Model-1713", "Name-1713", "Spec-1713", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1714, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2320), true, 1, "Code-1714", "Model-1714", "Name-1714", "Spec-1714", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1715, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2324), false, 2, "Code-1715", "Model-1715", "Name-1715", "Spec-1715", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1716, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2329), true, 2, "Code-1716", "Model-1716", "Name-1716", "Spec-1716", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1717, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2334), false, 1, "Code-1717", "Model-1717", "Name-1717", "Spec-1717", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1718, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2339), true, 1, "Code-1718", "Model-1718", "Name-1718", "Spec-1718", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1719, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2343), false, 2, "Code-1719", "Model-1719", "Name-1719", "Spec-1719", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1720, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2349), true, 2, "Code-1720", "Model-1720", "Name-1720", "Spec-1720", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1721, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2353), false, 1, "Code-1721", "Model-1721", "Name-1721", "Spec-1721", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1722, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2358), true, 2, "Code-1722", "Model-1722", "Name-1722", "Spec-1722", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1723, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2362), false, 2, "Code-1723", "Model-1723", "Name-1723", "Spec-1723", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1724, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2368), true, 2, "Code-1724", "Model-1724", "Name-1724", "Spec-1724", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1725, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2372), false, 2, "Code-1725", "Model-1725", "Name-1725", "Spec-1725", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1726, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2412), true, 1, "Code-1726", "Model-1726", "Name-1726", "Spec-1726", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1727, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2417), false, 1, "Code-1727", "Model-1727", "Name-1727", "Spec-1727", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1728, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2423), true, 2, "Code-1728", "Model-1728", "Name-1728", "Spec-1728", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1729, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2426), false, 1, "Code-1729", "Model-1729", "Name-1729", "Spec-1729", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1730, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2432), true, 1, "Code-1730", "Model-1730", "Name-1730", "Spec-1730", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1731, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2436), false, 1, "Code-1731", "Model-1731", "Name-1731", "Spec-1731", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1732, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2441), true, 1, "Code-1732", "Model-1732", "Name-1732", "Spec-1732", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1733, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2445), false, 2, "Code-1733", "Model-1733", "Name-1733", "Spec-1733", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1734, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2451), true, 1, "Code-1734", "Model-1734", "Name-1734", "Spec-1734", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1735, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2455), false, 2, "Code-1735", "Model-1735", "Name-1735", "Spec-1735", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1736, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2460), true, 1, "Code-1736", "Model-1736", "Name-1736", "Spec-1736", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1737, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2465), false, 1, "Code-1737", "Model-1737", "Name-1737", "Spec-1737", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1738, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2470), true, 1, "Code-1738", "Model-1738", "Name-1738", "Spec-1738", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1739, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2474), false, 2, "Code-1739", "Model-1739", "Name-1739", "Spec-1739", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1740, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2479), true, 2, "Code-1740", "Model-1740", "Name-1740", "Spec-1740", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1741, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2483), false, 1, "Code-1741", "Model-1741", "Name-1741", "Spec-1741", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1742, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2489), true, 1, "Code-1742", "Model-1742", "Name-1742", "Spec-1742", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1743, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2493), false, 1, "Code-1743", "Model-1743", "Name-1743", "Spec-1743", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1744, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2498), true, 2, "Code-1744", "Model-1744", "Name-1744", "Spec-1744", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1745, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2503), false, 2, "Code-1745", "Model-1745", "Name-1745", "Spec-1745", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1746, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2542), true, 2, "Code-1746", "Model-1746", "Name-1746", "Spec-1746", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1747, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2547), false, 1, "Code-1747", "Model-1747", "Name-1747", "Spec-1747", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1748, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2552), true, 2, "Code-1748", "Model-1748", "Name-1748", "Spec-1748", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1749, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2556), false, 1, "Code-1749", "Model-1749", "Name-1749", "Spec-1749", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1750, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2561), true, 2, "Code-1750", "Model-1750", "Name-1750", "Spec-1750", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1751, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2565), false, 1, "Code-1751", "Model-1751", "Name-1751", "Spec-1751", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1752, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2571), true, 1, "Code-1752", "Model-1752", "Name-1752", "Spec-1752", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1753, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2575), false, 1, "Code-1753", "Model-1753", "Name-1753", "Spec-1753", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1754, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2580), true, 2, "Code-1754", "Model-1754", "Name-1754", "Spec-1754", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1755, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2584), false, 2, "Code-1755", "Model-1755", "Name-1755", "Spec-1755", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1756, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2590), true, 1, "Code-1756", "Model-1756", "Name-1756", "Spec-1756", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1757, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2594), false, 2, "Code-1757", "Model-1757", "Name-1757", "Spec-1757", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1758, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2599), true, 2, "Code-1758", "Model-1758", "Name-1758", "Spec-1758", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1759, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2603), false, 2, "Code-1759", "Model-1759", "Name-1759", "Spec-1759", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1760, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2608), true, 1, "Code-1760", "Model-1760", "Name-1760", "Spec-1760", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1761, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2612), false, 1, "Code-1761", "Model-1761", "Name-1761", "Spec-1761", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1762, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2618), true, 2, "Code-1762", "Model-1762", "Name-1762", "Spec-1762", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1763, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2622), false, 1, "Code-1763", "Model-1763", "Name-1763", "Spec-1763", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1764, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2627), true, 2, "Code-1764", "Model-1764", "Name-1764", "Spec-1764", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1765, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2631), false, 2, "Code-1765", "Model-1765", "Name-1765", "Spec-1765", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1766, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2637), true, 1, "Code-1766", "Model-1766", "Name-1766", "Spec-1766", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1767, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2678), false, 1, "Code-1767", "Model-1767", "Name-1767", "Spec-1767", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1768, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2684), true, 1, "Code-1768", "Model-1768", "Name-1768", "Spec-1768", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1769, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2687), false, 1, "Code-1769", "Model-1769", "Name-1769", "Spec-1769", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1770, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2693), true, 2, "Code-1770", "Model-1770", "Name-1770", "Spec-1770", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1771, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2697), false, 1, "Code-1771", "Model-1771", "Name-1771", "Spec-1771", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1772, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2703), true, 1, "Code-1772", "Model-1772", "Name-1772", "Spec-1772", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1773, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2707), false, 2, "Code-1773", "Model-1773", "Name-1773", "Spec-1773", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1774, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2712), true, 2, "Code-1774", "Model-1774", "Name-1774", "Spec-1774", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1775, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2717), false, 1, "Code-1775", "Model-1775", "Name-1775", "Spec-1775", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1776, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2722), true, 1, "Code-1776", "Model-1776", "Name-1776", "Spec-1776", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1777, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2726), false, 1, "Code-1777", "Model-1777", "Name-1777", "Spec-1777", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1778, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2732), true, 2, "Code-1778", "Model-1778", "Name-1778", "Spec-1778", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1779, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2736), false, 1, "Code-1779", "Model-1779", "Name-1779", "Spec-1779", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1780, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2741), true, 1, "Code-1780", "Model-1780", "Name-1780", "Spec-1780", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1781, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2745), false, 2, "Code-1781", "Model-1781", "Name-1781", "Spec-1781", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1782, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2751), true, 1, "Code-1782", "Model-1782", "Name-1782", "Spec-1782", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1783, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2755), false, 1, "Code-1783", "Model-1783", "Name-1783", "Spec-1783", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1784, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2761), true, 2, "Code-1784", "Model-1784", "Name-1784", "Spec-1784", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1785, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2764), false, 1, "Code-1785", "Model-1785", "Name-1785", "Spec-1785", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1786, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2770), true, 1, "Code-1786", "Model-1786", "Name-1786", "Spec-1786", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1787, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2809), false, 2, "Code-1787", "Model-1787", "Name-1787", "Spec-1787", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1788, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2816), true, 2, "Code-1788", "Model-1788", "Name-1788", "Spec-1788", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1789, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2820), false, 1, "Code-1789", "Model-1789", "Name-1789", "Spec-1789", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1790, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2826), true, 1, "Code-1790", "Model-1790", "Name-1790", "Spec-1790", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1791, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2830), false, 1, "Code-1791", "Model-1791", "Name-1791", "Spec-1791", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1792, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2835), true, 1, "Code-1792", "Model-1792", "Name-1792", "Spec-1792", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1793, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2839), false, 2, "Code-1793", "Model-1793", "Name-1793", "Spec-1793", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1794, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2845), true, 2, "Code-1794", "Model-1794", "Name-1794", "Spec-1794", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1795, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2849), false, 1, "Code-1795", "Model-1795", "Name-1795", "Spec-1795", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1796, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2854), true, 2, "Code-1796", "Model-1796", "Name-1796", "Spec-1796", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1797, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2858), false, 2, "Code-1797", "Model-1797", "Name-1797", "Spec-1797", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1798, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2863), true, 2, "Code-1798", "Model-1798", "Name-1798", "Spec-1798", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1799, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2867), false, 1, "Code-1799", "Model-1799", "Name-1799", "Spec-1799", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1800, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2873), true, 1, "Code-1800", "Model-1800", "Name-1800", "Spec-1800", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1801, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2877), false, 1, "Code-1801", "Model-1801", "Name-1801", "Spec-1801", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1802, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2882), true, 2, "Code-1802", "Model-1802", "Name-1802", "Spec-1802", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1803, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2886), false, 2, "Code-1803", "Model-1803", "Name-1803", "Spec-1803", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1804, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2892), true, 1, "Code-1804", "Model-1804", "Name-1804", "Spec-1804", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1805, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2896), false, 2, "Code-1805", "Model-1805", "Name-1805", "Spec-1805", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1806, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2901), true, 1, "Code-1806", "Model-1806", "Name-1806", "Spec-1806", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1807, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2905), false, 1, "Code-1807", "Model-1807", "Name-1807", "Spec-1807", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1808, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2945), true, 1, "Code-1808", "Model-1808", "Name-1808", "Spec-1808", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1809, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2949), false, 2, "Code-1809", "Model-1809", "Name-1809", "Spec-1809", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1810, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2955), true, 1, "Code-1810", "Model-1810", "Name-1810", "Spec-1810", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1811, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2959), false, 1, "Code-1811", "Model-1811", "Name-1811", "Spec-1811", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1812, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2964), true, 2, "Code-1812", "Model-1812", "Name-1812", "Spec-1812", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1813, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2968), false, 2, "Code-1813", "Model-1813", "Name-1813", "Spec-1813", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1814, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2973), true, 2, "Code-1814", "Model-1814", "Name-1814", "Spec-1814", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1815, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2977), false, 1, "Code-1815", "Model-1815", "Name-1815", "Spec-1815", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1816, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2982), true, 1, "Code-1816", "Model-1816", "Name-1816", "Spec-1816", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1817, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2986), false, 2, "Code-1817", "Model-1817", "Name-1817", "Spec-1817", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1818, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2992), true, 1, "Code-1818", "Model-1818", "Name-1818", "Spec-1818", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1819, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(2996), false, 1, "Code-1819", "Model-1819", "Name-1819", "Spec-1819", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1820, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3001), true, 2, "Code-1820", "Model-1820", "Name-1820", "Spec-1820", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1821, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3006), false, 1, "Code-1821", "Model-1821", "Name-1821", "Spec-1821", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1822, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3011), true, 2, "Code-1822", "Model-1822", "Name-1822", "Spec-1822", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1823, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3015), false, 2, "Code-1823", "Model-1823", "Name-1823", "Spec-1823", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1824, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3021), true, 2, "Code-1824", "Model-1824", "Name-1824", "Spec-1824", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1825, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3025), false, 1, "Code-1825", "Model-1825", "Name-1825", "Spec-1825", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1826, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3031), true, 2, "Code-1826", "Model-1826", "Name-1826", "Spec-1826", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1827, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3035), false, 1, "Code-1827", "Model-1827", "Name-1827", "Spec-1827", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1828, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3075), true, 1, "Code-1828", "Model-1828", "Name-1828", "Spec-1828", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1829, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3080), false, 2, "Code-1829", "Model-1829", "Name-1829", "Spec-1829", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1830, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3086), true, 2, "Code-1830", "Model-1830", "Name-1830", "Spec-1830", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1831, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3089), false, 1, "Code-1831", "Model-1831", "Name-1831", "Spec-1831", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1832, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3095), true, 2, "Code-1832", "Model-1832", "Name-1832", "Spec-1832", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1833, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3099), false, 2, "Code-1833", "Model-1833", "Name-1833", "Spec-1833", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1834, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3105), true, 2, "Code-1834", "Model-1834", "Name-1834", "Spec-1834", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1835, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3109), false, 1, "Code-1835", "Model-1835", "Name-1835", "Spec-1835", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1836, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3114), true, 1, "Code-1836", "Model-1836", "Name-1836", "Spec-1836", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1837, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3118), false, 1, "Code-1837", "Model-1837", "Name-1837", "Spec-1837", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1838, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3123), true, 2, "Code-1838", "Model-1838", "Name-1838", "Spec-1838", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1839, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3127), false, 1, "Code-1839", "Model-1839", "Name-1839", "Spec-1839", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1840, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3133), true, 1, "Code-1840", "Model-1840", "Name-1840", "Spec-1840", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1841, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3136), false, 2, "Code-1841", "Model-1841", "Name-1841", "Spec-1841", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1842, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3142), true, 2, "Code-1842", "Model-1842", "Name-1842", "Spec-1842", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1843, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3146), false, 1, "Code-1843", "Model-1843", "Name-1843", "Spec-1843", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1844, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3152), true, 2, "Code-1844", "Model-1844", "Name-1844", "Spec-1844", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1845, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3156), false, 1, "Code-1845", "Model-1845", "Name-1845", "Spec-1845", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1846, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3162), true, 2, "Code-1846", "Model-1846", "Name-1846", "Spec-1846", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1847, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3165), false, 1, "Code-1847", "Model-1847", "Name-1847", "Spec-1847", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1848, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3171), true, 1, "Code-1848", "Model-1848", "Name-1848", "Spec-1848", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1849, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3218), false, 1, "Code-1849", "Model-1849", "Name-1849", "Spec-1849", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1850, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3225), true, 1, "Code-1850", "Model-1850", "Name-1850", "Spec-1850", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1851, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3229), false, 1, "Code-1851", "Model-1851", "Name-1851", "Spec-1851", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1852, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3234), true, 2, "Code-1852", "Model-1852", "Name-1852", "Spec-1852", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1853, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3238), false, 2, "Code-1853", "Model-1853", "Name-1853", "Spec-1853", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1854, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3244), true, 1, "Code-1854", "Model-1854", "Name-1854", "Spec-1854", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1855, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3248), false, 2, "Code-1855", "Model-1855", "Name-1855", "Spec-1855", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1856, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3253), true, 1, "Code-1856", "Model-1856", "Name-1856", "Spec-1856", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1857, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3257), false, 1, "Code-1857", "Model-1857", "Name-1857", "Spec-1857", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1858, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3263), true, 1, "Code-1858", "Model-1858", "Name-1858", "Spec-1858", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1859, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3268), false, 1, "Code-1859", "Model-1859", "Name-1859", "Spec-1859", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1860, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3273), true, 2, "Code-1860", "Model-1860", "Name-1860", "Spec-1860", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1861, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3277), false, 1, "Code-1861", "Model-1861", "Name-1861", "Spec-1861", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1862, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3282), true, 2, "Code-1862", "Model-1862", "Name-1862", "Spec-1862", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1863, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3286), false, 2, "Code-1863", "Model-1863", "Name-1863", "Spec-1863", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1864, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3291), true, 1, "Code-1864", "Model-1864", "Name-1864", "Spec-1864", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1865, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3296), false, 1, "Code-1865", "Model-1865", "Name-1865", "Spec-1865", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1866, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3301), true, 1, "Code-1866", "Model-1866", "Name-1866", "Spec-1866", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1867, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3305), false, 1, "Code-1867", "Model-1867", "Name-1867", "Spec-1867", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1868, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3311), true, 2, "Code-1868", "Model-1868", "Name-1868", "Spec-1868", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1869, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3349), false, 1, "Code-1869", "Model-1869", "Name-1869", "Spec-1869", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1870, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3355), true, 1, "Code-1870", "Model-1870", "Name-1870", "Spec-1870", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1871, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3358), false, 1, "Code-1871", "Model-1871", "Name-1871", "Spec-1871", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1872, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3364), true, 2, "Code-1872", "Model-1872", "Name-1872", "Spec-1872", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1873, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3368), false, 2, "Code-1873", "Model-1873", "Name-1873", "Spec-1873", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1874, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3373), true, 2, "Code-1874", "Model-1874", "Name-1874", "Spec-1874", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1875, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3377), false, 1, "Code-1875", "Model-1875", "Name-1875", "Spec-1875", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1876, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3383), true, 2, "Code-1876", "Model-1876", "Name-1876", "Spec-1876", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1877, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3387), false, 2, "Code-1877", "Model-1877", "Name-1877", "Spec-1877", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1878, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3392), true, 2, "Code-1878", "Model-1878", "Name-1878", "Spec-1878", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1879, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3396), false, 1, "Code-1879", "Model-1879", "Name-1879", "Spec-1879", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1880, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3402), true, 2, "Code-1880", "Model-1880", "Name-1880", "Spec-1880", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1881, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3406), false, 2, "Code-1881", "Model-1881", "Name-1881", "Spec-1881", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1882, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3411), true, 1, "Code-1882", "Model-1882", "Name-1882", "Spec-1882", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1883, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3416), false, 1, "Code-1883", "Model-1883", "Name-1883", "Spec-1883", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1884, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3421), true, 1, "Code-1884", "Model-1884", "Name-1884", "Spec-1884", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1885, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3425), false, 2, "Code-1885", "Model-1885", "Name-1885", "Spec-1885", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1886, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3431), true, 1, "Code-1886", "Model-1886", "Name-1886", "Spec-1886", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1887, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3435), false, 2, "Code-1887", "Model-1887", "Name-1887", "Spec-1887", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1888, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3440), true, 2, "Code-1888", "Model-1888", "Name-1888", "Spec-1888", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1889, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3477), false, 2, "Code-1889", "Model-1889", "Name-1889", "Spec-1889", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1890, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3484), true, 1, "Code-1890", "Model-1890", "Name-1890", "Spec-1890", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1891, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3488), false, 2, "Code-1891", "Model-1891", "Name-1891", "Spec-1891", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1892, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3493), true, 1, "Code-1892", "Model-1892", "Name-1892", "Spec-1892", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1893, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3497), false, 1, "Code-1893", "Model-1893", "Name-1893", "Spec-1893", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1894, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3503), true, 1, "Code-1894", "Model-1894", "Name-1894", "Spec-1894", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1895, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3507), false, 2, "Code-1895", "Model-1895", "Name-1895", "Spec-1895", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1896, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3512), true, 2, "Code-1896", "Model-1896", "Name-1896", "Spec-1896", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1897, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3517), false, 1, "Code-1897", "Model-1897", "Name-1897", "Spec-1897", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1898, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3522), true, 2, "Code-1898", "Model-1898", "Name-1898", "Spec-1898", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1899, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3526), false, 1, "Code-1899", "Model-1899", "Name-1899", "Spec-1899", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1900, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3532), true, 1, "Code-1900", "Model-1900", "Name-1900", "Spec-1900", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1901, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3536), false, 1, "Code-1901", "Model-1901", "Name-1901", "Spec-1901", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1902, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3542), true, 1, "Code-1902", "Model-1902", "Name-1902", "Spec-1902", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1903, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3545), false, 2, "Code-1903", "Model-1903", "Name-1903", "Spec-1903", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1904, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3551), true, 1, "Code-1904", "Model-1904", "Name-1904", "Spec-1904", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1905, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3555), false, 2, "Code-1905", "Model-1905", "Name-1905", "Spec-1905", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1906, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3560), true, 1, "Code-1906", "Model-1906", "Name-1906", "Spec-1906", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1907, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3564), false, 2, "Code-1907", "Model-1907", "Name-1907", "Spec-1907", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1908, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3570), true, 1, "Code-1908", "Model-1908", "Name-1908", "Spec-1908", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1909, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3574), false, 2, "Code-1909", "Model-1909", "Name-1909", "Spec-1909", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1910, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3614), true, 2, "Code-1910", "Model-1910", "Name-1910", "Spec-1910", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1911, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3618), false, 1, "Code-1911", "Model-1911", "Name-1911", "Spec-1911", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1912, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3624), true, 2, "Code-1912", "Model-1912", "Name-1912", "Spec-1912", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1913, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3628), false, 2, "Code-1913", "Model-1913", "Name-1913", "Spec-1913", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1914, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3633), true, 2, "Code-1914", "Model-1914", "Name-1914", "Spec-1914", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1915, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3637), false, 2, "Code-1915", "Model-1915", "Name-1915", "Spec-1915", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1916, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3643), true, 1, "Code-1916", "Model-1916", "Name-1916", "Spec-1916", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1917, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3647), false, 1, "Code-1917", "Model-1917", "Name-1917", "Spec-1917", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1918, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3652), true, 1, "Code-1918", "Model-1918", "Name-1918", "Spec-1918", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1919, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3656), false, 2, "Code-1919", "Model-1919", "Name-1919", "Spec-1919", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1920, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3662), true, 2, "Code-1920", "Model-1920", "Name-1920", "Spec-1920", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1921, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3666), false, 2, "Code-1921", "Model-1921", "Name-1921", "Spec-1921", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1922, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3671), true, 1, "Code-1922", "Model-1922", "Name-1922", "Spec-1922", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1923, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3675), false, 2, "Code-1923", "Model-1923", "Name-1923", "Spec-1923", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1924, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3681), true, 2, "Code-1924", "Model-1924", "Name-1924", "Spec-1924", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1925, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3686), false, 1, "Code-1925", "Model-1925", "Name-1925", "Spec-1925", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1926, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3692), true, 2, "Code-1926", "Model-1926", "Name-1926", "Spec-1926", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1927, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3696), false, 2, "Code-1927", "Model-1927", "Name-1927", "Spec-1927", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1928, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3701), true, 2, "Code-1928", "Model-1928", "Name-1928", "Spec-1928", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1929, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3705), false, 1, "Code-1929", "Model-1929", "Name-1929", "Spec-1929", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1930, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3747), true, 2, "Code-1930", "Model-1930", "Name-1930", "Spec-1930", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1931, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3752), false, 1, "Code-1931", "Model-1931", "Name-1931", "Spec-1931", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1932, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3758), true, 1, "Code-1932", "Model-1932", "Name-1932", "Spec-1932", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1933, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3761), false, 2, "Code-1933", "Model-1933", "Name-1933", "Spec-1933", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1934, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3767), true, 1, "Code-1934", "Model-1934", "Name-1934", "Spec-1934", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1935, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3771), false, 2, "Code-1935", "Model-1935", "Name-1935", "Spec-1935", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1936, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3776), true, 1, "Code-1936", "Model-1936", "Name-1936", "Spec-1936", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1937, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3780), false, 2, "Code-1937", "Model-1937", "Name-1937", "Spec-1937", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1938, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3786), true, 2, "Code-1938", "Model-1938", "Name-1938", "Spec-1938", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1939, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3790), false, 1, "Code-1939", "Model-1939", "Name-1939", "Spec-1939", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1940, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3795), true, 1, "Code-1940", "Model-1940", "Name-1940", "Spec-1940", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1941, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3799), false, 1, "Code-1941", "Model-1941", "Name-1941", "Spec-1941", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1942, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3805), true, 1, "Code-1942", "Model-1942", "Name-1942", "Spec-1942", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1943, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3809), false, 2, "Code-1943", "Model-1943", "Name-1943", "Spec-1943", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1944, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3815), true, 2, "Code-1944", "Model-1944", "Name-1944", "Spec-1944", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1945, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3819), false, 1, "Code-1945", "Model-1945", "Name-1945", "Spec-1945", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1946, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3825), true, 2, "Code-1946", "Model-1946", "Name-1946", "Spec-1946", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1947, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3829), false, 1, "Code-1947", "Model-1947", "Name-1947", "Spec-1947", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1948, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3834), true, 1, "Code-1948", "Model-1948", "Name-1948", "Spec-1948", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1949, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3838), false, 1, "Code-1949", "Model-1949", "Name-1949", "Spec-1949", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1950, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3843), true, 1, "Code-1950", "Model-1950", "Name-1950", "Spec-1950", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1951, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3882), false, 1, "Code-1951", "Model-1951", "Name-1951", "Spec-1951", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1952, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3888), true, 2, "Code-1952", "Model-1952", "Name-1952", "Spec-1952", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1953, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3892), false, 2, "Code-1953", "Model-1953", "Name-1953", "Spec-1953", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1954, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3898), true, 1, "Code-1954", "Model-1954", "Name-1954", "Spec-1954", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1955, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3902), false, 2, "Code-1955", "Model-1955", "Name-1955", "Spec-1955", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1956, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3908), true, 1, "Code-1956", "Model-1956", "Name-1956", "Spec-1956", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1957, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3912), false, 1, "Code-1957", "Model-1957", "Name-1957", "Spec-1957", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1958, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3917), true, 2, "Code-1958", "Model-1958", "Name-1958", "Spec-1958", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1959, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3922), false, 2, "Code-1959", "Model-1959", "Name-1959", "Spec-1959", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1960, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3928), true, 1, "Code-1960", "Model-1960", "Name-1960", "Spec-1960", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1961, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3933), false, 1, "Code-1961", "Model-1961", "Name-1961", "Spec-1961", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1962, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3938), true, 2, "Code-1962", "Model-1962", "Name-1962", "Spec-1962", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1963, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3942), false, 2, "Code-1963", "Model-1963", "Name-1963", "Spec-1963", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1964, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3948), true, 2, "Code-1964", "Model-1964", "Name-1964", "Spec-1964", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1965, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3952), false, 2, "Code-1965", "Model-1965", "Name-1965", "Spec-1965", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1966, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3958), true, 1, "Code-1966", "Model-1966", "Name-1966", "Spec-1966", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1967, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3962), false, 1, "Code-1967", "Model-1967", "Name-1967", "Spec-1967", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1968, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3967), true, 1, "Code-1968", "Model-1968", "Name-1968", "Spec-1968", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1969, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3971), false, 2, "Code-1969", "Model-1969", "Name-1969", "Spec-1969", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1970, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(3977), true, 1, "Code-1970", "Model-1970", "Name-1970", "Spec-1970", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1971, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4014), false, 2, "Code-1971", "Model-1971", "Name-1971", "Spec-1971", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1972, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4020), true, 1, "Code-1972", "Model-1972", "Name-1972", "Spec-1972", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1973, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4024), false, 1, "Code-1973", "Model-1973", "Name-1973", "Spec-1973", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1974, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4030), true, 2, "Code-1974", "Model-1974", "Name-1974", "Spec-1974", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1975, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4034), false, 2, "Code-1975", "Model-1975", "Name-1975", "Spec-1975", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1976, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4039), true, 2, "Code-1976", "Model-1976", "Name-1976", "Spec-1976", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1977, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4043), false, 2, "Code-1977", "Model-1977", "Name-1977", "Spec-1977", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1978, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4048), true, 2, "Code-1978", "Model-1978", "Name-1978", "Spec-1978", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1979, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4052), false, 2, "Code-1979", "Model-1979", "Name-1979", "Spec-1979", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1980, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4058), true, 2, "Code-1980", "Model-1980", "Name-1980", "Spec-1980", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1981, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4062), false, 2, "Code-1981", "Model-1981", "Name-1981", "Spec-1981", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1982, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4067), true, 1, "Code-1982", "Model-1982", "Name-1982", "Spec-1982", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1983, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4071), false, 1, "Code-1983", "Model-1983", "Name-1983", "Spec-1983", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1984, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4076), true, 1, "Code-1984", "Model-1984", "Name-1984", "Spec-1984", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1985, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4081), false, 2, "Code-1985", "Model-1985", "Name-1985", "Spec-1985", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1986, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4087), true, 2, "Code-1986", "Model-1986", "Name-1986", "Spec-1986", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1987, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4091), false, 1, "Code-1987", "Model-1987", "Name-1987", "Spec-1987", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1988, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4096), true, 2, "Code-1988", "Model-1988", "Name-1988", "Spec-1988", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1989, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4100), false, 1, "Code-1989", "Model-1989", "Name-1989", "Spec-1989", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1990, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4105), true, 2, "Code-1990", "Model-1990", "Name-1990", "Spec-1990", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1991, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4109), false, 2, "Code-1991", "Model-1991", "Name-1991", "Spec-1991", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1992, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4150), true, 2, "Code-1992", "Model-1992", "Name-1992", "Spec-1992", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1993, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4155), false, 2, "Code-1993", "Model-1993", "Name-1993", "Spec-1993", 1, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1994, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4160), true, 1, "Code-1994", "Model-1994", "Name-1994", "Spec-1994", 4, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1995, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4164), false, 2, "Code-1995", "Model-1995", "Name-1995", "Spec-1995", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1996, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4170), true, 1, "Code-1996", "Model-1996", "Name-1996", "Spec-1996", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1997, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4174), false, 1, "Code-1997", "Model-1997", "Name-1997", "Spec-1997", 3, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1998, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4179), true, 1, "Code-1998", "Model-1998", "Name-1998", "Spec-1998", 2, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "CreateTime", "IsAvailable", "MaterialClassification", "MaterialCode", "MaterialModel", "MaterialName", "MaterialSpecification", "Unit", "UpdateTime" },
                values: new object[] { 1999, new DateTime(2022, 4, 11, 9, 32, 8, 760, DateTimeKind.Utc).AddTicks(4183), false, 1, "Code-1999", "Model-1999", "Name-1999", "Spec-1999", 3, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
