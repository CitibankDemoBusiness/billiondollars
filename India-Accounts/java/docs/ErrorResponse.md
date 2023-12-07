# ErrorResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**type** | [**TypeEnum**](#TypeEnum) | Invalid - Request did not confirm to the specification and was unprocessed and rejected. Please fix the value and try again | 
**code** | **String** | Error code which qualifies the error | 
**details** | **String** | Human readable explanation specific to the occurrence of the problem |  [optional]
**location** | **String** | The name of the field that resulted in the error |  [optional]
**moreInfo** | **Object** | URI to human readable documentation of the error |  [optional]

<a name="TypeEnum"></a>
## Enum: TypeEnum
Name | Value
---- | -----
ERROR | &quot;error&quot;
WARN | &quot;warn&quot;
INVALID | &quot;invalid&quot;
FATAL | &quot;fatal&quot;
