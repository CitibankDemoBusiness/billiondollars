<?php
/**
 * AccountSummary
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
 * AccountSummary Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class AccountSummary implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'AccountSummary';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'checking_account_summary' => '\Swagger\Client\Model\CheckingAccountSummary',
'savings_account_summary' => '\Swagger\Client\Model\SavingsAccountSummary',
'credit_card_account_summary' => '\Swagger\Client\Model\CreditCardAccountSummary',
'ready_credit_account_summary' => '\Swagger\Client\Model\ReadyCreditAccountSummary',
'loan_account_summary' => '\Swagger\Client\Model\LoanAccountSummary',
'mutual_fund_account_summary' => '\Swagger\Client\Model\MutualFundAccountSummary',
'securities_brokerage_account_summary' => '\Swagger\Client\Model\SecuritiesBrokerageAccountSummary',
'call_deposit_account_summary' => '\Swagger\Client\Model\CallDepositAccountSummary',
'premium_deposit_account_summary' => '\Swagger\Client\Model\PremiumDepositAccountSummary',
'time_deposit_account_summary' => '\Swagger\Client\Model\TimeDepositAccountSummary'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'checking_account_summary' => null,
'savings_account_summary' => null,
'credit_card_account_summary' => null,
'ready_credit_account_summary' => null,
'loan_account_summary' => null,
'mutual_fund_account_summary' => null,
'securities_brokerage_account_summary' => null,
'call_deposit_account_summary' => null,
'premium_deposit_account_summary' => null,
'time_deposit_account_summary' => null    ];

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
        'checking_account_summary' => 'checkingAccountSummary',
'savings_account_summary' => 'savingsAccountSummary',
'credit_card_account_summary' => 'creditCardAccountSummary',
'ready_credit_account_summary' => 'readyCreditAccountSummary',
'loan_account_summary' => 'loanAccountSummary',
'mutual_fund_account_summary' => 'mutualFundAccountSummary',
'securities_brokerage_account_summary' => 'securitiesBrokerageAccountSummary',
'call_deposit_account_summary' => 'callDepositAccountSummary',
'premium_deposit_account_summary' => 'premiumDepositAccountSummary',
'time_deposit_account_summary' => 'timeDepositAccountSummary'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'checking_account_summary' => 'setCheckingAccountSummary',
'savings_account_summary' => 'setSavingsAccountSummary',
'credit_card_account_summary' => 'setCreditCardAccountSummary',
'ready_credit_account_summary' => 'setReadyCreditAccountSummary',
'loan_account_summary' => 'setLoanAccountSummary',
'mutual_fund_account_summary' => 'setMutualFundAccountSummary',
'securities_brokerage_account_summary' => 'setSecuritiesBrokerageAccountSummary',
'call_deposit_account_summary' => 'setCallDepositAccountSummary',
'premium_deposit_account_summary' => 'setPremiumDepositAccountSummary',
'time_deposit_account_summary' => 'setTimeDepositAccountSummary'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'checking_account_summary' => 'getCheckingAccountSummary',
'savings_account_summary' => 'getSavingsAccountSummary',
'credit_card_account_summary' => 'getCreditCardAccountSummary',
'ready_credit_account_summary' => 'getReadyCreditAccountSummary',
'loan_account_summary' => 'getLoanAccountSummary',
'mutual_fund_account_summary' => 'getMutualFundAccountSummary',
'securities_brokerage_account_summary' => 'getSecuritiesBrokerageAccountSummary',
'call_deposit_account_summary' => 'getCallDepositAccountSummary',
'premium_deposit_account_summary' => 'getPremiumDepositAccountSummary',
'time_deposit_account_summary' => 'getTimeDepositAccountSummary'    ];

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
        $this->container['checking_account_summary'] = isset($data['checking_account_summary']) ? $data['checking_account_summary'] : null;
        $this->container['savings_account_summary'] = isset($data['savings_account_summary']) ? $data['savings_account_summary'] : null;
        $this->container['credit_card_account_summary'] = isset($data['credit_card_account_summary']) ? $data['credit_card_account_summary'] : null;
        $this->container['ready_credit_account_summary'] = isset($data['ready_credit_account_summary']) ? $data['ready_credit_account_summary'] : null;
        $this->container['loan_account_summary'] = isset($data['loan_account_summary']) ? $data['loan_account_summary'] : null;
        $this->container['mutual_fund_account_summary'] = isset($data['mutual_fund_account_summary']) ? $data['mutual_fund_account_summary'] : null;
        $this->container['securities_brokerage_account_summary'] = isset($data['securities_brokerage_account_summary']) ? $data['securities_brokerage_account_summary'] : null;
        $this->container['call_deposit_account_summary'] = isset($data['call_deposit_account_summary']) ? $data['call_deposit_account_summary'] : null;
        $this->container['premium_deposit_account_summary'] = isset($data['premium_deposit_account_summary']) ? $data['premium_deposit_account_summary'] : null;
        $this->container['time_deposit_account_summary'] = isset($data['time_deposit_account_summary']) ? $data['time_deposit_account_summary'] : null;
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
     * Gets checking_account_summary
     *
     * @return \Swagger\Client\Model\CheckingAccountSummary
     */
    public function getCheckingAccountSummary()
    {
        return $this->container['checking_account_summary'];
    }

    /**
     * Sets checking_account_summary
     *
     * @param \Swagger\Client\Model\CheckingAccountSummary $checking_account_summary checking_account_summary
     *
     * @return $this
     */
    public function setCheckingAccountSummary($checking_account_summary)
    {
        $this->container['checking_account_summary'] = $checking_account_summary;

        return $this;
    }

    /**
     * Gets savings_account_summary
     *
     * @return \Swagger\Client\Model\SavingsAccountSummary
     */
    public function getSavingsAccountSummary()
    {
        return $this->container['savings_account_summary'];
    }

    /**
     * Sets savings_account_summary
     *
     * @param \Swagger\Client\Model\SavingsAccountSummary $savings_account_summary savings_account_summary
     *
     * @return $this
     */
    public function setSavingsAccountSummary($savings_account_summary)
    {
        $this->container['savings_account_summary'] = $savings_account_summary;

        return $this;
    }

    /**
     * Gets credit_card_account_summary
     *
     * @return \Swagger\Client\Model\CreditCardAccountSummary
     */
    public function getCreditCardAccountSummary()
    {
        return $this->container['credit_card_account_summary'];
    }

    /**
     * Sets credit_card_account_summary
     *
     * @param \Swagger\Client\Model\CreditCardAccountSummary $credit_card_account_summary credit_card_account_summary
     *
     * @return $this
     */
    public function setCreditCardAccountSummary($credit_card_account_summary)
    {
        $this->container['credit_card_account_summary'] = $credit_card_account_summary;

        return $this;
    }

    /**
     * Gets ready_credit_account_summary
     *
     * @return \Swagger\Client\Model\ReadyCreditAccountSummary
     */
    public function getReadyCreditAccountSummary()
    {
        return $this->container['ready_credit_account_summary'];
    }

    /**
     * Sets ready_credit_account_summary
     *
     * @param \Swagger\Client\Model\ReadyCreditAccountSummary $ready_credit_account_summary ready_credit_account_summary
     *
     * @return $this
     */
    public function setReadyCreditAccountSummary($ready_credit_account_summary)
    {
        $this->container['ready_credit_account_summary'] = $ready_credit_account_summary;

        return $this;
    }

    /**
     * Gets loan_account_summary
     *
     * @return \Swagger\Client\Model\LoanAccountSummary
     */
    public function getLoanAccountSummary()
    {
        return $this->container['loan_account_summary'];
    }

    /**
     * Sets loan_account_summary
     *
     * @param \Swagger\Client\Model\LoanAccountSummary $loan_account_summary loan_account_summary
     *
     * @return $this
     */
    public function setLoanAccountSummary($loan_account_summary)
    {
        $this->container['loan_account_summary'] = $loan_account_summary;

        return $this;
    }

    /**
     * Gets mutual_fund_account_summary
     *
     * @return \Swagger\Client\Model\MutualFundAccountSummary
     */
    public function getMutualFundAccountSummary()
    {
        return $this->container['mutual_fund_account_summary'];
    }

    /**
     * Sets mutual_fund_account_summary
     *
     * @param \Swagger\Client\Model\MutualFundAccountSummary $mutual_fund_account_summary mutual_fund_account_summary
     *
     * @return $this
     */
    public function setMutualFundAccountSummary($mutual_fund_account_summary)
    {
        $this->container['mutual_fund_account_summary'] = $mutual_fund_account_summary;

        return $this;
    }

    /**
     * Gets securities_brokerage_account_summary
     *
     * @return \Swagger\Client\Model\SecuritiesBrokerageAccountSummary
     */
    public function getSecuritiesBrokerageAccountSummary()
    {
        return $this->container['securities_brokerage_account_summary'];
    }

    /**
     * Sets securities_brokerage_account_summary
     *
     * @param \Swagger\Client\Model\SecuritiesBrokerageAccountSummary $securities_brokerage_account_summary securities_brokerage_account_summary
     *
     * @return $this
     */
    public function setSecuritiesBrokerageAccountSummary($securities_brokerage_account_summary)
    {
        $this->container['securities_brokerage_account_summary'] = $securities_brokerage_account_summary;

        return $this;
    }

    /**
     * Gets call_deposit_account_summary
     *
     * @return \Swagger\Client\Model\CallDepositAccountSummary
     */
    public function getCallDepositAccountSummary()
    {
        return $this->container['call_deposit_account_summary'];
    }

    /**
     * Sets call_deposit_account_summary
     *
     * @param \Swagger\Client\Model\CallDepositAccountSummary $call_deposit_account_summary call_deposit_account_summary
     *
     * @return $this
     */
    public function setCallDepositAccountSummary($call_deposit_account_summary)
    {
        $this->container['call_deposit_account_summary'] = $call_deposit_account_summary;

        return $this;
    }

    /**
     * Gets premium_deposit_account_summary
     *
     * @return \Swagger\Client\Model\PremiumDepositAccountSummary
     */
    public function getPremiumDepositAccountSummary()
    {
        return $this->container['premium_deposit_account_summary'];
    }

    /**
     * Sets premium_deposit_account_summary
     *
     * @param \Swagger\Client\Model\PremiumDepositAccountSummary $premium_deposit_account_summary premium_deposit_account_summary
     *
     * @return $this
     */
    public function setPremiumDepositAccountSummary($premium_deposit_account_summary)
    {
        $this->container['premium_deposit_account_summary'] = $premium_deposit_account_summary;

        return $this;
    }

    /**
     * Gets time_deposit_account_summary
     *
     * @return \Swagger\Client\Model\TimeDepositAccountSummary
     */
    public function getTimeDepositAccountSummary()
    {
        return $this->container['time_deposit_account_summary'];
    }

    /**
     * Sets time_deposit_account_summary
     *
     * @param \Swagger\Client\Model\TimeDepositAccountSummary $time_deposit_account_summary time_deposit_account_summary
     *
     * @return $this
     */
    public function setTimeDepositAccountSummary($time_deposit_account_summary)
    {
        $this->container['time_deposit_account_summary'] = $time_deposit_account_summary;

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
