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

class CompositeTransactionDetailsResponse(object):
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
        'transaction_details': 'list[TransactionDetails]'
    }

    attribute_map = {
        'transaction_details': 'transactionDetails'
    }

    def __init__(self, transaction_details=None):  # noqa: E501
        """CompositeTransactionDetailsResponse - a model defined in Swagger"""  # noqa: E501
        self._transaction_details = None
        self.discriminator = None
        if transaction_details is not None:
            self.transaction_details = transaction_details

    @property
    def transaction_details(self):
        """Gets the transaction_details of this CompositeTransactionDetailsResponse.  # noqa: E501

        Composite transaction details  # noqa: E501

        :return: The transaction_details of this CompositeTransactionDetailsResponse.  # noqa: E501
        :rtype: list[TransactionDetails]
        """
        return self._transaction_details

    @transaction_details.setter
    def transaction_details(self, transaction_details):
        """Sets the transaction_details of this CompositeTransactionDetailsResponse.

        Composite transaction details  # noqa: E501

        :param transaction_details: The transaction_details of this CompositeTransactionDetailsResponse.  # noqa: E501
        :type: list[TransactionDetails]
        """

        self._transaction_details = transaction_details

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
        if issubclass(CompositeTransactionDetailsResponse, dict):
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
        if not isinstance(other, CompositeTransactionDetailsResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
