<?php
/**
 * ExistingCustomerCreditProductApplicationUpdateRequest
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
 * ExistingCustomerCreditProductApplicationUpdateRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ExistingCustomerCreditProductApplicationUpdateRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ExistingCustomerCreditProductApplicationUpdateRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'product' => '\Swagger\Client\Model\ECMProductUpdate',
'survivor_product' => '\Swagger\Client\Model\SurvivorProduct',
'applicant' => '\Swagger\Client\Model\ECMApplicantUpdate',
'sales_agent_details' => '\Swagger\Client\Model\SalesAgentDetails',
'control_flow_id' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'product' => null,
'survivor_product' => null,
'applicant' => null,
'sales_agent_details' => null,
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
        'product' => 'product',
'survivor_product' => 'survivorProduct',
'applicant' => 'applicant',
'sales_agent_details' => 'salesAgentDetails',
'control_flow_id' => 'controlFlowId'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'product' => 'setProduct',
'survivor_product' => 'setSurvivorProduct',
'applicant' => 'setApplicant',
'sales_agent_details' => 'setSalesAgentDetails',
'control_flow_id' => 'setControlFlowId'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'product' => 'getProduct',
'survivor_product' => 'getSurvivorProduct',
'applicant' => 'getApplicant',
'sales_agent_details' => 'getSalesAgentDetails',
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
        $this->container['product'] = isset($data['product']) ? $data['product'] : null;
        $this->container['survivor_product'] = isset($data['survivor_product']) ? $data['survivor_product'] : null;
        $this->container['applicant'] = isset($data['applicant']) ? $data['applicant'] : null;
        $this->container['sales_agent_details'] = isset($data['sales_agent_details']) ? $data['sales_agent_details'] : null;
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
     * Gets product
     *
     * @return \Swagger\Client\Model\ECMProductUpdate
     */
    public function getProduct()
    {
        return $this->container['product'];
    }

    /**
     * Sets product
     *
     * @param \Swagger\Client\Model\ECMProductUpdate $product product
     *
     * @return $this
     */
    public function setProduct($product)
    {
        $this->container['product'] = $product;

        return $this;
    }

    /**
     * Gets survivor_product
     *
     * @return \Swagger\Client\Model\SurvivorProduct
     */
    public function getSurvivorProduct()
    {
        return $this->container['survivor_product'];
    }

    /**
     * Sets survivor_product
     *
     * @param \Swagger\Client\Model\SurvivorProduct $survivor_product survivor_product
     *
     * @return $this
     */
    public function setSurvivorProduct($survivor_product)
    {
        $this->container['survivor_product'] = $survivor_product;

        return $this;
    }

    /**
     * Gets applicant
     *
     * @return \Swagger\Client\Model\ECMApplicantUpdate
     */
    public function getApplicant()
    {
        return $this->container['applicant'];
    }

    /**
     * Sets applicant
     *
     * @param \Swagger\Client\Model\ECMApplicantUpdate $applicant applicant
     *
     * @return $this
     */
    public function setApplicant($applicant)
    {
        $this->container['applicant'] = $applicant;

        return $this;
    }

    /**
     * Gets sales_agent_details
     *
     * @return \Swagger\Client\Model\SalesAgentDetails
     */
    public function getSalesAgentDetails()
    {
        return $this->container['sales_agent_details'];
    }

    /**
     * Sets sales_agent_details
     *
     * @param \Swagger\Client\Model\SalesAgentDetails $sales_agent_details sales_agent_details
     *
     * @return $this
     */
    public function setSalesAgentDetails($sales_agent_details)
    {
        $this->container['sales_agent_details'] = $sales_agent_details;

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
     * @param string $control_flow_id Control flow id is used to control the flow for subsequent requests in the session.
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
