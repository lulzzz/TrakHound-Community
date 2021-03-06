﻿// Copyright (c) 2017 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

namespace TrakHound.API
{
    public static partial class Messages
    {
        public enum MessageType
        {
            DEVICE_GENERAL,
            DEVICE_ALERT,
            TRAKHOUND_BROADCAST,
            TRAKHOUND_ADVERTISEMENT,
            TRAKHOUND_UPDATE,
            TRAKHOUND_ALERT,
            TRAKHOUND_PRIVATE
        }
    }  
}
