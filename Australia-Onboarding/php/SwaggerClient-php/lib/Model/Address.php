<?php
/**
 * Address
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
 * Address Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class Address implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'Address';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'address_type' => 'string',
'address_line1' => 'string',
'address_line2' => 'string',
'address_line3' => 'string',
'address_line4' => 'string',
'city_name' => 'string',
'state' => 'string',
'postal_code' => 'string',
'province_code' => 'string',
'country_code' => 'string',
'ok_to_mail' => 'bool'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'address_type' => null,
'address_line1' => null,
'address_line2' => null,
'address_line3' => null,
'address_line4' => null,
'city_name' => null,
'state' => null,
'postal_code' => null,
'province_code' => null,
'country_code' => null,
'ok_to_mail' => null    ];

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
        'address_type' => 'addressType',
'address_line1' => 'addressLine1',
'address_line2' => 'addressLine2',
'address_line3' => 'addressLine3',
'address_line4' => 'addressLine4',
'city_name' => 'cityName',
'state' => 'state',
'postal_code' => 'postalCode',
'province_code' => 'provinceCode',
'country_code' => 'countryCode',
'ok_to_mail' => 'okToMail'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'address_type' => 'setAddressType',
'address_line1' => 'setAddressLine1',
'address_line2' => 'setAddressLine2',
'address_line3' => 'setAddressLine3',
'address_line4' => 'setAddressLine4',
'city_name' => 'setCityName',
'state' => 'setState',
'postal_code' => 'setPostalCode',
'province_code' => 'setProvinceCode',
'country_code' => 'setCountryCode',
'ok_to_mail' => 'setOkToMail'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'address_type' => 'getAddressType',
'address_line1' => 'getAddressLine1',
'address_line2' => 'getAddressLine2',
'address_line3' => 'getAddressLine3',
'address_line4' => 'getAddressLine4',
'city_name' => 'getCityName',
'state' => 'getState',
'postal_code' => 'getPostalCode',
'province_code' => 'getProvinceCode',
'country_code' => 'getCountryCode',
'ok_to_mail' => 'getOkToMail'    ];

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
        $this->container['address_type'] = isset($data['address_type']) ? $data['address_type'] : null;
        $this->container['address_line1'] = isset($data['address_line1']) ? $data['address_line1'] : null;
        $this->container['address_line2'] = isset($data['address_line2']) ? $data['address_line2'] : null;
        $this->container['address_line3'] = isset($data['address_line3']) ? $data['address_line3'] : null;
        $this->container['address_line4'] = isset($data['address_line4']) ? $data['address_line4'] : null;
        $this->container['city_name'] = isset($data['city_name']) ? $data['city_name'] : null;
        $this->container['state'] = isset($data['state']) ? $data['state'] : null;
        $this->container['postal_code'] = isset($data['postal_code']) ? $data['postal_code'] : null;
        $this->container['province_code'] = isset($data['province_code']) ? $data['province_code'] : null;
        $this->container['country_code'] = isset($data['country_code']) ? $data['country_code'] : null;
        $this->container['ok_to_mail'] = isset($data['ok_to_mail']) ? $data['ok_to_mail'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['address_type'] === null) {
            $invalidProperties[] = "'address_type' can't be null";
        }
        if ($this->container['address_line1'] === null) {
            $invalidProperties[] = "'address_line1' can't be null";
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
     * Gets address_type
     *
     * @return string
     */
    public function getAddressType()
    {
        return $this->container['address_type'];
    }

    /**
     * Sets address_type
     *
     * @param string $address_type Type of address. Ex: Residential, commercial, etc. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get possible value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setAddressType($address_type)
    {
        $this->container['address_type'] = $address_type;

        return $this;
    }

    /**
     * Gets address_line1
     *
     * @return string
     */
    public function getAddressLine1()
    {
        return $this->container['address_line1'];
    }

    /**
     * Sets address_line1
     *
     * @param string $address_line1 Address line 1
     *
     * @return $this
     */
    public function setAddressLine1($address_line1)
    {
        $this->container['address_line1'] = $address_line1;

        return $this;
    }

    /**
     * Gets address_line2
     *
     * @return string
     */
    public function getAddressLine2()
    {
        return $this->container['address_line2'];
    }

    /**
     * Sets address_line2
     *
     * @param string $address_line2 Address line 2
     *
     * @return $this
     */
    public function setAddressLine2($address_line2)
    {
        $this->container['address_line2'] = $address_line2;

        return $this;
    }

    /**
     * Gets address_line3
     *
     * @return string
     */
    public function getAddressLine3()
    {
        return $this->container['address_line3'];
    }

    /**
     * Sets address_line3
     *
     * @param string $address_line3 Address line 3
     *
     * @return $this
     */
    public function setAddressLine3($address_line3)
    {
        $this->container['address_line3'] = $address_line3;

        return $this;
    }

    /**
     * Gets address_line4
     *
     * @return string
     */
    public function getAddressLine4()
    {
        return $this->container['address_line4'];
    }

    /**
     * Sets address_line4
     *
     * @param string $address_line4 Address line 4
     *
     * @return $this
     */
    public function setAddressLine4($address_line4)
    {
        $this->container['address_line4'] = $address_line4;

        return $this;
    }

    /**
     * Gets city_name
     *
     * @return string
     */
    public function getCityName()
    {
        return $this->container['city_name'];
    }

    /**
     * Sets city_name
     *
     * @param string $city_name City
     *
     * @return $this
     */
    public function setCityName($city_name)
    {
        $this->container['city_name'] = $city_name;

        return $this;
    }

    /**
     * Gets state
     *
     * @return string
     */
    public function getState()
    {
        return $this->container['state'];
    }

    /**
     * Sets state
     *
     * @param string $state State
     *
     * @return $this
     */
    public function setState($state)
    {
        $this->container['state'] = $state;

        return $this;
    }

    /**
     * Gets postal_code
     *
     * @return string
     */
    public function getPostalCode()
    {
        return $this->container['postal_code'];
    }

    /**
     * Sets postal_code
     *
     * @param string $postal_code Postal/ZIP code
     *
     * @return $this
     */
    public function setPostalCode($postal_code)
    {
        $this->container['postal_code'] = $postal_code;

        return $this;
    }

    /**
     * Gets province_code
     *
     * @return string
     */
    public function getProvinceCode()
    {
        return $this->container['province_code'];
    }

    /**
     * Sets province_code
     *
     * @param string $province_code Province code
     *
     * @return $this
     */
    public function setProvinceCode($province_code)
    {
        $this->container['province_code'] = $province_code;

        return $this;
    }

    /**
     * Gets country_code
     *
     * @return string
     */
    public function getCountryCode()
    {
        return $this->container['country_code'];
    }

    /**
     * Sets country_code
     *
     * @param string $country_code ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get possible value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setCountryCode($country_code)
    {
        $this->container['country_code'] = $country_code;

        return $this;
    }

    /**
     * Gets ok_to_mail
     *
     * @return bool
     */
    public function getOkToMail()
    {
        return $this->container['ok_to_mail'];
    }

    /**
     * Sets ok_to_mail
     *
     * @param bool $ok_to_mail To indicate whether the prospect is ok to be sent mails. Valid values: true and false
     *
     * @return $this
     */
    public function setOkToMail($ok_to_mail)
    {
        $this->container['ok_to_mail'] = $ok_to_mail;

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
