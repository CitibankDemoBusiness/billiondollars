/*
 * Accounts
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.api;

import io.swagger.client.ApiCallback;
import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.ApiResponse;
import io.swagger.client.Configuration;
import io.swagger.client.Pair;
import io.swagger.client.ProgressRequestBody;
import io.swagger.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import io.swagger.client.model.ErrorResponse;
import io.swagger.client.model.SufficiencyOfFundsResponse;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class CustomerApi {
    private ApiClient apiClient;

    public CustomerApi() {
        this(Configuration.getDefaultApiClient());
    }

    public CustomerApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for sufficiencyOfFunds
     * @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param accept Content-Type that are acceptable for the response. (required)
     * @param clientId Client ID generated during application registration. (required)
     * @param sufficiencyCheckAmount Specifies amount to check account for sufficiency. (required)
     * @param accountId IBAN number of the customer. (required)
     * @param currencyCode Currency Code in ISO 4217 format (required)
     * @param clientDetails This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call sufficiencyOfFundsCall(String authorization, String uuid, String accept, String clientId, Double sufficiencyCheckAmount, String accountId, String currencyCode, String clientDetails, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/v1/accounts/{accountId}/funds/sufficiencyCheck"
            .replaceAll("\\{" + "accountId" + "\\}", apiClient.escapeString(accountId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        if (sufficiencyCheckAmount != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("sufficiencyCheckAmount", sufficiencyCheckAmount));
        if (currencyCode != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("currencyCode", currencyCode));

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        if (authorization != null)
        localVarHeaderParams.put("Authorization", apiClient.parameterToString(authorization));
        if (uuid != null)
        localVarHeaderParams.put("uuid", apiClient.parameterToString(uuid));
        if (accept != null)
        localVarHeaderParams.put("Accept", apiClient.parameterToString(accept));
        if (clientId != null)
        localVarHeaderParams.put("client_id", apiClient.parameterToString(clientId));
        if (clientDetails != null)
        localVarHeaderParams.put("clientDetails", apiClient.parameterToString(clientDetails));

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] {  };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call sufficiencyOfFundsValidateBeforeCall(String authorization, String uuid, String accept, String clientId, Double sufficiencyCheckAmount, String accountId, String currencyCode, String clientDetails, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'authorization' is set
        if (authorization == null) {
            throw new ApiException("Missing the required parameter 'authorization' when calling sufficiencyOfFunds(Async)");
        }
        // verify the required parameter 'uuid' is set
        if (uuid == null) {
            throw new ApiException("Missing the required parameter 'uuid' when calling sufficiencyOfFunds(Async)");
        }
        // verify the required parameter 'accept' is set
        if (accept == null) {
            throw new ApiException("Missing the required parameter 'accept' when calling sufficiencyOfFunds(Async)");
        }
        // verify the required parameter 'clientId' is set
        if (clientId == null) {
            throw new ApiException("Missing the required parameter 'clientId' when calling sufficiencyOfFunds(Async)");
        }
        // verify the required parameter 'sufficiencyCheckAmount' is set
        if (sufficiencyCheckAmount == null) {
            throw new ApiException("Missing the required parameter 'sufficiencyCheckAmount' when calling sufficiencyOfFunds(Async)");
        }
        // verify the required parameter 'accountId' is set
        if (accountId == null) {
            throw new ApiException("Missing the required parameter 'accountId' when calling sufficiencyOfFunds(Async)");
        }
        // verify the required parameter 'currencyCode' is set
        if (currencyCode == null) {
            throw new ApiException("Missing the required parameter 'currencyCode' when calling sufficiencyOfFunds(Async)");
        }
        
        com.squareup.okhttp.Call call = sufficiencyOfFundsCall(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Check Availability of Funds
     * This API returns a yes or no, based on the availability of requested funds in the customer’s account.
     * @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param accept Content-Type that are acceptable for the response. (required)
     * @param clientId Client ID generated during application registration. (required)
     * @param sufficiencyCheckAmount Specifies amount to check account for sufficiency. (required)
     * @param accountId IBAN number of the customer. (required)
     * @param currencyCode Currency Code in ISO 4217 format (required)
     * @param clientDetails This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @return SufficiencyOfFundsResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public SufficiencyOfFundsResponse sufficiencyOfFunds(String authorization, String uuid, String accept, String clientId, Double sufficiencyCheckAmount, String accountId, String currencyCode, String clientDetails) throws ApiException {
        ApiResponse<SufficiencyOfFundsResponse> resp = sufficiencyOfFundsWithHttpInfo(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails);
        return resp.getData();
    }

    /**
     * Check Availability of Funds
     * This API returns a yes or no, based on the availability of requested funds in the customer’s account.
     * @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param accept Content-Type that are acceptable for the response. (required)
     * @param clientId Client ID generated during application registration. (required)
     * @param sufficiencyCheckAmount Specifies amount to check account for sufficiency. (required)
     * @param accountId IBAN number of the customer. (required)
     * @param currencyCode Currency Code in ISO 4217 format (required)
     * @param clientDetails This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @return ApiResponse&lt;SufficiencyOfFundsResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<SufficiencyOfFundsResponse> sufficiencyOfFundsWithHttpInfo(String authorization, String uuid, String accept, String clientId, Double sufficiencyCheckAmount, String accountId, String currencyCode, String clientDetails) throws ApiException {
        com.squareup.okhttp.Call call = sufficiencyOfFundsValidateBeforeCall(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails, null, null);
        Type localVarReturnType = new TypeToken<SufficiencyOfFundsResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Check Availability of Funds (asynchronously)
     * This API returns a yes or no, based on the availability of requested funds in the customer’s account.
     * @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param accept Content-Type that are acceptable for the response. (required)
     * @param clientId Client ID generated during application registration. (required)
     * @param sufficiencyCheckAmount Specifies amount to check account for sufficiency. (required)
     * @param accountId IBAN number of the customer. (required)
     * @param currencyCode Currency Code in ISO 4217 format (required)
     * @param clientDetails This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call sufficiencyOfFundsAsync(String authorization, String uuid, String accept, String clientId, Double sufficiencyCheckAmount, String accountId, String currencyCode, String clientDetails, final ApiCallback<SufficiencyOfFundsResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = sufficiencyOfFundsValidateBeforeCall(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<SufficiencyOfFundsResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
