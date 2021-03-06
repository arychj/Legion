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

namespace Legion.Core.Exceptions {

    /// <summary>
    /// Special error exception. Message is returned as the InnerText of the /reply/error node
    /// </summary>
    public class ServiceError : Exception {

        /// <summary>
        /// Special error exception. Message is returned as the InnerText of the /reply/error node
        /// </summary>
        /// <param name="message">the error message</param>
        public ServiceError(string message) : base(message) { }

        /// <summary>
        /// Special error exception. Message is returned as the InnerText of the /reply/error node
        /// </summary>
        /// <param name="template">The message template</param>
        /// <param name="vars">The variables to instert into the template</param>
        public ServiceError(string template, params object[] vars) : base(string.Format(template, vars)) { }

    }
}
