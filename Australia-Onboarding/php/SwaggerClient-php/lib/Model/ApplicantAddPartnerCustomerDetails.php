<?php
/**
 * ApplicantAddPartnerCustomerDetails
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
 * ApplicantAddPartnerCustomerDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicantAddPartnerCustomerDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicantAddPartnerCustomerDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'partner_customer_internal_id' => 'string',
'partner_customer_id' => 'string',
'partner_customer_segment' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'partner_customer_internal_id' => null,
'partner_customer_id' => null,
'partner_customer_segment' => null    ];

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
        'partner_customer_internal_id' => 'partnerCustomerInternalId',
'partner_customer_id' => 'partnerCustomerId',
'partner_customer_segment' => 'partnerCustomerSegment'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'partner_customer_internal_id' => 'setPartnerCustomerInternalId',
'partner_customer_id' => 'setPartnerCustomerId',
'partner_customer_segment' => 'setPartnerCustomerSegment'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'partner_customer_internal_id' => 'getPartnerCustomerInternalId',
'partner_customer_id' => 'getPartnerCustomerId',
'partner_customer_segment' => 'getPartnerCustomerSegment'    ];

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
        $this->container['partner_customer_internal_id'] = isset($data['partner_customer_internal_id']) ? $data['partner_customer_internal_id'] : null;
        $this->container['partner_customer_id'] = isset($data['partner_customer_id']) ? $data['partner_customer_id'] : null;
        $this->container['partner_customer_segment'] = isset($data['partner_customer_segment']) ? $data['partner_customer_segment'] : null;
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
     * Gets partner_customer_internal_id
     *
     * @return string
     */
    public function getPartnerCustomerInternalId()
    {
        return $this->container['partner_customer_internal_id'];
    }

    /**
     * Sets partner_customer_internal_id
     *
     * @param string $partner_customer_internal_id Unique customer internal number associated with the partner.
     *
     * @return $this
     */
    public function setPartnerCustomerInternalId($partner_customer_internal_id)
    {
        $this->container['partner_customer_internal_id'] = $partner_customer_internal_id;

        return $this;
    }

    /**
     * Gets partner_customer_id
     *
     * @return string
     */
    public function getPartnerCustomerId()
    {
        return $this->container['partner_customer_id'];
    }

    /**
     * Sets partner_customer_id
     *
     * @param string $partner_customer_id Unique customer Id associated with the partner
     *
     * @return $this
     */
    public function setPartnerCustomerId($partner_customer_id)
    {
        $this->container['partner_customer_id'] = $partner_customer_id;

        return $this;
    }

    /**
     * Gets partner_customer_segment
     *
     * @return string
     */
    public function getPartnerCustomerSegment()
    {
        return $this->container['partner_customer_segment'];
    }

    /**
     * Sets partner_customer_segment
     *
     * @param string $partner_customer_segment Partner customer segment.Partner customer segment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{partnerCustomerSegment} resource to get possible value of this field with description. You can use partnerCustomerSegment field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setPartnerCustomerSegment($partner_customer_segment)
    {
        $this->container['partner_customer_segment'] = $partner_customer_segment;

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
