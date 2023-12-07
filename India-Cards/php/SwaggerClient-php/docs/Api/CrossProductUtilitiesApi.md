# Swagger\Client\CrossProductUtilitiesApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**activateCard**](CrossProductUtilitiesApi.md#activatecard) | **PUT** /v1/prelogin/cards/{cardId}/activations | This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.
[**changeAtmPin**](CrossProductUtilitiesApi.md#changeatmpin) | **PUT** /v1/prelogin/cards/atmPin/change | This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal. In  case this API is exposed to external party, TISO review will be required.

# **activateCard**
> activateCard($body, $authorization, $uuid, $accept, $client_id, $content_type, $card_id, $client_details)

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CrossProductUtilitiesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ActivateCardRequest(); // \Swagger\Client\Model\ActivateCardRequest | ActivateCardRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$card_id = "card_id_example"; // string | Hashed card number of the customer
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $apiInstance->activateCard($body, $authorization, $uuid, $accept, $client_id, $content_type, $card_id, $client_details);
} catch (Exception $e) {
    echo 'Exception when calling CrossProductUtilitiesApi->activateCard: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ActivateCardRequest**](../Model/ActivateCardRequest.md)| ActivateCardRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **card_id** | **string**| Hashed card number of the customer |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **changeAtmPin**
> changeAtmPin($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal. In  case this API is exposed to external party, TISO review will be required.

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal.  In case this API is exposed to external party, TISO review will be required.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CrossProductUtilitiesApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ChangeAtmPinRequest(); // \Swagger\Client\Model\ChangeAtmPinRequest | ChangeAtmPinRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $apiInstance->changeAtmPin($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
} catch (Exception $e) {
    echo 'Exception when calling CrossProductUtilitiesApi->changeAtmPin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ChangeAtmPinRequest**](../Model/ChangeAtmPinRequest.md)| ChangeAtmPinRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

