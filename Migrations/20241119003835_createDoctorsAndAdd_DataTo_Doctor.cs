using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hospital.Migrations
{
    /// <inheritdoc />
    public partial class createDoctorsAndAdd_DataTo_Doctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Img", "Name", "Specialization" },
                values: new object[,]
                {
                    { 1, "doctor1.jpg", "Dr. John Smith", "Cardiology" },
                    { 2, "doctor3.jpg", "Dr. Sarah Johnson", "Pediatrics" },
                    { 3, "doctor5.jpg", "Dr. Emily Davis", "Dermatology" },
                    { 4, "doctor2.jpg", "Dr. Michael Lee", "Orthopedics" },
                    { 5, "doctor6.jpg", "Dr. William Clark", "Neurology" },
                    { 6, "doctor4.jpg", "Dr. Younis Musa", "Cardiac surgery" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
