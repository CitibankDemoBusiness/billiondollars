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

class ECMAdditionalData(object):
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
        'fee_code': 'str',
        'country_specific_group': 'ECMCountrySpecificGroup',
        'introducer_id': 'str',
        'referral_tracking': 'ReferralTracking',
        'media_id': 'str'
    }

    attribute_map = {
        'fee_code': 'feeCode',
        'country_specific_group': 'countrySpecificGroup',
        'introducer_id': 'introducerId',
        'referral_tracking': 'referralTracking',
        'media_id': 'mediaId'
    }

    def __init__(self, fee_code=None, country_specific_group=None, introducer_id=None, referral_tracking=None, media_id=None):  # noqa: E501
        """ECMAdditionalData - a model defined in Swagger"""  # noqa: E501
        self._fee_code = None
        self._country_specific_group = None
        self._introducer_id = None
        self._referral_tracking = None
        self._media_id = None
        self.discriminator = None
        if fee_code is not None:
            self.fee_code = fee_code
        if country_specific_group is not None:
            self.country_specific_group = country_specific_group
        if introducer_id is not None:
            self.introducer_id = introducer_id
        if referral_tracking is not None:
            self.referral_tracking = referral_tracking
        if media_id is not None:
            self.media_id = media_id

    @property
    def fee_code(self):
        """Gets the fee_code of this ECMAdditionalData.  # noqa: E501

        Fee code that applied to the requested product  # noqa: E501

        :return: The fee_code of this ECMAdditionalData.  # noqa: E501
        :rtype: str
        """
        return self._fee_code

    @fee_code.setter
    def fee_code(self, fee_code):
        """Sets the fee_code of this ECMAdditionalData.

        Fee code that applied to the requested product  # noqa: E501

        :param fee_code: The fee_code of this ECMAdditionalData.  # noqa: E501
        :type: str
        """

        self._fee_code = fee_code

    @property
    def country_specific_group(self):
        """Gets the country_specific_group of this ECMAdditionalData.  # noqa: E501


        :return: The country_specific_group of this ECMAdditionalData.  # noqa: E501
        :rtype: ECMCountrySpecificGroup
        """
        return self._country_specific_group

    @country_specific_group.setter
    def country_specific_group(self, country_specific_group):
        """Sets the country_specific_group of this ECMAdditionalData.


        :param country_specific_group: The country_specific_group of this ECMAdditionalData.  # noqa: E501
        :type: ECMCountrySpecificGroup
        """

        self._country_specific_group = country_specific_group

    @property
    def introducer_id(self):
        """Gets the introducer_id of this ECMAdditionalData.  # noqa: E501

        Unique identifier associated with the introducer who had referred the applicant.  # noqa: E501

        :return: The introducer_id of this ECMAdditionalData.  # noqa: E501
        :rtype: str
        """
        return self._introducer_id

    @introducer_id.setter
    def introducer_id(self, introducer_id):
        """Sets the introducer_id of this ECMAdditionalData.

        Unique identifier associated with the introducer who had referred the applicant.  # noqa: E501

        :param introducer_id: The introducer_id of this ECMAdditionalData.  # noqa: E501
        :type: str
        """

        self._introducer_id = introducer_id

    @property
    def referral_tracking(self):
        """Gets the referral_tracking of this ECMAdditionalData.  # noqa: E501


        :return: The referral_tracking of this ECMAdditionalData.  # noqa: E501
        :rtype: ReferralTracking
        """
        return self._referral_tracking

    @referral_tracking.setter
    def referral_tracking(self, referral_tracking):
        """Sets the referral_tracking of this ECMAdditionalData.


        :param referral_tracking: The referral_tracking of this ECMAdditionalData.  # noqa: E501
        :type: ReferralTracking
        """

        self._referral_tracking = referral_tracking

    @property
    def media_id(self):
        """Gets the media_id of this ECMAdditionalData.  # noqa: E501

        The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application  # noqa: E501

        :return: The media_id of this ECMAdditionalData.  # noqa: E501
        :rtype: str
        """
        return self._media_id

    @media_id.setter
    def media_id(self, media_id):
        """Sets the media_id of this ECMAdditionalData.

        The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application  # noqa: E501

        :param media_id: The media_id of this ECMAdditionalData.  # noqa: E501
        :type: str
        """

        self._media_id = media_id

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
        if issubclass(ECMAdditionalData, dict):
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
        if not isinstance(other, ECMAdditionalData):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
