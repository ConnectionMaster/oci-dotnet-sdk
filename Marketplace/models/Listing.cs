/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.MarketplaceService.Models
{
    /// <summary>
    /// The model for an Oracle Cloud Infrastructure Marketplace listing.
    /// </summary>
    public class Listing 
    {
        
        /// <value>
        /// The unique identifier for the listing in Marketplace.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The name of the listing.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The version of the listing.
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// The tagline of the listing.
        /// </value>
        [JsonProperty(PropertyName = "tagline")]
        public string Tagline { get; set; }
        
        /// <value>
        /// Keywords associated with the listing.
        /// </value>
        [JsonProperty(PropertyName = "keywords")]
        public string Keywords { get; set; }
        
        /// <value>
        /// A short description of the listing.
        /// </value>
        [JsonProperty(PropertyName = "shortDescription")]
        public string ShortDescription { get; set; }
        
        /// <value>
        /// Usage information for the listing.
        /// </value>
        [JsonProperty(PropertyName = "usageInformation")]
        public string UsageInformation { get; set; }
        
        /// <value>
        /// A long description of the listing.
        /// </value>
        [JsonProperty(PropertyName = "longDescription")]
        public string LongDescription { get; set; }
        
        /// <value>
        /// A description of the publisher's licensing model for the listing.
        /// </value>
        [JsonProperty(PropertyName = "licenseModelDescription")]
        public string LicenseModelDescription { get; set; }
        
        /// <value>
        /// System requirements for the listing.
        /// </value>
        [JsonProperty(PropertyName = "systemRequirements")]
        public string SystemRequirements { get; set; }
        
        /// <value>
        /// The release date of the listing.
        /// </value>
        [JsonProperty(PropertyName = "timeReleased")]
        public System.Nullable<System.DateTime> TimeReleased { get; set; }
        
        /// <value>
        /// Release notes for the listing.
        /// </value>
        [JsonProperty(PropertyName = "releaseNotes")]
        public string ReleaseNotes { get; set; }
        
        /// <value>
        /// Categories that the listing belongs to.
        /// </value>
        [JsonProperty(PropertyName = "categories")]
        public System.Collections.Generic.List<string> Categories { get; set; }
        
        [JsonProperty(PropertyName = "publisher")]
        public Publisher Publisher { get; set; }
        
        /// <value>
        /// Languages supported by the listing.
        /// </value>
        [JsonProperty(PropertyName = "languages")]
        public System.Collections.Generic.List<Item> Languages { get; set; }
        
        /// <value>
        /// Screenshots of the listing.
        /// </value>
        [JsonProperty(PropertyName = "screenshots")]
        public System.Collections.Generic.List<Screenshot> Screenshots { get; set; }
        
        /// <value>
        /// Videos of the listing.
        /// </value>
        [JsonProperty(PropertyName = "videos")]
        public System.Collections.Generic.List<NamedLink> Videos { get; set; }
        
        /// <value>
        /// Contact information to use to get support from the publisher for the listing.
        /// </value>
        [JsonProperty(PropertyName = "supportContacts")]
        public System.Collections.Generic.List<SupportContact> SupportContacts { get; set; }
        
        /// <value>
        /// Links to support resources for the listing.
        /// </value>
        [JsonProperty(PropertyName = "supportLinks")]
        public System.Collections.Generic.List<NamedLink> SupportLinks { get; set; }
        
        /// <value>
        /// Links to additional documentation provided by the publisher specifically for the listing.
        /// </value>
        [JsonProperty(PropertyName = "documentationLinks")]
        public System.Collections.Generic.List<DocumentationLink> DocumentationLinks { get; set; }
        
        [JsonProperty(PropertyName = "icon")]
        public UploadData Icon { get; set; }
        
        [JsonProperty(PropertyName = "banner")]
        public UploadData Banner { get; set; }
        
        /// <value>
        /// The regions where you can deploy the listing. (Some listings have restrictions that limit their deployment to United States regions only.)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "regions")]
        public System.Collections.Generic.List<Region> Regions { get; set; }
        
        /// <value>
        /// The listing's package type.
        /// </value>
        [JsonProperty(PropertyName = "packageType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PackageTypeEnum> PackageType { get; set; }
        
        /// <value>
        /// The default package version.
        /// </value>
        [JsonProperty(PropertyName = "defaultPackageVersion")]
        public string DefaultPackageVersion { get; set; }
        
        /// <value>
        /// Links to reference material.
        /// </value>
        [JsonProperty(PropertyName = "links")]
        public System.Collections.Generic.List<Link> Links { get; set; }
        
        /// <value>
        /// Indicates whether the listing is included in Featured Listings.
        /// </value>
        [JsonProperty(PropertyName = "isFeatured")]
        public System.Nullable<bool> IsFeatured { get; set; }
        
        /// <value>
        /// The publisher category to which the listing belongs. The publisher category informs where the listing appears for use.
        /// </value>
        [JsonProperty(PropertyName = "listingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ListingType> ListingType { get; set; }
        
        /// <value>
        /// List of operating systems supported by the listing.
        /// </value>
        [JsonProperty(PropertyName = "supportedOperatingSystems")]
        public System.Collections.Generic.List<OperatingSystem> SupportedOperatingSystems { get; set; }
        
    }
}
