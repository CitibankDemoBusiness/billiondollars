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

class Meta(object):
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
        'bic_code': 'str',
        'last_updated': 'datetime',
        'version': 'str',
        'total_result': 'int',
        'campaign_url': 'str'
    }

    attribute_map = {
        'bic_code': 'bic_code',
        'last_updated': 'last_updated',
        'version': 'version',
        'total_result': 'total_result',
        'campaign_url': 'campaign_url'
    }

    def __init__(self, bic_code=None, last_updated=None, version=None, total_result=None, campaign_url=None):  # noqa: E501
        """Meta - a model defined in Swagger"""  # noqa: E501
        self._bic_code = None
        self._last_updated = None
        self._version = None
        self._total_result = None
        self._campaign_url = None
        self.discriminator = None
        self.bic_code = bic_code
        self.last_updated = last_updated
        self.version = version
        self.total_result = total_result
        if campaign_url is not None:
            self.campaign_url = campaign_url

    @property
    def bic_code(self):
        """Gets the bic_code of this Meta.  # noqa: E501

        8-characters SWIFT code  # noqa: E501

        :return: The bic_code of this Meta.  # noqa: E501
        :rtype: str
        """
        return self._bic_code

    @bic_code.setter
    def bic_code(self, bic_code):
        """Sets the bic_code of this Meta.

        8-characters SWIFT code  # noqa: E501

        :param bic_code: The bic_code of this Meta.  # noqa: E501
        :type: str
        """
        if bic_code is None:
            raise ValueError("Invalid value for `bic_code`, must not be `None`")  # noqa: E501

        self._bic_code = bic_code

    @property
    def last_updated(self):
        """Gets the last_updated of this Meta.  # noqa: E501

        Last updated date of product list  # noqa: E501

        :return: The last_updated of this Meta.  # noqa: E501
        :rtype: datetime
        """
        return self._last_updated

    @last_updated.setter
    def last_updated(self, last_updated):
        """Sets the last_updated of this Meta.

        Last updated date of product list  # noqa: E501

        :param last_updated: The last_updated of this Meta.  # noqa: E501
        :type: datetime
        """
        if last_updated is None:
            raise ValueError("Invalid value for `last_updated`, must not be `None`")  # noqa: E501

        self._last_updated = last_updated

    @property
    def version(self):
        """Gets the version of this Meta.  # noqa: E501

        API version as published https://github.com/BankNegaraMY/oapi-banking  # noqa: E501

        :return: The version of this Meta.  # noqa: E501
        :rtype: str
        """
        return self._version

    @version.setter
    def version(self, version):
        """Sets the version of this Meta.

        API version as published https://github.com/BankNegaraMY/oapi-banking  # noqa: E501

        :param version: The version of this Meta.  # noqa: E501
        :type: str
        """
        if version is None:
            raise ValueError("Invalid value for `version`, must not be `None`")  # noqa: E501

        self._version = version

    @property
    def total_result(self):
        """Gets the total_result of this Meta.  # noqa: E501

        Number of products returned  # noqa: E501

        :return: The total_result of this Meta.  # noqa: E501
        :rtype: int
        """
        return self._total_result

    @total_result.setter
    def total_result(self, total_result):
        """Sets the total_result of this Meta.

        Number of products returned  # noqa: E501

        :param total_result: The total_result of this Meta.  # noqa: E501
        :type: int
        """
        if total_result is None:
            raise ValueError("Invalid value for `total_result`, must not be `None`")  # noqa: E501

        self._total_result = total_result

    @property
    def campaign_url(self):
        """Gets the campaign_url of this Meta.  # noqa: E501

        Absolute URL to active campaign or promotions  # noqa: E501

        :return: The campaign_url of this Meta.  # noqa: E501
        :rtype: str
        """
        return self._campaign_url

    @campaign_url.setter
    def campaign_url(self, campaign_url):
        """Sets the campaign_url of this Meta.

        Absolute URL to active campaign or promotions  # noqa: E501

        :param campaign_url: The campaign_url of this Meta.  # noqa: E501
        :type: str
        """

        self._campaign_url = campaign_url

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
        if issubclass(Meta, dict):
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
        if not isinstance(other, Meta):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other