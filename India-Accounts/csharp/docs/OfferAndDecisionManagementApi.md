# IO.Swagger.Api.OfferAndDecisionManagementApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**](OfferAndDecisionManagementApi.md#executeapplicationprocessingunsecuredloantopupofferacceptanceandsubmission) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/offerAcceptanceAndSubmission | This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit
[**InitiateApplicationProcessingUnsecuredLoanTopup**](OfferAndDecisionManagementApi.md#initiateapplicationprocessingunsecuredloantopup) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications | This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
[**RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**](OfferAndDecisionManagementApi.md#retrieveapplicationprocessingunsecuredloantopuprepaymentschedule) | **GET** /v1/applicationProcessing/products/unsecuredLoans/topup/repaymentSchedule | This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
[**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**](OfferAndDecisionManagementApi.md#updateapplicationprocessingunsecuredloantopupbackgroundscreening) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/backgroundScreening | This API is used to update a saved Loan top-up application &amp; do background screening
[**UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**](OfferAndDecisionManagementApi.md#updateapplicationprocessingunsecuredloantopupinprincipalapproval) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/inPrincipleApprovals | This API is used to update a saved Loan top-up application and in principle approval

<a name="executeapplicationprocessingunsecuredloantopupofferacceptanceandsubmission"></a>
# **ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**
> void ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission (ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

This API is used to perform offer acceptance for Loan Top Up Application & final submit

This API is used to perform offer acceptance for Loan Top Up Application & final submit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionExample
    {
        public void main()
        {
            var apiInstance = new OfferAndDecisionManagementApi();
            var body = new ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest(); // ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest | ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to perform offer acceptance for Loan Top Up Application & final submit
                apiInstance.ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferAndDecisionManagementApi.ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest**](ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest.md)| ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**|  | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="initiateapplicationprocessingunsecuredloantopup"></a>
# **InitiateApplicationProcessingUnsecuredLoanTopup**
> InitiateApplicationProcessingUnsecuredLoanTopupResponse InitiateApplicationProcessingUnsecuredLoanTopup (InitiateApplicationProcessingUnsecuredLoanTopupRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiateApplicationProcessingUnsecuredLoanTopupExample
    {
        public void main()
        {
            var apiInstance = new OfferAndDecisionManagementApi();
            var body = new InitiateApplicationProcessingUnsecuredLoanTopupRequest(); // InitiateApplicationProcessingUnsecuredLoanTopupRequest | InitiateApplicationProcessingUnsecuredLoanTopupRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
                InitiateApplicationProcessingUnsecuredLoanTopupResponse result = apiInstance.InitiateApplicationProcessingUnsecuredLoanTopup(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferAndDecisionManagementApi.InitiateApplicationProcessingUnsecuredLoanTopup: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiateApplicationProcessingUnsecuredLoanTopupRequest**](InitiateApplicationProcessingUnsecuredLoanTopupRequest.md)| InitiateApplicationProcessingUnsecuredLoanTopupRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**InitiateApplicationProcessingUnsecuredLoanTopupResponse**](InitiateApplicationProcessingUnsecuredLoanTopupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrieveapplicationprocessingunsecuredloantopuprepaymentschedule"></a>
# **RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**
> RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule (string authorization, string uuid, string accept, string clientId, string contentType, double? loanAmount, double? insurancePremiumAmount, double? feeAmount, double? loanInterestRate, int? tenor, string clientDetails = null)

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleExample
    {
        public void main()
        {
            var apiInstance = new OfferAndDecisionManagementApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var loanAmount = 1.2;  // double? | Loan amount
            var insurancePremiumAmount = 1.2;  // double? | Insurance premium amount
            var feeAmount = 1.2;  // double? | Fee amount
            var loanInterestRate = 1.2;  // double? | Loan interest rate
            var tenor = 56;  // int? | Tenor
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
                RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse result = apiInstance.RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule(authorization, uuid, accept, clientId, contentType, loanAmount, insurancePremiumAmount, feeAmount, loanInterestRate, tenor, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferAndDecisionManagementApi.RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule: " + e.Message );
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
 **contentType** | **string**| application/json | 
 **loanAmount** | **double?**| Loan amount | 
 **insurancePremiumAmount** | **double?**| Insurance premium amount | 
 **feeAmount** | **double?**| Fee amount | 
 **loanInterestRate** | **double?**| Loan interest rate | 
 **tenor** | **int?**| Tenor | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse**](RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapplicationprocessingunsecuredloantopupbackgroundscreening"></a>
# **UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**
> UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreening (UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

This API is used to update a saved Loan top-up application & do background screening

This API is used to update a saved Loan top-up application & do background screening

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningExample
    {
        public void main()
        {
            var apiInstance = new OfferAndDecisionManagementApi();
            var body = new UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest(); // UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest | UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to update a saved Loan top-up application & do background screening
                UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse result = apiInstance.UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreening(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferAndDecisionManagementApi.UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreening: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest**](UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.md)| UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**|  | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse**](UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateapplicationprocessingunsecuredloantopupinprincipalapproval"></a>
# **UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**
> UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval (RequestedLoanTopupDecision body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

This API is used to update a saved Loan top-up application and in principle approval

This API is used to update a saved Loan top-up application and in principle approval

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalExample
    {
        public void main()
        {
            var apiInstance = new OfferAndDecisionManagementApi();
            var body = new RequestedLoanTopupDecision(); // RequestedLoanTopupDecision | RequestedLoanTopupDecision
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to update a saved Loan top-up application and in principle approval
                UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse result = apiInstance.UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferAndDecisionManagementApi.UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestedLoanTopupDecision**](RequestedLoanTopupDecision.md)| RequestedLoanTopupDecision | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**|  | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse**](UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
