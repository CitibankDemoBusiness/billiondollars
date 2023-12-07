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

class ApplicationInquiryResponse(object):
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
        'has_any_supplementary_flag': 'bool',
        'ipa_expiry_date': 'date',
        'product': 'ApplicationInquiryProduct',
        'applicant': 'ApplicationInquiryApplicant',
        'requested_product_decision': 'list[ApplicationInquiryRequestedProductDecision]',
        'counter_offers': 'list[ApplicationInquiryCounterOffer]',
        'cross_sell_offers': 'list[ApplicationInquiryCrossSellOffer]'
    }

    attribute_map = {
        'application_stage': 'applicationStage',
        'has_any_supplementary_flag': 'hasAnySupplementaryFlag',
        'ipa_expiry_date': 'ipaExpiryDate',
        'product': 'product',
        'applicant': 'applicant',
        'requested_product_decision': 'requestedProductDecision',
        'counter_offers': 'counterOffers',
        'cross_sell_offers': 'crossSellOffers'
    }

    def __init__(self, application_stage=None, has_any_supplementary_flag=None, ipa_expiry_date=None, product=None, applicant=None, requested_product_decision=None, counter_offers=None, cross_sell_offers=None):  # noqa: E501
        """ApplicationInquiryResponse - a model defined in Swagger"""  # noqa: E501
        self._application_stage = None
        self._has_any_supplementary_flag = None
        self._ipa_expiry_date = None
        self._product = None
        self._applicant = None
        self._requested_product_decision = None
        self._counter_offers = None
        self._cross_sell_offers = None
        self.discriminator = None
        self.application_stage = application_stage
        if has_any_supplementary_flag is not None:
            self.has_any_supplementary_flag = has_any_supplementary_flag
        if ipa_expiry_date is not None:
            self.ipa_expiry_date = ipa_expiry_date
        self.product = product
        self.applicant = applicant
        if requested_product_decision is not None:
            self.requested_product_decision = requested_product_decision
        if counter_offers is not None:
            self.counter_offers = counter_offers
        if cross_sell_offers is not None:
            self.cross_sell_offers = cross_sell_offers

    @property
    def application_stage(self):
        """Gets the application_stage of this ApplicationInquiryResponse.  # noqa: E501

        Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The application_stage of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: str
        """
        return self._application_stage

    @application_stage.setter
    def application_stage(self, application_stage):
        """Sets the application_stage of this ApplicationInquiryResponse.

        Current stage of an application.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. You can use applicationStage field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param application_stage: The application_stage of this ApplicationInquiryResponse.  # noqa: E501
        :type: str
        """
        if application_stage is None:
            raise ValueError("Invalid value for `application_stage`, must not be `None`")  # noqa: E501

        self._application_stage = application_stage

    @property
    def has_any_supplementary_flag(self):
        """Gets the has_any_supplementary_flag of this ApplicationInquiryResponse.  # noqa: E501

        Flag indicating whether the primary applicant has any supplementary.  # noqa: E501

        :return: The has_any_supplementary_flag of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: bool
        """
        return self._has_any_supplementary_flag

    @has_any_supplementary_flag.setter
    def has_any_supplementary_flag(self, has_any_supplementary_flag):
        """Sets the has_any_supplementary_flag of this ApplicationInquiryResponse.

        Flag indicating whether the primary applicant has any supplementary.  # noqa: E501

        :param has_any_supplementary_flag: The has_any_supplementary_flag of this ApplicationInquiryResponse.  # noqa: E501
        :type: bool
        """

        self._has_any_supplementary_flag = has_any_supplementary_flag

    @property
    def ipa_expiry_date(self):
        """Gets the ipa_expiry_date of this ApplicationInquiryResponse.  # noqa: E501

        In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The ipa_expiry_date of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: date
        """
        return self._ipa_expiry_date

    @ipa_expiry_date.setter
    def ipa_expiry_date(self, ipa_expiry_date):
        """Sets the ipa_expiry_date of this ApplicationInquiryResponse.

        In principle approval expiration date in  ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param ipa_expiry_date: The ipa_expiry_date of this ApplicationInquiryResponse.  # noqa: E501
        :type: date
        """

        self._ipa_expiry_date = ipa_expiry_date

    @property
    def product(self):
        """Gets the product of this ApplicationInquiryResponse.  # noqa: E501


        :return: The product of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: ApplicationInquiryProduct
        """
        return self._product

    @product.setter
    def product(self, product):
        """Sets the product of this ApplicationInquiryResponse.


        :param product: The product of this ApplicationInquiryResponse.  # noqa: E501
        :type: ApplicationInquiryProduct
        """
        if product is None:
            raise ValueError("Invalid value for `product`, must not be `None`")  # noqa: E501

        self._product = product

    @property
    def applicant(self):
        """Gets the applicant of this ApplicationInquiryResponse.  # noqa: E501


        :return: The applicant of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: ApplicationInquiryApplicant
        """
        return self._applicant

    @applicant.setter
    def applicant(self, applicant):
        """Sets the applicant of this ApplicationInquiryResponse.


        :param applicant: The applicant of this ApplicationInquiryResponse.  # noqa: E501
        :type: ApplicationInquiryApplicant
        """
        if applicant is None:
            raise ValueError("Invalid value for `applicant`, must not be `None`")  # noqa: E501

        self._applicant = applicant

    @property
    def requested_product_decision(self):
        """Gets the requested_product_decision of this ApplicationInquiryResponse.  # noqa: E501


        :return: The requested_product_decision of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: list[ApplicationInquiryRequestedProductDecision]
        """
        return self._requested_product_decision

    @requested_product_decision.setter
    def requested_product_decision(self, requested_product_decision):
        """Sets the requested_product_decision of this ApplicationInquiryResponse.


        :param requested_product_decision: The requested_product_decision of this ApplicationInquiryResponse.  # noqa: E501
        :type: list[ApplicationInquiryRequestedProductDecision]
        """

        self._requested_product_decision = requested_product_decision

    @property
    def counter_offers(self):
        """Gets the counter_offers of this ApplicationInquiryResponse.  # noqa: E501


        :return: The counter_offers of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: list[ApplicationInquiryCounterOffer]
        """
        return self._counter_offers

    @counter_offers.setter
    def counter_offers(self, counter_offers):
        """Sets the counter_offers of this ApplicationInquiryResponse.


        :param counter_offers: The counter_offers of this ApplicationInquiryResponse.  # noqa: E501
        :type: list[ApplicationInquiryCounterOffer]
        """

        self._counter_offers = counter_offers

    @property
    def cross_sell_offers(self):
        """Gets the cross_sell_offers of this ApplicationInquiryResponse.  # noqa: E501


        :return: The cross_sell_offers of this ApplicationInquiryResponse.  # noqa: E501
        :rtype: list[ApplicationInquiryCrossSellOffer]
        """
        return self._cross_sell_offers

    @cross_sell_offers.setter
    def cross_sell_offers(self, cross_sell_offers):
        """Sets the cross_sell_offers of this ApplicationInquiryResponse.


        :param cross_sell_offers: The cross_sell_offers of this ApplicationInquiryResponse.  # noqa: E501
        :type: list[ApplicationInquiryCrossSellOffer]
        """

        self._cross_sell_offers = cross_sell_offers

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
        if issubclass(ApplicationInquiryResponse, dict):
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
        if not isinstance(other, ApplicationInquiryResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
