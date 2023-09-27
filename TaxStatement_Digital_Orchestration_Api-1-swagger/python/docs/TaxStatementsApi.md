# swagger_client.TaxStatementsApi

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_tax_statement**](TaxStatementsApi.md#get_tax_statement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
[**get_tax_statements**](TaxStatementsApi.md#get_tax_statements) | **GET** /taxStatements | OB Returns list of masked tax statements

# **get_tax_statement**
> Document get_tax_statement(authorization, accept, content_type, uuid, client_id, taxstatement_id, country_code=country_code)

OB Return the masked tax statement for the given tax statement id

This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaxStatementsApi()
authorization = 'authorization_example' # str | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
accept = 'application/json' # str | Content types that are acceptable for the response. Currently we support application/json (default to application/json)
content_type = 'content_type_example' # str | Content-Type of the request
uuid = '4468adf1-adfe-4f85-a2c1-f29beaa1f6ee' # str | 128 bit random UUID generated uniquely for every request. (default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee)
client_id = '1c5f30d9-043c-49ff-b9c4-255a923278b2' # str | The client ID received during customer onboarding. (default to 1c5f30d9-043c-49ff-b9c4-255a923278b2)
taxstatement_id = 'taxstatement_id_example' # str | Unique id that maps to the specific tax statement to be downloaded.
country_code = 'country_code_example' # str | Two character ISO format country code. (optional)

try:
    # OB Return the masked tax statement for the given tax statement id
    api_response = api_instance.get_tax_statement(authorization, accept, content_type, uuid, client_id, taxstatement_id, country_code=country_code)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaxStatementsApi->get_tax_statement: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. | 
 **accept** | **str**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **content_type** | **str**| Content-Type of the request | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **client_id** | **str**| The client ID received during customer onboarding. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **taxstatement_id** | **str**| Unique id that maps to the specific tax statement to be downloaded. | 
 **country_code** | **str**| Two character ISO format country code. | [optional] 

### Return type

[**Document**](Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **get_tax_statements**
> Documents get_tax_statements(authorization, accept, uuid, content_type, client_id, country_code=country_code)

OB Returns list of masked tax statements

This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaxStatementsApi()
authorization = 'authorization_example' # str | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
accept = 'application/json' # str | Content types that are acceptable for the response. Currently we support application/json (default to application/json)
uuid = '4468adf1-adfe-4f85-a2c1-f29beaa1f6ee' # str | 128 bit random UUID generated uniquely for every request (default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee)
content_type = 'content_type_example' # str | Content-Type of the request
client_id = '1c5f30d9-043c-49ff-b9c4-255a923278b2' # str | The client ID received during application registration in the developer portal. (default to 1c5f30d9-043c-49ff-b9c4-255a923278b2)
country_code = 'country_code_example' # str | Two character ISO format country code. (optional)

try:
    # OB Returns list of masked tax statements
    api_response = api_instance.get_tax_statements(authorization, accept, uuid, content_type, client_id, country_code=country_code)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaxStatementsApi->get_tax_statements: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. | 
 **accept** | **str**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **content_type** | **str**| Content-Type of the request | 
 **client_id** | **str**| The client ID received during application registration in the developer portal. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **country_code** | **str**| Two character ISO format country code. | [optional] 

### Return type

[**Documents**](Documents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

