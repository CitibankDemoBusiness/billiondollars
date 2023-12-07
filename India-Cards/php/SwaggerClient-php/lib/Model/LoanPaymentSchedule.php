<?php
/**
 * LoanPaymentSchedule
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
 * LoanPaymentSchedule Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class LoanPaymentSchedule implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'LoanPaymentSchedule';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'installment_number' => 'int',
'principal_amount' => 'double',
'installment_interest_amount' => 'double',
'installment_amount' => 'double',
'installment_date' => '\DateTime'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'installment_number' => 'int32',
'principal_amount' => 'double',
'installment_interest_amount' => 'double',
'installment_amount' => 'double',
'installment_date' => 'date'    ];

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
        'installment_number' => 'installmentNumber',
'principal_amount' => 'principalAmount',
'installment_interest_amount' => 'installmentInterestAmount',
'installment_amount' => 'installmentAmount',
'installment_date' => 'installmentDate'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'installment_number' => 'setInstallmentNumber',
'principal_amount' => 'setPrincipalAmount',
'installment_interest_amount' => 'setInstallmentInterestAmount',
'installment_amount' => 'setInstallmentAmount',
'installment_date' => 'setInstallmentDate'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'installment_number' => 'getInstallmentNumber',
'principal_amount' => 'getPrincipalAmount',
'installment_interest_amount' => 'getInstallmentInterestAmount',
'installment_amount' => 'getInstallmentAmount',
'installment_date' => 'getInstallmentDate'    ];

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
        $this->container['installment_number'] = isset($data['installment_number']) ? $data['installment_number'] : null;
        $this->container['principal_amount'] = isset($data['principal_amount']) ? $data['principal_amount'] : null;
        $this->container['installment_interest_amount'] = isset($data['installment_interest_amount']) ? $data['installment_interest_amount'] : null;
        $this->container['installment_amount'] = isset($data['installment_amount']) ? $data['installment_amount'] : null;
        $this->container['installment_date'] = isset($data['installment_date']) ? $data['installment_date'] : null;
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
     * Gets installment_number
     *
     * @return int
     */
    public function getInstallmentNumber()
    {
        return $this->container['installment_number'];
    }

    /**
     * Sets installment_number
     *
     * @param int $installment_number The installment number of the total number of installments
     *
     * @return $this
     */
    public function setInstallmentNumber($installment_number)
    {
        $this->container['installment_number'] = $installment_number;

        return $this;
    }

    /**
     * Gets principal_amount
     *
     * @return double
     */
    public function getPrincipalAmount()
    {
        return $this->container['principal_amount'];
    }

    /**
     * Sets principal_amount
     *
     * @param double $principal_amount The portion of the principal amount paid for the loan.
     *
     * @return $this
     */
    public function setPrincipalAmount($principal_amount)
    {
        $this->container['principal_amount'] = $principal_amount;

        return $this;
    }

    /**
     * Gets installment_interest_amount
     *
     * @return double
     */
    public function getInstallmentInterestAmount()
    {
        return $this->container['installment_interest_amount'];
    }

    /**
     * Sets installment_interest_amount
     *
     * @param double $installment_interest_amount The interest amount to be paid as installment
     *
     * @return $this
     */
    public function setInstallmentInterestAmount($installment_interest_amount)
    {
        $this->container['installment_interest_amount'] = $installment_interest_amount;

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
     * @param double $installment_amount Installment amount to be payed by customer in order to repay the loan.
     *
     * @return $this
     */
    public function setInstallmentAmount($installment_amount)
    {
        $this->container['installment_amount'] = $installment_amount;

        return $this;
    }

    /**
     * Gets installment_date
     *
     * @return \DateTime
     */
    public function getInstallmentDate()
    {
        return $this->container['installment_date'];
    }

    /**
     * Sets installment_date
     *
     * @param \DateTime $installment_date Date of installment in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setInstallmentDate($installment_date)
    {
        $this->container['installment_date'] = $installment_date;

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
