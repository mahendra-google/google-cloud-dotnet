// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/support/v2/comment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Support.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/support/v2/comment.proto</summary>
  public static partial class CommentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/support/v2/comment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvY2xvdWQvc3VwcG9ydC92Mi9jb21tZW50LnByb3RvEhdnb29n",
            "bGUuY2xvdWQuc3VwcG9ydC52MhofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxojZ29vZ2xlL2Ns",
            "b3VkL3N1cHBvcnQvdjIvYWN0b3IucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8i1wIKB0NvbW1lbnQSFAoEbmFtZRgBIAEoCUIG4EEI",
            "4EEDEjQKC2NyZWF0ZV90aW1lGAIgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
            "bWVzdGFtcEID4EEDEjQKB2NyZWF0b3IYAyABKAsyHi5nb29nbGUuY2xvdWQu",
            "c3VwcG9ydC52Mi5BY3RvckID4EEDEgwKBGJvZHkYBCABKAkSHgoPcGxhaW5f",
            "dGV4dF9ib2R5GAUgASgJQgUYAeBBAzqbAepBlwEKI2Nsb3Vkc3VwcG9ydC5n",
            "b29nbGVhcGlzLmNvbS9Db21tZW50Ejxvcmdhbml6YXRpb25zL3tvcmdhbml6",
            "YXRpb259L2Nhc2VzL3tjYXNlfS9jb21tZW50cy97Y29tbWVudH0SMnByb2pl",
            "Y3RzL3twcm9qZWN0fS9jYXNlcy97Y2FzZX0vY29tbWVudHMve2NvbW1lbnR9",
            "QrUBChtjb20uZ29vZ2xlLmNsb3VkLnN1cHBvcnQudjJCDENvbW1lbnRQcm90",
            "b1ABWjVjbG91ZC5nb29nbGUuY29tL2dvL3N1cHBvcnQvYXBpdjIvc3VwcG9y",
            "dHBiO3N1cHBvcnRwYqoCF0dvb2dsZS5DbG91ZC5TdXBwb3J0LlYyygIXR29v",
            "Z2xlXENsb3VkXFN1cHBvcnRcVjLqAhpHb29nbGU6OkNsb3VkOjpTdXBwb3J0",
            "OjpWMmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.Support.V2.ActorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Support.V2.Comment), global::Google.Cloud.Support.V2.Comment.Parser, new[]{ "Name", "CreateTime", "Creator", "Body", "PlainTextBody" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A comment associated with a support case.
  ///
  /// Case comments are the primary way for Google Support to communicate with a
  /// user who has opened a case. When a user responds to Google Support, the
  /// user's responses also appear as comments.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Comment : pb::IMessage<Comment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Comment> _parser = new pb::MessageParser<Comment>(() => new Comment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Comment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Support.V2.CommentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Comment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Comment(Comment other) : this() {
      name_ = other.name_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      creator_ = other.creator_ != null ? other.creator_.Clone() : null;
      body_ = other.body_;
      plainTextBody_ = other.plainTextBody_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Comment Clone() {
      return new Comment(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Identifier. The resource name of the comment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time when the comment was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "creator" field.</summary>
    public const int CreatorFieldNumber = 3;
    private global::Google.Cloud.Support.V2.Actor creator_;
    /// <summary>
    /// Output only. The user or Google Support agent who created the comment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Support.V2.Actor Creator {
      get { return creator_; }
      set {
        creator_ = value;
      }
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 4;
    private string body_ = "";
    /// <summary>
    /// The full comment body.
    ///
    /// Maximum of 12800 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Body {
      get { return body_; }
      set {
        body_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "plain_text_body" field.</summary>
    public const int PlainTextBodyFieldNumber = 5;
    private string plainTextBody_ = "";
    /// <summary>
    /// Output only. DEPRECATED. DO NOT USE.
    ///
    /// A duplicate of the `body` field.
    ///
    /// This field is only present for legacy reasons.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PlainTextBody {
      get { return plainTextBody_; }
      set {
        plainTextBody_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Comment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Comment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(Creator, other.Creator)) return false;
      if (Body != other.Body) return false;
      if (PlainTextBody != other.PlainTextBody) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (creator_ != null) hash ^= Creator.GetHashCode();
      if (Body.Length != 0) hash ^= Body.GetHashCode();
      if (PlainTextBody.Length != 0) hash ^= PlainTextBody.GetHashCode();
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
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (creator_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Creator);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Body);
      }
      if (PlainTextBody.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PlainTextBody);
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
      if (createTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CreateTime);
      }
      if (creator_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Creator);
      }
      if (Body.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Body);
      }
      if (PlainTextBody.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(PlainTextBody);
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
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (creator_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Creator);
      }
      if (Body.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Body);
      }
      if (PlainTextBody.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlainTextBody);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Comment other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.creator_ != null) {
        if (creator_ == null) {
          Creator = new global::Google.Cloud.Support.V2.Actor();
        }
        Creator.MergeFrom(other.Creator);
      }
      if (other.Body.Length != 0) {
        Body = other.Body;
      }
      if (other.PlainTextBody.Length != 0) {
        PlainTextBody = other.PlainTextBody;
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            if (creator_ == null) {
              Creator = new global::Google.Cloud.Support.V2.Actor();
            }
            input.ReadMessage(Creator);
            break;
          }
          case 34: {
            Body = input.ReadString();
            break;
          }
          case 42: {
            PlainTextBody = input.ReadString();
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
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 26: {
            if (creator_ == null) {
              Creator = new global::Google.Cloud.Support.V2.Actor();
            }
            input.ReadMessage(Creator);
            break;
          }
          case 34: {
            Body = input.ReadString();
            break;
          }
          case 42: {
            PlainTextBody = input.ReadString();
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
