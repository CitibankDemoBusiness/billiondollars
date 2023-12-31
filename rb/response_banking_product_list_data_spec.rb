=begin
#ConsumerDataStandards_Digital_Regulatory

#The product \\amp Product Details APIs allow third-parties to retrieve a list of Product categories \\amp details for Citi and our White-label Partners.

OpenAPI spec version: 1.2.0
Contact: cdr-data61@csiro.au
Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::ResponseBankingProductListData
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'ResponseBankingProductListData' do
  before do
    # run before each test
    @instance = SwaggerClient::ResponseBankingProductListData.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of ResponseBankingProductListData' do
    it 'should create an instance of ResponseBankingProductListData' do
      expect(@instance).to be_instance_of(SwaggerClient::ResponseBankingProductListData)
    end
  end
  describe 'test attribute "products"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
