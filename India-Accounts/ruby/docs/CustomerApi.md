# SwaggerClient::CustomerApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sufficiency_of_funds**](CustomerApi.md#sufficiency_of_funds) | **GET** /v1/accounts/{accountId}/funds/sufficiencyCheck | Check Availability of Funds

# **sufficiency_of_funds**
> SufficiencyOfFundsResponse sufficiency_of_funds(authorization, uuid, accept, client_id, sufficiency_check_amount, account_id, currency_code, opts)

Check Availability of Funds

This API returns a yes or no, based on the availability of requested funds in the customer’s account.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CustomerApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
sufficiency_check_amount = 1.2 # Float | Specifies amount to check account for sufficiency.
account_id = 'account_id_example' # String | IBAN number of the customer.
currency_code = 'currency_code_example' # String | Currency Code in ISO 4217 format
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Check Availability of Funds
  result = api_instance.sufficiency_of_funds(authorization, uuid, accept, client_id, sufficiency_check_amount, account_id, currency_code, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CustomerApi->sufficiency_of_funds: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **sufficiency_check_amount** | **Float**| Specifies amount to check account for sufficiency. | 
 **account_id** | **String**| IBAN number of the customer. | 
 **currency_code** | **String**| Currency Code in ISO 4217 format | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SufficiencyOfFundsResponse**](SufficiencyOfFundsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



