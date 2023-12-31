=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::CardsLimitsAndEnrollmentsUpdateRequest
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CardsLimitsAndEnrollmentsUpdateRequest' do
  before do
    # run before each test
    @instance = SwaggerClient::CardsLimitsAndEnrollmentsUpdateRequest.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CardsLimitsAndEnrollmentsUpdateRequest' do
    it 'should create an instance of CardsLimitsAndEnrollmentsUpdateRequest' do
      expect(@instance).to be_instance_of(SwaggerClient::CardsLimitsAndEnrollmentsUpdateRequest)
    end
  end
  describe 'test attribute "credit_card_details"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "debit_card_details"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
