

using Legion.Core.Services;
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

namespace Legion.Core.Modules {

    /// <summary>
    /// 
    /// </summary>
    public abstract class ClientDetails : ExternalFuntionalityModule {

        /// <summary>
        /// The reference to the module
        /// </summary>
        public static ClientDetails Module {
            get { return ExternalFuntionalityModule.GetModule("ClientDetails") as ClientDetails; }
        }

        public abstract string IpAddress(RawRequest request);

        public abstract bool IsSecure(RawRequest request);

        public abstract bool IsInternal(RawRequest request);

        public abstract bool IsDatacenter(RawRequest request);

        public string IpAddress() {
            return IpAddress(RawRequest.Current);
        }

        public bool IsSecure() {
            return IsSecure(RawRequest.Current);
        }

        public bool IsInternal() {
            return IsInternal(RawRequest.Current);
        }

        public bool IsDatacenter() {
            return IsDatacenter(RawRequest.Current);
        }
    }
}