<?php
/**
 * RetrieveCreditChargeCardCorporateCardsCashLimitResponse
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
 * RetrieveCreditChargeCardCorporateCardsCashLimitResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class RetrieveCreditChargeCardCorporateCardsCashLimitResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'RetrieveCreditChargeCardCorporateCardsCashLimitResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'maximum_daily_cash_limit_amount' => 'int',
'maximum_weekly_cash_limit_amount' => 'int',
'maximum_monthly_cash_limit_amount' => 'float',
'maximum_individual_txn_limit_amount' => 'int'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'maximum_daily_cash_limit_amount' => 'int64',
'maximum_weekly_cash_limit_amount' => 'int64',
'maximum_monthly_cash_limit_amount' => 'int64',
'maximum_individual_txn_limit_amount' => 'int64'    ];

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
        'maximum_daily_cash_limit_amount' => 'maximumDailyCashLimitAmount',
'maximum_weekly_cash_limit_amount' => 'maximumWeeklyCashLimitAmount',
'maximum_monthly_cash_limit_amount' => 'maximumMonthlyCashLimitAmount',
'maximum_individual_txn_limit_amount' => 'maximumIndividualTxnLimitAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'maximum_daily_cash_limit_amount' => 'setMaximumDailyCashLimitAmount',
'maximum_weekly_cash_limit_amount' => 'setMaximumWeeklyCashLimitAmount',
'maximum_monthly_cash_limit_amount' => 'setMaximumMonthlyCashLimitAmount',
'maximum_individual_txn_limit_amount' => 'setMaximumIndividualTxnLimitAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'maximum_daily_cash_limit_amount' => 'getMaximumDailyCashLimitAmount',
'maximum_weekly_cash_limit_amount' => 'getMaximumWeeklyCashLimitAmount',
'maximum_monthly_cash_limit_amount' => 'getMaximumMonthlyCashLimitAmount',
'maximum_individual_txn_limit_amount' => 'getMaximumIndividualTxnLimitAmount'    ];

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
        $this->container['maximum_daily_cash_limit_amount'] = isset($data['maximum_daily_cash_limit_amount']) ? $data['maximum_daily_cash_limit_amount'] : null;
        $this->container['maximum_weekly_cash_limit_amount'] = isset($data['maximum_weekly_cash_limit_amount']) ? $data['maximum_weekly_cash_limit_amount'] : null;
        $this->container['maximum_monthly_cash_limit_amount'] = isset($data['maximum_monthly_cash_limit_amount']) ? $data['maximum_monthly_cash_limit_amount'] : null;
        $this->container['maximum_individual_txn_limit_amount'] = isset($data['maximum_individual_txn_limit_amount']) ? $data['maximum_individual_txn_limit_amount'] : null;
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
     * Gets maximum_daily_cash_limit_amount
     *
     * @return int
     */
    public function getMaximumDailyCashLimitAmount()
    {
        return $this->container['maximum_daily_cash_limit_amount'];
    }

    /**
     * Sets maximum_daily_cash_limit_amount
     *
     * @param int $maximum_daily_cash_limit_amount This is the max daily Cash limit Amount allowed for the cardholder
     *
     * @return $this
     */
    public function setMaximumDailyCashLimitAmount($maximum_daily_cash_limit_amount)
    {
        $this->container['maximum_daily_cash_limit_amount'] = $maximum_daily_cash_limit_amount;

        return $this;
    }

    /**
     * Gets maximum_weekly_cash_limit_amount
     *
     * @return int
     */
    public function getMaximumWeeklyCashLimitAmount()
    {
        return $this->container['maximum_weekly_cash_limit_amount'];
    }

    /**
     * Sets maximum_weekly_cash_limit_amount
     *
     * @param int $maximum_weekly_cash_limit_amount This is the max weekly Cash limit Amount allowed for the cardholder
     *
     * @return $this
     */
    public function setMaximumWeeklyCashLimitAmount($maximum_weekly_cash_limit_amount)
    {
        $this->container['maximum_weekly_cash_limit_amount'] = $maximum_weekly_cash_limit_amount;

        return $this;
    }

    /**
     * Gets maximum_monthly_cash_limit_amount
     *
     * @return float
     */
    public function getMaximumMonthlyCashLimitAmount()
    {
        return $this->container['maximum_monthly_cash_limit_amount'];
    }

    /**
     * Sets maximum_monthly_cash_limit_amount
     *
     * @param float $maximum_monthly_cash_limit_amount This is the max monthly Cash limit Amount allowed for the cardholder
     *
     * @return $this
     */
    public function setMaximumMonthlyCashLimitAmount($maximum_monthly_cash_limit_amount)
    {
        $this->container['maximum_monthly_cash_limit_amount'] = $maximum_monthly_cash_limit_amount;

        return $this;
    }

    /**
     * Gets maximum_individual_txn_limit_amount
     *
     * @return int
     */
    public function getMaximumIndividualTxnLimitAmount()
    {
        return $this->container['maximum_individual_txn_limit_amount'];
    }

    /**
     * Sets maximum_individual_txn_limit_amount
     *
     * @param int $maximum_individual_txn_limit_amount This is the max Cash Amount allowed for the cardholder per transaction
     *
     * @return $this
     */
    public function setMaximumIndividualTxnLimitAmount($maximum_individual_txn_limit_amount)
    {
        $this->container['maximum_individual_txn_limit_amount'] = $maximum_individual_txn_limit_amount;

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
