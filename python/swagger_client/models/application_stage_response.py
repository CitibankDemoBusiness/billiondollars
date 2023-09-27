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

class ApplicationStageResponse(object):
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
        'application_stage': 'str',
        'ipa_expiry_date': 'date'
    }

    attribute_map = {
        'application_stage': 'applicationStage',
        'ipa_expiry_date': 'ipaExpiryDate'
    }

    def __init__(self, application_stage=None, ipa_expiry_date=None):  # noqa: E501
        """ApplicationStageResponse - a model defined in Swagger"""  # noqa: E501
        self._application_stage = None
        self._ipa_expiry_date = None
        self.discriminator = None
        self.application_stage = application_stage
        if ipa_expiry_date is not None:
            self.ipa_expiry_date = ipa_expiry_date

    @property
    def application_stage(self):
        """Gets the application_stage of this ApplicationStageResponse.  # noqa: E501

        Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The application_stage of this ApplicationStageResponse.  # noqa: E501
        :rtype: str
        """
        return self._application_stage

    @application_stage.setter
    def application_stage(self, application_stage):
        """Sets the application_stage of this ApplicationStageResponse.

        Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param application_stage: The application_stage of this ApplicationStageResponse.  # noqa: E501
        :type: str
        """
        if application_stage is None:
            raise ValueError("Invalid value for `application_stage`, must not be `None`")  # noqa: E501

        self._application_stage = application_stage

    @property
    def ipa_expiry_date(self):
        """Gets the ipa_expiry_date of this ApplicationStageResponse.  # noqa: E501

        In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The ipa_expiry_date of this ApplicationStageResponse.  # noqa: E501
        :rtype: date
        """
        return self._ipa_expiry_date

    @ipa_expiry_date.setter
    def ipa_expiry_date(self, ipa_expiry_date):
        """Sets the ipa_expiry_date of this ApplicationStageResponse.

        In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param ipa_expiry_date: The ipa_expiry_date of this ApplicationStageResponse.  # noqa: E501
        :type: date
        """

        self._ipa_expiry_date = ipa_expiry_date

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
        if issubclass(ApplicationStageResponse, dict):
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
        if not isinstance(other, ApplicationStageResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
