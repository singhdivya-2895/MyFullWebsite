using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { new Guid("1c8ddba4-f744-42a7-b070-abdfd4bfa5f4"), "drinks", "London", new DateTime(2023, 9, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2462), "Activity 3 months in future", "Future Activity 3", "Another pub" },
                    { new Guid("4ef80d88-5861-4316-ad69-0934f23eee89"), "drinks", "London", new DateTime(2023, 4, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2405), "Activity 2 months ago", "Past Activity 1", "Pub" },
                    { new Guid("51a9e5c7-b810-45b9-a5fe-7c87c4b75efe"), "drinks", "London", new DateTime(2023, 11, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2469), "Activity 5 months in future", "Future Activity 5", "Just another pub" },
                    { new Guid("54600be9-f204-49cd-b307-c5d96aae9c5f"), "music", "London", new DateTime(2023, 12, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2480), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" },
                    { new Guid("66dd8e6e-2cbc-42ae-ab0f-b2a54b2b7ed1"), "culture", "London", new DateTime(2023, 7, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2457), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" },
                    { new Guid("81ff4f47-4a23-4d2b-9484-c2439555d890"), "drinks", "London", new DateTime(2023, 10, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2467), "Activity 4 months in future", "Future Activity 4", "Yet another pub" },
                    { new Guid("b081ea37-72c7-4cfc-98df-837bc77d6af7"), "travel", "London", new DateTime(2024, 1, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2483), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" },
                    { new Guid("b7f47c6a-cc93-44d6-a579-114ac80b99b2"), "music", "London", new DateTime(2023, 8, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2459), "Activity 2 months in future", "Future Activity 2", "O2 Arena" },
                    { new Guid("d46dc6e3-547d-40dc-a306-2237c6fe323a"), "film", "London", new DateTime(2024, 2, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2486), "Activity 8 months in future", "Future Activity 8", "Cinema" },
                    { new Guid("e34508c8-9bbd-4491-a274-0a38ff9d4795"), "culture", "Paris", new DateTime(2023, 5, 7, 6, 16, 23, 688, DateTimeKind.Utc).AddTicks(2454), "Activity 1 month ago", "Past Activity 2", "Louvre" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1c8ddba4-f744-42a7-b070-abdfd4bfa5f4"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4ef80d88-5861-4316-ad69-0934f23eee89"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("51a9e5c7-b810-45b9-a5fe-7c87c4b75efe"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("54600be9-f204-49cd-b307-c5d96aae9c5f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("66dd8e6e-2cbc-42ae-ab0f-b2a54b2b7ed1"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("81ff4f47-4a23-4d2b-9484-c2439555d890"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b081ea37-72c7-4cfc-98df-837bc77d6af7"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b7f47c6a-cc93-44d6-a579-114ac80b99b2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d46dc6e3-547d-40dc-a306-2237c6fe323a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e34508c8-9bbd-4491-a274-0a38ff9d4795"));
        }
    }
}
