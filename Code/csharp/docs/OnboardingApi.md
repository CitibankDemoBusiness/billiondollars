# IO.Swagger.Api.OnboardingApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicantSalaryAndContributionsUpload**](OnboardingApi.md#applicantsalaryandcontributionsupload) | **POST** /v1/onboarding/applications/{applicationId}/applicants/salariesAndContributions/upload | Upload Salary and Employer Contributions (Superannuation) Document
[**PresetAtmPinAdd**](OnboardingApi.md#presetatmpinadd) | **POST** /partners/v1/onboarding/applicants/apins/enrollments | Pre-set ATM Pin
[**PresetAtmPinAddConfirmation**](OnboardingApi.md#presetatmpinaddconfirmation) | **POST** /partners/v1/onboarding/applicants/apins/enrollments/confirmation | Pre-set ATM Pin Confirmation
[**UnsecuredApplicationGenerateAndSendOTP**](OnboardingApi.md#unsecuredapplicationgenerateandsendotp) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/mfa/otp | Generate and Send OTP for Unsecured Application Flow
[**UnsecuredApplicationValidateOtp**](OnboardingApi.md#unsecuredapplicationvalidateotp) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/mfa/otp | Validate OTP for Unsecured Application Flow
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost**](OnboardingApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidknowledgebasedassessmentspost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/knowledgeBasedAssessments | Submit KBA Answers to Bureau
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet**](OnboardingApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidknowledgebasedassessmentsquestionnaireget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/knowledgeBasedAssessments/questionnaire | Retrieve KBA Questionnaire

<a name="applicantsalaryandcontributionsupload"></a>
# **ApplicantSalaryAndContributionsUpload**
> void ApplicantSalaryAndContributionsUpload (ApplicantSalaryAndContributionsUploadRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

Upload Salary and Employer Contributions (Superannuation) Document

This API is used to upload the salary and employer contributions (superannuation) document retrieved from third party (Verifier) to host (CI).

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicantSalaryAndContributionsUploadExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var body = new ApplicantSalaryAndContributionsUploadRequest(); // ApplicantSalaryAndContributionsUploadRequest | ApplicantSalaryAndContributionsUploadRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique identifier for the application
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Upload Salary and Employer Contributions (Superannuation) Document
                apiInstance.ApplicantSalaryAndContributionsUpload(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.ApplicantSalaryAndContributionsUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantSalaryAndContributionsUploadRequest**](ApplicantSalaryAndContributionsUploadRequest.md)| ApplicantSalaryAndContributionsUploadRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique identifier for the application | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="presetatmpinadd"></a>
# **PresetAtmPinAdd**
> void PresetAtmPinAdd (PresetAtmPinAddRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Pre-set ATM Pin

This API is used to pre-set the ATM Pin of the cards during the onboarding flow before the card is approved. This functionality should only be exposed to internal channels and white label partners.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PresetAtmPinAddExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var body = new PresetAtmPinAddRequest(); // PresetAtmPinAddRequest | PresetAtmPinAddRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Pre-set ATM Pin
                apiInstance.PresetAtmPinAdd(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.PresetAtmPinAdd: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PresetAtmPinAddRequest**](PresetAtmPinAddRequest.md)| PresetAtmPinAddRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="presetatmpinaddconfirmation"></a>
# **PresetAtmPinAddConfirmation**
> void PresetAtmPinAddConfirmation (PresetAtmPinAddConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Pre-set ATM Pin Confirmation

This API is triggered after the PresetAtmPinAdd API and completes the preset ATM Pin process during the onboarding flow. This functionality should only be exposed to internal channels and white label partners.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PresetAtmPinAddConfirmationExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var body = new PresetAtmPinAddConfirmationRequest(); // PresetAtmPinAddConfirmationRequest | PresetAtmPinAddConfirmationRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Pre-set ATM Pin Confirmation
                apiInstance.PresetAtmPinAddConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.PresetAtmPinAddConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PresetAtmPinAddConfirmationRequest**](PresetAtmPinAddConfirmationRequest.md)| PresetAtmPinAddConfirmationRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unsecuredapplicationgenerateandsendotp"></a>
# **UnsecuredApplicationGenerateAndSendOTP**
> UnsecuredApplicationGenerateAndSendOtpResponse UnsecuredApplicationGenerateAndSendOTP (UnsecuredApplicationGenerateAndSendOtpRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

Generate and Send OTP for Unsecured Application Flow

This API is used to generate the one time password and deliver to customer for unsecured application flow.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnsecuredApplicationGenerateAndSendOTPExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var body = new UnsecuredApplicationGenerateAndSendOtpRequest(); // UnsecuredApplicationGenerateAndSendOtpRequest | UnsecuredApplicationGenerateAndSendOtpRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique identifier for the application.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Generate and Send OTP for Unsecured Application Flow
                UnsecuredApplicationGenerateAndSendOtpResponse result = apiInstance.UnsecuredApplicationGenerateAndSendOTP(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.UnsecuredApplicationGenerateAndSendOTP: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsecuredApplicationGenerateAndSendOtpRequest**](UnsecuredApplicationGenerateAndSendOtpRequest.md)| UnsecuredApplicationGenerateAndSendOtpRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique identifier for the application. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UnsecuredApplicationGenerateAndSendOtpResponse**](UnsecuredApplicationGenerateAndSendOtpResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="unsecuredapplicationvalidateotp"></a>
# **UnsecuredApplicationValidateOtp**
> void UnsecuredApplicationValidateOtp (UnsecuredApplicationValidateOtpRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

Validate OTP for Unsecured Application Flow

This API is used to validate the OTP for unsecured application flow.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UnsecuredApplicationValidateOtpExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var body = new UnsecuredApplicationValidateOtpRequest(); // UnsecuredApplicationValidateOtpRequest | UnsecuredApplicationValidateOtpRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique identifier for the application.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Validate OTP for Unsecured Application Flow
                apiInstance.UnsecuredApplicationValidateOtp(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.UnsecuredApplicationValidateOtp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsecuredApplicationValidateOtpRequest**](UnsecuredApplicationValidateOtpRequest.md)| UnsecuredApplicationValidateOtpRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique identifier for the application. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidknowledgebasedassessmentspost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost**
> KbaSubmissionResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost (KbaSubmissionRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string clientDetails = null)

Submit KBA Answers to Bureau

This API is used to submit KBA answers to Bureau for customer authentication. Application id along with KBA answers are passed in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPostExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var body = new KbaSubmissionRequest(); // KbaSubmissionRequest | KbaSubmissionRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | The unique identifier of the application.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Submit KBA Answers to Bureau
                KbaSubmissionResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KbaSubmissionRequest**](KbaSubmissionRequest.md)| KbaSubmissionRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| The unique identifier of the application. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**KbaSubmissionResponse**](KbaSubmissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidknowledgebasedassessmentsquestionnaireget"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet**
> KbaQuestionnaireResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet (string authorization, string uuid, string accept, string clientId, string applicationId, string controlFlowId, string clientDetails = null)

Retrieve KBA Questionnaire

This API retrieves the KBA questionnaire.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGetExample
    {
        public void main()
        {
            var apiInstance = new OnboardingApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var applicationId = applicationId_example;  // string | The unique identifier of the application.
            var controlFlowId = controlFlowId_example;  // string | Control Flow Id
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Retrieve KBA Questionnaire
                KbaQuestionnaireResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet(authorization, uuid, accept, clientId, applicationId, controlFlowId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OnboardingApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **applicationId** | **string**| The unique identifier of the application. | 
 **controlFlowId** | **string**| Control Flow Id | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**KbaQuestionnaireResponse**](KbaQuestionnaireResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
