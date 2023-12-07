# IO.Swagger.Api.CreditCardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompanionCardApplication**](CreditCardsApi.md#companioncardapplication) | **POST** /v1/creditCards/{cardId}/companion/applications | Issuance of Companion Card
[**EasyPaymentPlansTransactionEligibility**](CreditCardsApi.md#easypaymentplanstransactioneligibility) | **GET** /v1/creditCards/{cardId}/transactions/eligibility/easyPaymentPlan | Transaction Eligibility and Easy Payment Plans
[**V1CreditCardsCardIdEasyPaymentPlansBookingsPost**](CreditCardsApi.md#v1creditcardscardideasypaymentplansbookingspost) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings | Book Easy Payment Plan
[**V1CreditCardsCardIdEasyPaymentPlansEligibilityGet**](CreditCardsApi.md#v1creditcardscardideasypaymentplanseligibilityget) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/eligibility | Check Easy Payment Plan Eligibility
[**V1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet**](CreditCardsApi.md#v1creditcardscardideasypaymentplansrepaymentschedulesget) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/repaymentSchedules | Easy Payment Plan Repayment Schedule
[**V1CreditCardsCardIdEasyPaymentPlansSearchPost**](CreditCardsApi.md#v1creditcardscardideasypaymentplanssearchpost) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/search | Retrieve Easy Payment Plans Options
[**V1CreditCardsCardIdSupplementaryCardsGet**](CreditCardsApi.md#v1creditcardscardidsupplementarycardsget) | **GET** /v1/creditCards/{cardId}/supplementaryCards | List Supplementary Cards
[**V1CreditCardsStatementsSummarySearchPost**](CreditCardsApi.md#v1creditcardsstatementssummarysearchpost) | **POST** /v1/creditCards/statements/summary/search | Retrieve Composite Credit Cards Statement Summary

<a name="companioncardapplication"></a>
# **CompanionCardApplication**
> CompanionCardApplicationResponse CompanionCardApplication (string authorization, string uuid, string accept, string contentType, string clientId, string cardId, CompanionCardApplicationRequest body = null, string clientDetails = null)

Issuance of Companion Card

This API is used to issue a new companion card for primary credit card.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompanionCardApplicationExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var contentType = contentType_example;  // string | The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var cardId = cardId_example;  // string | Card Id in encrypted format
            var body = new CompanionCardApplicationRequest(); // CompanionCardApplicationRequest | CompanionCardApplicationRequest (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Issuance of Companion Card
                CompanionCardApplicationResponse result = apiInstance.CompanionCardApplication(authorization, uuid, accept, contentType, clientId, cardId, body, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.CompanionCardApplication: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **contentType** | **string**| The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **cardId** | **string**| Card Id in encrypted format | 
 **body** | [**CompanionCardApplicationRequest**](CompanionCardApplicationRequest.md)| CompanionCardApplicationRequest | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CompanionCardApplicationResponse**](CompanionCardApplicationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="easypaymentplanstransactioneligibility"></a>
# **EasyPaymentPlansTransactionEligibility**
> EasyPaymentPlansTransactionEligibilityResponse EasyPaymentPlansTransactionEligibility (string authorization, string uuid, string accept, string clientId, string cardId, double? eligbleLoanAmount, string clientDetails = null)

Transaction Eligibility and Easy Payment Plans

This API is used to check the Easy Payment Plans eligibility for a card and the available Payment Plans details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EasyPaymentPlansTransactionEligibilityExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var cardId = cardId_example;  // string | The card id in encrypted format.
            var eligbleLoanAmount = 1.2;  // double? | Elligible loan amount for easy payment plan booking..
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Transaction Eligibility and Easy Payment Plans
                EasyPaymentPlansTransactionEligibilityResponse result = apiInstance.EasyPaymentPlansTransactionEligibility(authorization, uuid, accept, clientId, cardId, eligbleLoanAmount, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.EasyPaymentPlansTransactionEligibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **cardId** | **string**| The card id in encrypted format. | 
 **eligbleLoanAmount** | **double?**| Elligible loan amount for easy payment plan booking.. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EasyPaymentPlansTransactionEligibilityResponse**](EasyPaymentPlansTransactionEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscardideasypaymentplansbookingspost"></a>
# **V1CreditCardsCardIdEasyPaymentPlansBookingsPost**
> EppLoanBookingResponse V1CreditCardsCardIdEasyPaymentPlansBookingsPost (EppLoanBookingRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

Book Easy Payment Plan

This API is triggered after the EPP plan selection and completes the EPP booking. On successful booking, it returns transaction reference in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCardIdEasyPaymentPlansBookingsPostExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var body = new EppLoanBookingRequest(); // EppLoanBookingRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The card id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Book Easy Payment Plan
                EppLoanBookingResponse result = apiInstance.V1CreditCardsCardIdEasyPaymentPlansBookingsPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.V1CreditCardsCardIdEasyPaymentPlansBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppLoanBookingRequest**](EppLoanBookingRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The card id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EppLoanBookingResponse**](EppLoanBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscardideasypaymentplanseligibilityget"></a>
# **V1CreditCardsCardIdEasyPaymentPlansEligibilityGet**
> EasyPaymentPlansEligibilityInquiryResponse V1CreditCardsCardIdEasyPaymentPlansEligibilityGet (string authorization, string uuid, string accept, string clientId, string cardId, string eppLoanBookingType, string clientDetails = null, string nextStartIndex = null)

Check Easy Payment Plan Eligibility

This API is used to validate the transaction eligibility for EPP conversion.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCardIdEasyPaymentPlansEligibilityGetExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client_id generated during consumer onboarding
            var cardId = cardId_example;  // string | Card Id in encrypted format.
            var eppLoanBookingType = eppLoanBookingType_example;  // string | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // Check Easy Payment Plan Eligibility
                EasyPaymentPlansEligibilityInquiryResponse result = apiInstance.V1CreditCardsCardIdEasyPaymentPlansEligibilityGet(authorization, uuid, accept, clientId, cardId, eppLoanBookingType, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.V1CreditCardsCardIdEasyPaymentPlansEligibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client_id generated during consumer onboarding | 
 **cardId** | **string**| Card Id in encrypted format. | 
 **eppLoanBookingType** | **string**| Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**EasyPaymentPlansEligibilityInquiryResponse**](EasyPaymentPlansEligibilityInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscardideasypaymentplansrepaymentschedulesget"></a>
# **V1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet**
> EppRepaymentScheuleResponse V1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet (string authorization, string uuid, string accept, string clientId, string cardId, double? loanAmount, decimal? tenor, string clientDetails = null, string nextStartIndex = null)

Easy Payment Plan Repayment Schedule

This API allows the customer to view the payment breakdown details and the repayment schedule for the Easy Payment Plan selected.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGetExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var cardId = cardId_example;  // string | The card id  in encrypted format.
            var loanAmount = 1.2;  // double? | Loan amount for easy payment plan booking.
            var tenor = 1.2;  // decimal? | Tenure of loan in months.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // Easy Payment Plan Repayment Schedule
                EppRepaymentScheuleResponse result = apiInstance.V1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet(authorization, uuid, accept, clientId, cardId, loanAmount, tenor, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.V1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer onboarding | 
 **cardId** | **string**| The card id  in encrypted format. | 
 **loanAmount** | **double?**| Loan amount for easy payment plan booking. | 
 **tenor** | **decimal?**| Tenure of loan in months. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**EppRepaymentScheuleResponse**](EppRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscardideasypaymentplanssearchpost"></a>
# **V1CreditCardsCardIdEasyPaymentPlansSearchPost**
> EppResponse V1CreditCardsCardIdEasyPaymentPlansSearchPost (EppRequest body, string authorization, string uuid, string accept, string clientId, string cardId, string clientDetails = null)

Retrieve Easy Payment Plans Options

This API retrieves the available Easy Payment Plans to be used by the customer for the repayment of his/her loans.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCardIdEasyPaymentPlansSearchPostExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var body = new EppRequest(); // EppRequest | Easy payment plan Request
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var cardId = cardId_example;  // string | The card id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Retrieve Easy Payment Plans Options
                EppResponse result = apiInstance.V1CreditCardsCardIdEasyPaymentPlansSearchPost(body, authorization, uuid, accept, clientId, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.V1CreditCardsCardIdEasyPaymentPlansSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppRequest**](EppRequest.md)| Easy payment plan Request | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer onboarding | 
 **cardId** | **string**| The card id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EppResponse**](EppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscardidsupplementarycardsget"></a>
# **V1CreditCardsCardIdSupplementaryCardsGet**
> SupplementaryCardListingResponse V1CreditCardsCardIdSupplementaryCardsGet (string authorization, string uuid, string accept, string clientId, string cardId, string clientDetails = null)

List Supplementary Cards

This API retrieves the details of all the supplementary cards associated with the primary card id in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCardIdSupplementaryCardsGetExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var cardId = cardId_example;  // string | The primary card id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // List Supplementary Cards
                SupplementaryCardListingResponse result = apiInstance.V1CreditCardsCardIdSupplementaryCardsGet(authorization, uuid, accept, clientId, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.V1CreditCardsCardIdSupplementaryCardsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer onboarding | 
 **cardId** | **string**| The primary card id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SupplementaryCardListingResponse**](SupplementaryCardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardsstatementssummarysearchpost"></a>
# **V1CreditCardsStatementsSummarySearchPost**
> CardStatementSummaryResponse V1CreditCardsStatementsSummarySearchPost (CardStatementSummaryRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Retrieve Composite Credit Cards Statement Summary

This API is used to retrieve the statement summary for multiple credit cards in a single request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsStatementsSummarySearchPostExample
    {
        public void main()
        {
            var apiInstance = new CreditCardsApi();
            var body = new CardStatementSummaryRequest(); // CardStatementSummaryRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Retrieve Composite Credit Cards Statement Summary
                CardStatementSummaryResponse result = apiInstance.V1CreditCardsStatementsSummarySearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CreditCardsApi.V1CreditCardsStatementsSummarySearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardStatementSummaryRequest**](CardStatementSummaryRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CardStatementSummaryResponse**](CardStatementSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
