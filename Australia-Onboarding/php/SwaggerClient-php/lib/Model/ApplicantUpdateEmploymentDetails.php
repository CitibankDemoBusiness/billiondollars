<?php
/**
 * ApplicantUpdateEmploymentDetails
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
 * ApplicantUpdateEmploymentDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicantUpdateEmploymentDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicantUpdateEmploymentDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'employment_duration_in_years' => 'int',
'employment_durationi_in_months' => 'int',
'employer_name' => 'string',
'job_title' => 'string',
'occupation_code' => 'string',
'employment_status' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'employment_duration_in_years' => 'int32',
'employment_durationi_in_months' => 'int32',
'employer_name' => null,
'job_title' => null,
'occupation_code' => null,
'employment_status' => null    ];

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
        'employment_duration_in_years' => 'employmentDurationInYears',
'employment_durationi_in_months' => 'employmentDurationiInMonths',
'employer_name' => 'employerName',
'job_title' => 'jobTitle',
'occupation_code' => 'occupationCode',
'employment_status' => 'employmentStatus'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'employment_duration_in_years' => 'setEmploymentDurationInYears',
'employment_durationi_in_months' => 'setEmploymentDurationiInMonths',
'employer_name' => 'setEmployerName',
'job_title' => 'setJobTitle',
'occupation_code' => 'setOccupationCode',
'employment_status' => 'setEmploymentStatus'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'employment_duration_in_years' => 'getEmploymentDurationInYears',
'employment_durationi_in_months' => 'getEmploymentDurationiInMonths',
'employer_name' => 'getEmployerName',
'job_title' => 'getJobTitle',
'occupation_code' => 'getOccupationCode',
'employment_status' => 'getEmploymentStatus'    ];

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
        $this->container['employment_duration_in_years'] = isset($data['employment_duration_in_years']) ? $data['employment_duration_in_years'] : null;
        $this->container['employment_durationi_in_months'] = isset($data['employment_durationi_in_months']) ? $data['employment_durationi_in_months'] : null;
        $this->container['employer_name'] = isset($data['employer_name']) ? $data['employer_name'] : null;
        $this->container['job_title'] = isset($data['job_title']) ? $data['job_title'] : null;
        $this->container['occupation_code'] = isset($data['occupation_code']) ? $data['occupation_code'] : null;
        $this->container['employment_status'] = isset($data['employment_status']) ? $data['employment_status'] : null;
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
     * Gets employment_duration_in_years
     *
     * @return int
     */
    public function getEmploymentDurationInYears()
    {
        return $this->container['employment_duration_in_years'];
    }

    /**
     * Sets employment_duration_in_years
     *
     * @param int $employment_duration_in_years Employment duration in years
     *
     * @return $this
     */
    public function setEmploymentDurationInYears($employment_duration_in_years)
    {
        $this->container['employment_duration_in_years'] = $employment_duration_in_years;

        return $this;
    }

    /**
     * Gets employment_durationi_in_months
     *
     * @return int
     */
    public function getEmploymentDurationiInMonths()
    {
        return $this->container['employment_durationi_in_months'];
    }

    /**
     * Sets employment_durationi_in_months
     *
     * @param int $employment_durationi_in_months Employment duration in months
     *
     * @return $this
     */
    public function setEmploymentDurationiInMonths($employment_durationi_in_months)
    {
        $this->container['employment_durationi_in_months'] = $employment_durationi_in_months;

        return $this;
    }

    /**
     * Gets employer_name
     *
     * @return string
     */
    public function getEmployerName()
    {
        return $this->container['employer_name'];
    }

    /**
     * Sets employer_name
     *
     * @param string $employer_name Name of the employer.
     *
     * @return $this
     */
    public function setEmployerName($employer_name)
    {
        $this->container['employer_name'] = $employer_name;

        return $this;
    }

    /**
     * Gets job_title
     *
     * @return string
     */
    public function getJobTitle()
    {
        return $this->container['job_title'];
    }

    /**
     * Sets job_title
     *
     * @param string $job_title Job Title. This a reference data field. Please use /utilities/referenceData/{jobTitle} resource to get valid values of this field with descriptions. You can use the jobTitle as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setJobTitle($job_title)
    {
        $this->container['job_title'] = $job_title;

        return $this;
    }

    /**
     * Gets occupation_code
     *
     * @return string
     */
    public function getOccupationCode()
    {
        return $this->container['occupation_code'];
    }

    /**
     * Sets occupation_code
     *
     * @param string $occupation_code Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions. You can use the occupationCode as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setOccupationCode($occupation_code)
    {
        $this->container['occupation_code'] = $occupation_code;

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
     * @param string $employment_status Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setEmploymentStatus($employment_status)
    {
        $this->container['employment_status'] = $employment_status;

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