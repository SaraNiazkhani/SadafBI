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
                    customerId = table.Column<int>(type: "int", nullable: false),
                    nationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dlNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    credit = table.Column<long>(type: "bigint", nullable: false),
                    comexCredit = table.Column<int>(type: "int", nullable: true),
                    sfCredit = table.Column<int>(type: "int", nullable: true),
                    telegramUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telegramStatusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branchId = table.Column<int>(type: "int", nullable: false),
                    branchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isCompany = table.Column<int>(type: "int", nullable: false),
                    customerIdentity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthCertificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    postalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    registerationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    referredBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hasSignSample = table.Column<bool>(type: "bit", nullable: false),
                    hasCustomerPhoto = table.Column<bool>(type: "bit", nullable: false),
                    hasBirthCertificate = table.Column<bool>(type: "bit", nullable: false),
                    hasCertificateComments = table.Column<bool>(type: "bit", nullable: false),
                    hasZipFile = table.Column<bool>(type: "bit", nullable: false),
                    hasOfficialGazette = table.Column<bool>(type: "bit", nullable: false),
                    hasOfficialAds = table.Column<bool>(type: "bit", nullable: false),
                    comexVisitorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mmtpUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comexEconomyAccount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isPortfo = table.Column<int>(type: "int", nullable: false),
                    traderCredit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provinceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    cityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAccountId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    shabaNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    baTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isStockCreditPurchase = table.Column<int>(type: "int", nullable: false),
                    isCollateralStocksCustomer = table.Column<int>(type: "int", nullable: false),
                    isProfessionalTrader = table.Column<int>(type: "int", nullable: false),
                    isOtcProfessionalTrader = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
