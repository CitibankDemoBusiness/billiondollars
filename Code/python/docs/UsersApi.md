# swagger_client.UsersApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**supplementary_card_application_status_inquiry**](UsersApi.md#supplementary_card_application_status_inquiry) | **GET** /v1/onboarding/supplementary/applications/{applicationId}/status | Check Supplementary Application Status

# **supplementary_card_application_status_inquiry**
> SupplementaryCardApplicationStatusInquiryResponse supplementary_card_application_status_inquiry(authorization, uuid, accept, client_id, application_id, date_of_birth, mother_maiden_name, client_details=client_details)

Check Supplementary Application Status

This API is used to check the status of the supplementary application.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UsersApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | client id generated during consumer on-boarding
application_id = 'application_id_example' # str | This refers to Unique identifier for the application.
date_of_birth = 'date_of_birth_example' # str | Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD
mother_maiden_name = 'mother_maiden_name_example' # str | Mother's maiden name
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # Check Supplementary Application Status
    api_response = api_instance.supplementary_card_application_status_inquiry(authorization, uuid, accept, client_id, application_id, date_of_birth, mother_maiden_name, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UsersApi->supplementary_card_application_status_inquiry: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| client id generated during consumer on-boarding | 
 **application_id** | **str**| This refers to Unique identifier for the application. | 
 **date_of_birth** | **str**| Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD | 
 **mother_maiden_name** | **str**| Mother&#x27;s maiden name | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SupplementaryCardApplicationStatusInquiryResponse**](SupplementaryCardApplicationStatusInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

