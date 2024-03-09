# swagger_client.OnboardingApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**applicant_salary_and_contributions_upload**](OnboardingApi.md#applicant_salary_and_contributions_upload) | **POST** /v1/onboarding/applications/{applicationId}/applicants/salariesAndContributions/upload | Upload Salary and Employer Contributions (Superannuation) Document

# **applicant_salary_and_contributions_upload**
> applicant_salary_and_contributions_upload(body, authorization, uuid, accept, client_id, content_type, application_id, client_details=client_details)

Upload Salary and Employer Contributions (Superannuation) Document

This API is used to upload the salary and employer contributions (superannuation) document retrieved from third party (Verifier) to host (CI).

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.OnboardingApi()
body = swagger_client.ApplicantSalaryAndContributionsUploadRequest() # ApplicantSalaryAndContributionsUploadRequest | ApplicantSalaryAndContributionsUploadRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
application_id = 'application_id_example' # str | Unique identifier for the application
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # Upload Salary and Employer Contributions (Superannuation) Document
    api_instance.applicant_salary_and_contributions_upload(body, authorization, uuid, accept, client_id, content_type, application_id, client_details=client_details)
except ApiException as e:
    print("Exception when calling OnboardingApi->applicant_salary_and_contributions_upload: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicantSalaryAndContributionsUploadRequest**](ApplicantSalaryAndContributionsUploadRequest.md)| ApplicantSalaryAndContributionsUploadRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **application_id** | **str**| Unique identifier for the application | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

