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

class DataRequirementsDocument(object):
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
        'item': 'str',
        'remark': 'str'
    }

    attribute_map = {
        'item': 'item',
        'remark': 'remark'
    }

    def __init__(self, item=None, remark=None):  # noqa: E501
        """DataRequirementsDocument - a model defined in Swagger"""  # noqa: E501
        self._item = None
        self._remark = None
        self.discriminator = None
        if item is not None:
            self.item = item
        if remark is not None:
            self.remark = remark

    @property
    def item(self):
        """Gets the item of this DataRequirementsDocument.  # noqa: E501

        Type of document  # noqa: E501

        :return: The item of this DataRequirementsDocument.  # noqa: E501
        :rtype: str
        """
        return self._item

    @item.setter
    def item(self, item):
        """Sets the item of this DataRequirementsDocument.

        Type of document  # noqa: E501

        :param item: The item of this DataRequirementsDocument.  # noqa: E501
        :type: str
        """
        allowed_values = ["bank_statement", "business_registration_certificate", "commision_statement", "dividend_statement", "employment_confirmation_letter", "epf_statement", "form_24", "form_49", "form_9", "identity_card_passport", "interest_statement", "others", "salary_slip", "tax_receipt", "tax_returns", "travel_visa", "valid_work_permit"]  # noqa: E501
        if item not in allowed_values:
            raise ValueError(
                "Invalid value for `item` ({0}), must be one of {1}"  # noqa: E501
                .format(item, allowed_values)
            )

        self._item = item

    @property
    def remark(self):
        """Gets the remark of this DataRequirementsDocument.  # noqa: E501

        Additional note for the document  # noqa: E501

        :return: The remark of this DataRequirementsDocument.  # noqa: E501
        :rtype: str
        """
        return self._remark

    @remark.setter
    def remark(self, remark):
        """Sets the remark of this DataRequirementsDocument.

        Additional note for the document  # noqa: E501

        :param remark: The remark of this DataRequirementsDocument.  # noqa: E501
        :type: str
        """

        self._remark = remark

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
        if issubclass(DataRequirementsDocument, dict):
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
        if not isinstance(other, DataRequirementsDocument):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
