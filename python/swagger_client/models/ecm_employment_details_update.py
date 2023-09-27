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

class ECMEmploymentDetailsUpdate(object):
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
        'employer_name': 'str',
        'employer_registration_number': 'str',
        'occupation_code': 'str',
        'other_occupation_description': 'str',
        'industry_code': 'str',
        'other_industry_description': 'str',
        'employment_duration_in_years': 'int',
        'employment_duration_in_months': 'int',
        'previous_employer_name': 'str',
        'months_in_previous_employment': 'int',
        'years_in_previous_employment': 'int',
        'email_address': 'str',
        'employment_status': 'str'
    }

    attribute_map = {
        'employer_name': 'employerName',
        'employer_registration_number': 'employerRegistrationNumber',
        'occupation_code': 'occupationCode',
        'other_occupation_description': 'otherOccupationDescription',
        'industry_code': 'industryCode',
        'other_industry_description': 'otherIndustryDescription',
        'employment_duration_in_years': 'employmentDurationInYears',
        'employment_duration_in_months': 'employmentDurationInMonths',
        'previous_employer_name': 'previousEmployerName',
        'months_in_previous_employment': 'monthsInPreviousEmployment',
        'years_in_previous_employment': 'yearsInPreviousEmployment',
        'email_address': 'emailAddress',
        'employment_status': 'employmentStatus'
    }

    def __init__(self, employer_name=None, employer_registration_number=None, occupation_code=None, other_occupation_description=None, industry_code=None, other_industry_description=None, employment_duration_in_years=None, employment_duration_in_months=None, previous_employer_name=None, months_in_previous_employment=None, years_in_previous_employment=None, email_address=None, employment_status=None):  # noqa: E501
        """ECMEmploymentDetailsUpdate - a model defined in Swagger"""  # noqa: E501
        self._employer_name = None
        self._employer_registration_number = None
        self._occupation_code = None
        self._other_occupation_description = None
        self._industry_code = None
        self._other_industry_description = None
        self._employment_duration_in_years = None
        self._employment_duration_in_months = None
        self._previous_employer_name = None
        self._months_in_previous_employment = None
        self._years_in_previous_employment = None
        self._email_address = None
        self._employment_status = None
        self.discriminator = None
        if employer_name is not None:
            self.employer_name = employer_name
        if employer_registration_number is not None:
            self.employer_registration_number = employer_registration_number
        if occupation_code is not None:
            self.occupation_code = occupation_code
        if other_occupation_description is not None:
            self.other_occupation_description = other_occupation_description
        if industry_code is not None:
            self.industry_code = industry_code
        if other_industry_description is not None:
            self.other_industry_description = other_industry_description
        if employment_duration_in_years is not None:
            self.employment_duration_in_years = employment_duration_in_years
        if employment_duration_in_months is not None:
            self.employment_duration_in_months = employment_duration_in_months
        if previous_employer_name is not None:
            self.previous_employer_name = previous_employer_name
        if months_in_previous_employment is not None:
            self.months_in_previous_employment = months_in_previous_employment
        if years_in_previous_employment is not None:
            self.years_in_previous_employment = years_in_previous_employment
        if email_address is not None:
            self.email_address = email_address
        if employment_status is not None:
            self.employment_status = employment_status

    @property
    def employer_name(self):
        """Gets the employer_name of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Name of the employer.  # noqa: E501

        :return: The employer_name of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._employer_name

    @employer_name.setter
    def employer_name(self, employer_name):
        """Sets the employer_name of this ECMEmploymentDetailsUpdate.

        Name of the employer.  # noqa: E501

        :param employer_name: The employer_name of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._employer_name = employer_name

    @property
    def employer_registration_number(self):
        """Gets the employer_registration_number of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Employer registration number  # noqa: E501

        :return: The employer_registration_number of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._employer_registration_number

    @employer_registration_number.setter
    def employer_registration_number(self, employer_registration_number):
        """Sets the employer_registration_number of this ECMEmploymentDetailsUpdate.

        Employer registration number  # noqa: E501

        :param employer_registration_number: The employer_registration_number of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._employer_registration_number = employer_registration_number

    @property
    def occupation_code(self):
        """Gets the occupation_code of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Occupation code. This is a reference data field. Please use /v1/utilities/referenceData/{occupationCode} resource to get valid value of this field with description.  # noqa: E501

        :return: The occupation_code of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._occupation_code

    @occupation_code.setter
    def occupation_code(self, occupation_code):
        """Sets the occupation_code of this ECMEmploymentDetailsUpdate.

        Occupation code. This is a reference data field. Please use /v1/utilities/referenceData/{occupationCode} resource to get valid value of this field with description.  # noqa: E501

        :param occupation_code: The occupation_code of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._occupation_code = occupation_code

    @property
    def other_occupation_description(self):
        """Gets the other_occupation_description of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Other Occupation details entered by the Applicant.This is applicable if Applicant selects Others from the occupation Code drop down  # noqa: E501

        :return: The other_occupation_description of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._other_occupation_description

    @other_occupation_description.setter
    def other_occupation_description(self, other_occupation_description):
        """Sets the other_occupation_description of this ECMEmploymentDetailsUpdate.

        Other Occupation details entered by the Applicant.This is applicable if Applicant selects Others from the occupation Code drop down  # noqa: E501

        :param other_occupation_description: The other_occupation_description of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._other_occupation_description = other_occupation_description

    @property
    def industry_code(self):
        """Gets the industry_code of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Code of the industry of employment. This is a reference data field. Please use /v1/utilities/referenceData/{industryCode} resource to get valid value of this field with description.  # noqa: E501

        :return: The industry_code of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._industry_code

    @industry_code.setter
    def industry_code(self, industry_code):
        """Sets the industry_code of this ECMEmploymentDetailsUpdate.

        Code of the industry of employment. This is a reference data field. Please use /v1/utilities/referenceData/{industryCode} resource to get valid value of this field with description.  # noqa: E501

        :param industry_code: The industry_code of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._industry_code = industry_code

    @property
    def other_industry_description(self):
        """Gets the other_industry_description of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Other Industry details entered by the Applicant.This is applicable if Applicant selects Others from the industry code drop down  # noqa: E501

        :return: The other_industry_description of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._other_industry_description

    @other_industry_description.setter
    def other_industry_description(self, other_industry_description):
        """Sets the other_industry_description of this ECMEmploymentDetailsUpdate.

        Other Industry details entered by the Applicant.This is applicable if Applicant selects Others from the industry code drop down  # noqa: E501

        :param other_industry_description: The other_industry_description of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._other_industry_description = other_industry_description

    @property
    def employment_duration_in_years(self):
        """Gets the employment_duration_in_years of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Employment duration in years  # noqa: E501

        :return: The employment_duration_in_years of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: int
        """
        return self._employment_duration_in_years

    @employment_duration_in_years.setter
    def employment_duration_in_years(self, employment_duration_in_years):
        """Sets the employment_duration_in_years of this ECMEmploymentDetailsUpdate.

        Employment duration in years  # noqa: E501

        :param employment_duration_in_years: The employment_duration_in_years of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: int
        """

        self._employment_duration_in_years = employment_duration_in_years

    @property
    def employment_duration_in_months(self):
        """Gets the employment_duration_in_months of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Employment duration in months  # noqa: E501

        :return: The employment_duration_in_months of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: int
        """
        return self._employment_duration_in_months

    @employment_duration_in_months.setter
    def employment_duration_in_months(self, employment_duration_in_months):
        """Sets the employment_duration_in_months of this ECMEmploymentDetailsUpdate.

        Employment duration in months  # noqa: E501

        :param employment_duration_in_months: The employment_duration_in_months of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: int
        """

        self._employment_duration_in_months = employment_duration_in_months

    @property
    def previous_employer_name(self):
        """Gets the previous_employer_name of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Name of the previous employer.  # noqa: E501

        :return: The previous_employer_name of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._previous_employer_name

    @previous_employer_name.setter
    def previous_employer_name(self, previous_employer_name):
        """Sets the previous_employer_name of this ECMEmploymentDetailsUpdate.

        Name of the previous employer.  # noqa: E501

        :param previous_employer_name: The previous_employer_name of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._previous_employer_name = previous_employer_name

    @property
    def months_in_previous_employment(self):
        """Gets the months_in_previous_employment of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Months spent in the previous employment  # noqa: E501

        :return: The months_in_previous_employment of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: int
        """
        return self._months_in_previous_employment

    @months_in_previous_employment.setter
    def months_in_previous_employment(self, months_in_previous_employment):
        """Sets the months_in_previous_employment of this ECMEmploymentDetailsUpdate.

        Months spent in the previous employment  # noqa: E501

        :param months_in_previous_employment: The months_in_previous_employment of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: int
        """

        self._months_in_previous_employment = months_in_previous_employment

    @property
    def years_in_previous_employment(self):
        """Gets the years_in_previous_employment of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Years spent in the previous employment  # noqa: E501

        :return: The years_in_previous_employment of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: int
        """
        return self._years_in_previous_employment

    @years_in_previous_employment.setter
    def years_in_previous_employment(self, years_in_previous_employment):
        """Sets the years_in_previous_employment of this ECMEmploymentDetailsUpdate.

        Years spent in the previous employment  # noqa: E501

        :param years_in_previous_employment: The years_in_previous_employment of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: int
        """

        self._years_in_previous_employment = years_in_previous_employment

    @property
    def email_address(self):
        """Gets the email_address of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Employers email address  # noqa: E501

        :return: The email_address of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._email_address

    @email_address.setter
    def email_address(self, email_address):
        """Sets the email_address of this ECMEmploymentDetailsUpdate.

        Employers email address  # noqa: E501

        :param email_address: The email_address of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._email_address = email_address

    @property
    def employment_status(self):
        """Gets the employment_status of this ECMEmploymentDetailsUpdate.  # noqa: E501

        Status of the employment.This is a reference data field. Please use /v1/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description.  # noqa: E501

        :return: The employment_status of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :rtype: str
        """
        return self._employment_status

    @employment_status.setter
    def employment_status(self, employment_status):
        """Sets the employment_status of this ECMEmploymentDetailsUpdate.

        Status of the employment.This is a reference data field. Please use /v1/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description.  # noqa: E501

        :param employment_status: The employment_status of this ECMEmploymentDetailsUpdate.  # noqa: E501
        :type: str
        """

        self._employment_status = employment_status

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
        if issubclass(ECMEmploymentDetailsUpdate, dict):
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
        if not isinstance(other, ECMEmploymentDetailsUpdate):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
