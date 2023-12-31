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

class AccountAccessCodeGenerationResponse(object):
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
        'account_access_code': 'str',
        'access_url': 'str'
    }

    attribute_map = {
        'account_access_code': 'accountAccessCode',
        'access_url': 'accessUrl'
    }

    def __init__(self, account_access_code=None, access_url=None):  # noqa: E501
        """AccountAccessCodeGenerationResponse - a model defined in Swagger"""  # noqa: E501
        self._account_access_code = None
        self._access_url = None
        self.discriminator = None
        self.account_access_code = account_access_code
        self.access_url = access_url

    @property
    def account_access_code(self):
        """Gets the account_access_code of this AccountAccessCodeGenerationResponse.  # noqa: E501

        Account access Code which will be used to see the clear account number  # noqa: E501

        :return: The account_access_code of this AccountAccessCodeGenerationResponse.  # noqa: E501
        :rtype: str
        """
        return self._account_access_code

    @account_access_code.setter
    def account_access_code(self, account_access_code):
        """Sets the account_access_code of this AccountAccessCodeGenerationResponse.

        Account access Code which will be used to see the clear account number  # noqa: E501

        :param account_access_code: The account_access_code of this AccountAccessCodeGenerationResponse.  # noqa: E501
        :type: str
        """
        if account_access_code is None:
            raise ValueError("Invalid value for `account_access_code`, must not be `None`")  # noqa: E501

        self._account_access_code = account_access_code

    @property
    def access_url(self):
        """Gets the access_url of this AccountAccessCodeGenerationResponse.  # noqa: E501

        URL for viewing clear account number  # noqa: E501

        :return: The access_url of this AccountAccessCodeGenerationResponse.  # noqa: E501
        :rtype: str
        """
        return self._access_url

    @access_url.setter
    def access_url(self, access_url):
        """Sets the access_url of this AccountAccessCodeGenerationResponse.

        URL for viewing clear account number  # noqa: E501

        :param access_url: The access_url of this AccountAccessCodeGenerationResponse.  # noqa: E501
        :type: str
        """
        if access_url is None:
            raise ValueError("Invalid value for `access_url`, must not be `None`")  # noqa: E501

        self._access_url = access_url

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
        if issubclass(AccountAccessCodeGenerationResponse, dict):
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
        if not isinstance(other, AccountAccessCodeGenerationResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
