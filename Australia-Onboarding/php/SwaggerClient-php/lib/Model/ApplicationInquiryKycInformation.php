<?php
/**
 * ApplicationInquiryKycInformation
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
 * ApplicationInquiryKycInformation Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquiryKycInformation implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquiryKycInformation';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'self_public_figure_declaration_flag' => 'bool',
'public_figure_office_status' => 'string',
'public_figure_office_details' => 'string',
'public_figure_office_start_date' => '\DateTime',
'public_figure_office_end_date' => '\DateTime',
'is_related_to_senior_public_figure' => 'bool',
'related_senior_public_figure_name' => 'string',
'related_senior_public_figure_designation' => 'string',
'related_spf_country_of_government' => 'string',
'related_senior_public_figure_department' => 'string',
'relationship_with_senior_public_figure' => 'string',
'related_senior_public_figure_last_name' => 'string',
'us_tax_status' => 'string',
'us_tax_id' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'self_public_figure_declaration_flag' => null,
'public_figure_office_status' => null,
'public_figure_office_details' => null,
'public_figure_office_start_date' => 'date',
'public_figure_office_end_date' => 'date',
'is_related_to_senior_public_figure' => null,
'related_senior_public_figure_name' => null,
'related_senior_public_figure_designation' => null,
'related_spf_country_of_government' => null,
'related_senior_public_figure_department' => null,
'relationship_with_senior_public_figure' => null,
'related_senior_public_figure_last_name' => null,
'us_tax_status' => null,
'us_tax_id' => null    ];

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
        'self_public_figure_declaration_flag' => 'selfPublicFigureDeclarationFlag',
'public_figure_office_status' => 'publicFigureOfficeStatus',
'public_figure_office_details' => 'publicFigureOfficeDetails',
'public_figure_office_start_date' => 'publicFigureOfficeStartDate',
'public_figure_office_end_date' => 'publicFigureOfficeEndDate',
'is_related_to_senior_public_figure' => 'isRelatedToSeniorPublicFigure',
'related_senior_public_figure_name' => 'relatedSeniorPublicFigureName',
'related_senior_public_figure_designation' => 'relatedSeniorPublicFigureDesignation',
'related_spf_country_of_government' => 'relatedSpfCountryOfGovernment',
'related_senior_public_figure_department' => 'relatedSeniorPublicFigureDepartment',
'relationship_with_senior_public_figure' => 'relationshipWithSeniorPublicFigure',
'related_senior_public_figure_last_name' => 'relatedSeniorPublicFigureLastName',
'us_tax_status' => 'usTaxStatus',
'us_tax_id' => 'usTaxId'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'self_public_figure_declaration_flag' => 'setSelfPublicFigureDeclarationFlag',
'public_figure_office_status' => 'setPublicFigureOfficeStatus',
'public_figure_office_details' => 'setPublicFigureOfficeDetails',
'public_figure_office_start_date' => 'setPublicFigureOfficeStartDate',
'public_figure_office_end_date' => 'setPublicFigureOfficeEndDate',
'is_related_to_senior_public_figure' => 'setIsRelatedToSeniorPublicFigure',
'related_senior_public_figure_name' => 'setRelatedSeniorPublicFigureName',
'related_senior_public_figure_designation' => 'setRelatedSeniorPublicFigureDesignation',
'related_spf_country_of_government' => 'setRelatedSpfCountryOfGovernment',
'related_senior_public_figure_department' => 'setRelatedSeniorPublicFigureDepartment',
'relationship_with_senior_public_figure' => 'setRelationshipWithSeniorPublicFigure',
'related_senior_public_figure_last_name' => 'setRelatedSeniorPublicFigureLastName',
'us_tax_status' => 'setUsTaxStatus',
'us_tax_id' => 'setUsTaxId'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'self_public_figure_declaration_flag' => 'getSelfPublicFigureDeclarationFlag',
'public_figure_office_status' => 'getPublicFigureOfficeStatus',
'public_figure_office_details' => 'getPublicFigureOfficeDetails',
'public_figure_office_start_date' => 'getPublicFigureOfficeStartDate',
'public_figure_office_end_date' => 'getPublicFigureOfficeEndDate',
'is_related_to_senior_public_figure' => 'getIsRelatedToSeniorPublicFigure',
'related_senior_public_figure_name' => 'getRelatedSeniorPublicFigureName',
'related_senior_public_figure_designation' => 'getRelatedSeniorPublicFigureDesignation',
'related_spf_country_of_government' => 'getRelatedSpfCountryOfGovernment',
'related_senior_public_figure_department' => 'getRelatedSeniorPublicFigureDepartment',
'relationship_with_senior_public_figure' => 'getRelationshipWithSeniorPublicFigure',
'related_senior_public_figure_last_name' => 'getRelatedSeniorPublicFigureLastName',
'us_tax_status' => 'getUsTaxStatus',
'us_tax_id' => 'getUsTaxId'    ];

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
        $this->container['self_public_figure_declaration_flag'] = isset($data['self_public_figure_declaration_flag']) ? $data['self_public_figure_declaration_flag'] : null;
        $this->container['public_figure_office_status'] = isset($data['public_figure_office_status']) ? $data['public_figure_office_status'] : null;
        $this->container['public_figure_office_details'] = isset($data['public_figure_office_details']) ? $data['public_figure_office_details'] : null;
        $this->container['public_figure_office_start_date'] = isset($data['public_figure_office_start_date']) ? $data['public_figure_office_start_date'] : null;
        $this->container['public_figure_office_end_date'] = isset($data['public_figure_office_end_date']) ? $data['public_figure_office_end_date'] : null;
        $this->container['is_related_to_senior_public_figure'] = isset($data['is_related_to_senior_public_figure']) ? $data['is_related_to_senior_public_figure'] : null;
        $this->container['related_senior_public_figure_name'] = isset($data['related_senior_public_figure_name']) ? $data['related_senior_public_figure_name'] : null;
        $this->container['related_senior_public_figure_designation'] = isset($data['related_senior_public_figure_designation']) ? $data['related_senior_public_figure_designation'] : null;
        $this->container['related_spf_country_of_government'] = isset($data['related_spf_country_of_government']) ? $data['related_spf_country_of_government'] : null;
        $this->container['related_senior_public_figure_department'] = isset($data['related_senior_public_figure_department']) ? $data['related_senior_public_figure_department'] : null;
        $this->container['relationship_with_senior_public_figure'] = isset($data['relationship_with_senior_public_figure']) ? $data['relationship_with_senior_public_figure'] : null;
        $this->container['related_senior_public_figure_last_name'] = isset($data['related_senior_public_figure_last_name']) ? $data['related_senior_public_figure_last_name'] : null;
        $this->container['us_tax_status'] = isset($data['us_tax_status']) ? $data['us_tax_status'] : null;
        $this->container['us_tax_id'] = isset($data['us_tax_id']) ? $data['us_tax_id'] : null;
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
     * Gets self_public_figure_declaration_flag
     *
     * @return bool
     */
    public function getSelfPublicFigureDeclarationFlag()
    {
        return $this->container['self_public_figure_declaration_flag'];
    }

    /**
     * Sets self_public_figure_declaration_flag
     *
     * @param bool $self_public_figure_declaration_flag Flag for self declaration if applicant is public figure. Valid values: true and false
     *
     * @return $this
     */
    public function setSelfPublicFigureDeclarationFlag($self_public_figure_declaration_flag)
    {
        $this->container['self_public_figure_declaration_flag'] = $self_public_figure_declaration_flag;

        return $this;
    }

    /**
     * Gets public_figure_office_status
     *
     * @return string
     */
    public function getPublicFigureOfficeStatus()
    {
        return $this->container['public_figure_office_status'];
    }

    /**
     * Sets public_figure_office_status
     *
     * @param string $public_figure_office_status Flag for status of public office if applicant is public figure
     *
     * @return $this
     */
    public function setPublicFigureOfficeStatus($public_figure_office_status)
    {
        $this->container['public_figure_office_status'] = $public_figure_office_status;

        return $this;
    }

    /**
     * Gets public_figure_office_details
     *
     * @return string
     */
    public function getPublicFigureOfficeDetails()
    {
        return $this->container['public_figure_office_details'];
    }

    /**
     * Sets public_figure_office_details
     *
     * @param string $public_figure_office_details Office details if applicant is public figure
     *
     * @return $this
     */
    public function setPublicFigureOfficeDetails($public_figure_office_details)
    {
        $this->container['public_figure_office_details'] = $public_figure_office_details;

        return $this;
    }

    /**
     * Gets public_figure_office_start_date
     *
     * @return \DateTime
     */
    public function getPublicFigureOfficeStartDate()
    {
        return $this->container['public_figure_office_start_date'];
    }

    /**
     * Sets public_figure_office_start_date
     *
     * @param \DateTime $public_figure_office_start_date Public figure office start date in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setPublicFigureOfficeStartDate($public_figure_office_start_date)
    {
        $this->container['public_figure_office_start_date'] = $public_figure_office_start_date;

        return $this;
    }

    /**
     * Gets public_figure_office_end_date
     *
     * @return \DateTime
     */
    public function getPublicFigureOfficeEndDate()
    {
        return $this->container['public_figure_office_end_date'];
    }

    /**
     * Sets public_figure_office_end_date
     *
     * @param \DateTime $public_figure_office_end_date Public figure office end date in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setPublicFigureOfficeEndDate($public_figure_office_end_date)
    {
        $this->container['public_figure_office_end_date'] = $public_figure_office_end_date;

        return $this;
    }

    /**
     * Gets is_related_to_senior_public_figure
     *
     * @return bool
     */
    public function getIsRelatedToSeniorPublicFigure()
    {
        return $this->container['is_related_to_senior_public_figure'];
    }

    /**
     * Sets is_related_to_senior_public_figure
     *
     * @param bool $is_related_to_senior_public_figure Self declaration if applicant has any relation with senior public figure. Valid values: true and false
     *
     * @return $this
     */
    public function setIsRelatedToSeniorPublicFigure($is_related_to_senior_public_figure)
    {
        $this->container['is_related_to_senior_public_figure'] = $is_related_to_senior_public_figure;

        return $this;
    }

    /**
     * Gets related_senior_public_figure_name
     *
     * @return string
     */
    public function getRelatedSeniorPublicFigureName()
    {
        return $this->container['related_senior_public_figure_name'];
    }

    /**
     * Sets related_senior_public_figure_name
     *
     * @param string $related_senior_public_figure_name Senior Public Figure Name
     *
     * @return $this
     */
    public function setRelatedSeniorPublicFigureName($related_senior_public_figure_name)
    {
        $this->container['related_senior_public_figure_name'] = $related_senior_public_figure_name;

        return $this;
    }

    /**
     * Gets related_senior_public_figure_designation
     *
     * @return string
     */
    public function getRelatedSeniorPublicFigureDesignation()
    {
        return $this->container['related_senior_public_figure_designation'];
    }

    /**
     * Sets related_senior_public_figure_designation
     *
     * @param string $related_senior_public_figure_designation Public figure designation.
     *
     * @return $this
     */
    public function setRelatedSeniorPublicFigureDesignation($related_senior_public_figure_designation)
    {
        $this->container['related_senior_public_figure_designation'] = $related_senior_public_figure_designation;

        return $this;
    }

    /**
     * Gets related_spf_country_of_government
     *
     * @return string
     */
    public function getRelatedSpfCountryOfGovernment()
    {
        return $this->container['related_spf_country_of_government'];
    }

    /**
     * Sets related_spf_country_of_government
     *
     * @param string $related_spf_country_of_government Senior Public Figure Country of Government
     *
     * @return $this
     */
    public function setRelatedSpfCountryOfGovernment($related_spf_country_of_government)
    {
        $this->container['related_spf_country_of_government'] = $related_spf_country_of_government;

        return $this;
    }

    /**
     * Gets related_senior_public_figure_department
     *
     * @return string
     */
    public function getRelatedSeniorPublicFigureDepartment()
    {
        return $this->container['related_senior_public_figure_department'];
    }

    /**
     * Sets related_senior_public_figure_department
     *
     * @param string $related_senior_public_figure_department Department Senior Public Figure belongs to
     *
     * @return $this
     */
    public function setRelatedSeniorPublicFigureDepartment($related_senior_public_figure_department)
    {
        $this->container['related_senior_public_figure_department'] = $related_senior_public_figure_department;

        return $this;
    }

    /**
     * Gets relationship_with_senior_public_figure
     *
     * @return string
     */
    public function getRelationshipWithSeniorPublicFigure()
    {
        return $this->container['relationship_with_senior_public_figure'];
    }

    /**
     * Sets relationship_with_senior_public_figure
     *
     * @param string $relationship_with_senior_public_figure Senior Public Figure relationship with applicant
     *
     * @return $this
     */
    public function setRelationshipWithSeniorPublicFigure($relationship_with_senior_public_figure)
    {
        $this->container['relationship_with_senior_public_figure'] = $relationship_with_senior_public_figure;

        return $this;
    }

    /**
     * Gets related_senior_public_figure_last_name
     *
     * @return string
     */
    public function getRelatedSeniorPublicFigureLastName()
    {
        return $this->container['related_senior_public_figure_last_name'];
    }

    /**
     * Sets related_senior_public_figure_last_name
     *
     * @param string $related_senior_public_figure_last_name Senior Public Figure Last Name
     *
     * @return $this
     */
    public function setRelatedSeniorPublicFigureLastName($related_senior_public_figure_last_name)
    {
        $this->container['related_senior_public_figure_last_name'] = $related_senior_public_figure_last_name;

        return $this;
    }

    /**
     * Gets us_tax_status
     *
     * @return string
     */
    public function getUsTaxStatus()
    {
        return $this->container['us_tax_status'];
    }

    /**
     * Sets us_tax_status
     *
     * @param string $us_tax_status US Tax status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setUsTaxStatus($us_tax_status)
    {
        $this->container['us_tax_status'] = $us_tax_status;

        return $this;
    }

    /**
     * Gets us_tax_id
     *
     * @return string
     */
    public function getUsTaxId()
    {
        return $this->container['us_tax_id'];
    }

    /**
     * Sets us_tax_id
     *
     * @param string $us_tax_id US Tax ID
     *
     * @return $this
     */
    public function setUsTaxId($us_tax_id)
    {
        $this->container['us_tax_id'] = $us_tax_id;

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
