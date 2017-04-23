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
using System.Collections.Specialized;

using Legion.Core;
using Legion.Core.Services;

namespace Centurion {
    public partial class api : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            Reply reply = Manager.Process(new RawRequest(
                Request.QueryString,
                Request.Form,
                Request.ServerVariables,
                Request.InputStream
            ));

            Response.Clear();
            Response.AppendHeader("Cache-Control", "no-cache, no-store, must-revalidate"); // HTTP 1.1.
            Response.AppendHeader("Pragma", "no-cache"); // HTTP 1.0.
            Response.AppendHeader("Expires", "0"); // Proxies.
            Response.ContentType = reply.ContentType;
            Response.Write(reply);
        }
    }
}