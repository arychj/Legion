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

using System.Collections.Specialized;

using Legion.Core.Modules;
using Legion.Core.Services;

namespace ClientDetailsModule {

    public class Module : ClientDetails {

        /// <summary>
        /// Returns the client's IP Address
        /// </summary>
        /// <param name="request">The raw request object</param>
        /// <returns>The client's IP address</returns>
        public override string IpAddress(RawRequest request) {
            return request.ServerVariables["REMOTE_ADDR"];
        }

        /// <summary>
        /// Checks if the connection is secure (HTTPS)
        /// </summary>
        /// <param name="request">The raw request object</param>
        /// <returns>returns true if the connection is secure, false otherwise</returns>
        public override bool IsSecure(RawRequest request) {
            return (request.ServerVariables["HTTPS"] == "ON");
        }

        /// <summary>
        /// Checks if the client is internal to DH
        /// </summary>
        /// <param name="request">The raw request object</param>
        /// <returns>true if the client is internal, false otherwise</returns>
        public override bool IsInternal(RawRequest request) {
            return false;
        }

        /// <summary>
        /// Checks if the client is in the datacenter
        /// </summary>
        /// <param name="request">The raw request object</param>
        /// <returns>true if the client is in the datacenter, false otherwise</returns>
        public override bool IsDatacenter(RawRequest request) {
            return false;
        }
    }
}