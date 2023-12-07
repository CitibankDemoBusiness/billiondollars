# SwaggerClient::UsersApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**supplementary_card_application_status_inquiry**](UsersApi.md#supplementary_card_application_status_inquiry) | **GET** /v1/onboarding/supplementary/applications/{applicationId}/status | Check Supplementary Application Status

# **supplementary_card_application_status_inquiry**
> SupplementaryCardApplicationStatusInquiryResponse supplementary_card_application_status_inquiry(authorization, uuid, accept, client_id, application_id, date_of_birth, mother_maiden_name, opts)

Check Supplementary Application Status

This API is used to check the status of the supplementary application.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::UsersApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client id generated during consumer on-boarding
application_id = 'application_id_example' # String | This refers to Unique identifier for the application.
date_of_birth = 'date_of_birth_example' # String | Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD
mother_maiden_name = 'mother_maiden_name_example' # String | Mother's maiden name
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #Check Supplementary Application Status
  result = api_instance.supplementary_card_application_status_inquiry(authorization, uuid, accept, client_id, application_id, date_of_birth, mother_maiden_name, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UsersApi->supplementary_card_application_status_inquiry: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client id generated during consumer on-boarding | 
 **application_id** | **String**| This refers to Unique identifier for the application. | 
 **date_of_birth** | **String**| Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD | 
 **mother_maiden_name** | **String**| Mother&#x27;s maiden name | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SupplementaryCardApplicationStatusInquiryResponse**](SupplementaryCardApplicationStatusInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



