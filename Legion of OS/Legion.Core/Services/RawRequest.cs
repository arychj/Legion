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
using System.Collections.Specialized;
using System.IO;

using Legion.Core.Extensions;
using Legion.Core.Modules;

namespace Legion.Core.Services {

    /// <summary>
    /// 
    /// </summary>
    public class RawRequest {

        /// <summary>
        /// The current RawRequest
        /// </summary>
        [ThreadStatic]
        public static RawRequest Current = null;

        private string _body;
        private NameValueCollection _querystring;
        private NameValueCollection _form;
        private NameValueCollection _servervariables;
        private Dictionary<string, object> _items;

        /// <summary>
        /// Combined parameters provided in the request
        /// </summary>
        /// <param name="key">The key to retrieve</param>
        /// <returns></returns>
        public string this[string key]{
            get {
                if (_form[key] != null)
                    return _form[key];
                else if (_querystring[key] != null)
                    return _querystring[key];
                else if (_items.ContainsKey(key))
                    return _items[key].ToString();
                else
                    return null;
            }
        }

        /// <summary>
        /// The request body
        /// </summary>
        public string Body {
            get { return _body; }
        }

        /// <summary>
        /// The request POST parameters
        /// </summary>
        public NameValueCollection Form {
            get { return _form; }
        }

        /// <summary>
        /// The request GET parameters
        /// </summary>
        public NameValueCollection QueryString {
            get { return _querystring; }
        }

        /// <summary>
        /// The request SERVER parameters
        /// </summary>
        public NameValueCollection ServerVariables {
            get { return _servervariables; }
        }

        /// <summary>
        /// Additional request items
        /// </summary>
        public Dictionary<string, object> Items {
            get { return _items; }
        }

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="querystring">The collection of provided GET parameters</param>
        /// <param name="form">The collection of provided POST parameters</param>
        /// <param name="serverVariables">The collection of provided SERVER parameters</param>
        /// <param name="body">The provided</param>
        public RawRequest(NameValueCollection querystring, NameValueCollection form, NameValueCollection serverVariables, string body) {
            _querystring = new NameValueCollection(querystring);
            _form = new NameValueCollection(form);
            _servervariables = new NameValueCollection(serverVariables);
            _body = body;
            _items = new Dictionary<string, object>();
        }

        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        /// <param name="querystring">The collection of provided GET parameters</param>
        /// <param name="form">The collection of provided POST parameters</param>
        /// <param name="serverVariables">The collection of provided SERVER parameters</param>
        /// <param name="sBody">The body input stream</param>
        public RawRequest(NameValueCollection querystring, NameValueCollection form, NameValueCollection serverVariables, Stream sBody)
            : this(querystring, form, serverVariables, sBody.ReadAllToString())  {}

        internal void Localize() {
            if(RawRequest.Current == null)
                RawRequest.Current = this;
            else {
                Logging.Module.WriteException(new LoggedException() {
                    Type = "xxx",
                    Message = ""
                });
            }
        }

        internal void Deinitialize() {
            RawRequest.Current = null;
        }
    }
}
