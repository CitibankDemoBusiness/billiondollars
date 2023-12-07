# IO.Swagger.Api.CustomerFoundationalApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EvaluateCustomerEligibilityAssessmentCheckPreLogin**](CustomerFoundationalApi.md#evaluatecustomereligibilityassessmentcheckprelogin) | **GET** /v1/preLogin/customerProductServiceEligibility/check/offers/{offerId} | This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

<a name="evaluatecustomereligibilityassessmentcheckprelogin"></a>
# **EvaluateCustomerEligibilityAssessmentCheckPreLogin**
> EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse EvaluateCustomerEligibilityAssessmentCheckPreLogin (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null)

This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EvaluateCustomerEligibilityAssessmentCheckPreLoginExample
    {
        public void main()
        {
            var apiInstance = new CustomerFoundationalApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var loanAmount = 1.2;  // decimal? | Loan amount for easy payment plan booking. (optional) 

            try
            {
                // This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
                EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse result = apiInstance.EvaluateCustomerEligibilityAssessmentCheckPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, loanAmount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFoundationalApi.EvaluateCustomerEligibilityAssessmentCheckPreLogin: " + e.Message );
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
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **loanAmount** | **decimal?**| Loan amount for easy payment plan booking. | [optional] 

### Return type

[**EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse**](EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
