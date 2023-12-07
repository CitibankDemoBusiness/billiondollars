# IO.Swagger.Api.CARDSApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**](CARDSApi.md#notifycreditchargecardfulfillmentarrangementauthorisedtransaction) | **POST** /partner/v1/creditChargeCard/transaction/authorised/notify | This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

<a name="notifycreditchargecardfulfillmentarrangementauthorisedtransaction"></a>
# **NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**
> void NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body, string authorization, string uuid, string accept, string contentType, string clientId = null, string clientDetails = null, string acceptLanguage = null, string xJwsSignature = null)

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionExample
    {
        public void main()
        {
            var apiInstance = new CARDSApi();
            var body = new NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest(); // NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest | NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest
            var authorization = authorization_example;  // string | HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var contentType = contentType_example;  // string | application/json
            var clientId = clientId_example;  // string | Client ID generated during application registration. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var xJwsSignature = xJwsSignature_example;  // string | This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional) 

            try
            {
                // This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
                apiInstance.NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction(body, authorization, uuid, accept, contentType, clientId, clientDetails, acceptLanguage, xJwsSignature);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CARDSApi.NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest**](NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.md)| NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest | 
 **authorization** | **string**| HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **contentType** | **string**| application/json | 
 **clientId** | **string**| Client ID generated during application registration. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **xJwsSignature** | **string**| This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
