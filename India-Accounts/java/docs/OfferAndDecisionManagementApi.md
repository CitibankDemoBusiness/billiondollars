# OfferAndDecisionManagementApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**](OfferAndDecisionManagementApi.md#executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/offerAcceptanceAndSubmission | This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit
[**initiateApplicationProcessingUnsecuredLoanTopup**](OfferAndDecisionManagementApi.md#initiateApplicationProcessingUnsecuredLoanTopup) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications | This API is used to create application for  loan top-up for existing credit card customer. This is for post login function
[**retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**](OfferAndDecisionManagementApi.md#retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule) | **GET** /v1/applicationProcessing/products/unsecuredLoans/topup/repaymentSchedule | This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit
[**updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**](OfferAndDecisionManagementApi.md#updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/backgroundScreening | This API is used to update a saved Loan top-up application &amp; do background screening
[**updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**](OfferAndDecisionManagementApi.md#updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval) | **POST** /v1/applicationProcessing/products/unsecuredLoans/topup/applications/{applicationId}/inPrincipleApprovals | This API is used to update a saved Loan top-up application and in principle approval

<a name="executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission"></a>
# **executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission**
> executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit

This API is used to perform offer acceptance for Loan Top Up Application &amp; final submit

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OfferAndDecisionManagementApi;


OfferAndDecisionManagementApi apiInstance = new OfferAndDecisionManagementApi();
ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest body = new ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest(); // ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest | ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | 
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling OfferAndDecisionManagementApi#executeApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmission");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest**](ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest.md)| ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**|  |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="initiateApplicationProcessingUnsecuredLoanTopup"></a>
# **initiateApplicationProcessingUnsecuredLoanTopup**
> InitiateApplicationProcessingUnsecuredLoanTopupResponse initiateApplicationProcessingUnsecuredLoanTopup(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

This API is used to create application for  loan top-up for existing credit card customer. This is for post login function

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OfferAndDecisionManagementApi;


OfferAndDecisionManagementApi apiInstance = new OfferAndDecisionManagementApi();
InitiateApplicationProcessingUnsecuredLoanTopupRequest body = new InitiateApplicationProcessingUnsecuredLoanTopupRequest(); // InitiateApplicationProcessingUnsecuredLoanTopupRequest | InitiateApplicationProcessingUnsecuredLoanTopupRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    InitiateApplicationProcessingUnsecuredLoanTopupResponse result = apiInstance.initiateApplicationProcessingUnsecuredLoanTopup(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OfferAndDecisionManagementApi#initiateApplicationProcessingUnsecuredLoanTopup");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiateApplicationProcessingUnsecuredLoanTopupRequest**](InitiateApplicationProcessingUnsecuredLoanTopupRequest.md)| InitiateApplicationProcessingUnsecuredLoanTopupRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**InitiateApplicationProcessingUnsecuredLoanTopupResponse**](InitiateApplicationProcessingUnsecuredLoanTopupResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule"></a>
# **retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule**
> RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule(authorization, uuid, accept, clientId, contentType, loanAmount, insurancePremiumAmount, feeAmount, loanInterestRate, tenor, clientDetails)

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

This API fetches repayment schedule details for a loan including loan amount, tenor, rates, fees, etc for unsecured loans on ready credit

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OfferAndDecisionManagementApi;


OfferAndDecisionManagementApi apiInstance = new OfferAndDecisionManagementApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
Double loanAmount = 3.4D; // Double | Loan amount
Double insurancePremiumAmount = 3.4D; // Double | Insurance premium amount
Double feeAmount = 3.4D; // Double | Fee amount
Double loanInterestRate = 3.4D; // Double | Loan interest rate
Integer tenor = 56; // Integer | Tenor
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse result = apiInstance.retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule(authorization, uuid, accept, clientId, contentType, loanAmount, insurancePremiumAmount, feeAmount, loanInterestRate, tenor, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OfferAndDecisionManagementApi#retrieveApplicationProcessingUnsecuredLoanTopupRepaymentSchedule");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **loanAmount** | **Double**| Loan amount |
 **insurancePremiumAmount** | **Double**| Insurance premium amount |
 **feeAmount** | **Double**| Fee amount |
 **loanInterestRate** | **Double**| Loan interest rate |
 **tenor** | **Integer**| Tenor |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse**](RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening"></a>
# **updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening**
> UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

This API is used to update a saved Loan top-up application &amp; do background screening

This API is used to update a saved Loan top-up application &amp; do background screening

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OfferAndDecisionManagementApi;


OfferAndDecisionManagementApi apiInstance = new OfferAndDecisionManagementApi();
UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest body = new UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest(); // UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest | UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | 
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse result = apiInstance.updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OfferAndDecisionManagementApi#updateApplicationProcessingUnsecuredLoanTopupBackgroundScreening");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest**](UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest.md)| UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**|  |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse**](UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval"></a>
# **updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval**
> UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails)

This API is used to update a saved Loan top-up application and in principle approval

This API is used to update a saved Loan top-up application and in principle approval

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.OfferAndDecisionManagementApi;


OfferAndDecisionManagementApi apiInstance = new OfferAndDecisionManagementApi();
RequestedLoanTopupDecision body = new RequestedLoanTopupDecision(); // RequestedLoanTopupDecision | RequestedLoanTopupDecision
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String applicationId = "applicationId_example"; // String | 
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse result = apiInstance.updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval(body, authorization, uuid, accept, clientId, contentType, applicationId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling OfferAndDecisionManagementApi#updateApplicationProcessingUnsecuredLoanTopupInPrincipalApproval");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestedLoanTopupDecision**](RequestedLoanTopupDecision.md)| RequestedLoanTopupDecision |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **applicationId** | **String**|  |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse**](UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

