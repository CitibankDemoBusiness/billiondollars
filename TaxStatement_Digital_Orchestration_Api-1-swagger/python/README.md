# swagger-client
Account Documents APIs Version 2.0. These APIs will be used by Citi Partners to retrieve tax documents for existing Accounts from various regions. PCF Deployment Reference name --> DM-O-DocumentServices-Statements  </br>Version 2.0.0 Added new Tax statements apis.

This Python package is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- Package version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.python.PythonClientCodegen

## Requirements.

Python 2.7 and 3.4+

## Installation & Usage
### pip install

If the python package is hosted on Github, you can install directly from Github

```sh
pip install git+https://github.com/GIT_USER_ID/GIT_REPO_ID.git
```
(you may need to run `pip` with root permission: `sudo pip install git+https://github.com/GIT_USER_ID/GIT_REPO_ID.git`)

Then import the package:
```python
import swagger_client 
```

### Setuptools

Install via [Setuptools](http://pypi.python.org/pypi/setuptools).

```sh
python setup.py install --user
```
(or `sudo python setup.py install` to install the package for all users)

Then import the package:
```python
import swagger_client
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaxStatementsApi(swagger_client.ApiClient(configuration))
authorization = 'authorization_example' # str | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
accept = 'application/json' # str | Content types that are acceptable for the response. Currently we support application/json (default to application/json)
content_type = 'content_type_example' # str | Content-Type of the request
uuid = '4468adf1-adfe-4f85-a2c1-f29beaa1f6ee' # str | 128 bit random UUID generated uniquely for every request. (default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee)
client_id = '1c5f30d9-043c-49ff-b9c4-255a923278b2' # str | The client ID received during customer onboarding. (default to 1c5f30d9-043c-49ff-b9c4-255a923278b2)
taxstatement_id = 'taxstatement_id_example' # str | Unique id that maps to the specific tax statement to be downloaded.
country_code = 'country_code_example' # str | Two character ISO format country code. (optional)

try:
    # OB Return the masked tax statement for the given tax statement id
    api_response = api_instance.get_tax_statement(authorization, accept, content_type, uuid, client_id, taxstatement_id, country_code=country_code)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaxStatementsApi->get_tax_statement: %s\n" % e)

# create an instance of the API class
api_instance = swagger_client.TaxStatementsApi(swagger_client.ApiClient(configuration))
authorization = 'authorization_example' # str | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
accept = 'application/json' # str | Content types that are acceptable for the response. Currently we support application/json (default to application/json)
uuid = '4468adf1-adfe-4f85-a2c1-f29beaa1f6ee' # str | 128 bit random UUID generated uniquely for every request (default to 4468adf1-adfe-4f85-a2c1-f29beaa1f6ee)
content_type = 'content_type_example' # str | Content-Type of the request
client_id = '1c5f30d9-043c-49ff-b9c4-255a923278b2' # str | The client ID received during application registration in the developer portal. (default to 1c5f30d9-043c-49ff-b9c4-255a923278b2)
country_code = 'country_code_example' # str | Two character ISO format country code. (optional)

try:
    # OB Returns list of masked tax statements
    api_response = api_instance.get_tax_statements(authorization, accept, uuid, content_type, client_id, country_code=country_code)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaxStatementsApi->get_tax_statements: %s\n" % e)
```

## Documentation for API Endpoints

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*TaxStatementsApi* | [**get_tax_statement**](docs/TaxStatementsApi.md#get_tax_statement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
*TaxStatementsApi* | [**get_tax_statements**](docs/TaxStatementsApi.md#get_tax_statements) | **GET** /taxStatements | OB Returns list of masked tax statements

## Documentation For Models

 - [Document](docs/Document.md)
 - [DocumentDetails](docs/DocumentDetails.md)
 - [Documents](docs/Documents.md)
 - [ErrorResponse](docs/ErrorResponse.md)

## Documentation For Authorization

 All endpoints do not require authorization.


## Author


