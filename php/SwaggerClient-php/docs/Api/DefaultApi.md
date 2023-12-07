# Swagger\Client\DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1ApacOnboardingApplicationsApplicationIdDocumentsPost**](DefaultApi.md#v1apaconboardingapplicationsapplicationiddocumentspost) | **POST** /v1/apac/onboarding/applications/{applicationId}/documents | Upload Application Documents
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsapplicantiddeleteput) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId}/delete | Supp Applicant Delete
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsapplicantidput) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId} | Supp Applicant Update
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Inquiry
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantspost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Add
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidbackgroundscreeningpost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/backgroundScreening | Screen Unsecured Credit Application
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Application Inquiry
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidinprincipleapprovalspost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/inPrincipleApprovals | Request Credit Application Decision
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidofferacceptancepost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/offerAcceptance | Accept Cross Sell Products
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidput) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Update Unsecured Credit Application
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidstatusget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/status | Check Application Status
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidsubmissionpost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/submission | Submit Application
[**v1ApacOnboardingProductsUnsecuredApplicationsPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationspost) | **POST** /v1/apac/onboarding/products/unsecured/applications | Create Unsecured Credit Application
[**v1ApacOnboardingProspectsPost**](DefaultApi.md#v1apaconboardingprospectspost) | **POST** /v1/apac/onboarding/prospects | Submit Prospect

# **v1ApacOnboardingApplicationsApplicationIdDocumentsPost**
> \Swagger\Client\Model\InsertDocumentResponse v1ApacOnboardingApplicationsApplicationIdDocumentsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Upload Application Documents

This API allows the applicant to upload the documents online to the specified application. Required documents such as drivers license and banking statements will be returned in the application decision.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\InsertDocumentRequest(); // \Swagger\Client\Model\InsertDocumentRequest | Insert the documents in documentum.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | The unique identifier of the application.

try {
    $result = $apiInstance->v1ApacOnboardingApplicationsApplicationIdDocumentsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingApplicationsApplicationIdDocumentsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\InsertDocumentRequest**](../Model/InsertDocumentRequest.md)| Insert the documents in documentum. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| The unique identifier of the application. |

### Return type

[**\Swagger\Client\Model\InsertDocumentResponse**](../Model/InsertDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $applicant_id)

Supp Applicant Delete

Allows primary card holder to delete the supplementary card application.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ApplicantDeleteRequest(); // \Swagger\Client\Model\ApplicantDeleteRequest | Add applicant details to the application
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Types that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
$applicant_id = "applicant_id_example"; // string | Unique ID created for an Applicant..

try {
    $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $applicant_id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApplicantDeleteRequest**](../Model/ApplicantDeleteRequest.md)| Add applicant details to the application |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Types that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |
 **applicant_id** | **string**| Unique ID created for an Applicant.. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $applicant_id)

Supp Applicant Update

Allows primary card holder to edit or update the supplementary card application details.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ApplicantUpdateRequest(); // \Swagger\Client\Model\ApplicantUpdateRequest | Add applicant details to the application
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Types that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
$applicant_id = "applicant_id_example"; // string | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.

try {
    $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id, $applicant_id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApplicantUpdateRequest**](../Model/ApplicantUpdateRequest.md)| Add applicant details to the application |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Types that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |
 **applicant_id** | **string**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet**
> \Swagger\Client\Model\ApplicantInquiryResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet($authorization, $uuid, $accept, $client_id, $application_id, $control_flow_id, $applicant_id)

Supp Applicant Inquiry

This API returns supplementary application details for the specific supplementary application id.

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
$accept = "accept_example"; // string | Content-Types that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$application_id = "application_id_example"; // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
$control_flow_id = "control_flow_id_example"; // string | It is used to control the flow for subsequent requests in the session.
$applicant_id = "applicant_id_example"; // string | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet($authorization, $uuid, $accept, $client_id, $application_id, $control_flow_id, $applicant_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Types that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **application_id** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |
 **control_flow_id** | **string**| It is used to control the flow for subsequent requests in the session. |
 **applicant_id** | **string**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional]

### Return type

[**\Swagger\Client\Model\ApplicantInquiryResponse**](../Model/ApplicantInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost**
> \Swagger\Client\Model\ApplicantAddResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Supp Applicant Add

This API creates a new supplementary card application along with primary card application.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ApplicantAddRequest(); // \Swagger\Client\Model\ApplicantAddRequest | Add applicant details to the application
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Types that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApplicantAddRequest**](../Model/ApplicantAddRequest.md)| Add applicant details to the application |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Types that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |

### Return type

[**\Swagger\Client\Model\ApplicantAddResponse**](../Model/ApplicantAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost**
> \Swagger\Client\Model\BackgroundScreeningResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Screen Unsecured Credit Application

This API submits the specified unsecured credit application for screening.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\BackgroundScreeningRequest(); // \Swagger\Client\Model\BackgroundScreeningRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | The unique identifier of the application

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BackgroundScreeningRequest**](../Model/BackgroundScreeningRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| The unique identifier of the application |

### Return type

[**\Swagger\Client\Model\BackgroundScreeningResponse**](../Model/BackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet**
> \Swagger\Client\Model\ApplicationInquiryResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet($authorization, $uuid, $accept, $client_id, $application_id, $control_flow_id)

Application Inquiry

This API returns the application details and status for a specific application id after a successful Multi Factor Authentication.

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
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$application_id = "application_id_example"; // string | Unique identifier for the application.
$control_flow_id = "control_flow_id_example"; // string | Control flow id is used to control the flow for subsequent requests in the session.

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet($authorization, $uuid, $accept, $client_id, $application_id, $control_flow_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet: ', $e->getMessage(), PHP_EOL;
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
 **application_id** | **string**| Unique identifier for the application. |
 **control_flow_id** | **string**| Control flow id is used to control the flow for subsequent requests in the session. | [optional]

### Return type

[**\Swagger\Client\Model\ApplicationInquiryResponse**](../Model/ApplicationInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost**
> \Swagger\Client\Model\InPrincipleApprovalResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Request Credit Application Decision

This API returns the results of a decision inquiry for an application, including credit limit, counter-product offers and cross-sell offers along with the list of required documents.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\InPrincipleApprovalRequest(); // \Swagger\Client\Model\InPrincipleApprovalRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | the ID of the application

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\InPrincipleApprovalRequest**](../Model/InPrincipleApprovalRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| the ID of the application |

### Return type

[**\Swagger\Client\Model\InPrincipleApprovalResponse**](../Model/InPrincipleApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Accept Cross Sell Products

This API accepts specified cross-sell product offers that were returned in the application decision.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\OfferAcceptanceRequest(); // \Swagger\Client\Model\OfferAcceptanceRequest | Input Data to accept the product offered in the application.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | the ID of the application

try {
    $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\OfferAcceptanceRequest**](../Model/OfferAcceptanceRequest.md)| Input Data to accept the product offered in the application. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| the ID of the application |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut**
> \Swagger\Client\Model\ApplicationUpdateResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Update Unsecured Credit Application

This API updates a saved application to correct information that was previously blank.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ApplicationUpdateRequest(); // \Swagger\Client\Model\ApplicationUpdateRequest | Input Data to submit the application.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApplicationUpdateRequest**](../Model/ApplicationUpdateRequest.md)| Input Data to submit the application. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |

### Return type

[**\Swagger\Client\Model\ApplicationUpdateResponse**](../Model/ApplicationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet**
> \Swagger\Client\Model\ApplicationStatusResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet($application_id, $authorization, $uuid, $accept, $client_id, $control_flow_id)

Check Application Status

This API returns the status for a specified submitted application and takes the application id as parameter.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$application_id = "application_id_example"; // string | the ID of the application
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$control_flow_id = "control_flow_id_example"; // string | Control Flow Id

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet($application_id, $authorization, $uuid, $accept, $client_id, $control_flow_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **application_id** | **string**| the ID of the application |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **control_flow_id** | **string**| Control Flow Id |

### Return type

[**\Swagger\Client\Model\ApplicationStatusResponse**](../Model/ApplicationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id)

Submit Application

This API submits the created application to host systems for a particular application id.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\FinalSubmitRequest(); // \Swagger\Client\Model\FinalSubmitRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$application_id = "application_id_example"; // string | The unique identifier of the application.

try {
    $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $application_id);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FinalSubmitRequest**](../Model/FinalSubmitRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **application_id** | **string**| The unique identifier of the application. |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProductsUnsecuredApplicationsPost**
> \Swagger\Client\Model\ApplicationAddResponse v1ApacOnboardingProductsUnsecuredApplicationsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $accept_language)

Create Unsecured Credit Application

This API pre-populates an application for card and banking products with the applicant's details. The API will then return an application id that can be used to perform actions on the application and check status.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ApplicationAddRequest(); // \Swagger\Client\Model\ApplicationAddRequest | Input Data to submit the application.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$accept_language = "accept_language_example"; // string | List of acceptable human languages for response

try {
    $result = $apiInstance->v1ApacOnboardingProductsUnsecuredApplicationsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $accept_language);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProductsUnsecuredApplicationsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApplicationAddRequest**](../Model/ApplicationAddRequest.md)| Input Data to submit the application. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **accept_language** | **string**| List of acceptable human languages for response | [optional]

### Return type

[**\Swagger\Client\Model\ApplicationAddResponse**](../Model/ApplicationAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1ApacOnboardingProspectsPost**
> \Swagger\Client\Model\ProspectAddResponse v1ApacOnboardingProspectsPost($body, $authorization, $uuid, $accept, $client_id, $content_type)

Submit Prospect

This API is used to create a new prospect or a potential customer for the bank. Returns a prospect id that can be used for reach out and conversions to applications.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ProspectAddRequest(); // \Swagger\Client\Model\ProspectAddRequest | Prospect Add Request
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json

try {
    $result = $apiInstance->v1ApacOnboardingProspectsPost($body, $authorization, $uuid, $accept, $client_id, $content_type);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1ApacOnboardingProspectsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ProspectAddRequest**](../Model/ProspectAddRequest.md)| Prospect Add Request |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |

### Return type

[**\Swagger\Client\Model\ProspectAddResponse**](../Model/ProspectAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

