# SwaggerClient::CardServicingApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1_cards_activations_confirmation_post**](CardServicingApi.md#v1_cards_activations_confirmation_post) | **POST** /v1/cards/activations/confirmation | Confirm Card Activation Deactivation
[**v1_cards_atm_pin_reset_confirmation_post**](CardServicingApi.md#v1_cards_atm_pin_reset_confirmation_post) | **POST** /v1/cards/atmPin/reset/confirmation | Confirm ATM Pin Request
[**v1_cards_atm_pin_reset_put**](CardServicingApi.md#v1_cards_atm_pin_reset_put) | **PUT** /v1/cards/atmPin/reset | Reset ATM Pin
[**v1_cards_overseas_usage_confirmation_post**](CardServicingApi.md#v1_cards_overseas_usage_confirmation_post) | **POST** /v1/cards/overseasUsage/confirmation | Confirm Card Overseas Activation Deactivation

# **v1_cards_activations_confirmation_post**
> v1_cards_activations_confirmation_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Confirm Card Activation Deactivation

This API is triggered after initiating the Card activation/de-activation request  and completes card activation/de-activation post successful multifactor authentication.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardServicingApi.new
body = SwaggerClient::CardUsageConfirmationRequest.new # CardUsageConfirmationRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Confirm Card Activation Deactivation
  api_instance.v1_cards_activations_confirmation_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardServicingApi->v1_cards_activations_confirmation_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardUsageConfirmationRequest**](CardUsageConfirmationRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
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



# **v1_cards_atm_pin_reset_confirmation_post**
> ResetAtmPinConfirmationResponse v1_cards_atm_pin_reset_confirmation_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Confirm ATM Pin Request

This API is triggered after the reset ATM Pin request and completes ATM Pin reset post successful multifactor authentication.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardServicingApi.new
body = SwaggerClient::ResetAtmPinConfirmationRequest.new # ResetAtmPinConfirmationRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Confirm ATM Pin Request
  result = api_instance.v1_cards_atm_pin_reset_confirmation_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardServicingApi->v1_cards_atm_pin_reset_confirmation_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ResetAtmPinConfirmationRequest**](ResetAtmPinConfirmationRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ResetAtmPinConfirmationResponse**](ResetAtmPinConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **v1_cards_atm_pin_reset_put**
> v1_cards_atm_pin_reset_put(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Reset ATM Pin

This API is used to reset the ATM Pin of the cards.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardServicingApi.new
body = SwaggerClient::ResetAtmPinRequest.new # ResetAtmPinRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Reset ATM Pin
  api_instance.v1_cards_atm_pin_reset_put(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardServicingApi->v1_cards_atm_pin_reset_put: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ResetAtmPinRequest**](ResetAtmPinRequest.md)|  | 
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



# **v1_cards_overseas_usage_confirmation_post**
> v1_cards_overseas_usage_confirmation_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

Confirm Card Overseas Activation Deactivation

This API is triggered after initiating the Card Overseas usage activation/deactivation request and completes the overseas usage activation/deactivation post successful multifactor authentication

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CardServicingApi.new
body = SwaggerClient::CardOverseasUsageConfirmationRequest.new # CardOverseasUsageConfirmationRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Confirm Card Overseas Activation Deactivation
  api_instance.v1_cards_overseas_usage_confirmation_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CardServicingApi->v1_cards_overseas_usage_confirmation_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardOverseasUsageConfirmationRequest**](CardOverseasUsageConfirmationRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
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



