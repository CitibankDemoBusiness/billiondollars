<?php
/**
 * ECMDemographicsUpdate
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
 * ECMDemographicsUpdate Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ECMDemographicsUpdate implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ECMDemographicsUpdate';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'marital_status' => 'string',
'residency_status' => 'string',
'correspondence_language_code' => 'string',
'place_of_birth' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'marital_status' => null,
'residency_status' => null,
'correspondence_language_code' => null,
'place_of_birth' => null    ];

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
        'marital_status' => 'maritalStatus',
'residency_status' => 'residencyStatus',
'correspondence_language_code' => 'correspondenceLanguageCode',
'place_of_birth' => 'placeOfBirth'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'marital_status' => 'setMaritalStatus',
'residency_status' => 'setResidencyStatus',
'correspondence_language_code' => 'setCorrespondenceLanguageCode',
'place_of_birth' => 'setPlaceOfBirth'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'marital_status' => 'getMaritalStatus',
'residency_status' => 'getResidencyStatus',
'correspondence_language_code' => 'getCorrespondenceLanguageCode',
'place_of_birth' => 'getPlaceOfBirth'    ];

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
        $this->container['marital_status'] = isset($data['marital_status']) ? $data['marital_status'] : null;
        $this->container['residency_status'] = isset($data['residency_status']) ? $data['residency_status'] : null;
        $this->container['correspondence_language_code'] = isset($data['correspondence_language_code']) ? $data['correspondence_language_code'] : null;
        $this->container['place_of_birth'] = isset($data['place_of_birth']) ? $data['place_of_birth'] : null;
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
     * Gets marital_status
     *
     * @return string
     */
    public function getMaritalStatus()
    {
        return $this->container['marital_status'];
    }

    /**
     * Sets marital_status
     *
     * @param string $marital_status Applicants marital status. This is a reference data field. Please use /v1/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setMaritalStatus($marital_status)
    {
        $this->container['marital_status'] = $marital_status;

        return $this;
    }

    /**
     * Gets residency_status
     *
     * @return string
     */
    public function getResidencyStatus()
    {
        return $this->container['residency_status'];
    }

    /**
     * Sets residency_status
     *
     * @param string $residency_status Indicate status of residence. This is a reference data field. Please use /v1/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setResidencyStatus($residency_status)
    {
        $this->container['residency_status'] = $residency_status;

        return $this;
    }

    /**
     * Gets correspondence_language_code
     *
     * @return string
     */
    public function getCorrespondenceLanguageCode()
    {
        return $this->container['correspondence_language_code'];
    }

    /**
     * Sets correspondence_language_code
     *
     * @param string $correspondence_language_code Code for correspondence language of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setCorrespondenceLanguageCode($correspondence_language_code)
    {
        $this->container['correspondence_language_code'] = $correspondence_language_code;

        return $this;
    }

    /**
     * Gets place_of_birth
     *
     * @return string
     */
    public function getPlaceOfBirth()
    {
        return $this->container['place_of_birth'];
    }

    /**
     * Sets place_of_birth
     *
     * @param string $place_of_birth Applicants place of birth
     *
     * @return $this
     */
    public function setPlaceOfBirth($place_of_birth)
    {
        $this->container['place_of_birth'] = $place_of_birth;

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
