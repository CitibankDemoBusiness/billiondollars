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

class OriginalTransactionDetails(object):
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
        'payment_type': 'str',
        'transaction_date': 'date',
        'transaction_amount': 'float',
        'transaction_currency_code': 'str',
        'transaction_status': 'str',
        'transaction_reference_number': 'str',
        'transaction_remarks': 'str',
        'end_to_end_identification': 'str'
    }

    attribute_map = {
        'payment_type': 'paymentType',
        'transaction_date': 'transactionDate',
        'transaction_amount': 'transactionAmount',
        'transaction_currency_code': 'transactionCurrencyCode',
        'transaction_status': 'transactionStatus',
        'transaction_reference_number': 'transactionReferenceNumber',
        'transaction_remarks': 'transactionRemarks',
        'end_to_end_identification': 'endToEndIdentification'
    }

    def __init__(self, payment_type=None, transaction_date=None, transaction_amount=None, transaction_currency_code=None, transaction_status=None, transaction_reference_number=None, transaction_remarks=None, end_to_end_identification=None):  # noqa: E501
        """OriginalTransactionDetails - a model defined in Swagger"""  # noqa: E501
        self._payment_type = None
        self._transaction_date = None
        self._transaction_amount = None
        self._transaction_currency_code = None
        self._transaction_status = None
        self._transaction_reference_number = None
        self._transaction_remarks = None
        self._end_to_end_identification = None
        self.discriminator = None
        if payment_type is not None:
            self.payment_type = payment_type
        if transaction_date is not None:
            self.transaction_date = transaction_date
        if transaction_amount is not None:
            self.transaction_amount = transaction_amount
        if transaction_currency_code is not None:
            self.transaction_currency_code = transaction_currency_code
        if transaction_status is not None:
            self.transaction_status = transaction_status
        if transaction_reference_number is not None:
            self.transaction_reference_number = transaction_reference_number
        if transaction_remarks is not None:
            self.transaction_remarks = transaction_remarks
        if end_to_end_identification is not None:
            self.end_to_end_identification = end_to_end_identification

    @property
    def payment_type(self):
        """Gets the payment_type of this OriginalTransactionDetails.  # noqa: E501

        The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.  # noqa: E501

        :return: The payment_type of this OriginalTransactionDetails.  # noqa: E501
        :rtype: str
        """
        return self._payment_type

    @payment_type.setter
    def payment_type(self, payment_type):
        """Sets the payment_type of this OriginalTransactionDetails.

        The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description.  # noqa: E501

        :param payment_type: The payment_type of this OriginalTransactionDetails.  # noqa: E501
        :type: str
        """

        self._payment_type = payment_type

    @property
    def transaction_date(self):
        """Gets the transaction_date of this OriginalTransactionDetails.  # noqa: E501

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,  # noqa: E501

        :return: The transaction_date of this OriginalTransactionDetails.  # noqa: E501
        :rtype: date
        """
        return self._transaction_date

    @transaction_date.setter
    def transaction_date(self, transaction_date):
        """Sets the transaction_date of this OriginalTransactionDetails.

        Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,  # noqa: E501

        :param transaction_date: The transaction_date of this OriginalTransactionDetails.  # noqa: E501
        :type: date
        """

        self._transaction_date = transaction_date

    @property
    def transaction_amount(self):
        """Gets the transaction_amount of this OriginalTransactionDetails.  # noqa: E501

        Transaction amount in account currency.  # noqa: E501

        :return: The transaction_amount of this OriginalTransactionDetails.  # noqa: E501
        :rtype: float
        """
        return self._transaction_amount

    @transaction_amount.setter
    def transaction_amount(self, transaction_amount):
        """Sets the transaction_amount of this OriginalTransactionDetails.

        Transaction amount in account currency.  # noqa: E501

        :param transaction_amount: The transaction_amount of this OriginalTransactionDetails.  # noqa: E501
        :type: float
        """

        self._transaction_amount = transaction_amount

    @property
    def transaction_currency_code(self):
        """Gets the transaction_currency_code of this OriginalTransactionDetails.  # noqa: E501

        The currency code for the foreign transaction amount in ISO 4217 format.  # noqa: E501

        :return: The transaction_currency_code of this OriginalTransactionDetails.  # noqa: E501
        :rtype: str
        """
        return self._transaction_currency_code

    @transaction_currency_code.setter
    def transaction_currency_code(self, transaction_currency_code):
        """Sets the transaction_currency_code of this OriginalTransactionDetails.

        The currency code for the foreign transaction amount in ISO 4217 format.  # noqa: E501

        :param transaction_currency_code: The transaction_currency_code of this OriginalTransactionDetails.  # noqa: E501
        :type: str
        """

        self._transaction_currency_code = transaction_currency_code

    @property
    def transaction_status(self):
        """Gets the transaction_status of this OriginalTransactionDetails.  # noqa: E501

        Transaction Status of the original transaction  # noqa: E501

        :return: The transaction_status of this OriginalTransactionDetails.  # noqa: E501
        :rtype: str
        """
        return self._transaction_status

    @transaction_status.setter
    def transaction_status(self, transaction_status):
        """Sets the transaction_status of this OriginalTransactionDetails.

        Transaction Status of the original transaction  # noqa: E501

        :param transaction_status: The transaction_status of this OriginalTransactionDetails.  # noqa: E501
        :type: str
        """

        self._transaction_status = transaction_status

    @property
    def transaction_reference_number(self):
        """Gets the transaction_reference_number of this OriginalTransactionDetails.  # noqa: E501

        Transaction reference number of the original transaction  # noqa: E501

        :return: The transaction_reference_number of this OriginalTransactionDetails.  # noqa: E501
        :rtype: str
        """
        return self._transaction_reference_number

    @transaction_reference_number.setter
    def transaction_reference_number(self, transaction_reference_number):
        """Sets the transaction_reference_number of this OriginalTransactionDetails.

        Transaction reference number of the original transaction  # noqa: E501

        :param transaction_reference_number: The transaction_reference_number of this OriginalTransactionDetails.  # noqa: E501
        :type: str
        """

        self._transaction_reference_number = transaction_reference_number

    @property
    def transaction_remarks(self):
        """Gets the transaction_remarks of this OriginalTransactionDetails.  # noqa: E501

        Transaction Remarks of the original transaction  # noqa: E501

        :return: The transaction_remarks of this OriginalTransactionDetails.  # noqa: E501
        :rtype: str
        """
        return self._transaction_remarks

    @transaction_remarks.setter
    def transaction_remarks(self, transaction_remarks):
        """Sets the transaction_remarks of this OriginalTransactionDetails.

        Transaction Remarks of the original transaction  # noqa: E501

        :param transaction_remarks: The transaction_remarks of this OriginalTransactionDetails.  # noqa: E501
        :type: str
        """

        self._transaction_remarks = transaction_remarks

    @property
    def end_to_end_identification(self):
        """Gets the end_to_end_identification of this OriginalTransactionDetails.  # noqa: E501

        End to End Identification reference of the original transaction  # noqa: E501

        :return: The end_to_end_identification of this OriginalTransactionDetails.  # noqa: E501
        :rtype: str
        """
        return self._end_to_end_identification

    @end_to_end_identification.setter
    def end_to_end_identification(self, end_to_end_identification):
        """Sets the end_to_end_identification of this OriginalTransactionDetails.

        End to End Identification reference of the original transaction  # noqa: E501

        :param end_to_end_identification: The end_to_end_identification of this OriginalTransactionDetails.  # noqa: E501
        :type: str
        """

        self._end_to_end_identification = end_to_end_identification

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
        if issubclass(OriginalTransactionDetails, dict):
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
        if not isinstance(other, OriginalTransactionDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other