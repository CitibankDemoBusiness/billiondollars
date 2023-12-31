/*
 * TaxStatement_Digital_Orchestation
 * Account Documents APIs Version 2.0. These APIs will be used by Citi Partners to retrieve tax documents for existing Accounts from various regions. PCF Deployment Reference name --> DM-O-DocumentServices-Statements  </br>Version 2.0.0 Added new Tax statements apis.
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


import io.swagger.client.model.Document;
import io.swagger.client.model.Documents;
import io.swagger.client.model.ErrorResponse;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class TaxStatementsApi {
    private ApiClient apiClient;

    public TaxStatementsApi() {
        this(Configuration.getDefaultApiClient());
    }

    public TaxStatementsApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for getTaxStatement
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param contentType Content-Type of the request (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param clientId The client ID received during customer onboarding. (required)
     * @param taxstatementId Unique id that maps to the specific tax statement to be downloaded. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTaxStatementCall(String authorization, String accept, String contentType, String uuid, String clientId, String taxstatementId, String countryCode, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/taxStatements/{taxstatementId}"
            .replaceAll("\\{" + "taxstatementId" + "\\}", apiClient.escapeString(taxstatementId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        if (authorization != null)
        localVarHeaderParams.put("Authorization", apiClient.parameterToString(authorization));
        if (accept != null)
        localVarHeaderParams.put("Accept", apiClient.parameterToString(accept));
        if (contentType != null)
        localVarHeaderParams.put("Content-Type", apiClient.parameterToString(contentType));
        if (uuid != null)
        localVarHeaderParams.put("uuid", apiClient.parameterToString(uuid));
        if (clientId != null)
        localVarHeaderParams.put("client_id", apiClient.parameterToString(clientId));
        if (countryCode != null)
        localVarHeaderParams.put("countryCode", apiClient.parameterToString(countryCode));

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json", "charset=UTF-8"
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
    private com.squareup.okhttp.Call getTaxStatementValidateBeforeCall(String authorization, String accept, String contentType, String uuid, String clientId, String taxstatementId, String countryCode, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'authorization' is set
        if (authorization == null) {
            throw new ApiException("Missing the required parameter 'authorization' when calling getTaxStatement(Async)");
        }
        // verify the required parameter 'accept' is set
        if (accept == null) {
            throw new ApiException("Missing the required parameter 'accept' when calling getTaxStatement(Async)");
        }
        // verify the required parameter 'contentType' is set
        if (contentType == null) {
            throw new ApiException("Missing the required parameter 'contentType' when calling getTaxStatement(Async)");
        }
        // verify the required parameter 'uuid' is set
        if (uuid == null) {
            throw new ApiException("Missing the required parameter 'uuid' when calling getTaxStatement(Async)");
        }
        // verify the required parameter 'clientId' is set
        if (clientId == null) {
            throw new ApiException("Missing the required parameter 'clientId' when calling getTaxStatement(Async)");
        }
        // verify the required parameter 'taxstatementId' is set
        if (taxstatementId == null) {
            throw new ApiException("Missing the required parameter 'taxstatementId' when calling getTaxStatement(Async)");
        }
        
        com.squareup.okhttp.Call call = getTaxStatementCall(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * OB Return the masked tax statement for the given tax statement id
     * This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param contentType Content-Type of the request (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param clientId The client ID received during customer onboarding. (required)
     * @param taxstatementId Unique id that maps to the specific tax statement to be downloaded. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @return Document
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public Document getTaxStatement(String authorization, String accept, String contentType, String uuid, String clientId, String taxstatementId, String countryCode) throws ApiException {
        ApiResponse<Document> resp = getTaxStatementWithHttpInfo(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode);
        return resp.getData();
    }

    /**
     * OB Return the masked tax statement for the given tax statement id
     * This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param contentType Content-Type of the request (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param clientId The client ID received during customer onboarding. (required)
     * @param taxstatementId Unique id that maps to the specific tax statement to be downloaded. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @return ApiResponse&lt;Document&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<Document> getTaxStatementWithHttpInfo(String authorization, String accept, String contentType, String uuid, String clientId, String taxstatementId, String countryCode) throws ApiException {
        com.squareup.okhttp.Call call = getTaxStatementValidateBeforeCall(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode, null, null);
        Type localVarReturnType = new TypeToken<Document>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * OB Return the masked tax statement for the given tax statement id (asynchronously)
     * This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param contentType Content-Type of the request (required)
     * @param uuid 128 bit random UUID generated uniquely for every request. (required)
     * @param clientId The client ID received during customer onboarding. (required)
     * @param taxstatementId Unique id that maps to the specific tax statement to be downloaded. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTaxStatementAsync(String authorization, String accept, String contentType, String uuid, String clientId, String taxstatementId, String countryCode, final ApiCallback<Document> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = getTaxStatementValidateBeforeCall(authorization, accept, contentType, uuid, clientId, taxstatementId, countryCode, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<Document>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for getTaxStatements
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param uuid 128 bit random UUID generated uniquely for every request (required)
     * @param contentType Content-Type of the request (required)
     * @param clientId The client ID received during application registration in the developer portal. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call getTaxStatementsCall(String authorization, String accept, String uuid, String contentType, String clientId, String countryCode, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/taxStatements";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        if (authorization != null)
        localVarHeaderParams.put("Authorization", apiClient.parameterToString(authorization));
        if (accept != null)
        localVarHeaderParams.put("Accept", apiClient.parameterToString(accept));
        if (uuid != null)
        localVarHeaderParams.put("uuid", apiClient.parameterToString(uuid));
        if (contentType != null)
        localVarHeaderParams.put("Content-Type", apiClient.parameterToString(contentType));
        if (clientId != null)
        localVarHeaderParams.put("client_id", apiClient.parameterToString(clientId));
        if (countryCode != null)
        localVarHeaderParams.put("countryCode", apiClient.parameterToString(countryCode));

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json", "charset=UTF-8"
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
    private com.squareup.okhttp.Call getTaxStatementsValidateBeforeCall(String authorization, String accept, String uuid, String contentType, String clientId, String countryCode, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'authorization' is set
        if (authorization == null) {
            throw new ApiException("Missing the required parameter 'authorization' when calling getTaxStatements(Async)");
        }
        // verify the required parameter 'accept' is set
        if (accept == null) {
            throw new ApiException("Missing the required parameter 'accept' when calling getTaxStatements(Async)");
        }
        // verify the required parameter 'uuid' is set
        if (uuid == null) {
            throw new ApiException("Missing the required parameter 'uuid' when calling getTaxStatements(Async)");
        }
        // verify the required parameter 'contentType' is set
        if (contentType == null) {
            throw new ApiException("Missing the required parameter 'contentType' when calling getTaxStatements(Async)");
        }
        // verify the required parameter 'clientId' is set
        if (clientId == null) {
            throw new ApiException("Missing the required parameter 'clientId' when calling getTaxStatements(Async)");
        }
        
        com.squareup.okhttp.Call call = getTaxStatementsCall(authorization, accept, uuid, contentType, clientId, countryCode, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * OB Returns list of masked tax statements
     * This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param uuid 128 bit random UUID generated uniquely for every request (required)
     * @param contentType Content-Type of the request (required)
     * @param clientId The client ID received during application registration in the developer portal. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @return Documents
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public Documents getTaxStatements(String authorization, String accept, String uuid, String contentType, String clientId, String countryCode) throws ApiException {
        ApiResponse<Documents> resp = getTaxStatementsWithHttpInfo(authorization, accept, uuid, contentType, clientId, countryCode);
        return resp.getData();
    }

    /**
     * OB Returns list of masked tax statements
     * This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param uuid 128 bit random UUID generated uniquely for every request (required)
     * @param contentType Content-Type of the request (required)
     * @param clientId The client ID received during application registration in the developer portal. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @return ApiResponse&lt;Documents&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<Documents> getTaxStatementsWithHttpInfo(String authorization, String accept, String uuid, String contentType, String clientId, String countryCode) throws ApiException {
        com.squareup.okhttp.Call call = getTaxStatementsValidateBeforeCall(authorization, accept, uuid, contentType, clientId, countryCode, null, null);
        Type localVarReturnType = new TypeToken<Documents>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * OB Returns list of masked tax statements (asynchronously)
     * This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.
     * @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners. (required)
     * @param accept Content types that are acceptable for the response. Currently we support application/json (required)
     * @param uuid 128 bit random UUID generated uniquely for every request (required)
     * @param contentType Content-Type of the request (required)
     * @param clientId The client ID received during application registration in the developer portal. (required)
     * @param countryCode Two character ISO format country code. (optional)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call getTaxStatementsAsync(String authorization, String accept, String uuid, String contentType, String clientId, String countryCode, final ApiCallback<Documents> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = getTaxStatementsValidateBeforeCall(authorization, accept, uuid, contentType, clientId, countryCode, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<Documents>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
