//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Groupssettings.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    /// <summary>Groups resource</summary>
    public class Groups : Google.Apis.Requests.IDirectResponseSchema {
        
        private string _allowExternalMembers;
        
        private string _allowGoogleCommunication;
        
        private string _allowWebPosting;
        
        private string _archiveOnly;
        
        private string _customReplyTo;
        
        private string _defaultMessageDenyNotificationText;
        
        private string _description;
        
        private string _email;
        
        private string _isArchived;
        
        private string _kind;
        
        private System.Nullable<long> _maxMessageBytes;
        
        private string _membersCanPostAsTheGroup;
        
        private string _messageDisplayFont;
        
        private string _messageModerationLevel;
        
        private string _name;
        
        private string _primaryLanguage;
        
        private string _replyTo;
        
        private string _sendMessageDenyNotification;
        
        private string _showInGroupDirectory;
        
        private string _whoCanInvite;
        
        private string _whoCanJoin;
        
        private string _whoCanPostMessage;
        
        private string _whoCanViewGroup;
        
        private string _whoCanViewMembership;
        
        private Google.Apis.Requests.RequestError _Error;
        
        private string _ETag;
        
        /// <summary>Are external members allowed to join the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowExternalMembers")]
        public virtual string AllowExternalMembers {
            get {
                return this._allowExternalMembers;
            }
            set {
                this._allowExternalMembers = value;
            }
        }
        
        /// <summary>Is google allowed to contact admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowGoogleCommunication")]
        public virtual string AllowGoogleCommunication {
            get {
                return this._allowGoogleCommunication;
            }
            set {
                this._allowGoogleCommunication = value;
            }
        }
        
        /// <summary>If posting from web is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowWebPosting")]
        public virtual string AllowWebPosting {
            get {
                return this._allowWebPosting;
            }
            set {
                this._allowWebPosting = value;
            }
        }
        
        /// <summary>If the group is archive only</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archiveOnly")]
        public virtual string ArchiveOnly {
            get {
                return this._archiveOnly;
            }
            set {
                this._archiveOnly = value;
            }
        }
        
        /// <summary>Default email to which reply to any message should go.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customReplyTo")]
        public virtual string CustomReplyTo {
            get {
                return this._customReplyTo;
            }
            set {
                this._customReplyTo = value;
            }
        }
        
        /// <summary>Default message deny notification message</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultMessageDenyNotificationText")]
        public virtual string DefaultMessageDenyNotificationText {
            get {
                return this._defaultMessageDenyNotificationText;
            }
            set {
                this._defaultMessageDenyNotificationText = value;
            }
        }
        
        /// <summary>Description of the group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description {
            get {
                return this._description;
            }
            set {
                this._description = value;
            }
        }
        
        /// <summary>Email id of the group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email {
            get {
                return this._email;
            }
            set {
                this._email = value;
            }
        }
        
        /// <summary>If the contents of the group are archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isArchived")]
        public virtual string IsArchived {
            get {
                return this._isArchived;
            }
            set {
                this._isArchived = value;
            }
        }
        
        /// <summary>The type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this._kind;
            }
            set {
                this._kind = value;
            }
        }
        
        /// <summary>Maximum message size allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessageBytes")]
        public virtual System.Nullable<long> MaxMessageBytes {
            get {
                return this._maxMessageBytes;
            }
            set {
                this._maxMessageBytes = value;
            }
        }
        
        /// <summary>Can members post using the group email address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("membersCanPostAsTheGroup")]
        public virtual string MembersCanPostAsTheGroup {
            get {
                return this._membersCanPostAsTheGroup;
            }
            set {
                this._membersCanPostAsTheGroup = value;
            }
        }
        
        /// <summary>Default message display font. Possible values are: DEFAULT_FONT FIXED_WIDTH_FONT</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageDisplayFont")]
        public virtual string MessageDisplayFont {
            get {
                return this._messageDisplayFont;
            }
            set {
                this._messageDisplayFont = value;
            }
        }
        
        /// <summary>Moderation level for messages. Possible values are: MODERATE_ALL_MESSAGES MODERATE_NON_MEMBERS MODERATE_NEW_MEMBERS MODERATE_NONE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageModerationLevel")]
        public virtual string MessageModerationLevel {
            get {
                return this._messageModerationLevel;
            }
            set {
                this._messageModerationLevel = value;
            }
        }
        
        /// <summary>Name of the Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this._name;
            }
            set {
                this._name = value;
            }
        }
        
        /// <summary>Primary language for the group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryLanguage")]
        public virtual string PrimaryLanguage {
            get {
                return this._primaryLanguage;
            }
            set {
                this._primaryLanguage = value;
            }
        }
        
        /// <summary>Whome should the default reply to a message go to. Possible values are: REPLY_TO_CUSTOM REPLY_TO_SENDER REPLY_TO_LIST REPLY_TO_OWNER REPLY_TO_IGNORE REPLY_TO_MANAGERS</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("replyTo")]
        public virtual string ReplyTo {
            get {
                return this._replyTo;
            }
            set {
                this._replyTo = value;
            }
        }
        
        /// <summary>Should the member be notified if his message is denied by owner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sendMessageDenyNotification")]
        public virtual string SendMessageDenyNotification {
            get {
                return this._sendMessageDenyNotification;
            }
            set {
                this._sendMessageDenyNotification = value;
            }
        }
        
        /// <summary>Is the group listed in groups directory</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("showInGroupDirectory")]
        public virtual string ShowInGroupDirectory {
            get {
                return this._showInGroupDirectory;
            }
            set {
                this._showInGroupDirectory = value;
            }
        }
        
        /// <summary>Permissions to invite members. Possbile values are: ALL_MEMBERS_CAN_INVITE ALL_MANAGERS_CAN_INVITE</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanInvite")]
        public virtual string WhoCanInvite {
            get {
                return this._whoCanInvite;
            }
            set {
                this._whoCanInvite = value;
            }
        }
        
        /// <summary>Permissions to join the group. Possible values are: ANYONE_CAN_JOIN ALL_IN_DOMAIN_CAN_JOIN INVITED_CAN_JOIN CAN_REQUEST_TO_JOIN</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanJoin")]
        public virtual string WhoCanJoin {
            get {
                return this._whoCanJoin;
            }
            set {
                this._whoCanJoin = value;
            }
        }
        
        /// <summary>Permissions to post messages to the group. Possible values are: NONE_CAN_POST ALL_MANAGERS_CAN_POST ALL_MEMBERS_CAN_POST ALL_IN_DOMAIN_CAN_POST ANYONE_CAN_POST</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanPostMessage")]
        public virtual string WhoCanPostMessage {
            get {
                return this._whoCanPostMessage;
            }
            set {
                this._whoCanPostMessage = value;
            }
        }
        
        /// <summary>Permissions to view group. Possbile values are: ANYONE_CAN_VIEW ALL_IN_DOMAIN_CAN_VIEW ALL_MEMBERS_CAN_VIEW ALL_MANAGERS_CAN_VIEW</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanViewGroup")]
        public virtual string WhoCanViewGroup {
            get {
                return this._whoCanViewGroup;
            }
            set {
                this._whoCanViewGroup = value;
            }
        }
        
        /// <summary>Permissions to view membership. Possbile values are: ALL_IN_DOMAIN_CAN_VIEW ALL_MEMBERS_CAN_VIEW ALL_MANAGERS_CAN_VIEW</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("whoCanViewMembership")]
        public virtual string WhoCanViewMembership {
            get {
                return this._whoCanViewMembership;
            }
            set {
                this._whoCanViewMembership = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this._Error;
            }
            set {
                this._Error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this._ETag;
            }
            set {
                this._ETag = value;
            }
        }
    }
}
namespace Google.Apis.Groupssettings.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public partial class GroupssettingsService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService _service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"discoveryVersion\":\"v1\",\"id\":\"groupssettings:" +
            "v1\",\"name\":\"groupssettings\",\"version\":\"v1\",\"revision\":\"20120417\",\"title\":\"Groups" +
            " Settings API\",\"description\":\"Lets you manage permission levels and related sett" +
            "ings of a group\",\"icons\":{\"x16\":\"http://www.google.com/images/icons/product/sear" +
            "ch-16.gif\",\"x32\":\"http://www.google.com/images/icons/product/search-32.gif\"},\"la" +
            "bels\":[\"limited_availability\"],\"protocol\":\"rest\",\"baseUrl\":\"https://www.googleap" +
            "is.com/groups/v1/groups/\",\"basePath\":\"/groups/v1/groups/\",\"rootUrl\":\"https://www" +
            ".googleapis.com/\",\"servicePath\":\"groups/v1/groups/\",\"batchPath\":\"batch\",\"paramet" +
            "ers\":{\"alt\":{\"type\":\"string\",\"description\":\"Data format for the response.\",\"defa" +
            "ult\":\"atom\",\"enum\":[\"atom\",\"json\"],\"enumDescriptions\":[\"Responses with Content-T" +
            "ype of application/atom+xml\",\"Responses with Content-Type of application/json\"]," +
            "\"location\":\"query\"},\"fields\":{\"type\":\"string\",\"description\":\"Selector specifying" +
            " which fields to include in a partial response.\",\"location\":\"query\"},\"key\":{\"typ" +
            "e\":\"string\",\"description\":\"API key. Your API key identifies your project and pro" +
            "vides you with API access, quota, and reports. Required unless you provide an OA" +
            "uth 2.0 token.\",\"location\":\"query\"},\"oauth_token\":{\"type\":\"string\",\"description\"" +
            ":\"OAuth 2.0 token for the current user.\",\"location\":\"query\"},\"prettyPrint\":{\"typ" +
            "e\":\"boolean\",\"description\":\"Returns response with indentations and line breaks.\"" +
            ",\"default\":\"true\",\"location\":\"query\"},\"quotaUser\":{\"type\":\"string\",\"description\"" +
            ":\"Available to use for quota purposes for server-side applications. Can be any a" +
            "rbitrary string assigned to a user, but should not exceed 40 characters. Overrid" +
            "es userIp if both are provided.\",\"location\":\"query\"},\"userIp\":{\"type\":\"string\",\"" +
            "description\":\"IP address of the site where the request originates. Use this if y" +
            "ou want to enforce per-user limits.\",\"location\":\"query\"}},\"auth\":{\"oauth2\":{\"sco" +
            "pes\":{\"https://www.googleapis.com/auth/apps.groups.settings\":{\"description\":\"Vie" +
            "w and manage the settings of a Google Apps Group\"}}}},\"schemas\":{\"Groups\":{\"id\":" +
            "\"Groups\",\"type\":\"object\",\"description\":\"Groups resource\",\"properties\":{\"allowExt" +
            "ernalMembers\":{\"type\":\"string\",\"description\":\"Are external members allowed to jo" +
            "in the group.\"},\"allowGoogleCommunication\":{\"type\":\"string\",\"description\":\"Is go" +
            "ogle allowed to contact admins.\"},\"allowWebPosting\":{\"type\":\"string\",\"descriptio" +
            "n\":\"If posting from web is allowed.\"},\"archiveOnly\":{\"type\":\"string\",\"descriptio" +
            "n\":\"If the group is archive only\"},\"customReplyTo\":{\"type\":\"string\",\"description" +
            "\":\"Default email to which reply to any message should go.\"},\"defaultMessageDenyN" +
            "otificationText\":{\"type\":\"string\",\"description\":\"Default message deny notificati" +
            "on message\"},\"description\":{\"type\":\"string\",\"description\":\"Description of the gr" +
            "oup\"},\"email\":{\"type\":\"string\",\"description\":\"Email id of the group\"},\"isArchive" +
            "d\":{\"type\":\"string\",\"description\":\"If the contents of the group are archived.\"}," +
            "\"kind\":{\"type\":\"string\",\"description\":\"The type of the resource.\",\"default\":\"gro" +
            "upsSettings#groups\"},\"maxMessageBytes\":{\"type\":\"integer\",\"description\":\"Maximum " +
            "message size allowed.\",\"format\":\"int32\"},\"membersCanPostAsTheGroup\":{\"type\":\"str" +
            "ing\",\"description\":\"Can members post using the group email address.\"},\"messageDi" +
            "splayFont\":{\"type\":\"string\",\"description\":\"Default message display font. Possibl" +
            "e values are: DEFAULT_FONT FIXED_WIDTH_FONT\"},\"messageModerationLevel\":{\"type\":\"" +
            "string\",\"description\":\"Moderation level for messages. Possible values are: MODER" +
            "ATE_ALL_MESSAGES MODERATE_NON_MEMBERS MODERATE_NEW_MEMBERS MODERATE_NONE\"},\"name" +
            "\":{\"type\":\"string\",\"description\":\"Name of the Group\"},\"primaryLanguage\":{\"type\":" +
            "\"string\",\"description\":\"Primary language for the group.\"},\"replyTo\":{\"type\":\"str" +
            "ing\",\"description\":\"Whome should the default reply to a message go to. Possible " +
            "values are: REPLY_TO_CUSTOM REPLY_TO_SENDER REPLY_TO_LIST REPLY_TO_OWNER REPLY_T" +
            "O_IGNORE REPLY_TO_MANAGERS\"},\"sendMessageDenyNotification\":{\"type\":\"string\",\"des" +
            "cription\":\"Should the member be notified if his message is denied by owner.\"},\"s" +
            "howInGroupDirectory\":{\"type\":\"string\",\"description\":\"Is the group listed in grou" +
            "ps directory\"},\"whoCanInvite\":{\"type\":\"string\",\"description\":\"Permissions to inv" +
            "ite members. Possbile values are: ALL_MEMBERS_CAN_INVITE ALL_MANAGERS_CAN_INVITE" +
            "\"},\"whoCanJoin\":{\"type\":\"string\",\"description\":\"Permissions to join the group. P" +
            "ossible values are: ANYONE_CAN_JOIN ALL_IN_DOMAIN_CAN_JOIN INVITED_CAN_JOIN CAN_" +
            "REQUEST_TO_JOIN\"},\"whoCanPostMessage\":{\"type\":\"string\",\"description\":\"Permission" +
            "s to post messages to the group. Possible values are: NONE_CAN_POST ALL_MANAGERS" +
            "_CAN_POST ALL_MEMBERS_CAN_POST ALL_IN_DOMAIN_CAN_POST ANYONE_CAN_POST\"},\"whoCanV" +
            "iewGroup\":{\"type\":\"string\",\"description\":\"Permissions to view group. Possbile va" +
            "lues are: ANYONE_CAN_VIEW ALL_IN_DOMAIN_CAN_VIEW ALL_MEMBERS_CAN_VIEW ALL_MANAGE" +
            "RS_CAN_VIEW\"},\"whoCanViewMembership\":{\"type\":\"string\",\"description\":\"Permissions" +
            " to view membership. Possbile values are: ALL_IN_DOMAIN_CAN_VIEW ALL_MEMBERS_CAN" +
            "_VIEW ALL_MANAGERS_CAN_VIEW\"}}}},\"resources\":{\"groups\":{\"methods\":{\"get\":{\"id\":\"" +
            "groupsSettings.groups.get\",\"path\":\"{groupUniqueId}\",\"httpMethod\":\"GET\",\"descript" +
            "ion\":\"Gets one resource by id.\",\"parameters\":{\"groupUniqueId\":{\"type\":\"string\",\"" +
            "description\":\"The resource ID\",\"required\":true,\"location\":\"path\"}},\"parameterOrd" +
            "er\":[\"groupUniqueId\"],\"response\":{\"$ref\":\"Groups\"},\"scopes\":[\"https://www.google" +
            "apis.com/auth/apps.groups.settings\"]},\"patch\":{\"id\":\"groupsSettings.groups.patch" +
            "\",\"path\":\"{groupUniqueId}\",\"httpMethod\":\"PATCH\",\"description\":\"Updates an existi" +
            "ng resource. This method supports patch semantics.\",\"parameters\":{\"groupUniqueId" +
            "\":{\"type\":\"string\",\"description\":\"The resource ID\",\"required\":true,\"location\":\"p" +
            "ath\"}},\"parameterOrder\":[\"groupUniqueId\"],\"request\":{\"$ref\":\"Groups\"},\"response\"" +
            ":{\"$ref\":\"Groups\"},\"scopes\":[\"https://www.googleapis.com/auth/apps.groups.settin" +
            "gs\"]},\"update\":{\"id\":\"groupsSettings.groups.update\",\"path\":\"{groupUniqueId}\",\"ht" +
            "tpMethod\":\"PUT\",\"description\":\"Updates an existing resource.\",\"parameters\":{\"gro" +
            "upUniqueId\":{\"type\":\"string\",\"description\":\"The resource ID\",\"required\":true,\"lo" +
            "cation\":\"path\"}},\"parameterOrder\":[\"groupUniqueId\"],\"request\":{\"$ref\":\"Groups\"}," +
            "\"response\":{\"$ref\":\"Groups\"},\"scopes\":[\"https://www.googleapis.com/auth/apps.gro" +
            "ups.settings\"]}}}}}";
        
        public const string Version = "v1";
        
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string _Key;
        
        protected GroupssettingsService(Google.Apis.Discovery.IService _service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this._service = _service;
            this._authenticator = _authenticator;
            this._groups = new GroupsResource(this, _authenticator);
        }
        
        public GroupssettingsService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public GroupssettingsService(Google.Apis.Authentication.IAuthenticator _authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(GroupssettingsService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameters(new System.Uri("https://www.googleapis.com/groups/v1/groups/"))), _authenticator) {
        }
        
        public Google.Apis.Authentication.IAuthenticator Authenticator {
            get {
                return this._authenticator;
            }
        }
        
        public virtual string Name {
            get {
                return "groupssettings";
            }
        }
        
        public virtual string BaseUri {
            get {
                return "https://www.googleapis.com/groups/v1/groups/";
            }
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this._Key;
            }
            set {
                this._Key = value;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this._service.CreateRequest(resource, method);
            if ((string.IsNullOrEmpty(Key) == false)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(_authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            _service.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return _service.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return _service.DeserializeResponse<T>(response);
        }
        
        /// <summary>A list of all OAuth2.0 scopes. Each of these scopes relates to a permission or group of permissions that different methods of this API may need.</summary>
        public enum Scopes {
            
            /// <summary>View and manage the settings of a Google Apps Group</summary>
            [Google.Apis.Util.StringValueAttribute("https://www.googleapis.com/auth/apps.groups.settings")]
            AppsGroupsSettings,
        }
    }
    
    public class GroupsResource {
        
        private GroupssettingsService service;
        
        private Google.Apis.Authentication.IAuthenticator _authenticator;
        
        private const string Resource = "groups";
        
        public GroupsResource(GroupssettingsService service, Google.Apis.Authentication.IAuthenticator _authenticator) {
            this.service = service;
            this._authenticator = _authenticator;
        }
        
        /// <summary>Gets one resource by id.</summary>
        /// <param name="groupUniqueId">Required - The resource ID</param>
        public virtual GetRequest Get(string groupUniqueId) {
            return new GetRequest(service, groupUniqueId);
        }
        
        /// <summary>Updates an existing resource. This method supports patch semantics.</summary>
        /// <param name="groupUniqueId">Required - The resource ID</param>
        public virtual PatchRequest Patch(Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId) {
            return new PatchRequest(service, body, groupUniqueId);
        }
        
        /// <summary>Updates an existing resource.</summary>
        /// <param name="groupUniqueId">Required - The resource ID</param>
        public virtual UpdateRequest Update(Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId) {
            return new UpdateRequest(service, body, groupUniqueId);
        }
        
        public class GetRequest : global::Google.Apis.Requests.ServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _groupUniqueId;
            
            public GetRequest(Google.Apis.Discovery.IRequestProvider service, string groupUniqueId) : 
                    base(service) {
                this._groupUniqueId = groupUniqueId;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>The resource ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId {
                get {
                    return this._groupUniqueId;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "groups";
                }
            }
            
            protected override string MethodName {
                get {
                    return "get";
                }
            }
        }
        
        public class PatchRequest : global::Google.Apis.Requests.ServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _groupUniqueId;
            
            private Google.Apis.Groupssettings.v1.Data.Groups _Body;
            
            public PatchRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId) : 
                    base(service) {
                this.Body = body;
                this._groupUniqueId = groupUniqueId;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>The resource ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId {
                get {
                    return this._groupUniqueId;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Groupssettings.v1.Data.Groups Body {
                get {
                    return this._Body;
                }
                set {
                    this._Body = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "groups";
                }
            }
            
            protected override string MethodName {
                get {
                    return "patch";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
        
        public class UpdateRequest : global::Google.Apis.Requests.ServiceRequest<Google.Apis.Groupssettings.v1.Data.Groups> {
            
            private string _oauth_token;
            
            private System.Nullable<bool> _prettyPrint;
            
            private string _quotaUser;
            
            private string _groupUniqueId;
            
            private Google.Apis.Groupssettings.v1.Data.Groups _Body;
            
            public UpdateRequest(Google.Apis.Discovery.IRequestProvider service, Google.Apis.Groupssettings.v1.Data.Groups body, string groupUniqueId) : 
                    base(service) {
                this.Body = body;
                this._groupUniqueId = groupUniqueId;
            }
            
            /// <summary>OAuth 2.0 token for the current user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Oauth_token {
                get {
                    return this._oauth_token;
                }
                set {
                    this._oauth_token = value;
                }
            }
            
            /// <summary>Returns response with indentations and line breaks.</summary>
            [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> PrettyPrint {
                get {
                    return this._prettyPrint;
                }
                set {
                    this._prettyPrint = value;
                }
            }
            
            /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a user, but should not exceed 40 characters. Overrides userIp if both are provided.</summary>
            [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string QuotaUser {
                get {
                    return this._quotaUser;
                }
                set {
                    this._quotaUser = value;
                }
            }
            
            /// <summary>The resource ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupUniqueId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupUniqueId {
                get {
                    return this._groupUniqueId;
                }
            }
            
            /// <summary>Gets/Sets the Body of this Request.</summary>
            public virtual Google.Apis.Groupssettings.v1.Data.Groups Body {
                get {
                    return this._Body;
                }
                set {
                    this._Body = value;
                }
            }
            
            protected override string ResourcePath {
                get {
                    return "groups";
                }
            }
            
            protected override string MethodName {
                get {
                    return "update";
                }
            }
            
            protected override object GetBody() {
                return this.Body;
            }
        }
    }
    
    public partial class GroupssettingsService {
        
        private const string Resource = "";
        
        private GroupsResource _groups;
        
        private Google.Apis.Discovery.IRequestProvider service {
            get {
                return this;
            }
        }
        
        public virtual GroupsResource Groups {
            get {
                return this._groups;
            }
        }
    }
}
