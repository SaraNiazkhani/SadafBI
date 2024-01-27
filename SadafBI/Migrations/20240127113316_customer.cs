using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SadafBI.Migrations
{
    public partial class customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dlNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    credit = table.Column<long>(type: "bigint", nullable: false),
                    comexCredit = table.Column<int>(type: "int", nullable: true),
                    sfCredit = table.Column<int>(type: "int", nullable: true),
                    telegramUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telegramStatusId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchId = table.Column<int>(type: "int", nullable: false),
                    branchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isCompany = table.Column<int>(type: "int", nullable: false),
                    customerIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthCertificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registerationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bourseAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    accountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    onlineUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasOnlineAccount = table.Column<int>(type: "int", nullable: false),
                    modificationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isMmtpUser = table.Column<int>(type: "int", nullable: false),
                    mmtpUserStatusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isSiteUser = table.Column<int>(type: "int", nullable: false),
                    eorderStatusId = table.Column<int>(type: "int", nullable: false),
                    sexTypeId = table.Column<int>(type: "int", nullable: false),
                    sexTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    referredBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hasSignSample = table.Column<bool>(type: "bit", nullable: false),
                    hasCustomerPhoto = table.Column<bool>(type: "bit", nullable: false),
                    hasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    hasCertificateComments = table.Column<bool>(type: "bit", nullable: false),
                    hasZipFile = table.Column<bool>(type: "bit", nullable: false),
                    hasOfficialGazette = table.Column<bool>(type: "bit", nullable: false),
                    hasOfficialAds = table.Column<bool>(type: "bit", nullable: false),
                    comexVisitorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mmtpUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comexEconomyAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isPortfo = table.Column<int>(type: "int", nullable: false),
                    traderCredit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    provinceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    cityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shabaNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    baTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isStockCreditPurchase = table.Column<int>(type: "int", nullable: false),
                    isCollateralStocksCustomer = table.Column<int>(type: "int", nullable: true),
                    isProfessionalTrader = table.Column<int>(type: "int", nullable: false),
                    isOtcProfessionalTrader = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customerId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    PageSize = table.Column<int>(type: "int", nullable: false),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    Offset = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Customergroups",
                columns: table => new
                {
                    customerGroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customerGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SqlCustomerListcustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customergroups", x => x.customerGroupId);
                    table.ForeignKey(
                        name: "FK_Customergroups_Customers_SqlCustomerListcustomerId",
                        column: x => x.SqlCustomerListcustomerId,
                        principalTable: "Customers",
                        principalColumn: "customerId");
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    domainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    domainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SqlCustomerListcustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.domainId);
                    table.ForeignKey(
                        name: "FK_Domains_Customers_SqlCustomerListcustomerId",
                        column: x => x.SqlCustomerListcustomerId,
                        principalTable: "Customers",
                        principalColumn: "customerId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customergroups_SqlCustomerListcustomerId",
                table: "Customergroups",
                column: "SqlCustomerListcustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_SqlCustomerListcustomerId",
                table: "Domains",
                column: "SqlCustomerListcustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customergroups");

            migrationBuilder.DropTable(
                name: "Domains");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
