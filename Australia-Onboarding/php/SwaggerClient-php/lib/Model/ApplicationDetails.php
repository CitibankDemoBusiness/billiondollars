<?php
/**
 * ApplicationDetails
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
 * ApplicationDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'application_id' => 'string',
'product_code' => 'string',
'application_stage' => 'string',
'application_received_date' => '\DateTime',
'application_submitted_flag' => 'bool',
'ekyc_submitted_flag' => 'bool',
'marketing_campaign_offer_details' => '\Swagger\Client\Model\PendingMarketingCampaignOfferDetails'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'application_id' => null,
'product_code' => null,
'application_stage' => null,
'application_received_date' => 'date',
'application_submitted_flag' => null,
'ekyc_submitted_flag' => null,
'marketing_campaign_offer_details' => null    ];

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
        'application_id' => 'applicationId',
'product_code' => 'productCode',
'application_stage' => 'applicationStage',
'application_received_date' => 'applicationReceivedDate',
'application_submitted_flag' => 'applicationSubmittedFlag',
'ekyc_submitted_flag' => 'ekycSubmittedFlag',
'marketing_campaign_offer_details' => 'marketingCampaignOfferDetails'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'application_id' => 'setApplicationId',
'product_code' => 'setProductCode',
'application_stage' => 'setApplicationStage',
'application_received_date' => 'setApplicationReceivedDate',
'application_submitted_flag' => 'setApplicationSubmittedFlag',
'ekyc_submitted_flag' => 'setEkycSubmittedFlag',
'marketing_campaign_offer_details' => 'setMarketingCampaignOfferDetails'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'application_id' => 'getApplicationId',
'product_code' => 'getProductCode',
'application_stage' => 'getApplicationStage',
'application_received_date' => 'getApplicationReceivedDate',
'application_submitted_flag' => 'getApplicationSubmittedFlag',
'ekyc_submitted_flag' => 'getEkycSubmittedFlag',
'marketing_campaign_offer_details' => 'getMarketingCampaignOfferDetails'    ];

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
        $this->container['application_id'] = isset($data['application_id']) ? $data['application_id'] : null;
        $this->container['product_code'] = isset($data['product_code']) ? $data['product_code'] : null;
        $this->container['application_stage'] = isset($data['application_stage']) ? $data['application_stage'] : null;
        $this->container['application_received_date'] = isset($data['application_received_date']) ? $data['application_received_date'] : null;
        $this->container['application_submitted_flag'] = isset($data['application_submitted_flag']) ? $data['application_submitted_flag'] : null;
        $this->container['ekyc_submitted_flag'] = isset($data['ekyc_submitted_flag']) ? $data['ekyc_submitted_flag'] : null;
        $this->container['marketing_campaign_offer_details'] = isset($data['marketing_campaign_offer_details']) ? $data['marketing_campaign_offer_details'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['application_id'] === null) {
            $invalidProperties[] = "'application_id' can't be null";
        }
        if ($this->container['application_stage'] === null) {
            $invalidProperties[] = "'application_stage' can't be null";
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
     * Gets application_id
     *
     * @return string
     */
    public function getApplicationId()
    {
        return $this->container['application_id'];
    }

    /**
     * Sets application_id
     *
     * @param string $application_id Unique identifier for the application.
     *
     * @return $this
     */
    public function setApplicationId($application_id)
    {
        $this->container['application_id'] = $application_id;

        return $this;
    }

    /**
     * Gets product_code
     *
     * @return string
     */
    public function getProductCode()
    {
        return $this->container['product_code'];
    }

    /**
     * Sets product_code
     *
     * @param string $product_code A unique code that identifies the product.
     *
     * @return $this
     */
    public function setProductCode($product_code)
    {
        $this->container['product_code'] = $product_code;

        return $this;
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
     * @param string $application_stage Application Stage of an Application
     *
     * @return $this
     */
    public function setApplicationStage($application_stage)
    {
        $this->container['application_stage'] = $application_stage;

        return $this;
    }

    /**
     * Gets application_received_date
     *
     * @return \DateTime
     */
    public function getApplicationReceivedDate()
    {
        return $this->container['application_received_date'];
    }

    /**
     * Sets application_received_date
     *
     * @param \DateTime $application_received_date Application Received Date in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setApplicationReceivedDate($application_received_date)
    {
        $this->container['application_received_date'] = $application_received_date;

        return $this;
    }

    /**
     * Gets application_submitted_flag
     *
     * @return bool
     */
    public function getApplicationSubmittedFlag()
    {
        return $this->container['application_submitted_flag'];
    }

    /**
     * Sets application_submitted_flag
     *
     * @param bool $application_submitted_flag Flag to indicate if application is already submitted
     *
     * @return $this
     */
    public function setApplicationSubmittedFlag($application_submitted_flag)
    {
        $this->container['application_submitted_flag'] = $application_submitted_flag;

        return $this;
    }

    /**
     * Gets ekyc_submitted_flag
     *
     * @return bool
     */
    public function getEkycSubmittedFlag()
    {
        return $this->container['ekyc_submitted_flag'];
    }

    /**
     * Sets ekyc_submitted_flag
     *
     * @param bool $ekyc_submitted_flag Flag to indicate if eKYC request is already submitted
     *
     * @return $this
     */
    public function setEkycSubmittedFlag($ekyc_submitted_flag)
    {
        $this->container['ekyc_submitted_flag'] = $ekyc_submitted_flag;

        return $this;
    }

    /**
     * Gets marketing_campaign_offer_details
     *
     * @return \Swagger\Client\Model\PendingMarketingCampaignOfferDetails
     */
    public function getMarketingCampaignOfferDetails()
    {
        return $this->container['marketing_campaign_offer_details'];
    }

    /**
     * Sets marketing_campaign_offer_details
     *
     * @param \Swagger\Client\Model\PendingMarketingCampaignOfferDetails $marketing_campaign_offer_details marketing_campaign_offer_details
     *
     * @return $this
     */
    public function setMarketingCampaignOfferDetails($marketing_campaign_offer_details)
    {
        $this->container['marketing_campaign_offer_details'] = $marketing_campaign_offer_details;

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
