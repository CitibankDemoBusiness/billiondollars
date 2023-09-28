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

class AccountBalancesSummaryInquiryResponse(object):
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
        'credit_card_account_balance_summary': 'CreditCardAccountBalanceSummary',
        'ready_credit_account_balance_summary': 'ReadyCreditAccountBalanceSummary'
    }

    attribute_map = {
        'credit_card_account_balance_summary': 'creditCardAccountBalanceSummary',
        'ready_credit_account_balance_summary': 'readyCreditAccountBalanceSummary'
    }

    def __init__(self, credit_card_account_balance_summary=None, ready_credit_account_balance_summary=None):  # noqa: E501
        """AccountBalancesSummaryInquiryResponse - a model defined in Swagger"""  # noqa: E501
        self._credit_card_account_balance_summary = None
        self._ready_credit_account_balance_summary = None
        self.discriminator = None
        if credit_card_account_balance_summary is not None:
            self.credit_card_account_balance_summary = credit_card_account_balance_summary
        if ready_credit_account_balance_summary is not None:
            self.ready_credit_account_balance_summary = ready_credit_account_balance_summary

    @property
    def credit_card_account_balance_summary(self):
        """Gets the credit_card_account_balance_summary of this AccountBalancesSummaryInquiryResponse.  # noqa: E501


        :return: The credit_card_account_balance_summary of this AccountBalancesSummaryInquiryResponse.  # noqa: E501
        :rtype: CreditCardAccountBalanceSummary
        """
        return self._credit_card_account_balance_summary

    @credit_card_account_balance_summary.setter
    def credit_card_account_balance_summary(self, credit_card_account_balance_summary):
        """Sets the credit_card_account_balance_summary of this AccountBalancesSummaryInquiryResponse.


        :param credit_card_account_balance_summary: The credit_card_account_balance_summary of this AccountBalancesSummaryInquiryResponse.  # noqa: E501
        :type: CreditCardAccountBalanceSummary
        """

        self._credit_card_account_balance_summary = credit_card_account_balance_summary

    @property
    def ready_credit_account_balance_summary(self):
        """Gets the ready_credit_account_balance_summary of this AccountBalancesSummaryInquiryResponse.  # noqa: E501


        :return: The ready_credit_account_balance_summary of this AccountBalancesSummaryInquiryResponse.  # noqa: E501
        :rtype: ReadyCreditAccountBalanceSummary
        """
        return self._ready_credit_account_balance_summary

    @ready_credit_account_balance_summary.setter
    def ready_credit_account_balance_summary(self, ready_credit_account_balance_summary):
        """Sets the ready_credit_account_balance_summary of this AccountBalancesSummaryInquiryResponse.


        :param ready_credit_account_balance_summary: The ready_credit_account_balance_summary of this AccountBalancesSummaryInquiryResponse.  # noqa: E501
        :type: ReadyCreditAccountBalanceSummary
        """

        self._ready_credit_account_balance_summary = ready_credit_account_balance_summary

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
        if issubclass(AccountBalancesSummaryInquiryResponse, dict):
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
        if not isinstance(other, AccountBalancesSummaryInquiryResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other