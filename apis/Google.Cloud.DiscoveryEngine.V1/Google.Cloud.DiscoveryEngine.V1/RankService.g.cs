// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1/rank_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DiscoveryEngine.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/discoveryengine/v1/rank_service.proto</summary>
  public static partial class RankServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/discoveryengine/v1/rank_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RankServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxL3Jhbmtfc2Vydmlj",
            "ZS5wcm90bxIfZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MRocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQu",
            "cHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8iSgoNUmFua2luZ1JlY29yZBIKCgJpZBgB",
            "IAEoCRINCgV0aXRsZRgCIAEoCRIPCgdjb250ZW50GAMgASgJEg0KBXNjb3Jl",
            "GAQgASgCIv8CCgtSYW5rUmVxdWVzdBJMCg5yYW5raW5nX2NvbmZpZxgBIAEo",
            "CUI04EEC+kEuCixkaXNjb3ZlcnllbmdpbmUuZ29vZ2xlYXBpcy5jb20vUmFu",
            "a2luZ0NvbmZpZxINCgVtb2RlbBgCIAEoCRINCgV0b3BfbhgDIAEoBRINCgVx",
            "dWVyeRgEIAEoCRJECgdyZWNvcmRzGAUgAygLMi4uZ29vZ2xlLmNsb3VkLmRp",
            "c2NvdmVyeWVuZ2luZS52MS5SYW5raW5nUmVjb3JkQgPgQQISKQohaWdub3Jl",
            "X3JlY29yZF9kZXRhaWxzX2luX3Jlc3BvbnNlGAYgASgIElEKC3VzZXJfbGFi",
            "ZWxzGAcgAygLMjwuZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MS5S",
            "YW5rUmVxdWVzdC5Vc2VyTGFiZWxzRW50cnkaMQoPVXNlckxhYmVsc0VudHJ5",
            "EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEiTwoMUmFua1Jlc3Bv",
            "bnNlEj8KB3JlY29yZHMYBSADKAsyLi5nb29nbGUuY2xvdWQuZGlzY292ZXJ5",
            "ZW5naW5lLnYxLlJhbmtpbmdSZWNvcmQylQIKC1JhbmtTZXJ2aWNlErEBCgRS",
            "YW5rEiwuZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MS5SYW5rUmVx",
            "dWVzdBotLmdvb2dsZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjEuUmFua1Jl",
            "c3BvbnNlIkyC0+STAkYiQS92MS97cmFua2luZ19jb25maWc9cHJvamVjdHMv",
            "Ki9sb2NhdGlvbnMvKi9yYW5raW5nQ29uZmlncy8qfTpyYW5rOgEqGlLKQR5k",
            "aXNjb3ZlcnllbmdpbmUuZ29vZ2xlYXBpcy5jb23SQS5odHRwczovL3d3dy5n",
            "b29nbGVhcGlzLmNvbS9hdXRoL2Nsb3VkLXBsYXRmb3JtQoMCCiNjb20uZ29v",
            "Z2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MUIQUmFua1NlcnZpY2VQcm90",
            "b1ABWk1jbG91ZC5nb29nbGUuY29tL2dvL2Rpc2NvdmVyeWVuZ2luZS9hcGl2",
            "MS9kaXNjb3ZlcnllbmdpbmVwYjtkaXNjb3ZlcnllbmdpbmVwYqICD0RJU0NP",
            "VkVSWUVOR0lORaoCH0dvb2dsZS5DbG91ZC5EaXNjb3ZlcnlFbmdpbmUuVjHK",
            "Ah9Hb29nbGVcQ2xvdWRcRGlzY292ZXJ5RW5naW5lXFYx6gIiR29vZ2xlOjpD",
            "bG91ZDo6RGlzY292ZXJ5RW5naW5lOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.RankingRecord), global::Google.Cloud.DiscoveryEngine.V1.RankingRecord.Parser, new[]{ "Id", "Title", "Content", "Score" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.RankRequest), global::Google.Cloud.DiscoveryEngine.V1.RankRequest.Parser, new[]{ "RankingConfig", "Model", "TopN", "Query", "Records", "IgnoreRecordDetailsInResponse", "UserLabels" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.RankResponse), global::Google.Cloud.DiscoveryEngine.V1.RankResponse.Parser, new[]{ "Records" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Record message for
  /// [RankService.Rank][google.cloud.discoveryengine.v1.RankService.Rank] method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RankingRecord : pb::IMessage<RankingRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RankingRecord> _parser = new pb::MessageParser<RankingRecord>(() => new RankingRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RankingRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1.RankServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankingRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankingRecord(RankingRecord other) : this() {
      id_ = other.id_;
      title_ = other.title_;
      content_ = other.content_;
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankingRecord Clone() {
      return new RankingRecord(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// The unique ID to represent the record.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 2;
    private string title_ = "";
    /// <summary>
    /// The title of the record. Empty by default.
    /// At least one of
    /// [title][google.cloud.discoveryengine.v1.RankingRecord.title] or
    /// [content][google.cloud.discoveryengine.v1.RankingRecord.content] should be
    /// set otherwise an INVALID_ARGUMENT error is thrown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 3;
    private string content_ = "";
    /// <summary>
    /// The content of the record. Empty by default.
    /// At least one of
    /// [title][google.cloud.discoveryengine.v1.RankingRecord.title] or
    /// [content][google.cloud.discoveryengine.v1.RankingRecord.content] should be
    /// set otherwise an INVALID_ARGUMENT error is thrown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 4;
    private float score_;
    /// <summary>
    /// The score of this record based on the given query and selected model.
    /// The score will be rounded to 2 decimal places. If the score is close to 0,
    /// it will be rounded to 0.0001 to avoid returning unset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RankingRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RankingRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Title != other.Title) return false;
      if (Content != other.Content) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Score, other.Score)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Score);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Content);
      }
      if (Score != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Score);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Title.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Title);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Content);
      }
      if (Score != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Score);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (Score != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RankingRecord other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.Score != 0F) {
        Score = other.Score;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            Content = input.ReadString();
            break;
          }
          case 37: {
            Score = input.ReadFloat();
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Title = input.ReadString();
            break;
          }
          case 26: {
            Content = input.ReadString();
            break;
          }
          case 37: {
            Score = input.ReadFloat();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Request message for
  /// [RankService.Rank][google.cloud.discoveryengine.v1.RankService.Rank] method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RankRequest : pb::IMessage<RankRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RankRequest> _parser = new pb::MessageParser<RankRequest>(() => new RankRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RankRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1.RankServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankRequest(RankRequest other) : this() {
      rankingConfig_ = other.rankingConfig_;
      model_ = other.model_;
      topN_ = other.topN_;
      query_ = other.query_;
      records_ = other.records_.Clone();
      ignoreRecordDetailsInResponse_ = other.ignoreRecordDetailsInResponse_;
      userLabels_ = other.userLabels_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankRequest Clone() {
      return new RankRequest(this);
    }

    /// <summary>Field number for the "ranking_config" field.</summary>
    public const int RankingConfigFieldNumber = 1;
    private string rankingConfig_ = "";
    /// <summary>
    /// Required. The resource name of the rank service config, such as
    /// `projects/{project_num}/locations/{location}/rankingConfigs/default_ranking_config`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RankingConfig {
      get { return rankingConfig_; }
      set {
        rankingConfig_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "model" field.</summary>
    public const int ModelFieldNumber = 2;
    private string model_ = "";
    /// <summary>
    /// The identifier of the model to use. It is one of:
    ///
    /// * `semantic-ranker-512@latest`: Semantic ranking model with maximum input
    /// token size 512.
    ///
    /// It is set to `semantic-ranker-512@latest` by default if unspecified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Model {
      get { return model_; }
      set {
        model_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "top_n" field.</summary>
    public const int TopNFieldNumber = 3;
    private int topN_;
    /// <summary>
    /// The number of results to return. If this is unset or no bigger than zero,
    /// returns all results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TopN {
      get { return topN_; }
      set {
        topN_ = value;
      }
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 4;
    private string query_ = "";
    /// <summary>
    /// The query to use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord> _repeated_records_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.DiscoveryEngine.V1.RankingRecord.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord> records_ = new pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord>();
    /// <summary>
    /// Required. A list of records to rank. At most 200 records to rank.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord> Records {
      get { return records_; }
    }

    /// <summary>Field number for the "ignore_record_details_in_response" field.</summary>
    public const int IgnoreRecordDetailsInResponseFieldNumber = 6;
    private bool ignoreRecordDetailsInResponse_;
    /// <summary>
    /// If true, the response will contain only record ID and score. By default, it
    /// is false, the response will contain record details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IgnoreRecordDetailsInResponse {
      get { return ignoreRecordDetailsInResponse_; }
      set {
        ignoreRecordDetailsInResponse_ = value;
      }
    }

    /// <summary>Field number for the "user_labels" field.</summary>
    public const int UserLabelsFieldNumber = 7;
    private static readonly pbc::MapField<string, string>.Codec _map_userLabels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 58);
    private readonly pbc::MapField<string, string> userLabels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// The user labels applied to a resource must meet the following requirements:
    ///
    /// * Each resource can have multiple labels, up to a maximum of 64.
    /// * Each label must be a key-value pair.
    /// * Keys have a minimum length of 1 character and a maximum length of 63
    ///   characters and cannot be empty. Values can be empty and have a maximum
    ///   length of 63 characters.
    /// * Keys and values can contain only lowercase letters, numeric characters,
    ///   underscores, and dashes. All characters must use UTF-8 encoding, and
    ///   international characters are allowed.
    /// * The key portion of a label must be unique. However, you can use the same
    ///   key with multiple resources.
    /// * Keys must start with a lowercase letter or international character.
    ///
    /// See [Google Cloud
    /// Document](https://cloud.google.com/resource-manager/docs/creating-managing-labels#requirements)
    /// for more details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, string> UserLabels {
      get { return userLabels_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RankRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RankRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RankingConfig != other.RankingConfig) return false;
      if (Model != other.Model) return false;
      if (TopN != other.TopN) return false;
      if (Query != other.Query) return false;
      if(!records_.Equals(other.records_)) return false;
      if (IgnoreRecordDetailsInResponse != other.IgnoreRecordDetailsInResponse) return false;
      if (!UserLabels.Equals(other.UserLabels)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RankingConfig.Length != 0) hash ^= RankingConfig.GetHashCode();
      if (Model.Length != 0) hash ^= Model.GetHashCode();
      if (TopN != 0) hash ^= TopN.GetHashCode();
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      hash ^= records_.GetHashCode();
      if (IgnoreRecordDetailsInResponse != false) hash ^= IgnoreRecordDetailsInResponse.GetHashCode();
      hash ^= UserLabels.GetHashCode();
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
      if (RankingConfig.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RankingConfig);
      }
      if (Model.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Model);
      }
      if (TopN != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TopN);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Query);
      }
      records_.WriteTo(output, _repeated_records_codec);
      if (IgnoreRecordDetailsInResponse != false) {
        output.WriteRawTag(48);
        output.WriteBool(IgnoreRecordDetailsInResponse);
      }
      userLabels_.WriteTo(output, _map_userLabels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (RankingConfig.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RankingConfig);
      }
      if (Model.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Model);
      }
      if (TopN != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TopN);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Query);
      }
      records_.WriteTo(ref output, _repeated_records_codec);
      if (IgnoreRecordDetailsInResponse != false) {
        output.WriteRawTag(48);
        output.WriteBool(IgnoreRecordDetailsInResponse);
      }
      userLabels_.WriteTo(ref output, _map_userLabels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (RankingConfig.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RankingConfig);
      }
      if (Model.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Model);
      }
      if (TopN != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TopN);
      }
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      size += records_.CalculateSize(_repeated_records_codec);
      if (IgnoreRecordDetailsInResponse != false) {
        size += 1 + 1;
      }
      size += userLabels_.CalculateSize(_map_userLabels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RankRequest other) {
      if (other == null) {
        return;
      }
      if (other.RankingConfig.Length != 0) {
        RankingConfig = other.RankingConfig;
      }
      if (other.Model.Length != 0) {
        Model = other.Model;
      }
      if (other.TopN != 0) {
        TopN = other.TopN;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
      records_.Add(other.records_);
      if (other.IgnoreRecordDetailsInResponse != false) {
        IgnoreRecordDetailsInResponse = other.IgnoreRecordDetailsInResponse;
      }
      userLabels_.MergeFrom(other.userLabels_);
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
            RankingConfig = input.ReadString();
            break;
          }
          case 18: {
            Model = input.ReadString();
            break;
          }
          case 24: {
            TopN = input.ReadInt32();
            break;
          }
          case 34: {
            Query = input.ReadString();
            break;
          }
          case 42: {
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
          case 48: {
            IgnoreRecordDetailsInResponse = input.ReadBool();
            break;
          }
          case 58: {
            userLabels_.AddEntriesFrom(input, _map_userLabels_codec);
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
            RankingConfig = input.ReadString();
            break;
          }
          case 18: {
            Model = input.ReadString();
            break;
          }
          case 24: {
            TopN = input.ReadInt32();
            break;
          }
          case 34: {
            Query = input.ReadString();
            break;
          }
          case 42: {
            records_.AddEntriesFrom(ref input, _repeated_records_codec);
            break;
          }
          case 48: {
            IgnoreRecordDetailsInResponse = input.ReadBool();
            break;
          }
          case 58: {
            userLabels_.AddEntriesFrom(ref input, _map_userLabels_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for
  /// [RankService.Rank][google.cloud.discoveryengine.v1.RankService.Rank] method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RankResponse : pb::IMessage<RankResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RankResponse> _parser = new pb::MessageParser<RankResponse>(() => new RankResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RankResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1.RankServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankResponse(RankResponse other) : this() {
      records_ = other.records_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RankResponse Clone() {
      return new RankResponse(this);
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord> _repeated_records_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.DiscoveryEngine.V1.RankingRecord.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord> records_ = new pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord>();
    /// <summary>
    /// A list of records sorted by descending score.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.RankingRecord> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RankResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RankResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!records_.Equals(other.records_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= records_.GetHashCode();
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
      records_.WriteTo(output, _repeated_records_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      records_.WriteTo(ref output, _repeated_records_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += records_.CalculateSize(_repeated_records_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RankResponse other) {
      if (other == null) {
        return;
      }
      records_.Add(other.records_);
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
          case 42: {
            records_.AddEntriesFrom(input, _repeated_records_codec);
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
          case 42: {
            records_.AddEntriesFrom(ref input, _repeated_records_codec);
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
