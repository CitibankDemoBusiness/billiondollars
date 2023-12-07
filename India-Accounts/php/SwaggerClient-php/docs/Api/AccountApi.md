# Swagger\Client\AccountApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountClosure**](AccountApi.md#accountclosure) | **POST** /v1/accounts/closure | Closure of Account

# **accountClosure**
> \Swagger\Client\Model\AccountClosureResponse accountClosure($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

Closure of Account

This API allows the customer to close the account or credit card.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\AccountClosureRequest(); // \Swagger\Client\Model\AccountClosureRequest | AccountClosureRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->accountClosure($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountApi->accountClosure: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\AccountClosureRequest**](../Model/AccountClosureRequest.md)| AccountClosureRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\AccountClosureResponse**](../Model/AccountClosureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

