<?php
/**
 * EppOffers
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
 * EppOffers Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class EppOffers implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'EppOffers';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'tenor' => 'float',
'effective_interest_rate' => 'double',
'annual_percentage_rate' => 'double',
'installment_amount' => 'double',
'one_time_processing_fee_indicator' => 'string',
'one_time_processing_fee_amount' => 'double',
'one_time_processing_fee_percentage' => 'double',
'initial_interest_amount' => 'double',
'offer_indicator' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'tenor' => 'integer',
'effective_interest_rate' => 'double',
'annual_percentage_rate' => 'double',
'installment_amount' => 'double',
'one_time_processing_fee_indicator' => null,
'one_time_processing_fee_amount' => 'double',
'one_time_processing_fee_percentage' => 'double',
'initial_interest_amount' => 'double',
'offer_indicator' => null    ];

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
        'tenor' => 'tenor',
'effective_interest_rate' => 'effectiveInterestRate',
'annual_percentage_rate' => 'annualPercentageRate',
'installment_amount' => 'installmentAmount',
'one_time_processing_fee_indicator' => 'oneTimeProcessingFeeIndicator',
'one_time_processing_fee_amount' => 'oneTimeProcessingFeeAmount',
'one_time_processing_fee_percentage' => 'oneTimeProcessingFeePercentage',
'initial_interest_amount' => 'initialInterestAmount',
'offer_indicator' => 'offerIndicator'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'tenor' => 'setTenor',
'effective_interest_rate' => 'setEffectiveInterestRate',
'annual_percentage_rate' => 'setAnnualPercentageRate',
'installment_amount' => 'setInstallmentAmount',
'one_time_processing_fee_indicator' => 'setOneTimeProcessingFeeIndicator',
'one_time_processing_fee_amount' => 'setOneTimeProcessingFeeAmount',
'one_time_processing_fee_percentage' => 'setOneTimeProcessingFeePercentage',
'initial_interest_amount' => 'setInitialInterestAmount',
'offer_indicator' => 'setOfferIndicator'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'tenor' => 'getTenor',
'effective_interest_rate' => 'getEffectiveInterestRate',
'annual_percentage_rate' => 'getAnnualPercentageRate',
'installment_amount' => 'getInstallmentAmount',
'one_time_processing_fee_indicator' => 'getOneTimeProcessingFeeIndicator',
'one_time_processing_fee_amount' => 'getOneTimeProcessingFeeAmount',
'one_time_processing_fee_percentage' => 'getOneTimeProcessingFeePercentage',
'initial_interest_amount' => 'getInitialInterestAmount',
'offer_indicator' => 'getOfferIndicator'    ];

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
        $this->container['tenor'] = isset($data['tenor']) ? $data['tenor'] : null;
        $this->container['effective_interest_rate'] = isset($data['effective_interest_rate']) ? $data['effective_interest_rate'] : null;
        $this->container['annual_percentage_rate'] = isset($data['annual_percentage_rate']) ? $data['annual_percentage_rate'] : null;
        $this->container['installment_amount'] = isset($data['installment_amount']) ? $data['installment_amount'] : null;
        $this->container['one_time_processing_fee_indicator'] = isset($data['one_time_processing_fee_indicator']) ? $data['one_time_processing_fee_indicator'] : null;
        $this->container['one_time_processing_fee_amount'] = isset($data['one_time_processing_fee_amount']) ? $data['one_time_processing_fee_amount'] : null;
        $this->container['one_time_processing_fee_percentage'] = isset($data['one_time_processing_fee_percentage']) ? $data['one_time_processing_fee_percentage'] : null;
        $this->container['initial_interest_amount'] = isset($data['initial_interest_amount']) ? $data['initial_interest_amount'] : null;
        $this->container['offer_indicator'] = isset($data['offer_indicator']) ? $data['offer_indicator'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['tenor'] === null) {
            $invalidProperties[] = "'tenor' can't be null";
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
     * Gets tenor
     *
     * @return float
     */
    public function getTenor()
    {
        return $this->container['tenor'];
    }

    /**
     * Sets tenor
     *
     * @param float $tenor Tenure of loan in months.
     *
     * @return $this
     */
    public function setTenor($tenor)
    {
        $this->container['tenor'] = $tenor;

        return $this;
    }

    /**
     * Gets effective_interest_rate
     *
     * @return double
     */
    public function getEffectiveInterestRate()
    {
        return $this->container['effective_interest_rate'];
    }

    /**
     * Sets effective_interest_rate
     *
     * @param double $effective_interest_rate The interest rate applicable on Loan Amount.
     *
     * @return $this
     */
    public function setEffectiveInterestRate($effective_interest_rate)
    {
        $this->container['effective_interest_rate'] = $effective_interest_rate;

        return $this;
    }

    /**
     * Gets annual_percentage_rate
     *
     * @return double
     */
    public function getAnnualPercentageRate()
    {
        return $this->container['annual_percentage_rate'];
    }

    /**
     * Sets annual_percentage_rate
     *
     * @param double $annual_percentage_rate Interest rate for a whole year. This includes any fees or additional cost associated.
     *
     * @return $this
     */
    public function setAnnualPercentageRate($annual_percentage_rate)
    {
        $this->container['annual_percentage_rate'] = $annual_percentage_rate;

        return $this;
    }

    /**
     * Gets installment_amount
     *
     * @return double
     */
    public function getInstallmentAmount()
    {
        return $this->container['installment_amount'];
    }

    /**
     * Sets installment_amount
     *
     * @param double $installment_amount The montly emi for the loan amount taken based on Tenor
     *
     * @return $this
     */
    public function setInstallmentAmount($installment_amount)
    {
        $this->container['installment_amount'] = $installment_amount;

        return $this;
    }

    /**
     * Gets one_time_processing_fee_indicator
     *
     * @return string
     */
    public function getOneTimeProcessingFeeIndicator()
    {
        return $this->container['one_time_processing_fee_indicator'];
    }

    /**
     * Sets one_time_processing_fee_indicator
     *
     * @param string $one_time_processing_fee_indicator One time processing fee indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{oneTimeProcessingFeeIndicator} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setOneTimeProcessingFeeIndicator($one_time_processing_fee_indicator)
    {
        $this->container['one_time_processing_fee_indicator'] = $one_time_processing_fee_indicator;

        return $this;
    }

    /**
     * Gets one_time_processing_fee_amount
     *
     * @return double
     */
    public function getOneTimeProcessingFeeAmount()
    {
        return $this->container['one_time_processing_fee_amount'];
    }

    /**
     * Sets one_time_processing_fee_amount
     *
     * @param double $one_time_processing_fee_amount Fee charged as part of one time processing.
     *
     * @return $this
     */
    public function setOneTimeProcessingFeeAmount($one_time_processing_fee_amount)
    {
        $this->container['one_time_processing_fee_amount'] = $one_time_processing_fee_amount;

        return $this;
    }

    /**
     * Gets one_time_processing_fee_percentage
     *
     * @return double
     */
    public function getOneTimeProcessingFeePercentage()
    {
        return $this->container['one_time_processing_fee_percentage'];
    }

    /**
     * Sets one_time_processing_fee_percentage
     *
     * @param double $one_time_processing_fee_percentage Percentage of one time processing fee charged.
     *
     * @return $this
     */
    public function setOneTimeProcessingFeePercentage($one_time_processing_fee_percentage)
    {
        $this->container['one_time_processing_fee_percentage'] = $one_time_processing_fee_percentage;

        return $this;
    }

    /**
     * Gets initial_interest_amount
     *
     * @return double
     */
    public function getInitialInterestAmount()
    {
        return $this->container['initial_interest_amount'];
    }

    /**
     * Sets initial_interest_amount
     *
     * @param double $initial_interest_amount Initial interest amount charged to customer from the epp booking date to the first installment start date
     *
     * @return $this
     */
    public function setInitialInterestAmount($initial_interest_amount)
    {
        $this->container['initial_interest_amount'] = $initial_interest_amount;

        return $this;
    }

    /**
     * Gets offer_indicator
     *
     * @return string
     */
    public function getOfferIndicator()
    {
        return $this->container['offer_indicator'];
    }

    /**
     * Sets offer_indicator
     *
     * @param string $offer_indicator Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setOfferIndicator($offer_indicator)
    {
        $this->container['offer_indicator'] = $offer_indicator;

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
