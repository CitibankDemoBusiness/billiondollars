# SwaggerClient::CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**b_nmoapi_banking_digital_regulatory**](CardsApi.md#b_nmoapi_banking_digital_regulatory) | **GET** /v1/my/bnm/cards | Retrieve the detail of card products
[**epp_loan_booking_confirmation**](CardsApi.md#epp_loan_booking_confirmation) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings/confirmation | Confirm Easy Payment Plan Booking
[**initiate_credit_charge_card_corporate_cards_closure**](CardsApi.md#initiate_credit_charge_card_corporate_cards_closure) | **POST** /partner/v1/creditChargeCard/corporateCards/closure | This API is used to close the corporate Credit Card or Ready credit Account.
[**multi_currency_account_enrollment**](CardsApi.md#multi_currency_account_enrollment) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**multi_currency_account_enrollment_with_currency**](CardsApi.md#multi_currency_account_enrollment_with_currency) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**partner_card_listing**](CardsApi.md#partner_card_listing) | **GET** /partner/v1/cards | Partner Card List
[**request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed**](CardsApi.md#request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed) | **POST** /partner/v1/creditChargeCard/corporateCards/suspensionAndCashLimitAllowed | This API is used to Suspend and Unsuspend corporate card.
[**request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement**](CardsApi.md#request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement) | **POST** /partner/v1/creditChargeCard/corporateCards/cardReplacement | This API is to do the replacement of credit card for Damage/Lost/Stolen reasons
[**request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund**](CardsApi.md#request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund) | **POST** /v1/creditChargeCard/creditPlan/epp/refund | This API is used for EPP Refund in Open Loop
[**retrieve_credit_charge_card_corporate_cards_cash_limit**](CardsApi.md#retrieve_credit_charge_card_corporate_cards_cash_limit) | **POST** /partner/v1/creditChargeCard/corporateCards/cashLimit/retrieve | This API is used to retrieve the corporate card cash limit
[**retrieve_credit_charge_card_corporate_cards_detail**](CardsApi.md#retrieve_credit_charge_card_corporate_cards_detail) | **POST** /partner/v1/creditChargeCard/corporateCards/details/retrieve | This API is used to retrieve the corporate card details
[**retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions**](CardsApi.md#retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions) | **POST** /partner/v1/creditChargeCard/corporateCards/pendingAndIntradayAuthorizationTransactions/retrieve | This API used to retrieve the pending Authorization refund and intraday and history transactions
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status) | **GET** /v1/creditChargeCard/cardStatus | Retrieve Credit Card Status
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**update_credit_charge_card_corporate_cards_cash_limit**](CardsApi.md#update_credit_charge_card_corporate_cards_cash_limit) | **PUT** /partner/v1/creditChargeCard/corporateCards/cashLimit | This API is used to update the corporate card cash limit
[**update_credit_charge_card_corporate_cards_credit_limit**](CardsApi.md#update_credit_charge_card_corporate_cards_credit_limit) | **PUT** /partner/v1/creditChargeCard/corporateCards/creditLimit | This API is used to update the corportate card credit limit
[**update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen**](CardsApi.md#update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen) | **PUT** /partner/v1/creditChargeCard/corporateCards/lostOrStolen | This API is to report lost or stolen card and to apply for Replacement
[**update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control**](CardsApi.md#update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control) | **PUT** /partner/v1/creditChargeCard/corporateCards/spendControl | This API will help corporate user to update purchases for specific merchants coming in the API request
[**v1_cards_card_id_limits_and_enrollments_put**](CardsApi.md#v1_cards_card_id_limits_and_enrollments_put) | **PUT** /v1/cards/{cardId}/limitsAndEnrollments | Enroll for Transaction Limit Setup
[**v1_cards_card_id_multi_currency_accounts_delete**](CardsApi.md#v1_cards_card_id_multi_currency_accounts_delete) | **DELETE** /v1/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**v1_cards_card_id_multi_currency_accounts_enrollments_currency_post**](CardsApi.md#v1_cards_card_id_multi_currency_accounts_enrollments_currency_post) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**v1_cards_card_id_multi_currency_accounts_enrollments_post**](CardsApi.md#v1_cards_card_id_multi_currency_accounts_enrollments_post) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**v1_cards_card_id_overseas_travel_plans_delete**](CardsApi.md#v1_cards_card_id_overseas_travel_plans_delete) | **DELETE** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to delete an existing travel plan 
[**v1_cards_card_id_overseas_travel_plans_post**](CardsApi.md#v1_cards_card_id_overseas_travel_plans_post) | **POST** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to add a new travel plan
[**v1_cards_card_id_overseas_travel_plans_put**](CardsApi.md#v1_cards_card_id_overseas_travel_plans_put) | **PUT** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to update an existing travel plan
[**v1_cards_cvv_verification_post**](CardsApi.md#v1_cards_cvv_verification_post) | **POST** /v1/cards/cvv/verification | Verify CVV for Debit or Credit Card
[**v1_cards_multi_currency_accounts_enrollment_eligibility_get**](CardsApi.md#v1_cards_multi_currency_accounts_enrollment_eligibility_get) | **GET** /v1/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
[**v1_cards_overseas_travel_plans_get**](CardsApi.md#v1_cards_overseas_travel_plans_get) | **GET** /v1/cards/overseasTravelPlans | This API enables customer to inquire current travel plan
[**v2_cards_card_id_multi_currency_accounts_delete**](CardsApi.md#v2_cards_card_id_multi_currency_accounts_delete) | **DELETE** /v2/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**v2_cards_multi_currency_accounts_enrollment_eligibility_get**](CardsApi.md#v2_cards_multi_currency_accounts_enrollment_eligibility_get) | **GET** /v2/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

# **b_nmoapi_banking_digital_regulatory**
> ProductResponse b_nmoapi_banking_digital_regulatory(authorization, uuid, accept, client_id, content_type, opts)

Retrieve the detail of card products

This API is designed basing on Bank Negara Malaysia (BNM) Open API Product Information Specification to provide Citibank’s Malaysia Credit card product information that are currently offered in the Market.<br/>API specs for Swagger download and the API details displayed are for illustration purpose only. For actual specification please refer to the BNM website.<br/><b>Note</b> :To get the details of the API specification , please refer to the BNM link below to extract the exact specifications.<br/>BNM Link  :https://github.com/BankNegaraMY

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  card_type: 'credit_card', # String | Type of card
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Retrieve the detail of card products
  result = api_instance.b_nmoapi_banking_digital_regulatory(authorization, uuid, accept, client_id, content_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->b_nmoapi_banking_digital_regulatory: #{e}"
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
 **card_type** | **String**| Type of card | [optional] [default to credit_card]
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **epp_loan_booking_confirmation**
> EppLoanBookingConfirmationResponse epp_loan_booking_confirmation(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

Confirm Easy Payment Plan Booking

This API is triggered after the EPP plan is selected and completes the EPP booking. On successful booking, it returns transaction reference in the response.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::EppLoanBookingConfirmationRequest.new # EppLoanBookingConfirmationRequest | 
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
  #Confirm Easy Payment Plan Booking
  result = api_instance.epp_loan_booking_confirmation(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->epp_loan_booking_confirmation: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppLoanBookingConfirmationRequest**](EppLoanBookingConfirmationRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The card id  in encrypted format. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EppLoanBookingConfirmationResponse**](EppLoanBookingConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **initiate_credit_charge_card_corporate_cards_closure**
> InitiateCreditChargeCardCorporateCardsClosureResponse initiate_credit_charge_card_corporate_cards_closure(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to close the corporate Credit Card or Ready credit Account.

This API is used to close the corporate Credit Card or Ready credit Account.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::InitiateCreditChargeCardCorporateCardsClosureRequest.new # InitiateCreditChargeCardCorporateCardsClosureRequest | InitiateCreditChargeCardCorporateCardsClosureRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to close the corporate Credit Card or Ready credit Account.
  result = api_instance.initiate_credit_charge_card_corporate_cards_closure(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->initiate_credit_charge_card_corporate_cards_closure: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiateCreditChargeCardCorporateCardsClosureRequest**](InitiateCreditChargeCardCorporateCardsClosureRequest.md)| InitiateCreditChargeCardCorporateCardsClosureRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**InitiateCreditChargeCardCorporateCardsClosureResponse**](InitiateCreditChargeCardCorporateCardsClosureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **multi_currency_account_enrollment**
> MultiCurrencyAccountEnrollmentResponse multi_currency_account_enrollment(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::MultiCurrencyAccountEnrollmentRequest.new # MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
  result = api_instance.multi_currency_account_enrollment(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->multi_currency_account_enrollment: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **multi_currency_account_enrollment_with_currency**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse multi_currency_account_enrollment_with_currency(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::MultiCurrencyAccountEnrollmentWithCurrencyRequest.new # MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to generate/enroll new FCY Accounts to Multi Currency Account
  result = api_instance.multi_currency_account_enrollment_with_currency(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->multi_currency_account_enrollment_with_currency: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **partner_card_listing**
> PartnerCardListingResponse partner_card_listing(authorization, uuid, accept, client_id, card_function, opts)

Partner Card List

This API is used to list all the cards held by a customer with Citi partner.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
card_function = 'card_function_example' # String | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description.
opts = { 
  linked_supplementary_card_flag: true, # BOOLEAN | Flag to identify linked supplementary information to be retrieved.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Partner Card List
  result = api_instance.partner_card_listing(authorization, uuid, accept, client_id, card_function, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->partner_card_listing: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **card_function** | **String**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. | 
 **linked_supplementary_card_flag** | **BOOLEAN**| Flag to identify linked supplementary information to be retrieved. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**PartnerCardListingResponse**](PartnerCardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed**
> request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to Suspend and Unsuspend corporate card.

This API is used to Suspend and Unsuspend corporate card.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest.new # RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest | RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to Suspend and Unsuspend corporate card.
  api_instance.request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->request_credit_charge_card_corporate_cards_suspension_and_cash_limit_allowed: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest**](RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest.md)| RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement**
> RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is to do the replacement of credit card for Damage/Lost/Stolen reasons

This API is to do the replacement of credit card for Damage/Lost/Stolen reasons

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.new # RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest | RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to do the replacement of credit card for Damage/Lost/Stolen reasons
  result = api_instance.request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->request_credit_charge_card_fulfillment_arrangement_corporate_cards_damage_replacement: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest**](RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.md)| RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse**](RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund**
> request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used for EPP Refund in Open Loop

This API is used for EPP Refund in Open Loop

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.new # RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest | RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used for EPP Refund in Open Loop
  api_instance.request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->request_credit_charge_card_fulfillment_arrangement_credit_plan_epp_refund: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest**](RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.md)| RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest | 
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



# **retrieve_credit_charge_card_corporate_cards_cash_limit**
> RetrieveCreditChargeCardCorporateCardsCashLimitResponse retrieve_credit_charge_card_corporate_cards_cash_limit(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to retrieve the corporate card cash limit

This API is used to retrieve the corporate card cash limit

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardCorporateCardsCashLimitRequest.new # RetrieveCreditChargeCardCorporateCardsCashLimitRequest | RetrieveCreditChargeCardCorporateCardsCashLimitRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to retrieve the corporate card cash limit
  result = api_instance.retrieve_credit_charge_card_corporate_cards_cash_limit(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_corporate_cards_cash_limit: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsCashLimitRequest**](RetrieveCreditChargeCardCorporateCardsCashLimitRequest.md)| RetrieveCreditChargeCardCorporateCardsCashLimitRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardCorporateCardsCashLimitResponse**](RetrieveCreditChargeCardCorporateCardsCashLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_corporate_cards_detail**
> RetrieveCreditChargeCardCorporateCardsDetailResponse retrieve_credit_charge_card_corporate_cards_detail(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to retrieve the corporate card details

This API is used to retrieve the corporate card details

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardCorporateCardsDetailRequest.new # RetrieveCreditChargeCardCorporateCardsDetailRequest | RetrieveCreditChargeCardCorporateCardsDetailRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to retrieve the corporate card details
  result = api_instance.retrieve_credit_charge_card_corporate_cards_detail(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_corporate_cards_detail: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsDetailRequest**](RetrieveCreditChargeCardCorporateCardsDetailRequest.md)| RetrieveCreditChargeCardCorporateCardsDetailRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardCorporateCardsDetailResponse**](RetrieveCreditChargeCardCorporateCardsDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions**
> RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API used to retrieve the pending Authorization refund and intraday and history transactions

This API used to retrieve the pending Authorization refund and intraday and history transactions

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.new # RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest | RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API used to retrieve the pending Authorization refund and intraday and history transactions
  result = api_instance.retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_corporate_cards_pending_and_intraday_authorization_transactions: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest**](RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.md)| RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse**](RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status**
> RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status(authorization, uuid, accept, client_id, card_id, transaction_reference_id, opts)

Retrieve Credit Card Status

This API is used to return the credit card status.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
card_id = 'card_id_example' # String | The customer Card identifier in encrypted format.
transaction_reference_id = 'transaction_reference_id_example' # String | This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Retrieve Credit Card Status
  result = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status(authorization, uuid, accept, client_id, card_id, transaction_reference_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **card_id** | **String**| The customer Card identifier in encrypted format. | 
 **transaction_reference_id** | **String**| This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse.md)

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



# **update_credit_charge_card_corporate_cards_cash_limit**
> update_credit_charge_card_corporate_cards_cash_limit(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to update the corporate card cash limit

This API is used to update the corporate card cash limit

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::UpdateCreditChargeCardCorporateCardsCashLimitRequest.new # UpdateCreditChargeCardCorporateCardsCashLimitRequest | UpdateCreditChargeCardCorporateCardsCashLimitRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to update the corporate card cash limit
  api_instance.update_credit_charge_card_corporate_cards_cash_limit(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->update_credit_charge_card_corporate_cards_cash_limit: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardCorporateCardsCashLimitRequest**](UpdateCreditChargeCardCorporateCardsCashLimitRequest.md)| UpdateCreditChargeCardCorporateCardsCashLimitRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_credit_charge_card_corporate_cards_credit_limit**
> UpdateCreditChargeCardCorporateCardsCreditLimitResponse update_credit_charge_card_corporate_cards_credit_limit(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to update the corportate card credit limit

This API is used to update the corportate card credit limit

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::UpdateCreditChargeCardCorporateCardsCreditLimitRequest.new # UpdateCreditChargeCardCorporateCardsCreditLimitRequest | UpdateCreditChargeCardCorporateCardsCreditLimitRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example' # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to update the corportate card credit limit
  result = api_instance.update_credit_charge_card_corporate_cards_credit_limit(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->update_credit_charge_card_corporate_cards_credit_limit: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardCorporateCardsCreditLimitRequest**](UpdateCreditChargeCardCorporateCardsCreditLimitRequest.md)| UpdateCreditChargeCardCorporateCardsCreditLimitRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateCreditChargeCardCorporateCardsCreditLimitResponse**](UpdateCreditChargeCardCorporateCardsCreditLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen**
> UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is to report lost or stolen card and to apply for Replacement

This API is to report lost or stolen card and to apply for Replacement

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest.new # UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest | UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to report lost or stolen card and to apply for Replacement
  result = api_instance.update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->update_credit_charge_card_fulfillment_arrangement_corporate_cards_lost_or_stolen: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest.md)| UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control**
> update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API will help corporate user to update purchases for specific merchants coming in the API request

This API will help corporate user to update purchases for specific merchants coming in the API request

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest.new # UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest | UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API will help corporate user to update purchases for specific merchants coming in the API request
  api_instance.update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->update_credit_charge_card_fulfillment_arrangement_corporate_cards_spend_control: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest.md)| UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest | 
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



# **v1_cards_card_id_limits_and_enrollments_put**
> v1_cards_card_id_limits_and_enrollments_put(bodyuuidacceptclient_idcontent_typeauthorizationcard_id, opts)

Enroll for Transaction Limit Setup

This API is used to update the limits (daily and transaction level) and the enrollments applicable for the credit/debit card of a customer.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::CardsLimitsAndEnrollmentsUpdateRequest.new # CardsLimitsAndEnrollmentsUpdateRequest | CardsLimitsAndEnrollmentsUpdateRequest
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # String | Card Id in encrypted format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Enroll for Transaction Limit Setup
  api_instance.v1_cards_card_id_limits_and_enrollments_put(bodyuuidacceptclient_idcontent_typeauthorizationcard_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_limits_and_enrollments_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardsLimitsAndEnrollmentsUpdateRequest**](CardsLimitsAndEnrollmentsUpdateRequest.md)| CardsLimitsAndEnrollmentsUpdateRequest | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **String**| Card Id in encrypted format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_card_id_multi_currency_accounts_delete**
> v1_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, opts)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
card_id = 'card_id_example' # String | The customer card identifier in encrypted format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
  api_instance.v1_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_multi_currency_accounts_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **card_id** | **String**| The customer card identifier in encrypted format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_cards_card_id_multi_currency_accounts_enrollments_currency_post**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse v1_cards_card_id_multi_currency_accounts_enrollments_currency_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::MultiCurrencyAccountEnrollmentWithCurrencyRequest.new # MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to generate/enroll new FCY Accounts to Multi Currency Account
  result = api_instance.v1_cards_card_id_multi_currency_accounts_enrollments_currency_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_multi_currency_accounts_enrollments_currency_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_card_id_multi_currency_accounts_enrollments_post**
> MultiCurrencyAccountEnrollmentResponse v1_cards_card_id_multi_currency_accounts_enrollments_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::MultiCurrencyAccountEnrollmentRequest.new # MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
  result = api_instance.v1_cards_card_id_multi_currency_accounts_enrollments_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_multi_currency_accounts_enrollments_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_card_id_overseas_travel_plans_delete**
> v1_cards_card_id_overseas_travel_plans_delete(authorization, uuid, accept, client_id, content_type, card_id, opts)

This API enables customer to delete an existing travel plan 

This API enables customer to delete an existing travel plan 

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The card id  in encrypted format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API enables customer to delete an existing travel plan 
  api_instance.v1_cards_card_id_overseas_travel_plans_delete(authorization, uuid, accept, client_id, content_type, card_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_overseas_travel_plans_delete: #{e}"
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
 **card_id** | **String**| The card id  in encrypted format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_cards_card_id_overseas_travel_plans_post**
> v1_cards_card_id_overseas_travel_plans_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API enables customer to add a new travel plan

This API enables customer to add a new travel plan

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::OverseasTravelPlanAddRequest.new # OverseasTravelPlanAddRequest | OverseasTravelPlanAddRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The card id  in encrypted format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API enables customer to add a new travel plan
  api_instance.v1_cards_card_id_overseas_travel_plans_post(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_overseas_travel_plans_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanAddRequest**](OverseasTravelPlanAddRequest.md)| OverseasTravelPlanAddRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The card id  in encrypted format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_card_id_overseas_travel_plans_put**
> v1_cards_card_id_overseas_travel_plans_put(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API enables customer to update an existing travel plan

This API enables customer to update an existing travel plan

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::OverseasTravelPlanUpdateRequest.new # OverseasTravelPlanUpdateRequest | OverseasTravelPlanUpdateRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | The card id  in encrypted format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API enables customer to update an existing travel plan
  api_instance.v1_cards_card_id_overseas_travel_plans_put(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_card_id_overseas_travel_plans_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanUpdateRequest**](OverseasTravelPlanUpdateRequest.md)| OverseasTravelPlanUpdateRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| The card id  in encrypted format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_cvv_verification_post**
> v1_cards_cvv_verification_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Verify CVV for Debit or Credit Card

This API is used to verify the CVV of a debit or a credit card.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
body = SwaggerClient::CvvVerificationRequest.new # CvvVerificationRequest | CvvVerificationRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Verify CVV for Debit or Credit Card
  api_instance.v1_cards_cvv_verification_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_cvv_verification_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CvvVerificationRequest**](CvvVerificationRequest.md)| CvvVerificationRequest | 
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



# **v1_cards_multi_currency_accounts_enrollment_eligibility_get**
> MultiCurrencyAccountEligibilityResponse v1_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, opts)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
  result = api_instance.v1_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_multi_currency_accounts_enrollment_eligibility_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_cards_overseas_travel_plans_get**
> OverseasTravelPlanInquiryResponse v1_cards_overseas_travel_plans_get(authorization, uuid, accept, client_id, opts)

This API enables customer to inquire current travel plan

This API enables customer to inquire current travel plan

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
opts = { 
  client_details: 'client_details_example', # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
  card_id: 'card_id_example' # String | The card id  in encrypted format
}

begin
  #This API enables customer to inquire current travel plan
  result = api_instance.v1_cards_overseas_travel_plans_get(authorization, uuid, accept, client_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v1_cards_overseas_travel_plans_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **card_id** | **String**| The card id  in encrypted format | [optional] 

### Return type

[**OverseasTravelPlanInquiryResponse**](OverseasTravelPlanInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v2_cards_card_id_multi_currency_accounts_delete**
> v2_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, opts)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
card_id = 'card_id_example' # String | The customer card identifier in encrypted format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
  api_instance.v2_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v2_cards_card_id_multi_currency_accounts_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **card_id** | **String**| The customer card identifier in encrypted format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v2_cards_multi_currency_accounts_enrollment_eligibility_get**
> MultiCurrencyAccountEligibilityResponse v2_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, opts)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardsApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
  result = api_instance.v2_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardsApi->v2_cards_multi_currency_accounts_enrollment_eligibility_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



