<?php
/**
 * ApplicantInquiryCreditCardProduct
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
 * ApplicantInquiryCreditCardProduct Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicantInquiryCreditCardProduct implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicantInquiryCreditCardProduct';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'emboss_name' => 'string',
'requested_credit_limit' => 'double',
'overseas_card_activation_flag' => 'bool'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'emboss_name' => null,
'requested_credit_limit' => 'double',
'overseas_card_activation_flag' => null    ];

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
        'emboss_name' => 'embossName',
'requested_credit_limit' => 'requestedCreditLimit',
'overseas_card_activation_flag' => 'overseasCardActivationFlag'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'emboss_name' => 'setEmbossName',
'requested_credit_limit' => 'setRequestedCreditLimit',
'overseas_card_activation_flag' => 'setOverseasCardActivationFlag'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'emboss_name' => 'getEmbossName',
'requested_credit_limit' => 'getRequestedCreditLimit',
'overseas_card_activation_flag' => 'getOverseasCardActivationFlag'    ];

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
        $this->container['emboss_name'] = isset($data['emboss_name']) ? $data['emboss_name'] : null;
        $this->container['requested_credit_limit'] = isset($data['requested_credit_limit']) ? $data['requested_credit_limit'] : null;
        $this->container['overseas_card_activation_flag'] = isset($data['overseas_card_activation_flag']) ? $data['overseas_card_activation_flag'] : null;
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
     * Gets emboss_name
     *
     * @return string
     */
    public function getEmbossName()
    {
        return $this->container['emboss_name'];
    }

    /**
     * Sets emboss_name
     *
     * @param string $emboss_name Name to be embossed on card.
     *
     * @return $this
     */
    public function setEmbossName($emboss_name)
    {
        $this->container['emboss_name'] = $emboss_name;

        return $this;
    }

    /**
     * Gets requested_credit_limit
     *
     * @return double
     */
    public function getRequestedCreditLimit()
    {
        return $this->container['requested_credit_limit'];
    }

    /**
     * Sets requested_credit_limit
     *
     * @param double $requested_credit_limit Credit limit accepted by applicant
     *
     * @return $this
     */
    public function setRequestedCreditLimit($requested_credit_limit)
    {
        $this->container['requested_credit_limit'] = $requested_credit_limit;

        return $this;
    }

    /**
     * Gets overseas_card_activation_flag
     *
     * @return bool
     */
    public function getOverseasCardActivationFlag()
    {
        return $this->container['overseas_card_activation_flag'];
    }

    /**
     * Sets overseas_card_activation_flag
     *
     * @param bool $overseas_card_activation_flag Flag to activate the card for overseas usage.Valid values: true and false
     *
     * @return $this
     */
    public function setOverseasCardActivationFlag($overseas_card_activation_flag)
    {
        $this->container['overseas_card_activation_flag'] = $overseas_card_activation_flag;

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
