<?php
/**
 * TemporaryCreditLimitIncrease
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
 * TemporaryCreditLimitIncrease Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class TemporaryCreditLimitIncrease implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'TemporaryCreditLimitIncrease';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'card_id' => 'string',
'credit_limit_increase_end_date' => '\DateTime',
'reason_code' => 'string',
'credit_limit_increase_start_date' => '\DateTime',
'requested_credit_limit_amount' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'card_id' => null,
'credit_limit_increase_end_date' => 'date',
'reason_code' => null,
'credit_limit_increase_start_date' => 'date',
'requested_credit_limit_amount' => 'double'    ];

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
        'card_id' => 'cardId',
'credit_limit_increase_end_date' => 'creditLimitIncreaseEndDate',
'reason_code' => 'reasonCode',
'credit_limit_increase_start_date' => 'creditLimitIncreaseStartDate',
'requested_credit_limit_amount' => 'requestedCreditLimitAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'card_id' => 'setCardId',
'credit_limit_increase_end_date' => 'setCreditLimitIncreaseEndDate',
'reason_code' => 'setReasonCode',
'credit_limit_increase_start_date' => 'setCreditLimitIncreaseStartDate',
'requested_credit_limit_amount' => 'setRequestedCreditLimitAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'card_id' => 'getCardId',
'credit_limit_increase_end_date' => 'getCreditLimitIncreaseEndDate',
'reason_code' => 'getReasonCode',
'credit_limit_increase_start_date' => 'getCreditLimitIncreaseStartDate',
'requested_credit_limit_amount' => 'getRequestedCreditLimitAmount'    ];

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
        $this->container['card_id'] = isset($data['card_id']) ? $data['card_id'] : null;
        $this->container['credit_limit_increase_end_date'] = isset($data['credit_limit_increase_end_date']) ? $data['credit_limit_increase_end_date'] : null;
        $this->container['reason_code'] = isset($data['reason_code']) ? $data['reason_code'] : null;
        $this->container['credit_limit_increase_start_date'] = isset($data['credit_limit_increase_start_date']) ? $data['credit_limit_increase_start_date'] : null;
        $this->container['requested_credit_limit_amount'] = isset($data['requested_credit_limit_amount']) ? $data['requested_credit_limit_amount'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['card_id'] === null) {
            $invalidProperties[] = "'card_id' can't be null";
        }
        if ($this->container['credit_limit_increase_end_date'] === null) {
            $invalidProperties[] = "'credit_limit_increase_end_date' can't be null";
        }
        if ($this->container['reason_code'] === null) {
            $invalidProperties[] = "'reason_code' can't be null";
        }
        if ($this->container['credit_limit_increase_start_date'] === null) {
            $invalidProperties[] = "'credit_limit_increase_start_date' can't be null";
        }
        if ($this->container['requested_credit_limit_amount'] === null) {
            $invalidProperties[] = "'requested_credit_limit_amount' can't be null";
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
     * Gets card_id
     *
     * @return string
     */
    public function getCardId()
    {
        return $this->container['card_id'];
    }

    /**
     * Sets card_id
     *
     * @param string $card_id The card identifier in encrypted format.
     *
     * @return $this
     */
    public function setCardId($card_id)
    {
        $this->container['card_id'] = $card_id;

        return $this;
    }

    /**
     * Gets credit_limit_increase_end_date
     *
     * @return \DateTime
     */
    public function getCreditLimitIncreaseEndDate()
    {
        return $this->container['credit_limit_increase_end_date'];
    }

    /**
     * Sets credit_limit_increase_end_date
     *
     * @param \DateTime $credit_limit_increase_end_date Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD.
     *
     * @return $this
     */
    public function setCreditLimitIncreaseEndDate($credit_limit_increase_end_date)
    {
        $this->container['credit_limit_increase_end_date'] = $credit_limit_increase_end_date;

        return $this;
    }

    /**
     * Gets reason_code
     *
     * @return string
     */
    public function getReasonCode()
    {
        return $this->container['reason_code'];
    }

    /**
     * Sets reason_code
     *
     * @param string $reason_code Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setReasonCode($reason_code)
    {
        $this->container['reason_code'] = $reason_code;

        return $this;
    }

    /**
     * Gets credit_limit_increase_start_date
     *
     * @return \DateTime
     */
    public function getCreditLimitIncreaseStartDate()
    {
        return $this->container['credit_limit_increase_start_date'];
    }

    /**
     * Sets credit_limit_increase_start_date
     *
     * @param \DateTime $credit_limit_increase_start_date Credit limit increase start date in ISO 8601 date format YYYY-MM-DD.
     *
     * @return $this
     */
    public function setCreditLimitIncreaseStartDate($credit_limit_increase_start_date)
    {
        $this->container['credit_limit_increase_start_date'] = $credit_limit_increase_start_date;

        return $this;
    }

    /**
     * Gets requested_credit_limit_amount
     *
     * @return double
     */
    public function getRequestedCreditLimitAmount()
    {
        return $this->container['requested_credit_limit_amount'];
    }

    /**
     * Sets requested_credit_limit_amount
     *
     * @param double $requested_credit_limit_amount Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer
     *
     * @return $this
     */
    public function setRequestedCreditLimitAmount($requested_credit_limit_amount)
    {
        $this->container['requested_credit_limit_amount'] = $requested_credit_limit_amount;

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
