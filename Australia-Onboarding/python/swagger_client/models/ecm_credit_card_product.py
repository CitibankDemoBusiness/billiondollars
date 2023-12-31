# coding: utf-8

"""
    Onboarding

    The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ECMCreditCardProduct(object):
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
        'gift_code': 'str'
    }

    attribute_map = {
        'gift_code': 'giftCode'
    }

    def __init__(self, gift_code=None):  # noqa: E501
        """ECMCreditCardProduct - a model defined in Swagger"""  # noqa: E501
        self._gift_code = None
        self.discriminator = None
        if gift_code is not None:
            self.gift_code = gift_code

    @property
    def gift_code(self):
        """Gets the gift_code of this ECMCreditCardProduct.  # noqa: E501

        A unique code that identifies the gift offered along with the product  # noqa: E501

        :return: The gift_code of this ECMCreditCardProduct.  # noqa: E501
        :rtype: str
        """
        return self._gift_code

    @gift_code.setter
    def gift_code(self, gift_code):
        """Sets the gift_code of this ECMCreditCardProduct.

        A unique code that identifies the gift offered along with the product  # noqa: E501

        :param gift_code: The gift_code of this ECMCreditCardProduct.  # noqa: E501
        :type: str
        """

        self._gift_code = gift_code

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
        if issubclass(ECMCreditCardProduct, dict):
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
        if not isinstance(other, ECMCreditCardProduct):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
