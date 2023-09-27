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

class ApplicationUpdateEmploymentDetails(object):
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
        'job_title': 'str',
        'occupation_code': 'str',
        'industry_code': 'str',
        'employment_duration_in_years': 'int',
        'employment_duration_in_months': 'int',
        'employment_status': 'str',
        'months_in_previous_employment': 'int',
        'years_in_previous_employment': 'int',
        'accountant_name': 'str',
        'accountant_firm_name': 'str',
        'years_in_industry': 'int',
        'months_in_industry': 'int'
    }

    attribute_map = {
        'employer_name': 'employerName',
        'job_title': 'jobTitle',
        'occupation_code': 'occupationCode',
        'industry_code': 'industryCode',
        'employment_duration_in_years': 'employmentDurationInYears',
        'employment_duration_in_months': 'employmentDurationInMonths',
        'employment_status': 'employmentStatus',
        'months_in_previous_employment': 'monthsInPreviousEmployment',
        'years_in_previous_employment': 'yearsInPreviousEmployment',
        'accountant_name': 'accountantName',
        'accountant_firm_name': 'accountantFirmName',
        'years_in_industry': 'yearsInIndustry',
        'months_in_industry': 'monthsInIndustry'
    }

    def __init__(self, employer_name=None, job_title=None, occupation_code=None, industry_code=None, employment_duration_in_years=None, employment_duration_in_months=None, employment_status=None, months_in_previous_employment=None, years_in_previous_employment=None, accountant_name=None, accountant_firm_name=None, years_in_industry=None, months_in_industry=None):  # noqa: E501
        """ApplicationUpdateEmploymentDetails - a model defined in Swagger"""  # noqa: E501
        self._employer_name = None
        self._job_title = None
        self._occupation_code = None
        self._industry_code = None
        self._employment_duration_in_years = None
        self._employment_duration_in_months = None
        self._employment_status = None
        self._months_in_previous_employment = None
        self._years_in_previous_employment = None
        self._accountant_name = None
        self._accountant_firm_name = None
        self._years_in_industry = None
        self._months_in_industry = None
        self.discriminator = None
        if employer_name is not None:
            self.employer_name = employer_name
        if job_title is not None:
            self.job_title = job_title
        if occupation_code is not None:
            self.occupation_code = occupation_code
        if industry_code is not None:
            self.industry_code = industry_code
        if employment_duration_in_years is not None:
            self.employment_duration_in_years = employment_duration_in_years
        if employment_duration_in_months is not None:
            self.employment_duration_in_months = employment_duration_in_months
        if employment_status is not None:
            self.employment_status = employment_status
        if months_in_previous_employment is not None:
            self.months_in_previous_employment = months_in_previous_employment
        if years_in_previous_employment is not None:
            self.years_in_previous_employment = years_in_previous_employment
        if accountant_name is not None:
            self.accountant_name = accountant_name
        if accountant_firm_name is not None:
            self.accountant_firm_name = accountant_firm_name
        if years_in_industry is not None:
            self.years_in_industry = years_in_industry
        if months_in_industry is not None:
            self.months_in_industry = months_in_industry

    @property
    def employer_name(self):
        """Gets the employer_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Name of the employer.  # noqa: E501

        :return: The employer_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._employer_name

    @employer_name.setter
    def employer_name(self, employer_name):
        """Sets the employer_name of this ApplicationUpdateEmploymentDetails.

        Name of the employer.  # noqa: E501

        :param employer_name: The employer_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._employer_name = employer_name

    @property
    def job_title(self):
        """Gets the job_title of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Job Title. This is a reference data field. Please use /v1/apac/utilities/referenceData/{jobTitle} resource to get valid value of this field with description. You can use jobTitle field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The job_title of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._job_title

    @job_title.setter
    def job_title(self, job_title):
        """Sets the job_title of this ApplicationUpdateEmploymentDetails.

        Job Title. This is a reference data field. Please use /v1/apac/utilities/referenceData/{jobTitle} resource to get valid value of this field with description. You can use jobTitle field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param job_title: The job_title of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._job_title = job_title

    @property
    def occupation_code(self):
        """Gets the occupation_code of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Occupation code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. You can use occupationCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The occupation_code of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._occupation_code

    @occupation_code.setter
    def occupation_code(self, occupation_code):
        """Sets the occupation_code of this ApplicationUpdateEmploymentDetails.

        Occupation code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. You can use occupationCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param occupation_code: The occupation_code of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._occupation_code = occupation_code

    @property
    def industry_code(self):
        """Gets the industry_code of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Code of the industry of employment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{industryCode} resource to get valid value of this field with description. You can use industryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The industry_code of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._industry_code

    @industry_code.setter
    def industry_code(self, industry_code):
        """Sets the industry_code of this ApplicationUpdateEmploymentDetails.

        Code of the industry of employment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{industryCode} resource to get valid value of this field with description. You can use industryCode field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param industry_code: The industry_code of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._industry_code = industry_code

    @property
    def employment_duration_in_years(self):
        """Gets the employment_duration_in_years of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Employment duration in years  # noqa: E501

        :return: The employment_duration_in_years of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: int
        """
        return self._employment_duration_in_years

    @employment_duration_in_years.setter
    def employment_duration_in_years(self, employment_duration_in_years):
        """Sets the employment_duration_in_years of this ApplicationUpdateEmploymentDetails.

        Employment duration in years  # noqa: E501

        :param employment_duration_in_years: The employment_duration_in_years of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: int
        """

        self._employment_duration_in_years = employment_duration_in_years

    @property
    def employment_duration_in_months(self):
        """Gets the employment_duration_in_months of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Employment duration in months  # noqa: E501

        :return: The employment_duration_in_months of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: int
        """
        return self._employment_duration_in_months

    @employment_duration_in_months.setter
    def employment_duration_in_months(self, employment_duration_in_months):
        """Sets the employment_duration_in_months of this ApplicationUpdateEmploymentDetails.

        Employment duration in months  # noqa: E501

        :param employment_duration_in_months: The employment_duration_in_months of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: int
        """

        self._employment_duration_in_months = employment_duration_in_months

    @property
    def employment_status(self):
        """Gets the employment_status of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The employment_status of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._employment_status

    @employment_status.setter
    def employment_status(self, employment_status):
        """Sets the employment_status of this ApplicationUpdateEmploymentDetails.

        Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param employment_status: The employment_status of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._employment_status = employment_status

    @property
    def months_in_previous_employment(self):
        """Gets the months_in_previous_employment of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Months spent in the previouse employment  # noqa: E501

        :return: The months_in_previous_employment of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: int
        """
        return self._months_in_previous_employment

    @months_in_previous_employment.setter
    def months_in_previous_employment(self, months_in_previous_employment):
        """Sets the months_in_previous_employment of this ApplicationUpdateEmploymentDetails.

        Months spent in the previouse employment  # noqa: E501

        :param months_in_previous_employment: The months_in_previous_employment of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: int
        """

        self._months_in_previous_employment = months_in_previous_employment

    @property
    def years_in_previous_employment(self):
        """Gets the years_in_previous_employment of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Years spent in the previouse employment  # noqa: E501

        :return: The years_in_previous_employment of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: int
        """
        return self._years_in_previous_employment

    @years_in_previous_employment.setter
    def years_in_previous_employment(self, years_in_previous_employment):
        """Sets the years_in_previous_employment of this ApplicationUpdateEmploymentDetails.

        Years spent in the previouse employment  # noqa: E501

        :param years_in_previous_employment: The years_in_previous_employment of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: int
        """

        self._years_in_previous_employment = years_in_previous_employment

    @property
    def accountant_name(self):
        """Gets the accountant_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Accountant or contact's name  # noqa: E501

        :return: The accountant_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._accountant_name

    @accountant_name.setter
    def accountant_name(self, accountant_name):
        """Sets the accountant_name of this ApplicationUpdateEmploymentDetails.

        Accountant or contact's name  # noqa: E501

        :param accountant_name: The accountant_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._accountant_name = accountant_name

    @property
    def accountant_firm_name(self):
        """Gets the accountant_firm_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Accountant's firm or business name  # noqa: E501

        :return: The accountant_firm_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: str
        """
        return self._accountant_firm_name

    @accountant_firm_name.setter
    def accountant_firm_name(self, accountant_firm_name):
        """Sets the accountant_firm_name of this ApplicationUpdateEmploymentDetails.

        Accountant's firm or business name  # noqa: E501

        :param accountant_firm_name: The accountant_firm_name of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: str
        """

        self._accountant_firm_name = accountant_firm_name

    @property
    def years_in_industry(self):
        """Gets the years_in_industry of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Years spent in industry  # noqa: E501

        :return: The years_in_industry of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: int
        """
        return self._years_in_industry

    @years_in_industry.setter
    def years_in_industry(self, years_in_industry):
        """Sets the years_in_industry of this ApplicationUpdateEmploymentDetails.

        Years spent in industry  # noqa: E501

        :param years_in_industry: The years_in_industry of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: int
        """

        self._years_in_industry = years_in_industry

    @property
    def months_in_industry(self):
        """Gets the months_in_industry of this ApplicationUpdateEmploymentDetails.  # noqa: E501

        Months spent in industry  # noqa: E501

        :return: The months_in_industry of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :rtype: int
        """
        return self._months_in_industry

    @months_in_industry.setter
    def months_in_industry(self, months_in_industry):
        """Sets the months_in_industry of this ApplicationUpdateEmploymentDetails.

        Months spent in industry  # noqa: E501

        :param months_in_industry: The months_in_industry of this ApplicationUpdateEmploymentDetails.  # noqa: E501
        :type: int
        """

        self._months_in_industry = months_in_industry

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
        if issubclass(ApplicationUpdateEmploymentDetails, dict):
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
        if not isinstance(other, ApplicationUpdateEmploymentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
