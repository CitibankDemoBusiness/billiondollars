# SwaggerClient::BalanceTransferEligibilityDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **String** | The account id  in encrypted format. | 
**display_account_number** | **String** | A masked account number that can be displayed to the customer. | 
**bt_supported_account_group** | **String** | This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description. | [optional] 
**maximum_eligible_loan_amount** | **Float** | This field indicates the maximum eligible amount for loan. | 
**minimum_eligible_loan_amount** | **Float** | This field indicates the minimum eligible amount for loan. | [optional] 
**bt_disbursement_options** | [**Array&lt;BtDisbursementOptions&gt;**](BtDisbursementOptions.md) |  | 
**payment_pans** | [**Array&lt;PaymentPans&gt;**](PaymentPans.md) |  | [optional] 

