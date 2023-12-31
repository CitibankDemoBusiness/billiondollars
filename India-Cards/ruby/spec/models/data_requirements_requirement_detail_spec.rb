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

# Unit tests for SwaggerClient::DataRequirementsRequirementDetail
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'DataRequirementsRequirementDetail' do
  before do
    # run before each test
    @instance = SwaggerClient::DataRequirementsRequirementDetail.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of DataRequirementsRequirementDetail' do
    it 'should create an instance of DataRequirementsRequirementDetail' do
      expect(@instance).to be_instance_of(SwaggerClient::DataRequirementsRequirementDetail)
    end
  end
  describe 'test attribute "nationality"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["malaysian", "non_malaysian", "any"])
      # validator.allowable_values.each do |value|
      #   expect { @instance.nationality = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "nationality_remark"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "residency"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
      # validator = Petstore::EnumTest::EnumAttributeValidator.new('String', ["resident", "non_resident", "any"])
      # validator.allowable_values.each do |value|
      #   expect { @instance.residency = value }.not_to raise_error
      # end
    end
  end

  describe 'test attribute "account_holder_flag"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "applicant"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
