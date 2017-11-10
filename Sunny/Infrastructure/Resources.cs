using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Text;

namespace Sunny.Infrastructure
{
    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
           = new ResourceManager("Sunny.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// No service for type '{0}' has been registered.
        /// </summary>
        internal static string FormatException_UseServiceNoSuunyServiceFactory(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("Exception_UseServiceNoSuunyServiceFactory"), p0);

        /// <summary>
        /// '{0}' failed to create service of type '{1}'.
        /// </summary>
        internal static string FormatException_UseServiceUnableToCreateSunnyService(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("Exception_UseServiceUnableToCreateSunnyService"), p0, p1);

        /// <summary>
        /// '{0}' failed to create service of type '{1}'.
        /// </summary>
        internal static string FormatException_UseServiceServiceTypeNotInheritedISunnyService(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("Exception_UseServiceServiceTypeNotInheritedISunnyService"), p0);

        private static string GetString(string name, params string[] formatterNames)
        {
            return name;
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
