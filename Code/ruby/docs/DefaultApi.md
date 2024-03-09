# SwaggerClient::DefaultApi

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
> InsertDocumentResponse v1_apac_onboarding_applications_application_id_documents_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Upload Application Documents

This API allows the applicant to upload the documents online to the specified application. Required documents such as drivers license and banking statements will be returned in the application decision.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::InsertDocumentRequest.new # InsertDocumentRequest | Insert the documents in documentum.
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | The unique identifier of the application.


begin
  #Upload Application Documents
  result = api_instance.v1_apac_onboarding_applications_application_id_documents_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_applications_application_id_documents_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InsertDocumentRequest**](InsertDocumentRequest.md)| Insert the documents in documentum. | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| The unique identifier of the application. | 

### Return type

[**InsertDocumentResponse**](InsertDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put**
> v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put(bodyauthorizationuuidacceptclient_idcontent_typeapplication_idapplicant_id)

Supp Applicant Delete

Allows primary card holder to delete the supplementary card application.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ApplicantDeleteRequest.new # ApplicantDeleteRequest | Add applicant details to the application
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
applicant_id = 'applicant_id_example' # String | Unique ID created for an Applicant..


begin
  #Supp Applicant Delete
  api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put(bodyauthorizationuuidacceptclient_idcontent_typeapplication_idapplicant_id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantDeleteRequest**](ApplicantDeleteRequest.md)| Add applicant details to the application | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Types that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **applicant_id** | **String**| Unique ID created for an Applicant.. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put**
> v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put(bodyauthorizationuuidacceptclient_idcontent_typeapplication_idapplicant_id)

Supp Applicant Update

Allows primary card holder to edit or update the supplementary card application details.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ApplicantUpdateRequest.new # ApplicantUpdateRequest | Add applicant details to the application
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
applicant_id = 'applicant_id_example' # String | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.


begin
  #Supp Applicant Update
  api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put(bodyauthorizationuuidacceptclient_idcontent_typeapplication_idapplicant_id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantUpdateRequest**](ApplicantUpdateRequest.md)| Add applicant details to the application | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Types that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **applicant_id** | **String**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get**
> ApplicantInquiryResponse v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get(authorization, uuid, accept, client_id, application_id, control_flow_id, opts)

Supp Applicant Inquiry

This API returns supplementary application details for the specific supplementary application id.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
application_id = 'application_id_example' # String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.
control_flow_id = 'control_flow_id_example' # String | It is used to control the flow for subsequent requests in the session.
opts = { 
  applicant_id: 'applicant_id_example' # String | Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.
}

begin
  #Supp Applicant Inquiry
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get(authorization, uuid, accept, client_id, application_id, control_flow_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Types that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **application_id** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 
 **control_flow_id** | **String**| It is used to control the flow for subsequent requests in the session. | 
 **applicant_id** | **String**| Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here. | [optional] 

### Return type

[**ApplicantInquiryResponse**](ApplicantInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post**
> ApplicantAddResponse v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Supp Applicant Add

This API creates a new supplementary card application along with primary card application.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ApplicantAddRequest.new # ApplicantAddRequest | Add applicant details to the application
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Types that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.


begin
  #Supp Applicant Add
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantAddRequest**](ApplicantAddRequest.md)| Add applicant details to the application | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Types that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 

### Return type

[**ApplicantAddResponse**](ApplicantAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post**
> BackgroundScreeningResponse v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Screen Unsecured Credit Application

This API submits the specified unsecured credit application for screening.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::BackgroundScreeningRequest.new # BackgroundScreeningRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | The unique identifier of the application


begin
  #Screen Unsecured Credit Application
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BackgroundScreeningRequest**](BackgroundScreeningRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| The unique identifier of the application | 

### Return type

[**BackgroundScreeningResponse**](BackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_get**
> ApplicationInquiryResponse v1_apac_onboarding_products_unsecured_applications_application_id_get(authorization, uuid, accept, client_id, application_id, opts)

Application Inquiry

This API returns the application details and status for a specific application id after a successful Multi Factor Authentication.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
application_id = 'application_id_example' # String | Unique identifier for the application.
opts = { 
  control_flow_id: 'control_flow_id_example' # String | Control flow id is used to control the flow for subsequent requests in the session.
}

begin
  #Application Inquiry
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_get(authorization, uuid, accept, client_id, application_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **application_id** | **String**| Unique identifier for the application. | 
 **control_flow_id** | **String**| Control flow id is used to control the flow for subsequent requests in the session. | [optional] 

### Return type

[**ApplicationInquiryResponse**](ApplicationInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post**
> InPrincipleApprovalResponse v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Request Credit Application Decision

This API returns the results of a decision inquiry for an application, including credit limit, counter-product offers and cross-sell offers along with the list of required documents.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::InPrincipleApprovalRequest.new # InPrincipleApprovalRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | the ID of the application


begin
  #Request Credit Application Decision
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InPrincipleApprovalRequest**](InPrincipleApprovalRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| the ID of the application | 

### Return type

[**InPrincipleApprovalResponse**](InPrincipleApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post**
> v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Accept Cross Sell Products

This API accepts specified cross-sell product offers that were returned in the application decision.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::OfferAcceptanceRequest.new # OfferAcceptanceRequest | Input Data to accept the product offered in the application.
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | the ID of the application


begin
  #Accept Cross Sell Products
  api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OfferAcceptanceRequest**](OfferAcceptanceRequest.md)| Input Data to accept the product offered in the application. | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| the ID of the application | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_put**
> ApplicationUpdateResponse v1_apac_onboarding_products_unsecured_applications_application_id_put(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Update Unsecured Credit Application

This API updates a saved application to correct information that was previously blank.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ApplicationUpdateRequest.new # ApplicationUpdateRequest | Input Data to submit the application.
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here.


begin
  #Update Unsecured Credit Application
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_put(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationUpdateRequest**](ApplicationUpdateRequest.md)| Input Data to submit the application. | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique ID created for an Application. This is retuned back in ApplicationAdd response and the same should be passed here. | 

### Return type

[**ApplicationUpdateResponse**](ApplicationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_status_get**
> ApplicationStatusResponse v1_apac_onboarding_products_unsecured_applications_application_id_status_get(application_id, authorization, uuid, accept, client_id, control_flow_id)

Check Application Status

This API returns the status for a specified submitted application and takes the application id as parameter.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
application_id = 'application_id_example' # String | the ID of the application
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
control_flow_id = 'control_flow_id_example' # String | Control Flow Id


begin
  #Check Application Status
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_status_get(application_id, authorization, uuid, accept, client_id, control_flow_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_status_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **application_id** | **String**| the ID of the application | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **control_flow_id** | **String**| Control Flow Id | 

### Return type

[**ApplicationStatusResponse**](ApplicationStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_submission_post**
> v1_apac_onboarding_products_unsecured_applications_application_id_submission_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)

Submit Application

This API submits the created application to host systems for a particular application id.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::FinalSubmitRequest.new # FinalSubmitRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | The unique identifier of the application.


begin
  #Submit Application
  api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_submission_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_application_id_submission_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FinalSubmitRequest**](FinalSubmitRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| The unique identifier of the application. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_post**
> ApplicationAddResponse v1_apac_onboarding_products_unsecured_applications_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Create Unsecured Credit Application

This API pre-populates an application for card and banking products with the applicant's details. The API will then return an application id that can be used to perform actions on the application and check status.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ApplicationAddRequest.new # ApplicationAddRequest | Input Data to submit the application.
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response
}

begin
  #Create Unsecured Credit Application
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_products_unsecured_applications_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationAddRequest**](ApplicationAddRequest.md)| Input Data to submit the application. | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response | [optional] 

### Return type

[**ApplicationAddResponse**](ApplicationAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_prospects_post**
> ProspectAddResponse v1_apac_onboarding_prospects_post(bodyauthorizationuuidacceptclient_idcontent_type)

Submit Prospect

This API is used to create a new prospect or a potential customer for the bank. Returns a prospect id that can be used for reach out and conversions to applications.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ProspectAddRequest.new # ProspectAddRequest | Prospect Add Request
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json


begin
  #Submit Prospect
  result = api_instance.v1_apac_onboarding_prospects_post(bodyauthorizationuuidacceptclient_idcontent_type)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_apac_onboarding_prospects_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProspectAddRequest**](ProspectAddRequest.md)| Prospect Add Request | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 

### Return type

[**ProspectAddResponse**](ProspectAddResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



