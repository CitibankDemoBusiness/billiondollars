# SwaggerClient::TaxStatementsApi

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_tax_statement**](TaxStatementsApi.md#get_tax_statement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
[**get_tax_statements**](TaxStatementsApi.md#get_tax_statements) | **GET** /taxStatements | OB Returns list of masked tax statements

# **get_tax_statement**
> Document get_tax_statement(authorization, accept, content_type, uuid, client_id, taxstatement_id, opts)

OB Return the masked tax statement for the given tax statement id

This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::TaxStatementsApi.new
authorization = 'authorization_example' # String | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
accept = 'application/json' # String | Content types that are acceptable for the response. Currently we support application/json
content_type = 'content_type_example' # String | Content-Type of the request
uuid = '4468adf1-adfe-4f85-a2c1-f29beaa1f6ee' # String | 128 bit random UUID generated uniquely for every request.
client_id = '1c5f30d9-043c-49ff-b9c4-255a923278b2' # String | The client ID received during customer onboarding.
taxstatement_id = 'taxstatement_id_example' # String | Unique id that maps to the specific tax statement to be downloaded.
opts = { 
  country_code: 'country_code_example' # String | Two character ISO format country code.
}

begin
  #OB Return the masked tax statement for the given tax statement id
  result = api_instance.get_tax_statement(authorization, accept, content_type, uuid, client_id, taxstatement_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TaxStatementsApi->get_tax_statement: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. | 
 **accept** | **String**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **content_type** | **String**| Content-Type of the request | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **client_id** | **String**| The client ID received during customer onboarding. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **taxstatement_id** | **String**| Unique id that maps to the specific tax statement to be downloaded. | 
 **country_code** | **String**| Two character ISO format country code. | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8



# **get_tax_statements**
> Documents get_tax_statements(authorization, accept, uuid, content_type, client_id, opts)

OB Returns list of masked tax statements

This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::TaxStatementsApi.new
authorization = 'authorization_example' # String | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
accept = 'application/json' # String | Content types that are acceptable for the response. Currently we support application/json
uuid = '4468adf1-adfe-4f85-a2c1-f29beaa1f6ee' # String | 128 bit random UUID generated uniquely for every request
content_type = 'content_type_example' # String | Content-Type of the request
client_id = '1c5f30d9-043c-49ff-b9c4-255a923278b2' # String | The client ID received during application registration in the developer portal.
opts = { 
  country_code: 'country_code_example' # String | Two character ISO format country code.
}

begin
  #OB Returns list of masked tax statements
  result = api_instance.get_tax_statements(authorization, accept, uuid, content_type, client_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TaxStatementsApi->get_tax_statements: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. | 
 **accept** | **String**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **content_type** | **String**| Content-Type of the request | 
 **client_id** | **String**| The client ID received during application registration in the developer portal. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **country_code** | **String**| Two character ISO format country code. | [optional] 

### Return type

[**Documents**](Documents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8



