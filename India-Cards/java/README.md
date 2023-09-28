# swagger-java-client

Cards
- API version: 1.0.0
  - Build date: 2023-08-14T16:43:49.245466Z[Etc/UTC]

The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.


*Automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen)*


## Requirements

Building the API client library requires:
1. Java 1.7+
2. Maven/Gradle

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn clean install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn clean deploy
```

Refer to the [OSSRH Guide](http://central.sonatype.org/pages/ossrh-guide.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
  <groupId>io.swagger</groupId>
  <artifactId>swagger-java-client</artifactId>
  <version>1.0.0</version>
  <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "io.swagger:swagger-java-client:1.0.0"
```

### Others

At first generate the JAR by executing:

```shell
mvn clean package
```

Then manually install the following JARs:

* `target/swagger-java-client-1.0.0.jar`
* `target/lib/*.jar`

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java
import io.swagger.client.*;
import io.swagger.client.auth.*;
import io.swagger.client.model.*;
import io.swagger.client.api.AccountsApi;

import java.io.File;
import java.util.*;

public class AccountsApiExample {

    public static void main(String[] args) {
        
        AccountsApi apiInstance = new AccountsApi();
        CreditLimitDecreaseRequest body = new CreditLimitDecreaseRequest(); // CreditLimitDecreaseRequest | CreditLimitDecreaseRequest
        String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
        String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
        String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
        String clientId = "clientId_example"; // String | client id generated during consumer on-boarding
        String contentType = "contentType_example"; // String | application/json
        String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        try {
            CreditLimitDecreaseResponse result = apiInstance.creditLimitDecrease(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling AccountsApi#creditLimitDecrease");
            e.printStackTrace();
        }
    }
}
import io.swagger.client.*;
import io.swagger.client.auth.*;
import io.swagger.client.model.*;
import io.swagger.client.api.AccountsApi;

import java.io.File;
import java.util.*;

public class AccountsApiExample {

    public static void main(String[] args) {
        
        AccountsApi apiInstance = new AccountsApi();
        CreditLimitDecreaseConsentRequest body = new CreditLimitDecreaseConsentRequest(); // CreditLimitDecreaseConsentRequest | CreditLimitDecreaseConsentRequest
        String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
        String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
        String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
        String clientId = "clientId_example"; // String | client id generated during consumer on-boarding
        String contentType = "contentType_example"; // String | application/json
        String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        try {
            CreditLimitDecreaseConsentResponse result = apiInstance.creditLimitDecreaseConsent(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling AccountsApi#creditLimitDecreaseConsent");
            e.printStackTrace();
        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**creditLimitDecrease**](docs/AccountsApi.md#creditLimitDecrease) | **PUT** /v1/creditCards/creditLimits/decrease | Decrease Credit Limit
*AccountsApi* | [**creditLimitDecreaseConsent**](docs/AccountsApi.md#creditLimitDecreaseConsent) | **PUT** /v1/creditCards/creditLimits/decrease/consents | Decrease Credit Limit with Consent
*CardServicingApi* | [**v1CardsActivationsConfirmationPost**](docs/CardServicingApi.md#v1CardsActivationsConfirmationPost) | **POST** /v1/cards/activations/confirmation | Confirm Card Activation Deactivation
*CardServicingApi* | [**v1CardsAtmPinResetConfirmationPost**](docs/CardServicingApi.md#v1CardsAtmPinResetConfirmationPost) | **POST** /v1/cards/atmPin/reset/confirmation | Confirm ATM Pin Request
*CardServicingApi* | [**v1CardsAtmPinResetPut**](docs/CardServicingApi.md#v1CardsAtmPinResetPut) | **PUT** /v1/cards/atmPin/reset | Reset ATM Pin
*CardServicingApi* | [**v1CardsOverseasUsageConfirmationPost**](docs/CardServicingApi.md#v1CardsOverseasUsageConfirmationPost) | **POST** /v1/cards/overseasUsage/confirmation | Confirm Card Overseas Activation Deactivation
*CardsApi* | [**bNMOAPIBankingDigitalRegulatory**](docs/CardsApi.md#bNMOAPIBankingDigitalRegulatory) | **GET** /v1/my/bnm/cards | Retrieve the detail of card products
*CardsApi* | [**eppLoanBookingConfirmation**](docs/CardsApi.md#eppLoanBookingConfirmation) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings/confirmation | Confirm Easy Payment Plan Booking
*CardsApi* | [**initiateCreditChargeCardCorporateCardsClosure**](docs/CardsApi.md#initiateCreditChargeCardCorporateCardsClosure) | **POST** /partner/v1/creditChargeCard/corporateCards/closure | This API is used to close the corporate Credit Card or Ready credit Account.
*CardsApi* | [**multiCurrencyAccountEnrollment**](docs/CardsApi.md#multiCurrencyAccountEnrollment) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
*CardsApi* | [**multiCurrencyAccountEnrollmentWithCurrency**](docs/CardsApi.md#multiCurrencyAccountEnrollmentWithCurrency) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
*CardsApi* | [**notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**](docs/CardsApi.md#notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction) | **POST** /partner/v1/creditChargeCard/transaction/authorised/notify | This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
*CardsApi* | [**partnerCardListing**](docs/CardsApi.md#partnerCardListing) | **GET** /partner/v1/cards | Partner Card List
*CardsApi* | [**requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed**](docs/CardsApi.md#requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed) | **POST** /partner/v1/creditChargeCard/corporateCards/suspensionAndCashLimitAllowed | This API is used to Suspend and Unsuspend corporate card.
*CardsApi* | [**requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement**](docs/CardsApi.md#requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement) | **POST** /partner/v1/creditChargeCard/corporateCards/cardReplacement | This API is to do the replacement of credit card for Damage/Lost/Stolen reasons
*CardsApi* | [**requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund**](docs/CardsApi.md#requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund) | **POST** /v1/creditChargeCard/creditPlan/epp/refund | This API is used for EPP Refund in Open Loop
*CardsApi* | [**retrieveCreditChargeCardCorporateCardsCashLimit**](docs/CardsApi.md#retrieveCreditChargeCardCorporateCardsCashLimit) | **POST** /partner/v1/creditChargeCard/corporateCards/cashLimit/retrieve | This API is used to retrieve the corporate card cash limit
*CardsApi* | [**retrieveCreditChargeCardCorporateCardsDetail**](docs/CardsApi.md#retrieveCreditChargeCardCorporateCardsDetail) | **POST** /partner/v1/creditChargeCard/corporateCards/details/retrieve | This API is used to retrieve the corporate card details
*CardsApi* | [**retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions**](docs/CardsApi.md#retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions) | **POST** /partner/v1/creditChargeCard/corporateCards/pendingAndIntradayAuthorizationTransactions/retrieve | This API used to retrieve the pending Authorization refund and intraday and history transactions
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus**](docs/CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus) | **GET** /v1/creditChargeCard/cardStatus | Retrieve Credit Card Status
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](docs/CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](docs/CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
*CardsApi* | [**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](docs/CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
*CardsApi* | [**updateCreditChargeCardCorporateCardsCashLimit**](docs/CardsApi.md#updateCreditChargeCardCorporateCardsCashLimit) | **PUT** /partner/v1/creditChargeCard/corporateCards/cashLimit | This API is used to update the corporate card cash limit
*CardsApi* | [**updateCreditChargeCardCorporateCardsCreditLimit**](docs/CardsApi.md#updateCreditChargeCardCorporateCardsCreditLimit) | **PUT** /partner/v1/creditChargeCard/corporateCards/creditLimit | This API is used to update the corportate card credit limit
*CardsApi* | [**updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen**](docs/CardsApi.md#updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen) | **PUT** /partner/v1/creditChargeCard/corporateCards/lostOrStolen | This API is to report lost or stolen card and to apply for Replacement
*CardsApi* | [**updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl**](docs/CardsApi.md#updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl) | **PUT** /partner/v1/creditChargeCard/corporateCards/spendControl | This API will help corporate user to update purchases for specific merchants coming in the API request
*CardsApi* | [**v1CardsCardIdLimitsAndEnrollmentsPut**](docs/CardsApi.md#v1CardsCardIdLimitsAndEnrollmentsPut) | **PUT** /v1/cards/{cardId}/limitsAndEnrollments | Enroll for Transaction Limit Setup
*CardsApi* | [**v1CardsCardIdMultiCurrencyAccountsDelete**](docs/CardsApi.md#v1CardsCardIdMultiCurrencyAccountsDelete) | **DELETE** /v1/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
*CardsApi* | [**v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost**](docs/CardsApi.md#v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
*CardsApi* | [**v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost**](docs/CardsApi.md#v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
*CardsApi* | [**v1CardsCardIdOverseasTravelPlansDelete**](docs/CardsApi.md#v1CardsCardIdOverseasTravelPlansDelete) | **DELETE** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to delete an existing travel plan 
*CardsApi* | [**v1CardsCardIdOverseasTravelPlansPost**](docs/CardsApi.md#v1CardsCardIdOverseasTravelPlansPost) | **POST** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to add a new travel plan
*CardsApi* | [**v1CardsCardIdOverseasTravelPlansPut**](docs/CardsApi.md#v1CardsCardIdOverseasTravelPlansPut) | **PUT** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to update an existing travel plan
*CardsApi* | [**v1CardsCvvVerificationPost**](docs/CardsApi.md#v1CardsCvvVerificationPost) | **POST** /v1/cards/cvv/verification | Verify CVV for Debit or Credit Card
*CardsApi* | [**v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet**](docs/CardsApi.md#v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet) | **GET** /v1/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
*CardsApi* | [**v1CardsOverseasTravelPlansGet**](docs/CardsApi.md#v1CardsOverseasTravelPlansGet) | **GET** /v1/cards/overseasTravelPlans | This API enables customer to inquire current travel plan
*CardsApi* | [**v2CardsCardIdMultiCurrencyAccountsDelete**](docs/CardsApi.md#v2CardsCardIdMultiCurrencyAccountsDelete) | **DELETE** /v2/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
*CardsApi* | [**v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet**](docs/CardsApi.md#v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet) | **GET** /v2/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
*CreditCardsApi* | [**companionCardApplication**](docs/CreditCardsApi.md#companionCardApplication) | **POST** /v1/creditCards/{cardId}/companion/applications | Issuance of Companion Card
*CreditCardsApi* | [**easyPaymentPlansTransactionEligibility**](docs/CreditCardsApi.md#easyPaymentPlansTransactionEligibility) | **GET** /v1/creditCards/{cardId}/transactions/eligibility/easyPaymentPlan | Transaction Eligibility and Easy Payment Plans
*CreditCardsApi* | [**v1CreditCardsCardIdEasyPaymentPlansBookingsPost**](docs/CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansBookingsPost) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings | Book Easy Payment Plan
*CreditCardsApi* | [**v1CreditCardsCardIdEasyPaymentPlansEligibilityGet**](docs/CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansEligibilityGet) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/eligibility | Check Easy Payment Plan Eligibility
*CreditCardsApi* | [**v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet**](docs/CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/repaymentSchedules | Easy Payment Plan Repayment Schedule
*CreditCardsApi* | [**v1CreditCardsCardIdEasyPaymentPlansSearchPost**](docs/CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansSearchPost) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/search | Retrieve Easy Payment Plans Options
*CreditCardsApi* | [**v1CreditCardsCardIdSupplementaryCardsGet**](docs/CreditCardsApi.md#v1CreditCardsCardIdSupplementaryCardsGet) | **GET** /v1/creditCards/{cardId}/supplementaryCards | List Supplementary Cards
*CreditCardsApi* | [**v1CreditCardsStatementsSummarySearchPost**](docs/CreditCardsApi.md#v1CreditCardsStatementsSummarySearchPost) | **POST** /v1/creditCards/statements/summary/search | Retrieve Composite Credit Cards Statement Summary
*CrossProductUtilitiesApi* | [**activateCard**](docs/CrossProductUtilitiesApi.md#activateCard) | **PUT** /v1/prelogin/cards/{cardId}/activations | This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.
*CrossProductUtilitiesApi* | [**changeAtmPin**](docs/CrossProductUtilitiesApi.md#changeAtmPin) | **PUT** /v1/prelogin/cards/atmPin/change | This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal. In  case this API is exposed to external party, TISO review will be required.
*CrossProductUtilitiesApi* | [**updateIssuedDeviceAllocationDevicePfid**](docs/CrossProductUtilitiesApi.md#updateIssuedDeviceAllocationDevicePfid) | **POST** /v1/issuedDeviceAdministration/device/pfid | This API is used to receive the PFID from partner and maintain across the respective card.
*CustomerFoundationalApi* | [**retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**](docs/CustomerFoundationalApi.md#retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact) | **POST** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts/retrieve | This API is used to inquire the Customer contact details.
*CustomerFoundationalApi* | [**updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**](docs/CustomerFoundationalApi.md#updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact) | **PUT** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts | This API is used to update customer contact details
*DefaultApi* | [**v1CardsCardIdActivationsCardActivationCodePut**](docs/DefaultApi.md#v1CardsCardIdActivationsCardActivationCodePut) | **PUT** /v1/cards/{cardId}/activations/{cardActivationCode} | Update local usage activation
*DefaultApi* | [**v1CardsCardIdLostStolenPut**](docs/DefaultApi.md#v1CardsCardIdLostStolenPut) | **PUT** /v1/cards/{cardId}/lostStolen | Report card as lost or stolen
*DefaultApi* | [**v1CardsCardIdOverseasUsagePut**](docs/DefaultApi.md#v1CardsCardIdOverseasUsagePut) | **PUT** /v1/cards/{cardId}/overseasUsage | Update overseas usage activation
*DefaultApi* | [**v1CardsGet**](docs/DefaultApi.md#v1CardsGet) | **GET** /v1/cards | Retrieve all cards
*DefaultApi* | [**v1CreditCardsCardIdSupplementaryApplicationsPost**](docs/DefaultApi.md#v1CreditCardsCardIdSupplementaryApplicationsPost) | **POST** /v1/creditCards/{cardId}/supplementary/applications | Supplementary Card Application
*DefaultApi* | [**v1CreditCardsCreditLimitsPost**](docs/DefaultApi.md#v1CreditCardsCreditLimitsPost) | **POST** /v1/creditCards/creditLimits | Request credit limit increase
*RewardsApi* | [**v1CreditCardsRewardsPointBalanceSearchPost**](docs/RewardsApi.md#v1CreditCardsRewardsPointBalanceSearchPost) | **POST** /v1/creditCards/rewards/pointBalance/search | This API is used to retrieve reward points balance for multiple credit cards

## Documentation for Models

 - [Account](docs/Account.md)
 - [AccountCurrencyDetails](docs/AccountCurrencyDetails.md)
 - [AccountDetails](docs/AccountDetails.md)
 - [AccountDtls](docs/AccountDtls.md)
 - [ActivateCardRequest](docs/ActivateCardRequest.md)
 - [ActivationRequest](docs/ActivationRequest.md)
 - [Address](docs/Address.md)
 - [AmortizationSchedule](docs/AmortizationSchedule.md)
 - [Applicant](docs/Applicant.md)
 - [BankDetails](docs/BankDetails.md)
 - [BeneficiaryBankDetail](docs/BeneficiaryBankDetail.md)
 - [BeneficiaryDetail](docs/BeneficiaryDetail.md)
 - [BinaryData](docs/BinaryData.md)
 - [CardDetails](docs/CardDetails.md)
 - [CardFunctionsAllowed](docs/CardFunctionsAllowed.md)
 - [CardListingResponse](docs/CardListingResponse.md)
 - [CardOverseasUsageConfirmationRequest](docs/CardOverseasUsageConfirmationRequest.md)
 - [CardStatementSummaryRequest](docs/CardStatementSummaryRequest.md)
 - [CardStatementSummaryResponse](docs/CardStatementSummaryResponse.md)
 - [CardUsageConfirmationRequest](docs/CardUsageConfirmationRequest.md)
 - [CardUsageRequest](docs/CardUsageRequest.md)
 - [CardsLimitsAndEnrollmentsUpdateRequest](docs/CardsLimitsAndEnrollmentsUpdateRequest.md)
 - [ChangeAtmPinRequest](docs/ChangeAtmPinRequest.md)
 - [CompanionCardApplicationRequest](docs/CompanionCardApplicationRequest.md)
 - [CompanionCardApplicationResponse](docs/CompanionCardApplicationResponse.md)
 - [ConsentDetails](docs/ConsentDetails.md)
 - [CorporateOfficerDetails](docs/CorporateOfficerDetails.md)
 - [CountryCodes](docs/CountryCodes.md)
 - [CountrySpecificAddress](docs/CountrySpecificAddress.md)
 - [CreditCardDetails](docs/CreditCardDetails.md)
 - [CreditCardLimitDetails](docs/CreditCardLimitDetails.md)
 - [CreditCardStatement](docs/CreditCardStatement.md)
 - [CreditCardStatementSummary](docs/CreditCardStatementSummary.md)
 - [CreditLimitDecreaseConsentRequest](docs/CreditLimitDecreaseConsentRequest.md)
 - [CreditLimitDecreaseConsentResponse](docs/CreditLimitDecreaseConsentResponse.md)
 - [CreditLimitDecreaseRequest](docs/CreditLimitDecreaseRequest.md)
 - [CreditLimitDecreaseResponse](docs/CreditLimitDecreaseResponse.md)
 - [CreditLimitIncreaseRequest](docs/CreditLimitIncreaseRequest.md)
 - [CreditLimitIncreaseResponse](docs/CreditLimitIncreaseResponse.md)
 - [CurrencyDetails](docs/CurrencyDetails.md)
 - [CvvVerificationRequest](docs/CvvVerificationRequest.md)
 - [Data](docs/Data.md)
 - [DataFeesCharges](docs/DataFeesCharges.md)
 - [DataFeesChargesFeeChargeDetail](docs/DataFeesChargesFeeChargeDetail.md)
 - [DataProductDetails](docs/DataProductDetails.md)
 - [DataProductOfferings](docs/DataProductOfferings.md)
 - [DataPromotions](docs/DataPromotions.md)
 - [DataRequirements](docs/DataRequirements.md)
 - [DataRequirementsApplicant](docs/DataRequirementsApplicant.md)
 - [DataRequirementsDocument](docs/DataRequirementsDocument.md)
 - [DataRequirementsRequirementDetail](docs/DataRequirementsRequirementDetail.md)
 - [DebitCardDetails](docs/DebitCardDetails.md)
 - [DebitCardEnrollmentDetails](docs/DebitCardEnrollmentDetails.md)
 - [DebitCardLimitDetails](docs/DebitCardLimitDetails.md)
 - [Demographics](docs/Demographics.md)
 - [DomesticTransaction](docs/DomesticTransaction.md)
 - [EasyPaymentPlansEligibilityInquiryResponse](docs/EasyPaymentPlansEligibilityInquiryResponse.md)
 - [EasyPaymentPlansTransactionEligibilityResponse](docs/EasyPaymentPlansTransactionEligibilityResponse.md)
 - [EligibleForEqualPaymentPlan](docs/EligibleForEqualPaymentPlan.md)
 - [EmploymentDetails](docs/EmploymentDetails.md)
 - [EppAmortizationSchedule](docs/EppAmortizationSchedule.md)
 - [EppLoanBooking](docs/EppLoanBooking.md)
 - [EppLoanBookingConfirmationRequest](docs/EppLoanBookingConfirmationRequest.md)
 - [EppLoanBookingConfirmationResponse](docs/EppLoanBookingConfirmationResponse.md)
 - [EppLoanBookingRequest](docs/EppLoanBookingRequest.md)
 - [EppLoanBookingResponse](docs/EppLoanBookingResponse.md)
 - [EppOffers](docs/EppOffers.md)
 - [EppRepaymentScheuleResponse](docs/EppRepaymentScheuleResponse.md)
 - [EppRequest](docs/EppRequest.md)
 - [EppResponse](docs/EppResponse.md)
 - [EppTransaction](docs/EppTransaction.md)
 - [ErrorResponse](docs/ErrorResponse.md)
 - [HistoryAndIntradayTransaction](docs/HistoryAndIntradayTransaction.md)
 - [HistoryAndIntradayTransactionRecords](docs/HistoryAndIntradayTransactionRecords.md)
 - [HistoryAndIntradayTransactions](docs/HistoryAndIntradayTransactions.md)
 - [IdentificationDocumentDetails](docs/IdentificationDocumentDetails.md)
 - [InitiateCreditChargeCardCorporateCardsClosureRequest](docs/InitiateCreditChargeCardCorporateCardsClosureRequest.md)
 - [InitiateCreditChargeCardCorporateCardsClosureResponse](docs/InitiateCreditChargeCardCorporateCardsClosureResponse.md)
 - [InternationalTransaction](docs/InternationalTransaction.md)
 - [LinkedAccountDetails](docs/LinkedAccountDetails.md)
 - [ListResponse](docs/ListResponse.md)
 - [Loan](docs/Loan.md)
 - [LoanAccount](docs/LoanAccount.md)
 - [LoanAmortizationSchedule](docs/LoanAmortizationSchedule.md)
 - [LoanPaymentPlans](docs/LoanPaymentPlans.md)
 - [LoanPaymentSchedule](docs/LoanPaymentSchedule.md)
 - [LoanSummary](docs/LoanSummary.md)
 - [Meta](docs/Meta.md)
 - [MultiCurrencyAccountEligibility](docs/MultiCurrencyAccountEligibility.md)
 - [MultiCurrencyAccountEligibilityResponse](docs/MultiCurrencyAccountEligibilityResponse.md)
 - [MultiCurrencyAccountEnrollmentRequest](docs/MultiCurrencyAccountEnrollmentRequest.md)
 - [MultiCurrencyAccountEnrollmentResponse](docs/MultiCurrencyAccountEnrollmentResponse.md)
 - [MultiCurrencyAccountEnrollmentWithCurrencyRequest](docs/MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)
 - [MultiCurrencyAccountEnrollmentWithCurrencyResponse](docs/MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)
 - [Name](docs/Name.md)
 - [NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest](docs/NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.md)
 - [OverseasCardUsageRequest](docs/OverseasCardUsageRequest.md)
 - [OverseasTravelPlanAddRequest](docs/OverseasTravelPlanAddRequest.md)
 - [OverseasTravelPlanInquiryResponse](docs/OverseasTravelPlanInquiryResponse.md)
 - [OverseasTravelPlanUpdateRequest](docs/OverseasTravelPlanUpdateRequest.md)
 - [PartnerCardDetails](docs/PartnerCardDetails.md)
 - [PartnerCardListingResponse](docs/PartnerCardListingResponse.md)
 - [PartnerCustomerDetails](docs/PartnerCustomerDetails.md)
 - [PendingAuthorizationTransaction](docs/PendingAuthorizationTransaction.md)
 - [PendingAuthorizationTransactionRecords](docs/PendingAuthorizationTransactionRecords.md)
 - [PendingAuthorizationTransactions](docs/PendingAuthorizationTransactions.md)
 - [PendingTransaction](docs/PendingTransaction.md)
 - [PermanentCreditLimitIncrease](docs/PermanentCreditLimitIncrease.md)
 - [Phone](docs/Phone.md)
 - [PreviousPrimaryCard](docs/PreviousPrimaryCard.md)
 - [ProductResponse](docs/ProductResponse.md)
 - [ReportLostStolenCardRequest](docs/ReportLostStolenCardRequest.md)
 - [ReportLostStolenCardResponse](docs/ReportLostStolenCardResponse.md)
 - [RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest](docs/RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest.md)
 - [RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest](docs/RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.md)
 - [RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse](docs/RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse.md)
 - [RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest](docs/RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.md)
 - [ResetAtmPinConfirmationRequest](docs/ResetAtmPinConfirmationRequest.md)
 - [ResetAtmPinConfirmationResponse](docs/ResetAtmPinConfirmationResponse.md)
 - [ResetAtmPinRequest](docs/ResetAtmPinRequest.md)
 - [RetrieveCreditChargeCardCorporateCardsCashLimitRequest](docs/RetrieveCreditChargeCardCorporateCardsCashLimitRequest.md)
 - [RetrieveCreditChargeCardCorporateCardsCashLimitResponse](docs/RetrieveCreditChargeCardCorporateCardsCashLimitResponse.md)
 - [RetrieveCreditChargeCardCorporateCardsDetailRequest](docs/RetrieveCreditChargeCardCorporateCardsDetailRequest.md)
 - [RetrieveCreditChargeCardCorporateCardsDetailResponse](docs/RetrieveCreditChargeCardCorporateCardsDetailResponse.md)
 - [RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest](docs/RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.md)
 - [RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse](docs/RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse.md)
 - [RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse](docs/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse.md)
 - [RewardAccount](docs/RewardAccount.md)
 - [RewardPoints](docs/RewardPoints.md)
 - [RewardsInquiryRequest](docs/RewardsInquiryRequest.md)
 - [RewardsInquiryResponse](docs/RewardsInquiryResponse.md)
 - [Statement](docs/Statement.md)
 - [StatementList](docs/StatementList.md)
 - [StatementSummaryRequest](docs/StatementSummaryRequest.md)
 - [SupplementaryCardListingResponse](docs/SupplementaryCardListingResponse.md)
 - [SupplementaryCardRequest](docs/SupplementaryCardRequest.md)
 - [SupplementaryCardResponse](docs/SupplementaryCardResponse.md)
 - [SupplementaryCards](docs/SupplementaryCards.md)
 - [TemporaryCreditLimitIncrease](docs/TemporaryCreditLimitIncrease.md)
 - [TransactionAuthorizationCodes](docs/TransactionAuthorizationCodes.md)
 - [TransactionReferenceId](docs/TransactionReferenceId.md)
 - [TravelPlan](docs/TravelPlan.md)
 - [UnbilledTransaction](docs/UnbilledTransaction.md)
 - [UpdateCreditChargeCardCorporateCardsCashLimitRequest](docs/UpdateCreditChargeCardCorporateCardsCashLimitRequest.md)
 - [UpdateCreditChargeCardCorporateCardsCreditLimitRequest](docs/UpdateCreditChargeCardCorporateCardsCreditLimitRequest.md)
 - [UpdateCreditChargeCardCorporateCardsCreditLimitResponse](docs/UpdateCreditChargeCardCorporateCardsCreditLimitResponse.md)
 - [UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest](docs/UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest.md)
 - [UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse](docs/UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse.md)
 - [UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest](docs/UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest.md)
 - [UpdateIssuedDeviceAllocationDevicePfidRequest](docs/UpdateIssuedDeviceAllocationDevicePfidRequest.md)
 - [UpdateIssuedDeviceAllocationDevicePfidResponse](docs/UpdateIssuedDeviceAllocationDevicePfidResponse.md)

## Documentation for Authorization

All endpoints do not require authorization.
Authentication schemes defined for the API:

## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

