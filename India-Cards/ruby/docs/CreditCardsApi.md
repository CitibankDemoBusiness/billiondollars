# SwaggerClient::CreditCardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companion_card_application**](CreditCardsApi.md#companion_card_application) | **POST** /v1/creditCards/{cardId}/companion/applications | Issuance of Companion Card
[**easy_payment_plans_transaction_eligibility**](CreditCardsApi.md#easy_payment_plans_transaction_eligibility) | **GET** /v1/creditCards/{cardId}/transactions/eligibility/easyPaymentPlan | Transaction Eligibility and Easy Payment Plans
[**v1_credit_cards_card_id_easy_payment_plans_bookings_post**](CreditCardsApi.md#v1_credit_cards_card_id_easy_payment_plans_bookings_post) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings | Book Easy Payment Plan
[**v1_credit_cards_card_id_easy_payment_plans_eligibility_get**](CreditCardsApi.md#v1_credit_cards_card_id_easy_payment_plans_eligibility_get) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/eligibility | Check Easy Payment Plan Eligibility
[**v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get**](CreditCardsApi.md#v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/repaymentSchedules | Easy Payment Plan Repayment Schedule
[**v1_credit_cards_card_id_easy_payment_plans_search_post**](CreditCardsApi.md#v1_credit_cards_card_id_easy_payment_plans_search_post) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/search | Retrieve Easy Payment Plans Options
[**v1_credit_cards_card_id_supplementary_cards_get**](CreditCardsApi.md#v1_credit_cards_card_id_supplementary_cards_get) | **GET** /v1/creditCards/{cardId}/supplementaryCards | List Supplementary Cards
[**v1_credit_cards_statements_summary_search_post**](CreditCardsApi.md#v1_credit_cards_statements_summary_search_post) | **POST** /v1/creditCards/statements/summary/search | Retrieve Composite Credit Cards Statement Summary

# **companion_card_application**
> CompanionCardApplicationResponse companion_card_application(authorizationuuidacceptcontent_typeclient_idcard_id, opts)

Issuance of Companion Card

This API is used to issue a new companion card for primary credit card.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
content_type = 'content_type_example' # String | The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json.
client_id = 'client_id_example' # String | Client ID generated during application registration.
card_id = 'card_id_example' # String | Card Id in encrypted format
opts = { 
  body: SwaggerClient::CompanionCardApplicationRequest.new # CompanionCardApplicationRequest | CompanionCardApplicationRequest
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Issuance of Companion Card
  result = api_instance.companion_card_application(authorizationuuidacceptcontent_typeclient_idcard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->companion_card_application: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **content_type** | **String**| The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **card_id** | **String**| Card Id in encrypted format | 
 **body** | [**CompanionCardApplicationRequest**](CompanionCardApplicationRequest.md)| CompanionCardApplicationRequest | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CompanionCardApplicationResponse**](CompanionCardApplicationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **easy_payment_plans_transaction_eligibility**
> EasyPaymentPlansTransactionEligibilityResponse easy_payment_plans_transaction_eligibility(authorization, uuid, accept, client_id, card_id, eligble_loan_amount, opts)

Transaction Eligibility and Easy Payment Plans

This API is used to check the Easy Payment Plans eligibility for a card and the available Payment Plans details.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
card_id = 'card_id_example' # String | The card id in encrypted format.
eligble_loan_amount = 1.2 # Float | Elligible loan amount for easy payment plan booking..
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Transaction Eligibility and Easy Payment Plans
  result = api_instance.easy_payment_plans_transaction_eligibility(authorization, uuid, accept, client_id, card_id, eligble_loan_amount, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->easy_payment_plans_transaction_eligibility: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **card_id** | **String**| The card id in encrypted format. | 
 **eligble_loan_amount** | **Float**| Elligible loan amount for easy payment plan booking.. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EasyPaymentPlansTransactionEligibilityResponse**](EasyPaymentPlansTransactionEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_credit_cards_card_id_easy_payment_plans_bookings_post**
> EppLoanBookingResponse v1_credit_cards_card_id_easy_payment_plans_bookings_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

Book Easy Payment Plan

This API is triggered after the EPP plan selection and completes the EPP booking. On successful booking, it returns transaction reference in the response.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
body = SwaggerClient::EppLoanBookingRequest.new # EppLoanBookingRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The card id  in encrypted format.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Book Easy Payment Plan
  result = api_instance.v1_credit_cards_card_id_easy_payment_plans_bookings_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->v1_credit_cards_card_id_easy_payment_plans_bookings_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppLoanBookingRequest**](EppLoanBookingRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The card id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EppLoanBookingResponse**](EppLoanBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_credit_cards_card_id_easy_payment_plans_eligibility_get**
> EasyPaymentPlansEligibilityInquiryResponse v1_credit_cards_card_id_easy_payment_plans_eligibility_get(authorization, uuid, accept, client_id, card_id, epp_loan_booking_type, opts)

Check Easy Payment Plan Eligibility

This API is used to validate the transaction eligibility for EPP conversion.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client_id generated during consumer onboarding
card_id = 'card_id_example' # String | Card Id in encrypted format.
epp_loan_booking_type = 'epp_loan_booking_type_example' # String | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  next_start_index: 'next_start_index_example' # String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
}

begin
  #Check Easy Payment Plan Eligibility
  result = api_instance.v1_credit_cards_card_id_easy_payment_plans_eligibility_get(authorization, uuid, accept, client_id, card_id, epp_loan_booking_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->v1_credit_cards_card_id_easy_payment_plans_eligibility_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client_id generated during consumer onboarding | 
 **card_id** | **String**| Card Id in encrypted format. | 
 **epp_loan_booking_type** | **String**| Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **next_start_index** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**EasyPaymentPlansEligibilityInquiryResponse**](EasyPaymentPlansEligibilityInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get**
> EppRepaymentScheuleResponse v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get(authorization, uuid, accept, client_id, card_id, loan_amount, tenor, opts)

Easy Payment Plan Repayment Schedule

This API allows the customer to view the payment breakdown details and the repayment schedule for the Easy Payment Plan selected.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
card_id = 'card_id_example' # String | The card id  in encrypted format.
loan_amount = 1.2 # Float | Loan amount for easy payment plan booking.
tenor = SwaggerClient::BigDecimal.new # BigDecimal | Tenure of loan in months.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  next_start_index: 'next_start_index_example' # String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
}

begin
  #Easy Payment Plan Repayment Schedule
  result = api_instance.v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get(authorization, uuid, accept, client_id, card_id, loan_amount, tenor, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->v1_credit_cards_card_id_easy_payment_plans_repayment_schedules_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **card_id** | **String**| The card id  in encrypted format. | 
 **loan_amount** | **Float**| Loan amount for easy payment plan booking. | 
 **tenor** | **BigDecimal**| Tenure of loan in months. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **next_start_index** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**EppRepaymentScheuleResponse**](EppRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_credit_cards_card_id_easy_payment_plans_search_post**
> EppResponse v1_credit_cards_card_id_easy_payment_plans_search_post(bodyauthorizationuuidacceptclient_idcard_id, opts)

Retrieve Easy Payment Plans Options

This API retrieves the available Easy Payment Plans to be used by the customer for the repayment of his/her loans.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
body = SwaggerClient::EppRequest.new # EppRequest | Easy payment plan Request
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
card_id = 'card_id_example' # String | The card id  in encrypted format.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Retrieve Easy Payment Plans Options
  result = api_instance.v1_credit_cards_card_id_easy_payment_plans_search_post(bodyauthorizationuuidacceptclient_idcard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->v1_credit_cards_card_id_easy_payment_plans_search_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppRequest**](EppRequest.md)| Easy payment plan Request | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **card_id** | **String**| The card id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EppResponse**](EppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_credit_cards_card_id_supplementary_cards_get**
> SupplementaryCardListingResponse v1_credit_cards_card_id_supplementary_cards_get(authorization, uuid, accept, client_id, card_id, opts)

List Supplementary Cards

This API retrieves the details of all the supplementary cards associated with the primary card id in the request.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
card_id = 'card_id_example' # String | The primary card id  in encrypted format.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #List Supplementary Cards
  result = api_instance.v1_credit_cards_card_id_supplementary_cards_get(authorization, uuid, accept, client_id, card_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->v1_credit_cards_card_id_supplementary_cards_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **card_id** | **String**| The primary card id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SupplementaryCardListingResponse**](SupplementaryCardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_credit_cards_statements_summary_search_post**
> CardStatementSummaryResponse v1_credit_cards_statements_summary_search_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Retrieve Composite Credit Cards Statement Summary

This API is used to retrieve the statement summary for multiple credit cards in a single request.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CreditCardsApi.new
body = SwaggerClient::CardStatementSummaryRequest.new # CardStatementSummaryRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Retrieve Composite Credit Cards Statement Summary
  result = api_instance.v1_credit_cards_statements_summary_search_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CreditCardsApi->v1_credit_cards_statements_summary_search_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardStatementSummaryRequest**](CardStatementSummaryRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CardStatementSummaryResponse**](CardStatementSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



