# swagger_client.CustomerApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sufficiency_of_funds**](CustomerApi.md#sufficiency_of_funds) | **GET** /v1/accounts/{accountId}/funds/sufficiencyCheck | Check Availability of Funds

# **sufficiency_of_funds**
> SufficiencyOfFundsResponse sufficiency_of_funds(authorization, uuid, accept, client_id, sufficiency_check_amount, account_id, currency_code, client_details=client_details)

Check Availability of Funds

This API returns a yes or no, based on the availability of requested funds in the customer’s account.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
sufficiency_check_amount = 1.2 # float | Specifies amount to check account for sufficiency.
account_id = 'account_id_example' # str | IBAN number of the customer.
currency_code = 'currency_code_example' # str | Currency Code in ISO 4217 format
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # Check Availability of Funds
    api_response = api_instance.sufficiency_of_funds(authorization, uuid, accept, client_id, sufficiency_check_amount, account_id, currency_code, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerApi->sufficiency_of_funds: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **sufficiency_check_amount** | **float**| Specifies amount to check account for sufficiency. | 
 **account_id** | **str**| IBAN number of the customer. | 
 **currency_code** | **str**| Currency Code in ISO 4217 format | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SufficiencyOfFundsResponse**](SufficiencyOfFundsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

