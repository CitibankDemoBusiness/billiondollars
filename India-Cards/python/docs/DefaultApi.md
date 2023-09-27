# swagger_client.DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1_cards_card_id_activations_card_activation_code_put**](DefaultApi.md#v1_cards_card_id_activations_card_activation_code_put) | **PUT** /v1/cards/{cardId}/activations/{cardActivationCode} | Update local usage activation
[**v1_cards_card_id_lost_stolen_put**](DefaultApi.md#v1_cards_card_id_lost_stolen_put) | **PUT** /v1/cards/{cardId}/lostStolen | Report card as lost or stolen
[**v1_cards_card_id_overseas_usage_put**](DefaultApi.md#v1_cards_card_id_overseas_usage_put) | **PUT** /v1/cards/{cardId}/overseasUsage | Update overseas usage activation
[**v1_cards_get**](DefaultApi.md#v1_cards_get) | **GET** /v1/cards | Retrieve all cards
[**v1_credit_cards_card_id_supplementary_applications_post**](DefaultApi.md#v1_credit_cards_card_id_supplementary_applications_post) | **POST** /v1/creditCards/{cardId}/supplementary/applications | Supplementary Card Application
[**v1_credit_cards_credit_limits_post**](DefaultApi.md#v1_credit_cards_credit_limits_post) | **POST** /v1/creditCards/creditLimits | Request credit limit increase

# **v1_cards_card_id_activations_card_activation_code_put**
> v1_cards_card_id_activations_card_activation_code_put(uuid, client_id, authorization, card_id, card_activation_code, body=body)

Update local usage activation

This API is used to activate or deactivate the specified card's ability to be used locally.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
client_id = 'client_id_example' # str | Client ID generated during application registration.
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # str | Card Id in encrypted format
card_activation_code = 'card_activation_code_example' # str | Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values.
body = swagger_client.CardUsageRequest() # CardUsageRequest |  (optional)

try:
    # Update local usage activation
    api_instance.v1_cards_card_id_activations_card_activation_code_put(uuid, client_id, authorization, card_id, card_activation_code, body=body)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_cards_card_id_activations_card_activation_code_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **str**| Card Id in encrypted format | 
 **card_activation_code** | **str**| Activation Code for card Usage. Possible values:ACTIVATE, DEACTIVATE.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardActivationCode} resource to get valid value of this field with description. You can use the cardActivationCode as the referenceCode parameter to retrieve the values. | 
 **body** | [**CardUsageRequest**](CardUsageRequest.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_lost_stolen_put**
> ReportLostStolenCardResponse v1_cards_card_id_lost_stolen_put(body, uuid, accept, client_id, content_type, authorization, card_id)

Report card as lost or stolen

This API is used to report a specified card as lost or stolen and returns a reference number to track the request.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.ReportLostStolenCardRequest() # ReportLostStolenCardRequest | 
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # str | Unique Id of the card in encrypted format

try:
    # Report card as lost or stolen
    api_response = api_instance.v1_cards_card_id_lost_stolen_put(body, uuid, accept, client_id, content_type, authorization, card_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_cards_card_id_lost_stolen_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReportLostStolenCardRequest**](ReportLostStolenCardRequest.md)|  | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **str**| Unique Id of the card in encrypted format | 

### Return type

[**ReportLostStolenCardResponse**](ReportLostStolenCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_card_id_overseas_usage_put**
> v1_cards_card_id_overseas_usage_put(body, uuid, accept, client_id, content_type, authorization, card_id)

Update overseas usage activation

This API is used to activate or deactivate a specified card's ability to be used overseas. Cards can be activated for overseas usage permanently or for a set period of time.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.OverseasCardUsageRequest() # OverseasCardUsageRequest | 
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
card_id = 'card_id_example' # str | Unique Id of the card for activation or de-activation.

try:
    # Update overseas usage activation
    api_instance.v1_cards_card_id_overseas_usage_put(body, uuid, accept, client_id, content_type, authorization, card_id)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_cards_card_id_overseas_usage_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasCardUsageRequest**](OverseasCardUsageRequest.md)|  | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **card_id** | **str**| Unique Id of the card for activation or de-activation. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_cards_get**
> CardListingResponse v1_cards_get(authorization, client_id, uuid, accept, card_function)

Retrieve all cards

This API is used to retrieve all the credit card numbers and correponding details of the customers who authorized the application.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
client_id = 'client_id_example' # str | client id generated during consumer onboarding
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
card_function = 'card_function_example' # str | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.

try:
    # Retrieve all cards
    api_response = api_instance.v1_cards_get(authorization, client_id, uuid, accept, card_function)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_cards_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **client_id** | **str**| client id generated during consumer onboarding | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **card_function** | **str**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 

### Return type

[**CardListingResponse**](CardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_credit_cards_card_id_supplementary_applications_post**
> SupplementaryCardResponse v1_credit_cards_card_id_supplementary_applications_post(authorization, uuid, client_id, card_id, body=body)

Supplementary Card Application

This API is used to authorize Citi Customer to add a Supplementary card to their existing primary card.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
client_id = 'client_id_example' # str | Client ID generated during application registration.
card_id = 'card_id_example' # str | Primary card id in encrypted format.
body = swagger_client.SupplementaryCardRequest() # SupplementaryCardRequest |  (optional)

try:
    # Supplementary Card Application
    api_response = api_instance.v1_credit_cards_card_id_supplementary_applications_post(authorization, uuid, client_id, card_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_credit_cards_card_id_supplementary_applications_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **card_id** | **str**| Primary card id in encrypted format. | 
 **body** | [**SupplementaryCardRequest**](SupplementaryCardRequest.md)|  | [optional] 

### Return type

[**SupplementaryCardResponse**](SupplementaryCardResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **v1_credit_cards_credit_limits_post**
> CreditLimitIncreaseResponse v1_credit_cards_credit_limits_post(body, uuid, accept, client_id, content_type, authorization)

Request credit limit increase

This API is used to request for a permanent or temporary credit limit increase on credit card.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DefaultApi()
body = swagger_client.CreditLimitIncreaseRequest() # CreditLimitIncreaseRequest | 
uuid = 'uuid_example' # str | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # str | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # str | Client ID generated during application registration.
content_type = 'content_type_example' # str | application/json
authorization = 'authorization_example' # str | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.

try:
    # Request credit limit increase
    api_response = api_instance.v1_credit_cards_credit_limits_post(body, uuid, accept, client_id, content_type, authorization)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DefaultApi->v1_credit_cards_credit_limits_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitIncreaseRequest**](CreditLimitIncreaseRequest.md)|  | 
 **uuid** | **str**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **str**| Content-Type that are acceptable for the response. | 
 **client_id** | **str**| Client ID generated during application registration. | 
 **content_type** | **str**| application/json | 
 **authorization** | **str**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 

### Return type

[**CreditLimitIncreaseResponse**](CreditLimitIncreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

