<?php
/**
 * DebitCardEnrollmentDetails
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
 * DebitCardEnrollmentDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class DebitCardEnrollmentDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'DebitCardEnrollmentDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'internet_purchase_access_flag' => 'bool',
'contactless_payment_enrolled_flag' => 'bool',
'overseas_atm_access_allowed_flag' => 'bool'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'internet_purchase_access_flag' => null,
'contactless_payment_enrolled_flag' => null,
'overseas_atm_access_allowed_flag' => null    ];

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
        'internet_purchase_access_flag' => 'internetPurchaseAccessFlag',
'contactless_payment_enrolled_flag' => 'contactlessPaymentEnrolledFlag',
'overseas_atm_access_allowed_flag' => 'overseasAtmAccessAllowedFlag'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'internet_purchase_access_flag' => 'setInternetPurchaseAccessFlag',
'contactless_payment_enrolled_flag' => 'setContactlessPaymentEnrolledFlag',
'overseas_atm_access_allowed_flag' => 'setOverseasAtmAccessAllowedFlag'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'internet_purchase_access_flag' => 'getInternetPurchaseAccessFlag',
'contactless_payment_enrolled_flag' => 'getContactlessPaymentEnrolledFlag',
'overseas_atm_access_allowed_flag' => 'getOverseasAtmAccessAllowedFlag'    ];

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
        $this->container['internet_purchase_access_flag'] = isset($data['internet_purchase_access_flag']) ? $data['internet_purchase_access_flag'] : null;
        $this->container['contactless_payment_enrolled_flag'] = isset($data['contactless_payment_enrolled_flag']) ? $data['contactless_payment_enrolled_flag'] : null;
        $this->container['overseas_atm_access_allowed_flag'] = isset($data['overseas_atm_access_allowed_flag']) ? $data['overseas_atm_access_allowed_flag'] : null;
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
     * Gets internet_purchase_access_flag
     *
     * @return bool
     */
    public function getInternetPurchaseAccessFlag()
    {
        return $this->container['internet_purchase_access_flag'];
    }

    /**
     * Sets internet_purchase_access_flag
     *
     * @param bool $internet_purchase_access_flag Flag to indicate if internet purchase access is enabled or not on the debit/credit card
     *
     * @return $this
     */
    public function setInternetPurchaseAccessFlag($internet_purchase_access_flag)
    {
        $this->container['internet_purchase_access_flag'] = $internet_purchase_access_flag;

        return $this;
    }

    /**
     * Gets contactless_payment_enrolled_flag
     *
     * @return bool
     */
    public function getContactlessPaymentEnrolledFlag()
    {
        return $this->container['contactless_payment_enrolled_flag'];
    }

    /**
     * Sets contactless_payment_enrolled_flag
     *
     * @param bool $contactless_payment_enrolled_flag Flag to indicate if contact-less payment is enabled or not on the debit/credit card
     *
     * @return $this
     */
    public function setContactlessPaymentEnrolledFlag($contactless_payment_enrolled_flag)
    {
        $this->container['contactless_payment_enrolled_flag'] = $contactless_payment_enrolled_flag;

        return $this;
    }

    /**
     * Gets overseas_atm_access_allowed_flag
     *
     * @return bool
     */
    public function getOverseasAtmAccessAllowedFlag()
    {
        return $this->container['overseas_atm_access_allowed_flag'];
    }

    /**
     * Sets overseas_atm_access_allowed_flag
     *
     * @param bool $overseas_atm_access_allowed_flag This field is to indicate if overseas ATM access is allowed to the card.
     *
     * @return $this
     */
    public function setOverseasAtmAccessAllowedFlag($overseas_atm_access_allowed_flag)
    {
        $this->container['overseas_atm_access_allowed_flag'] = $overseas_atm_access_allowed_flag;

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
