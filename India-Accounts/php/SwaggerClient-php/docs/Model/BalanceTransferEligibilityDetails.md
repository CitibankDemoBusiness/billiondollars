# BalanceTransferEligibilityDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **string** | The account id  in encrypted format. | 
**display_account_number** | **string** | A masked account number that can be displayed to the customer. | 
**bt_supported_account_group** | **string** | This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description. | [optional] 
**maximum_eligible_loan_amount** | **double** | This field indicates the maximum eligible amount for loan. | 
**minimum_eligible_loan_amount** | **double** | This field indicates the minimum eligible amount for loan. | [optional] 
**bt_disbursement_options** | [**\Swagger\Client\Model\BtDisbursementOptions[]**](BtDisbursementOptions.md) |  | 
**payment_pans** | [**\Swagger\Client\Model\PaymentPans[]**](PaymentPans.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

