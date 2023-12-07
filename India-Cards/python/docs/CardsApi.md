# swagger_client.CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**multi_currency_account_enrollment**](CardsApi.md#multi_currency_account_enrollment) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**multi_currency_account_enrollment_with_currency**](CardsApi.md#multi_currency_account_enrollment_with_currency) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status**](CardsApi.md#retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status) | **GET** /v1/creditChargeCard/cardStatus | Retrieve Credit Card Status
[**v1_cards_card_id_multi_currency_accounts_delete**](CardsApi.md#v1_cards_card_id_multi_currency_accounts_delete) | **DELETE** /v1/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**v1_cards_card_id_multi_currency_accounts_enrollments_currency_post**](CardsApi.md#v1_cards_card_id_multi_currency_accounts_enrollments_currency_post) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**v1_cards_card_id_multi_currency_accounts_enrollments_post**](CardsApi.md#v1_cards_card_id_multi_currency_accounts_enrollments_post) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**v1_cards_card_id_overseas_travel_plans_delete**](CardsApi.md#v1_cards_card_id_overseas_travel_plans_delete) | **DELETE** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to delete an existing travel plan 
[**v1_cards_card_id_overseas_travel_plans_post**](CardsApi.md#v1_cards_card_id_overseas_travel_plans_post) | **POST** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to add a new travel plan
[**v1_cards_card_id_overseas_travel_plans_put**](CardsApi.md#v1_cards_card_id_overseas_travel_plans_put) | **PUT** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to update an existing travel plan
[**v1_cards_multi_currency_accounts_enrollment_eligibility_get**](CardsApi.md#v1_cards_multi_currency_accounts_enrollment_eligibility_get) | **GET** /v1/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
[**v1_cards_overseas_travel_plans_get**](CardsApi.md#v1_cards_overseas_travel_plans_get) | **GET** /v1/cards/overseasTravelPlans | This API enables customer to inquire current travel plan
[**v2_cards_card_id_multi_currency_accounts_delete**](CardsApi.md#v2_cards_card_id_multi_currency_accounts_delete) | **DELETE** /v2/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**v2_cards_multi_currency_accounts_enrollment_eligibility_get**](CardsApi.md#v2_cards_multi_currency_accounts_enrollment_eligibility_get) | **GET** /v2/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

# **multi_currency_account_enrollment**
> MultiCurrencyAccountEnrollmentResponse multi_currency_account_enrollment(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
body = swagger_client.MultiCurrencyAccountEnrollmentRequest() # MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
    api_response = api_instance.multi_currency_account_enrollment(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->multi_currency_account_enrollment: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **multi_currency_account_enrollment_with_currency**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse multi_currency_account_enrollment_with_currency(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
body = swagger_client.MultiCurrencyAccountEnrollmentWithCurrencyRequest() # MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is to generate/enroll new FCY Accounts to Multi Currency Account
    api_response = api_instance.multi_currency_account_enrollment_with_currency(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->multi_currency_account_enrollment_with_currency: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status**
> RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status(authorization, uuid, accept, client_id, card_id, transaction_reference_id, client_details=client_details)

Retrieve Credit Card Status

This API is used to return the credit card status.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
card_id = 'card_id_example' # str | The customer Card identifier in encrypted format.
transaction_reference_id = 'transaction_reference_id_example' # str | This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction.
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # Retrieve Credit Card Status
    api_response = api_instance.retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status(authorization, uuid, accept, client_id, card_id, transaction_reference_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->retrieve_credit_charge_card_fulfillment_arrangement_credit_card_status: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **card_id** | **str**| The customer Card identifier in encrypted format. | 
 **transaction_reference_id** | **str**| This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction. | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_multi_currency_accounts_delete**
> v1_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, client_details=client_details)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
card_id = 'card_id_example' # str | The customer card identifier in encrypted format
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
    api_instance.v1_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, client_details=client_details)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_card_id_multi_currency_accounts_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **card_id** | **str**| The customer card identifier in encrypted format | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_multi_currency_accounts_enrollments_currency_post**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse v1_cards_card_id_multi_currency_accounts_enrollments_currency_post(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
body = swagger_client.MultiCurrencyAccountEnrollmentWithCurrencyRequest() # MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is to generate/enroll new FCY Accounts to Multi Currency Account
    api_response = api_instance.v1_cards_card_id_multi_currency_accounts_enrollments_currency_post(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_card_id_multi_currency_accounts_enrollments_currency_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_multi_currency_accounts_enrollments_post**
> MultiCurrencyAccountEnrollmentResponse v1_cards_card_id_multi_currency_accounts_enrollments_post(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
body = swagger_client.MultiCurrencyAccountEnrollmentRequest() # MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
    api_response = api_instance.v1_cards_card_id_multi_currency_accounts_enrollments_post(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_card_id_multi_currency_accounts_enrollments_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_overseas_travel_plans_delete**
> v1_cards_card_id_overseas_travel_plans_delete(authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API enables customer to delete an existing travel plan 

This API enables customer to delete an existing travel plan 

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The card id  in encrypted format
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API enables customer to delete an existing travel plan 
    api_instance.v1_cards_card_id_overseas_travel_plans_delete(authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_card_id_overseas_travel_plans_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The card id  in encrypted format | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_overseas_travel_plans_post**
> v1_cards_card_id_overseas_travel_plans_post(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API enables customer to add a new travel plan

This API enables customer to add a new travel plan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
body = swagger_client.OverseasTravelPlanAddRequest() # OverseasTravelPlanAddRequest | OverseasTravelPlanAddRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The card id  in encrypted format
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API enables customer to add a new travel plan
    api_instance.v1_cards_card_id_overseas_travel_plans_post(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_card_id_overseas_travel_plans_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanAddRequest**](OverseasTravelPlanAddRequest.md)| OverseasTravelPlanAddRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The card id  in encrypted format | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_overseas_travel_plans_put**
> v1_cards_card_id_overseas_travel_plans_put(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)

This API enables customer to update an existing travel plan

This API enables customer to update an existing travel plan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
body = swagger_client.OverseasTravelPlanUpdateRequest() # OverseasTravelPlanUpdateRequest | OverseasTravelPlanUpdateRequest
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
card_id = 'card_id_example' # str | The card id  in encrypted format
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API enables customer to update an existing travel plan
    api_instance.v1_cards_card_id_overseas_travel_plans_put(body, authorization, uuid, accept, client_id, content_type, card_id, client_details=client_details)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_card_id_overseas_travel_plans_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanUpdateRequest**](OverseasTravelPlanUpdateRequest.md)| OverseasTravelPlanUpdateRequest | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **card_id** | **str**| The card id  in encrypted format | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_multi_currency_accounts_enrollment_eligibility_get**
> MultiCurrencyAccountEligibilityResponse v1_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, client_details=client_details)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
    api_response = api_instance.v1_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_multi_currency_accounts_enrollment_eligibility_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_overseas_travel_plans_get**
> OverseasTravelPlanInquiryResponse v1_cards_overseas_travel_plans_get(authorization, uuid, accept, client_id, client_details=client_details, card_id=card_id)

This API enables customer to inquire current travel plan

This API enables customer to inquire current travel plan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
card_id = 'card_id_example' # str | The card id  in encrypted format (optional)

try:
    # This API enables customer to inquire current travel plan
    api_response = api_instance.v1_cards_overseas_travel_plans_get(authorization, uuid, accept, client_id, client_details=client_details, card_id=card_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->v1_cards_overseas_travel_plans_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **card_id** | **str**| The card id  in encrypted format | [optional] 

### Return type

[**OverseasTravelPlanInquiryResponse**](OverseasTravelPlanInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v2_cards_card_id_multi_currency_accounts_delete**
> v2_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, client_details=client_details)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
card_id = 'card_id_example' # str | The customer card identifier in encrypted format
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
    api_instance.v2_cards_card_id_multi_currency_accounts_delete(authorization, uuid, accept, client_id, card_id, client_details=client_details)
except ApiException as e:
    print("Exception when calling CardsApi->v2_cards_card_id_multi_currency_accounts_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **card_id** | **str**| The customer card identifier in encrypted format | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v2_cards_multi_currency_accounts_enrollment_eligibility_get**
> MultiCurrencyAccountEligibilityResponse v2_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, client_details=client_details)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CardsApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
client_details = 'client_details_example' # str | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)

try:
    # This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
    api_response = api_instance.v2_cards_multi_currency_accounts_enrollment_eligibility_get(authorization, uuid, accept, client_id, client_details=client_details)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CardsApi->v2_cards_multi_currency_accounts_enrollment_eligibility_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **client_details** | **str**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

