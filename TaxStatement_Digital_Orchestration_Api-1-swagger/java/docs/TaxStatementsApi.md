# TaxStatementsApi

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getTaxStatement**](TaxStatementsApi.md#getTaxStatement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
[**getTaxStatements**](TaxStatementsApi.md#getTaxStatements) | **GET** /taxStatements | OB Returns list of masked tax statements

<a name="getTaxStatement"></a>
# **getTaxStatement**
> Document getTaxStatement(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode)

OB Return the masked tax statement for the given tax statement id

This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.TaxStatementsApi;


TaxStatementsApi apiInstance = new TaxStatementsApi();
String authorization = "authorization_example"; // String | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
String accept = "application/json"; // String | Content types that are acceptable for the response. Currently we support application/json
String contentType = "contentType_example"; // String | Content-Type of the request
String uuid = "4468adf1-adfe-4f85-a2c1-f29beaa1f6ee"; // String | 128 bit random UUID generated uniquely for every request.
String clientId = "1c5f30d9-043c-49ff-b9c4-255a923278b2"; // String | The client ID received during customer onboarding.
String taxstatementId = "taxstatementId_example"; // String | Unique id that maps to the specific tax statement to be downloaded.
String countryCode = "countryCode_example"; // String | Two character ISO format country code.
try {
    Document result = apiInstance.getTaxStatement(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TaxStatementsApi#getTaxStatement");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. |
 **accept** | **String**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **contentType** | **String**| Content-Type of the request |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **clientId** | **String**| The client ID received during customer onboarding. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **taxstatementId** | **String**| Unique id that maps to the specific tax statement to be downloaded. |
 **countryCode** | **String**| Two character ISO format country code. | [optional]

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

<a name="getTaxStatements"></a>
# **getTaxStatements**
> Documents getTaxStatements(authorization, accept, uuid, contentType, clientId, countryCode)

OB Returns list of masked tax statements

This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.TaxStatementsApi;


TaxStatementsApi apiInstance = new TaxStatementsApi();
String authorization = "authorization_example"; // String | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
String accept = "application/json"; // String | Content types that are acceptable for the response. Currently we support application/json
String uuid = "4468adf1-adfe-4f85-a2c1-f29beaa1f6ee"; // String | 128 bit random UUID generated uniquely for every request
String contentType = "contentType_example"; // String | Content-Type of the request
String clientId = "1c5f30d9-043c-49ff-b9c4-255a923278b2"; // String | The client ID received during application registration in the developer portal.
String countryCode = "countryCode_example"; // String | Two character ISO format country code.
try {
    Documents result = apiInstance.getTaxStatements(authorization, accept, uuid, contentType, clientId, countryCode);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TaxStatementsApi#getTaxStatements");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. |
 **accept** | **String**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **contentType** | **String**| Content-Type of the request |
 **clientId** | **String**| The client ID received during application registration in the developer portal. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **countryCode** | **String**| Two character ISO format country code. | [optional]

### Return type

[**Documents**](Documents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

