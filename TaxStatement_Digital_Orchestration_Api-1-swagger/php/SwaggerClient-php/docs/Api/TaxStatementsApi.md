# Swagger\Client\TaxStatementsApi

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getTaxStatement**](TaxStatementsApi.md#gettaxstatement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
[**getTaxStatements**](TaxStatementsApi.md#gettaxstatements) | **GET** /taxStatements | OB Returns list of masked tax statements

# **getTaxStatement**
> \Swagger\Client\Model\Document getTaxStatement($authorization, $accept, $content_type, $uuid, $client_id, $taxstatement_id, $country_code)

OB Return the masked tax statement for the given tax statement id

This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TaxStatementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
$accept = "application/json"; // string | Content types that are acceptable for the response. Currently we support application/json
$content_type = "content_type_example"; // string | Content-Type of the request
$uuid = "4468adf1-adfe-4f85-a2c1-f29beaa1f6ee"; // string | 128 bit random UUID generated uniquely for every request.
$client_id = "1c5f30d9-043c-49ff-b9c4-255a923278b2"; // string | The client ID received during customer onboarding.
$taxstatement_id = "taxstatement_id_example"; // string | Unique id that maps to the specific tax statement to be downloaded.
$country_code = "country_code_example"; // string | Two character ISO format country code.

try {
    $result = $apiInstance->getTaxStatement($authorization, $accept, $content_type, $uuid, $client_id, $taxstatement_id, $country_code);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TaxStatementsApi->getTaxStatement: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. |
 **accept** | **string**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **content_type** | **string**| Content-Type of the request |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **client_id** | **string**| The client ID received during customer onboarding. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **taxstatement_id** | **string**| Unique id that maps to the specific tax statement to be downloaded. |
 **country_code** | **string**| Two character ISO format country code. | [optional]

### Return type

[**\Swagger\Client\Model\Document**](../Model/Document.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **getTaxStatements**
> \Swagger\Client\Model\Documents getTaxStatements($authorization, $accept, $uuid, $content_type, $client_id, $country_code)

OB Returns list of masked tax statements

This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TaxStatementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
$accept = "application/json"; // string | Content types that are acceptable for the response. Currently we support application/json
$uuid = "4468adf1-adfe-4f85-a2c1-f29beaa1f6ee"; // string | 128 bit random UUID generated uniquely for every request
$content_type = "content_type_example"; // string | Content-Type of the request
$client_id = "1c5f30d9-043c-49ff-b9c4-255a923278b2"; // string | The client ID received during application registration in the developer portal.
$country_code = "country_code_example"; // string | Two character ISO format country code.

try {
    $result = $apiInstance->getTaxStatements($authorization, $accept, $uuid, $content_type, $client_id, $country_code);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TaxStatementsApi->getTaxStatements: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. |
 **accept** | **string**| Content types that are acceptable for the response. Currently we support application/json | [default to application/json]
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request | [default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee]
 **content_type** | **string**| Content-Type of the request |
 **client_id** | **string**| The client ID received during application registration in the developer portal. | [default to 1c5f30d9-043c-49ff-b9c4-255a923278b2]
 **country_code** | **string**| Two character ISO format country code. | [optional]

### Return type

[**\Swagger\Client\Model\Documents**](../Model/Documents.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, charset=UTF-8

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

