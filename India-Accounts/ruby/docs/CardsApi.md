# SwaggerClient::CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**loan_booking_confirmation_pre_login**](CardsApi.md#loan_booking_confirmation_pre_login) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings/confirmation | This API  is triggered after CMAMT interdiction in Loan Booking process.
[**loan_booking_pre_login**](CardsApi.md#loan_booking_pre_login) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings | This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
[**partner_v1_accounts_account_id_loans_get**](CardsApi.md#partner_v1_accounts_account_id_loans_get) | **GET** /partner/v1/accounts/{accountId}/loans | This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate) | **POST** /v1/creditChargeCard/creditPlans/{cardId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation) | **POST** /v1/creditChargeCard/creditPlans/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_pre_login**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_pre_login) | **GET** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/loans | This API is to fetch the list of booked loans on customer&#x27;s  credit cards.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/loans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**retrieve_disbursement_options_pre_login**](CardsApi.md#retrieve_disbursement_options_pre_login) | **GET** /v1/creditCardServices/offers/{offerId}/prelogin/loans/disbursementOptions | Get the list of disbursement options and the details like bank details and billing address relevant to each option.
[**v1_accounts_account_id_loans_credit_check_search_post**](CardsApi.md#v1_accounts_account_id_loans_credit_check_search_post) | **POST** /v1/accounts/{accountId}/loans/creditCheck/search | Credit Check based on Debt Service Ratio

# **loan_booking_confirmation_pre_login**
> LoanBookingConfirmationPreLoginResponse loan_booking_confirmation_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)

This API  is triggered after CMAMT interdiction in Loan Booking process.

This API  is triggered after CMAMT interdiction in Loan Booking process.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::LoanBookingConfirmationPreLoginRequest.new # LoanBookingConfirmationPreLoginRequest | LoanBookingConfirmationPreLoginRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API  is triggered after CMAMT interdiction in Loan Booking process.
  result = api_instance.loan_booking_confirmation_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->loan_booking_confirmation_pre_login: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingConfirmationPreLoginRequest**](LoanBookingConfirmationPreLoginRequest.md)| LoanBookingConfirmationPreLoginRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **offer_id** | **String**| This Refers to the unique id for the Pre login offer. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**LoanBookingConfirmationPreLoginResponse**](LoanBookingConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **loan_booking_pre_login**
> LoanBookingPreLoginResponse loan_booking_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::LoanBookingPreLoginRequest.new # LoanBookingPreLoginRequest | LoanBookingPreLoginRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
  result = api_instance.loan_booking_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->loan_booking_pre_login: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingPreLoginRequest**](LoanBookingPreLoginRequest.md)| LoanBookingPreLoginRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **offer_id** | **String**| This Refers to the unique id for the Pre login offer. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**LoanBookingPreLoginResponse**](LoanBookingPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **partner_v1_accounts_account_id_loans_get**
> LoanSummaryResponse partner_v1_accounts_account_id_loans_get(authorization, uuid, accept, client_id, account_id, opts)

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
account_id = 'account_id_example' # String | The account id  in encrypted format.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  next_start_index: 'next_start_index_example', # String | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.
  loan_status: 'loan_status_example', # String | This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description
  offer_type: 'offer_type_example', # String | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description
  offer_indicator: 'offer_indicator_example' # String | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description
}

begin
  #This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
  result = api_instance.partner_v1_accounts_account_id_loans_get(authorization, uuid, accept, client_id, account_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->partner_v1_accounts_account_id_loans_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **account_id** | **String**| The account id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **next_start_index** | **String**| The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. | [optional] 
 **loan_status** | **String**| This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description | [optional] 
 **offer_type** | **String**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional] 
 **offer_indicator** | **String**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional] 

### Return type

[**LoanSummaryResponse**](LoanSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest.new # RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The card id  in encrypted format.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to merge the multiple LOPs in to single loan with top up amount added
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The card id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.new # RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to merge the multiple LOPs in to single loan with top up amount added
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.new # RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to merge the multiple LOPs in to single loan with top up amount added
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **offer_id** | **String**| This Refers to the unique id for the Pre login offer. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.new # RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to merge the multiple LOPs in to single loan with top up amount added
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **offer_id** | **String**| This Refers to the unique id for the Pre login offer. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_pre_login**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_pre_login(authorization, uuid, accept, client_id, offer_id, opts)

This API is to fetch the list of booked loans on customer's  credit cards.

This API is to fetch the list of booked loans on customer's  credit cards.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
offer_id = 'offer_id_example' # String | his Refers to the unique id for the Pre login offer
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  offer_type: 'offer_type_example', # String | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description
  offer_indicator: 'offer_indicator_example' # String | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description
}

begin
  #This API is to fetch the list of booked loans on customer's  credit cards.
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_pre_login(authorization, uuid, accept, client_id, offer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_pre_login: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **offer_id** | **String**| his Refers to the unique id for the Pre login offer | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **offer_type** | **String**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional] 
 **offer_indicator** | **String**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp(authorization, uuid, accept, client_id, offer_id, opts)

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  product_id: 'product_id_example', # String | Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description.
  loan_amount: SwaggerClient::BigDecimal.new # BigDecimal | Loan amount for easy payment plan booking.
}

begin
  #This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp(authorization, uuid, accept, client_id, offer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp: #{e}"
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
 **product_id** | **String**| Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description. | [optional] 
 **loan_amount** | **BigDecimal**| Loan amount for easy payment plan booking. | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)

This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

This API is triggered after the EPP Plan is selected and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.new # RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings(bodyauthorizationuuidacceptclient_idcontent_typeoffer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **offer_id** | **String**| This Refers to the unique id for the Pre login offer. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules(authorization, uuid, accept, client_id, offer_id, loan_amount, tenor, opts)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details for the selected time period for prelogin offer

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
loan_amount = SwaggerClient::BigDecimal.new # BigDecimal | Loan amount for easy payment plan booking.
tenor = SwaggerClient::BigDecimal.new # BigDecimal | Tenure of loan in months
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  next_start_index: 'next_start_index_example', # String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
  binary_data_flag: true # BOOLEAN | This refer to the flag in case of binary file is require.
}

begin
  #To allow customers to view the payment breakdown details.
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules(authorization, uuid, accept, client_id, offer_id, loan_amount, tenor, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules: #{e}"
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
 **loan_amount** | **BigDecimal**| Loan amount for easy payment plan booking. | 
 **tenor** | **BigDecimal**| Tenure of loan in months | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **next_start_index** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 
 **binary_data_flag** | **BOOLEAN**| This refer to the flag in case of binary file is require. | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules(authorization, uuid, accept, client_id, offer_id, loan_amount, tenor, opts)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
loan_amount = 'loan_amount_example' # String | Loan amount for easy payment plan booking.
tenor = 56 # Integer | Tenure of loan.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  next_start_index: 'next_start_index_example' # String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
}

begin
  #To allow customers to view the payment breakdown details.
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules(authorization, uuid, accept, client_id, offer_id, loan_amount, tenor, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules: #{e}"
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
 **loan_amount** | **String**| Loan amount for easy payment plan booking. | 
 **tenor** | **Integer**| Tenure of loan. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **next_start_index** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **retrieve_disbursement_options_pre_login**
> RetrieveDisbursementOptionsPreLoginResponse retrieve_disbursement_options_pre_login(authorization, uuid, accept, client_id, offer_id, opts)

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
offer_id = 'offer_id_example' # String | This Refers to the unique id for the Pre login offer.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Get the list of disbursement options and the details like bank details and billing address relevant to each option.
  result = api_instance.retrieve_disbursement_options_pre_login(authorization, uuid, accept, client_id, offer_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_disbursement_options_pre_login: #{e}"
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

### Return type

[**RetrieveDisbursementOptionsPreLoginResponse**](RetrieveDisbursementOptionsPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_accounts_account_id_loans_credit_check_search_post**
> CreditCheckResponse v1_accounts_account_id_loans_credit_check_search_post(bodyauthorizationuuidacceptclient_idaccount_id, opts)

Credit Check based on Debt Service Ratio

This API is used to retrieve the eligible tenure options, the corresponding maximum eligible loan amount and the annual interest rate based on debt service ratio.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::CreditCheckRequest.new # CreditCheckRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
account_id = 'account_id_example' # String | The account id  in encrypted format.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Credit Check based on Debt Service Ratio
  result = api_instance.v1_accounts_account_id_loans_credit_check_search_post(bodyauthorizationuuidacceptclient_idaccount_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_accounts_account_id_loans_credit_check_search_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditCheckRequest**](CreditCheckRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **account_id** | **String**| The account id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CreditCheckResponse**](CreditCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



