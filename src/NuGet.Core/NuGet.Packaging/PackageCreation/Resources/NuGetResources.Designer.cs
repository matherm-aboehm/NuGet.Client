﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.Packaging.PackageCreation.Resources {
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
    internal class NuGetResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NuGetResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.Packaging.PackageCreation.Resources.NuGetResources", typeof(NuGetResources).Assembly);
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
        ///   Looks up a localized string similar to Cannot create a package that has no dependencies nor content..
        /// </summary>
        internal static string CannotCreateEmptyPackage {
            get {
                return ResourceManager.GetString("CannotCreateEmptyPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dependency &apos;{0}&apos; has an invalid version..
        /// </summary>
        internal static string DependencyHasInvalidVersion {
            get {
                return ResourceManager.GetString("DependencyHasInvalidVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; already has a dependency defined for &apos;{1}&apos;..
        /// </summary>
        internal static string DuplicateDependenciesDefined {
            get {
                return ResourceManager.GetString("DuplicateDependenciesDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open the icon file &apos;{0}&apos;: {1}..
        /// </summary>
        internal static string IconCannotOpenFile {
            get {
                return ResourceManager.GetString("IconCannotOpenFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The icon file is empty..
        /// </summary>
        internal static string IconErrorEmpty {
            get {
                return ResourceManager.GetString("IconErrorEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;icon&apos; element &apos;{0}&apos; has an invalid file extension. Valid options are .png, .jpg or .jpeg..
        /// </summary>
        internal static string IconInvalidExtension {
            get {
                return ResourceManager.GetString("IconInvalidExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The icon file size must not exceed 1 megabyte..
        /// </summary>
        internal static string IconMaxFileSizeExceeded {
            get {
                return ResourceManager.GetString("IconMaxFileSizeExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The element &apos;icon&apos; cannot be empty..
        /// </summary>
        internal static string IconMissingRequiredValue {
            get {
                return ResourceManager.GetString("IconMissingRequiredValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The icon file &apos;{0}&apos; does not exist in the package..
        /// </summary>
        internal static string IconNoFileElement {
            get {
                return ResourceManager.GetString("IconNoFileElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The icon file &apos;{0}&apos; does not exist in the package. (Did you mean &apos;{1}&apos;?).
        /// </summary>
        internal static string IconNoFileElementWithHint {
            get {
                return ResourceManager.GetString("IconNoFileElementWithHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The schema version of &apos;{0}&apos; is incompatible with version {1} of NuGet. Please upgrade NuGet to the latest version from http://go.microsoft.com/fwlink/?LinkId=213942..
        /// </summary>
        internal static string IncompatibleSchema {
            get {
                return ResourceManager.GetString("IncompatibleSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The package ID &apos;{0}&apos; contains invalid characters. Examples of valid package IDs include &apos;MyPackage&apos; and &apos;MyPackage.Sample&apos;..
        /// </summary>
        internal static string InvalidPackageId {
            get {
                return ResourceManager.GetString("InvalidPackageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;dependencies&gt; element must not contain both &lt;group&gt; and &lt;dependency&gt; child elements..
        /// </summary>
        internal static string Manifest_DependenciesHasMixedElements {
            get {
                return ResourceManager.GetString("Manifest_DependenciesHasMixedElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exclude path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_ExcludeContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_ExcludeContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Id must not exceed 100 characters..
        /// </summary>
        internal static string Manifest_IdMaxLengthExceeded {
            get {
                return ResourceManager.GetString("Manifest_IdMaxLengthExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;minClientVersion&apos; attribute in the package manifest has invalid value. It must be a valid version string..
        /// </summary>
        internal static string Manifest_InvalidMinClientVersion {
            get {
                return ResourceManager.GetString("Manifest_InvalidMinClientVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid assembly reference &apos;{0}&apos;. Ensure that a file named &apos;{0}&apos; exists in the lib directory..
        /// </summary>
        internal static string Manifest_InvalidReference {
            get {
                return ResourceManager.GetString("Manifest_InvalidReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assembly reference &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_InvalidReferenceFile {
            get {
                return ResourceManager.GetString("Manifest_InvalidReferenceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The license file &apos;{0}&apos; has an invalid extension. Valid options are .txt, .md or none..
        /// </summary>
        internal static string Manifest_LicenseFileExtensionIsInvalid {
            get {
                return ResourceManager.GetString("Manifest_LicenseFileExtensionIsInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The license file &apos;{0}&apos; does not exist in the package..
        /// </summary>
        internal static string Manifest_LicenseFileIsNotInNupkg {
            get {
                return ResourceManager.GetString("Manifest_LicenseFileIsNotInNupkg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The license file &apos;{0}&apos; does not exist in the package. (Did you mean &apos;{1}&apos;?).
        /// </summary>
        internal static string Manifest_LicenseFileIsNotInNupkgWithHint {
            get {
                return ResourceManager.GetString("Manifest_LicenseFileIsNotInNupkgWithHint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The licenseUrl and license elements cannot be used together..
        /// </summary>
        internal static string Manifest_LicenseUrlCannotBeUsedWithLicenseMetadata {
            get {
                return ResourceManager.GetString("Manifest_LicenseUrlCannotBeUsedWithLicenseMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occured while trying to parse the value &apos;{0}&apos; of property &apos;{1}&apos; in the manifest file..
        /// </summary>
        internal static string Manifest_PropertyValueReadFailure {
            get {
                return ResourceManager.GetString("Manifest_PropertyValueReadFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;references&gt; element must not contain both &lt;group&gt; and &lt;reference&gt; child elements..
        /// </summary>
        internal static string Manifest_ReferencesHasMixedElements {
            get {
                return ResourceManager.GetString("Manifest_ReferencesHasMixedElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The element package\metadata\references\group must contain at least one &lt;reference&gt; child element..
        /// </summary>
        internal static string Manifest_ReferencesIsEmpty {
            get {
                return ResourceManager.GetString("Manifest_ReferencesIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The required element &apos;{0}&apos; is missing from the manifest..
        /// </summary>
        internal static string Manifest_RequiredElementMissing {
            get {
                return ResourceManager.GetString("Manifest_RequiredElementMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is required..
        /// </summary>
        internal static string Manifest_RequiredMetadataMissing {
            get {
                return ResourceManager.GetString("Manifest_RequiredMetadataMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EmitRequireLicenseAcceptance must not be set to false if RequireLicenseAcceptance is set to true..
        /// </summary>
        internal static string Manifest_RequireLicenseAcceptanceRequiresEmit {
            get {
                return ResourceManager.GetString("Manifest_RequireLicenseAcceptanceRequiresEmit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabling license acceptance requires a license or a licenseUrl to be specified. The licenseUrl will be deprecated, consider using the license metadata..
        /// </summary>
        internal static string Manifest_RequireLicenseAcceptanceRequiresLicenseUrl {
            get {
                return ResourceManager.GetString("Manifest_RequireLicenseAcceptanceRequiresLicenseUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_SourceContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_SourceContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Target path &apos;{0}&apos; contains invalid characters..
        /// </summary>
        internal static string Manifest_TargetContainsInvalidCharacters {
            get {
                return ResourceManager.GetString("Manifest_TargetContainsInvalidCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} cannot be empty..
        /// </summary>
        internal static string Manifest_UriCannotBeEmpty {
            get {
                return ResourceManager.GetString("Manifest_UriCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File not found: &apos;{0}&apos;..
        /// </summary>
        internal static string PackageAuthoring_FileNotFound {
            get {
                return ResourceManager.GetString("PackageAuthoring_FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown schema version &apos;{0}&apos;..
        /// </summary>
        internal static string UnknownSchemaVersion {
            get {
                return ResourceManager.GetString("UnknownSchemaVersion", resourceCulture);
            }
        }
    }
}
