# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class Transaction(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'display_account_number': 'str',
        'transaction_date': 'date',
        'transaction_description': 'str',
        'transaction_reference_id': 'str',
        'check_serial_number': 'str',
        'transaction_amount': 'float',
        'currency_code': 'str',
        'foreign_transaction_amount': 'float',
        'foreign_currency_code': 'str',
        'foreign_exchange_rate': 'float',
        'transaction_type': 'str',
        'transaction_status': 'str',
        'running_balance': 'float',
        'transaction_posting_date': 'date',
        'transaction_code': 'str',
        'merchant_name': 'str',
        'eligible_for_equal_payment_plan': 'str'
    }

    attribute_map = {
        'display_account_number': 'displayAccountNumber',
        'transaction_date': 'transactionDate',
        'transaction_description': 'transactionDescription',
        'transaction_reference_id': 'transactionReferenceId',
        'check_serial_number': 'checkSerialNumber',
        'transaction_amount': 'transactionAmount',
        'currency_code': 'currencyCode',
        'foreign_transaction_amount': 'foreignTransactionAmount',
        'foreign_currency_code': 'foreignCurrencyCode',
        'foreign_exchange_rate': 'foreignExchangeRate',
        'transaction_type': 'transactionType',
        'transaction_status': 'transactionStatus',
        'running_balance': 'runningBalance',
        'transaction_posting_date': 'transactionPostingDate',
        'transaction_code': 'transactionCode',
        'merchant_name': 'merchantName',
        'eligible_for_equal_payment_plan': 'eligibleForEqualPaymentPlan'
    }

    def __init__(self, display_account_number=None, transaction_date=None, transaction_description=None, transaction_reference_id=None, check_serial_number=None, transaction_amount=None, currency_code=None, foreign_transaction_amount=None, foreign_currency_code=None, foreign_exchange_rate=None, transaction_type=None, transaction_status=None, running_balance=None, transaction_posting_date=None, transaction_code=None, merchant_name=None, eligible_for_equal_payment_plan=None):  # noqa: E501
        """Transaction - a model defined in Swagger"""  # noqa: E501
        self._display_account_number = None
        self._transaction_date = None
        self._transaction_description = None
        self._transaction_reference_id = None
        self._check_serial_number = None
        self._transaction_amount = None
        self._currency_code = None
        self._foreign_transaction_amount = None
        self._foreign_currency_code = None
        self._foreign_exchange_rate = None
        self._transaction_type = None
        self._transaction_status = None
        self._running_balance = None
        self._transaction_posting_date = None
        self._transaction_code = None
        self._merchant_name = None
        self._eligible_for_equal_payment_plan = None
        self.discriminator = None
        if display_account_number is not None:
            self.display_account_number = display_account_number
        if transaction_date is not None:
            self.transaction_date = transaction_date
        if transaction_description is not None:
            self.transaction_description = transaction_description
        if transaction_reference_id is not None:
            self.transaction_reference_id = transaction_reference_id
        if check_serial_number is not None:
            self.check_serial_number = check_serial_number
        if transaction_amount is not None:
            self.transaction_amount = transaction_amount
        if currency_code is not None:
            self.currency_code = currency_code
        if foreign_transaction_amount is not None:
            self.foreign_transaction_amount = foreign_transaction_amount
        if foreign_currency_code is not None:
            self.foreign_currency_code = foreign_currency_code
        if foreign_exchange_rate is not None:
            self.foreign_exchange_rate = foreign_exchange_rate
        if transaction_type is not None:
            self.transaction_type = transaction_type
        if transaction_status is not None:
            self.transaction_status = transaction_status
        if running_balance is not None:
            self.running_balance = running_balance
        if transaction_posting_date is not None:
            self.transaction_posting_date = transaction_posting_date
        if transaction_code is not None:
            self.transaction_code = transaction_code
        if merchant_name is not None:
            self.merchant_name = merchant_name
        if eligible_for_equal_payment_plan is not None:
            self.eligible_for_equal_payment_plan = eligible_for_equal_payment_plan

    @property
    def display_account_number(self):
        """Gets the display_account_number of this Transaction.  # noqa: E501

        A masked account number that can be displayed to the customer  # noqa: E501

        :return: The display_account_number of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._display_account_number

    @display_account_number.setter
    def display_account_number(self, display_account_number):
        """Sets the display_account_number of this Transaction.

        A masked account number that can be displayed to the customer  # noqa: E501

        :param display_account_number: The display_account_number of this Transaction.  # noqa: E501
        :type: str
        """

        self._display_account_number = display_account_number

    @property
    def transaction_date(self):
        """Gets the transaction_date of this Transaction.  # noqa: E501

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,  # noqa: E501

        :return: The transaction_date of this Transaction.  # noqa: E501
        :rtype: date
        """
        return self._transaction_date

    @transaction_date.setter
    def transaction_date(self, transaction_date):
        """Sets the transaction_date of this Transaction.

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,  # noqa: E501

        :param transaction_date: The transaction_date of this Transaction.  # noqa: E501
        :type: date
        """

        self._transaction_date = transaction_date

    @property
    def transaction_description(self):
        """Gets the transaction_description of this Transaction.  # noqa: E501

        Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.  # noqa: E501

        :return: The transaction_description of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_description

    @transaction_description.setter
    def transaction_description(self, transaction_description):
        """Sets the transaction_description of this Transaction.

        Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.  # noqa: E501

        :param transaction_description: The transaction_description of this Transaction.  # noqa: E501
        :type: str
        """

        self._transaction_description = transaction_description

    @property
    def transaction_reference_id(self):
        """Gets the transaction_reference_id of this Transaction.  # noqa: E501

        Reference Id to uniquely identify the transaction  # noqa: E501

        :return: The transaction_reference_id of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_reference_id

    @transaction_reference_id.setter
    def transaction_reference_id(self, transaction_reference_id):
        """Sets the transaction_reference_id of this Transaction.

        Reference Id to uniquely identify the transaction  # noqa: E501

        :param transaction_reference_id: The transaction_reference_id of this Transaction.  # noqa: E501
        :type: str
        """

        self._transaction_reference_id = transaction_reference_id

    @property
    def check_serial_number(self):
        """Gets the check_serial_number of this Transaction.  # noqa: E501

        The check serial number. Applicable for checking accounts only  # noqa: E501

        :return: The check_serial_number of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._check_serial_number

    @check_serial_number.setter
    def check_serial_number(self, check_serial_number):
        """Sets the check_serial_number of this Transaction.

        The check serial number. Applicable for checking accounts only  # noqa: E501

        :param check_serial_number: The check_serial_number of this Transaction.  # noqa: E501
        :type: str
        """

        self._check_serial_number = check_serial_number

    @property
    def transaction_amount(self):
        """Gets the transaction_amount of this Transaction.  # noqa: E501

        Transaction amount in local currency.  # noqa: E501

        :return: The transaction_amount of this Transaction.  # noqa: E501
        :rtype: float
        """
        return self._transaction_amount

    @transaction_amount.setter
    def transaction_amount(self, transaction_amount):
        """Sets the transaction_amount of this Transaction.

        Transaction amount in local currency.  # noqa: E501

        :param transaction_amount: The transaction_amount of this Transaction.  # noqa: E501
        :type: float
        """

        self._transaction_amount = transaction_amount

    @property
    def currency_code(self):
        """Gets the currency_code of this Transaction.  # noqa: E501

        The currency code of the transaction in ISO 4217 format  # noqa: E501

        :return: The currency_code of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._currency_code

    @currency_code.setter
    def currency_code(self, currency_code):
        """Sets the currency_code of this Transaction.

        The currency code of the transaction in ISO 4217 format  # noqa: E501

        :param currency_code: The currency_code of this Transaction.  # noqa: E501
        :type: str
        """

        self._currency_code = currency_code

    @property
    def foreign_transaction_amount(self):
        """Gets the foreign_transaction_amount of this Transaction.  # noqa: E501

        The transaction amount in the foreign currency  # noqa: E501

        :return: The foreign_transaction_amount of this Transaction.  # noqa: E501
        :rtype: float
        """
        return self._foreign_transaction_amount

    @foreign_transaction_amount.setter
    def foreign_transaction_amount(self, foreign_transaction_amount):
        """Sets the foreign_transaction_amount of this Transaction.

        The transaction amount in the foreign currency  # noqa: E501

        :param foreign_transaction_amount: The foreign_transaction_amount of this Transaction.  # noqa: E501
        :type: float
        """

        self._foreign_transaction_amount = foreign_transaction_amount

    @property
    def foreign_currency_code(self):
        """Gets the foreign_currency_code of this Transaction.  # noqa: E501

        The foreign currency code of the transaction in ISO 4217 format  # noqa: E501

        :return: The foreign_currency_code of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._foreign_currency_code

    @foreign_currency_code.setter
    def foreign_currency_code(self, foreign_currency_code):
        """Sets the foreign_currency_code of this Transaction.

        The foreign currency code of the transaction in ISO 4217 format  # noqa: E501

        :param foreign_currency_code: The foreign_currency_code of this Transaction.  # noqa: E501
        :type: str
        """

        self._foreign_currency_code = foreign_currency_code

    @property
    def foreign_exchange_rate(self):
        """Gets the foreign_exchange_rate of this Transaction.  # noqa: E501

        The exchange rate at the time the foreign transaction was done  # noqa: E501

        :return: The foreign_exchange_rate of this Transaction.  # noqa: E501
        :rtype: float
        """
        return self._foreign_exchange_rate

    @foreign_exchange_rate.setter
    def foreign_exchange_rate(self, foreign_exchange_rate):
        """Sets the foreign_exchange_rate of this Transaction.

        The exchange rate at the time the foreign transaction was done  # noqa: E501

        :param foreign_exchange_rate: The foreign_exchange_rate of this Transaction.  # noqa: E501
        :type: float
        """

        self._foreign_exchange_rate = foreign_exchange_rate

    @property
    def transaction_type(self):
        """Gets the transaction_type of this Transaction.  # noqa: E501

        The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :return: The transaction_type of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_type

    @transaction_type.setter
    def transaction_type(self, transaction_type):
        """Sets the transaction_type of this Transaction.

        The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :param transaction_type: The transaction_type of this Transaction.  # noqa: E501
        :type: str
        """

        self._transaction_type = transaction_type

    @property
    def transaction_status(self):
        """Gets the transaction_status of this Transaction.  # noqa: E501

        The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :return: The transaction_status of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_status

    @transaction_status.setter
    def transaction_status(self, transaction_status):
        """Sets the transaction_status of this Transaction.

        The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :param transaction_status: The transaction_status of this Transaction.  # noqa: E501
        :type: str
        """

        self._transaction_status = transaction_status

    @property
    def running_balance(self):
        """Gets the running_balance of this Transaction.  # noqa: E501

        The amount available to transact immediately  # noqa: E501

        :return: The running_balance of this Transaction.  # noqa: E501
        :rtype: float
        """
        return self._running_balance

    @running_balance.setter
    def running_balance(self, running_balance):
        """Sets the running_balance of this Transaction.

        The amount available to transact immediately  # noqa: E501

        :param running_balance: The running_balance of this Transaction.  # noqa: E501
        :type: float
        """

        self._running_balance = running_balance

    @property
    def transaction_posting_date(self):
        """Gets the transaction_posting_date of this Transaction.  # noqa: E501

        Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting  # noqa: E501

        :return: The transaction_posting_date of this Transaction.  # noqa: E501
        :rtype: date
        """
        return self._transaction_posting_date

    @transaction_posting_date.setter
    def transaction_posting_date(self, transaction_posting_date):
        """Sets the transaction_posting_date of this Transaction.

        Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting  # noqa: E501

        :param transaction_posting_date: The transaction_posting_date of this Transaction.  # noqa: E501
        :type: date
        """

        self._transaction_posting_date = transaction_posting_date

    @property
    def transaction_code(self):
        """Gets the transaction_code of this Transaction.  # noqa: E501

        The transaction code  # noqa: E501

        :return: The transaction_code of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._transaction_code

    @transaction_code.setter
    def transaction_code(self, transaction_code):
        """Sets the transaction_code of this Transaction.

        The transaction code  # noqa: E501

        :param transaction_code: The transaction_code of this Transaction.  # noqa: E501
        :type: str
        """

        self._transaction_code = transaction_code

    @property
    def merchant_name(self):
        """Gets the merchant_name of this Transaction.  # noqa: E501

        The merchant name with which this transaction was made with  # noqa: E501

        :return: The merchant_name of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._merchant_name

    @merchant_name.setter
    def merchant_name(self, merchant_name):
        """Sets the merchant_name of this Transaction.

        The merchant name with which this transaction was made with  # noqa: E501

        :param merchant_name: The merchant_name of this Transaction.  # noqa: E501
        :type: str
        """

        self._merchant_name = merchant_name

    @property
    def eligible_for_equal_payment_plan(self):
        """Gets the eligible_for_equal_payment_plan of this Transaction.  # noqa: E501

        The EPP allowed indicator. This is applicable for credit cards transactions only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :return: The eligible_for_equal_payment_plan of this Transaction.  # noqa: E501
        :rtype: str
        """
        return self._eligible_for_equal_payment_plan

    @eligible_for_equal_payment_plan.setter
    def eligible_for_equal_payment_plan(self, eligible_for_equal_payment_plan):
        """Sets the eligible_for_equal_payment_plan of this Transaction.

        The EPP allowed indicator. This is applicable for credit cards transactions only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :param eligible_for_equal_payment_plan: The eligible_for_equal_payment_plan of this Transaction.  # noqa: E501
        :type: str
        """

        self._eligible_for_equal_payment_plan = eligible_for_equal_payment_plan

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(Transaction, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Transaction):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other