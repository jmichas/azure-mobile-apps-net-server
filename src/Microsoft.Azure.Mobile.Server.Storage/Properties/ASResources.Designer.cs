﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Mobile.Server.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ASResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ASResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Mobile.Server.Properties.ASResources", typeof(ASResources).Assembly);
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
        ///   Looks up a localized string similar to No connection string named &apos;{0}&apos; could be found in the service configuration..
        /// </summary>
        internal static string DomainManager_ConnectionStringNotFound {
            get {
                return ResourceManager.GetString("DomainManager_ConnectionStringNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation failed with the following error: &apos;{0}&apos;..
        /// </summary>
        internal static string DomainManager_InvalidOperation {
            get {
                return ResourceManager.GetString("DomainManager_InvalidOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The query specified in the URI is not valid: &apos;{0}&apos;..
        /// </summary>
        internal static string DomainManager_InvalidQueryUri {
            get {
                return ResourceManager.GetString("DomainManager_InvalidQueryUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key &apos;{0}&apos; is not valid. It must be a comma separated tuple representing a partition key and a row key..
        /// </summary>
        internal static string StorageTable_InvalidKey {
            get {
                return ResourceManager.GetString("StorageTable_InvalidKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not create a &apos;{0}&apos; instance from the connection string named &apos;{1}&apos;..
        /// </summary>
        internal static string StorageTable_NoCloudStorageAccount {
            get {
                return ResourceManager.GetString("StorageTable_NoCloudStorageAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; field in the HTTP request body must match the values used in the request URI. Expected a value of &apos;{1}&apos; but received &apos;{2}&apos;..
        /// </summary>
        internal static string TableController_KeyMismatch {
            get {
                return ResourceManager.GetString("TableController_KeyMismatch", resourceCulture);
            }
        }
    }
}
