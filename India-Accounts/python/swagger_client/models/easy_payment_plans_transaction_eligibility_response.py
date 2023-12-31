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

class EasyPaymentPlansTransactionEligibilityResponse(object):
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
        'easy_payment_plan': 'list[EasyPaymentPlan]'
    }

    attribute_map = {
        'easy_payment_plan': 'easyPaymentPlan'
    }

    def __init__(self, easy_payment_plan=None):  # noqa: E501
        """EasyPaymentPlansTransactionEligibilityResponse - a model defined in Swagger"""  # noqa: E501
        self._easy_payment_plan = None
        self.discriminator = None
        if easy_payment_plan is not None:
            self.easy_payment_plan = easy_payment_plan

    @property
    def easy_payment_plan(self):
        """Gets the easy_payment_plan of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501


        :return: The easy_payment_plan of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :rtype: list[EasyPaymentPlan]
        """
        return self._easy_payment_plan

    @easy_payment_plan.setter
    def easy_payment_plan(self, easy_payment_plan):
        """Sets the easy_payment_plan of this EasyPaymentPlansTransactionEligibilityResponse.


        :param easy_payment_plan: The easy_payment_plan of this EasyPaymentPlansTransactionEligibilityResponse.  # noqa: E501
        :type: list[EasyPaymentPlan]
        """

        self._easy_payment_plan = easy_payment_plan

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
        if issubclass(EasyPaymentPlansTransactionEligibilityResponse, dict):
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
        if not isinstance(other, EasyPaymentPlansTransactionEligibilityResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
