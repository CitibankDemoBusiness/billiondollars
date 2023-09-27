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

class ECMCreditCardProductUpdate(object):
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
        'billing_address': 'str',
        'card_delivery_address': 'str',
        'pin_delivery_address': 'str'
    }

    attribute_map = {
        'billing_address': 'billingAddress',
        'card_delivery_address': 'cardDeliveryAddress',
        'pin_delivery_address': 'pinDeliveryAddress'
    }

    def __init__(self, billing_address=None, card_delivery_address=None, pin_delivery_address=None):  # noqa: E501
        """ECMCreditCardProductUpdate - a model defined in Swagger"""  # noqa: E501
        self._billing_address = None
        self._card_delivery_address = None
        self._pin_delivery_address = None
        self.discriminator = None
        if billing_address is not None:
            self.billing_address = billing_address
        if card_delivery_address is not None:
            self.card_delivery_address = card_delivery_address
        if pin_delivery_address is not None:
            self.pin_delivery_address = pin_delivery_address

    @property
    def billing_address(self):
        """Gets the billing_address of this ECMCreditCardProductUpdate.  # noqa: E501

        Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.  # noqa: E501

        :return: The billing_address of this ECMCreditCardProductUpdate.  # noqa: E501
        :rtype: str
        """
        return self._billing_address

    @billing_address.setter
    def billing_address(self, billing_address):
        """Sets the billing_address of this ECMCreditCardProductUpdate.

        Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.  # noqa: E501

        :param billing_address: The billing_address of this ECMCreditCardProductUpdate.  # noqa: E501
        :type: str
        """

        self._billing_address = billing_address

    @property
    def card_delivery_address(self):
        """Gets the card_delivery_address of this ECMCreditCardProductUpdate.  # noqa: E501

        Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.  # noqa: E501

        :return: The card_delivery_address of this ECMCreditCardProductUpdate.  # noqa: E501
        :rtype: str
        """
        return self._card_delivery_address

    @card_delivery_address.setter
    def card_delivery_address(self, card_delivery_address):
        """Sets the card_delivery_address of this ECMCreditCardProductUpdate.

        Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.  # noqa: E501

        :param card_delivery_address: The card_delivery_address of this ECMCreditCardProductUpdate.  # noqa: E501
        :type: str
        """

        self._card_delivery_address = card_delivery_address

    @property
    def pin_delivery_address(self):
        """Gets the pin_delivery_address of this ECMCreditCardProductUpdate.  # noqa: E501

        Delivery address for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.  # noqa: E501

        :return: The pin_delivery_address of this ECMCreditCardProductUpdate.  # noqa: E501
        :rtype: str
        """
        return self._pin_delivery_address

    @pin_delivery_address.setter
    def pin_delivery_address(self, pin_delivery_address):
        """Sets the pin_delivery_address of this ECMCreditCardProductUpdate.

        Delivery address for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.  # noqa: E501

        :param pin_delivery_address: The pin_delivery_address of this ECMCreditCardProductUpdate.  # noqa: E501
        :type: str
        """

        self._pin_delivery_address = pin_delivery_address

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
        if issubclass(ECMCreditCardProductUpdate, dict):
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
        if not isinstance(other, ECMCreditCardProductUpdate):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
