<?php
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse
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
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'list_response' => '\Swagger\Client\Model\ListResponse',
'org_code' => 'string',
'loan_amortization_schedule' => '\Swagger\Client\Model\LoanPaymentSchedule[]',
'loan_summary' => '\Swagger\Client\Model\LoanSummary'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'list_response' => null,
'org_code' => null,
'loan_amortization_schedule' => null,
'loan_summary' => null    ];

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
        'list_response' => 'listResponse',
'org_code' => 'orgCode',
'loan_amortization_schedule' => 'loanAmortizationSchedule',
'loan_summary' => 'loanSummary'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'list_response' => 'setListResponse',
'org_code' => 'setOrgCode',
'loan_amortization_schedule' => 'setLoanAmortizationSchedule',
'loan_summary' => 'setLoanSummary'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'list_response' => 'getListResponse',
'org_code' => 'getOrgCode',
'loan_amortization_schedule' => 'getLoanAmortizationSchedule',
'loan_summary' => 'getLoanSummary'    ];

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
        $this->container['list_response'] = isset($data['list_response']) ? $data['list_response'] : null;
        $this->container['org_code'] = isset($data['org_code']) ? $data['org_code'] : null;
        $this->container['loan_amortization_schedule'] = isset($data['loan_amortization_schedule']) ? $data['loan_amortization_schedule'] : null;
        $this->container['loan_summary'] = isset($data['loan_summary']) ? $data['loan_summary'] : null;
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
     * Gets list_response
     *
     * @return \Swagger\Client\Model\ListResponse
     */
    public function getListResponse()
    {
        return $this->container['list_response'];
    }

    /**
     * Sets list_response
     *
     * @param \Swagger\Client\Model\ListResponse $list_response list_response
     *
     * @return $this
     */
    public function setListResponse($list_response)
    {
        $this->container['list_response'] = $list_response;

        return $this;
    }

    /**
     * Gets org_code
     *
     * @return string
     */
    public function getOrgCode()
    {
        return $this->container['org_code'];
    }

    /**
     * Sets org_code
     *
     * @param string $org_code Organization of the card
     *
     * @return $this
     */
    public function setOrgCode($org_code)
    {
        $this->container['org_code'] = $org_code;

        return $this;
    }

    /**
     * Gets loan_amortization_schedule
     *
     * @return \Swagger\Client\Model\LoanPaymentSchedule[]
     */
    public function getLoanAmortizationSchedule()
    {
        return $this->container['loan_amortization_schedule'];
    }

    /**
     * Sets loan_amortization_schedule
     *
     * @param \Swagger\Client\Model\LoanPaymentSchedule[] $loan_amortization_schedule loan_amortization_schedule
     *
     * @return $this
     */
    public function setLoanAmortizationSchedule($loan_amortization_schedule)
    {
        $this->container['loan_amortization_schedule'] = $loan_amortization_schedule;

        return $this;
    }

    /**
     * Gets loan_summary
     *
     * @return \Swagger\Client\Model\LoanSummary
     */
    public function getLoanSummary()
    {
        return $this->container['loan_summary'];
    }

    /**
     * Sets loan_summary
     *
     * @param \Swagger\Client\Model\LoanSummary $loan_summary loan_summary
     *
     * @return $this
     */
    public function setLoanSummary($loan_summary)
    {
        $this->container['loan_summary'] = $loan_summary;

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
