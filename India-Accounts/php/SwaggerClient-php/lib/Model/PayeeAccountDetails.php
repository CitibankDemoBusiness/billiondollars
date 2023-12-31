<?php
/**
 * PayeeAccountDetails
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
 * PayeeAccountDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class PayeeAccountDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'PayeeAccountDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'payee_nick_name' => 'string',
'payee_name' => 'string',
'display_payee_account_number' => 'string',
'iban' => 'string',
'payee_id' => 'string',
'payee_bank_name' => 'string',
'payment_type' => 'string',
'bank_code' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'payee_nick_name' => null,
'payee_name' => null,
'display_payee_account_number' => null,
'iban' => null,
'payee_id' => null,
'payee_bank_name' => null,
'payment_type' => null,
'bank_code' => null    ];

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
        'payee_nick_name' => 'payeeNickName',
'payee_name' => 'payeeName',
'display_payee_account_number' => 'displayPayeeAccountNumber',
'iban' => 'iban',
'payee_id' => 'payeeId',
'payee_bank_name' => 'payeeBankName',
'payment_type' => 'paymentType',
'bank_code' => 'bankCode'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'payee_nick_name' => 'setPayeeNickName',
'payee_name' => 'setPayeeName',
'display_payee_account_number' => 'setDisplayPayeeAccountNumber',
'iban' => 'setIban',
'payee_id' => 'setPayeeId',
'payee_bank_name' => 'setPayeeBankName',
'payment_type' => 'setPaymentType',
'bank_code' => 'setBankCode'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'payee_nick_name' => 'getPayeeNickName',
'payee_name' => 'getPayeeName',
'display_payee_account_number' => 'getDisplayPayeeAccountNumber',
'iban' => 'getIban',
'payee_id' => 'getPayeeId',
'payee_bank_name' => 'getPayeeBankName',
'payment_type' => 'getPaymentType',
'bank_code' => 'getBankCode'    ];

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
        $this->container['payee_nick_name'] = isset($data['payee_nick_name']) ? $data['payee_nick_name'] : null;
        $this->container['payee_name'] = isset($data['payee_name']) ? $data['payee_name'] : null;
        $this->container['display_payee_account_number'] = isset($data['display_payee_account_number']) ? $data['display_payee_account_number'] : null;
        $this->container['iban'] = isset($data['iban']) ? $data['iban'] : null;
        $this->container['payee_id'] = isset($data['payee_id']) ? $data['payee_id'] : null;
        $this->container['payee_bank_name'] = isset($data['payee_bank_name']) ? $data['payee_bank_name'] : null;
        $this->container['payment_type'] = isset($data['payment_type']) ? $data['payment_type'] : null;
        $this->container['bank_code'] = isset($data['bank_code']) ? $data['bank_code'] : null;
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
     * Gets payee_nick_name
     *
     * @return string
     */
    public function getPayeeNickName()
    {
        return $this->container['payee_nick_name'];
    }

    /**
     * Sets payee_nick_name
     *
     * @param string $payee_nick_name The nick name of the payee assigned by the customer.
     *
     * @return $this
     */
    public function setPayeeNickName($payee_nick_name)
    {
        $this->container['payee_nick_name'] = $payee_nick_name;

        return $this;
    }

    /**
     * Gets payee_name
     *
     * @return string
     */
    public function getPayeeName()
    {
        return $this->container['payee_name'];
    }

    /**
     * Sets payee_name
     *
     * @param string $payee_name Name of the payee.
     *
     * @return $this
     */
    public function setPayeeName($payee_name)
    {
        $this->container['payee_name'] = $payee_name;

        return $this;
    }

    /**
     * Gets display_payee_account_number
     *
     * @return string
     */
    public function getDisplayPayeeAccountNumber()
    {
        return $this->container['display_payee_account_number'];
    }

    /**
     * Sets display_payee_account_number
     *
     * @param string $display_payee_account_number The display account number of the destination account
     *
     * @return $this
     */
    public function setDisplayPayeeAccountNumber($display_payee_account_number)
    {
        $this->container['display_payee_account_number'] = $display_payee_account_number;

        return $this;
    }

    /**
     * Gets iban
     *
     * @return string
     */
    public function getIban()
    {
        return $this->container['iban'];
    }

    /**
     * Sets iban
     *
     * @param string $iban IBAN stands for International Bank Account Number and is a number attached to all accounts in the EU countries plus Norway, Switzerland, Liechtenstein and Hungary. The IBAN is made up of a code that identifies the country the account belongs to, the account holders bank and the account number itself
     *
     * @return $this
     */
    public function setIban($iban)
    {
        $this->container['iban'] = $iban;

        return $this;
    }

    /**
     * Gets payee_id
     *
     * @return string
     */
    public function getPayeeId()
    {
        return $this->container['payee_id'];
    }

    /**
     * Sets payee_id
     *
     * @param string $payee_id Unique identifier associated with the payee.Typically, this is not displayed to the customer.
     *
     * @return $this
     */
    public function setPayeeId($payee_id)
    {
        $this->container['payee_id'] = $payee_id;

        return $this;
    }

    /**
     * Gets payee_bank_name
     *
     * @return string
     */
    public function getPayeeBankName()
    {
        return $this->container['payee_bank_name'];
    }

    /**
     * Sets payee_bank_name
     *
     * @param string $payee_bank_name Name of the bank.
     *
     * @return $this
     */
    public function setPayeeBankName($payee_bank_name)
    {
        $this->container['payee_bank_name'] = $payee_bank_name;

        return $this;
    }

    /**
     * Gets payment_type
     *
     * @return string
     */
    public function getPaymentType()
    {
        return $this->container['payment_type'];
    }

    /**
     * Sets payment_type
     *
     * @param string $payment_type The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setPaymentType($payment_type)
    {
        $this->container['payment_type'] = $payment_type;

        return $this;
    }

    /**
     * Gets bank_code
     *
     * @return string
     */
    public function getBankCode()
    {
        return $this->container['bank_code'];
    }

    /**
     * Sets bank_code
     *
     * @param string $bank_code Bank Code of the Payee
     *
     * @return $this
     */
    public function setBankCode($bank_code)
    {
        $this->container['bank_code'] = $bank_code;

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
