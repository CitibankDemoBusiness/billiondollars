# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from swagger_client.api_client import ApiClient


class AccountsApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def consents_details_inquiry(self, authorization, uuid, accept, client_id, account_id, consent_type, **kwargs):  # noqa: E501
        """Retrieve Consents based on Account Number  # noqa: E501

        This API is used to retrieve the consents based on account number.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.consents_details_inquiry(authorization, uuid, accept, client_id, account_id, consent_type, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str authorization: The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==. (required)
        :param str uuid: 128 bit random UUID generated uniquely for every request. (required)
        :param str accept: Content-Type that are acceptable for the response. (required)
        :param str client_id: Client ID generated during application registration. (required)
        :param str account_id: The account identifier in encrypted format.Typically, this is not displayed to the customer (required)
        :param str consent_type: Consent Type (required)
        :param str client_details: This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        :return: ConsentsDetailsInquiryResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.consents_details_inquiry_with_http_info(authorization, uuid, accept, client_id, account_id, consent_type, **kwargs)  # noqa: E501
        else:
            (data) = self.consents_details_inquiry_with_http_info(authorization, uuid, accept, client_id, account_id, consent_type, **kwargs)  # noqa: E501
            return data

    def consents_details_inquiry_with_http_info(self, authorization, uuid, accept, client_id, account_id, consent_type, **kwargs):  # noqa: E501
        """Retrieve Consents based on Account Number  # noqa: E501

        This API is used to retrieve the consents based on account number.  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.consents_details_inquiry_with_http_info(authorization, uuid, accept, client_id, account_id, consent_type, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str authorization: The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==. (required)
        :param str uuid: 128 bit random UUID generated uniquely for every request. (required)
        :param str accept: Content-Type that are acceptable for the response. (required)
        :param str client_id: Client ID generated during application registration. (required)
        :param str account_id: The account identifier in encrypted format.Typically, this is not displayed to the customer (required)
        :param str consent_type: Consent Type (required)
        :param str client_details: This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        :return: ConsentsDetailsInquiryResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['authorization', 'uuid', 'accept', 'client_id', 'account_id', 'consent_type', 'client_details']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method consents_details_inquiry" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'authorization' is set
        if ('authorization' not in params or
                params['authorization'] is None):
            raise ValueError("Missing the required parameter `authorization` when calling `consents_details_inquiry`")  # noqa: E501
        # verify the required parameter 'uuid' is set
        if ('uuid' not in params or
                params['uuid'] is None):
            raise ValueError("Missing the required parameter `uuid` when calling `consents_details_inquiry`")  # noqa: E501
        # verify the required parameter 'accept' is set
        if ('accept' not in params or
                params['accept'] is None):
            raise ValueError("Missing the required parameter `accept` when calling `consents_details_inquiry`")  # noqa: E501
        # verify the required parameter 'client_id' is set
        if ('client_id' not in params or
                params['client_id'] is None):
            raise ValueError("Missing the required parameter `client_id` when calling `consents_details_inquiry`")  # noqa: E501
        # verify the required parameter 'account_id' is set
        if ('account_id' not in params or
                params['account_id'] is None):
            raise ValueError("Missing the required parameter `account_id` when calling `consents_details_inquiry`")  # noqa: E501
        # verify the required parameter 'consent_type' is set
        if ('consent_type' not in params or
                params['consent_type'] is None):
            raise ValueError("Missing the required parameter `consent_type` when calling `consents_details_inquiry`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'account_id' in params:
            path_params['accountId'] = params['account_id']  # noqa: E501

        query_params = []
        if 'consent_type' in params:
            query_params.append(('consentType', params['consent_type']))  # noqa: E501

        header_params = {}
        if 'authorization' in params:
            header_params['Authorization'] = params['authorization']  # noqa: E501
        if 'uuid' in params:
            header_params['uuid'] = params['uuid']  # noqa: E501
        if 'accept' in params:
            header_params['Accept'] = params['accept']  # noqa: E501
        if 'client_id' in params:
            header_params['client_id'] = params['client_id']  # noqa: E501
        if 'client_details' in params:
            header_params['clientDetails'] = params['client_details']  # noqa: E501

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = []  # noqa: E501

        return self.api_client.call_api(
            '/v1/accounts/{accountId}/consents', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='ConsentsDetailsInquiryResponse',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def consents_details_update(self, body, authorization, uuid, accept, client_id, content_type, account_id, **kwargs):  # noqa: E501
        """This API is used to update the consent for an account  # noqa: E501

        This API is used to update the consent for an account  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.consents_details_update(body, authorization, uuid, accept, client_id, content_type, account_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param ConsentsDetailsUpdateRequest body: ConsentsDetailsUpdateRequest (required)
        :param str authorization: The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==. (required)
        :param str uuid: 128 bit random UUID generated uniquely for every request. (required)
        :param str accept: Content-Type that are acceptable for the response. (required)
        :param str client_id: Client ID generated during application registration. (required)
        :param str content_type: application/json (required)
        :param str account_id: The account identifier in encrypted format (required)
        :param str client_details: This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.consents_details_update_with_http_info(body, authorization, uuid, accept, client_id, content_type, account_id, **kwargs)  # noqa: E501
        else:
            (data) = self.consents_details_update_with_http_info(body, authorization, uuid, accept, client_id, content_type, account_id, **kwargs)  # noqa: E501
            return data

    def consents_details_update_with_http_info(self, body, authorization, uuid, accept, client_id, content_type, account_id, **kwargs):  # noqa: E501
        """This API is used to update the consent for an account  # noqa: E501

        This API is used to update the consent for an account  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.consents_details_update_with_http_info(body, authorization, uuid, accept, client_id, content_type, account_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param ConsentsDetailsUpdateRequest body: ConsentsDetailsUpdateRequest (required)
        :param str authorization: The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==. (required)
        :param str uuid: 128 bit random UUID generated uniquely for every request. (required)
        :param str accept: Content-Type that are acceptable for the response. (required)
        :param str client_id: Client ID generated during application registration. (required)
        :param str content_type: application/json (required)
        :param str account_id: The account identifier in encrypted format (required)
        :param str client_details: This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body', 'authorization', 'uuid', 'accept', 'client_id', 'content_type', 'account_id', 'client_details']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method consents_details_update" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `consents_details_update`")  # noqa: E501
        # verify the required parameter 'authorization' is set
        if ('authorization' not in params or
                params['authorization'] is None):
            raise ValueError("Missing the required parameter `authorization` when calling `consents_details_update`")  # noqa: E501
        # verify the required parameter 'uuid' is set
        if ('uuid' not in params or
                params['uuid'] is None):
            raise ValueError("Missing the required parameter `uuid` when calling `consents_details_update`")  # noqa: E501
        # verify the required parameter 'accept' is set
        if ('accept' not in params or
                params['accept'] is None):
            raise ValueError("Missing the required parameter `accept` when calling `consents_details_update`")  # noqa: E501
        # verify the required parameter 'client_id' is set
        if ('client_id' not in params or
                params['client_id'] is None):
            raise ValueError("Missing the required parameter `client_id` when calling `consents_details_update`")  # noqa: E501
        # verify the required parameter 'content_type' is set
        if ('content_type' not in params or
                params['content_type'] is None):
            raise ValueError("Missing the required parameter `content_type` when calling `consents_details_update`")  # noqa: E501
        # verify the required parameter 'account_id' is set
        if ('account_id' not in params or
                params['account_id'] is None):
            raise ValueError("Missing the required parameter `account_id` when calling `consents_details_update`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'account_id' in params:
            path_params['accountId'] = params['account_id']  # noqa: E501

        query_params = []

        header_params = {}
        if 'authorization' in params:
            header_params['Authorization'] = params['authorization']  # noqa: E501
        if 'uuid' in params:
            header_params['uuid'] = params['uuid']  # noqa: E501
        if 'accept' in params:
            header_params['Accept'] = params['accept']  # noqa: E501
        if 'client_id' in params:
            header_params['client_id'] = params['client_id']  # noqa: E501
        if 'content_type' in params:
            header_params['Content-Type'] = params['content_type']  # noqa: E501
        if 'client_details' in params:
            header_params['clientDetails'] = params['client_details']  # noqa: E501

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = []  # noqa: E501

        return self.api_client.call_api(
            '/v1/accounts/{accountId}/consents', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def partner_v1_accounts_account_id_access_codes_get(self, authorization, uuid, accept, client_id, account_id, **kwargs):  # noqa: E501
        """This API will retrieve the Access Code which will be used to see the clear account number  # noqa: E501

        This API will retrieve the Access Code which will be used to see the clear account number  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.partner_v1_accounts_account_id_access_codes_get(authorization, uuid, accept, client_id, account_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str authorization: The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==. (required)
        :param str uuid: 128 bit random UUID generated uniquely for every request. (required)
        :param str accept: Content-Type that are acceptable for the response. (required)
        :param str client_id: Client ID generated during application registration. (required)
        :param str account_id: The customer account identifier in encrypted format (required)
        :param str client_details: This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        :return: AccountAccessCodeGenerationResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.partner_v1_accounts_account_id_access_codes_get_with_http_info(authorization, uuid, accept, client_id, account_id, **kwargs)  # noqa: E501
        else:
            (data) = self.partner_v1_accounts_account_id_access_codes_get_with_http_info(authorization, uuid, accept, client_id, account_id, **kwargs)  # noqa: E501
            return data

    def partner_v1_accounts_account_id_access_codes_get_with_http_info(self, authorization, uuid, accept, client_id, account_id, **kwargs):  # noqa: E501
        """This API will retrieve the Access Code which will be used to see the clear account number  # noqa: E501

        This API will retrieve the Access Code which will be used to see the clear account number  # noqa: E501
        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.partner_v1_accounts_account_id_access_codes_get_with_http_info(authorization, uuid, accept, client_id, account_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str authorization: The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==. (required)
        :param str uuid: 128 bit random UUID generated uniquely for every request. (required)
        :param str accept: Content-Type that are acceptable for the response. (required)
        :param str client_id: Client ID generated during application registration. (required)
        :param str account_id: The customer account identifier in encrypted format (required)
        :param str client_details: This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
        :return: AccountAccessCodeGenerationResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['authorization', 'uuid', 'accept', 'client_id', 'account_id', 'client_details']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method partner_v1_accounts_account_id_access_codes_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'authorization' is set
        if ('authorization' not in params or
                params['authorization'] is None):
            raise ValueError("Missing the required parameter `authorization` when calling `partner_v1_accounts_account_id_access_codes_get`")  # noqa: E501
        # verify the required parameter 'uuid' is set
        if ('uuid' not in params or
                params['uuid'] is None):
            raise ValueError("Missing the required parameter `uuid` when calling `partner_v1_accounts_account_id_access_codes_get`")  # noqa: E501
        # verify the required parameter 'accept' is set
        if ('accept' not in params or
                params['accept'] is None):
            raise ValueError("Missing the required parameter `accept` when calling `partner_v1_accounts_account_id_access_codes_get`")  # noqa: E501
        # verify the required parameter 'client_id' is set
        if ('client_id' not in params or
                params['client_id'] is None):
            raise ValueError("Missing the required parameter `client_id` when calling `partner_v1_accounts_account_id_access_codes_get`")  # noqa: E501
        # verify the required parameter 'account_id' is set
        if ('account_id' not in params or
                params['account_id'] is None):
            raise ValueError("Missing the required parameter `account_id` when calling `partner_v1_accounts_account_id_access_codes_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'account_id' in params:
            path_params['accountId'] = params['account_id']  # noqa: E501

        query_params = []

        header_params = {}
        if 'authorization' in params:
            header_params['Authorization'] = params['authorization']  # noqa: E501
        if 'uuid' in params:
            header_params['uuid'] = params['uuid']  # noqa: E501
        if 'accept' in params:
            header_params['Accept'] = params['accept']  # noqa: E501
        if 'client_id' in params:
            header_params['client_id'] = params['client_id']  # noqa: E501
        if 'client_details' in params:
            header_params['clientDetails'] = params['client_details']  # noqa: E501

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = []  # noqa: E501

        return self.api_client.call_api(
            '/partner/v1/accounts/{accountId}/accessCodes', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='AccountAccessCodeGenerationResponse',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
