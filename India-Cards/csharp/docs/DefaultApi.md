# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CardsCardIdActivationsCardActivationCodePut**](DefaultApi.md#v1cardscardidactivationscardactivationcodeput) | **PUT** /v1/cards/{cardId}/activations/{cardActivationCode} | Update local usage activation
[**V1CardsCardIdLostStolenPut**](DefaultApi.md#v1cardscardidloststolenput) | **PUT** /v1/cards/{cardId}/lostStolen | Report card as lost or stolen
[**V1CardsCardIdOverseasUsagePut**](DefaultApi.md#v1cardscardidoverseasusageput) | **PUT** /v1/cards/{cardId}/overseasUsage | Update overseas usage activation
[**V1CardsGet**](DefaultApi.md#v1cardsget) | **GET** /v1/cards | Retrieve all cards
[**V1CreditCardsCardIdSupplementaryApplicationsPost**](DefaultApi.md#v1creditcardscardidsupplementaryapplicationspost) | **POST** /v1/creditCards/{cardId}/supplementary/applications | Supplementary Card Application
[**V1CreditCardsCreditLimitsPost**](DefaultApi.md#v1creditcardscreditlimitspost) | **POST** /v1/creditCards/creditLimits | Request credit limit increase

<a name="v1cardscardidactivationscardactivationcodeput"></a>
# **V1CardsCardIdActivationsCardActivationCodePut**
> void V1CardsCardIdActivationsCardActivationCodePut (string uuid, string clientId, string authorization, string cardId, string cardActivationCode, CardUsageRequest body = null)

Update local usage activation

This API is used to activate or deactivate the specified card's ability to be used locally.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdActivationsCardActivationCodePutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var cardId = cardId_example;  // string | Card Id in encrypted format
            var cardActivationCode = cardActivationCode_example;  // string | Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values.
            var body = new CardUsageRequest(); // CardUsageRequest |  (optional) 

            try
            {
                // Update local usage activation
                apiInstance.V1CardsCardIdActivationsCardActivationCodePut(uuid, clientId, authorization, cardId, cardActivationCode, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1CardsCardIdActivationsCardActivationCodePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **cardId** | **string**| Card Id in encrypted format | 
 **cardActivationCode** | **string**| Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values. | 
 **body** | [**CardUsageRequest**](CardUsageRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidloststolenput"></a>
# **V1CardsCardIdLostStolenPut**
> ReportLostStolenCardResponse V1CardsCardIdLostStolenPut (ReportLostStolenCardRequest body, string uuid, string accept, string clientId, string contentType, string authorization, string cardId)

Report card as lost or stolen

This API is used to report a specified card as lost or stolen and returns a reference number to track the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdLostStolenPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ReportLostStolenCardRequest(); // ReportLostStolenCardRequest | 
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var cardId = cardId_example;  // string | Unique Id of the card in encrypted format

            try
            {
                // Report card as lost or stolen
                ReportLostStolenCardResponse result = apiInstance.V1CardsCardIdLostStolenPut(body, uuid, accept, clientId, contentType, authorization, cardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1CardsCardIdLostStolenPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportLostStolenCardRequest**](ReportLostStolenCardRequest.md)|  | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **cardId** | **string**| Unique Id of the card in encrypted format | 

### Return type

[**ReportLostStolenCardResponse**](ReportLostStolenCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidoverseasusageput"></a>
# **V1CardsCardIdOverseasUsagePut**
> void V1CardsCardIdOverseasUsagePut (OverseasCardUsageRequest body, string uuid, string accept, string clientId, string contentType, string authorization, string cardId)

Update overseas usage activation

This API is used to activate or deactivate a specified card's ability to be used overseas. Cards can be activated for overseas usage permanently or for a set period of time.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdOverseasUsagePutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new OverseasCardUsageRequest(); // OverseasCardUsageRequest | 
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var cardId = cardId_example;  // string | Unique Id of the card for activation or de-activation.

            try
            {
                // Update overseas usage activation
                apiInstance.V1CardsCardIdOverseasUsagePut(body, uuid, accept, clientId, contentType, authorization, cardId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1CardsCardIdOverseasUsagePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasCardUsageRequest**](OverseasCardUsageRequest.md)|  | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **cardId** | **string**| Unique Id of the card for activation or de-activation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardsget"></a>
# **V1CardsGet**
> CardListingResponse V1CardsGet (string authorization, string clientId, string uuid, string accept, string cardFunction)

Retrieve all cards

This API is used to retrieve all the credit card numbers and correponding details of the customers who authorized the application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var cardFunction = cardFunction_example;  // string | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.

            try
            {
                // Retrieve all cards
                CardListingResponse result = apiInstance.V1CardsGet(authorization, clientId, uuid, accept, cardFunction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1CardsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **clientId** | **string**| client id generated during consumer onboarding | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **cardFunction** | **string**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 

### Return type

[**CardListingResponse**](CardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscardidsupplementaryapplicationspost"></a>
# **V1CreditCardsCardIdSupplementaryApplicationsPost**
> SupplementaryCardResponse V1CreditCardsCardIdSupplementaryApplicationsPost (string authorization, string uuid, string clientId, string cardId, SupplementaryCardRequest body = null)

Supplementary Card Application

This API is used to authorize Citi Customer to add a Supplementary card to their existing primary card.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCardIdSupplementaryApplicationsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var cardId = cardId_example;  // string | Primary card id in encrypted format.
            var body = new SupplementaryCardRequest(); // SupplementaryCardRequest |  (optional) 

            try
            {
                // Supplementary Card Application
                SupplementaryCardResponse result = apiInstance.V1CreditCardsCardIdSupplementaryApplicationsPost(authorization, uuid, clientId, cardId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1CreditCardsCardIdSupplementaryApplicationsPost: " + e.Message );
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
 **clientId** | **string**| Client ID generated during application registration. | 
 **cardId** | **string**| Primary card id in encrypted format. | 
 **body** | [**SupplementaryCardRequest**](SupplementaryCardRequest.md)|  | [optional] 

### Return type

[**SupplementaryCardResponse**](SupplementaryCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1creditcardscreditlimitspost"></a>
# **V1CreditCardsCreditLimitsPost**
> CreditLimitIncreaseResponse V1CreditCardsCreditLimitsPost (CreditLimitIncreaseRequest body, string uuid, string accept, string clientId, string contentType, string authorization)

Request credit limit increase

This API is used to request for a permanent or temporary credit limit increase on credit card.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsCreditLimitsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new CreditLimitIncreaseRequest(); // CreditLimitIncreaseRequest | 
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.

            try
            {
                // Request credit limit increase
                CreditLimitIncreaseResponse result = apiInstance.V1CreditCardsCreditLimitsPost(body, uuid, accept, clientId, contentType, authorization);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1CreditCardsCreditLimitsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitIncreaseRequest**](CreditLimitIncreaseRequest.md)|  | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 

### Return type

[**CreditLimitIncreaseResponse**](CreditLimitIncreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
