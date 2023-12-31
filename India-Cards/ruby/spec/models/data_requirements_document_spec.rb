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

# Unit tests for SwaggerClient::DataRequirementsDocument
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'DataRequirementsDocument' do
  before do
    # run before each test
    @instance = SwaggerClient::DataRequirementsDocument.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of DataRequirementsDocument' do
    it 'should create an instance of DataRequirementsDocument' do
      expect(@instance).to be_instance_of(SwaggerClient::DataRequirementsDocument)
    end
  end
  describe 'test attribute "item"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["bank_statement", "business_registration_certificate", "commision_statement", "dividend_statement", "employment_confirmation_letter", "epf_statement", "form_24", "form_49", "form_9", "identity_card_passport", "interest_statement", "others", "salary_slip", "tax_receipt", "tax_returns", "travel_visa", "valid_work_permit"])
      # validator.allowable_values.each do |value|
      #   expect { @instance.item = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "remark"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
