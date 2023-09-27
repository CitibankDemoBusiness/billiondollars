# swagger_client.CARDSApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notify_credit_charge_card_fulfillment_arrangement_authorised_transaction**](CARDSApi.md#notify_credit_charge_card_fulfillment_arrangement_authorised_transaction) | **POST** /partner/v1/creditChargeCard/transaction/authorised/notify | This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

# **notify_credit_charge_card_fulfillment_arrangement_authorised_transaction**
> notify_credit_charge_card_fulfillment_arrangement_authorised_transaction(body, authorization, uuid, accept, content_type, client_id=client_id, client_details=client_details, accept_language=accept_language, x_jws_signature=x_jws_signature)

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CARDSApi()
body = swagger_client.NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest() # NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest | NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest
authorization = 'authorization_example' # str | HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
content_type = 'content_type_example' # str | application/json
client_id = 'client_id_example' # str | Client ID generated during application registration. (optional)
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
accept_language = 'accept_language_example' # str | List of acceptable human languages for response. (optional)
x_jws_signature = 'x_jws_signature_example' # str | This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB (optional)

try:
    # This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
    api_instance.notify_credit_charge_card_fulfillment_arrangement_authorised_transaction(body, authorization, uuid, accept, content_type, client_id=client_id, client_details=client_details, accept_language=accept_language, x_jws_signature=x_jws_signature)
except ApiException as e:
    print("Exception when calling CARDSApi->notify_credit_charge_card_fulfillment_arrangement_authorised_transaction: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest**](NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.md)| NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest | 
 **authorization** | **str**| HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **content_type** | **str**| application/json | 
 **client_id** | **str**| Client ID generated during application registration. | [optional] 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **accept_language** | **str**| List of acceptable human languages for response. | [optional] 
 **x_jws_signature** | **str**| This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

