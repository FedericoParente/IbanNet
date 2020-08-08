﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IbanNet {
    using System;
    using System.Reflection;
    
    
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("IbanNet.Resources", typeof(Resources).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Invalid country code. must be exactly two characters long..
        /// </summary>
        internal static string ArgumentException_Invalid_country_code {
            get {
                return ResourceManager.GetString("ArgumentException_Invalid_country_code", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provide the registry..
        /// </summary>
        internal static string ArgumentException_Registry_is_required {
            get {
                return ResourceManager.GetString("ArgumentException_Registry_is_required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string ArgumentException_The_format_0_is_invalid {
            get {
                return ResourceManager.GetString("ArgumentException_The_format_0_is_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format &apos;{0}&apos; is invalid. Supported formats are &apos;{1}&apos; (flat) and &apos;{2}&apos; (partitioned by space)..
        /// </summary>
        internal static string ArgumentException_The_format_0_is_invalid_with_supported_formats {
            get {
                return ResourceManager.GetString("ArgumentException_The_format_0_is_invalid_with_supported_formats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format is required. Supported formats are &apos;{0}&apos; (flat) and &apos;{1}&apos; (partitioned by space)..
        /// </summary>
        internal static string ArgumentException_The_format_is_required_with_supported_formats {
            get {
                return ResourceManager.GetString("ArgumentException_The_format_is_required_with_supported_formats", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The structure segment &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string ArgumentException_The_structure_segment_0_is_invalid {
            get {
                return ResourceManager.GetString("ArgumentException_The_structure_segment_0_is_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The validation method is invalid..
        /// </summary>
        internal static string ArgumentException_ValidationMethod_is_invalid {
            get {
                return ResourceManager.GetString("ArgumentException_ValidationMethod_is_invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not a valid IBAN..
        /// </summary>
        internal static string IbanFormatException_The_value_0_is_not_a_valid_IBAN {
            get {
                return ResourceManager.GetString("IbanFormatException_The_value_0_is_not_a_valid_IBAN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IBAN contains illegal characters..
        /// </summary>
        internal static string IllegalCharactersResult {
            get {
                return ResourceManager.GetString("IllegalCharactersResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IBAN check digits are incorrect..
        /// </summary>
        internal static string InvalidCheckDigitsResult {
            get {
                return ResourceManager.GetString("InvalidCheckDigitsResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IBAN has an incorrect length..
        /// </summary>
        internal static string InvalidLengthResult {
            get {
                return ResourceManager.GetString("InvalidLengthResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The structure of the IBAN is incorrect..
        /// </summary>
        internal static string InvalidStructureResult {
            get {
                return ResourceManager.GetString("InvalidStructureResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected alphanumeric character at position {0}, but found &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidTokenException_Expected_alphanumeric_character_at_position_0_but_found_1 {
            get {
                return ResourceManager.GetString("InvalidTokenException_Expected_alphanumeric_character_at_position_0_but_found_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more providers is required..
        /// </summary>
        internal static string One_or_more_providers_is_required {
            get {
                return ResourceManager.GetString("One_or_more_providers_is_required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one character to partition on is required..
        /// </summary>
        internal static string PartitionOn_At_least_one_character_to_partition_on_is_required {
            get {
                return ResourceManager.GetString("PartitionOn_At_least_one_character_to_partition_on_is_required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The registry has no providers..
        /// </summary>
        internal static string The_registry_has_no_providers {
            get {
                return ResourceManager.GetString("The_registry_has_no_providers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The country code is unknown/not supported..
        /// </summary>
        internal static string UnknownCountryCodeResult {
            get {
                return ResourceManager.GetString("UnknownCountryCodeResult", resourceCulture);
            }
        }
    }
}
