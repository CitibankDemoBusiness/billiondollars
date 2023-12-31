<?php
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse
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
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'loan_payment_plans' => '\Swagger\Client\Model\LoanPaymentPlans[]',
'service_charge' => 'double',
'additional_service_charge' => 'double',
'internal_rate_of_return' => 'double',
'list_response' => '\Swagger\Client\Model\ListResponse'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'loan_payment_plans' => null,
'service_charge' => 'double',
'additional_service_charge' => 'double',
'internal_rate_of_return' => 'double',
'list_response' => null    ];

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
        'loan_payment_plans' => 'loanPaymentPlans',
'service_charge' => 'serviceCharge',
'additional_service_charge' => 'additionalServiceCharge',
'internal_rate_of_return' => 'internalRateOfReturn',
'list_response' => 'listResponse'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'loan_payment_plans' => 'setLoanPaymentPlans',
'service_charge' => 'setServiceCharge',
'additional_service_charge' => 'setAdditionalServiceCharge',
'internal_rate_of_return' => 'setInternalRateOfReturn',
'list_response' => 'setListResponse'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'loan_payment_plans' => 'getLoanPaymentPlans',
'service_charge' => 'getServiceCharge',
'additional_service_charge' => 'getAdditionalServiceCharge',
'internal_rate_of_return' => 'getInternalRateOfReturn',
'list_response' => 'getListResponse'    ];

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
        $this->container['loan_payment_plans'] = isset($data['loan_payment_plans']) ? $data['loan_payment_plans'] : null;
        $this->container['service_charge'] = isset($data['service_charge']) ? $data['service_charge'] : null;
        $this->container['additional_service_charge'] = isset($data['additional_service_charge']) ? $data['additional_service_charge'] : null;
        $this->container['internal_rate_of_return'] = isset($data['internal_rate_of_return']) ? $data['internal_rate_of_return'] : null;
        $this->container['list_response'] = isset($data['list_response']) ? $data['list_response'] : null;
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
     * Gets loan_payment_plans
     *
     * @return \Swagger\Client\Model\LoanPaymentPlans[]
     */
    public function getLoanPaymentPlans()
    {
        return $this->container['loan_payment_plans'];
    }

    /**
     * Sets loan_payment_plans
     *
     * @param \Swagger\Client\Model\LoanPaymentPlans[] $loan_payment_plans loan_payment_plans
     *
     * @return $this
     */
    public function setLoanPaymentPlans($loan_payment_plans)
    {
        $this->container['loan_payment_plans'] = $loan_payment_plans;

        return $this;
    }

    /**
     * Gets service_charge
     *
     * @return double
     */
    public function getServiceCharge()
    {
        return $this->container['service_charge'];
    }

    /**
     * Sets service_charge
     *
     * @param double $service_charge Booking fee
     *
     * @return $this
     */
    public function setServiceCharge($service_charge)
    {
        $this->container['service_charge'] = $service_charge;

        return $this;
    }

    /**
     * Gets additional_service_charge
     *
     * @return double
     */
    public function getAdditionalServiceCharge()
    {
        return $this->container['additional_service_charge'];
    }

    /**
     * Sets additional_service_charge
     *
     * @param double $additional_service_charge Additional service charge
     *
     * @return $this
     */
    public function setAdditionalServiceCharge($additional_service_charge)
    {
        $this->container['additional_service_charge'] = $additional_service_charge;

        return $this;
    }

    /**
     * Gets internal_rate_of_return
     *
     * @return double
     */
    public function getInternalRateOfReturn()
    {
        return $this->container['internal_rate_of_return'];
    }

    /**
     * Sets internal_rate_of_return
     *
     * @param double $internal_rate_of_return Internal rate of return
     *
     * @return $this
     */
    public function setInternalRateOfReturn($internal_rate_of_return)
    {
        $this->container['internal_rate_of_return'] = $internal_rate_of_return;

        return $this;
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
