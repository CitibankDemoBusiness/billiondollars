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

# Unit tests for SwaggerClient::BankingProductV2CardArt
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'BankingProductV2CardArt' do
  before do
    # run before each test
    @instance = SwaggerClient::BankingProductV2CardArt.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of BankingProductV2CardArt' do
    it 'should create an instance of BankingProductV2CardArt' do
      expect(@instance).to be_instance_of(SwaggerClient::BankingProductV2CardArt)
    end
  end
  describe 'test attribute "title"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "image_uri"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
