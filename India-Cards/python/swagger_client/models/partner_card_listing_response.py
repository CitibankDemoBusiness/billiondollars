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

class PartnerCardListingResponse(object):
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
        'partner_card_details': 'list[PartnerCardDetails]'
    }

    attribute_map = {
        'partner_card_details': 'partnerCardDetails'
    }

    def __init__(self, partner_card_details=None):  # noqa: E501
        """PartnerCardListingResponse - a model defined in Swagger"""  # noqa: E501
        self._partner_card_details = None
        self.discriminator = None
        if partner_card_details is not None:
            self.partner_card_details = partner_card_details

    @property
    def partner_card_details(self):
        """Gets the partner_card_details of this PartnerCardListingResponse.  # noqa: E501


        :return: The partner_card_details of this PartnerCardListingResponse.  # noqa: E501
        :rtype: list[PartnerCardDetails]
        """
        return self._partner_card_details

    @partner_card_details.setter
    def partner_card_details(self, partner_card_details):
        """Sets the partner_card_details of this PartnerCardListingResponse.


        :param partner_card_details: The partner_card_details of this PartnerCardListingResponse.  # noqa: E501
        :type: list[PartnerCardDetails]
        """

        self._partner_card_details = partner_card_details

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
        if issubclass(PartnerCardListingResponse, dict):
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
        if not isinstance(other, PartnerCardListingResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
