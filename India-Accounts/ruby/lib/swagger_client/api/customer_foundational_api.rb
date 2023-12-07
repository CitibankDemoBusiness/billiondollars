=begin
#Accounts

#The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

module SwaggerClient
  class CustomerFoundationalApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
    # This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
    # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
    # @param uuid 128 bit random UUID generated uniquely for every request.
    # @param accept Content-Type that are acceptable for the response.
    # @param client_id Client ID generated during application registration.
    # @param offer_id This Refers to the unique id for the Pre login offer.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
    # @option opts [BigDecimal] :loan_amount Loan amount for easy payment plan booking.
    # @return [EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse]
    def evaluate_customer_eligibility_assessment_check_pre_login(authorization, uuid, accept, client_id, offer_id, opts = {})
      data, _status_code, _headers = evaluate_customer_eligibility_assessment_check_pre_login_with_http_info(authorization, uuid, accept, client_id, offer_id, opts)
      data
    end

    # This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
    # This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
    # @param authorization The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.
    # @param uuid 128 bit random UUID generated uniquely for every request.
    # @param accept Content-Type that are acceptable for the response.
    # @param client_id Client ID generated during application registration.
    # @param offer_id This Refers to the unique id for the Pre login offer.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :client_details This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
    # @option opts [BigDecimal] :loan_amount Loan amount for easy payment plan booking.
    # @return [Array<(EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse, Integer, Hash)>] EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse data, response status code and response headers
    def evaluate_customer_eligibility_assessment_check_pre_login_with_http_info(authorization, uuid, accept, client_id, offer_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CustomerFoundationalApi.evaluate_customer_eligibility_assessment_check_pre_login ...'
      end
      # verify the required parameter 'authorization' is set
      if @api_client.config.client_side_validation && authorization.nil?
        fail ArgumentError, "Missing the required parameter 'authorization' when calling CustomerFoundationalApi.evaluate_customer_eligibility_assessment_check_pre_login"
      end
      # verify the required parameter 'uuid' is set
      if @api_client.config.client_side_validation && uuid.nil?
        fail ArgumentError, "Missing the required parameter 'uuid' when calling CustomerFoundationalApi.evaluate_customer_eligibility_assessment_check_pre_login"
      end
      # verify the required parameter 'accept' is set
      if @api_client.config.client_side_validation && accept.nil?
        fail ArgumentError, "Missing the required parameter 'accept' when calling CustomerFoundationalApi.evaluate_customer_eligibility_assessment_check_pre_login"
      end
      # verify the required parameter 'client_id' is set
      if @api_client.config.client_side_validation && client_id.nil?
        fail ArgumentError, "Missing the required parameter 'client_id' when calling CustomerFoundationalApi.evaluate_customer_eligibility_assessment_check_pre_login"
      end
      # verify the required parameter 'offer_id' is set
      if @api_client.config.client_side_validation && offer_id.nil?
        fail ArgumentError, "Missing the required parameter 'offer_id' when calling CustomerFoundationalApi.evaluate_customer_eligibility_assessment_check_pre_login"
      end
      # resource path
      local_var_path = '/v1/preLogin/customerProductServiceEligibility/check/offers/{offerId}'.sub('{' + 'offerId' + '}', offer_id.to_s)

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'loanAmount'] = opts[:'loan_amount'] if !opts[:'loan_amount'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      header_params[:'Authorization'] = authorization
      header_params[:'uuid'] = uuid
      header_params[:'Accept'] = accept
      header_params[:'client_id'] = client_id
      header_params[:'clientDetails'] = opts[:'client_details'] if !opts[:'client_details'].nil?

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      return_type = opts[:return_type] || 'EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse' 

      auth_names = opts[:auth_names] || []
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: CustomerFoundationalApi#evaluate_customer_eligibility_assessment_check_pre_login\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
