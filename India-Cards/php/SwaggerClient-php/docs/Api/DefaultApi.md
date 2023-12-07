# Swagger\Client\DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1CardsCardIdActivationsCardActivationCodePut**](DefaultApi.md#v1cardscardidactivationscardactivationcodeput) | **PUT** /v1/cards/{cardId}/activations/{cardActivationCode} | Update local usage activation
[**v1CardsCardIdLostStolenPut**](DefaultApi.md#v1cardscardidloststolenput) | **PUT** /v1/cards/{cardId}/lostStolen | Report card as lost or stolen
[**v1CardsCardIdOverseasUsagePut**](DefaultApi.md#v1cardscardidoverseasusageput) | **PUT** /v1/cards/{cardId}/overseasUsage | Update overseas usage activation
[**v1CardsGet**](DefaultApi.md#v1cardsget) | **GET** /v1/cards | Retrieve all cards
[**v1CreditCardsCardIdSupplementaryApplicationsPost**](DefaultApi.md#v1creditcardscardidsupplementaryapplicationspost) | **POST** /v1/creditCards/{cardId}/supplementary/applications | Supplementary Card Application
[**v1CreditCardsCreditLimitsPost**](DefaultApi.md#v1creditcardscreditlimitspost) | **POST** /v1/creditCards/creditLimits | Request credit limit increase

# **v1CardsCardIdActivationsCardActivationCodePut**
> v1CardsCardIdActivationsCardActivationCodePut($uuid, $client_id, $authorization, $card_id, $card_activation_code, $body)

Update local usage activation

This API is used to activate or deactivate the specified card's ability to be used locally.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$card_id = "card_id_example"; // string | Card Id in encrypted format
$card_activation_code = "card_activation_code_example"; // string | Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values.
$body = new \Swagger\Client\Model\CardUsageRequest(); // \Swagger\Client\Model\CardUsageRequest | 

try {
    $apiInstance->v1CardsCardIdActivationsCardActivationCodePut($uuid, $client_id, $authorization, $card_id, $card_activation_code, $body);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1CardsCardIdActivationsCardActivationCodePut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **client_id** | **string**| Client ID generated during application registration. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **card_id** | **string**| Card Id in encrypted format |
 **card_activation_code** | **string**| Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values. |
 **body** | [**\Swagger\Client\Model\CardUsageRequest**](../Model/CardUsageRequest.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1CardsCardIdLostStolenPut**
> \Swagger\Client\Model\ReportLostStolenCardResponse v1CardsCardIdLostStolenPut($body, $uuid, $accept, $client_id, $content_type, $authorization, $card_id)

Report card as lost or stolen

This API is used to report a specified card as lost or stolen and returns a reference number to track the request.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ReportLostStolenCardRequest(); // \Swagger\Client\Model\ReportLostStolenCardRequest | 
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$card_id = "card_id_example"; // string | Unique Id of the card in encrypted format

try {
    $result = $apiInstance->v1CardsCardIdLostStolenPut($body, $uuid, $accept, $client_id, $content_type, $authorization, $card_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1CardsCardIdLostStolenPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ReportLostStolenCardRequest**](../Model/ReportLostStolenCardRequest.md)|  |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **card_id** | **string**| Unique Id of the card in encrypted format |

### Return type

[**\Swagger\Client\Model\ReportLostStolenCardResponse**](../Model/ReportLostStolenCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1CardsCardIdOverseasUsagePut**
> v1CardsCardIdOverseasUsagePut($body, $uuid, $accept, $client_id, $content_type, $authorization, $card_id)

Update overseas usage activation

This API is used to activate or deactivate a specified card's ability to be used overseas. Cards can be activated for overseas usage permanently or for a set period of time.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\OverseasCardUsageRequest(); // \Swagger\Client\Model\OverseasCardUsageRequest | 
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$card_id = "card_id_example"; // string | Unique Id of the card for activation or de-activation.

try {
    $apiInstance->v1CardsCardIdOverseasUsagePut($body, $uuid, $accept, $client_id, $content_type, $authorization, $card_id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1CardsCardIdOverseasUsagePut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\OverseasCardUsageRequest**](../Model/OverseasCardUsageRequest.md)|  |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **card_id** | **string**| Unique Id of the card for activation or de-activation. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1CardsGet**
> \Swagger\Client\Model\CardListingResponse v1CardsGet($authorization, $client_id, $uuid, $accept, $card_function)

Retrieve all cards

This API is used to retrieve all the credit card numbers and correponding details of the customers who authorized the application.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$card_function = "card_function_example"; // string | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.

try {
    $result = $apiInstance->v1CardsGet($authorization, $client_id, $uuid, $accept, $card_function);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1CardsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **client_id** | **string**| client id generated during consumer onboarding |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **card_function** | **string**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |

### Return type

[**\Swagger\Client\Model\CardListingResponse**](../Model/CardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1CreditCardsCardIdSupplementaryApplicationsPost**
> \Swagger\Client\Model\SupplementaryCardResponse v1CreditCardsCardIdSupplementaryApplicationsPost($authorization, $uuid, $client_id, $card_id, $body)

Supplementary Card Application

This API is used to authorize Citi Customer to add a Supplementary card to their existing primary card.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$card_id = "card_id_example"; // string | Primary card id in encrypted format.
$body = new \Swagger\Client\Model\SupplementaryCardRequest(); // \Swagger\Client\Model\SupplementaryCardRequest | 

try {
    $result = $apiInstance->v1CreditCardsCardIdSupplementaryApplicationsPost($authorization, $uuid, $client_id, $card_id, $body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1CreditCardsCardIdSupplementaryApplicationsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **client_id** | **string**| Client ID generated during application registration. |
 **card_id** | **string**| Primary card id in encrypted format. |
 **body** | [**\Swagger\Client\Model\SupplementaryCardRequest**](../Model/SupplementaryCardRequest.md)|  | [optional]

### Return type

[**\Swagger\Client\Model\SupplementaryCardResponse**](../Model/SupplementaryCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1CreditCardsCreditLimitsPost**
> \Swagger\Client\Model\CreditLimitIncreaseResponse v1CreditCardsCreditLimitsPost($body, $uuid, $accept, $client_id, $content_type, $authorization)

Request credit limit increase

This API is used to request for a permanent or temporary credit limit increase on credit card.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\CreditLimitIncreaseRequest(); // \Swagger\Client\Model\CreditLimitIncreaseRequest | 
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.

try {
    $result = $apiInstance->v1CreditCardsCreditLimitsPost($body, $uuid, $accept, $client_id, $content_type, $authorization);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1CreditCardsCreditLimitsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CreditLimitIncreaseRequest**](../Model/CreditLimitIncreaseRequest.md)|  |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |

### Return type

[**\Swagger\Client\Model\CreditLimitIncreaseResponse**](../Model/CreditLimitIncreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

