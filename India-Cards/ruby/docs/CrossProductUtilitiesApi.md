# SwaggerClient::CrossProductUtilitiesApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**activate_card**](CrossProductUtilitiesApi.md#activate_card) | **PUT** /v1/prelogin/cards/{cardId}/activations | This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.
[**change_atm_pin**](CrossProductUtilitiesApi.md#change_atm_pin) | **PUT** /v1/prelogin/cards/atmPin/change | This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal. In  case this API is exposed to external party, TISO review will be required.

# **activate_card**
> activate_card(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CrossProductUtilitiesApi.new
body = SwaggerClient::ActivateCardRequest.new # ActivateCardRequest | ActivateCardRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
card_id = 'card_id_example' # String | Hashed card number of the customer
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.
  api_instance.activate_card(bodyauthorizationuuidacceptclient_idcontent_typecard_id, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CrossProductUtilitiesApi->activate_card: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActivateCardRequest**](ActivateCardRequest.md)| ActivateCardRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **card_id** | **String**| Hashed card number of the customer | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **change_atm_pin**
> change_atm_pin(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal. In  case this API is exposed to external party, TISO review will be required.

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal.  In case this API is exposed to external party, TISO review will be required.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CrossProductUtilitiesApi.new
body = SwaggerClient::ChangeAtmPinRequest.new # ChangeAtmPinRequest | ChangeAtmPinRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal. In  case this API is exposed to external party, TISO review will be required.
  api_instance.change_atm_pin(bodyauthorizationuuidacceptclient_idcontent_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CrossProductUtilitiesApi->change_atm_pin: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeAtmPinRequest**](ChangeAtmPinRequest.md)| ChangeAtmPinRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



