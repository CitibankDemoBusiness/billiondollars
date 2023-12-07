# SwaggerClient::PayeeAccountDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payee_nick_name** | **String** | The nick name of the payee assigned by the customer. | [optional] 
**payee_name** | **String** | Name of the payee. | [optional] 
**display_payee_account_number** | **String** | The display account number of the destination account | [optional] 
**iban** | **String** | IBAN stands for International Bank Account Number and is a number attached to all accounts in the EU countries plus Norway, Switzerland, Liechtenstein and Hungary. The IBAN is made up of a code that identifies the country the account belongs to, the account holders bank and the account number itself | [optional] 
**payee_id** | **String** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**payee_bank_name** | **String** | Name of the bank. | [optional] 
**payment_type** | **String** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | [optional] 
**bank_code** | **String** | Bank Code of the Payee | [optional] 

