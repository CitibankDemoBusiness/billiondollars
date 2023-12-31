<?php
/**
 * ApplicationInquiryCounterOffer
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
 * ApplicationInquiryCounterOffer Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquiryCounterOffer implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquiryCounterOffer';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'offer_product_code' => 'string',
'offer_product_organisation' => 'string',
'offer_source_code' => 'string',
'credit_specific_recommendations' => '\Swagger\Client\Model\ApplicationInquiryCreditSpecificRecommendations[]',
'loan_specific_recommendations' => '\Swagger\Client\Model\ApplicationInquiryLoanSpecificRecommendations[]',
'required_documents' => '\Swagger\Client\Model\ApplicationInquiryRequiredDocuments[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'offer_product_code' => null,
'offer_product_organisation' => null,
'offer_source_code' => null,
'credit_specific_recommendations' => null,
'loan_specific_recommendations' => null,
'required_documents' => null    ];

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
        'offer_product_code' => 'offerProductCode',
'offer_product_organisation' => 'offerProductOrganisation',
'offer_source_code' => 'offerSourceCode',
'credit_specific_recommendations' => 'creditSpecificRecommendations',
'loan_specific_recommendations' => 'loanSpecificRecommendations',
'required_documents' => 'requiredDocuments'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'offer_product_code' => 'setOfferProductCode',
'offer_product_organisation' => 'setOfferProductOrganisation',
'offer_source_code' => 'setOfferSourceCode',
'credit_specific_recommendations' => 'setCreditSpecificRecommendations',
'loan_specific_recommendations' => 'setLoanSpecificRecommendations',
'required_documents' => 'setRequiredDocuments'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'offer_product_code' => 'getOfferProductCode',
'offer_product_organisation' => 'getOfferProductOrganisation',
'offer_source_code' => 'getOfferSourceCode',
'credit_specific_recommendations' => 'getCreditSpecificRecommendations',
'loan_specific_recommendations' => 'getLoanSpecificRecommendations',
'required_documents' => 'getRequiredDocuments'    ];

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
        $this->container['offer_product_code'] = isset($data['offer_product_code']) ? $data['offer_product_code'] : null;
        $this->container['offer_product_organisation'] = isset($data['offer_product_organisation']) ? $data['offer_product_organisation'] : null;
        $this->container['offer_source_code'] = isset($data['offer_source_code']) ? $data['offer_source_code'] : null;
        $this->container['credit_specific_recommendations'] = isset($data['credit_specific_recommendations']) ? $data['credit_specific_recommendations'] : null;
        $this->container['loan_specific_recommendations'] = isset($data['loan_specific_recommendations']) ? $data['loan_specific_recommendations'] : null;
        $this->container['required_documents'] = isset($data['required_documents']) ? $data['required_documents'] : null;
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
     * Gets offer_product_code
     *
     * @return string
     */
    public function getOfferProductCode()
    {
        return $this->container['offer_product_code'];
    }

    /**
     * Sets offer_product_code
     *
     * @param string $offer_product_code A unique code that identifies the offered product to applicant
     *
     * @return $this
     */
    public function setOfferProductCode($offer_product_code)
    {
        $this->container['offer_product_code'] = $offer_product_code;

        return $this;
    }

    /**
     * Gets offer_product_organisation
     *
     * @return string
     */
    public function getOfferProductOrganisation()
    {
        return $this->container['offer_product_organisation'];
    }

    /**
     * Sets offer_product_organisation
     *
     * @param string $offer_product_organisation Offered card issuing organization name
     *
     * @return $this
     */
    public function setOfferProductOrganisation($offer_product_organisation)
    {
        $this->container['offer_product_organisation'] = $offer_product_organisation;

        return $this;
    }

    /**
     * Gets offer_source_code
     *
     * @return string
     */
    public function getOfferSourceCode()
    {
        return $this->container['offer_source_code'];
    }

    /**
     * Sets offer_source_code
     *
     * @param string $offer_source_code A source code to identify the product
     *
     * @return $this
     */
    public function setOfferSourceCode($offer_source_code)
    {
        $this->container['offer_source_code'] = $offer_source_code;

        return $this;
    }

    /**
     * Gets credit_specific_recommendations
     *
     * @return \Swagger\Client\Model\ApplicationInquiryCreditSpecificRecommendations[]
     */
    public function getCreditSpecificRecommendations()
    {
        return $this->container['credit_specific_recommendations'];
    }

    /**
     * Sets credit_specific_recommendations
     *
     * @param \Swagger\Client\Model\ApplicationInquiryCreditSpecificRecommendations[] $credit_specific_recommendations credit_specific_recommendations
     *
     * @return $this
     */
    public function setCreditSpecificRecommendations($credit_specific_recommendations)
    {
        $this->container['credit_specific_recommendations'] = $credit_specific_recommendations;

        return $this;
    }

    /**
     * Gets loan_specific_recommendations
     *
     * @return \Swagger\Client\Model\ApplicationInquiryLoanSpecificRecommendations[]
     */
    public function getLoanSpecificRecommendations()
    {
        return $this->container['loan_specific_recommendations'];
    }

    /**
     * Sets loan_specific_recommendations
     *
     * @param \Swagger\Client\Model\ApplicationInquiryLoanSpecificRecommendations[] $loan_specific_recommendations loan_specific_recommendations
     *
     * @return $this
     */
    public function setLoanSpecificRecommendations($loan_specific_recommendations)
    {
        $this->container['loan_specific_recommendations'] = $loan_specific_recommendations;

        return $this;
    }

    /**
     * Gets required_documents
     *
     * @return \Swagger\Client\Model\ApplicationInquiryRequiredDocuments[]
     */
    public function getRequiredDocuments()
    {
        return $this->container['required_documents'];
    }

    /**
     * Sets required_documents
     *
     * @param \Swagger\Client\Model\ApplicationInquiryRequiredDocuments[] $required_documents required_documents
     *
     * @return $this
     */
    public function setRequiredDocuments($required_documents)
    {
        $this->container['required_documents'] = $required_documents;

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
