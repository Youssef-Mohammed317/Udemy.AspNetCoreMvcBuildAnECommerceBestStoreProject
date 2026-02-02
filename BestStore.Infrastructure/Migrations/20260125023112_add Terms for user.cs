using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addTermsforuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcceptTerms",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptTerms",
                table: "AspNetUsers");
        }
    }
}
