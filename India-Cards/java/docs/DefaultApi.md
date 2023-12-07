# DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1CardsCardIdActivationsCardActivationCodePut**](DefaultApi.md#v1CardsCardIdActivationsCardActivationCodePut) | **PUT** /v1/cards/{cardId}/activations/{cardActivationCode} | Update local usage activation
[**v1CardsCardIdLostStolenPut**](DefaultApi.md#v1CardsCardIdLostStolenPut) | **PUT** /v1/cards/{cardId}/lostStolen | Report card as lost or stolen
[**v1CardsCardIdOverseasUsagePut**](DefaultApi.md#v1CardsCardIdOverseasUsagePut) | **PUT** /v1/cards/{cardId}/overseasUsage | Update overseas usage activation
[**v1CardsGet**](DefaultApi.md#v1CardsGet) | **GET** /v1/cards | Retrieve all cards
[**v1CreditCardsCardIdSupplementaryApplicationsPost**](DefaultApi.md#v1CreditCardsCardIdSupplementaryApplicationsPost) | **POST** /v1/creditCards/{cardId}/supplementary/applications | Supplementary Card Application
[**v1CreditCardsCreditLimitsPost**](DefaultApi.md#v1CreditCardsCreditLimitsPost) | **POST** /v1/creditCards/creditLimits | Request credit limit increase

<a name="v1CardsCardIdActivationsCardActivationCodePut"></a>
# **v1CardsCardIdActivationsCardActivationCodePut**
> v1CardsCardIdActivationsCardActivationCodePut(uuid, clientId, authorization, cardId, cardActivationCode, body)

Update local usage activation

This API is used to activate or deactivate the specified card&#x27;s ability to be used locally.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String cardId = "cardId_example"; // String | Card Id in encrypted format
String cardActivationCode = "cardActivationCode_example"; // String | Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values.
CardUsageRequest body = new CardUsageRequest(); // CardUsageRequest | 
try {
    apiInstance.v1CardsCardIdActivationsCardActivationCodePut(uuid, clientId, authorization, cardId, cardActivationCode, body);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1CardsCardIdActivationsCardActivationCodePut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **clientId** | **String**| Client ID generated during application registration. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **cardId** | **String**| Card Id in encrypted format |
 **cardActivationCode** | **String**| Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values. |
 **body** | [**CardUsageRequest**](CardUsageRequest.md)|  | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCardIdLostStolenPut"></a>
# **v1CardsCardIdLostStolenPut**
> ReportLostStolenCardResponse v1CardsCardIdLostStolenPut(body, uuid, accept, clientId, contentType, authorization, cardId)

Report card as lost or stolen

This API is used to report a specified card as lost or stolen and returns a reference number to track the request.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ReportLostStolenCardRequest body = new ReportLostStolenCardRequest(); // ReportLostStolenCardRequest | 
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String cardId = "cardId_example"; // String | Unique Id of the card in encrypted format
try {
    ReportLostStolenCardResponse result = apiInstance.v1CardsCardIdLostStolenPut(body, uuid, accept, clientId, contentType, authorization, cardId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1CardsCardIdLostStolenPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportLostStolenCardRequest**](ReportLostStolenCardRequest.md)|  |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **cardId** | **String**| Unique Id of the card in encrypted format |

### Return type

[**ReportLostStolenCardResponse**](ReportLostStolenCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCardIdOverseasUsagePut"></a>
# **v1CardsCardIdOverseasUsagePut**
> v1CardsCardIdOverseasUsagePut(body, uuid, accept, clientId, contentType, authorization, cardId)

Update overseas usage activation

This API is used to activate or deactivate a specified card&#x27;s ability to be used overseas. Cards can be activated for overseas usage permanently or for a set period of time.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
OverseasCardUsageRequest body = new OverseasCardUsageRequest(); // OverseasCardUsageRequest | 
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String cardId = "cardId_example"; // String | Unique Id of the card for activation or de-activation.
try {
    apiInstance.v1CardsCardIdOverseasUsagePut(body, uuid, accept, clientId, contentType, authorization, cardId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1CardsCardIdOverseasUsagePut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasCardUsageRequest**](OverseasCardUsageRequest.md)|  |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **cardId** | **String**| Unique Id of the card for activation or de-activation. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsGet"></a>
# **v1CardsGet**
> CardListingResponse v1CardsGet(authorization, clientId, uuid, accept, cardFunction)

Retrieve all cards

This API is used to retrieve all the credit card numbers and correponding details of the customers who authorized the application.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String cardFunction = "cardFunction_example"; // String | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
try {
    CardListingResponse result = apiInstance.v1CardsGet(authorization, clientId, uuid, accept, cardFunction);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1CardsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **clientId** | **String**| client id generated during consumer onboarding |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **cardFunction** | **String**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |

### Return type

[**CardListingResponse**](CardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CreditCardsCardIdSupplementaryApplicationsPost"></a>
# **v1CreditCardsCardIdSupplementaryApplicationsPost**
> SupplementaryCardResponse v1CreditCardsCardIdSupplementaryApplicationsPost(authorization, uuid, clientId, cardId, body)

Supplementary Card Application

This API is used to authorize Citi Customer to add a Supplementary card to their existing primary card.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String cardId = "cardId_example"; // String | Primary card id in encrypted format.
SupplementaryCardRequest body = new SupplementaryCardRequest(); // SupplementaryCardRequest | 
try {
    SupplementaryCardResponse result = apiInstance.v1CreditCardsCardIdSupplementaryApplicationsPost(authorization, uuid, clientId, cardId, body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1CreditCardsCardIdSupplementaryApplicationsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **clientId** | **String**| Client ID generated during application registration. |
 **cardId** | **String**| Primary card id in encrypted format. |
 **body** | [**SupplementaryCardRequest**](SupplementaryCardRequest.md)|  | [optional]

### Return type

[**SupplementaryCardResponse**](SupplementaryCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CreditCardsCreditLimitsPost"></a>
# **v1CreditCardsCreditLimitsPost**
> CreditLimitIncreaseResponse v1CreditCardsCreditLimitsPost(body, uuid, accept, clientId, contentType, authorization)

Request credit limit increase

This API is used to request for a permanent or temporary credit limit increase on credit card.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
CreditLimitIncreaseRequest body = new CreditLimitIncreaseRequest(); // CreditLimitIncreaseRequest | 
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
try {
    CreditLimitIncreaseResponse result = apiInstance.v1CreditCardsCreditLimitsPost(body, uuid, accept, clientId, contentType, authorization);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1CreditCardsCreditLimitsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitIncreaseRequest**](CreditLimitIncreaseRequest.md)|  |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |

### Return type

[**CreditLimitIncreaseResponse**](CreditLimitIncreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

