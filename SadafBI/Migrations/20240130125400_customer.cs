using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SadafBI.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customergroups",
                columns: table => new
                {
                    customerGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customergroups", x => x.customerGroupId);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    domainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    domainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerId = table.Column<int>(type: "int", nullable: true),
                    nationalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dlNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    credit = table.Column<long>(type: "bigint", nullable: true),
                    comexCredit = table.Column<int>(type: "int", nullable: true),
                    sfCredit = table.Column<int>(type: "int", nullable: true),
                    telegramUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telegramStatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branchId = table.Column<int>(type: "int", nullable: true),
                    branchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isCompany = table.Column<int>(type: "int", nullable: true),
                    customerIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthCertificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registerationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bourseAccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    onlineUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hasOnlineAccount = table.Column<int>(type: "int", nullable: true),
                    modificationDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isMmtpUser = table.Column<int>(type: "int", nullable: true),
                    mmtpUserStatusId = table.Column<int>(type: "int", nullable: true),
                    isSiteUser = table.Column<int>(type: "int", nullable: true),
                    eorderStatusId = table.Column<int>(type: "int", nullable: true),
                    sexTypeId = table.Column<int>(type: "int", nullable: true),
                    sexTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    referredBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hasSignSample = table.Column<bool>(type: "bit", nullable: true),
                    hasCustomerPhoto = table.Column<bool>(type: "bit", nullable: true),
                    hasBirthCertificate = table.Column<bool>(type: "bit", nullable: true),
                    hasCertificateComments = table.Column<bool>(type: "bit", nullable: true),
                    hasZipFile = table.Column<bool>(type: "bit", nullable: true),
                    hasOfficialGazette = table.Column<bool>(type: "bit", nullable: true),
                    hasOfficialAds = table.Column<bool>(type: "bit", nullable: true),
                    comexVisitorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mmtpUserId = table.Column<int>(type: "int", nullable: true),
                    comexEconomyAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isPortfo = table.Column<int>(type: "int", nullable: true),
                    traderCredit = table.Column<int>(type: "int", nullable: true),
                    provinceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    provinceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cityId = table.Column<int>(type: "int", nullable: true),
                    cityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankAccountId = table.Column<int>(type: "int", nullable: true),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shabaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    baTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isStockCreditPurchase = table.Column<int>(type: "int", nullable: true),
                    isCollateralStocksCustomer = table.Column<int>(type: "int", nullable: true),
                    isProfessionalTrader = table.Column<int>(type: "int", nullable: true),
                    isOtcProfessionalTrader = table.Column<int>(type: "int", nullable: true),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customerGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.domainId);
                    table.ForeignKey(
                        name: "FK_Domains_Customergroups_customerGroupId",
                        column: x => x.customerGroupId,
                        principalTable: "Customergroups",
                        principalColumn: "customerGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Domains_customerGroupId",
                table: "Domains",
                column: "customerGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "Customergroups");
        }
    }
}
