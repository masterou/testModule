using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Test.Module.RNTestModule
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNTestModuleModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNTestModuleModule"/>.
        /// </summary>
        internal RNTestModuleModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNTestModule";
            }
        }
    }
}
