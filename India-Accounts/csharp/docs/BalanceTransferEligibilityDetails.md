# IO.Swagger.Model.BalanceTransferEligibilityDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account id  in encrypted format. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer. | 
**BtSupportedAccountGroup** | **string** | This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description. | [optional] 
**MaximumEligibleLoanAmount** | **double?** | This field indicates the maximum eligible amount for loan. | 
**MinimumEligibleLoanAmount** | **double?** | This field indicates the minimum eligible amount for loan. | [optional] 
**BtDisbursementOptions** | [**List&lt;BtDisbursementOptions&gt;**](BtDisbursementOptions.md) |  | 
**PaymentPans** | [**List&lt;PaymentPans&gt;**](PaymentPans.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

