﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenCBS.MultiLanguageRessources.resx {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PaymentMethodAddEdit {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PaymentMethodAddEdit() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenCBS.MultiLanguageRessources.resx.PaymentMethodAddEdit", typeof(PaymentMethodAddEdit).Assembly);
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
        ///   Looks up a localized string similar to This payment method already exists.
        /// </summary>
        internal static string alreadyHave {
            get {
                return ResourceManager.GetString("alreadyHave", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &quot;Name&quot; is empty.
        /// </summary>
        internal static string nameEmpty {
            get {
                return ResourceManager.GetString("nameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An incorrect(Wrong) account was selected.
        /// </summary>
        internal static string selectedIncorrectAccount {
            get {
                return ResourceManager.GetString("selectedIncorrectAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add payment method.
        /// </summary>
        internal static string titleAdd {
            get {
                return ResourceManager.GetString("titleAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit payment method.
        /// </summary>
        internal static string titleEdit {
            get {
                return ResourceManager.GetString("titleEdit", resourceCulture);
            }
        }
    }
}