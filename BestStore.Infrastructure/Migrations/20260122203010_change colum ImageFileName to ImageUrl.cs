using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BestStore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changecolumImageFileNametoImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageFileName",
                table: "Products",
                newName: "ImageUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Products",
                newName: "ImageFileName");
        }
    }
}
