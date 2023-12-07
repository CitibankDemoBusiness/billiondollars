# SwaggerClient::CROSSPRODUCTUTILITIESApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**update_issued_device_allocation_device_pfid**](CROSSPRODUCTUTILITIESApi.md#update_issued_device_allocation_device_pfid) | **POST** /v1/issuedDeviceAdministration/device/pfid | This API is used to receive the PFID from partner and maintain across the respective card.

# **update_issued_device_allocation_device_pfid**
> UpdateIssuedDeviceAllocationDevicePfidResponse update_issued_device_allocation_device_pfid(bodyauthorizationuuidacceptclient_idcontent_type, opts)

This API is used to receive the PFID from partner and maintain across the respective card.

This API is used to receive the PFID from partner and maintain across the respective card.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CROSSPRODUCTUTILITIESApi.new
body = SwaggerClient::UpdateIssuedDeviceAllocationDevicePfidRequest.new # UpdateIssuedDeviceAllocationDevicePfidRequest | UpdateIssuedDeviceAllocationDevicePfidRequest
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to receive the PFID from partner and maintain across the respective card.
  result = api_instance.update_issued_device_allocation_device_pfid(bodyauthorizationuuidacceptclient_idcontent_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CROSSPRODUCTUTILITIESApi->update_issued_device_allocation_device_pfid: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateIssuedDeviceAllocationDevicePfidRequest**](UpdateIssuedDeviceAllocationDevicePfidRequest.md)| UpdateIssuedDeviceAllocationDevicePfidRequest | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateIssuedDeviceAllocationDevicePfidResponse**](UpdateIssuedDeviceAllocationDevicePfidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



