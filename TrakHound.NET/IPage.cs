﻿// Copyright (c) 2017 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System;

namespace TrakHound
{
    /// <summary>
    /// Interface used for any general page use that needs a name and image
    /// </summary>
    public interface IPage
    {
        string Title { get; }

        Uri Image { get; }

        bool ZoomEnabled { get; }

        void Opened();
        bool Opening();

        void Closed();
        bool Closing();

        void SetZoom(double zoomPercent);


        /// <summary>
        /// Get Data from another page
        /// </summary>
        /// <param name="data"></param>
        void GetSentData(EventData data);

        /// <summary>
        /// Send data to other pages
        /// </summary>
        event SendData_Handler SendData;
    }

}
