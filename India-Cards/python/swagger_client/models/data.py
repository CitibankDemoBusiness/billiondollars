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

class Data(object):
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
        'product_details': 'DataProductDetails',
        'requirements': 'DataRequirements',
        'product_offerings': 'DataProductOfferings',
        'fees_charges': 'DataFeesCharges',
        'promotions': 'DataPromotions'
    }

    attribute_map = {
        'product_details': 'product_details',
        'requirements': 'requirements',
        'product_offerings': 'product_offerings',
        'fees_charges': 'fees_charges',
        'promotions': 'promotions'
    }

    def __init__(self, product_details=None, requirements=None, product_offerings=None, fees_charges=None, promotions=None):  # noqa: E501
        """Data - a model defined in Swagger"""  # noqa: E501
        self._product_details = None
        self._requirements = None
        self._product_offerings = None
        self._fees_charges = None
        self._promotions = None
        self.discriminator = None
        if product_details is not None:
            self.product_details = product_details
        if requirements is not None:
            self.requirements = requirements
        if product_offerings is not None:
            self.product_offerings = product_offerings
        if fees_charges is not None:
            self.fees_charges = fees_charges
        if promotions is not None:
            self.promotions = promotions

    @property
    def product_details(self):
        """Gets the product_details of this Data.  # noqa: E501


        :return: The product_details of this Data.  # noqa: E501
        :rtype: DataProductDetails
        """
        return self._product_details

    @product_details.setter
    def product_details(self, product_details):
        """Sets the product_details of this Data.


        :param product_details: The product_details of this Data.  # noqa: E501
        :type: DataProductDetails
        """

        self._product_details = product_details

    @property
    def requirements(self):
        """Gets the requirements of this Data.  # noqa: E501


        :return: The requirements of this Data.  # noqa: E501
        :rtype: DataRequirements
        """
        return self._requirements

    @requirements.setter
    def requirements(self, requirements):
        """Sets the requirements of this Data.


        :param requirements: The requirements of this Data.  # noqa: E501
        :type: DataRequirements
        """

        self._requirements = requirements

    @property
    def product_offerings(self):
        """Gets the product_offerings of this Data.  # noqa: E501


        :return: The product_offerings of this Data.  # noqa: E501
        :rtype: DataProductOfferings
        """
        return self._product_offerings

    @product_offerings.setter
    def product_offerings(self, product_offerings):
        """Sets the product_offerings of this Data.


        :param product_offerings: The product_offerings of this Data.  # noqa: E501
        :type: DataProductOfferings
        """

        self._product_offerings = product_offerings

    @property
    def fees_charges(self):
        """Gets the fees_charges of this Data.  # noqa: E501


        :return: The fees_charges of this Data.  # noqa: E501
        :rtype: DataFeesCharges
        """
        return self._fees_charges

    @fees_charges.setter
    def fees_charges(self, fees_charges):
        """Sets the fees_charges of this Data.


        :param fees_charges: The fees_charges of this Data.  # noqa: E501
        :type: DataFeesCharges
        """

        self._fees_charges = fees_charges

    @property
    def promotions(self):
        """Gets the promotions of this Data.  # noqa: E501


        :return: The promotions of this Data.  # noqa: E501
        :rtype: DataPromotions
        """
        return self._promotions

    @promotions.setter
    def promotions(self, promotions):
        """Sets the promotions of this Data.


        :param promotions: The promotions of this Data.  # noqa: E501
        :type: DataPromotions
        """

        self._promotions = promotions

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
        if issubclass(Data, dict):
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
        if not isinstance(other, Data):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
