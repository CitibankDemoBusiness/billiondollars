# Swagger\Client\UsersApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**supplementaryCardApplicationStatusInquiry**](UsersApi.md#supplementarycardapplicationstatusinquiry) | **GET** /v1/onboarding/supplementary/applications/{applicationId}/status | Check Supplementary Application Status

# **supplementaryCardApplicationStatusInquiry**
> \Swagger\Client\Model\SupplementaryCardApplicationStatusInquiryResponse supplementaryCardApplicationStatusInquiry($authorization, $uuid, $accept, $client_id, $application_id, $date_of_birth, $mother_maiden_name, $client_details)

Check Supplementary Application Status

This API is used to check the status of the supplementary application.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\UsersApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer on-boarding
$application_id = "application_id_example"; // string | This refers to Unique identifier for the application.
$date_of_birth = "date_of_birth_example"; // string | Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD
$mother_maiden_name = "mother_maiden_name_example"; // string | Mother's maiden name
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->supplementaryCardApplicationStatusInquiry($authorization, $uuid, $accept, $client_id, $application_id, $date_of_birth, $mother_maiden_name, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling UsersApi->supplementaryCardApplicationStatusInquiry: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client id generated during consumer on-boarding |
 **application_id** | **string**| This refers to Unique identifier for the application. |
 **date_of_birth** | **string**| Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD |
 **mother_maiden_name** | **string**| Mother&#x27;s maiden name |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\SupplementaryCardApplicationStatusInquiryResponse**](../Model/SupplementaryCardApplicationStatusInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

