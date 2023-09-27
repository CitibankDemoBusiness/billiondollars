<?php
/**
 * InternationalTransaction
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
 * InternationalTransaction Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class InternationalTransaction implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'InternationalTransaction';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'atm_transaction_limit_toggle_indicator' => 'string',
'atm_transaction_limit_amount' => 'double',
'contactless_txn_limit_toggle_indicator' => 'string',
'contactless_transaction_limit_amount' => 'double',
'contact_pos_txn_limit_toggle_indicator' => 'string',
'contact_pos_transaction_limit_amount' => 'double',
'non_pos_txn_limit_toggle_indicator' => 'string',
'non_pos_transaction_limit_amount' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'atm_transaction_limit_toggle_indicator' => null,
'atm_transaction_limit_amount' => 'double',
'contactless_txn_limit_toggle_indicator' => null,
'contactless_transaction_limit_amount' => 'double',
'contact_pos_txn_limit_toggle_indicator' => null,
'contact_pos_transaction_limit_amount' => 'double',
'non_pos_txn_limit_toggle_indicator' => null,
'non_pos_transaction_limit_amount' => 'double'    ];

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
        'atm_transaction_limit_toggle_indicator' => 'atmTransactionLimitToggleIndicator',
'atm_transaction_limit_amount' => 'atmTransactionLimitAmount',
'contactless_txn_limit_toggle_indicator' => 'contactlessTxnLimitToggleIndicator',
'contactless_transaction_limit_amount' => 'contactlessTransactionLimitAmount',
'contact_pos_txn_limit_toggle_indicator' => 'contactPosTxnLimitToggleIndicator',
'contact_pos_transaction_limit_amount' => 'contactPosTransactionLimitAmount',
'non_pos_txn_limit_toggle_indicator' => 'nonPosTxnLimitToggleIndicator',
'non_pos_transaction_limit_amount' => 'nonPosTransactionLimitAmount'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'atm_transaction_limit_toggle_indicator' => 'setAtmTransactionLimitToggleIndicator',
'atm_transaction_limit_amount' => 'setAtmTransactionLimitAmount',
'contactless_txn_limit_toggle_indicator' => 'setContactlessTxnLimitToggleIndicator',
'contactless_transaction_limit_amount' => 'setContactlessTransactionLimitAmount',
'contact_pos_txn_limit_toggle_indicator' => 'setContactPosTxnLimitToggleIndicator',
'contact_pos_transaction_limit_amount' => 'setContactPosTransactionLimitAmount',
'non_pos_txn_limit_toggle_indicator' => 'setNonPosTxnLimitToggleIndicator',
'non_pos_transaction_limit_amount' => 'setNonPosTransactionLimitAmount'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'atm_transaction_limit_toggle_indicator' => 'getAtmTransactionLimitToggleIndicator',
'atm_transaction_limit_amount' => 'getAtmTransactionLimitAmount',
'contactless_txn_limit_toggle_indicator' => 'getContactlessTxnLimitToggleIndicator',
'contactless_transaction_limit_amount' => 'getContactlessTransactionLimitAmount',
'contact_pos_txn_limit_toggle_indicator' => 'getContactPosTxnLimitToggleIndicator',
'contact_pos_transaction_limit_amount' => 'getContactPosTransactionLimitAmount',
'non_pos_txn_limit_toggle_indicator' => 'getNonPosTxnLimitToggleIndicator',
'non_pos_transaction_limit_amount' => 'getNonPosTransactionLimitAmount'    ];

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
        $this->container['atm_transaction_limit_toggle_indicator'] = isset($data['atm_transaction_limit_toggle_indicator']) ? $data['atm_transaction_limit_toggle_indicator'] : null;
        $this->container['atm_transaction_limit_amount'] = isset($data['atm_transaction_limit_amount']) ? $data['atm_transaction_limit_amount'] : null;
        $this->container['contactless_txn_limit_toggle_indicator'] = isset($data['contactless_txn_limit_toggle_indicator']) ? $data['contactless_txn_limit_toggle_indicator'] : null;
        $this->container['contactless_transaction_limit_amount'] = isset($data['contactless_transaction_limit_amount']) ? $data['contactless_transaction_limit_amount'] : null;
        $this->container['contact_pos_txn_limit_toggle_indicator'] = isset($data['contact_pos_txn_limit_toggle_indicator']) ? $data['contact_pos_txn_limit_toggle_indicator'] : null;
        $this->container['contact_pos_transaction_limit_amount'] = isset($data['contact_pos_transaction_limit_amount']) ? $data['contact_pos_transaction_limit_amount'] : null;
        $this->container['non_pos_txn_limit_toggle_indicator'] = isset($data['non_pos_txn_limit_toggle_indicator']) ? $data['non_pos_txn_limit_toggle_indicator'] : null;
        $this->container['non_pos_transaction_limit_amount'] = isset($data['non_pos_transaction_limit_amount']) ? $data['non_pos_transaction_limit_amount'] : null;
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
     * Gets atm_transaction_limit_toggle_indicator
     *
     * @return string
     */
    public function getAtmTransactionLimitToggleIndicator()
    {
        return $this->container['atm_transaction_limit_toggle_indicator'];
    }

    /**
     * Sets atm_transaction_limit_toggle_indicator
     *
     * @param string $atm_transaction_limit_toggle_indicator InternationalSingleATMTransactionLimitToggleFlag
     *
     * @return $this
     */
    public function setAtmTransactionLimitToggleIndicator($atm_transaction_limit_toggle_indicator)
    {
        $this->container['atm_transaction_limit_toggle_indicator'] = $atm_transaction_limit_toggle_indicator;

        return $this;
    }

    /**
     * Gets atm_transaction_limit_amount
     *
     * @return double
     */
    public function getAtmTransactionLimitAmount()
    {
        return $this->container['atm_transaction_limit_amount'];
    }

    /**
     * Sets atm_transaction_limit_amount
     *
     * @param double $atm_transaction_limit_amount InternationalSingleATMTransactionLimit
     *
     * @return $this
     */
    public function setAtmTransactionLimitAmount($atm_transaction_limit_amount)
    {
        $this->container['atm_transaction_limit_amount'] = $atm_transaction_limit_amount;

        return $this;
    }

    /**
     * Gets contactless_txn_limit_toggle_indicator
     *
     * @return string
     */
    public function getContactlessTxnLimitToggleIndicator()
    {
        return $this->container['contactless_txn_limit_toggle_indicator'];
    }

    /**
     * Sets contactless_txn_limit_toggle_indicator
     *
     * @param string $contactless_txn_limit_toggle_indicator InternationalSingleContactlessTransactionLimitToggleFlag
     *
     * @return $this
     */
    public function setContactlessTxnLimitToggleIndicator($contactless_txn_limit_toggle_indicator)
    {
        $this->container['contactless_txn_limit_toggle_indicator'] = $contactless_txn_limit_toggle_indicator;

        return $this;
    }

    /**
     * Gets contactless_transaction_limit_amount
     *
     * @return double
     */
    public function getContactlessTransactionLimitAmount()
    {
        return $this->container['contactless_transaction_limit_amount'];
    }

    /**
     * Sets contactless_transaction_limit_amount
     *
     * @param double $contactless_transaction_limit_amount InternationalSingleContactlessTransactionLimit
     *
     * @return $this
     */
    public function setContactlessTransactionLimitAmount($contactless_transaction_limit_amount)
    {
        $this->container['contactless_transaction_limit_amount'] = $contactless_transaction_limit_amount;

        return $this;
    }

    /**
     * Gets contact_pos_txn_limit_toggle_indicator
     *
     * @return string
     */
    public function getContactPosTxnLimitToggleIndicator()
    {
        return $this->container['contact_pos_txn_limit_toggle_indicator'];
    }

    /**
     * Sets contact_pos_txn_limit_toggle_indicator
     *
     * @param string $contact_pos_txn_limit_toggle_indicator InternationalSingleContactPOSTransactionLimitToggleFlag
     *
     * @return $this
     */
    public function setContactPosTxnLimitToggleIndicator($contact_pos_txn_limit_toggle_indicator)
    {
        $this->container['contact_pos_txn_limit_toggle_indicator'] = $contact_pos_txn_limit_toggle_indicator;

        return $this;
    }

    /**
     * Gets contact_pos_transaction_limit_amount
     *
     * @return double
     */
    public function getContactPosTransactionLimitAmount()
    {
        return $this->container['contact_pos_transaction_limit_amount'];
    }

    /**
     * Sets contact_pos_transaction_limit_amount
     *
     * @param double $contact_pos_transaction_limit_amount InternationalSingleContactPOSTransactionLimit
     *
     * @return $this
     */
    public function setContactPosTransactionLimitAmount($contact_pos_transaction_limit_amount)
    {
        $this->container['contact_pos_transaction_limit_amount'] = $contact_pos_transaction_limit_amount;

        return $this;
    }

    /**
     * Gets non_pos_txn_limit_toggle_indicator
     *
     * @return string
     */
    public function getNonPosTxnLimitToggleIndicator()
    {
        return $this->container['non_pos_txn_limit_toggle_indicator'];
    }

    /**
     * Sets non_pos_txn_limit_toggle_indicator
     *
     * @param string $non_pos_txn_limit_toggle_indicator InternationalSingleNonPOSTransactionLimitToggleFlag
     *
     * @return $this
     */
    public function setNonPosTxnLimitToggleIndicator($non_pos_txn_limit_toggle_indicator)
    {
        $this->container['non_pos_txn_limit_toggle_indicator'] = $non_pos_txn_limit_toggle_indicator;

        return $this;
    }

    /**
     * Gets non_pos_transaction_limit_amount
     *
     * @return double
     */
    public function getNonPosTransactionLimitAmount()
    {
        return $this->container['non_pos_transaction_limit_amount'];
    }

    /**
     * Sets non_pos_transaction_limit_amount
     *
     * @param double $non_pos_transaction_limit_amount InternationalSingleNonPOSTransactionLimit
     *
     * @return $this
     */
    public function setNonPosTransactionLimitAmount($non_pos_transaction_limit_amount)
    {
        $this->container['non_pos_transaction_limit_amount'] = $non_pos_transaction_limit_amount;

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
