# SwaggerClient::OfferAndDecisionManagementApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission**](OfferAndDecisionManagementApi.md#execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/offerAcceptanceAndSubmission | This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit
[**initiate_application_processing_unsecured_loan_topup**](OfferAndDecisionManagementApi.md#initiate_application_processing_unsecured_loan_topup) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications | This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
[**retrieve_application_processing_unsecured_loan_topup_repayment_schedule**](OfferAndDecisionManagementApi.md#retrieve_application_processing_unsecured_loan_topup_repayment_schedule) | **GET** /v1/applicationProcessing/products/unsecuredLoans/topup/repaymentSchedule | This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
[**update_application_processing_unsecured_loan_topup_background_screening**](OfferAndDecisionManagementApi.md#update_application_processing_unsecured_loan_topup_background_screening) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/backgroundScreening | This API is used to update a saved Loan top-up application &amp; do background screening
[**update_application_processing_unsecured_loan_topup_in_principal_approval**](OfferAndDecisionManagementApi.md#update_application_processing_unsecured_loan_topup_in_principal_approval) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/inPrincipleApprovals | This API is used to update a saved Loan top-up application and in principle approval

# **execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission**
> execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

This API is used to perform offer acceptance for Loan Top Up Application & final submit

This API is used to perform offer acceptance for Loan Top Up Application & final submit

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OfferAndDecisionManagementApi.new
body = SwaggerClient::ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest.new # ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest | ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | 
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to perform offer acceptance for Loan Top Up Application & final submit
  api_instance.execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OfferAndDecisionManagementApi->execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest**](ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest.md)| ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**|  | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **initiate_application_processing_unsecured_loan_topup**
> InitiateApplicationProcessingUnsecuredLoanTopupResponse initiate_application_processing_unsecured_loan_topup(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OfferAndDecisionManagementApi.new
body = SwaggerClient::InitiateApplicationProcessingUnsecuredLoanTopupRequest.new # InitiateApplicationProcessingUnsecuredLoanTopupRequest | InitiateApplicationProcessingUnsecuredLoanTopupRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
  result = api_instance.initiate_application_processing_unsecured_loan_topup(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OfferAndDecisionManagementApi->initiate_application_processing_unsecured_loan_topup: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiateApplicationProcessingUnsecuredLoanTopupRequest**](InitiateApplicationProcessingUnsecuredLoanTopupRequest.md)| InitiateApplicationProcessingUnsecuredLoanTopupRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**InitiateApplicationProcessingUnsecuredLoanTopupResponse**](InitiateApplicationProcessingUnsecuredLoanTopupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_application_processing_unsecured_loan_topup_repayment_schedule**
> RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse retrieve_application_processing_unsecured_loan_topup_repayment_schedule(authorization, uuid, accept, client_id, content_type, loan_amount, insurance_premium_amount, fee_amount, loan_interest_rate, tenor, opts)

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OfferAndDecisionManagementApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
loan_amount = 1.2 # Float | Loan amount
insurance_premium_amount = 1.2 # Float | Insurance premium amount
fee_amount = 1.2 # Float | Fee amount
loan_interest_rate = 1.2 # Float | Loan interest rate
tenor = 56 # Integer | Tenor
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
  result = api_instance.retrieve_application_processing_unsecured_loan_topup_repayment_schedule(authorization, uuid, accept, client_id, content_type, loan_amount, insurance_premium_amount, fee_amount, loan_interest_rate, tenor, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OfferAndDecisionManagementApi->retrieve_application_processing_unsecured_loan_topup_repayment_schedule: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **loan_amount** | **Float**| Loan amount | 
 **insurance_premium_amount** | **Float**| Insurance premium amount | 
 **fee_amount** | **Float**| Fee amount | 
 **loan_interest_rate** | **Float**| Loan interest rate | 
 **tenor** | **Integer**| Tenor | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse**](RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **update_application_processing_unsecured_loan_topup_background_screening**
> UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse update_application_processing_unsecured_loan_topup_background_screening(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

This API is used to update a saved Loan top-up application & do background screening

This API is used to update a saved Loan top-up application & do background screening

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OfferAndDecisionManagementApi.new
body = SwaggerClient::UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.new # UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest | UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | 
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to update a saved Loan top-up application & do background screening
  result = api_instance.update_application_processing_unsecured_loan_topup_background_screening(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OfferAndDecisionManagementApi->update_application_processing_unsecured_loan_topup_background_screening: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest**](UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.md)| UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**|  | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse**](UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_application_processing_unsecured_loan_topup_in_principal_approval**
> UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse update_application_processing_unsecured_loan_topup_in_principal_approval(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)

This API is used to update a saved Loan top-up application and in principle approval

This API is used to update a saved Loan top-up application and in principle approval

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::OfferAndDecisionManagementApi.new
body = SwaggerClient::RequestedLoanTopupDecision.new # RequestedLoanTopupDecision | RequestedLoanTopupDecision
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
application_id = 'application_id_example' # String | 
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to update a saved Loan top-up application and in principle approval
  result = api_instance.update_application_processing_unsecured_loan_topup_in_principal_approval(bodyauthorizationuuidacceptclient_idcontent_typeapplication_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling OfferAndDecisionManagementApi->update_application_processing_unsecured_loan_topup_in_principal_approval: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestedLoanTopupDecision**](RequestedLoanTopupDecision.md)| RequestedLoanTopupDecision | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **application_id** | **String**|  | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse**](UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



