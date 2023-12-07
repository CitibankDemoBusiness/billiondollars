# SwaggerClient::CustomerFoundationalApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact**](CustomerFoundationalApi.md#retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact) | **POST** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts/retrieve | This API is used to inquire the Customer contact details.
[**update_customer_reference_data_directory_entry_corporate_card_customer_contact**](CustomerFoundationalApi.md#update_customer_reference_data_directory_entry_corporate_card_customer_contact) | **PUT** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts | This API is used to update customer contact details

# **retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact**
> RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact(authorization, uuid, accept, client_id, content_type, opts)

This API is used to inquire the Customer contact details.

This API is used to inquire the Customer contact details.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CustomerFoundationalApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example', # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to inquire the Customer contact details.
  result = api_instance.retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact(authorization, uuid, accept, client_id, content_type, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CustomerFoundationalApi->retrieve_customer_reference_data_directory_entry_corporate_card_customer_contact: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse**](RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **update_customer_reference_data_directory_entry_corporate_card_customer_contact**
> update_customer_reference_data_directory_entry_corporate_card_customer_contact(authorization, uuid, accept, client_id, content_type, opts)

This API is used to update customer contact details

This API is used to update customer contact details

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::CustomerFoundationalApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | Client ID generated during application registration.
content_type = 'content_type_example' # String | application/json
opts = { 
  accept_language: 'accept_language_example', # String | List of acceptable human languages for response.
  client_details: 'client_details_example' # String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
}

begin
  #This API is used to update customer contact details
  api_instance.update_customer_reference_data_directory_entry_corporate_card_customer_contact(authorization, uuid, accept, client_id, content_type, opts)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CustomerFoundationalApi->update_customer_reference_data_directory_entry_corporate_card_customer_contact: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| Client ID generated during application registration. | 
 **content_type** | **String**| application/json | 
 **accept_language** | **String**| List of acceptable human languages for response. | [optional] 
 **client_details** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



