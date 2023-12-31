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

class ExternalBankDetails(object):
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
        'bank_code': 'str',
        'destination_account_id': 'str',
        'display_destination_account_number': 'str'
    }

    attribute_map = {
        'bank_code': 'bankCode',
        'destination_account_id': 'destinationAccountId',
        'display_destination_account_number': 'displayDestinationAccountNumber'
    }

    def __init__(self, bank_code=None, destination_account_id=None, display_destination_account_number=None):  # noqa: E501
        """ExternalBankDetails - a model defined in Swagger"""  # noqa: E501
        self._bank_code = None
        self._destination_account_id = None
        self._display_destination_account_number = None
        self.discriminator = None
        self.bank_code = bank_code
        self.destination_account_id = destination_account_id
        if display_destination_account_number is not None:
            self.display_destination_account_number = display_destination_account_number

    @property
    def bank_code(self):
        """Gets the bank_code of this ExternalBankDetails.  # noqa: E501

        This field is to indicate the bank code. Code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions code  # noqa: E501

        :return: The bank_code of this ExternalBankDetails.  # noqa: E501
        :rtype: str
        """
        return self._bank_code

    @bank_code.setter
    def bank_code(self, bank_code):
        """Sets the bank_code of this ExternalBankDetails.

        This field is to indicate the bank code. Code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions code  # noqa: E501

        :param bank_code: The bank_code of this ExternalBankDetails.  # noqa: E501
        :type: str
        """
        if bank_code is None:
            raise ValueError("Invalid value for `bank_code`, must not be `None`")  # noqa: E501

        self._bank_code = bank_code

    @property
    def destination_account_id(self):
        """Gets the destination_account_id of this ExternalBankDetails.  # noqa: E501

        The destination account identifier in encrypted format.Typically, this is not displayed to the customer.  # noqa: E501

        :return: The destination_account_id of this ExternalBankDetails.  # noqa: E501
        :rtype: str
        """
        return self._destination_account_id

    @destination_account_id.setter
    def destination_account_id(self, destination_account_id):
        """Sets the destination_account_id of this ExternalBankDetails.

        The destination account identifier in encrypted format.Typically, this is not displayed to the customer.  # noqa: E501

        :param destination_account_id: The destination_account_id of this ExternalBankDetails.  # noqa: E501
        :type: str
        """
        if destination_account_id is None:
            raise ValueError("Invalid value for `destination_account_id`, must not be `None`")  # noqa: E501

        self._destination_account_id = destination_account_id

    @property
    def display_destination_account_number(self):
        """Gets the display_destination_account_number of this ExternalBankDetails.  # noqa: E501

        A masked account number that can be displayed to the customer  # noqa: E501

        :return: The display_destination_account_number of this ExternalBankDetails.  # noqa: E501
        :rtype: str
        """
        return self._display_destination_account_number

    @display_destination_account_number.setter
    def display_destination_account_number(self, display_destination_account_number):
        """Sets the display_destination_account_number of this ExternalBankDetails.

        A masked account number that can be displayed to the customer  # noqa: E501

        :param display_destination_account_number: The display_destination_account_number of this ExternalBankDetails.  # noqa: E501
        :type: str
        """

        self._display_destination_account_number = display_destination_account_number

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
        if issubclass(ExternalBankDetails, dict):
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
        if not isinstance(other, ExternalBankDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
