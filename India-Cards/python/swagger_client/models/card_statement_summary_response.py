# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class CardStatementSummaryResponse(object):
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
        'credit_card_statement_summary': 'list[CreditCardStatementSummary]'
    }

    attribute_map = {
        'credit_card_statement_summary': 'creditCardStatementSummary'
    }

    def __init__(self, credit_card_statement_summary=None):  # noqa: E501
        """CardStatementSummaryResponse - a model defined in Swagger"""  # noqa: E501
        self._credit_card_statement_summary = None
        self.discriminator = None
        if credit_card_statement_summary is not None:
            self.credit_card_statement_summary = credit_card_statement_summary

    @property
    def credit_card_statement_summary(self):
        """Gets the credit_card_statement_summary of this CardStatementSummaryResponse.  # noqa: E501


        :return: The credit_card_statement_summary of this CardStatementSummaryResponse.  # noqa: E501
        :rtype: list[CreditCardStatementSummary]
        """
        return self._credit_card_statement_summary

    @credit_card_statement_summary.setter
    def credit_card_statement_summary(self, credit_card_statement_summary):
        """Sets the credit_card_statement_summary of this CardStatementSummaryResponse.


        :param credit_card_statement_summary: The credit_card_statement_summary of this CardStatementSummaryResponse.  # noqa: E501
        :type: list[CreditCardStatementSummary]
        """

        self._credit_card_statement_summary = credit_card_statement_summary

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
        if issubclass(CardStatementSummaryResponse, dict):
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
        if not isinstance(other, CardStatementSummaryResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
