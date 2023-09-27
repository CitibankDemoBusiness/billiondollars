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

class ApplicationInquiryDemographics(object):
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
        'gender': 'str',
        'date_of_birth': 'date',
        'place_of_birth': 'str',
        'country_of_birth': 'str',
        'nationality': 'str',
        'domicile_country_code': 'str',
        'permanent_residency_country_code': 'str',
        'marital_status': 'str',
        'residency_status': 'str',
        'residence_type': 'str',
        'tax_domicile_country_code': 'str',
        'spoken_language_code': 'str',
        'correspondence_language_code': 'str'
    }

    attribute_map = {
        'gender': 'gender',
        'date_of_birth': 'dateOfBirth',
        'place_of_birth': 'placeOfBirth',
        'country_of_birth': 'countryOfBirth',
        'nationality': 'nationality',
        'domicile_country_code': 'domicileCountryCode',
        'permanent_residency_country_code': 'permanentResidencyCountryCode',
        'marital_status': 'maritalStatus',
        'residency_status': 'residencyStatus',
        'residence_type': 'residenceType',
        'tax_domicile_country_code': 'taxDomicileCountryCode',
        'spoken_language_code': 'spokenLanguageCode',
        'correspondence_language_code': 'correspondenceLanguageCode'
    }

    def __init__(self, gender=None, date_of_birth=None, place_of_birth=None, country_of_birth=None, nationality=None, domicile_country_code=None, permanent_residency_country_code=None, marital_status=None, residency_status=None, residence_type=None, tax_domicile_country_code=None, spoken_language_code=None, correspondence_language_code=None):  # noqa: E501
        """ApplicationInquiryDemographics - a model defined in Swagger"""  # noqa: E501
        self._gender = None
        self._date_of_birth = None
        self._place_of_birth = None
        self._country_of_birth = None
        self._nationality = None
        self._domicile_country_code = None
        self._permanent_residency_country_code = None
        self._marital_status = None
        self._residency_status = None
        self._residence_type = None
        self._tax_domicile_country_code = None
        self._spoken_language_code = None
        self._correspondence_language_code = None
        self.discriminator = None
        if gender is not None:
            self.gender = gender
        if date_of_birth is not None:
            self.date_of_birth = date_of_birth
        if place_of_birth is not None:
            self.place_of_birth = place_of_birth
        if country_of_birth is not None:
            self.country_of_birth = country_of_birth
        if nationality is not None:
            self.nationality = nationality
        if domicile_country_code is not None:
            self.domicile_country_code = domicile_country_code
        if permanent_residency_country_code is not None:
            self.permanent_residency_country_code = permanent_residency_country_code
        if marital_status is not None:
            self.marital_status = marital_status
        if residency_status is not None:
            self.residency_status = residency_status
        if residence_type is not None:
            self.residence_type = residence_type
        if tax_domicile_country_code is not None:
            self.tax_domicile_country_code = tax_domicile_country_code
        if spoken_language_code is not None:
            self.spoken_language_code = spoken_language_code
        if correspondence_language_code is not None:
            self.correspondence_language_code = correspondence_language_code

    @property
    def gender(self):
        """Gets the gender of this ApplicationInquiryDemographics.  # noqa: E501

        Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The gender of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._gender

    @gender.setter
    def gender(self, gender):
        """Sets the gender of this ApplicationInquiryDemographics.

        Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param gender: The gender of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._gender = gender

    @property
    def date_of_birth(self):
        """Gets the date_of_birth of this ApplicationInquiryDemographics.  # noqa: E501

        Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The date_of_birth of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: date
        """
        return self._date_of_birth

    @date_of_birth.setter
    def date_of_birth(self, date_of_birth):
        """Sets the date_of_birth of this ApplicationInquiryDemographics.

        Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param date_of_birth: The date_of_birth of this ApplicationInquiryDemographics.  # noqa: E501
        :type: date
        """

        self._date_of_birth = date_of_birth

    @property
    def place_of_birth(self):
        """Gets the place_of_birth of this ApplicationInquiryDemographics.  # noqa: E501

        Applicant's place of birth  # noqa: E501

        :return: The place_of_birth of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._place_of_birth

    @place_of_birth.setter
    def place_of_birth(self, place_of_birth):
        """Sets the place_of_birth of this ApplicationInquiryDemographics.

        Applicant's place of birth  # noqa: E501

        :param place_of_birth: The place_of_birth of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._place_of_birth = place_of_birth

    @property
    def country_of_birth(self):
        """Gets the country_of_birth of this ApplicationInquiryDemographics.  # noqa: E501

        Applicant's Country of birth. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryOfBirth field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The country_of_birth of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._country_of_birth

    @country_of_birth.setter
    def country_of_birth(self, country_of_birth):
        """Sets the country_of_birth of this ApplicationInquiryDemographics.

        Applicant's Country of birth. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryOfBirth field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param country_of_birth: The country_of_birth of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._country_of_birth = country_of_birth

    @property
    def nationality(self):
        """Gets the nationality of this ApplicationInquiryDemographics.  # noqa: E501

        Applicant's nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The nationality of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._nationality

    @nationality.setter
    def nationality(self, nationality):
        """Sets the nationality of this ApplicationInquiryDemographics.

        Applicant's nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param nationality: The nationality of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._nationality = nationality

    @property
    def domicile_country_code(self):
        """Gets the domicile_country_code of this ApplicationInquiryDemographics.  # noqa: E501

        Domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The domicile_country_code of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._domicile_country_code

    @domicile_country_code.setter
    def domicile_country_code(self, domicile_country_code):
        """Sets the domicile_country_code of this ApplicationInquiryDemographics.

        Domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param domicile_country_code: The domicile_country_code of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._domicile_country_code = domicile_country_code

    @property
    def permanent_residency_country_code(self):
        """Gets the permanent_residency_country_code of this ApplicationInquiryDemographics.  # noqa: E501

        Permanent residency country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use domicileCountryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The permanent_residency_country_code of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._permanent_residency_country_code

    @permanent_residency_country_code.setter
    def permanent_residency_country_code(self, permanent_residency_country_code):
        """Sets the permanent_residency_country_code of this ApplicationInquiryDemographics.

        Permanent residency country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use domicileCountryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param permanent_residency_country_code: The permanent_residency_country_code of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._permanent_residency_country_code = permanent_residency_country_code

    @property
    def marital_status(self):
        """Gets the marital_status of this ApplicationInquiryDemographics.  # noqa: E501

        Applicant's marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The marital_status of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._marital_status

    @marital_status.setter
    def marital_status(self, marital_status):
        """Sets the marital_status of this ApplicationInquiryDemographics.

        Applicant's marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param marital_status: The marital_status of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._marital_status = marital_status

    @property
    def residency_status(self):
        """Gets the residency_status of this ApplicationInquiryDemographics.  # noqa: E501

        Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The residency_status of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._residency_status

    @residency_status.setter
    def residency_status(self, residency_status):
        """Sets the residency_status of this ApplicationInquiryDemographics.

        Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param residency_status: The residency_status of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._residency_status = residency_status

    @property
    def residence_type(self):
        """Gets the residence_type of this ApplicationInquiryDemographics.  # noqa: E501

        Type of Residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceType} resource to get valid value of this field with description. You can use residenceType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The residence_type of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._residence_type

    @residence_type.setter
    def residence_type(self, residence_type):
        """Sets the residence_type of this ApplicationInquiryDemographics.

        Type of Residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceType} resource to get valid value of this field with description. You can use residenceType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param residence_type: The residence_type of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._residence_type = residence_type

    @property
    def tax_domicile_country_code(self):
        """Gets the tax_domicile_country_code of this ApplicationInquiryDemographics.  # noqa: E501

        Tax domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use taxDomicileCountryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The tax_domicile_country_code of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._tax_domicile_country_code

    @tax_domicile_country_code.setter
    def tax_domicile_country_code(self, tax_domicile_country_code):
        """Sets the tax_domicile_country_code of this ApplicationInquiryDemographics.

        Tax domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use taxDomicileCountryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param tax_domicile_country_code: The tax_domicile_country_code of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._tax_domicile_country_code = tax_domicile_country_code

    @property
    def spoken_language_code(self):
        """Gets the spoken_language_code of this ApplicationInquiryDemographics.  # noqa: E501

        Code for spoken language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use spokenLanguageCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The spoken_language_code of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._spoken_language_code

    @spoken_language_code.setter
    def spoken_language_code(self, spoken_language_code):
        """Sets the spoken_language_code of this ApplicationInquiryDemographics.

        Code for spoken language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use spokenLanguageCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param spoken_language_code: The spoken_language_code of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._spoken_language_code = spoken_language_code

    @property
    def correspondence_language_code(self):
        """Gets the correspondence_language_code of this ApplicationInquiryDemographics.  # noqa: E501

        Code for correspondence language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use correspondenceLanguageCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The correspondence_language_code of this ApplicationInquiryDemographics.  # noqa: E501
        :rtype: str
        """
        return self._correspondence_language_code

    @correspondence_language_code.setter
    def correspondence_language_code(self, correspondence_language_code):
        """Sets the correspondence_language_code of this ApplicationInquiryDemographics.

        Code for correspondence language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use correspondenceLanguageCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param correspondence_language_code: The correspondence_language_code of this ApplicationInquiryDemographics.  # noqa: E501
        :type: str
        """

        self._correspondence_language_code = correspondence_language_code

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
        if issubclass(ApplicationInquiryDemographics, dict):
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
        if not isinstance(other, ApplicationInquiryDemographics):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
