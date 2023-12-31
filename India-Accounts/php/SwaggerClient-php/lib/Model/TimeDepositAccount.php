<?php
/**
 * TimeDepositAccount
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.29
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * TimeDepositAccount Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class TimeDepositAccount implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'TimeDepositAccount';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'product_name' => 'string',
'product_code' => 'string',
'display_account_number' => 'string',
'original_principal_amount' => 'double',
'currency_code' => 'string',
'interest_rate' => 'double',
'opening_date' => '\DateTime',
'maturity_date' => '\DateTime',
'next_interest_payment_date' => '\DateTime',
'interest_amount_due' => 'double',
'renewal_instructions' => 'string',
'tenor_term' => 'int',
'tenor_period' => 'string',
'base_currency_maturity_amount' => 'double',
'maturity_interest_amount' => 'double',
'last_interest_payment_amount' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'product_name' => null,
'product_code' => null,
'display_account_number' => null,
'original_principal_amount' => 'double',
'currency_code' => null,
'interest_rate' => 'double',
'opening_date' => 'date',
'maturity_date' => 'date',
'next_interest_payment_date' => 'date',
'interest_amount_due' => 'double',
'renewal_instructions' => null,
'tenor_term' => null,
'tenor_period' => null,
'base_currency_maturity_amount' => 'double',
'maturity_interest_amount' => 'double',
'last_interest_payment_amount' => 'double'    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'product_name' => 'productName',
'product_code' => 'productCode',
'display_account_number' => 'displayAccountNumber',
'original_principal_amount' => 'originalPrincipalAmount',
'currency_code' => 'currencyCode',
'interest_rate' => 'interestRate',
'opening_date' => 'openingDate',
'maturity_date' => 'maturityDate',
'next_interest_payment_date' => 'nextInterestPaymentDate',
'interest_amount_due' => 'interestAmountDue',
'renewal_instructions' => 'renewalInstructions',
'tenor_term' => 'tenorTerm',
'tenor_period' => 'tenorPeriod',
'base_currency_maturity_amount' => 'baseCurrencyMaturityAmount',
'maturity_interest_amount' => 'maturityInterestAmount',
'last_interest_payment_amount' => 'lastInterestPaymentAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'product_name' => 'setProductName',
'product_code' => 'setProductCode',
'display_account_number' => 'setDisplayAccountNumber',
'original_principal_amount' => 'setOriginalPrincipalAmount',
'currency_code' => 'setCurrencyCode',
'interest_rate' => 'setInterestRate',
'opening_date' => 'setOpeningDate',
'maturity_date' => 'setMaturityDate',
'next_interest_payment_date' => 'setNextInterestPaymentDate',
'interest_amount_due' => 'setInterestAmountDue',
'renewal_instructions' => 'setRenewalInstructions',
'tenor_term' => 'setTenorTerm',
'tenor_period' => 'setTenorPeriod',
'base_currency_maturity_amount' => 'setBaseCurrencyMaturityAmount',
'maturity_interest_amount' => 'setMaturityInterestAmount',
'last_interest_payment_amount' => 'setLastInterestPaymentAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'product_name' => 'getProductName',
'product_code' => 'getProductCode',
'display_account_number' => 'getDisplayAccountNumber',
'original_principal_amount' => 'getOriginalPrincipalAmount',
'currency_code' => 'getCurrencyCode',
'interest_rate' => 'getInterestRate',
'opening_date' => 'getOpeningDate',
'maturity_date' => 'getMaturityDate',
'next_interest_payment_date' => 'getNextInterestPaymentDate',
'interest_amount_due' => 'getInterestAmountDue',
'renewal_instructions' => 'getRenewalInstructions',
'tenor_term' => 'getTenorTerm',
'tenor_period' => 'getTenorPeriod',
'base_currency_maturity_amount' => 'getBaseCurrencyMaturityAmount',
'maturity_interest_amount' => 'getMaturityInterestAmount',
'last_interest_payment_amount' => 'getLastInterestPaymentAmount'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['product_name'] = isset($data['product_name']) ? $data['product_name'] : null;
        $this->container['product_code'] = isset($data['product_code']) ? $data['product_code'] : null;
        $this->container['display_account_number'] = isset($data['display_account_number']) ? $data['display_account_number'] : null;
        $this->container['original_principal_amount'] = isset($data['original_principal_amount']) ? $data['original_principal_amount'] : null;
        $this->container['currency_code'] = isset($data['currency_code']) ? $data['currency_code'] : null;
        $this->container['interest_rate'] = isset($data['interest_rate']) ? $data['interest_rate'] : null;
        $this->container['opening_date'] = isset($data['opening_date']) ? $data['opening_date'] : null;
        $this->container['maturity_date'] = isset($data['maturity_date']) ? $data['maturity_date'] : null;
        $this->container['next_interest_payment_date'] = isset($data['next_interest_payment_date']) ? $data['next_interest_payment_date'] : null;
        $this->container['interest_amount_due'] = isset($data['interest_amount_due']) ? $data['interest_amount_due'] : null;
        $this->container['renewal_instructions'] = isset($data['renewal_instructions']) ? $data['renewal_instructions'] : null;
        $this->container['tenor_term'] = isset($data['tenor_term']) ? $data['tenor_term'] : null;
        $this->container['tenor_period'] = isset($data['tenor_period']) ? $data['tenor_period'] : null;
        $this->container['base_currency_maturity_amount'] = isset($data['base_currency_maturity_amount']) ? $data['base_currency_maturity_amount'] : null;
        $this->container['maturity_interest_amount'] = isset($data['maturity_interest_amount']) ? $data['maturity_interest_amount'] : null;
        $this->container['last_interest_payment_amount'] = isset($data['last_interest_payment_amount']) ? $data['last_interest_payment_amount'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['display_account_number'] === null) {
            $invalidProperties[] = "'display_account_number' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets product_name
     *
     * @return string
     */
    public function getProductName()
    {
        return $this->container['product_name'];
    }

    /**
     * Sets product_name
     *
     * @param string $product_name The name of the product
     *
     * @return $this
     */
    public function setProductName($product_name)
    {
        $this->container['product_name'] = $product_name;

        return $this;
    }

    /**
     * Gets product_code
     *
     * @return string
     */
    public function getProductCode()
    {
        return $this->container['product_code'];
    }

    /**
     * Sets product_code
     *
     * @param string $product_code A unique code that identifies the product
     *
     * @return $this
     */
    public function setProductCode($product_code)
    {
        $this->container['product_code'] = $product_code;

        return $this;
    }

    /**
     * Gets display_account_number
     *
     * @return string
     */
    public function getDisplayAccountNumber()
    {
        return $this->container['display_account_number'];
    }

    /**
     * Sets display_account_number
     *
     * @param string $display_account_number A masked account number that can be displayed to the customer
     *
     * @return $this
     */
    public function setDisplayAccountNumber($display_account_number)
    {
        $this->container['display_account_number'] = $display_account_number;

        return $this;
    }

    /**
     * Gets original_principal_amount
     *
     * @return double
     */
    public function getOriginalPrincipalAmount()
    {
        return $this->container['original_principal_amount'];
    }

    /**
     * Sets original_principal_amount
     *
     * @param double $original_principal_amount The original principal amount when account opened.
     *
     * @return $this
     */
    public function setOriginalPrincipalAmount($original_principal_amount)
    {
        $this->container['original_principal_amount'] = $original_principal_amount;

        return $this;
    }

    /**
     * Gets currency_code
     *
     * @return string
     */
    public function getCurrencyCode()
    {
        return $this->container['currency_code'];
    }

    /**
     * Sets currency_code
     *
     * @param string $currency_code The currency code of the account in ISO 4217 format
     *
     * @return $this
     */
    public function setCurrencyCode($currency_code)
    {
        $this->container['currency_code'] = $currency_code;

        return $this;
    }

    /**
     * Gets interest_rate
     *
     * @return double
     */
    public function getInterestRate()
    {
        return $this->container['interest_rate'];
    }

    /**
     * Sets interest_rate
     *
     * @param double $interest_rate The rate of interest applicable for the time deposit
     *
     * @return $this
     */
    public function setInterestRate($interest_rate)
    {
        $this->container['interest_rate'] = $interest_rate;

        return $this;
    }

    /**
     * Gets opening_date
     *
     * @return \DateTime
     */
    public function getOpeningDate()
    {
        return $this->container['opening_date'];
    }

    /**
     * Sets opening_date
     *
     * @param \DateTime $opening_date The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD
     *
     * @return $this
     */
    public function setOpeningDate($opening_date)
    {
        $this->container['opening_date'] = $opening_date;

        return $this;
    }

    /**
     * Gets maturity_date
     *
     * @return \DateTime
     */
    public function getMaturityDate()
    {
        return $this->container['maturity_date'];
    }

    /**
     * Sets maturity_date
     *
     * @param \DateTime $maturity_date The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD
     *
     * @return $this
     */
    public function setMaturityDate($maturity_date)
    {
        $this->container['maturity_date'] = $maturity_date;

        return $this;
    }

    /**
     * Gets next_interest_payment_date
     *
     * @return \DateTime
     */
    public function getNextInterestPaymentDate()
    {
        return $this->container['next_interest_payment_date'];
    }

    /**
     * Sets next_interest_payment_date
     *
     * @param \DateTime $next_interest_payment_date The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD
     *
     * @return $this
     */
    public function setNextInterestPaymentDate($next_interest_payment_date)
    {
        $this->container['next_interest_payment_date'] = $next_interest_payment_date;

        return $this;
    }

    /**
     * Gets interest_amount_due
     *
     * @return double
     */
    public function getInterestAmountDue()
    {
        return $this->container['interest_amount_due'];
    }

    /**
     * Sets interest_amount_due
     *
     * @param double $interest_amount_due The accrued interest amount which has not yet been paid by Citibank
     *
     * @return $this
     */
    public function setInterestAmountDue($interest_amount_due)
    {
        $this->container['interest_amount_due'] = $interest_amount_due;

        return $this;
    }

    /**
     * Gets renewal_instructions
     *
     * @return string
     */
    public function getRenewalInstructions()
    {
        return $this->container['renewal_instructions'];
    }

    /**
     * Sets renewal_instructions
     *
     * @param string $renewal_instructions The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setRenewalInstructions($renewal_instructions)
    {
        $this->container['renewal_instructions'] = $renewal_instructions;

        return $this;
    }

    /**
     * Gets tenor_term
     *
     * @return int
     */
    public function getTenorTerm()
    {
        return $this->container['tenor_term'];
    }

    /**
     * Sets tenor_term
     *
     * @param int $tenor_term The tenor term for the deposit, expressed as a whole number
     *
     * @return $this
     */
    public function setTenorTerm($tenor_term)
    {
        $this->container['tenor_term'] = $tenor_term;

        return $this;
    }

    /**
     * Gets tenor_period
     *
     * @return string
     */
    public function getTenorPeriod()
    {
        return $this->container['tenor_period'];
    }

    /**
     * Sets tenor_period
     *
     * @param string $tenor_period The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setTenorPeriod($tenor_period)
    {
        $this->container['tenor_period'] = $tenor_period;

        return $this;
    }

    /**
     * Gets base_currency_maturity_amount
     *
     * @return double
     */
    public function getBaseCurrencyMaturityAmount()
    {
        return $this->container['base_currency_maturity_amount'];
    }

    /**
     * Sets base_currency_maturity_amount
     *
     * @param double $base_currency_maturity_amount The investment amount and accrued interest in base currency
     *
     * @return $this
     */
    public function setBaseCurrencyMaturityAmount($base_currency_maturity_amount)
    {
        $this->container['base_currency_maturity_amount'] = $base_currency_maturity_amount;

        return $this;
    }

    /**
     * Gets maturity_interest_amount
     *
     * @return double
     */
    public function getMaturityInterestAmount()
    {
        return $this->container['maturity_interest_amount'];
    }

    /**
     * Sets maturity_interest_amount
     *
     * @param double $maturity_interest_amount The accrued interest in base currency.
     *
     * @return $this
     */
    public function setMaturityInterestAmount($maturity_interest_amount)
    {
        $this->container['maturity_interest_amount'] = $maturity_interest_amount;

        return $this;
    }

    /**
     * Gets last_interest_payment_amount
     *
     * @return double
     */
    public function getLastInterestPaymentAmount()
    {
        return $this->container['last_interest_payment_amount'];
    }

    /**
     * Sets last_interest_payment_amount
     *
     * @param double $last_interest_payment_amount Last interest amount for the time deposit account
     *
     * @return $this
     */
    public function setLastInterestPaymentAmount($last_interest_payment_amount)
    {
        $this->container['last_interest_payment_amount'] = $last_interest_payment_amount;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
