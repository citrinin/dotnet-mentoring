﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileService.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileService.Resources.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Are you sure that you want to stop work of application (Y/y).
        /// </summary>
        internal static string AskConfirmationOfExit {
            get {
                return ResourceManager.GetString("AskConfirmationOfExit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} doesn&apos;t exist. Change configuration file..
        /// </summary>
        internal static string DirectoryDoesntExist {
            get {
                return ResourceManager.GetString("DirectoryDoesntExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit from the application....
        /// </summary>
        internal static string EndOfWork {
            get {
                return ResourceManager.GetString("EndOfWork", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while adding folder {0} for watching.
        /// </summary>
        internal static string ErrorWatching {
            get {
                return ResourceManager.GetString("ErrorWatching", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File moved to {0}.
        /// </summary>
        internal static string FileMoved {
            get {
                return ResourceManager.GetString("FileMoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder {0} is added for watching.
        /// </summary>
        internal static string FolderRegistration {
            get {
                return ResourceManager.GetString("FolderRegistration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome aboard capitan! .
        /// </summary>
        internal static string Greeting {
            get {
                return ResourceManager.GetString("Greeting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occurred: {0}.
        /// </summary>
        internal static string MoveError {
            get {
                return ResourceManager.GetString("MoveError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} - New file {1}.
        /// </summary>
        internal static string NewFileFound {
            get {
                return ResourceManager.GetString("NewFileFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filename match pattern {0}.
        /// </summary>
        internal static string PatternMatch {
            get {
                return ResourceManager.GetString("PatternMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pattern not found. File {0} moved to default folder .
        /// </summary>
        internal static string PatternNotFound {
            get {
                return ResourceManager.GetString("PatternNotFound", resourceCulture);
            }
        }
    }
}
