/**
 *	Copyright 2016 Dartmouth-Hitchcock
 *	
 *	Licensed under the Apache License, Version 2.0 (the "License");
 *	you may not use this file except in compliance with the License.
 *	You may obtain a copy of the License at
 *	
 *	    http://www.apache.org/licenses/LICENSE-2.0
 *	
 *	Unless required by applicable law or agreed to in writing, software
 *	distributed under the License is distributed on an "AS IS" BASIS,
 *	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *	See the License for the specific language governing permissions and
 *	limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

using Legion.Core.Services.ServiceToService;

namespace Caesar.Legion {

    /// <summary>
    /// The parsed sReply from a Legion Service
    /// </summary>
    /// <typeparam name="Format">The format to return the Response and Result object</typeparam>
    public class LegionReply<Format> where Format : XmlElement {
        private LegionFault _fault = null;
        private LegionError _error = null;
        private DateTime? _dtCached = null;
        private DateTime? _dtExpires = null;
        private Format _result;
        private Format _response;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="response">The response node of the Legion Reply</param>
        /// <param name="result">The result node of the Legion Reply</param>
        /// <param name="fault">The fault (if one occurred)</param>
        /// <param name="error">The error (if one occurred)</param>
        /// <param name="CachedOn">If cached, the DateTime the reply was cached</param>
        /// <param name="CachedOn">If cached, the DateTime the reply expires</param>
        public LegionReply(Format response, Format result, LegionFault fault, LegionError error, DateTime? CachedOn, DateTime? ExpiresOn) {
            _response = response;
            _result = result;
            _fault = fault;
            _error = error;
            _dtCached = CachedOn;
            _dtExpires = ExpiresOn;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="response">The response node of the Legion Reply</param>
        /// <param name="result">The result node of the Legion Reply</param>
        /// <param name="fault">The fault (if one occurred)</param>
        /// <param name="error">The error (if one occurred)</param>
        /// <param name="CachedOn">If cached, the DateTime the reply was cached</param>
        /// <param name="CachedOn">If cached, the DateTime the reply expires</param>
        internal LegionReply(XmlElement response, XmlElement result, LegionFault fault, LegionError error, DateTime? CachedOn, DateTime? ExpiresOn) {
            _response = (Format)response;
            _result = (Format)result;
            _fault = fault;
            _error = error;
            _dtCached = CachedOn;
            _dtExpires = ExpiresOn;
        }

        /// <summary>
        /// true if a fault occurred in the request, false otherwise
        /// </summary>
        public bool HasFault { get { return _fault == null ? false : true; } }

        /// <summary>
        /// true if the method returned an error, false otherwise
        /// </summary>
        public bool HasError { get { return _error == null ? false : true; } }

        /// <summary>
        /// A fault if one occurred, null otherwise
        /// </summary>
        public LegionFault Fault { get { return _fault; } }

        /// <summary>
        /// A string containing the error message if one occurred, null otherwise
        /// </summary>
        public LegionError Error { get { return _error; } }

        /// <summary>
        /// The Result node of the Reply
        /// </summary>
        public Format Result { get { return _result; } }

        /// <summary>
        /// The Response node of the Reply
        /// </summary>
        public Format Response { get { return _response; } }

        /// <summary>
        /// Is the reply cached
        /// </summary>
        public bool IsCached { get { return _dtCached != null; } }

        /// <summary>
        /// If cached, the DateTime the reply was cached on, otherwise null
        /// </summary>
        public DateTime? CachedOn { get { return _dtCached; } }

        /// <summary>
        /// If cached, the DateTime the reply expired, otherwise null
        /// </summary>
        public DateTime? ExpiresOn { get { return _dtExpires; } }

        /// <summary>
        /// Builds a broken out LegionReply off of the reaw xml return
        /// </summary>
        /// <param name="sReply">the string of the sReply</param>
        /// <returns>a new LegionReply</returns>
        public static LegionReply<XmlElement> BuildLegionXmlReply(string sReply) {
            LegionFault fault = null;

            XmlDocument reply = new XmlDocument();
            reply.LoadXml(sReply);

            XmlElement result = (XmlElement)reply.SelectSingleNode("/reply/result");
            XmlElement response = (XmlElement)reply.SelectSingleNode("/reply/response");

            XmlElement xFault = (XmlElement)reply.SelectSingleNode("/reply/response/fault");
            if (xFault != null)
                fault = new LegionFault(xFault.InnerText, xFault.Attributes["type"].Value);

            LegionError error = (reply.SelectSingleNode("/reply/error") == null ? null : new LegionError(reply.SelectSingleNode("/reply/error")));

            DateTime? dtCached = null;
            DateTime? dtExpires = null;

            if (reply.SelectSingleNode("/reply/response/cachedresult") != null) {
                dtCached = DateTime.Parse(reply.SelectSingleNode("/reply/response/cachedresult/updated").InnerText);
                dtExpires = DateTime.Parse(reply.SelectSingleNode("/reply/response/cachedresult/expires").InnerText);
            }

            return new LegionReply<XmlElement>(response, result, fault, error, dtCached, dtExpires);
        }

        public static implicit operator LegionReply<Format>(Reply r) {
            return new LegionReply<Format>(r.Response, r.Result, r.Fault, r.Error, r.CachedOn, r.ExpiresOn);
        }
    }
}
