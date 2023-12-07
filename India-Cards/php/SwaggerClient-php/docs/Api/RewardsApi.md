# Swagger\Client\RewardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1CreditCardsRewardsPointBalanceSearchPost**](RewardsApi.md#v1creditcardsrewardspointbalancesearchpost) | **POST** /v1/creditCards/rewards/pointBalance/search | This API is used to retrieve reward points balance for multiple credit cards

# **v1CreditCardsRewardsPointBalanceSearchPost**
> \Swagger\Client\Model\RewardsInquiryResponse v1CreditCardsRewardsPointBalanceSearchPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

This API is used to retrieve reward points balance for multiple credit cards

This API is used to retrieve reward points balance for multiple credit cards

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\RewardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RewardsInquiryRequest(); // \Swagger\Client\Model\RewardsInquiryRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | The client ID  you received during application registration in the developer portal
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1CreditCardsRewardsPointBalanceSearchPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RewardsApi->v1CreditCardsRewardsPointBalanceSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RewardsInquiryRequest**](../Model/RewardsInquiryRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| The client ID  you received during application registration in the developer portal |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RewardsInquiryResponse**](../Model/RewardsInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

