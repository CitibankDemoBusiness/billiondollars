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

class ApplicationInquiryCrossSellOffer(object):
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
        'offer_product_code': 'str',
        'offer_product_organisation': 'str',
        'offer_source_code': 'str',
        'credit_specific_recommendations': 'list[ApplicationInquiryCreditSpecificRecommendations]',
        'loan_specific_recommendations': 'list[ApplicationInquiryLoanSpecificRecommendations]',
        'required_documents': 'list[ApplicationInquiryRequiredDocuments]'
    }

    attribute_map = {
        'offer_product_code': 'offerProductCode',
        'offer_product_organisation': 'offerProductOrganisation',
        'offer_source_code': 'offerSourceCode',
        'credit_specific_recommendations': 'creditSpecificRecommendations',
        'loan_specific_recommendations': 'loanSpecificRecommendations',
        'required_documents': 'requiredDocuments'
    }

    def __init__(self, offer_product_code=None, offer_product_organisation=None, offer_source_code=None, credit_specific_recommendations=None, loan_specific_recommendations=None, required_documents=None):  # noqa: E501
        """ApplicationInquiryCrossSellOffer - a model defined in Swagger"""  # noqa: E501
        self._offer_product_code = None
        self._offer_product_organisation = None
        self._offer_source_code = None
        self._credit_specific_recommendations = None
        self._loan_specific_recommendations = None
        self._required_documents = None
        self.discriminator = None
        if offer_product_code is not None:
            self.offer_product_code = offer_product_code
        if offer_product_organisation is not None:
            self.offer_product_organisation = offer_product_organisation
        if offer_source_code is not None:
            self.offer_source_code = offer_source_code
        if credit_specific_recommendations is not None:
            self.credit_specific_recommendations = credit_specific_recommendations
        if loan_specific_recommendations is not None:
            self.loan_specific_recommendations = loan_specific_recommendations
        if required_documents is not None:
            self.required_documents = required_documents

    @property
    def offer_product_code(self):
        """Gets the offer_product_code of this ApplicationInquiryCrossSellOffer.  # noqa: E501

        A unique code that identifies the offered product to applicant  # noqa: E501

        :return: The offer_product_code of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :rtype: str
        """
        return self._offer_product_code

    @offer_product_code.setter
    def offer_product_code(self, offer_product_code):
        """Sets the offer_product_code of this ApplicationInquiryCrossSellOffer.

        A unique code that identifies the offered product to applicant  # noqa: E501

        :param offer_product_code: The offer_product_code of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :type: str
        """

        self._offer_product_code = offer_product_code

    @property
    def offer_product_organisation(self):
        """Gets the offer_product_organisation of this ApplicationInquiryCrossSellOffer.  # noqa: E501

        Offered card issuing organization name  # noqa: E501

        :return: The offer_product_organisation of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :rtype: str
        """
        return self._offer_product_organisation

    @offer_product_organisation.setter
    def offer_product_organisation(self, offer_product_organisation):
        """Sets the offer_product_organisation of this ApplicationInquiryCrossSellOffer.

        Offered card issuing organization name  # noqa: E501

        :param offer_product_organisation: The offer_product_organisation of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :type: str
        """

        self._offer_product_organisation = offer_product_organisation

    @property
    def offer_source_code(self):
        """Gets the offer_source_code of this ApplicationInquiryCrossSellOffer.  # noqa: E501

        A source code to identify the product  # noqa: E501

        :return: The offer_source_code of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :rtype: str
        """
        return self._offer_source_code

    @offer_source_code.setter
    def offer_source_code(self, offer_source_code):
        """Sets the offer_source_code of this ApplicationInquiryCrossSellOffer.

        A source code to identify the product  # noqa: E501

        :param offer_source_code: The offer_source_code of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :type: str
        """

        self._offer_source_code = offer_source_code

    @property
    def credit_specific_recommendations(self):
        """Gets the credit_specific_recommendations of this ApplicationInquiryCrossSellOffer.  # noqa: E501


        :return: The credit_specific_recommendations of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :rtype: list[ApplicationInquiryCreditSpecificRecommendations]
        """
        return self._credit_specific_recommendations

    @credit_specific_recommendations.setter
    def credit_specific_recommendations(self, credit_specific_recommendations):
        """Sets the credit_specific_recommendations of this ApplicationInquiryCrossSellOffer.


        :param credit_specific_recommendations: The credit_specific_recommendations of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :type: list[ApplicationInquiryCreditSpecificRecommendations]
        """

        self._credit_specific_recommendations = credit_specific_recommendations

    @property
    def loan_specific_recommendations(self):
        """Gets the loan_specific_recommendations of this ApplicationInquiryCrossSellOffer.  # noqa: E501


        :return: The loan_specific_recommendations of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :rtype: list[ApplicationInquiryLoanSpecificRecommendations]
        """
        return self._loan_specific_recommendations

    @loan_specific_recommendations.setter
    def loan_specific_recommendations(self, loan_specific_recommendations):
        """Sets the loan_specific_recommendations of this ApplicationInquiryCrossSellOffer.


        :param loan_specific_recommendations: The loan_specific_recommendations of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :type: list[ApplicationInquiryLoanSpecificRecommendations]
        """

        self._loan_specific_recommendations = loan_specific_recommendations

    @property
    def required_documents(self):
        """Gets the required_documents of this ApplicationInquiryCrossSellOffer.  # noqa: E501


        :return: The required_documents of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :rtype: list[ApplicationInquiryRequiredDocuments]
        """
        return self._required_documents

    @required_documents.setter
    def required_documents(self, required_documents):
        """Sets the required_documents of this ApplicationInquiryCrossSellOffer.


        :param required_documents: The required_documents of this ApplicationInquiryCrossSellOffer.  # noqa: E501
        :type: list[ApplicationInquiryRequiredDocuments]
        """

        self._required_documents = required_documents

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
        if issubclass(ApplicationInquiryCrossSellOffer, dict):
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
        if not isinstance(other, ApplicationInquiryCrossSellOffer):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
