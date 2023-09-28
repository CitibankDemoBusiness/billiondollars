# SwaggerClient-php
Account Documents APIs Version 2.0. These APIs will be used by Citi Partners to retrieve tax documents for existing Accounts from various regions. PCF Deployment Reference name --> DM-O-DocumentServices-Statements  </br>Version 2.0.0 Added new Tax statements apis.

This PHP package is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.php.PhpClientCodegen

## Requirements

PHP 5.5 and later

## Installation & Usage
### Composer

To install the bindings via [Composer](http://getcomposer.org/), add the following to `composer.json`:

```
{
  "repositories": [
    {
      "type": "git",
      "url": "http://github.com/GIT_USER_ID/GIT_REPO_ID.git"
    }
  ],
  "require": {
    "GIT_USER_ID/GIT_REPO_ID": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
    require_once('/path/to/SwaggerClient-php/vendor/autoload.php');
```

## Tests

To run the unit tests:

```
composer install
./vendor/bin/phpunit
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\TaxStatementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
$accept = "application/json"; // string | Content types that are acceptable for the response. Currently we support application/json
$content_type = "content_type_example"; // string | Content-Type of the request
$uuid = "4468adf1-adfe-4f85-a2c1-f29beaa1f6ee"; // string | 128 bit random UUID generated uniquely for every request.
$client_id = "1c5f30d9-043c-49ff-b9c4-255a923278b2"; // string | The client ID received during customer onboarding.
$taxstatement_id = "taxstatement_id_example"; // string | Unique id that maps to the specific tax statement to be downloaded.
$country_code = "country_code_example"; // string | Two character ISO format country code.

try {
    $result = $apiInstance->getTaxStatement($authorization, $accept, $content_type, $uuid, $client_id, $taxstatement_id, $country_code);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TaxStatementsApi->getTaxStatement: ', $e->getMessage(), PHP_EOL;
}

$apiInstance = new Swagger\Client\Api\TaxStatementsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The authorization token received in earlier API call. This will contain the access token and partner identity. This header is populated only for third-party partners.
$accept = "application/json"; // string | Content types that are acceptable for the response. Currently we support application/json
$uuid = "4468adf1-adfe-4f85-a2c1-f29beaa1f6ee"; // string | 128 bit random UUID generated uniquely for every request
$content_type = "content_type_example"; // string | Content-Type of the request
$client_id = "1c5f30d9-043c-49ff-b9c4-255a923278b2"; // string | The client ID received during application registration in the developer portal.
$country_code = "country_code_example"; // string | Two character ISO format country code.

try {
    $result = $apiInstance->getTaxStatements($authorization, $accept, $uuid, $content_type, $client_id, $country_code);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TaxStatementsApi->getTaxStatements: ', $e->getMessage(), PHP_EOL;
}
?>
```

## Documentation for API Endpoints

All URIs are relative to */gcgapi/docmgmt/taxforms/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*TaxStatementsApi* | [**getTaxStatement**](docs/Api/TaxStatementsApi.md#gettaxstatement) | **GET** /taxStatements/{taxstatementId} | OB Return the masked tax statement for the given tax statement id
*TaxStatementsApi* | [**getTaxStatements**](docs/Api/TaxStatementsApi.md#gettaxstatements) | **GET** /taxStatements | OB Returns list of masked tax statements

## Documentation For Models

 - [Document](docs/Model/Document.md)
 - [DocumentDetails](docs/Model/DocumentDetails.md)
 - [Documents](docs/Model/Documents.md)
 - [ErrorResponse](docs/Model/ErrorResponse.md)

## Documentation For Authorization

 All endpoints do not require authorization.


## Author


