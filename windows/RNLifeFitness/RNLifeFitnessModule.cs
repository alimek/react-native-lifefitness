using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Life.Fitness.RNLifeFitness
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLifeFitnessModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLifeFitnessModule"/>.
        /// </summary>
        internal RNLifeFitnessModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLifeFitness";
            }
        }
    }
}
