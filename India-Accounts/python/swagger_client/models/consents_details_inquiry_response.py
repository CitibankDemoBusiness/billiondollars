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

class ConsentsDetailsInquiryResponse(object):
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
        'account_consent_details': 'list[AccountConsentDetails]'
    }

    attribute_map = {
        'account_consent_details': 'accountConsentDetails'
    }

    def __init__(self, account_consent_details=None):  # noqa: E501
        """ConsentsDetailsInquiryResponse - a model defined in Swagger"""  # noqa: E501
        self._account_consent_details = None
        self.discriminator = None
        if account_consent_details is not None:
            self.account_consent_details = account_consent_details

    @property
    def account_consent_details(self):
        """Gets the account_consent_details of this ConsentsDetailsInquiryResponse.  # noqa: E501


        :return: The account_consent_details of this ConsentsDetailsInquiryResponse.  # noqa: E501
        :rtype: list[AccountConsentDetails]
        """
        return self._account_consent_details

    @account_consent_details.setter
    def account_consent_details(self, account_consent_details):
        """Sets the account_consent_details of this ConsentsDetailsInquiryResponse.


        :param account_consent_details: The account_consent_details of this ConsentsDetailsInquiryResponse.  # noqa: E501
        :type: list[AccountConsentDetails]
        """

        self._account_consent_details = account_consent_details

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
        if issubclass(ConsentsDetailsInquiryResponse, dict):
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
        if not isinstance(other, ConsentsDetailsInquiryResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other