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

class DataProductOfferings(object):
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
        'category': 'str',
        'item': 'str',
        'remark': 'str',
        'branding': 'str',
        'tnc_url': 'str'
    }

    attribute_map = {
        'category': 'category',
        'item': 'item',
        'remark': 'remark',
        'branding': 'branding',
        'tnc_url': 'tnc_url'
    }

    def __init__(self, category=None, item=None, remark=None, branding=None, tnc_url=None):  # noqa: E501
        """DataProductOfferings - a model defined in Swagger"""  # noqa: E501
        self._category = None
        self._item = None
        self._remark = None
        self._branding = None
        self._tnc_url = None
        self.discriminator = None
        self.category = category
        self.item = item
        if remark is not None:
            self.remark = remark
        if branding is not None:
            self.branding = branding
        if tnc_url is not None:
            self.tnc_url = tnc_url

    @property
    def category(self):
        """Gets the category of this DataProductOfferings.  # noqa: E501

        Type of offering  # noqa: E501

        :return: The category of this DataProductOfferings.  # noqa: E501
        :rtype: str
        """
        return self._category

    @category.setter
    def category(self, category):
        """Sets the category of this DataProductOfferings.

        Type of offering  # noqa: E501

        :param category: The category of this DataProductOfferings.  # noqa: E501
        :type: str
        """
        if category is None:
            raise ValueError("Invalid value for `category`, must not be `None`")  # noqa: E501
        allowed_values = ["reward_cashback", "air_miles", "feature_benefit"]  # noqa: E501
        if category not in allowed_values:
            raise ValueError(
                "Invalid value for `category` ({0}), must be one of {1}"  # noqa: E501
                .format(category, allowed_values)
            )

        self._category = category

    @property
    def item(self):
        """Gets the item of this DataProductOfferings.  # noqa: E501


        :return: The item of this DataProductOfferings.  # noqa: E501
        :rtype: str
        """
        return self._item

    @item.setter
    def item(self, item):
        """Sets the item of this DataProductOfferings.


        :param item: The item of this DataProductOfferings.  # noqa: E501
        :type: str
        """
        if item is None:
            raise ValueError("Invalid value for `item`, must not be `None`")  # noqa: E501
        allowed_values = ["bookstore", "cashless_transaction", "cinema", "department_store", "dining", "education", "entertainment", "express_autopay", "gold", "groceries", "highway", "hotel", "installment_plan", "insurance_premium", "local_retail", "membership_day", "mobile_telco", "myeg_services", "online_air_ticket", "online_bill_payment", "online_shopping", "others", "oversea_retail", "petrol", "pharmacy", "retail", "shopping", "touch_n_go", "transport", "travel", "utility_bill", "weekend", "asia_miles", "big_point_aasia", "enrich_mas", "garuda_miles_id", "krisfyler_sg", "malindo_miles_malindoair", "star_alliance", "airport_speed_pass", "annual_fee_waiver", "auto_bill_payment", "balance_transfer_plan", "cash_advance", "cash_installment_plan", "cash_withdrawal", "charity_fund", "concierge_services", "contactless", "dining_privileges", "discount", "easy_payment_plan", "ecommerce_insurance", "emergency_cheque_cashing", "global_assistance", "golf", "partnership_discount", "plaza_premium_lounge", "retail_insurance", "travel_insurance", "wallet_guard"]  # noqa: E501
        if item not in allowed_values:
            raise ValueError(
                "Invalid value for `item` ({0}), must be one of {1}"  # noqa: E501
                .format(item, allowed_values)
            )

        self._item = item

    @property
    def remark(self):
        """Gets the remark of this DataProductOfferings.  # noqa: E501

        Additional notes for the reward, air miles and feature  # noqa: E501

        :return: The remark of this DataProductOfferings.  # noqa: E501
        :rtype: str
        """
        return self._remark

    @remark.setter
    def remark(self, remark):
        """Sets the remark of this DataProductOfferings.

        Additional notes for the reward, air miles and feature  # noqa: E501

        :param remark: The remark of this DataProductOfferings.  # noqa: E501
        :type: str
        """

        self._remark = remark

    @property
    def branding(self):
        """Gets the branding of this DataProductOfferings.  # noqa: E501

        Branding for specific offering  # noqa: E501

        :return: The branding of this DataProductOfferings.  # noqa: E501
        :rtype: str
        """
        return self._branding

    @branding.setter
    def branding(self, branding):
        """Sets the branding of this DataProductOfferings.

        Branding for specific offering  # noqa: E501

        :param branding: The branding of this DataProductOfferings.  # noqa: E501
        :type: str
        """

        self._branding = branding

    @property
    def tnc_url(self):
        """Gets the tnc_url of this DataProductOfferings.  # noqa: E501

        Absolute URL to term and conditions for specific offering  # noqa: E501

        :return: The tnc_url of this DataProductOfferings.  # noqa: E501
        :rtype: str
        """
        return self._tnc_url

    @tnc_url.setter
    def tnc_url(self, tnc_url):
        """Sets the tnc_url of this DataProductOfferings.

        Absolute URL to term and conditions for specific offering  # noqa: E501

        :param tnc_url: The tnc_url of this DataProductOfferings.  # noqa: E501
        :type: str
        """

        self._tnc_url = tnc_url

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
        if issubclass(DataProductOfferings, dict):
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
        if not isinstance(other, DataProductOfferings):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
