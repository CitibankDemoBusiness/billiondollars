<?php
/**
 * HistoryAndIntradayTransactionRecords
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
 * HistoryAndIntradayTransactionRecords Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class HistoryAndIntradayTransactionRecords implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'HistoryAndIntradayTransactionRecords';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'transaction_date' => '\DateTime',
'merchant_name' => 'string',
'merchant_location' => 'string',
'transaction_status' => 'string',
'reason_description' => 'string',
'transaction_amount' => 'double',
'transaction_currency_code' => 'string',
'billed_amount' => 'double',
'billed_currency_code' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'transaction_date' => 'date',
'merchant_name' => null,
'merchant_location' => null,
'transaction_status' => null,
'reason_description' => null,
'transaction_amount' => 'double',
'transaction_currency_code' => null,
'billed_amount' => 'double',
'billed_currency_code' => null    ];

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
        'transaction_date' => 'transactionDate',
'merchant_name' => 'merchantName',
'merchant_location' => 'merchantLocation',
'transaction_status' => 'transactionStatus',
'reason_description' => 'reasonDescription',
'transaction_amount' => 'transactionAmount',
'transaction_currency_code' => 'transactionCurrencyCode',
'billed_amount' => 'billedAmount',
'billed_currency_code' => 'billedCurrencyCode'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'transaction_date' => 'setTransactionDate',
'merchant_name' => 'setMerchantName',
'merchant_location' => 'setMerchantLocation',
'transaction_status' => 'setTransactionStatus',
'reason_description' => 'setReasonDescription',
'transaction_amount' => 'setTransactionAmount',
'transaction_currency_code' => 'setTransactionCurrencyCode',
'billed_amount' => 'setBilledAmount',
'billed_currency_code' => 'setBilledCurrencyCode'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'transaction_date' => 'getTransactionDate',
'merchant_name' => 'getMerchantName',
'merchant_location' => 'getMerchantLocation',
'transaction_status' => 'getTransactionStatus',
'reason_description' => 'getReasonDescription',
'transaction_amount' => 'getTransactionAmount',
'transaction_currency_code' => 'getTransactionCurrencyCode',
'billed_amount' => 'getBilledAmount',
'billed_currency_code' => 'getBilledCurrencyCode'    ];

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
        $this->container['transaction_date'] = isset($data['transaction_date']) ? $data['transaction_date'] : null;
        $this->container['merchant_name'] = isset($data['merchant_name']) ? $data['merchant_name'] : null;
        $this->container['merchant_location'] = isset($data['merchant_location']) ? $data['merchant_location'] : null;
        $this->container['transaction_status'] = isset($data['transaction_status']) ? $data['transaction_status'] : null;
        $this->container['reason_description'] = isset($data['reason_description']) ? $data['reason_description'] : null;
        $this->container['transaction_amount'] = isset($data['transaction_amount']) ? $data['transaction_amount'] : null;
        $this->container['transaction_currency_code'] = isset($data['transaction_currency_code']) ? $data['transaction_currency_code'] : null;
        $this->container['billed_amount'] = isset($data['billed_amount']) ? $data['billed_amount'] : null;
        $this->container['billed_currency_code'] = isset($data['billed_currency_code']) ? $data['billed_currency_code'] : null;
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
     * Gets transaction_date
     *
     * @return \DateTime
     */
    public function getTransactionDate()
    {
        return $this->container['transaction_date'];
    }

    /**
     * Sets transaction_date
     *
     * @param \DateTime $transaction_date Transaction date in ISO 8601  format YYYY-MM-DD
     *
     * @return $this
     */
    public function setTransactionDate($transaction_date)
    {
        $this->container['transaction_date'] = $transaction_date;

        return $this;
    }

    /**
     * Gets merchant_name
     *
     * @return string
     */
    public function getMerchantName()
    {
        return $this->container['merchant_name'];
    }

    /**
     * Sets merchant_name
     *
     * @param string $merchant_name This field indicates the merchant Name
     *
     * @return $this
     */
    public function setMerchantName($merchant_name)
    {
        $this->container['merchant_name'] = $merchant_name;

        return $this;
    }

    /**
     * Gets merchant_location
     *
     * @return string
     */
    public function getMerchantLocation()
    {
        return $this->container['merchant_location'];
    }

    /**
     * Sets merchant_location
     *
     * @param string $merchant_location This filed indicates the Merchant Address
     *
     * @return $this
     */
    public function setMerchantLocation($merchant_location)
    {
        $this->container['merchant_location'] = $merchant_location;

        return $this;
    }

    /**
     * Gets transaction_status
     *
     * @return string
     */
    public function getTransactionStatus()
    {
        return $this->container['transaction_status'];
    }

    /**
     * Sets transaction_status
     *
     * @param string $transaction_status This field provides the status of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions.
     *
     * @return $this
     */
    public function setTransactionStatus($transaction_status)
    {
        $this->container['transaction_status'] = $transaction_status;

        return $this;
    }

    /**
     * Gets reason_description
     *
     * @return string
     */
    public function getReasonDescription()
    {
        return $this->container['reason_description'];
    }

    /**
     * Sets reason_description
     *
     * @param string $reason_description Decline Description- for declined transaction
     *
     * @return $this
     */
    public function setReasonDescription($reason_description)
    {
        $this->container['reason_description'] = $reason_description;

        return $this;
    }

    /**
     * Gets transaction_amount
     *
     * @return double
     */
    public function getTransactionAmount()
    {
        return $this->container['transaction_amount'];
    }

    /**
     * Sets transaction_amount
     *
     * @param double $transaction_amount Amount of funds the cardholder requested in source location of the transaction.
     *
     * @return $this
     */
    public function setTransactionAmount($transaction_amount)
    {
        $this->container['transaction_amount'] = $transaction_amount;

        return $this;
    }

    /**
     * Gets transaction_currency_code
     *
     * @return string
     */
    public function getTransactionCurrencyCode()
    {
        return $this->container['transaction_currency_code'];
    }

    /**
     * Sets transaction_currency_code
     *
     * @param string $transaction_currency_code transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions
     *
     * @return $this
     */
    public function setTransactionCurrencyCode($transaction_currency_code)
    {
        $this->container['transaction_currency_code'] = $transaction_currency_code;

        return $this;
    }

    /**
     * Gets billed_amount
     *
     * @return double
     */
    public function getBilledAmount()
    {
        return $this->container['billed_amount'];
    }

    /**
     * Sets billed_amount
     *
     * @param double $billed_amount Amount billed to the cardholder in the cardholder account currency
     *
     * @return $this
     */
    public function setBilledAmount($billed_amount)
    {
        $this->container['billed_amount'] = $billed_amount;

        return $this;
    }

    /**
     * Gets billed_currency_code
     *
     * @return string
     */
    public function getBilledCurrencyCode()
    {
        return $this->container['billed_currency_code'];
    }

    /**
     * Sets billed_currency_code
     *
     * @param string $billed_currency_code billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions
     *
     * @return $this
     */
    public function setBilledCurrencyCode($billed_currency_code)
    {
        $this->container['billed_currency_code'] = $billed_currency_code;

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