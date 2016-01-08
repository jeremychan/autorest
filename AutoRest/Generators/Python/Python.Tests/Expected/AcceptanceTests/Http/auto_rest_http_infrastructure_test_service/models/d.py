# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class D(Model):

    _required = []

    _attribute_map = {
        'http_status_code': {'key': 'httpStatusCode', 'type': 'str'},
    }

    def __init__(self, *args, **kwargs):

        self.http_status_code = None

        super(D, self).__init__(*args, **kwargs)
