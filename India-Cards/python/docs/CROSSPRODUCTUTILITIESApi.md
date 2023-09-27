# swagger_client.CROSSPRODUCTUTILITIESApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**update_issued_device_allocation_device_pfid**](CROSSPRODUCTUTILITIESApi.md#update_issued_device_allocation_device_pfid) | **POST** /v1/issuedDeviceAdministration/device/pfid | This API is used to receive the PFID from partner and maintain across the respective card.

# **update_issued_device_allocation_device_pfid**
> UpdateIssuedDeviceAllocationDevicePfidResponse update_issued_device_allocation_device_pfid(body, authorization, uuid, accept, client_id, content_type, client_details=client_details)

This API is used to receive the PFID from partner and maintain across the respective card.

This API is used to receive the PFID from partner and maintain across the respective card.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CROSSPRODUCTUTILITIESApi()
body = swagger_client.UpdateIssuedDeviceAllocationDevicePfidRequest() # UpdateIssuedDeviceAllocationDevicePfidRequest | UpdateIssuedDeviceAllocationDevicePfidRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is used to receive the PFID from partner and maintain across the respective card.
    api_response = api_instance.update_issued_device_allocation_device_pfid(body, authorization, uuid, accept, client_id, content_type, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CROSSPRODUCTUTILITIESApi->update_issued_device_allocation_device_pfid: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateIssuedDeviceAllocationDevicePfidRequest**](UpdateIssuedDeviceAllocationDevicePfidRequest.md)| UpdateIssuedDeviceAllocationDevicePfidRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateIssuedDeviceAllocationDevicePfidResponse**](UpdateIssuedDeviceAllocationDevicePfidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

