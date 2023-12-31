<?php
/**
 * DataRequirementsApplicant
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
 * DataRequirementsApplicant Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class DataRequirementsApplicant implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'data_requirements_applicant';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'application_type' => 'string',
'employment_status' => 'string',
'min_age' => 'int',
'max_age' => 'int',
'min_annual_income' => 'int',
'min_annual_income_currency_code' => 'string',
'document' => '\Swagger\Client\Model\DataRequirementsDocument[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'application_type' => null,
'employment_status' => null,
'min_age' => null,
'max_age' => null,
'min_annual_income' => null,
'min_annual_income_currency_code' => null,
'document' => null    ];

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
        'application_type' => 'application_type',
'employment_status' => 'employment_status',
'min_age' => 'min_age',
'max_age' => 'max_age',
'min_annual_income' => 'min_annual_income',
'min_annual_income_currency_code' => 'min_annual_income_currency_code',
'document' => 'document'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'application_type' => 'setApplicationType',
'employment_status' => 'setEmploymentStatus',
'min_age' => 'setMinAge',
'max_age' => 'setMaxAge',
'min_annual_income' => 'setMinAnnualIncome',
'min_annual_income_currency_code' => 'setMinAnnualIncomeCurrencyCode',
'document' => 'setDocument'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'application_type' => 'getApplicationType',
'employment_status' => 'getEmploymentStatus',
'min_age' => 'getMinAge',
'max_age' => 'getMaxAge',
'min_annual_income' => 'getMinAnnualIncome',
'min_annual_income_currency_code' => 'getMinAnnualIncomeCurrencyCode',
'document' => 'getDocument'    ];

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

    const APPLICATION_TYPE_PRINCIPAL = 'principal';
const APPLICATION_TYPE_SUPPLEMENTARY = 'supplementary';
const APPLICATION_TYPE_ANY = 'any';
const EMPLOYMENT_STATUS_EMPLOYED = 'employed';
const EMPLOYMENT_STATUS_SELF_EMPLOYED = 'self_employed';
const EMPLOYMENT_STATUS_GRADUATE = 'graduate';
const EMPLOYMENT_STATUS_OTHERS = 'others';
const EMPLOYMENT_STATUS_ANY = 'any';

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getApplicationTypeAllowableValues()
    {
        return [
            self::APPLICATION_TYPE_PRINCIPAL,
self::APPLICATION_TYPE_SUPPLEMENTARY,
self::APPLICATION_TYPE_ANY,        ];
    }
    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getEmploymentStatusAllowableValues()
    {
        return [
            self::EMPLOYMENT_STATUS_EMPLOYED,
self::EMPLOYMENT_STATUS_SELF_EMPLOYED,
self::EMPLOYMENT_STATUS_GRADUATE,
self::EMPLOYMENT_STATUS_OTHERS,
self::EMPLOYMENT_STATUS_ANY,        ];
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
        $this->container['application_type'] = isset($data['application_type']) ? $data['application_type'] : null;
        $this->container['employment_status'] = isset($data['employment_status']) ? $data['employment_status'] : null;
        $this->container['min_age'] = isset($data['min_age']) ? $data['min_age'] : null;
        $this->container['max_age'] = isset($data['max_age']) ? $data['max_age'] : null;
        $this->container['min_annual_income'] = isset($data['min_annual_income']) ? $data['min_annual_income'] : null;
        $this->container['min_annual_income_currency_code'] = isset($data['min_annual_income_currency_code']) ? $data['min_annual_income_currency_code'] : 'MYR';
        $this->container['document'] = isset($data['document']) ? $data['document'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['application_type'] === null) {
            $invalidProperties[] = "'application_type' can't be null";
        }
        $allowedValues = $this->getApplicationTypeAllowableValues();
        if (!is_null($this->container['application_type']) && !in_array($this->container['application_type'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value for 'application_type', must be one of '%s'",
                implode("', '", $allowedValues)
            );
        }

        $allowedValues = $this->getEmploymentStatusAllowableValues();
        if (!is_null($this->container['employment_status']) && !in_array($this->container['employment_status'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value for 'employment_status', must be one of '%s'",
                implode("', '", $allowedValues)
            );
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
     * Gets application_type
     *
     * @return string
     */
    public function getApplicationType()
    {
        return $this->container['application_type'];
    }

    /**
     * Sets application_type
     *
     * @param string $application_type Type of the card application
     *
     * @return $this
     */
    public function setApplicationType($application_type)
    {
        $allowedValues = $this->getApplicationTypeAllowableValues();
        if (!in_array($application_type, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value for 'application_type', must be one of '%s'",
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['application_type'] = $application_type;

        return $this;
    }

    /**
     * Gets employment_status
     *
     * @return string
     */
    public function getEmploymentStatus()
    {
        return $this->container['employment_status'];
    }

    /**
     * Sets employment_status
     *
     * @param string $employment_status Employment status of the applicant
     *
     * @return $this
     */
    public function setEmploymentStatus($employment_status)
    {
        $allowedValues = $this->getEmploymentStatusAllowableValues();
        if (!is_null($employment_status) && !in_array($employment_status, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value for 'employment_status', must be one of '%s'",
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['employment_status'] = $employment_status;

        return $this;
    }

    /**
     * Gets min_age
     *
     * @return int
     */
    public function getMinAge()
    {
        return $this->container['min_age'];
    }

    /**
     * Sets min_age
     *
     * @param int $min_age Minimum age of applicant
     *
     * @return $this
     */
    public function setMinAge($min_age)
    {
        $this->container['min_age'] = $min_age;

        return $this;
    }

    /**
     * Gets max_age
     *
     * @return int
     */
    public function getMaxAge()
    {
        return $this->container['max_age'];
    }

    /**
     * Sets max_age
     *
     * @param int $max_age Maximum age of applicant
     *
     * @return $this
     */
    public function setMaxAge($max_age)
    {
        $this->container['max_age'] = $max_age;

        return $this;
    }

    /**
     * Gets min_annual_income
     *
     * @return int
     */
    public function getMinAnnualIncome()
    {
        return $this->container['min_annual_income'];
    }

    /**
     * Sets min_annual_income
     *
     * @param int $min_annual_income Minimum annual income
     *
     * @return $this
     */
    public function setMinAnnualIncome($min_annual_income)
    {
        $this->container['min_annual_income'] = $min_annual_income;

        return $this;
    }

    /**
     * Gets min_annual_income_currency_code
     *
     * @return string
     */
    public function getMinAnnualIncomeCurrencyCode()
    {
        return $this->container['min_annual_income_currency_code'];
    }

    /**
     * Sets min_annual_income_currency_code
     *
     * @param string $min_annual_income_currency_code ISO-4217 3 characters currency code for minimum annual income
     *
     * @return $this
     */
    public function setMinAnnualIncomeCurrencyCode($min_annual_income_currency_code)
    {
        $this->container['min_annual_income_currency_code'] = $min_annual_income_currency_code;

        return $this;
    }

    /**
     * Gets document
     *
     * @return \Swagger\Client\Model\DataRequirementsDocument[]
     */
    public function getDocument()
    {
        return $this->container['document'];
    }

    /**
     * Sets document
     *
     * @param \Swagger\Client\Model\DataRequirementsDocument[] $document document
     *
     * @return $this
     */
    public function setDocument($document)
    {
        $this->container['document'] = $document;

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
