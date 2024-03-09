# SwaggerClient::OnboardingApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**applicant_salary_and_contributions_upload**](OnboardingApi.md#applicant_salary_and_contributions_upload) | **POST** /v1/onboarding/applications/{applicationId}/applicants/salariesAndContributions/upload | Upload Salary and Employer Contributions (Superannuation) Document
[**preset_atm_pin_add**](OnboardingApi.md#preset_atm_pin_add) | **POST** /partners/v1/onboarding/applicants/apins/enrollments | Pre-set ATM Pin
[**preset_atm_pin_add_confirmation**](OnboardingApi.md#preset_atm_pin_add_confirmation) | **POST** /partners/v1/onboarding/applicants/apins/enrollments/confirmation | Pre-set ATM Pin Confirmation
[**unsecured_application_generate_and_send_otp**](OnboardingApi.md#unsecured_application_generate_and_send_otp) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/mfa/otp | Generate and Send OTP for Unsecured Application Flow
[**unsecured_application_validate_otp**](OnboardingApi.md#unsecured_application_validate_otp) | **PUT** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/mfa/otp | Validate OTP for Unsecured Application Flow
[**v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_post**](OnboardingApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_post) | **POST** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/knowledgeBasedAssessments | Submit KBA Answers to Bureau
[**v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_questionnaire_get**](OnboardingApi.md#v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_questionnaire_get) | **GET** /v1/apac/onboarding/products/unsecured/applications/{applicationId}/knowledgeBasedAssessments/questionnaire | Retrieve KBA Questionnaire

# **applicant_salary_and_contributions_upload**
> applicant_salary_and_contributions_upload(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

Upload Salary and Employer Contributions (Superannuation) Document

This API is used to upload the salary and employer contributions (superannuation) document retrieved from third party (Verifier) to host (CI).

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
body = SwaggerClient::ApplicantSalaryAndContributionsUploadRequest.new # ApplicantSalaryAndContributionsUploadRequest | ApplicantSalaryAndContributionsUploadRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique identifier for the application
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Upload Salary and Employer Contributions (Superannuation) Document
  api_instance.applicant_salary_and_contributions_upload(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->applicant_salary_and_contributions_upload: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantSalaryAndContributionsUploadRequest**](ApplicantSalaryAndContributionsUploadRequest.md)| ApplicantSalaryAndContributionsUploadRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique identifier for the application | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **preset_atm_pin_add**
> preset_atm_pin_add(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Pre-set ATM Pin

This API is used to pre-set the ATM Pin of the cards during the onboarding flow before the card is approved. This functionality should only be exposed to internal channels and white label partners.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
body = SwaggerClient::PresetAtmPinAddRequest.new # PresetAtmPinAddRequest | PresetAtmPinAddRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Pre-set ATM Pin
  api_instance.preset_atm_pin_add(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->preset_atm_pin_add: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PresetAtmPinAddRequest**](PresetAtmPinAddRequest.md)| PresetAtmPinAddRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **preset_atm_pin_add_confirmation**
> preset_atm_pin_add_confirmation(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Pre-set ATM Pin Confirmation

This API is triggered after the PresetAtmPinAdd API and completes the preset ATM Pin process during the onboarding flow. This functionality should only be exposed to internal channels and white label partners.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
body = SwaggerClient::PresetAtmPinAddConfirmationRequest.new # PresetAtmPinAddConfirmationRequest | PresetAtmPinAddConfirmationRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Pre-set ATM Pin Confirmation
  api_instance.preset_atm_pin_add_confirmation(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->preset_atm_pin_add_confirmation: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PresetAtmPinAddConfirmationRequest**](PresetAtmPinAddConfirmationRequest.md)| PresetAtmPinAddConfirmationRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **unsecured_application_generate_and_send_otp**
> UnsecuredApplicationGenerateAndSendOtpResponse unsecured_application_generate_and_send_otp(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

Generate and Send OTP for Unsecured Application Flow

This API is used to generate the one time password and deliver to customer for unsecured application flow.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
body = SwaggerClient::UnsecuredApplicationGenerateAndSendOtpRequest.new # UnsecuredApplicationGenerateAndSendOtpRequest | UnsecuredApplicationGenerateAndSendOtpRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique identifier for the application.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Generate and Send OTP for Unsecured Application Flow
  result = api_instance.unsecured_application_generate_and_send_otp(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->unsecured_application_generate_and_send_otp: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsecuredApplicationGenerateAndSendOtpRequest**](UnsecuredApplicationGenerateAndSendOtpRequest.md)| UnsecuredApplicationGenerateAndSendOtpRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique identifier for the application. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UnsecuredApplicationGenerateAndSendOtpResponse**](UnsecuredApplicationGenerateAndSendOtpResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **unsecured_application_validate_otp**
> unsecured_application_validate_otp(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

Validate OTP for Unsecured Application Flow

This API is used to validate the OTP for unsecured application flow.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
body = SwaggerClient::UnsecuredApplicationValidateOtpRequest.new # UnsecuredApplicationValidateOtpRequest | UnsecuredApplicationValidateOtpRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | Unique identifier for the application.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Validate OTP for Unsecured Application Flow
  api_instance.unsecured_application_validate_otp(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->unsecured_application_validate_otp: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UnsecuredApplicationValidateOtpRequest**](UnsecuredApplicationValidateOtpRequest.md)| UnsecuredApplicationValidateOtpRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| Unique identifier for the application. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_post**
> KbaSubmissionResponse v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

Submit KBA Answers to Bureau

This API is used to submit KBA answers to Bureau for customer authentication. Application id along with KBA answers are passed in the request.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
body = SwaggerClient::KbaSubmissionRequest.new # KbaSubmissionRequest | KbaSubmissionRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | The unique identifier of the application.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Submit KBA Answers to Bureau
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_post(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**KbaSubmissionRequest**](KbaSubmissionRequest.md)| KbaSubmissionRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**| The unique identifier of the application. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**KbaSubmissionResponse**](KbaSubmissionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_questionnaire_get**
> KbaQuestionnaireResponse v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_questionnaire_get(authorization, uuid, accept, client_id, application_id, control_flow_id, opts)

Retrieve KBA Questionnaire

This API retrieves the KBA questionnaire.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OnboardingApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
application_id = 'application_id_example' # String | The unique identifier of the application.
control_flow_id = 'control_flow_id_example' # String | Control Flow Id
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Retrieve KBA Questionnaire
  result = api_instance.v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_questionnaire_get(authorization, uuid, accept, client_id, application_id, control_flow_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OnboardingApi->v1_apac_onboarding_products_unsecured_applications_application_id_knowledge_based_assessments_questionnaire_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **application_id** | **String**| The unique identifier of the application. | 
 **control_flow_id** | **String**| Control Flow Id | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**KbaQuestionnaireResponse**](KbaQuestionnaireResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



