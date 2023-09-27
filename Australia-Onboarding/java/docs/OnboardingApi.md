# OnboardingApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**applicantSalaryAndContributionsUpload**](OnboardingApi.md#applicantSalaryAndContributionsUpload) | **POST** /v1/onboarding/applications/{applicationId}/applicants/salariesAndContributions/upload | Upload Salary and Employer Contributions (Superannuation) Document
[**presetAtmPinAdd**](OnboardingApi.md#presetAtmPinAdd) | **POST** /partners/v1/onboarding/applicants/apins/enrollments | Pre-set ATM Pin
[**presetAtmPinAddConfirmation**](OnboardingApi.md#presetAtmPinAddConfirmation) | **POST** /partners/v1/onboarding/applicants/apins/enrollments/confirmation | Pre-set ATM Pin Confirmation
[**unsecuredApplicationGenerateAndSendOTP**](OnboardingApi.md#unsecuredApplicationGenerateAndSendOTP) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/mfa/otp | Generate and Send OTP for Unsecured Application Flow
[**unsecuredApplicationValidateOtp**](OnboardingApi.md#unsecuredApplicationValidateOtp) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/mfa/otp | Validate OTP for Unsecured Application Flow
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost**](OnboardingApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/knowledgeBasedAssessments | Submit KBA Answers to Bureau
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet**](OnboardingApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/knowledgeBasedAssessments/questionnaire | Retrieve KBA Questionnaire

<a name="applicantSalaryAndContributionsUpload"></a>
# **applicantSalaryAndContributionsUpload**
> applicantSalaryAndContributionsUpload(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

Upload Salary and Employer Contributions (Superannuation) Document

This API is used to upload the salary and employer contributions (superannuation) document retrieved from third party (Verifier) to host (CI).

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
ApplicantSalaryAndContributionsUploadRequest body = new ApplicantSalaryAndContributionsUploadRequest(); // ApplicantSalaryAndContributionsUploadRequest | ApplicantSalaryAndContributionsUploadRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique identifier for the application
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.applicantSalaryAndContributionsUpload(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#applicantSalaryAndContributionsUpload");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantSalaryAndContributionsUploadRequest**](ApplicantSalaryAndContributionsUploadRequest.md)| ApplicantSalaryAndContributionsUploadRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique identifier for the application |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="presetAtmPinAdd"></a>
# **presetAtmPinAdd**
> presetAtmPinAdd(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Pre-set ATM Pin

This API is used to pre-set the ATM Pin of the cards during the onboarding flow before the card is approved. This functionality should only be exposed to internal channels and white label partners.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
PresetAtmPinAddRequest body = new PresetAtmPinAddRequest(); // PresetAtmPinAddRequest | PresetAtmPinAddRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.presetAtmPinAdd(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#presetAtmPinAdd");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PresetAtmPinAddRequest**](PresetAtmPinAddRequest.md)| PresetAtmPinAddRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="presetAtmPinAddConfirmation"></a>
# **presetAtmPinAddConfirmation**
> presetAtmPinAddConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Pre-set ATM Pin Confirmation

This API is triggered after the PresetAtmPinAdd API and completes the preset ATM Pin process during the onboarding flow. This functionality should only be exposed to internal channels and white label partners.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
PresetAtmPinAddConfirmationRequest body = new PresetAtmPinAddConfirmationRequest(); // PresetAtmPinAddConfirmationRequest | PresetAtmPinAddConfirmationRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.presetAtmPinAddConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#presetAtmPinAddConfirmation");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PresetAtmPinAddConfirmationRequest**](PresetAtmPinAddConfirmationRequest.md)| PresetAtmPinAddConfirmationRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="unsecuredApplicationGenerateAndSendOTP"></a>
# **unsecuredApplicationGenerateAndSendOTP**
> UnsecuredApplicationGenerateAndSendOtpResponse unsecuredApplicationGenerateAndSendOTP(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

Generate and Send OTP for Unsecured Application Flow

This API is used to generate the one time password and deliver to customer for unsecured application flow.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
UnsecuredApplicationGenerateAndSendOtpRequest body = new UnsecuredApplicationGenerateAndSendOtpRequest(); // UnsecuredApplicationGenerateAndSendOtpRequest | UnsecuredApplicationGenerateAndSendOtpRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique identifier for the application.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    UnsecuredApplicationGenerateAndSendOtpResponse result = apiInstance.unsecuredApplicationGenerateAndSendOTP(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#unsecuredApplicationGenerateAndSendOTP");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsecuredApplicationGenerateAndSendOtpRequest**](UnsecuredApplicationGenerateAndSendOtpRequest.md)| UnsecuredApplicationGenerateAndSendOtpRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique identifier for the application. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**UnsecuredApplicationGenerateAndSendOtpResponse**](UnsecuredApplicationGenerateAndSendOtpResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="unsecuredApplicationValidateOtp"></a>
# **unsecuredApplicationValidateOtp**
> unsecuredApplicationValidateOtp(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

Validate OTP for Unsecured Application Flow

This API is used to validate the OTP for unsecured application flow.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
UnsecuredApplicationValidateOtpRequest body = new UnsecuredApplicationValidateOtpRequest(); // UnsecuredApplicationValidateOtpRequest | UnsecuredApplicationValidateOtpRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique identifier for the application.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.unsecuredApplicationValidateOtp(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#unsecuredApplicationValidateOtp");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsecuredApplicationValidateOtpRequest**](UnsecuredApplicationValidateOtpRequest.md)| UnsecuredApplicationValidateOtpRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique identifier for the application. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost**
> KbaSubmissionResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

Submit KBA Answers to Bureau

This API is used to submit KBA answers to Bureau for customer authentication. Application id along with KBA answers are passed in the request.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
KbaSubmissionRequest body = new KbaSubmissionRequest(); // KbaSubmissionRequest | KbaSubmissionRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | The unique identifier of the application.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    KbaSubmissionResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KbaSubmissionRequest**](KbaSubmissionRequest.md)| KbaSubmissionRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| The unique identifier of the application. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**KbaSubmissionResponse**](KbaSubmissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet**
> KbaQuestionnaireResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet(authorization, uuid, accept, clientId, applicationId, controlFlowId, clientDetails)

Retrieve KBA Questionnaire

This API retrieves the KBA questionnaire.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OnboardingApi;


OnboardingApi apiInstance = new OnboardingApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String applicationId = "applicationId_example"; // String | The unique identifier of the application.
String controlFlowId = "controlFlowId_example"; // String | Control Flow Id
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    KbaQuestionnaireResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet(authorization, uuid, accept, clientId, applicationId, controlFlowId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OnboardingApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdKnowledgeBasedAssessmentsQuestionnaireGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **applicationId** | **String**| The unique identifier of the application. |
 **controlFlowId** | **String**| Control Flow Id |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**KbaQuestionnaireResponse**](KbaQuestionnaireResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

