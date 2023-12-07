<?php
/**
 * OfferAcceptanceRequest
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
 * OfferAcceptanceRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class OfferAcceptanceRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'OfferAcceptanceRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'counter_product_accepted_flag' => 'bool',
'counter_product_confirmation' => '\Swagger\Client\Model\ProductConfirmation[]',
'requested_product_confirmation' => '\Swagger\Client\Model\ProductConfirmation[]',
'control_flow_id' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'counter_product_accepted_flag' => null,
'counter_product_confirmation' => null,
'requested_product_confirmation' => null,
'control_flow_id' => null    ];

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
        'counter_product_accepted_flag' => 'counterProductAcceptedFlag',
'counter_product_confirmation' => 'counterProductConfirmation',
'requested_product_confirmation' => 'requestedProductConfirmation',
'control_flow_id' => 'controlFlowId'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'counter_product_accepted_flag' => 'setCounterProductAcceptedFlag',
'counter_product_confirmation' => 'setCounterProductConfirmation',
'requested_product_confirmation' => 'setRequestedProductConfirmation',
'control_flow_id' => 'setControlFlowId'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'counter_product_accepted_flag' => 'getCounterProductAcceptedFlag',
'counter_product_confirmation' => 'getCounterProductConfirmation',
'requested_product_confirmation' => 'getRequestedProductConfirmation',
'control_flow_id' => 'getControlFlowId'    ];

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
        $this->container['counter_product_accepted_flag'] = isset($data['counter_product_accepted_flag']) ? $data['counter_product_accepted_flag'] : null;
        $this->container['counter_product_confirmation'] = isset($data['counter_product_confirmation']) ? $data['counter_product_confirmation'] : null;
        $this->container['requested_product_confirmation'] = isset($data['requested_product_confirmation']) ? $data['requested_product_confirmation'] : null;
        $this->container['control_flow_id'] = isset($data['control_flow_id']) ? $data['control_flow_id'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['requested_product_confirmation'] === null) {
            $invalidProperties[] = "'requested_product_confirmation' can't be null";
        }
        if ($this->container['control_flow_id'] === null) {
            $invalidProperties[] = "'control_flow_id' can't be null";
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
     * Gets counter_product_accepted_flag
     *
     * @return bool
     */
    public function getCounterProductAcceptedFlag()
    {
        return $this->container['counter_product_accepted_flag'];
    }

    /**
     * Sets counter_product_accepted_flag
     *
     * @param bool $counter_product_accepted_flag Flag to indicate a counter offer selected by an applicant. Valid values: true and false
     *
     * @return $this
     */
    public function setCounterProductAcceptedFlag($counter_product_accepted_flag)
    {
        $this->container['counter_product_accepted_flag'] = $counter_product_accepted_flag;

        return $this;
    }

    /**
     * Gets counter_product_confirmation
     *
     * @return \Swagger\Client\Model\ProductConfirmation[]
     */
    public function getCounterProductConfirmation()
    {
        return $this->container['counter_product_confirmation'];
    }

    /**
     * Sets counter_product_confirmation
     *
     * @param \Swagger\Client\Model\ProductConfirmation[] $counter_product_confirmation counter_product_confirmation
     *
     * @return $this
     */
    public function setCounterProductConfirmation($counter_product_confirmation)
    {
        $this->container['counter_product_confirmation'] = $counter_product_confirmation;

        return $this;
    }

    /**
     * Gets requested_product_confirmation
     *
     * @return \Swagger\Client\Model\ProductConfirmation[]
     */
    public function getRequestedProductConfirmation()
    {
        return $this->container['requested_product_confirmation'];
    }

    /**
     * Sets requested_product_confirmation
     *
     * @param \Swagger\Client\Model\ProductConfirmation[] $requested_product_confirmation requested_product_confirmation
     *
     * @return $this
     */
    public function setRequestedProductConfirmation($requested_product_confirmation)
    {
        $this->container['requested_product_confirmation'] = $requested_product_confirmation;

        return $this;
    }

    /**
     * Gets control_flow_id
     *
     * @return string
     */
    public function getControlFlowId()
    {
        return $this->container['control_flow_id'];
    }

    /**
     * Sets control_flow_id
     *
     * @param string $control_flow_id Control Flow Id
     *
     * @return $this
     */
    public function setControlFlowId($control_flow_id)
    {
        $this->container['control_flow_id'] = $control_flow_id;

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
