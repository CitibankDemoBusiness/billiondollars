<?php
/**
 * CreditCardLimitDetails
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
 * CreditCardLimitDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CreditCardLimitDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CreditCardLimitDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'current_contactless_wthout_pin_pmt_limit' => 'float',
'pos_spending_limit_amount' => 'double',
'internet_purchase_limit_amount' => 'double',
'daily_atm_withdrawal_limit_amount' => 'double',
'daily_transaction_limit_amount' => 'double',
'internet_purchase_activation_flag' => 'bool',
'domestic_transaction' => '\Swagger\Client\Model\DomesticTransaction',
'international_transaction' => '\Swagger\Client\Model\InternationalTransaction'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'current_contactless_wthout_pin_pmt_limit' => 'integer',
'pos_spending_limit_amount' => 'double',
'internet_purchase_limit_amount' => 'double',
'daily_atm_withdrawal_limit_amount' => 'double',
'daily_transaction_limit_amount' => 'double',
'internet_purchase_activation_flag' => null,
'domestic_transaction' => null,
'international_transaction' => null    ];

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
        'current_contactless_wthout_pin_pmt_limit' => 'currentContactlessWthoutPinPmtLimit',
'pos_spending_limit_amount' => 'posSpendingLimitAmount',
'internet_purchase_limit_amount' => 'internetPurchaseLimitAmount',
'daily_atm_withdrawal_limit_amount' => 'dailyAtmWithdrawalLimitAmount',
'daily_transaction_limit_amount' => 'dailyTransactionLimitAmount',
'internet_purchase_activation_flag' => 'internetPurchaseActivationFlag',
'domestic_transaction' => 'domesticTransaction',
'international_transaction' => 'internationalTransaction'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'current_contactless_wthout_pin_pmt_limit' => 'setCurrentContactlessWthoutPinPmtLimit',
'pos_spending_limit_amount' => 'setPosSpendingLimitAmount',
'internet_purchase_limit_amount' => 'setInternetPurchaseLimitAmount',
'daily_atm_withdrawal_limit_amount' => 'setDailyAtmWithdrawalLimitAmount',
'daily_transaction_limit_amount' => 'setDailyTransactionLimitAmount',
'internet_purchase_activation_flag' => 'setInternetPurchaseActivationFlag',
'domestic_transaction' => 'setDomesticTransaction',
'international_transaction' => 'setInternationalTransaction'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'current_contactless_wthout_pin_pmt_limit' => 'getCurrentContactlessWthoutPinPmtLimit',
'pos_spending_limit_amount' => 'getPosSpendingLimitAmount',
'internet_purchase_limit_amount' => 'getInternetPurchaseLimitAmount',
'daily_atm_withdrawal_limit_amount' => 'getDailyAtmWithdrawalLimitAmount',
'daily_transaction_limit_amount' => 'getDailyTransactionLimitAmount',
'internet_purchase_activation_flag' => 'getInternetPurchaseActivationFlag',
'domestic_transaction' => 'getDomesticTransaction',
'international_transaction' => 'getInternationalTransaction'    ];

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
        $this->container['current_contactless_wthout_pin_pmt_limit'] = isset($data['current_contactless_wthout_pin_pmt_limit']) ? $data['current_contactless_wthout_pin_pmt_limit'] : null;
        $this->container['pos_spending_limit_amount'] = isset($data['pos_spending_limit_amount']) ? $data['pos_spending_limit_amount'] : null;
        $this->container['internet_purchase_limit_amount'] = isset($data['internet_purchase_limit_amount']) ? $data['internet_purchase_limit_amount'] : null;
        $this->container['daily_atm_withdrawal_limit_amount'] = isset($data['daily_atm_withdrawal_limit_amount']) ? $data['daily_atm_withdrawal_limit_amount'] : null;
        $this->container['daily_transaction_limit_amount'] = isset($data['daily_transaction_limit_amount']) ? $data['daily_transaction_limit_amount'] : null;
        $this->container['internet_purchase_activation_flag'] = isset($data['internet_purchase_activation_flag']) ? $data['internet_purchase_activation_flag'] : null;
        $this->container['domestic_transaction'] = isset($data['domestic_transaction']) ? $data['domestic_transaction'] : null;
        $this->container['international_transaction'] = isset($data['international_transaction']) ? $data['international_transaction'] : null;
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
     * Gets current_contactless_wthout_pin_pmt_limit
     *
     * @return float
     */
    public function getCurrentContactlessWthoutPinPmtLimit()
    {
        return $this->container['current_contactless_wthout_pin_pmt_limit'];
    }

    /**
     * Sets current_contactless_wthout_pin_pmt_limit
     *
     * @param float $current_contactless_wthout_pin_pmt_limit Transaction limit set by the customer for the contact less payments without pin
     *
     * @return $this
     */
    public function setCurrentContactlessWthoutPinPmtLimit($current_contactless_wthout_pin_pmt_limit)
    {
        $this->container['current_contactless_wthout_pin_pmt_limit'] = $current_contactless_wthout_pin_pmt_limit;

        return $this;
    }

    /**
     * Gets pos_spending_limit_amount
     *
     * @return double
     */
    public function getPosSpendingLimitAmount()
    {
        return $this->container['pos_spending_limit_amount'];
    }

    /**
     * Sets pos_spending_limit_amount
     *
     * @param double $pos_spending_limit_amount Point Sale Transaction Limit for the Credit card depends on customer selection
     *
     * @return $this
     */
    public function setPosSpendingLimitAmount($pos_spending_limit_amount)
    {
        $this->container['pos_spending_limit_amount'] = $pos_spending_limit_amount;

        return $this;
    }

    /**
     * Gets internet_purchase_limit_amount
     *
     * @return double
     */
    public function getInternetPurchaseLimitAmount()
    {
        return $this->container['internet_purchase_limit_amount'];
    }

    /**
     * Sets internet_purchase_limit_amount
     *
     * @param double $internet_purchase_limit_amount Non Point of Sale Transaction Limit for the Credit Card. Example: Online Transaction
     *
     * @return $this
     */
    public function setInternetPurchaseLimitAmount($internet_purchase_limit_amount)
    {
        $this->container['internet_purchase_limit_amount'] = $internet_purchase_limit_amount;

        return $this;
    }

    /**
     * Gets daily_atm_withdrawal_limit_amount
     *
     * @return double
     */
    public function getDailyAtmWithdrawalLimitAmount()
    {
        return $this->container['daily_atm_withdrawal_limit_amount'];
    }

    /**
     * Sets daily_atm_withdrawal_limit_amount
     *
     * @param double $daily_atm_withdrawal_limit_amount Field to indicate the limit on local ATM withdrawal amount
     *
     * @return $this
     */
    public function setDailyAtmWithdrawalLimitAmount($daily_atm_withdrawal_limit_amount)
    {
        $this->container['daily_atm_withdrawal_limit_amount'] = $daily_atm_withdrawal_limit_amount;

        return $this;
    }

    /**
     * Gets daily_transaction_limit_amount
     *
     * @return double
     */
    public function getDailyTransactionLimitAmount()
    {
        return $this->container['daily_transaction_limit_amount'];
    }

    /**
     * Sets daily_transaction_limit_amount
     *
     * @param double $daily_transaction_limit_amount This is Daily accumulated Transaction amount Limit and set by customer.
     *
     * @return $this
     */
    public function setDailyTransactionLimitAmount($daily_transaction_limit_amount)
    {
        $this->container['daily_transaction_limit_amount'] = $daily_transaction_limit_amount;

        return $this;
    }

    /**
     * Gets internet_purchase_activation_flag
     *
     * @return bool
     */
    public function getInternetPurchaseActivationFlag()
    {
        return $this->container['internet_purchase_activation_flag'];
    }

    /**
     * Sets internet_purchase_activation_flag
     *
     * @param bool $internet_purchase_activation_flag The indicator to enable/disable online purchase transaction (E-commerce).
     *
     * @return $this
     */
    public function setInternetPurchaseActivationFlag($internet_purchase_activation_flag)
    {
        $this->container['internet_purchase_activation_flag'] = $internet_purchase_activation_flag;

        return $this;
    }

    /**
     * Gets domestic_transaction
     *
     * @return \Swagger\Client\Model\DomesticTransaction
     */
    public function getDomesticTransaction()
    {
        return $this->container['domestic_transaction'];
    }

    /**
     * Sets domestic_transaction
     *
     * @param \Swagger\Client\Model\DomesticTransaction $domestic_transaction domestic_transaction
     *
     * @return $this
     */
    public function setDomesticTransaction($domestic_transaction)
    {
        $this->container['domestic_transaction'] = $domestic_transaction;

        return $this;
    }

    /**
     * Gets international_transaction
     *
     * @return \Swagger\Client\Model\InternationalTransaction
     */
    public function getInternationalTransaction()
    {
        return $this->container['international_transaction'];
    }

    /**
     * Sets international_transaction
     *
     * @param \Swagger\Client\Model\InternationalTransaction $international_transaction international_transaction
     *
     * @return $this
     */
    public function setInternationalTransaction($international_transaction)
    {
        $this->container['international_transaction'] = $international_transaction;

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
