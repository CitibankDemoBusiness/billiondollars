# SwaggerClient::RewardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1_credit_cards_rewards_point_balance_search_post**](RewardsApi.md#v1_credit_cards_rewards_point_balance_search_post) | **POST** /v1/creditCards/rewards/pointBalance/search | This API is used to retrieve reward points balance for multiple credit cards

# **v1_credit_cards_rewards_point_balance_search_post**
> RewardsInquiryResponse v1_credit_cards_rewards_point_balance_search_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to retrieve reward points balance for multiple credit cards

This API is used to retrieve reward points balance for multiple credit cards

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::RewardsApi.new
body = SwaggerClient::RewardsInquiryRequest.new # RewardsInquiryRequest | 
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | The client ID  you received during application registration in the developer portal
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to retrieve reward points balance for multiple credit cards
  result = api_instance.v1_credit_cards_rewards_point_balance_search_post(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling RewardsApi->v1_credit_cards_rewards_point_balance_search_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RewardsInquiryRequest**](RewardsInquiryRequest.md)|  | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| The client ID  you received during application registration in the developer portal | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RewardsInquiryResponse**](RewardsInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



