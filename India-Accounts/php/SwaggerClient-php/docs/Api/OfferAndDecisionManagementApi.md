# Swagger\Client\OfferAndDecisionManagementApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**](OfferAndDecisionManagementApi.md#executeapplicationprocessingunsecuredloantopupofferacceptanceandsubmission) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/offerAcceptanceAndSubmission | This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit
[**initiateApplicationProcessingUnsecuredLoanTopup**](OfferAndDecisionManagementApi.md#initiateapplicationprocessingunsecuredloantopup) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications | This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
[**retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**](OfferAndDecisionManagementApi.md#retrieveapplicationprocessingunsecuredloantopuprepaymentschedule) | **GET** /v1/applicationProcessing/products/unsecuredLoans/topup/repaymentSchedule | This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
[**updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**](OfferAndDecisionManagementApi.md#updateapplicationprocessingunsecuredloantopupbackgroundscreening) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/backgroundScreening | This API is used to update a saved Loan top-up application &amp; do background screening
[**updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**](OfferAndDecisionManagementApi.md#updateapplicationprocessingunsecuredloantopupinprincipalapproval) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/inPrincipleApprovals | This API is used to update a saved Loan top-up application and in principle approval

# **executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**
> executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $client_details)

This API is used to perform offer acceptance for Loan Top Up Application & final submit

This API is used to perform offer acceptance for Loan Top Up Application & final submit

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\OfferAndDecisionManagementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest(); // \Swagger\Client\Model\ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest | ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | 
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $apiInstance->executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $client_details);
} catch (Exception $e) {
    echo 'Exception when calling OfferAndDecisionManagementApi->executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest**](../Model/ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest.md)| ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**|  |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **initiateApplicationProcessingUnsecuredLoanTopup**
> \Swagger\Client\Model\InitiateApplicationProcessingUnsecuredLoanTopupResponse initiateApplicationProcessingUnsecuredLoanTopup($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\OfferAndDecisionManagementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\InitiateApplicationProcessingUnsecuredLoanTopupRequest(); // \Swagger\Client\Model\InitiateApplicationProcessingUnsecuredLoanTopupRequest | InitiateApplicationProcessingUnsecuredLoanTopupRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->initiateApplicationProcessingUnsecuredLoanTopup($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OfferAndDecisionManagementApi->initiateApplicationProcessingUnsecuredLoanTopup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\InitiateApplicationProcessingUnsecuredLoanTopupRequest**](../Model/InitiateApplicationProcessingUnsecuredLoanTopupRequest.md)| InitiateApplicationProcessingUnsecuredLoanTopupRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\InitiateApplicationProcessingUnsecuredLoanTopupResponse**](../Model/InitiateApplicationProcessingUnsecuredLoanTopupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**
> \Swagger\Client\Model\RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule($authorization, $uuid, $accept, $client_id, $content_type, $loan_amount, $insurance_premium_amount, $fee_amount, $loan_interest_rate, $tenor, $client_details)

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\OfferAndDecisionManagementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$loan_amount = 1.2; // double | Loan amount
$insurance_premium_amount = 1.2; // double | Insurance premium amount
$fee_amount = 1.2; // double | Fee amount
$loan_interest_rate = 1.2; // double | Loan interest rate
$tenor = 56; // int | Tenor
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule($authorization, $uuid, $accept, $client_id, $content_type, $loan_amount, $insurance_premium_amount, $fee_amount, $loan_interest_rate, $tenor, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OfferAndDecisionManagementApi->retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **loan_amount** | **double**| Loan amount |
 **insurance_premium_amount** | **double**| Insurance premium amount |
 **fee_amount** | **double**| Fee amount |
 **loan_interest_rate** | **double**| Loan interest rate |
 **tenor** | **int**| Tenor |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse**](../Model/RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**
> \Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $client_details)

This API is used to update a saved Loan top-up application & do background screening

This API is used to update a saved Loan top-up application & do background screening

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\OfferAndDecisionManagementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest(); // \Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest | UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | 
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OfferAndDecisionManagementApi->updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest**](../Model/UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.md)| UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**|  |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse**](../Model/UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**
> \Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $client_details)

This API is used to update a saved Loan top-up application and in principle approval

This API is used to update a saved Loan top-up application and in principle approval

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\OfferAndDecisionManagementApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RequestedLoanTopupDecision(); // \Swagger\Client\Model\RequestedLoanTopupDecision | RequestedLoanTopupDecision
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | 
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling OfferAndDecisionManagementApi->updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RequestedLoanTopupDecision**](../Model/RequestedLoanTopupDecision.md)| RequestedLoanTopupDecision |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**|  |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse**](../Model/UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

