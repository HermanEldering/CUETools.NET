﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CUETools.Ripper.SCSI {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CUETools.Ripper.SCSI.Resource1", typeof(Resource1).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to failed to autodetect read command.
        /// </summary>
        internal static string AutodetectReadCommandFailed {
            get {
                return ResourceManager.GetString("AutodetectReadCommandFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error querying drive.
        /// </summary>
        internal static string DeviceInquiryError {
            get {
                return ResourceManager.GetString("DeviceInquiryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to not an MMC device.
        /// </summary>
        internal static string DeviceNotMMC {
            get {
                return ResourceManager.GetString("DeviceNotMMC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Open failed.
        /// </summary>
        internal static string DeviceOpenError {
            get {
                return ResourceManager.GetString("DeviceOpenError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to no audio.
        /// </summary>
        internal static string NoAudio {
            get {
                return ResourceManager.GetString("NoAudio", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading CD.
        /// </summary>
        internal static string ReadCDError {
            get {
                return ResourceManager.GetString("ReadCDError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open CD.
        /// </summary>
        internal static string ReadTOCError {
            get {
                return ResourceManager.GetString("ReadTOCError", resourceCulture);
            }
        }
    }
}
