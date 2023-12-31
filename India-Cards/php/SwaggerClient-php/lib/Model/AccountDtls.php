<?php
/**
 * AccountDtls
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
 * AccountDtls Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class AccountDtls implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'AccountDtls';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'display_account_number' => 'string',
'account_id' => 'string',
'currency_code' => 'string',
'enrollment_status_flag' => 'bool',
'primary_account_flag' => 'bool',
'account_balance' => 'double',
'linked_account_details' => '\Swagger\Client\Model\LinkedAccountDetails[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'display_account_number' => null,
'account_id' => null,
'currency_code' => null,
'enrollment_status_flag' => null,
'primary_account_flag' => null,
'account_balance' => 'double',
'linked_account_details' => null    ];

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
        'display_account_number' => 'displayAccountNumber',
'account_id' => 'accountId',
'currency_code' => 'currencyCode',
'enrollment_status_flag' => 'enrollmentStatusFlag',
'primary_account_flag' => 'primaryAccountFlag',
'account_balance' => 'accountBalance',
'linked_account_details' => 'linkedAccountDetails'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'display_account_number' => 'setDisplayAccountNumber',
'account_id' => 'setAccountId',
'currency_code' => 'setCurrencyCode',
'enrollment_status_flag' => 'setEnrollmentStatusFlag',
'primary_account_flag' => 'setPrimaryAccountFlag',
'account_balance' => 'setAccountBalance',
'linked_account_details' => 'setLinkedAccountDetails'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'display_account_number' => 'getDisplayAccountNumber',
'account_id' => 'getAccountId',
'currency_code' => 'getCurrencyCode',
'enrollment_status_flag' => 'getEnrollmentStatusFlag',
'primary_account_flag' => 'getPrimaryAccountFlag',
'account_balance' => 'getAccountBalance',
'linked_account_details' => 'getLinkedAccountDetails'    ];

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
        $this->container['display_account_number'] = isset($data['display_account_number']) ? $data['display_account_number'] : null;
        $this->container['account_id'] = isset($data['account_id']) ? $data['account_id'] : null;
        $this->container['currency_code'] = isset($data['currency_code']) ? $data['currency_code'] : null;
        $this->container['enrollment_status_flag'] = isset($data['enrollment_status_flag']) ? $data['enrollment_status_flag'] : null;
        $this->container['primary_account_flag'] = isset($data['primary_account_flag']) ? $data['primary_account_flag'] : null;
        $this->container['account_balance'] = isset($data['account_balance']) ? $data['account_balance'] : null;
        $this->container['linked_account_details'] = isset($data['linked_account_details']) ? $data['linked_account_details'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

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
     * @param string $display_account_number Currency code which has to be added to Multi Currency Account in ISO 4217 format.
     *
     * @return $this
     */
    public function setDisplayAccountNumber($display_account_number)
    {
        $this->container['display_account_number'] = $display_account_number;

        return $this;
    }

    /**
     * Gets account_id
     *
     * @return string
     */
    public function getAccountId()
    {
        return $this->container['account_id'];
    }

    /**
     * Sets account_id
     *
     * @param string $account_id The customer account identifier in encrypted format
     *
     * @return $this
     */
    public function setAccountId($account_id)
    {
        $this->container['account_id'] = $account_id;

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
     * @param string $currency_code Currency code which has to be added to Multi Currency Account in ISO 4217 format.
     *
     * @return $this
     */
    public function setCurrencyCode($currency_code)
    {
        $this->container['currency_code'] = $currency_code;

        return $this;
    }

    /**
     * Gets enrollment_status_flag
     *
     * @return bool
     */
    public function getEnrollmentStatusFlag()
    {
        return $this->container['enrollment_status_flag'];
    }

    /**
     * Sets enrollment_status_flag
     *
     * @param bool $enrollment_status_flag This field is to indicate if the  account is enrolled for Multi Currency Account or not.
     *
     * @return $this
     */
    public function setEnrollmentStatusFlag($enrollment_status_flag)
    {
        $this->container['enrollment_status_flag'] = $enrollment_status_flag;

        return $this;
    }

    /**
     * Gets primary_account_flag
     *
     * @return bool
     */
    public function getPrimaryAccountFlag()
    {
        return $this->container['primary_account_flag'];
    }

    /**
     * Sets primary_account_flag
     *
     * @param bool $primary_account_flag Flag to indicate if account is primary
     *
     * @return $this
     */
    public function setPrimaryAccountFlag($primary_account_flag)
    {
        $this->container['primary_account_flag'] = $primary_account_flag;

        return $this;
    }

    /**
     * Gets account_balance
     *
     * @return double
     */
    public function getAccountBalance()
    {
        return $this->container['account_balance'];
    }

    /**
     * Sets account_balance
     *
     * @param double $account_balance Current Balance of the Account.
     *
     * @return $this
     */
    public function setAccountBalance($account_balance)
    {
        $this->container['account_balance'] = $account_balance;

        return $this;
    }

    /**
     * Gets linked_account_details
     *
     * @return \Swagger\Client\Model\LinkedAccountDetails[]
     */
    public function getLinkedAccountDetails()
    {
        return $this->container['linked_account_details'];
    }

    /**
     * Sets linked_account_details
     *
     * @param \Swagger\Client\Model\LinkedAccountDetails[] $linked_account_details linked_account_details
     *
     * @return $this
     */
    public function setLinkedAccountDetails($linked_account_details)
    {
        $this->container['linked_account_details'] = $linked_account_details;

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
