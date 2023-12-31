# SwaggerClient-php
The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

This PHP package is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.php.PhpClientCodegen

## Requirements

PHP 5.5 and later

## Installation & Usage
### Composer

To install the bindings via [Composer](http://getcomposer.org/), add the following to `composer.json`:

```
{
  "repositories": [
    {
      "type": "git",
      "url": "http://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
    require_once('/path/to/SwaggerClient-php/vendor/autoload.php');
```

## Tests

To run the unit tests:

```
composer install
./vendor/bin/phpunit
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\AccountClosureRequest(); // \Swagger\Client\Model\AccountClosureRequest | AccountClosureRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->accountClosure($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountApi->accountClosure: ', $e->getMessage(), PHP_EOL;
}
?>
```

## Documentation for API Endpoints

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**accountClosure**](docs/Api/AccountApi.md#accountclosure) | **POST** /v1/accounts/closure | Closure of Account
*AccountsApi* | [**accountBalancesSummaryInquiry**](docs/Api/AccountsApi.md#accountbalancessummaryinquiry) | **GET** /v1/accounts/{accountId}/closure/balances | Retrieve Account Balance Summary
*AccountsApi* | [**balanceTransferBooking**](docs/Api/AccountsApi.md#balancetransferbooking) | **POST** /v1/accounts/{accountId}/loans/balanceTransfers/bookings | Book Balance Transfer
*AccountsApi* | [**balanceTransferEligibility**](docs/Api/AccountsApi.md#balancetransfereligibility) | **GET** /v1/accounts/loans/balanceTransfers | Check Eligibility for Balance Transfer Offer
*AccountsApi* | [**consentsDetailsInquiry**](docs/Api/AccountsApi.md#consentsdetailsinquiry) | **GET** /v1/accounts/{accountId}/consents | Retrieve Consents based on Account Number
*AccountsApi* | [**consentsDetailsUpdate**](docs/Api/AccountsApi.md#consentsdetailsupdate) | **POST** /v1/accounts/{accountId}/consents | This API is used to update the consent for an account
*AccountsApi* | [**partnerV1AccountsAccountIdAccessCodesGet**](docs/Api/AccountsApi.md#partnerv1accountsaccountidaccesscodesget) | **GET** /partner/v1/accounts/{accountId}/accessCodes | This API will retrieve the Access Code which will be used to see the clear account number
*AccountsApi* | [**partnerV1PartnerAccountsGet**](docs/Api/AccountsApi.md#partnerv1partneraccountsget) | **GET** /partner/v1/partnerAccounts | Retrieve Partner Account Summary
*AccountsApi* | [**retrieveUnmaskedAccountData**](docs/Api/AccountsApi.md#retrieveunmaskedaccountdata) | **POST** /v1/accounts/clearData/retrieve | This API provides unmasked IBAN (International bank account number) for the requested account Id.
*AccountsApi* | [**v1AccountsAccountIdLoansBookingsPost**](docs/Api/AccountsApi.md#v1accountsaccountidloansbookingspost) | **POST** /v1/accounts/{accountId}/loans/bookings | Book Loan Over Phone
*AccountsApi* | [**v1AccountsAccountIdLoansDisbursementOptionsGet**](docs/Api/AccountsApi.md#v1accountsaccountidloansdisbursementoptionsget) | **GET** /v1/accounts/{accountId}/loans/disbursementOptions | Retrieve Disbursement Options
*AccountsApi* | [**v1AccountsAccountIdLoansGet**](docs/Api/AccountsApi.md#v1accountsaccountidloansget) | **GET** /v1/accounts/{accountId}/loans | Retrieve Loan Summary
*AccountsApi* | [**v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet**](docs/Api/AccountsApi.md#v1accountsaccountidloansloanamountpaymentsplansget) | **GET** /v1/accounts/{accountId}/loans/{loanAmount}/paymentsPlans | Retrieve Loan Booking Plans
*AccountsApi* | [**v1AccountsAccountIdLoansRepaymentSchedulesGet**](docs/Api/AccountsApi.md#v1accountsaccountidloansrepaymentschedulesget) | **GET** /v1/accounts/{accountId}/loans/repaymentSchedules | Retrieve Repayment Schedules
*AccountsApi* | [**v1AccountsAccountIdStatementsGet**](docs/Api/AccountsApi.md#v1accountsaccountidstatementsget) | **GET** /v1/accounts/{accountId}/statements | Retrieve list of available statements.
*AccountsApi* | [**v1AccountsAccountIdStatementsStatementIdGet**](docs/Api/AccountsApi.md#v1accountsaccountidstatementsstatementidget) | **GET** /v1/accounts/{accountId}/statements/{statementId} | Retrieve Statements Summary and Transaction
*AccountsApi* | [**v1AccountsAccountIdTransactionsConfirmationPost**](docs/Api/AccountsApi.md#v1accountsaccountidtransactionsconfirmationpost) | **POST** /v1/accounts/{accountId}/transactions/confirmation | Confirm Transaction Details
*AccountsApi* | [**v1AccountsAccountIdTransactionsLimitedDayRangeGet**](docs/Api/AccountsApi.md#v1accountsaccountidtransactionslimiteddayrangeget) | **GET** /v1/accounts/{accountId}/transactions/limited/dayRange | Retrieve Transaction Details for Limited Period
*AccountsApi* | [**v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet**](docs/Api/AccountsApi.md#v1accountsaccountidtransactionstransactionreferenceiddetailsget) | **GET** /v1/accounts/{accountId}/transactions/{transactionReferenceId}/details | Retrieve Additional Transaction Details By Transaction Reference Id
*AccountsApi* | [**v1AccountsLoansBookingsConfirmationPost**](docs/Api/AccountsApi.md#v1accountsloansbookingsconfirmationpost) | **POST** /v1/accounts/loans/bookings/confirmation | Loan Booking Confirmation
*AccountsApi* | [**v1AccountsLoansEligibilityGet**](docs/Api/AccountsApi.md#v1accountsloanseligibilityget) | **GET** /v1/accounts/loans/eligibility | Check Eligibility for Loan Offer
*AccountsApi* | [**v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet**](docs/Api/AccountsApi.md#v1accountsloansloanreferenceidrepaymentschedulesget) | **GET** /v1/accounts/loans/{loanReferenceId}/repaymentSchedules | Retrieve Repayment Schedule of Booked LOP/EPP Loan
*AccountsApi* | [**v1AccountsTransactionsSearchPost**](docs/Api/AccountsApi.md#v1accountstransactionssearchpost) | **POST** /v1/accounts/transactions/search | Retrieve Multiple Accounts Transaction Details
*AccountsApi* | [**viewTransactionDetailsDocument_**](docs/Api/AccountsApi.md#viewtransactiondetailsdocument_) | **GET** /v1/accounts/{accountId}/transactions/documents | Download Transaction Details
*CardsApi* | [**loanBookingConfirmationPreLogin**](docs/Api/CardsApi.md#loanbookingconfirmationprelogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings/confirmation | This API  is triggered after CMAMT interdiction in Loan Booking process.
*CardsApi* | [**loanBookingPreLogin**](docs/Api/CardsApi.md#loanbookingprelogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings | This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
*CardsApi* | [**partnerV1AccountsAccountIdLoansGet**](docs/Api/CardsApi.md#partnerv1accountsaccountidloansget) | **GET** /partner/v1/accounts/{accountId}/loans | This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidate) | **POST** /v1/creditChargeCard/creditPlans/{cardId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmation) | **POST** /v1/creditChargeCard/creditPlans/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmationprelogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateprelogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanloansprelogin) | **GET** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/loans | This API is to fetch the list of booked loans on customer&#x27;s  credit cards.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanofferseppbookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepprepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**](docs/Api/CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersloanrepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/loans/repaymentSchedules | To allow customers to view the payment breakdown details.
*CardsApi* | [**retrieveDisbursementOptionsPreLogin**](docs/Api/CardsApi.md#retrievedisbursementoptionsprelogin) | **GET** /v1/creditCardServices/offers/{offerId}/prelogin/loans/disbursementOptions | Get the list of disbursement options and the details like bank details and billing address relevant to each option.
*CardsApi* | [**v1AccountsAccountIdLoansCreditCheckSearchPost**](docs/Api/CardsApi.md#v1accountsaccountidloanscreditchecksearchpost) | **POST** /v1/accounts/{accountId}/loans/creditCheck/search | Credit Check based on Debt Service Ratio
*CustomerApi* | [**sufficiencyOfFunds**](docs/Api/CustomerApi.md#sufficiencyoffunds) | **GET** /v1/accounts/{accountId}/funds/sufficiencyCheck | Check Availability of Funds
*CustomerFoundationalApi* | [**evaluateCustomerEligibilityAssessmentCheckPreLogin**](docs/Api/CustomerFoundationalApi.md#evaluatecustomereligibilityassessmentcheckprelogin) | **GET** /v1/preLogin/customerProductServiceEligibility/check/offers/{offerId} | This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
*DefaultApi* | [**v1AccountsAccountIdGet**](docs/Api/DefaultApi.md#v1accountsaccountidget) | **GET** /v1/accounts/{accountId} | Retrieve Account Details
*DefaultApi* | [**v1AccountsAccountIdTransactionsGet**](docs/Api/DefaultApi.md#v1accountsaccountidtransactionsget) | **GET** /v1/accounts/{accountId}/transactions | Retrieve Transactions for Specific Account
*DefaultApi* | [**v1AccountsGet**](docs/Api/DefaultApi.md#v1accountsget) | **GET** /v1/accounts | Retrieve Summary of All Accounts
*OfferAndDecisionManagementApi* | [**executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**](docs/Api/OfferAndDecisionManagementApi.md#executeapplicationprocessingunsecuredloantopupofferacceptanceandsubmission) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/offerAcceptanceAndSubmission | This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit
*OfferAndDecisionManagementApi* | [**initiateApplicationProcessingUnsecuredLoanTopup**](docs/Api/OfferAndDecisionManagementApi.md#initiateapplicationprocessingunsecuredloantopup) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications | This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
*OfferAndDecisionManagementApi* | [**retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**](docs/Api/OfferAndDecisionManagementApi.md#retrieveapplicationprocessingunsecuredloantopuprepaymentschedule) | **GET** /v1/applicationProcessing/products/unsecuredLoans/topup/repaymentSchedule | This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
*OfferAndDecisionManagementApi* | [**updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**](docs/Api/OfferAndDecisionManagementApi.md#updateapplicationprocessingunsecuredloantopupbackgroundscreening) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/backgroundScreening | This API is used to update a saved Loan top-up application &amp; do background screening
*OfferAndDecisionManagementApi* | [**updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**](docs/Api/OfferAndDecisionManagementApi.md#updateapplicationprocessingunsecuredloantopupinprincipalapproval) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/inPrincipleApprovals | This API is used to update a saved Loan top-up application and in principle approval

## Documentation For Models

 - [AccountAccessCodeGenerationResponse](docs/Model/AccountAccessCodeGenerationResponse.md)
 - [AccountBalancesSummaryInquiryResponse](docs/Model/AccountBalancesSummaryInquiryResponse.md)
 - [AccountClosureRequest](docs/Model/AccountClosureRequest.md)
 - [AccountClosureResponse](docs/Model/AccountClosureResponse.md)
 - [AccountConsentDetails](docs/Model/AccountConsentDetails.md)
 - [AccountDetailsResponse](docs/Model/AccountDetailsResponse.md)
 - [AccountGroupSummary](docs/Model/AccountGroupSummary.md)
 - [AccountInfo](docs/Model/AccountInfo.md)
 - [AccountStatementListResponse](docs/Model/AccountStatementListResponse.md)
 - [AccountSummary](docs/Model/AccountSummary.md)
 - [Accounts](docs/Model/Accounts.md)
 - [AccountsGroupList](docs/Model/AccountsGroupList.md)
 - [Address](docs/Model/Address.md)
 - [AmortizationSched](docs/Model/AmortizationSched.md)
 - [AmortizationSchedule](docs/Model/AmortizationSchedule.md)
 - [Applicant](docs/Model/Applicant.md)
 - [ApplicantDetail](docs/Model/ApplicantDetail.md)
 - [BalanceTransferBookingRequest](docs/Model/BalanceTransferBookingRequest.md)
 - [BalanceTransferBookingResponse](docs/Model/BalanceTransferBookingResponse.md)
 - [BalanceTransferBookings](docs/Model/BalanceTransferBookings.md)
 - [BalanceTransferEligibilityDetails](docs/Model/BalanceTransferEligibilityDetails.md)
 - [BalanceTransferEligibilityResponse](docs/Model/BalanceTransferEligibilityResponse.md)
 - [BankDetails](docs/Model/BankDetails.md)
 - [BeneficiaryAddress](docs/Model/BeneficiaryAddress.md)
 - [BeneficiaryBankDetail](docs/Model/BeneficiaryBankDetail.md)
 - [BeneficiaryBankDetails](docs/Model/BeneficiaryBankDetails.md)
 - [BeneficiaryDetail](docs/Model/BeneficiaryDetail.md)
 - [BinaryData](docs/Model/BinaryData.md)
 - [BtDisbursementOptions](docs/Model/BtDisbursementOptions.md)
 - [CallDepositAccount](docs/Model/CallDepositAccount.md)
 - [CallDepositAccountSummary](docs/Model/CallDepositAccountSummary.md)
 - [CheckingAccount](docs/Model/CheckingAccount.md)
 - [CheckingAccountSummary](docs/Model/CheckingAccountSummary.md)
 - [CompositeTransactionDetailsRequest](docs/Model/CompositeTransactionDetailsRequest.md)
 - [CompositeTransactionDetailsResponse](docs/Model/CompositeTransactionDetailsResponse.md)
 - [ConsentDetails](docs/Model/ConsentDetails.md)
 - [ConsentsDetailsInquiryResponse](docs/Model/ConsentsDetailsInquiryResponse.md)
 - [ConsentsDetailsUpdateRequest](docs/Model/ConsentsDetailsUpdateRequest.md)
 - [CountrySpecificAddress](docs/Model/CountrySpecificAddress.md)
 - [CreditCardAccount](docs/Model/CreditCardAccount.md)
 - [CreditCardAccountBalanceSummary](docs/Model/CreditCardAccountBalanceSummary.md)
 - [CreditCardAccountSummary](docs/Model/CreditCardAccountSummary.md)
 - [CreditCardStatement](docs/Model/CreditCardStatement.md)
 - [CreditCheck](docs/Model/CreditCheck.md)
 - [CreditCheckRequest](docs/Model/CreditCheckRequest.md)
 - [CreditCheckResponse](docs/Model/CreditCheckResponse.md)
 - [CreditorDetails](docs/Model/CreditorDetails.md)
 - [CustomerAddress](docs/Model/CustomerAddress.md)
 - [CustomerMerchantReferenceDetails](docs/Model/CustomerMerchantReferenceDetails.md)
 - [CustomerName](docs/Model/CustomerName.md)
 - [DebtorDetails](docs/Model/DebtorDetails.md)
 - [DisbursementOption](docs/Model/DisbursementOption.md)
 - [DisbursementOptions](docs/Model/DisbursementOptions.md)
 - [DisbursementOptionsResponse](docs/Model/DisbursementOptionsResponse.md)
 - [EasyPaymentPlan](docs/Model/EasyPaymentPlan.md)
 - [EasyPaymentPlansTransactionEligibilityResponse](docs/Model/EasyPaymentPlansTransactionEligibilityResponse.md)
 - [EmploymentDetails](docs/Model/EmploymentDetails.md)
 - [EppAmortizationSchedule](docs/Model/EppAmortizationSchedule.md)
 - [EppLoanBooking](docs/Model/EppLoanBooking.md)
 - [EppLoanBookingRequest](docs/Model/EppLoanBookingRequest.md)
 - [EppLoanBookingResponse](docs/Model/EppLoanBookingResponse.md)
 - [EppOffers](docs/Model/EppOffers.md)
 - [EppRepaymentScheuleResponse](docs/Model/EppRepaymentScheuleResponse.md)
 - [EppTransaction](docs/Model/EppTransaction.md)
 - [ErrorResponse](docs/Model/ErrorResponse.md)
 - [EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse](docs/Model/EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse.md)
 - [ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest](docs/Model/ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest.md)
 - [ExpenseDetails](docs/Model/ExpenseDetails.md)
 - [ExternalBankDetails](docs/Model/ExternalBankDetails.md)
 - [FinancialInformation](docs/Model/FinancialInformation.md)
 - [GroupBalance](docs/Model/GroupBalance.md)
 - [IncomeDetails](docs/Model/IncomeDetails.md)
 - [InitiateApplicationProcessingUnsecuredLoanTopupRequest](docs/Model/InitiateApplicationProcessingUnsecuredLoanTopupRequest.md)
 - [InitiateApplicationProcessingUnsecuredLoanTopupResponse](docs/Model/InitiateApplicationProcessingUnsecuredLoanTopupResponse.md)
 - [InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest](docs/Model/InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest.md)
 - [InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse](docs/Model/InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.md)
 - [InsurancePolicySummary](docs/Model/InsurancePolicySummary.md)
 - [InvestmentTransaction](docs/Model/InvestmentTransaction.md)
 - [ListResponse](docs/Model/ListResponse.md)
 - [Loan](docs/Model/Loan.md)
 - [LoanAccount](docs/Model/LoanAccount.md)
 - [LoanAccountSummary](docs/Model/LoanAccountSummary.md)
 - [LoanAmortizationSchedule](docs/Model/LoanAmortizationSchedule.md)
 - [LoanBookingConfirmationPreLoginRequest](docs/Model/LoanBookingConfirmationPreLoginRequest.md)
 - [LoanBookingConfirmationPreLoginResponse](docs/Model/LoanBookingConfirmationPreLoginResponse.md)
 - [LoanBookingConfirmationRequest](docs/Model/LoanBookingConfirmationRequest.md)
 - [LoanBookingConfirmationResponse](docs/Model/LoanBookingConfirmationResponse.md)
 - [LoanBookingPlan](docs/Model/LoanBookingPlan.md)
 - [LoanBookingPlanResponse](docs/Model/LoanBookingPlanResponse.md)
 - [LoanBookingPreLoginRequest](docs/Model/LoanBookingPreLoginRequest.md)
 - [LoanBookingPreLoginResponse](docs/Model/LoanBookingPreLoginResponse.md)
 - [LoanBookingRequest](docs/Model/LoanBookingRequest.md)
 - [LoanBookingResponse](docs/Model/LoanBookingResponse.md)
 - [LoanEligibilityCheckResponse](docs/Model/LoanEligibilityCheckResponse.md)
 - [LoanEligibilityDetails](docs/Model/LoanEligibilityDetails.md)
 - [LoanPaymentPlans](docs/Model/LoanPaymentPlans.md)
 - [LoanPaymentSchedule](docs/Model/LoanPaymentSchedule.md)
 - [LoanRepaymentScheduleResponse](docs/Model/LoanRepaymentScheduleResponse.md)
 - [LoanRepaymentScheuleResponse](docs/Model/LoanRepaymentScheuleResponse.md)
 - [LoanScheduleDetails](docs/Model/LoanScheduleDetails.md)
 - [LoanSummary](docs/Model/LoanSummary.md)
 - [LoanSummaryResponse](docs/Model/LoanSummaryResponse.md)
 - [LoanTopup](docs/Model/LoanTopup.md)
 - [LoanTopupRecommendations](docs/Model/LoanTopupRecommendations.md)
 - [Loans](docs/Model/Loans.md)
 - [MarketingCampaignOffer](docs/Model/MarketingCampaignOffer.md)
 - [MutualFund](docs/Model/MutualFund.md)
 - [MutualFundAccount](docs/Model/MutualFundAccount.md)
 - [MutualFundAccountSummary](docs/Model/MutualFundAccountSummary.md)
 - [OriginalCreditAccountDetails](docs/Model/OriginalCreditAccountDetails.md)
 - [OriginalCreditorDetails](docs/Model/OriginalCreditorDetails.md)
 - [OriginalDebitAccountDetails](docs/Model/OriginalDebitAccountDetails.md)
 - [OriginalTransactionDetails](docs/Model/OriginalTransactionDetails.md)
 - [PartialResponseInformation](docs/Model/PartialResponseInformation.md)
 - [PayeeAccountDetails](docs/Model/PayeeAccountDetails.md)
 - [PaymentPans](docs/Model/PaymentPans.md)
 - [PendingTransaction](docs/Model/PendingTransaction.md)
 - [PersonalAccountDetails](docs/Model/PersonalAccountDetails.md)
 - [Phone](docs/Model/Phone.md)
 - [PremiumDepositAccount](docs/Model/PremiumDepositAccount.md)
 - [PremiumDepositAccountSummary](docs/Model/PremiumDepositAccountSummary.md)
 - [Product](docs/Model/Product.md)
 - [ReadyCreditAccount](docs/Model/ReadyCreditAccount.md)
 - [ReadyCreditAccountBalanceSummary](docs/Model/ReadyCreditAccountBalanceSummary.md)
 - [ReadyCreditAccountSummary](docs/Model/ReadyCreditAccountSummary.md)
 - [Relationship](docs/Model/Relationship.md)
 - [RequestedLoanTopupDecision](docs/Model/RequestedLoanTopupDecision.md)
 - [RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse](docs/Model/RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoanRepayScheduleSimulatorResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoanRepayScheduleSimulatorResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoanRepayScheduleSimulatorResponseAmortizationSchedule](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoanRepayScheduleSimulatorResponseAmortizationSchedule.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse](docs/Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse.md)
 - [RetrieveDisbursementOptionsPreLoginResponse](docs/Model/RetrieveDisbursementOptionsPreLoginResponse.md)
 - [RetrieveUnmaskedAccountDataRequest](docs/Model/RetrieveUnmaskedAccountDataRequest.md)
 - [RetrieveUnmaskedAccountDataResponse](docs/Model/RetrieveUnmaskedAccountDataResponse.md)
 - [SavingsAccount](docs/Model/SavingsAccount.md)
 - [SavingsAccountSummary](docs/Model/SavingsAccountSummary.md)
 - [SecuritiesBrokerageAccount](docs/Model/SecuritiesBrokerageAccount.md)
 - [SecuritiesBrokerageAccountSummary](docs/Model/SecuritiesBrokerageAccountSummary.md)
 - [Security](docs/Model/Security.md)
 - [Statement](docs/Model/Statement.md)
 - [StatementList](docs/Model/StatementList.md)
 - [StatementSummary](docs/Model/StatementSummary.md)
 - [Statements](docs/Model/Statements.md)
 - [StatementsResponse](docs/Model/StatementsResponse.md)
 - [SufficiencyOfFundsResponse](docs/Model/SufficiencyOfFundsResponse.md)
 - [TimeDepositAccount](docs/Model/TimeDepositAccount.md)
 - [TimeDepositAccountSummary](docs/Model/TimeDepositAccountSummary.md)
 - [Transaction](docs/Model/Transaction.md)
 - [TransactionDetailedViewResponse](docs/Model/TransactionDetailedViewResponse.md)
 - [TransactionDetails](docs/Model/TransactionDetails.md)
 - [TransactionDetailsConfirmationRequest](docs/Model/TransactionDetailsConfirmationRequest.md)
 - [TransactionDetailsConfirmationResponse](docs/Model/TransactionDetailsConfirmationResponse.md)
 - [TransactionDetailsRequest](docs/Model/TransactionDetailsRequest.md)
 - [TransactionDetailsResponse](docs/Model/TransactionDetailsResponse.md)
 - [TransactionDocumentList](docs/Model/TransactionDocumentList.md)
 - [Transactions](docs/Model/Transactions.md)
 - [UnSecuredLoans](docs/Model/UnSecuredLoans.md)
 - [UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest](docs/Model/UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.md)
 - [UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse](docs/Model/UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse.md)
 - [UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest](docs/Model/UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest.md)
 - [UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse](docs/Model/UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.md)
 - [ViewTransactionDetailsDocumentResponse](docs/Model/ViewTransactionDetailsDocumentResponse.md)

## Documentation For Authorization

 All endpoints do not require authorization.


## Author



