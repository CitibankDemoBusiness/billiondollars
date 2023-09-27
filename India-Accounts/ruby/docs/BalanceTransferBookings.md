# SwaggerClient::BalanceTransferBookings

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **Float** | This field is to indicate the loan amount for booking. | 
**bt_disbursement_option** | **String** | Provide the list of the options available to receive the disbursement of balance transfer. Please use /v1/utilities/referenceData/{btDisbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **String** | The disbursement account identifier in encrypted format. Applicable only for HK. | [optional] 
**payee_type** | **String** | Identifies the type of payee based on the destination of the payee.This is a reference data field. Please use /v1/utilities/referenceData/{payeeType} resource to get valid value of this field with description.  | [optional] 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 

