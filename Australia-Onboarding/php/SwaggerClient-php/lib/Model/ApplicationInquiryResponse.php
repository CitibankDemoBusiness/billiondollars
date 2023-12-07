<?php
/**
 * ApplicationInquiryResponse
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
 * ApplicationInquiryResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquiryResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquiryResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'application_stage' => 'string',
'has_any_supplementary_flag' => 'bool',
'ipa_expiry_date' => '\DateTime',
'product' => '\Swagger\Client\Model\ApplicationInquiryProduct',
'applicant' => '\Swagger\Client\Model\ApplicationInquiryApplicant',
'requested_product_decision' => '\Swagger\Client\Model\ApplicationInquiryRequestedProductDecision[]',
'counter_offers' => '\Swagger\Client\Model\ApplicationInquiryCounterOffer[]',
'cross_sell_offers' => '\Swagger\Client\Model\ApplicationInquiryCrossSellOffer[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'application_stage' => null,
'has_any_supplementary_flag' => null,
'ipa_expiry_date' => 'date',
'product' => null,
'applicant' => null,
'requested_product_decision' => null,
'counter_offers' => null,
'cross_sell_offers' => null    ];

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
        'application_stage' => 'applicationStage',
'has_any_supplementary_flag' => 'hasAnySupplementaryFlag',
'ipa_expiry_date' => 'ipaExpiryDate',
'product' => 'product',
'applicant' => 'applicant',
'requested_product_decision' => 'requestedProductDecision',
'counter_offers' => 'counterOffers',
'cross_sell_offers' => 'crossSellOffers'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'application_stage' => 'setApplicationStage',
'has_any_supplementary_flag' => 'setHasAnySupplementaryFlag',
'ipa_expiry_date' => 'setIpaExpiryDate',
'product' => 'setProduct',
'applicant' => 'setApplicant',
'requested_product_decision' => 'setRequestedProductDecision',
'counter_offers' => 'setCounterOffers',
'cross_sell_offers' => 'setCrossSellOffers'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'application_stage' => 'getApplicationStage',
'has_any_supplementary_flag' => 'getHasAnySupplementaryFlag',
'ipa_expiry_date' => 'getIpaExpiryDate',
'product' => 'getProduct',
'applicant' => 'getApplicant',
'requested_product_decision' => 'getRequestedProductDecision',
'counter_offers' => 'getCounterOffers',
'cross_sell_offers' => 'getCrossSellOffers'    ];

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
        $this->container['application_stage'] = isset($data['application_stage']) ? $data['application_stage'] : null;
        $this->container['has_any_supplementary_flag'] = isset($data['has_any_supplementary_flag']) ? $data['has_any_supplementary_flag'] : null;
        $this->container['ipa_expiry_date'] = isset($data['ipa_expiry_date']) ? $data['ipa_expiry_date'] : null;
        $this->container['product'] = isset($data['product']) ? $data['product'] : null;
        $this->container['applicant'] = isset($data['applicant']) ? $data['applicant'] : null;
        $this->container['requested_product_decision'] = isset($data['requested_product_decision']) ? $data['requested_product_decision'] : null;
        $this->container['counter_offers'] = isset($data['counter_offers']) ? $data['counter_offers'] : null;
        $this->container['cross_sell_offers'] = isset($data['cross_sell_offers']) ? $data['cross_sell_offers'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['application_stage'] === null) {
            $invalidProperties[] = "'application_stage' can't be null";
        }
        if ($this->container['product'] === null) {
            $invalidProperties[] = "'product' can't be null";
        }
        if ($this->container['applicant'] === null) {
            $invalidProperties[] = "'applicant' can't be null";
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
     * Gets application_stage
     *
     * @return string
     */
    public function getApplicationStage()
    {
        return $this->container['application_stage'];
    }

    /**
     * Sets application_stage
     *
     * @param string $application_stage Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setApplicationStage($application_stage)
    {
        $this->container['application_stage'] = $application_stage;

        return $this;
    }

    /**
     * Gets has_any_supplementary_flag
     *
     * @return bool
     */
    public function getHasAnySupplementaryFlag()
    {
        return $this->container['has_any_supplementary_flag'];
    }

    /**
     * Sets has_any_supplementary_flag
     *
     * @param bool $has_any_supplementary_flag Flag indicating whether the primary applicant has any supplementary.
     *
     * @return $this
     */
    public function setHasAnySupplementaryFlag($has_any_supplementary_flag)
    {
        $this->container['has_any_supplementary_flag'] = $has_any_supplementary_flag;

        return $this;
    }

    /**
     * Gets ipa_expiry_date
     *
     * @return \DateTime
     */
    public function getIpaExpiryDate()
    {
        return $this->container['ipa_expiry_date'];
    }

    /**
     * Sets ipa_expiry_date
     *
     * @param \DateTime $ipa_expiry_date In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setIpaExpiryDate($ipa_expiry_date)
    {
        $this->container['ipa_expiry_date'] = $ipa_expiry_date;

        return $this;
    }

    /**
     * Gets product
     *
     * @return \Swagger\Client\Model\ApplicationInquiryProduct
     */
    public function getProduct()
    {
        return $this->container['product'];
    }

    /**
     * Sets product
     *
     * @param \Swagger\Client\Model\ApplicationInquiryProduct $product product
     *
     * @return $this
     */
    public function setProduct($product)
    {
        $this->container['product'] = $product;

        return $this;
    }

    /**
     * Gets applicant
     *
     * @return \Swagger\Client\Model\ApplicationInquiryApplicant
     */
    public function getApplicant()
    {
        return $this->container['applicant'];
    }

    /**
     * Sets applicant
     *
     * @param \Swagger\Client\Model\ApplicationInquiryApplicant $applicant applicant
     *
     * @return $this
     */
    public function setApplicant($applicant)
    {
        $this->container['applicant'] = $applicant;

        return $this;
    }

    /**
     * Gets requested_product_decision
     *
     * @return \Swagger\Client\Model\ApplicationInquiryRequestedProductDecision[]
     */
    public function getRequestedProductDecision()
    {
        return $this->container['requested_product_decision'];
    }

    /**
     * Sets requested_product_decision
     *
     * @param \Swagger\Client\Model\ApplicationInquiryRequestedProductDecision[] $requested_product_decision requested_product_decision
     *
     * @return $this
     */
    public function setRequestedProductDecision($requested_product_decision)
    {
        $this->container['requested_product_decision'] = $requested_product_decision;

        return $this;
    }

    /**
     * Gets counter_offers
     *
     * @return \Swagger\Client\Model\ApplicationInquiryCounterOffer[]
     */
    public function getCounterOffers()
    {
        return $this->container['counter_offers'];
    }

    /**
     * Sets counter_offers
     *
     * @param \Swagger\Client\Model\ApplicationInquiryCounterOffer[] $counter_offers counter_offers
     *
     * @return $this
     */
    public function setCounterOffers($counter_offers)
    {
        $this->container['counter_offers'] = $counter_offers;

        return $this;
    }

    /**
     * Gets cross_sell_offers
     *
     * @return \Swagger\Client\Model\ApplicationInquiryCrossSellOffer[]
     */
    public function getCrossSellOffers()
    {
        return $this->container['cross_sell_offers'];
    }

    /**
     * Sets cross_sell_offers
     *
     * @param \Swagger\Client\Model\ApplicationInquiryCrossSellOffer[] $cross_sell_offers cross_sell_offers
     *
     * @return $this
     */
    public function setCrossSellOffers($cross_sell_offers)
    {
        $this->container['cross_sell_offers'] = $cross_sell_offers;

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
