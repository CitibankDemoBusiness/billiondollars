# SwaggerClient::CustomerFoundationalApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**evaluate_customer_eligibility_assessment_check_pre_login**](CustomerFoundationalApi.md#evaluate_customer_eligibility_assessment_check_pre_login) | **GET** /v1/preLogin/customerProductServiceEligibility/check/offers/{offerId} | This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

# **evaluate_customer_eligibility_assessment_check_pre_login**
> EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse evaluate_customer_eligibility_assessment_check_pre_login(authorization, uuid, accept, client_id, offer_id, opts)

This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CustomerFoundationalApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  loan_amount: SwaggerClient::BigDecimal.new # BigDecimal | Loan amount for easy payment plan booking.
}

begin
  #This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
  result = api_instance.evaluate_customer_eligibility_assessment_check_pre_login(authorization, uuid, accept, client_id, offer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CustomerFoundationalApi->evaluate_customer_eligibility_assessment_check_pre_login: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **offer_id** | **String**| This Refers to the unique id for the Pre login offer. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **loan_amount** | **BigDecimal**| Loan amount for easy payment plan booking. | [optional] 

### Return type

[**EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse**](EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



