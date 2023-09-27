# swagger_client.CreditCardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**easy_payment_plans_transaction_eligibility**](CreditCardsApi.md#easy_payment_plans_transaction_eligibility) | **GET** /v1/creditCards/{cardId}/transactions/eligibility/easyPaymentPlan | Transaction Eligibility and Easy Payment Plans

# **easy_payment_plans_transaction_eligibility**
> EasyPaymentPlansTransactionEligibilityResponse easy_payment_plans_transaction_eligibility(authorization, uuid, accept, client_id, card_id, eligble_loan_amount, client_details=client_details)

Transaction Eligibility and Easy Payment Plans

This API is used to check the Easy Payment Plans eligibility for a card and the available Payment Plans details.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CreditCardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
card_id = 'card_id_example' # str | The card id in encrypted format.
eligble_loan_amount = 1.2 # float | Elligible loan amount for easy payment plan booking..
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # Transaction Eligibility and Easy Payment Plans
    api_response = api_instance.easy_payment_plans_transaction_eligibility(authorization, uuid, accept, client_id, card_id, eligble_loan_amount, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CreditCardsApi->easy_payment_plans_transaction_eligibility: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **card_id** | **str**| The card id in encrypted format. | 
 **eligble_loan_amount** | **float**| Elligible loan amount for easy payment plan booking.. | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EasyPaymentPlansTransactionEligibilityResponse**](EasyPaymentPlansTransactionEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

