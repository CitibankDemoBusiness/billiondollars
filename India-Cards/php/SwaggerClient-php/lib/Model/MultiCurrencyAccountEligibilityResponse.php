<?php
/**
 * MultiCurrencyAccountEligibilityResponse
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
 * MultiCurrencyAccountEligibilityResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class MultiCurrencyAccountEligibilityResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'MultiCurrencyAccountEligibilityResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'display_card_number' => 'string',
'card_id' => 'string',
'atm_card_flag' => 'bool',
'card_enrollment_status' => 'string',
'eligible_for_currency_addition' => 'string',
'account_details' => '\Swagger\Client\Model\AccountDetails[]',
'currency_details' => '\Swagger\Client\Model\CurrencyDetails[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'display_card_number' => null,
'card_id' => null,
'atm_card_flag' => null,
'card_enrollment_status' => null,
'eligible_for_currency_addition' => null,
'account_details' => null,
'currency_details' => null    ];

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
        'display_card_number' => 'displayCardNumber',
'card_id' => 'cardId',
'atm_card_flag' => 'atmCardFlag',
'card_enrollment_status' => 'cardEnrollmentStatus',
'eligible_for_currency_addition' => 'eligibleForCurrencyAddition',
'account_details' => 'accountDetails',
'currency_details' => 'currencyDetails'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'display_card_number' => 'setDisplayCardNumber',
'card_id' => 'setCardId',
'atm_card_flag' => 'setAtmCardFlag',
'card_enrollment_status' => 'setCardEnrollmentStatus',
'eligible_for_currency_addition' => 'setEligibleForCurrencyAddition',
'account_details' => 'setAccountDetails',
'currency_details' => 'setCurrencyDetails'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'display_card_number' => 'getDisplayCardNumber',
'card_id' => 'getCardId',
'atm_card_flag' => 'getAtmCardFlag',
'card_enrollment_status' => 'getCardEnrollmentStatus',
'eligible_for_currency_addition' => 'getEligibleForCurrencyAddition',
'account_details' => 'getAccountDetails',
'currency_details' => 'getCurrencyDetails'    ];

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
        $this->container['display_card_number'] = isset($data['display_card_number']) ? $data['display_card_number'] : null;
        $this->container['card_id'] = isset($data['card_id']) ? $data['card_id'] : null;
        $this->container['atm_card_flag'] = isset($data['atm_card_flag']) ? $data['atm_card_flag'] : null;
        $this->container['card_enrollment_status'] = isset($data['card_enrollment_status']) ? $data['card_enrollment_status'] : null;
        $this->container['eligible_for_currency_addition'] = isset($data['eligible_for_currency_addition']) ? $data['eligible_for_currency_addition'] : null;
        $this->container['account_details'] = isset($data['account_details']) ? $data['account_details'] : null;
        $this->container['currency_details'] = isset($data['currency_details']) ? $data['currency_details'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['display_card_number'] === null) {
            $invalidProperties[] = "'display_card_number' can't be null";
        }
        if ($this->container['card_id'] === null) {
            $invalidProperties[] = "'card_id' can't be null";
        }
        if ($this->container['card_enrollment_status'] === null) {
            $invalidProperties[] = "'card_enrollment_status' can't be null";
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
     * Gets display_card_number
     *
     * @return string
     */
    public function getDisplayCardNumber()
    {
        return $this->container['display_card_number'];
    }

    /**
     * Sets display_card_number
     *
     * @param string $display_card_number A masked card number that can be displayed to the customer.
     *
     * @return $this
     */
    public function setDisplayCardNumber($display_card_number)
    {
        $this->container['display_card_number'] = $display_card_number;

        return $this;
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
     * @param string $card_id The customer card identifier in encrypted format
     *
     * @return $this
     */
    public function setCardId($card_id)
    {
        $this->container['card_id'] = $card_id;

        return $this;
    }

    /**
     * Gets atm_card_flag
     *
     * @return bool
     */
    public function getAtmCardFlag()
    {
        return $this->container['atm_card_flag'];
    }

    /**
     * Sets atm_card_flag
     *
     * @param bool $atm_card_flag Flag to identify if the cardNumbre in response is ATM card.
     *
     * @return $this
     */
    public function setAtmCardFlag($atm_card_flag)
    {
        $this->container['atm_card_flag'] = $atm_card_flag;

        return $this;
    }

    /**
     * Gets card_enrollment_status
     *
     * @return string
     */
    public function getCardEnrollmentStatus()
    {
        return $this->container['card_enrollment_status'];
    }

    /**
     * Sets card_enrollment_status
     *
     * @param string $card_enrollment_status This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setCardEnrollmentStatus($card_enrollment_status)
    {
        $this->container['card_enrollment_status'] = $card_enrollment_status;

        return $this;
    }

    /**
     * Gets eligible_for_currency_addition
     *
     * @return string
     */
    public function getEligibleForCurrencyAddition()
    {
        return $this->container['eligible_for_currency_addition'];
    }

    /**
     * Sets eligible_for_currency_addition
     *
     * @param string $eligible_for_currency_addition Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setEligibleForCurrencyAddition($eligible_for_currency_addition)
    {
        $this->container['eligible_for_currency_addition'] = $eligible_for_currency_addition;

        return $this;
    }

    /**
     * Gets account_details
     *
     * @return \Swagger\Client\Model\AccountDetails[]
     */
    public function getAccountDetails()
    {
        return $this->container['account_details'];
    }

    /**
     * Sets account_details
     *
     * @param \Swagger\Client\Model\AccountDetails[] $account_details account_details
     *
     * @return $this
     */
    public function setAccountDetails($account_details)
    {
        $this->container['account_details'] = $account_details;

        return $this;
    }

    /**
     * Gets currency_details
     *
     * @return \Swagger\Client\Model\CurrencyDetails[]
     */
    public function getCurrencyDetails()
    {
        return $this->container['currency_details'];
    }

    /**
     * Sets currency_details
     *
     * @param \Swagger\Client\Model\CurrencyDetails[] $currency_details currency_details
     *
     * @return $this
     */
    public function setCurrencyDetails($currency_details)
    {
        $this->container['currency_details'] = $currency_details;

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
