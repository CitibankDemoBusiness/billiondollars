# Swagger\Client\CARDSApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**](CARDSApi.md#notifycreditchargecardfulfillmentarrangementauthorisedtransaction) | **POST** /partner/v1/creditChargeCard/transaction/authorised/notify | This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

# **notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**
> notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction($body, $authorization, $uuid, $accept, $content_type, $client_id, $client_details, $accept_language, $x_jws_signature)

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CARDSApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest(); // \Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest | NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest
$authorization = "authorization_example"; // string | HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$content_type = "content_type_example"; // string | application/json
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$accept_language = "accept_language_example"; // string | List of acceptable human languages for response.
$x_jws_signature = "x_jws_signature_example"; // string | This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB

try {
    $apiInstance->notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction($body, $authorization, $uuid, $accept, $content_type, $client_id, $client_details, $accept_language, $x_jws_signature);
} catch (Exception $e) {
    echo 'Exception when calling CARDSApi->notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest**](../Model/NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.md)| NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest |
 **authorization** | **string**| HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **content_type** | **string**| application/json |
 **client_id** | **string**| Client ID generated during application registration. | [optional]
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **accept_language** | **string**| List of acceptable human languages for response. | [optional]
 **x_jws_signature** | **string**| This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

