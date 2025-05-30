// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/gkebackup/v1/restore_channel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.GkeBackup.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/gkebackup/v1/restore_channel.proto</summary>
  public static partial class RestoreChannelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/gkebackup/v1/restore_channel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RestoreChannelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvY2xvdWQvZ2tlYmFja3VwL3YxL3Jlc3RvcmVfY2hhbm5lbC5w",
            "cm90bxIZZ29vZ2xlLmNsb3VkLmdrZWJhY2t1cC52MRofZ29vZ2xlL2FwaS9m",
            "aWVsZF9iZWhhdmlvci5wcm90bxobZ29vZ2xlL2FwaS9maWVsZF9pbmZvLnBy",
            "b3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh9nb29nbGUvcHJvdG9i",
            "dWYvdGltZXN0YW1wLnByb3RvIrcECg5SZXN0b3JlQ2hhbm5lbBIRCgRuYW1l",
            "GAEgASgJQgPgQQgSIwoTZGVzdGluYXRpb25fcHJvamVjdBgCIAEoCUIG4EEF",
            "4EECEhgKA3VpZBgDIAEoCUIL4EED4ozP1wgCCAESNAoLY3JlYXRlX3RpbWUY",
            "BCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPgQQMSNAoLdXBk",
            "YXRlX3RpbWUYBSABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wQgPg",
            "QQMSSgoGbGFiZWxzGAYgAygLMjUuZ29vZ2xlLmNsb3VkLmdrZWJhY2t1cC52",
            "MS5SZXN0b3JlQ2hhbm5lbC5MYWJlbHNFbnRyeUID4EEBEhgKC2Rlc2NyaXB0",
            "aW9uGAcgASgJQgPgQQESEQoEZXRhZxgIIAEoCUID4EEDEiMKFmRlc3RpbmF0",
            "aW9uX3Byb2plY3RfaWQYCSABKAlCA+BBAxotCgtMYWJlbHNFbnRyeRILCgNr",
            "ZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBOpkB6kGVAQonZ2tlYmFja3Vw",
            "Lmdvb2dsZWFwaXMuY29tL1Jlc3RvcmVDaGFubmVsEklwcm9qZWN0cy97cHJv",
            "amVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0vcmVzdG9yZUNoYW5uZWxzL3ty",
            "ZXN0b3JlX2NoYW5uZWx9Kg9yZXN0b3JlQ2hhbm5lbHMyDnJlc3RvcmVDaGFu",
            "bmVsQsoBCh1jb20uZ29vZ2xlLmNsb3VkLmdrZWJhY2t1cC52MUITUmVzdG9y",
            "ZUNoYW5uZWxQcm90b1ABWjtjbG91ZC5nb29nbGUuY29tL2dvL2drZWJhY2t1",
            "cC9hcGl2MS9na2ViYWNrdXBwYjtna2ViYWNrdXBwYqoCGUdvb2dsZS5DbG91",
            "ZC5Ha2VCYWNrdXAuVjHKAhlHb29nbGVcQ2xvdWRcR2tlQmFja3VwXFYx6gIc",
            "R29vZ2xlOjpDbG91ZDo6R2tlQmFja3VwOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.FieldInfoReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.GkeBackup.V1.RestoreChannel), global::Google.Cloud.GkeBackup.V1.RestoreChannel.Parser, new[]{ "Name", "DestinationProject", "Uid", "CreateTime", "UpdateTime", "Labels", "Description", "Etag", "DestinationProjectId" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A RestoreChannel imposes constraints on where backups can be restored.
  /// The RestoreChannel should be in the same project and region
  /// as the backups. The backups can only be restored in the
  /// `destination_project`.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RestoreChannel : pb::IMessage<RestoreChannel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RestoreChannel> _parser = new pb::MessageParser<RestoreChannel>(() => new RestoreChannel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RestoreChannel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.GkeBackup.V1.RestoreChannelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreChannel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreChannel(RestoreChannel other) : this() {
      name_ = other.name_;
      destinationProject_ = other.destinationProject_;
      uid_ = other.uid_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      labels_ = other.labels_.Clone();
      description_ = other.description_;
      etag_ = other.etag_;
      destinationProjectId_ = other.destinationProjectId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RestoreChannel Clone() {
      return new RestoreChannel(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Identifier. The fully qualified name of the RestoreChannel.
    /// `projects/*/locations/*/restoreChannels/*`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destination_project" field.</summary>
    public const int DestinationProjectFieldNumber = 2;
    private string destinationProject_ = "";
    /// <summary>
    /// Required. Immutable. The project into which the backups will be restored.
    /// The format is `projects/{projectId}` or `projects/{projectNumber}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DestinationProject {
      get { return destinationProject_; }
      set {
        destinationProject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 3;
    private string uid_ = "";
    /// <summary>
    /// Output only. Server generated global unique identifier of
    /// [UUID](https://en.wikipedia.org/wiki/Universally_unique_identifier) format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The timestamp when this RestoreChannel was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. The timestamp when this RestoreChannel was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. A set of custom labels supplied by user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 7;
    private string description_ = "";
    /// <summary>
    /// Optional. User specified descriptive string for this RestoreChannel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "etag" field.</summary>
    public const int EtagFieldNumber = 8;
    private string etag_ = "";
    /// <summary>
    /// Output only. `etag` is used for optimistic concurrency control as a way to
    /// help prevent simultaneous updates of a RestoreChannel from overwriting each
    /// other. It is strongly suggested that systems make use of the 'etag' in the
    /// read-modify-write cycle to perform RestoreChannel updates in order to
    /// avoid race conditions: An `etag` is returned in the response to
    /// `GetRestoreChannel`, and systems are expected to put that etag in the
    /// request to `UpdateRestoreChannel` or `DeleteRestoreChannel` to
    /// ensure that their change will be applied to the same version of the
    /// resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Etag {
      get { return etag_; }
      set {
        etag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "destination_project_id" field.</summary>
    public const int DestinationProjectIdFieldNumber = 9;
    private string destinationProjectId_ = "";
    /// <summary>
    /// Output only. The project_id where backups will be restored.
    /// Example Project ID: "my-project-id".
    /// This will be an OUTPUT_ONLY field to return the project_id of the
    /// destination project.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DestinationProjectId {
      get { return destinationProjectId_; }
      set {
        destinationProjectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RestoreChannel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RestoreChannel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DestinationProject != other.DestinationProject) return false;
      if (Uid != other.Uid) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (Description != other.Description) return false;
      if (Etag != other.Etag) return false;
      if (DestinationProjectId != other.DestinationProjectId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DestinationProject.Length != 0) hash ^= DestinationProject.GetHashCode();
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Etag.Length != 0) hash ^= Etag.GetHashCode();
      if (DestinationProjectId.Length != 0) hash ^= DestinationProjectId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DestinationProject.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DestinationProject);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Uid);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (Description.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Description);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Etag);
      }
      if (DestinationProjectId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DestinationProjectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DestinationProject.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DestinationProject);
      }
      if (Uid.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Uid);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UpdateTime);
      }
      labels_.WriteTo(ref output, _map_labels_codec);
      if (Description.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Description);
      }
      if (Etag.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Etag);
      }
      if (DestinationProjectId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(DestinationProjectId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DestinationProject.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DestinationProject);
      }
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Etag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Etag);
      }
      if (DestinationProjectId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DestinationProjectId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RestoreChannel other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DestinationProject.Length != 0) {
        DestinationProject = other.DestinationProject;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      labels_.MergeFrom(other.labels_);
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Etag.Length != 0) {
        Etag = other.Etag;
      }
      if (other.DestinationProjectId.Length != 0) {
        DestinationProjectId = other.DestinationProjectId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DestinationProject = input.ReadString();
            break;
          }
          case 26: {
            Uid = input.ReadString();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            Description = input.ReadString();
            break;
          }
          case 66: {
            Etag = input.ReadString();
            break;
          }
          case 74: {
            DestinationProjectId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DestinationProject = input.ReadString();
            break;
          }
          case 26: {
            Uid = input.ReadString();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(ref input, _map_labels_codec);
            break;
          }
          case 58: {
            Description = input.ReadString();
            break;
          }
          case 66: {
            Etag = input.ReadString();
            break;
          }
          case 74: {
            DestinationProjectId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
