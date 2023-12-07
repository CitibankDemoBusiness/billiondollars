# IO.Swagger.Api.TaxStatementsApi

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTaxStatement**](TaxStatementsApi.md#gettaxstatement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
[**GetTaxStatements**](TaxStatementsApi.md#gettaxstatements) | **GET** /taxStatements | OB Returns list of masked tax statements

<a name="gettaxstatement"></a>
# **GetTaxStatement**
> Document GetTaxStatement (string authorization, string accept, string contentType, string uuid, string clientId, string taxstatementId, string countryCode = null)

OB Return the masked tax statement for the given tax statement id

This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaxStatementExample
    {
        public void main()
        {
            var apiInstance = new TaxStatementsApi();
            var authorization = authorization_example;  // string | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
            var accept = accept_example;  // string | Content types that are acceptable for the response. Currently we support application/json (default to application/json)
            var contentType = contentType_example;  // string | Content-Type of the request
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request. (default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee)
            var clientId = clientId_example;  // string | The client ID received during customer onboarding. (default to 1c5f30d9-043c-49ff-b9c4-255a923278b2)
            var taxstatementId = taxstatementId_example;  // string | Unique id that maps to the specific tax statement to be downloaded.
            var countryCode = countryCode_example;  // string | Two character ISO format country code. (optional) 

            try
            {
                // OB Return the masked tax statement for the given tax statement id
                Document result = apiInstance.GetTaxStatement(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxStatementsApi.GetTaxStatement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. | 
 **accept** | **string**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **contentType** | **string**| Content-Type of the request | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **clientId** | **string**| The client ID received during customer onboarding. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **taxstatementId** | **string**| Unique id that maps to the specific tax statement to be downloaded. | 
 **countryCode** | **string**| Two character ISO format country code. | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="gettaxstatements"></a>
# **GetTaxStatements**
> Documents GetTaxStatements (string authorization, string accept, string uuid, string contentType, string clientId, string countryCode = null)

OB Returns list of masked tax statements

This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetTaxStatementsExample
    {
        public void main()
        {
            var apiInstance = new TaxStatementsApi();
            var authorization = authorization_example;  // string | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
            var accept = accept_example;  // string | Content types that are acceptable for the response. Currently we support application/json (default to application/json)
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request (default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee)
            var contentType = contentType_example;  // string | Content-Type of the request
            var clientId = clientId_example;  // string | The client ID received during application registration in the developer portal. (default to 1c5f30d9-043c-49ff-b9c4-255a923278b2)
            var countryCode = countryCode_example;  // string | Two character ISO format country code. (optional) 

            try
            {
                // OB Returns list of masked tax statements
                Documents result = apiInstance.GetTaxStatements(authorization, accept, uuid, contentType, clientId, countryCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TaxStatementsApi.GetTaxStatements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. | 
 **accept** | **string**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **contentType** | **string**| Content-Type of the request | 
 **clientId** | **string**| The client ID received during application registration in the developer portal. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **countryCode** | **string**| Two character ISO format country code. | [optional] 

### Return type

[**Documents**](Documents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
