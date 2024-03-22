//using Microsoft.EntityFrameworkCore.Migrations;
//using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

//#nullable disable

//namespace ERP.Repository.PgSql.Migrations
//{
//    /// <inheritdoc />
//    public partial class addedRequests : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "Requests",
//                columns: table => new
//                {
//                    RequestID = table.Column<int>(type: "integer", nullable: false)
//                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
//                    SenderAddress = table.Column<string>(type: "text", nullable: false),
//                    ReceiverAddress = table.Column<string>(type: "text", nullable: false),
//                    RegNumber = table.Column<string>(type: "text", nullable: false),
//                    Reason = table.Column<string>(type: "text", nullable: false),
//                    Description = table.Column<string>(type: "text", nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Requests", x => x.RequestID);
//                });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1001,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Milton.Carroll75@gmail.com", "Milton", "Carroll", "EG/2021/2744" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1002,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Pablo.Kertzmann55@gmail.com", "Pablo", "Kertzmann", "EG/2023/3607" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1003,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Marcelle.Towne17@gmail.com", "Marcelle", "Towne", "EG/2022/9338" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1004,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Armand_Wilkinson25@gmail.com", "Armand", "Wilkinson", "EG/2020/9158" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1005,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Alba89@hotmail.com", "Alba", "Wisoky", "EG/2020/4030" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1006,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Jayda6@hotmail.com", "Jayda", "Langosh", "EG/2023/5450" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1007,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Celia.Wisozk@gmail.com", "Celia", "Wisozk", "EG/2022/1561" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1008,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Kianna_Larkin88@gmail.com", "Kianna", "Larkin", "EG/2020/5093" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1009,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Chaya_Batz3@gmail.com", "Chaya", "Batz", "EG/2020/6459" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1010,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Velma6@yahoo.com", "Velma", "Dare", "EG/2023/5160" });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "Requests");

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1001,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Gail_Auer7@hotmail.com", "Gail", "Auer", "EG/2021/6447" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1002,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Jefferey.Kshlerin47@gmail.com", "Jefferey", "Kshlerin", "EG/2023/6712" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1003,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Stevie35@hotmail.com", "Stevie", "Bosco", "EG/2022/7796" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1004,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Christy_Moore76@gmail.com", "Christy", "Moore", "EG/2022/5728" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1005,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Glenda_Marks@yahoo.com", "Glenda", "Marks", "EG/2023/7424" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1006,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Mellie.Deckow83@gmail.com", "Mellie", "Deckow", "EG/2023/9723" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1007,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Noah_Mosciski74@yahoo.com", "Noah", "Mosciski", "EG/2020/7537" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1008,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Darrel29@yahoo.com", "Darrel", "Goyette", "EG/2020/1430" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1009,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Cary64@hotmail.com", "Cary", "Senger", "EG/2023/2956" });

//            migrationBuilder.UpdateData(
//                table: "Students",
//                keyColumn: "StudentId",
//                keyValue: 1010,
//                columns: new[] { "Email", "FirstName", "LastName", "RegistrationNum" },
//                values: new object[] { "Coby66@hotmail.com", "Coby", "O'Reilly", "EG/2023/3277" });
//        }
//    }
//}
