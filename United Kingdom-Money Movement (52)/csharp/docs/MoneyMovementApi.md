# IO.Swagger.Api.MoneyMovementApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountProxyTransfers**](MoneyMovementApi.md#accountproxytransfers) | **POST** /v1/moneyMovement/accountProxyTransfers | Allows the customer to transfer fund from customer to proxy registered account.
[**AccountProxyTransfersConfirmation**](MoneyMovementApi.md#accountproxytransfersconfirmation) | **POST** /v1/moneyMovement/accountProxyTransfers/confirmation | This API allows the customer to transfer fund from customer to proxy registered account if MFA interdicts.
[**AccountProxyTransfersPreprocess**](MoneyMovementApi.md#accountproxytransferspreprocess) | **POST** /v1/moneyMovement/accountProxyTransfers/preprocess | This API is used to do pre-process activities for proxy payments.This handle the exchange rate, fees and charges.
[**AccountProxyTransfersSourceAccountEligibility**](MoneyMovementApi.md#accountproxytransferssourceaccounteligibility) | **GET** /v1/moneyMovement/accountProxyTransfers/sourceAccounts | This API return eligible source accounts for account proxy transfers.
[**AdhocAccountProxyTransfersPreprocessWithAddPayee**](MoneyMovementApi.md#adhocaccountproxytransferspreprocesswithaddpayee) | **POST** /v1/moneyMovement/accountProxyTransfers/preprocess/adhocWithPayeeCreation | This API is used to do pre-process activities for adhoc proxy payments.This handle the exchange rate, fees and charges.
[**BillDetailsInquiry**](MoneyMovementApi.md#billdetailsinquiry) | **GET** /v1/moneyMovement/billPayments/payees/{payeeId}/billDetails | This API returns additional Bill details for an existing bill payments payee from Mpay.
[**V1MoneyMovementDestinationCountriesGet**](MoneyMovementApi.md#v1moneymovementdestinationcountriesget) | **GET** /v1/moneyMovement/destinationCountries | This API allows to inquire list of countries along with country code and country bank branch identifier.
[**V1MoneyMovementExternalDomesticTransfersConfirmationPost**](MoneyMovementApi.md#v1moneymovementexternaldomestictransfersconfirmationpost) | **POST** /v1/moneyMovement/externalDomesticTransfers/confirmation | This API is to confirm external domestic transfers post Multi Factor Authentication.
[**V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost**](MoneyMovementApi.md#v1moneymovementexternaldomestictransferspreprocessadhocwithpayeecreationpost) | **POST** /v1/moneyMovement/externalDomesticTransfers/preprocess/adhocWithPayeeCreation | This API is used to do preprocess activities for externalDomesticTransfer. This handle the exchange rate, fees and charges.This API also allows to send request to  enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.
[**V1MoneyMovementExternalDomesticTransfersPreprocessPost**](MoneyMovementApi.md#v1moneymovementexternaldomestictransferspreprocesspost) | **POST** /v1/moneyMovement/externalDomesticTransfers/preprocess | Pre-process activities for transfer/payment that handle the exchange rate, fees and charges.
[**V1MoneyMovementInternalDomesticTransfersConfirmationPost**](MoneyMovementApi.md#v1moneymovementinternaldomestictransfersconfirmationpost) | **POST** /v1/moneyMovement/internalDomesticTransfers/confirmation | This API is to confirm internal domestic transfers post Multi Factor Authentication.
[**V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost**](MoneyMovementApi.md#v1moneymovementinternaldomestictransferspreprocessadhocwithpayeecreationpost) | **POST** /v1/moneyMovement/internalDomesticTransfers/preprocess/adhocWithPayeeCreation | This API allows customer to make adhoc transfers within CITIBANK for a same country.This handle the exchange rate, fees and charges. This API also allows to send request to enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.
[**V1MoneyMovementPayeesPayeeIdDetailsGet**](MoneyMovementApi.md#v1moneymovementpayeespayeeiddetailsget) | **GET** /v1/moneyMovement/payees/{payeeId}/details | Retrieve Payee Additional Details by Payee Id
[**V1MoneyMovementPersonalDomesticTransfersConfirmationPost**](MoneyMovementApi.md#v1moneymovementpersonaldomestictransfersconfirmationpost) | **POST** /v1/moneyMovement/personalDomesticTransfers/confirmation | This API is to confirm personal domestic transfers post Multi Factor Authentication.

<a name="accountproxytransfers"></a>
# **AccountProxyTransfers**
> AccountProxyTransfersResponse AccountProxyTransfers (AccountProxyTransfersRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Allows the customer to transfer fund from customer to proxy registered account.

Allows the customer to transfer fund from customer to proxy registered account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountProxyTransfersExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new AccountProxyTransfersRequest(); // AccountProxyTransfersRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Allows the customer to transfer fund from customer to proxy registered account.
                AccountProxyTransfersResponse result = apiInstance.AccountProxyTransfers(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.AccountProxyTransfers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountProxyTransfersRequest**](AccountProxyTransfersRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AccountProxyTransfersResponse**](AccountProxyTransfersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountproxytransfersconfirmation"></a>
# **AccountProxyTransfersConfirmation**
> AccountProxyTransfersConfirmationResponse AccountProxyTransfersConfirmation (AccountProxyTransfersConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API allows the customer to transfer fund from customer to proxy registered account if MFA interdicts.

This API allows the customer to transfer fund from customer to proxy registered account if MFA interdicts.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountProxyTransfersConfirmationExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new AccountProxyTransfersConfirmationRequest(); // AccountProxyTransfersConfirmationRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API allows the customer to transfer fund from customer to proxy registered account if MFA interdicts.
                AccountProxyTransfersConfirmationResponse result = apiInstance.AccountProxyTransfersConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.AccountProxyTransfersConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountProxyTransfersConfirmationRequest**](AccountProxyTransfersConfirmationRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AccountProxyTransfersConfirmationResponse**](AccountProxyTransfersConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountproxytransferspreprocess"></a>
# **AccountProxyTransfersPreprocess**
> AccountProxyTransfersPreprocessResponse AccountProxyTransfersPreprocess (AccountProxyTransfersPreprocessRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to do pre-process activities for proxy payments.This handle the exchange rate, fees and charges.

This API is used to do pre-process activities for proxy payments.This handle the exchange rate, fees and charges.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountProxyTransfersPreprocessExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new AccountProxyTransfersPreprocessRequest(); // AccountProxyTransfersPreprocessRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to do pre-process activities for proxy payments.This handle the exchange rate, fees and charges.
                AccountProxyTransfersPreprocessResponse result = apiInstance.AccountProxyTransfersPreprocess(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.AccountProxyTransfersPreprocess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountProxyTransfersPreprocessRequest**](AccountProxyTransfersPreprocessRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AccountProxyTransfersPreprocessResponse**](AccountProxyTransfersPreprocessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="accountproxytransferssourceaccounteligibility"></a>
# **AccountProxyTransfersSourceAccountEligibility**
> AccountProxyTransfersSourceAccountEligibilityResponse AccountProxyTransfersSourceAccountEligibility (string authorization, string uuid, string accept, string clientId, string proxyPaymentType, string clientDetails = null, string nextStartIndex = null)

This API return eligible source accounts for account proxy transfers.

This API return eligible source accounts for account proxy transfers.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountProxyTransfersSourceAccountEligibilityExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var proxyPaymentType = proxyPaymentType_example;  // string | The type of proxy payment.This is a reference data field. Please use /v1/utilities/referenceData/{proxyPaymentType} resource to get valid value of this field with description.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // This API return eligible source accounts for account proxy transfers.
                AccountProxyTransfersSourceAccountEligibilityResponse result = apiInstance.AccountProxyTransfersSourceAccountEligibility(authorization, uuid, accept, clientId, proxyPaymentType, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.AccountProxyTransfersSourceAccountEligibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **proxyPaymentType** | **string**| The type of proxy payment.This is a reference data field. Please use /v1/utilities/referenceData/{proxyPaymentType} resource to get valid value of this field with description. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**AccountProxyTransfersSourceAccountEligibilityResponse**](AccountProxyTransfersSourceAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="adhocaccountproxytransferspreprocesswithaddpayee"></a>
# **AdhocAccountProxyTransfersPreprocessWithAddPayee**
> AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse AdhocAccountProxyTransfersPreprocessWithAddPayee (AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to do pre-process activities for adhoc proxy payments.This handle the exchange rate, fees and charges.

This API is used to do pre-process activities for adhoc proxy payments.This handle the exchange rate, fees and charges.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AdhocAccountProxyTransfersPreprocessWithAddPayeeExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest(); // AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to do pre-process activities for adhoc proxy payments.This handle the exchange rate, fees and charges.
                AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse result = apiInstance.AdhocAccountProxyTransfersPreprocessWithAddPayee(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.AdhocAccountProxyTransfersPreprocessWithAddPayee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest**](AdhocAccountProxyTransfersPreprocessWithAddPayeeRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse**](AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="billdetailsinquiry"></a>
# **BillDetailsInquiry**
> BillDetailsInquiryResponse BillDetailsInquiry (string authorization, string uuid, string accept, string clientId, string payeeId, string clientDetails = null)

This API returns additional Bill details for an existing bill payments payee from Mpay.

This API returns additional Bill details for an existing bill payments payee from Mpay.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BillDetailsInquiryExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var payeeId = payeeId_example;  // string | Unique identifier associated with the payee.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API returns additional Bill details for an existing bill payments payee from Mpay.
                BillDetailsInquiryResponse result = apiInstance.BillDetailsInquiry(authorization, uuid, accept, clientId, payeeId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.BillDetailsInquiry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **payeeId** | **string**| Unique identifier associated with the payee. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**BillDetailsInquiryResponse**](BillDetailsInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementdestinationcountriesget"></a>
# **V1MoneyMovementDestinationCountriesGet**
> DestinationListResponse V1MoneyMovementDestinationCountriesGet (string authorization, string uuid, string accept, string clientId, string clientDetails = null, string nextStartIndex = null)

This API allows to inquire list of countries along with country code and country bank branch identifier.

This API allows to inquire list of countries along with country code and country bank branch identifier.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementDestinationCountriesGetExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer on-boarding
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // This API allows to inquire list of countries along with country code and country bank branch identifier.
                DestinationListResponse result = apiInstance.V1MoneyMovementDestinationCountriesGet(authorization, uuid, accept, clientId, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementDestinationCountriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer on-boarding | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**DestinationListResponse**](DestinationListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementexternaldomestictransfersconfirmationpost"></a>
# **V1MoneyMovementExternalDomesticTransfersConfirmationPost**
> ExternalDomesticTransferConfirmationResponse V1MoneyMovementExternalDomesticTransfersConfirmationPost (ExternalDomesticTransferConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is to confirm external domestic transfers post Multi Factor Authentication.

This API is to confirm external domestic transfers post Multi Factor Authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementExternalDomesticTransfersConfirmationPostExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new ExternalDomesticTransferConfirmationRequest(); // ExternalDomesticTransferConfirmationRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to confirm external domestic transfers post Multi Factor Authentication.
                ExternalDomesticTransferConfirmationResponse result = apiInstance.V1MoneyMovementExternalDomesticTransfersConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementExternalDomesticTransfersConfirmationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExternalDomesticTransferConfirmationRequest**](ExternalDomesticTransferConfirmationRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ExternalDomesticTransferConfirmationResponse**](ExternalDomesticTransferConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementexternaldomestictransferspreprocessadhocwithpayeecreationpost"></a>
# **V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost**
> AdhocExtDmstcTransferPreprocessWithAddPayeeResponse V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost (AdhocExtDmstcTransferPreprocessWithAddPayeeRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to do preprocess activities for externalDomesticTransfer. This handle the exchange rate, fees and charges.This API also allows to send request to  enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.

This API is used to do preprocess activities for externalDomesticTransfer. This handle the exchange rate, fees and charges.This API also allows to send request to  enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPostExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new AdhocExtDmstcTransferPreprocessWithAddPayeeRequest(); // AdhocExtDmstcTransferPreprocessWithAddPayeeRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to do preprocess activities for externalDomesticTransfer. This handle the exchange rate, fees and charges.This API also allows to send request to  enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.
                AdhocExtDmstcTransferPreprocessWithAddPayeeResponse result = apiInstance.V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementExternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdhocExtDmstcTransferPreprocessWithAddPayeeRequest**](AdhocExtDmstcTransferPreprocessWithAddPayeeRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AdhocExtDmstcTransferPreprocessWithAddPayeeResponse**](AdhocExtDmstcTransferPreprocessWithAddPayeeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementexternaldomestictransferspreprocesspost"></a>
# **V1MoneyMovementExternalDomesticTransfersPreprocessPost**
> PreprocessForFundTransferResponse V1MoneyMovementExternalDomesticTransfersPreprocessPost (PreprocessFundTransferRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Pre-process activities for transfer/payment that handle the exchange rate, fees and charges.

This API allows you to pre process the External domestic transfer transaction for any errors and check the validity of all inputs. The result of this is shown in a pre-confirmation or review details type of page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementExternalDomesticTransfersPreprocessPostExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new PreprocessFundTransferRequest(); // PreprocessFundTransferRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Pre-process activities for transfer/payment that handle the exchange rate, fees and charges.
                PreprocessForFundTransferResponse result = apiInstance.V1MoneyMovementExternalDomesticTransfersPreprocessPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementExternalDomesticTransfersPreprocessPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PreprocessFundTransferRequest**](PreprocessFundTransferRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**PreprocessForFundTransferResponse**](PreprocessForFundTransferResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementinternaldomestictransfersconfirmationpost"></a>
# **V1MoneyMovementInternalDomesticTransfersConfirmationPost**
> InternalDomesticTransferConfirmationResponse V1MoneyMovementInternalDomesticTransfersConfirmationPost (InternalDomesticTransferConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is to confirm internal domestic transfers post Multi Factor Authentication.

This API is to confirm internal domestic transfers post Multi Factor Authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementInternalDomesticTransfersConfirmationPostExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new InternalDomesticTransferConfirmationRequest(); // InternalDomesticTransferConfirmationRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to confirm internal domestic transfers post Multi Factor Authentication.
                InternalDomesticTransferConfirmationResponse result = apiInstance.V1MoneyMovementInternalDomesticTransfersConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementInternalDomesticTransfersConfirmationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InternalDomesticTransferConfirmationRequest**](InternalDomesticTransferConfirmationRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**InternalDomesticTransferConfirmationResponse**](InternalDomesticTransferConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementinternaldomestictransferspreprocessadhocwithpayeecreationpost"></a>
# **V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost**
> AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost (AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API allows customer to make adhoc transfers within CITIBANK for a same country.This handle the exchange rate, fees and charges. This API also allows to send request to enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.

This API allows customer to make adhoc transfers within CITIBANK for a same country.This handle the exchange rate, fees and charges. This API also allows to send request to enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPostExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest(); // AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API allows customer to make adhoc transfers within CITIBANK for a same country.This handle the exchange rate, fees and charges. This API also allows to send request to enroll the payee in registered list of payees, however  registration of payee in  payee list takes place in  subsequent confirmation APIs.
                AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse result = apiInstance.V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementInternalDomesticTransfersPreprocessAdhocWithPayeeCreationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest**](AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse**](AdhocInternalDmstcTransferPreprocessWithAddPayeeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementpayeespayeeiddetailsget"></a>
# **V1MoneyMovementPayeesPayeeIdDetailsGet**
> PayeeDetailsResponse V1MoneyMovementPayeesPayeeIdDetailsGet (string authorization, string uuid, string accept, string clientId, string payeeId, string clientDetails = null)

Retrieve Payee Additional Details by Payee Id

This API returns the additional payee details associated with a payee id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementPayeesPayeeIdDetailsGetExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var payeeId = payeeId_example;  // string | Unique identifier associated with the payee.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Retrieve Payee Additional Details by Payee Id
                PayeeDetailsResponse result = apiInstance.V1MoneyMovementPayeesPayeeIdDetailsGet(authorization, uuid, accept, clientId, payeeId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementPayeesPayeeIdDetailsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **payeeId** | **string**| Unique identifier associated with the payee. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**PayeeDetailsResponse**](PayeeDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1moneymovementpersonaldomestictransfersconfirmationpost"></a>
# **V1MoneyMovementPersonalDomesticTransfersConfirmationPost**
> PersonalDomesticTransferConfirmationResponse V1MoneyMovementPersonalDomesticTransfersConfirmationPost (PersonalDomesticTransferConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is to confirm personal domestic transfers post Multi Factor Authentication.

This API is to confirm personal domestic transfers post Multi Factor Authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1MoneyMovementPersonalDomesticTransfersConfirmationPostExample
    {
        public void main()
        {
            var apiInstance = new MoneyMovementApi();
            var body = new PersonalDomesticTransferConfirmationRequest(); // PersonalDomesticTransferConfirmationRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to confirm personal domestic transfers post Multi Factor Authentication.
                PersonalDomesticTransferConfirmationResponse result = apiInstance.V1MoneyMovementPersonalDomesticTransfersConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MoneyMovementApi.V1MoneyMovementPersonalDomesticTransfersConfirmationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PersonalDomesticTransferConfirmationRequest**](PersonalDomesticTransferConfirmationRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**PersonalDomesticTransferConfirmationResponse**](PersonalDomesticTransferConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
