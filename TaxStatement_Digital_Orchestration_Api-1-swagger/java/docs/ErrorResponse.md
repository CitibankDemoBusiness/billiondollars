# ErrorResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**code** | **String** | Error code | 
**details** | **String** | Verbose explanation of the error |  [optional]
**location** | **String** | The name of the field that resulted in the error |  [optional]
**type** | [**TypeEnum**](#TypeEnum) | error type | 
**moreInfo** | **Object** | URI to documentation of the error |  [optional]

<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
ERROR | &quot;ERROR&quot;
WARN | &quot;WARN&quot;
INVALID | &quot;INVALID&quot;
FATAL | &quot;FATAL&quot;
