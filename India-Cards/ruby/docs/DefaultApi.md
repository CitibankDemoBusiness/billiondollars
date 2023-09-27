# SwaggerClient::DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1_cards_card_id_activations_card_activation_code_put**](DefaultApi.md#v1_cards_card_id_activations_card_activation_code_put) | **PUT** /v1/cards/{cardId}/activations/{cardActivationCode} | Update local usage activation
[**v1_cards_card_id_lost_stolen_put**](DefaultApi.md#v1_cards_card_id_lost_stolen_put) | **PUT** /v1/cards/{cardId}/lostStolen | Report card as lost or stolen
[**v1_cards_card_id_overseas_usage_put**](DefaultApi.md#v1_cards_card_id_overseas_usage_put) | **PUT** /v1/cards/{cardId}/overseasUsage | Update overseas usage activation
[**v1_cards_get**](DefaultApi.md#v1_cards_get) | **GET** /v1/cards | Retrieve all cards
[**v1_credit_cards_card_id_supplementary_applications_post**](DefaultApi.md#v1_credit_cards_card_id_supplementary_applications_post) | **POST** /v1/creditCards/{cardId}/supplementary/applications | Supplementary Card Application
[**v1_credit_cards_credit_limits_post**](DefaultApi.md#v1_credit_cards_credit_limits_post) | **POST** /v1/creditCards/creditLimits | Request credit limit increase

# **v1_cards_card_id_activations_card_activation_code_put**
> v1_cards_card_id_activations_card_activation_code_put(uuidclient_idauthorizationcard_idcard_activation_code, opts)

Update local usage activation

This API is used to activate or deactivate the specified card's ability to be used locally.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
client_id = 'client_id_example' # String | Client ID generated during application registration.
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # String | Card Id in encrypted format
card_activation_code = 'card_activation_code_example' # String | Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values.
opts = { 
  body: SwaggerClient::CardUsageRequest.new # CardUsageRequest | 
}

begin
  #Update local usage activation
  api_instance.v1_cards_card_id_activations_card_activation_code_put(uuidclient_idauthorizationcard_idcard_activation_code, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_cards_card_id_activations_card_activation_code_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **String**| Card Id in encrypted format | 
 **card_activation_code** | **String**| Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values. | 
 **body** | [**CardUsageRequest**](CardUsageRequest.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_card_id_lost_stolen_put**
> ReportLostStolenCardResponse v1_cards_card_id_lost_stolen_put(bodyuuidacceptclient_idcontent_typeauthorizationcard_id)

Report card as lost or stolen

This API is used to report a specified card as lost or stolen and returns a reference number to track the request.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::ReportLostStolenCardRequest.new # ReportLostStolenCardRequest | 
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # String | Unique Id of the card in encrypted format


begin
  #Report card as lost or stolen
  result = api_instance.v1_cards_card_id_lost_stolen_put(bodyuuidacceptclient_idcontent_typeauthorizationcard_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_cards_card_id_lost_stolen_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportLostStolenCardRequest**](ReportLostStolenCardRequest.md)|  | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **String**| Unique Id of the card in encrypted format | 

### Return type

[**ReportLostStolenCardResponse**](ReportLostStolenCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_card_id_overseas_usage_put**
> v1_cards_card_id_overseas_usage_put(bodyuuidacceptclient_idcontent_typeauthorizationcard_id)

Update overseas usage activation

This API is used to activate or deactivate a specified card's ability to be used overseas. Cards can be activated for overseas usage permanently or for a set period of time.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::OverseasCardUsageRequest.new # OverseasCardUsageRequest | 
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # String | Unique Id of the card for activation or de-activation.


begin
  #Update overseas usage activation
  api_instance.v1_cards_card_id_overseas_usage_put(bodyuuidacceptclient_idcontent_typeauthorizationcard_id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_cards_card_id_overseas_usage_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasCardUsageRequest**](OverseasCardUsageRequest.md)|  | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **String**| Unique Id of the card for activation or de-activation. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_get**
> CardListingResponse v1_cards_get(authorization, client_id, uuid, accept, card_function)

Retrieve all cards

This API is used to retrieve all the credit card numbers and correponding details of the customers who authorized the application.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
client_id = 'client_id_example' # String | client id generated during consumer onboarding
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
card_function = 'card_function_example' # String | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.


begin
  #Retrieve all cards
  result = api_instance.v1_cards_get(authorization, client_id, uuid, accept, card_function)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_cards_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **client_id** | **String**| client id generated during consumer onboarding | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **card_function** | **String**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 

### Return type

[**CardListingResponse**](CardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_credit_cards_card_id_supplementary_applications_post**
> SupplementaryCardResponse v1_credit_cards_card_id_supplementary_applications_post(authorizationuuidclient_idcard_id, opts)

Supplementary Card Application

This API is used to authorize Citi Customer to add a Supplementary card to their existing primary card.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
client_id = 'client_id_example' # String | Client ID generated during application registration.
card_id = 'card_id_example' # String | Primary card id in encrypted format.
opts = { 
  body: SwaggerClient::SupplementaryCardRequest.new # SupplementaryCardRequest | 
}

begin
  #Supplementary Card Application
  result = api_instance.v1_credit_cards_card_id_supplementary_applications_post(authorizationuuidclient_idcard_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_credit_cards_card_id_supplementary_applications_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **card_id** | **String**| Primary card id in encrypted format. | 
 **body** | [**SupplementaryCardRequest**](SupplementaryCardRequest.md)|  | [optional] 

### Return type

[**SupplementaryCardResponse**](SupplementaryCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_credit_cards_credit_limits_post**
> CreditLimitIncreaseResponse v1_credit_cards_credit_limits_post(bodyuuidacceptclient_idcontent_typeauthorization)

Request credit limit increase

This API is used to request for a permanent or temporary credit limit increase on credit card.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
body = SwaggerClient::CreditLimitIncreaseRequest.new # CreditLimitIncreaseRequest | 
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.


begin
  #Request credit limit increase
  result = api_instance.v1_credit_cards_credit_limits_post(bodyuuidacceptclient_idcontent_typeauthorization)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_credit_cards_credit_limits_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitIncreaseRequest**](CreditLimitIncreaseRequest.md)|  | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 

### Return type

[**CreditLimitIncreaseResponse**](CreditLimitIncreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



