﻿using System;

namespace MasterDevs.ChromeDevTools
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Enum)]
    public class SupportedByAttribute : Attribute
    {
        public SupportedByAttribute(string browser)
        {
            if (browser == null)
            {
                throw new ArgumentNullException(nameof(browser));
            }

            this.Browser = browser;
        }

        public string Browser
        {
            get;
            set;
        }
    }
}
