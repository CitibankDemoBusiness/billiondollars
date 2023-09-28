=begin
#TaxStatement_Digital_Orchestation

#Account Documents APIs Version 2.0. These APIs will be used by Citi Partners to retrieve tax documents for existing Accounts from various regions. PCF Deployment Reference name --> DM-O-DocumentServices-Statements  </br>Version 2.0.0 Added new Tax statements apis.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::TaxStatementsApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'TaxStatementsApi' do
  before do
    # run before each test
    @instance = SwaggerClient::TaxStatementsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of TaxStatementsApi' do
    it 'should create an instance of TaxStatementsApi' do
      expect(@instance).to be_instance_of(SwaggerClient::TaxStatementsApi)
    end
  end

  # unit tests for get_tax_statement
  # OB Return the masked tax statement for the given tax statement id
  # This API retrieves a masked tax statement for the given tax statement id. This global API uses country fields to identify the appropriate regional services.
  # @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
  # @param accept Content types that are acceptable for the response. Currently we support application/json
  # @param content_type Content-Type of the request
  # @param uuid 128 bit random UUID generated uniquely for every request.
  # @param client_id The client ID received during customer onboarding.
  # @param taxstatement_id Unique id that maps to the specific tax statement to be downloaded.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :country_code Two character ISO format country code.
  # @return [Document]
  describe 'get_tax_statement test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for get_tax_statements
  # OB Returns list of masked tax statements
  # This API is used to retrieve list of masked tax statements for given parameters. This global API uses country fields to identify the appropriate regional services.
  # @param authorization The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
  # @param accept Content types that are acceptable for the response. Currently we support application/json
  # @param uuid 128 bit random UUID generated uniquely for every request
  # @param content_type Content-Type of the request
  # @param client_id The client ID received during application registration in the developer portal.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :country_code Two character ISO format country code.
  # @return [Documents]
  describe 'get_tax_statements test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end