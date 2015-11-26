﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#if NET451

using System.Diagnostics.Contracts;
using System.Xml;
using System.Xml.Linq;

namespace IdentityModel.Extensions
{
    public static partial class XmlExtensions
    {
        /// <summary>
        /// Converts a XElement to a XmlElement.
        /// </summary>
        /// <param name="element">The XElement.</param>
        /// <returns>A XmlElement</returns>
        public static XmlElement ToXmlElement(this XElement element)
        {
            Contract.Requires(element != null);
            Contract.Ensures(Contract.Result<XmlElement>() != null);


            return new XmlConverter(element).CreateXmlElement();
        }
    }
}

#endif