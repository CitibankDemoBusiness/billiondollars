<?php
/**
 * LoanScheduleDetails
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
 * LoanScheduleDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class LoanScheduleDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'LoanScheduleDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'payment_cycle_number' => 'string',
'applied_financed_amount' => 'double',
'applied_interest_amount' => 'double',
'applied_credit_usage_fee_amount' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'payment_cycle_number' => null,
'applied_financed_amount' => 'double',
'applied_interest_amount' => 'double',
'applied_credit_usage_fee_amount' => 'double'    ];

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
        'payment_cycle_number' => 'paymentCycleNumber',
'applied_financed_amount' => 'appliedFinancedAmount',
'applied_interest_amount' => 'appliedInterestAmount',
'applied_credit_usage_fee_amount' => 'appliedCreditUsageFeeAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'payment_cycle_number' => 'setPaymentCycleNumber',
'applied_financed_amount' => 'setAppliedFinancedAmount',
'applied_interest_amount' => 'setAppliedInterestAmount',
'applied_credit_usage_fee_amount' => 'setAppliedCreditUsageFeeAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'payment_cycle_number' => 'getPaymentCycleNumber',
'applied_financed_amount' => 'getAppliedFinancedAmount',
'applied_interest_amount' => 'getAppliedInterestAmount',
'applied_credit_usage_fee_amount' => 'getAppliedCreditUsageFeeAmount'    ];

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
        $this->container['payment_cycle_number'] = isset($data['payment_cycle_number']) ? $data['payment_cycle_number'] : null;
        $this->container['applied_financed_amount'] = isset($data['applied_financed_amount']) ? $data['applied_financed_amount'] : null;
        $this->container['applied_interest_amount'] = isset($data['applied_interest_amount']) ? $data['applied_interest_amount'] : null;
        $this->container['applied_credit_usage_fee_amount'] = isset($data['applied_credit_usage_fee_amount']) ? $data['applied_credit_usage_fee_amount'] : null;
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
     * Gets payment_cycle_number
     *
     * @return string
     */
    public function getPaymentCycleNumber()
    {
        return $this->container['payment_cycle_number'];
    }

    /**
     * Sets payment_cycle_number
     *
     * @param string $payment_cycle_number Payment no
     *
     * @return $this
     */
    public function setPaymentCycleNumber($payment_cycle_number)
    {
        $this->container['payment_cycle_number'] = $payment_cycle_number;

        return $this;
    }

    /**
     * Gets applied_financed_amount
     *
     * @return double
     */
    public function getAppliedFinancedAmount()
    {
        return $this->container['applied_financed_amount'];
    }

    /**
     * Sets applied_financed_amount
     *
     * @param double $applied_financed_amount Financed amount applied
     *
     * @return $this
     */
    public function setAppliedFinancedAmount($applied_financed_amount)
    {
        $this->container['applied_financed_amount'] = $applied_financed_amount;

        return $this;
    }

    /**
     * Gets applied_interest_amount
     *
     * @return double
     */
    public function getAppliedInterestAmount()
    {
        return $this->container['applied_interest_amount'];
    }

    /**
     * Sets applied_interest_amount
     *
     * @param double $applied_interest_amount Interest amount applied
     *
     * @return $this
     */
    public function setAppliedInterestAmount($applied_interest_amount)
    {
        $this->container['applied_interest_amount'] = $applied_interest_amount;

        return $this;
    }

    /**
     * Gets applied_credit_usage_fee_amount
     *
     * @return double
     */
    public function getAppliedCreditUsageFeeAmount()
    {
        return $this->container['applied_credit_usage_fee_amount'];
    }

    /**
     * Sets applied_credit_usage_fee_amount
     *
     * @param double $applied_credit_usage_fee_amount Credit usage fee amount applied
     *
     * @return $this
     */
    public function setAppliedCreditUsageFeeAmount($applied_credit_usage_fee_amount)
    {
        $this->container['applied_credit_usage_fee_amount'] = $applied_credit_usage_fee_amount;

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
