# DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1ApacOnboardingApplicationsApplicationIdDocumentsPost**](DefaultApi.md#v1ApacOnboardingApplicationsApplicationIdDocumentsPost) | **POST** /v1/apac/onboarding/applications/{applicationId}/documents | Upload Application Documents
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId}/delete | Supp Applicant Delete
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId} | Supp Applicant Update
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Inquiry
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Add
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/backgroundScreening | Screen Unsecured Credit Application
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Application Inquiry
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/inPrincipleApprovals | Request Credit Application Decision
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/offerAcceptance | Accept Cross Sell Products
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Update Unsecured Credit Application
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/status | Check Application Status
[**v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/submission | Submit Application
[**v1ApacOnboardingProductsUnsecuredApplicationsPost**](DefaultApi.md#v1ApacOnboardingProductsUnsecuredApplicationsPost) | **POST** /v1/apac/onboarding/products/unsecured/applications | Create Unsecured Credit Application
[**v1ApacOnboardingProspectsPost**](DefaultApi.md#v1ApacOnboardingProspectsPost) | **POST** /v1/apac/onboarding/prospects | Submit Prospect

<a name="v1ApacOnboardingApplicationsApplicationIdDocumentsPost"></a>
# **v1ApacOnboardingApplicationsApplicationIdDocumentsPost**
> InsertDocumentResponse v1ApacOnboardingApplicationsApplicationIdDocumentsPost(body, authorization, uuid, accept, clientId, contentType, applicationId)

Upload Application Documents

This API allows the applicant to upload the documents online to the specified application. Required documents such as drivers license and banking statements will be returned in the application decision.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
InsertDocumentRequest body = new InsertDocumentRequest(); // InsertDocumentRequest | Insert the documents in documentum.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | The unique identifier of the application.
try {
    InsertDocumentResponse result = apiInstance.v1ApacOnboardingApplicationsApplicationIdDocumentsPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingApplicationsApplicationIdDocumentsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InsertDocumentRequest**](InsertDocumentRequest.md)| Insert the documents in documentum. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| The unique identifier of the application. |

### Return type

[**InsertDocumentResponse**](InsertDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut(body, authorization, uuid, accept, clientId, contentType, applicationId, applicantId)

Supp Applicant Delete

Allows primary card holder to delete the supplementary card application.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ApplicantDeleteRequest body = new ApplicantDeleteRequest(); // ApplicantDeleteRequest | Add applicant details to the application
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Types that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
String applicantId = "applicantId_example"; // String | Unique ID created for an Applicant..
try {
    apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut(body, authorization, uuid, accept, clientId, contentType, applicationId, applicantId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantDeleteRequest**](ApplicantDeleteRequest.md)| Add applicant details to the application |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Types that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |
 **applicantId** | **String**| Unique ID created for an Applicant.. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut(body, authorization, uuid, accept, clientId, contentType, applicationId, applicantId)

Supp Applicant Update

Allows primary card holder to edit or update the supplementary card application details.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ApplicantUpdateRequest body = new ApplicantUpdateRequest(); // ApplicantUpdateRequest | Add applicant details to the application
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Types that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
String applicantId = "applicantId_example"; // String | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.
try {
    apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut(body, authorization, uuid, accept, clientId, contentType, applicationId, applicantId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantUpdateRequest**](ApplicantUpdateRequest.md)| Add applicant details to the application |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Types that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |
 **applicantId** | **String**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet**
> ApplicantInquiryResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet(authorization, uuid, accept, clientId, applicationId, controlFlowId, applicantId)

Supp Applicant Inquiry

This API returns supplementary application details for the specific supplementary application id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Types that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String applicationId = "applicationId_example"; // String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
String controlFlowId = "controlFlowId_example"; // String | It is used to control the flow for subsequent requests in the session.
String applicantId = "applicantId_example"; // String | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.
try {
    ApplicantInquiryResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet(authorization, uuid, accept, clientId, applicationId, controlFlowId, applicantId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Types that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **applicationId** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |
 **controlFlowId** | **String**| It is used to control the flow for subsequent requests in the session. |
 **applicantId** | **String**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional]

### Return type

[**ApplicantInquiryResponse**](ApplicantInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost**
> ApplicantAddResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost(body, authorization, uuid, accept, clientId, contentType, applicationId)

Supp Applicant Add

This API creates a new supplementary card application along with primary card application.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ApplicantAddRequest body = new ApplicantAddRequest(); // ApplicantAddRequest | Add applicant details to the application
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Types that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
try {
    ApplicantAddResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantAddRequest**](ApplicantAddRequest.md)| Add applicant details to the application |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Types that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |

### Return type

[**ApplicantAddResponse**](ApplicantAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost**
> BackgroundScreeningResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost(body, authorization, uuid, accept, clientId, contentType, applicationId)

Screen Unsecured Credit Application

This API submits the specified unsecured credit application for screening.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
BackgroundScreeningRequest body = new BackgroundScreeningRequest(); // BackgroundScreeningRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | The unique identifier of the application
try {
    BackgroundScreeningResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackgroundScreeningRequest**](BackgroundScreeningRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| The unique identifier of the application |

### Return type

[**BackgroundScreeningResponse**](BackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet**
> ApplicationInquiryResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet(authorization, uuid, accept, clientId, applicationId, controlFlowId)

Application Inquiry

This API returns the application details and status for a specific application id after a successful Multi Factor Authentication.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String applicationId = "applicationId_example"; // String | Unique identifier for the application.
String controlFlowId = "controlFlowId_example"; // String | Control flow id is used to control the flow for subsequent requests in the session.
try {
    ApplicationInquiryResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet(authorization, uuid, accept, clientId, applicationId, controlFlowId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet");
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
 **applicationId** | **String**| Unique identifier for the application. |
 **controlFlowId** | **String**| Control flow id is used to control the flow for subsequent requests in the session. | [optional]

### Return type

[**ApplicationInquiryResponse**](ApplicationInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost**
> InPrincipleApprovalResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost(body, authorization, uuid, accept, clientId, contentType, applicationId)

Request Credit Application Decision

This API returns the results of a decision inquiry for an application, including credit limit, counter-product offers and cross-sell offers along with the list of required documents.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
InPrincipleApprovalRequest body = new InPrincipleApprovalRequest(); // InPrincipleApprovalRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | the ID of the application
try {
    InPrincipleApprovalResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InPrincipleApprovalRequest**](InPrincipleApprovalRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| the ID of the application |

### Return type

[**InPrincipleApprovalResponse**](InPrincipleApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost(body, authorization, uuid, accept, clientId, contentType, applicationId)

Accept Cross Sell Products

This API accepts specified cross-sell product offers that were returned in the application decision.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
OfferAcceptanceRequest body = new OfferAcceptanceRequest(); // OfferAcceptanceRequest | Input Data to accept the product offered in the application.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | the ID of the application
try {
    apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost(body, authorization, uuid, accept, clientId, contentType, applicationId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OfferAcceptanceRequest**](OfferAcceptanceRequest.md)| Input Data to accept the product offered in the application. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| the ID of the application |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut**
> ApplicationUpdateResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut(body, authorization, uuid, accept, clientId, contentType, applicationId)

Update Unsecured Credit Application

This API updates a saved application to correct information that was previously blank.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ApplicationUpdateRequest body = new ApplicationUpdateRequest(); // ApplicationUpdateRequest | Input Data to submit the application.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
try {
    ApplicationUpdateResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut(body, authorization, uuid, accept, clientId, contentType, applicationId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationUpdateRequest**](ApplicationUpdateRequest.md)| Input Data to submit the application. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. |

### Return type

[**ApplicationUpdateResponse**](ApplicationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet**
> ApplicationStatusResponse v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet(applicationId, authorization, uuid, accept, clientId, controlFlowId)

Check Application Status

This API returns the status for a specified submitted application and takes the application id as parameter.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String applicationId = "applicationId_example"; // String | the ID of the application
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String controlFlowId = "controlFlowId_example"; // String | Control Flow Id
try {
    ApplicationStatusResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet(applicationId, authorization, uuid, accept, clientId, controlFlowId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **String**| the ID of the application |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **controlFlowId** | **String**| Control Flow Id |

### Return type

[**ApplicationStatusResponse**](ApplicationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost**
> v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost(body, authorization, uuid, accept, clientId, contentType, applicationId)

Submit Application

This API submits the created application to host systems for a particular application id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
FinalSubmitRequest body = new FinalSubmitRequest(); // FinalSubmitRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | The unique identifier of the application.
try {
    apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinalSubmitRequest**](FinalSubmitRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**| The unique identifier of the application. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProductsUnsecuredApplicationsPost"></a>
# **v1ApacOnboardingProductsUnsecuredApplicationsPost**
> ApplicationAddResponse v1ApacOnboardingProductsUnsecuredApplicationsPost(body, authorization, uuid, accept, clientId, contentType, acceptLanguage)

Create Unsecured Credit Application

This API pre-populates an application for card and banking products with the applicant&#x27;s details. The API will then return an application id that can be used to perform actions on the application and check status.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ApplicationAddRequest body = new ApplicationAddRequest(); // ApplicationAddRequest | Input Data to submit the application.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response
try {
    ApplicationAddResponse result = apiInstance.v1ApacOnboardingProductsUnsecuredApplicationsPost(body, authorization, uuid, accept, clientId, contentType, acceptLanguage);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProductsUnsecuredApplicationsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationAddRequest**](ApplicationAddRequest.md)| Input Data to submit the application. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response | [optional]

### Return type

[**ApplicationAddResponse**](ApplicationAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1ApacOnboardingProspectsPost"></a>
# **v1ApacOnboardingProspectsPost**
> ProspectAddResponse v1ApacOnboardingProspectsPost(body, authorization, uuid, accept, clientId, contentType)

Submit Prospect

This API is used to create a new prospect or a potential customer for the bank. Returns a prospect id that can be used for reach out and conversions to applications.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
ProspectAddRequest body = new ProspectAddRequest(); // ProspectAddRequest | Prospect Add Request
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
try {
    ProspectAddResponse result = apiInstance.v1ApacOnboardingProspectsPost(body, authorization, uuid, accept, clientId, contentType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1ApacOnboardingProspectsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProspectAddRequest**](ProspectAddRequest.md)| Prospect Add Request |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |

### Return type

[**ProspectAddResponse**](ProspectAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

