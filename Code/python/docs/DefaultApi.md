# swagger_client.DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1_apac_onboarding_applications_application_id_documents_post**](DefaultApi.md#v1_apac_onboarding_applications_application_id_documents_post) | **POST** /v1/apac/onboarding/applications/{applicationId}/documents | Upload Application Documents
[**v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId}/delete | Supp Applicant Delete
[**v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants/{applicantId} | Supp Applicant Update
[**v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Inquiry
[**v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/applicants | Supp Applicant Add
[**v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/backgroundScreening | Screen Unsecured Credit Application
[**v1_apac_onboarding_products_unsecured_applications_application_id_get**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_get) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Application Inquiry
[**v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/inPrincipleApprovals | Request Credit Application Decision
[**v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/offerAcceptance | Accept Cross Sell Products
[**v1_apac_onboarding_products_unsecured_applications_application_id_put**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_put) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId} | Update Unsecured Credit Application
[**v1_apac_onboarding_products_unsecured_applications_application_id_status_get**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_status_get) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/status | Check Application Status
[**v1_apac_onboarding_products_unsecured_applications_application_id_submission_post**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_submission_post) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/submission | Submit Application
[**v1_apac_onboarding_products_unsecured_applications_post**](DefaultApi.md#v1_apac_onboarding_products_unsecured_applications_post) | **POST** /v1/apac/onboarding/products/unsecured/applications | Create Unsecured Credit Application
[**v1_apac_onboarding_prospects_post**](DefaultApi.md#v1_apac_onboarding_prospects_post) | **POST** /v1/apac/onboarding/prospects | Submit Prospect

# **v1_apac_onboarding_applications_application_id_documents_post**
> InsertDocumentResponse v1_apac_onboarding_applications_application_id_documents_post(body, authorization, uuid, accept, client_id, content_type, application_id)

Upload Application Documents

This API allows the applicant to upload the documents online to the specified application. Required documents such as drivers license and banking statements will be returned in the application decision.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.InsertDocumentRequest() # InsertDocumentRequest | Insert the documents in documentum.
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | The unique identifier of the application.

try:
    # Upload Application Documents
    api_response = api_instance.v1_apac_onboarding_applications_application_id_documents_post(body, authorization, uuid, accept, client_id, content_type, application_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_applications_application_id_documents_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InsertDocumentRequest**](InsertDocumentRequest.md)| Insert the documents in documentum. | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| The unique identifier of the application. | 

### Return type

[**InsertDocumentResponse**](InsertDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put**
> v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put(body, authorization, uuid, accept, client_id, content_type, application_id, applicant_id)

Supp Applicant Delete

Allows primary card holder to delete the supplementary card application.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ApplicantDeleteRequest() # ApplicantDeleteRequest | Add applicant details to the application
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
applicant_id = 'applicant_id_example' # str | Unique ID created for an Applicant..

try:
    # Supp Applicant Delete
    api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put(body, authorization, uuid, accept, client_id, content_type, application_id, applicant_id)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantDeleteRequest**](ApplicantDeleteRequest.md)| Add applicant details to the application | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Types that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **applicant_id** | **str**| Unique ID created for an Applicant.. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put**
> v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put(body, authorization, uuid, accept, client_id, content_type, application_id, applicant_id)

Supp Applicant Update

Allows primary card holder to edit or update the supplementary card application details.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ApplicantUpdateRequest() # ApplicantUpdateRequest | Add applicant details to the application
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
applicant_id = 'applicant_id_example' # str | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.

try:
    # Supp Applicant Update
    api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put(body, authorization, uuid, accept, client_id, content_type, application_id, applicant_id)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantUpdateRequest**](ApplicantUpdateRequest.md)| Add applicant details to the application | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Types that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **applicant_id** | **str**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get**
> ApplicantInquiryResponse v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get(authorization, uuid, accept, client_id, application_id, control_flow_id, applicant_id=applicant_id)

Supp Applicant Inquiry

This API returns supplementary application details for the specific supplementary application id.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
application_id = 'application_id_example' # str | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
control_flow_id = 'control_flow_id_example' # str | It is used to control the flow for subsequent requests in the session.
applicant_id = 'applicant_id_example' # str | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. (optional)

try:
    # Supp Applicant Inquiry
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get(authorization, uuid, accept, client_id, application_id, control_flow_id, applicant_id=applicant_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Types that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **application_id** | **str**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **control_flow_id** | **str**| It is used to control the flow for subsequent requests in the session. | 
 **applicant_id** | **str**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 

### Return type

[**ApplicantInquiryResponse**](ApplicantInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post**
> ApplicantAddResponse v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post(body, authorization, uuid, accept, client_id, content_type, application_id)

Supp Applicant Add

This API creates a new supplementary card application along with primary card application.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ApplicantAddRequest() # ApplicantAddRequest | Add applicant details to the application
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.

try:
    # Supp Applicant Add
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post(body, authorization, uuid, accept, client_id, content_type, application_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantAddRequest**](ApplicantAddRequest.md)| Add applicant details to the application | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Types that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 

### Return type

[**ApplicantAddResponse**](ApplicantAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post**
> BackgroundScreeningResponse v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post(body, authorization, uuid, accept, client_id, content_type, application_id)

Screen Unsecured Credit Application

This API submits the specified unsecured credit application for screening.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.BackgroundScreeningRequest() # BackgroundScreeningRequest | 
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | The unique identifier of the application

try:
    # Screen Unsecured Credit Application
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post(body, authorization, uuid, accept, client_id, content_type, application_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackgroundScreeningRequest**](BackgroundScreeningRequest.md)|  | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| The unique identifier of the application | 

### Return type

[**BackgroundScreeningResponse**](BackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_get**
> ApplicationInquiryResponse v1_apac_onboarding_products_unsecured_applications_application_id_get(authorization, uuid, accept, client_id, application_id, control_flow_id=control_flow_id)

Application Inquiry

This API returns the application details and status for a specific application id after a successful Multi Factor Authentication.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
application_id = 'application_id_example' # str | Unique identifier for the application.
control_flow_id = 'control_flow_id_example' # str | Control flow id is used to control the flow for subsequent requests in the session. (optional)

try:
    # Application Inquiry
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_get(authorization, uuid, accept, client_id, application_id, control_flow_id=control_flow_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **application_id** | **str**| Unique identifier for the application. | 
 **control_flow_id** | **str**| Control flow id is used to control the flow for subsequent requests in the session. | [optional] 

### Return type

[**ApplicationInquiryResponse**](ApplicationInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post**
> InPrincipleApprovalResponse v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post(body, authorization, uuid, accept, client_id, content_type, application_id)

Request Credit Application Decision

This API returns the results of a decision inquiry for an application, including credit limit, counter-product offers and cross-sell offers along with the list of required documents.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.InPrincipleApprovalRequest() # InPrincipleApprovalRequest | 
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | the ID of the application

try:
    # Request Credit Application Decision
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post(body, authorization, uuid, accept, client_id, content_type, application_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InPrincipleApprovalRequest**](InPrincipleApprovalRequest.md)|  | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| the ID of the application | 

### Return type

[**InPrincipleApprovalResponse**](InPrincipleApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post**
> v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post(body, authorization, uuid, accept, client_id, content_type, application_id)

Accept Cross Sell Products

This API accepts specified cross-sell product offers that were returned in the application decision.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.OfferAcceptanceRequest() # OfferAcceptanceRequest | Input Data to accept the product offered in the application.
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | the ID of the application

try:
    # Accept Cross Sell Products
    api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post(body, authorization, uuid, accept, client_id, content_type, application_id)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OfferAcceptanceRequest**](OfferAcceptanceRequest.md)| Input Data to accept the product offered in the application. | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| the ID of the application | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_put**
> ApplicationUpdateResponse v1_apac_onboarding_products_unsecured_applications_application_id_put(body, authorization, uuid, accept, client_id, content_type, application_id)

Update Unsecured Credit Application

This API updates a saved application to correct information that was previously blank.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ApplicationUpdateRequest() # ApplicationUpdateRequest | Input Data to submit the application.
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.

try:
    # Update Unsecured Credit Application
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_put(body, authorization, uuid, accept, client_id, content_type, application_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationUpdateRequest**](ApplicationUpdateRequest.md)| Input Data to submit the application. | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 

### Return type

[**ApplicationUpdateResponse**](ApplicationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_status_get**
> ApplicationStatusResponse v1_apac_onboarding_products_unsecured_applications_application_id_status_get(application_id, authorization, uuid, accept, client_id, control_flow_id)

Check Application Status

This API returns the status for a specified submitted application and takes the application id as parameter.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
application_id = 'application_id_example' # str | the ID of the application
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
control_flow_id = 'control_flow_id_example' # str | Control Flow Id

try:
    # Check Application Status
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_status_get(application_id, authorization, uuid, accept, client_id, control_flow_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_status_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **application_id** | **str**| the ID of the application | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **control_flow_id** | **str**| Control Flow Id | 

### Return type

[**ApplicationStatusResponse**](ApplicationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_application_id_submission_post**
> v1_apac_onboarding_products_unsecured_applications_application_id_submission_post(body, authorization, uuid, accept, client_id, content_type, application_id)

Submit Application

This API submits the created application to host systems for a particular application id.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.FinalSubmitRequest() # FinalSubmitRequest | 
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | The unique identifier of the application.

try:
    # Submit Application
    api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_submission_post(body, authorization, uuid, accept, client_id, content_type, application_id)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_submission_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinalSubmitRequest**](FinalSubmitRequest.md)|  | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| The unique identifier of the application. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_products_unsecured_applications_post**
> ApplicationAddResponse v1_apac_onboarding_products_unsecured_applications_post(body, authorization, uuid, accept, client_id, content_type, accept_language=accept_language)

Create Unsecured Credit Application

This API pre-populates an application for card and banking products with the applicant's details. The API will then return an application id that can be used to perform actions on the application and check status.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ApplicationAddRequest() # ApplicationAddRequest | Input Data to submit the application.
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
accept_language = 'accept_language_example' # str | List of acceptable human languages for response (optional)

try:
    # Create Unsecured Credit Application
    api_response = api_instance.v1_apac_onboarding_products_unsecured_applications_post(body, authorization, uuid, accept, client_id, content_type, accept_language=accept_language)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationAddRequest**](ApplicationAddRequest.md)| Input Data to submit the application. | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **accept_language** | **str**| List of acceptable human languages for response | [optional] 

### Return type

[**ApplicationAddResponse**](ApplicationAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_apac_onboarding_prospects_post**
> ProspectAddResponse v1_apac_onboarding_prospects_post(body, authorization, uuid, accept, client_id, content_type)

Submit Prospect

This API is used to create a new prospect or a potential customer for the bank. Returns a prospect id that can be used for reach out and conversions to applications.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ProspectAddRequest() # ProspectAddRequest | Prospect Add Request
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json

try:
    # Submit Prospect
    api_response = api_instance.v1_apac_onboarding_prospects_post(body, authorization, uuid, accept, client_id, content_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_apac_onboarding_prospects_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProspectAddRequest**](ProspectAddRequest.md)| Prospect Add Request | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 

### Return type

[**ProspectAddResponse**](ProspectAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

