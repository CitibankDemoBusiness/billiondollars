# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1ApacOnboardingApplicationsApplicationIdDocumentsPost**](DefaultApi.md#v1apaconboardingapplicationsapplicationiddocumentspost) | **POST** /v1/apac/onboarding/applications/{applicationId}/documents | Upload Application Documents
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsapplicantiddeleteput) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId}/delete | Supp Applicant Delete
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsapplicantidput) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId} | Supp Applicant Update
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Inquiry
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantspost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Add
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidbackgroundscreeningpost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/backgroundScreening | Screen Unsecured Credit Application
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Application Inquiry
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidinprincipleapprovalspost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/inPrincipleApprovals | Request Credit Application Decision
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidofferacceptancepost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/offerAcceptance | Accept Cross Sell Products
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidput) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Update Unsecured Credit Application
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidstatusget) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/status | Check Application Status
[**V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationsapplicationidsubmissionpost) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/submission | Submit Application
[**V1ApacOnboardingProductsUnsecuredApplicationsPost**](DefaultApi.md#v1apaconboardingproductsunsecuredapplicationspost) | **POST** /v1/apac/onboarding/products/unsecured/applications | Create Unsecured Credit Application
[**V1ApacOnboardingProspectsPost**](DefaultApi.md#v1apaconboardingprospectspost) | **POST** /v1/apac/onboarding/prospects | Submit Prospect

<a name="v1apaconboardingapplicationsapplicationiddocumentspost"></a>
# **V1ApacOnboardingApplicationsApplicationIdDocumentsPost**
> InsertDocumentResponse V1ApacOnboardingApplicationsApplicationIdDocumentsPost (InsertDocumentRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Upload Application Documents

This API allows the applicant to upload the documents online to the specified application. Required documents such as drivers license and banking statements will be returned in the application decision.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingApplicationsApplicationIdDocumentsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new InsertDocumentRequest(); // InsertDocumentRequest | Insert the documents in documentum.
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | The unique identifier of the application.

            try
            {
                // Upload Application Documents
                InsertDocumentResponse result = apiInstance.V1ApacOnboardingApplicationsApplicationIdDocumentsPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingApplicationsApplicationIdDocumentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InsertDocumentRequest**](InsertDocumentRequest.md)| Insert the documents in documentum. | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| The unique identifier of the application. | 

### Return type

[**InsertDocumentResponse**](InsertDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsapplicantiddeleteput"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut**
> void V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut (ApplicantDeleteRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string applicantId)

Supp Applicant Delete

Allows primary card holder to delete the supplementary card application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ApplicantDeleteRequest(); // ApplicantDeleteRequest | Add applicant details to the application
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Types that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
            var applicantId = applicantId_example;  // string | Unique ID created for an Applicant..

            try
            {
                // Supp Applicant Delete
                apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut(body, authorization, uuid, accept, clientId, contentType, applicationId, applicantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdDeletePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantDeleteRequest**](ApplicantDeleteRequest.md)| Add applicant details to the application | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Types that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **applicantId** | **string**| Unique ID created for an Applicant.. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsapplicantidput"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut**
> void V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut (ApplicantUpdateRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId, string applicantId)

Supp Applicant Update

Allows primary card holder to edit or update the supplementary card application details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ApplicantUpdateRequest(); // ApplicantUpdateRequest | Add applicant details to the application
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Types that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
            var applicantId = applicantId_example;  // string | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.

            try
            {
                // Supp Applicant Update
                apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut(body, authorization, uuid, accept, clientId, contentType, applicationId, applicantId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsApplicantIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantUpdateRequest**](ApplicantUpdateRequest.md)| Add applicant details to the application | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Types that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **applicantId** | **string**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantsget"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet**
> ApplicantInquiryResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet (string authorization, string uuid, string accept, string clientId, string applicationId, string controlFlowId, string applicantId = null)

Supp Applicant Inquiry

This API returns supplementary application details for the specific supplementary application id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Types that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var applicationId = applicationId_example;  // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
            var controlFlowId = controlFlowId_example;  // string | It is used to control the flow for subsequent requests in the session.
            var applicantId = applicantId_example;  // string | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. (optional) 

            try
            {
                // Supp Applicant Inquiry
                ApplicantInquiryResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet(authorization, uuid, accept, clientId, applicationId, controlFlowId, applicantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsGet: " + e.Message );
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
 **accept** | **string**| Content-Types that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **applicationId** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **controlFlowId** | **string**| It is used to control the flow for subsequent requests in the session. | 
 **applicantId** | **string**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 

### Return type

[**ApplicantInquiryResponse**](ApplicantInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidapplicantspost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost**
> ApplicantAddResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost (ApplicantAddRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Supp Applicant Add

This API creates a new supplementary card application along with primary card application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ApplicantAddRequest(); // ApplicantAddRequest | Add applicant details to the application
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Types that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.

            try
            {
                // Supp Applicant Add
                ApplicantAddResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdApplicantsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantAddRequest**](ApplicantAddRequest.md)| Add applicant details to the application | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Types that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 

### Return type

[**ApplicantAddResponse**](ApplicantAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidbackgroundscreeningpost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost**
> BackgroundScreeningResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost (BackgroundScreeningRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Screen Unsecured Credit Application

This API submits the specified unsecured credit application for screening.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new BackgroundScreeningRequest(); // BackgroundScreeningRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | The unique identifier of the application

            try
            {
                // Screen Unsecured Credit Application
                BackgroundScreeningResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdBackgroundScreeningPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackgroundScreeningRequest**](BackgroundScreeningRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| The unique identifier of the application | 

### Return type

[**BackgroundScreeningResponse**](BackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidget"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet**
> ApplicationInquiryResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet (string authorization, string uuid, string accept, string clientId, string applicationId, string controlFlowId = null)

Application Inquiry

This API returns the application details and status for a specific application id after a successful Multi Factor Authentication.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var applicationId = applicationId_example;  // string | Unique identifier for the application.
            var controlFlowId = controlFlowId_example;  // string | Control flow id is used to control the flow for subsequent requests in the session. (optional) 

            try
            {
                // Application Inquiry
                ApplicationInquiryResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet(authorization, uuid, accept, clientId, applicationId, controlFlowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdGet: " + e.Message );
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
 **applicationId** | **string**| Unique identifier for the application. | 
 **controlFlowId** | **string**| Control flow id is used to control the flow for subsequent requests in the session. | [optional] 

### Return type

[**ApplicationInquiryResponse**](ApplicationInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidinprincipleapprovalspost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost**
> InPrincipleApprovalResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost (InPrincipleApprovalRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Request Credit Application Decision

This API returns the results of a decision inquiry for an application, including credit limit, counter-product offers and cross-sell offers along with the list of required documents.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new InPrincipleApprovalRequest(); // InPrincipleApprovalRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | the ID of the application

            try
            {
                // Request Credit Application Decision
                InPrincipleApprovalResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdInPrincipleApprovalsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InPrincipleApprovalRequest**](InPrincipleApprovalRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| the ID of the application | 

### Return type

[**InPrincipleApprovalResponse**](InPrincipleApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidofferacceptancepost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost**
> void V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost (OfferAcceptanceRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Accept Cross Sell Products

This API accepts specified cross-sell product offers that were returned in the application decision.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new OfferAcceptanceRequest(); // OfferAcceptanceRequest | Input Data to accept the product offered in the application.
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | the ID of the application

            try
            {
                // Accept Cross Sell Products
                apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost(body, authorization, uuid, accept, clientId, contentType, applicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdOfferAcceptancePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OfferAcceptanceRequest**](OfferAcceptanceRequest.md)| Input Data to accept the product offered in the application. | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| the ID of the application | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidput"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut**
> ApplicationUpdateResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut (ApplicationUpdateRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Update Unsecured Credit Application

This API updates a saved application to correct information that was previously blank.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPutExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ApplicationUpdateRequest(); // ApplicationUpdateRequest | Input Data to submit the application.
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.

            try
            {
                // Update Unsecured Credit Application
                ApplicationUpdateResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut(body, authorization, uuid, accept, clientId, contentType, applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationUpdateRequest**](ApplicationUpdateRequest.md)| Input Data to submit the application. | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 

### Return type

[**ApplicationUpdateResponse**](ApplicationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidstatusget"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet**
> ApplicationStatusResponse V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet (string applicationId, string authorization, string uuid, string accept, string clientId, string controlFlowId)

Check Application Status

This API returns the status for a specified submitted application and takes the application id as parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var applicationId = applicationId_example;  // string | the ID of the application
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var controlFlowId = controlFlowId_example;  // string | Control Flow Id

            try
            {
                // Check Application Status
                ApplicationStatusResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet(applicationId, authorization, uuid, accept, clientId, controlFlowId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdStatusGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | **string**| the ID of the application | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **controlFlowId** | **string**| Control Flow Id | 

### Return type

[**ApplicationStatusResponse**](ApplicationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationsapplicationidsubmissionpost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost**
> void V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost (FinalSubmitRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string applicationId)

Submit Application

This API submits the created application to host systems for a particular application id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new FinalSubmitRequest(); // FinalSubmitRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var applicationId = applicationId_example;  // string | The unique identifier of the application.

            try
            {
                // Submit Application
                apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost(body, authorization, uuid, accept, clientId, contentType, applicationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsApplicationIdSubmissionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinalSubmitRequest**](FinalSubmitRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **applicationId** | **string**| The unique identifier of the application. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingproductsunsecuredapplicationspost"></a>
# **V1ApacOnboardingProductsUnsecuredApplicationsPost**
> ApplicationAddResponse V1ApacOnboardingProductsUnsecuredApplicationsPost (ApplicationAddRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null)

Create Unsecured Credit Application

This API pre-populates an application for card and banking products with the applicant's details. The API will then return an application id that can be used to perform actions on the application and check status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProductsUnsecuredApplicationsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ApplicationAddRequest(); // ApplicationAddRequest | Input Data to submit the application.
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response (optional) 

            try
            {
                // Create Unsecured Credit Application
                ApplicationAddResponse result = apiInstance.V1ApacOnboardingProductsUnsecuredApplicationsPost(body, authorization, uuid, accept, clientId, contentType, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProductsUnsecuredApplicationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationAddRequest**](ApplicationAddRequest.md)| Input Data to submit the application. | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response | [optional] 

### Return type

[**ApplicationAddResponse**](ApplicationAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1apaconboardingprospectspost"></a>
# **V1ApacOnboardingProspectsPost**
> ProspectAddResponse V1ApacOnboardingProspectsPost (ProspectAddRequest body, string authorization, string uuid, string accept, string clientId, string contentType)

Submit Prospect

This API is used to create a new prospect or a potential customer for the bank. Returns a prospect id that can be used for reach out and conversions to applications.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1ApacOnboardingProspectsPostExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var body = new ProspectAddRequest(); // ProspectAddRequest | Prospect Add Request
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json

            try
            {
                // Submit Prospect
                ProspectAddResponse result = apiInstance.V1ApacOnboardingProspectsPost(body, authorization, uuid, accept, clientId, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1ApacOnboardingProspectsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProspectAddRequest**](ProspectAddRequest.md)| Prospect Add Request | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 

### Return type

[**ProspectAddResponse**](ProspectAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
