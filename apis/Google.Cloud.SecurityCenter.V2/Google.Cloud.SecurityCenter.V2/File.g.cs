// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v2/file.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v2/file.proto</summary>
  public static partial class FileReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v2/file.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FileReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvZmlsZS5wcm90bxIe",
            "Z29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyIoMECgRGaWxlEgwKBHBh",
            "dGgYASABKAkSDAoEc2l6ZRgCIAEoAxIOCgZzaGEyNTYYAyABKAkSEwoLaGFz",
            "aGVkX3NpemUYBCABKAMSGAoQcGFydGlhbGx5X2hhc2hlZBgFIAEoCBIQCghj",
            "b250ZW50cxgGIAEoCRJACglkaXNrX3BhdGgYByABKAsyLS5nb29nbGUuY2xv",
            "dWQuc2VjdXJpdHljZW50ZXIudjIuRmlsZS5EaXNrUGF0aBJGCgpvcGVyYXRp",
            "b25zGAggAygLMjIuZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyLkZp",
            "bGUuRmlsZU9wZXJhdGlvbho5CghEaXNrUGF0aBIWCg5wYXJ0aXRpb25fdXVp",
            "ZBgBIAEoCRIVCg1yZWxhdGl2ZV9wYXRoGAIgASgJGsgBCg1GaWxlT3BlcmF0",
            "aW9uEk4KBHR5cGUYASABKA4yQC5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50",
            "ZXIudjIuRmlsZS5GaWxlT3BlcmF0aW9uLk9wZXJhdGlvblR5cGUiZwoNT3Bl",
            "cmF0aW9uVHlwZRIeChpPUEVSQVRJT05fVFlQRV9VTlNQRUNJRklFRBAAEggK",
            "BE9QRU4QARIICgRSRUFEEAISCgoGUkVOQU1FEAMSCQoFV1JJVEUQBBILCgdF",
            "WEVDVVRFEAVC4wEKImNvbS5nb29nbGUuY2xvdWQuc2VjdXJpdHljZW50ZXIu",
            "djJCCUZpbGVQcm90b1ABWkpjbG91ZC5nb29nbGUuY29tL2dvL3NlY3VyaXR5",
            "Y2VudGVyL2FwaXYyL3NlY3VyaXR5Y2VudGVycGI7c2VjdXJpdHljZW50ZXJw",
            "YqoCHkdvb2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5WMsoCHkdvb2dsZVxD",
            "bG91ZFxTZWN1cml0eUNlbnRlclxWMuoCIUdvb2dsZTo6Q2xvdWQ6OlNlY3Vy",
            "aXR5Q2VudGVyOjpWMmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.File), global::Google.Cloud.SecurityCenter.V2.File.Parser, new[]{ "Path", "Size", "Sha256", "HashedSize", "PartiallyHashed", "Contents", "DiskPath", "Operations" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath), global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath.Parser, new[]{ "PartitionUuid", "RelativePath" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation), global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Parser, new[]{ "Type" }, null, new[]{ typeof(global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType) }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// File information about the related binary/library used by an executable, or
  /// the script used by a script interpreter
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class File : pb::IMessage<File>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<File> _parser = new pb::MessageParser<File>(() => new File());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<File> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V2.FileReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public File() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public File(File other) : this() {
      path_ = other.path_;
      size_ = other.size_;
      sha256_ = other.sha256_;
      hashedSize_ = other.hashedSize_;
      partiallyHashed_ = other.partiallyHashed_;
      contents_ = other.contents_;
      diskPath_ = other.diskPath_ != null ? other.diskPath_.Clone() : null;
      operations_ = other.operations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public File Clone() {
      return new File(this);
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 1;
    private string path_ = "";
    /// <summary>
    /// Absolute path of the file as a JSON encoded string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 2;
    private long size_;
    /// <summary>
    /// Size of the file in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "sha256" field.</summary>
    public const int Sha256FieldNumber = 3;
    private string sha256_ = "";
    /// <summary>
    /// SHA256 hash of the first hashed_size bytes of the file encoded as a
    /// hex string.  If hashed_size == size, sha256 represents the SHA256 hash
    /// of the entire file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Sha256 {
      get { return sha256_; }
      set {
        sha256_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hashed_size" field.</summary>
    public const int HashedSizeFieldNumber = 4;
    private long hashedSize_;
    /// <summary>
    /// The length in bytes of the file prefix that was hashed.  If
    /// hashed_size == size, any hashes reported represent the entire
    /// file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long HashedSize {
      get { return hashedSize_; }
      set {
        hashedSize_ = value;
      }
    }

    /// <summary>Field number for the "partially_hashed" field.</summary>
    public const int PartiallyHashedFieldNumber = 5;
    private bool partiallyHashed_;
    /// <summary>
    /// True when the hash covers only a prefix of the file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool PartiallyHashed {
      get { return partiallyHashed_; }
      set {
        partiallyHashed_ = value;
      }
    }

    /// <summary>Field number for the "contents" field.</summary>
    public const int ContentsFieldNumber = 6;
    private string contents_ = "";
    /// <summary>
    /// Prefix of the file contents as a JSON-encoded string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Contents {
      get { return contents_; }
      set {
        contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "disk_path" field.</summary>
    public const int DiskPathFieldNumber = 7;
    private global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath diskPath_;
    /// <summary>
    /// Path of the file in terms of underlying disk/partition identifiers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath DiskPath {
      get { return diskPath_; }
      set {
        diskPath_ = value;
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(66, global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation> operations_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation>();
    /// <summary>
    /// Operation(s) performed on a file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation> Operations {
      get { return operations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as File);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(File other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Path != other.Path) return false;
      if (Size != other.Size) return false;
      if (Sha256 != other.Sha256) return false;
      if (HashedSize != other.HashedSize) return false;
      if (PartiallyHashed != other.PartiallyHashed) return false;
      if (Contents != other.Contents) return false;
      if (!object.Equals(DiskPath, other.DiskPath)) return false;
      if(!operations_.Equals(other.operations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (Size != 0L) hash ^= Size.GetHashCode();
      if (Sha256.Length != 0) hash ^= Sha256.GetHashCode();
      if (HashedSize != 0L) hash ^= HashedSize.GetHashCode();
      if (PartiallyHashed != false) hash ^= PartiallyHashed.GetHashCode();
      if (Contents.Length != 0) hash ^= Contents.GetHashCode();
      if (diskPath_ != null) hash ^= DiskPath.GetHashCode();
      hash ^= operations_.GetHashCode();
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
      if (Path.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Path);
      }
      if (Size != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Size);
      }
      if (Sha256.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sha256);
      }
      if (HashedSize != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HashedSize);
      }
      if (PartiallyHashed != false) {
        output.WriteRawTag(40);
        output.WriteBool(PartiallyHashed);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Contents);
      }
      if (diskPath_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DiskPath);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Path.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Path);
      }
      if (Size != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Size);
      }
      if (Sha256.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Sha256);
      }
      if (HashedSize != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HashedSize);
      }
      if (PartiallyHashed != false) {
        output.WriteRawTag(40);
        output.WriteBool(PartiallyHashed);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Contents);
      }
      if (diskPath_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DiskPath);
      }
      operations_.WriteTo(ref output, _repeated_operations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (Size != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Size);
      }
      if (Sha256.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Sha256);
      }
      if (HashedSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HashedSize);
      }
      if (PartiallyHashed != false) {
        size += 1 + 1;
      }
      if (Contents.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Contents);
      }
      if (diskPath_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DiskPath);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(File other) {
      if (other == null) {
        return;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      if (other.Size != 0L) {
        Size = other.Size;
      }
      if (other.Sha256.Length != 0) {
        Sha256 = other.Sha256;
      }
      if (other.HashedSize != 0L) {
        HashedSize = other.HashedSize;
      }
      if (other.PartiallyHashed != false) {
        PartiallyHashed = other.PartiallyHashed;
      }
      if (other.Contents.Length != 0) {
        Contents = other.Contents;
      }
      if (other.diskPath_ != null) {
        if (diskPath_ == null) {
          DiskPath = new global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath();
        }
        DiskPath.MergeFrom(other.DiskPath);
      }
      operations_.Add(other.operations_);
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
            Path = input.ReadString();
            break;
          }
          case 16: {
            Size = input.ReadInt64();
            break;
          }
          case 26: {
            Sha256 = input.ReadString();
            break;
          }
          case 32: {
            HashedSize = input.ReadInt64();
            break;
          }
          case 40: {
            PartiallyHashed = input.ReadBool();
            break;
          }
          case 50: {
            Contents = input.ReadString();
            break;
          }
          case 58: {
            if (diskPath_ == null) {
              DiskPath = new global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath();
            }
            input.ReadMessage(DiskPath);
            break;
          }
          case 66: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
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
            Path = input.ReadString();
            break;
          }
          case 16: {
            Size = input.ReadInt64();
            break;
          }
          case 26: {
            Sha256 = input.ReadString();
            break;
          }
          case 32: {
            HashedSize = input.ReadInt64();
            break;
          }
          case 40: {
            PartiallyHashed = input.ReadBool();
            break;
          }
          case 50: {
            Contents = input.ReadString();
            break;
          }
          case 58: {
            if (diskPath_ == null) {
              DiskPath = new global::Google.Cloud.SecurityCenter.V2.File.Types.DiskPath();
            }
            input.ReadMessage(DiskPath);
            break;
          }
          case 66: {
            operations_.AddEntriesFrom(ref input, _repeated_operations_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the File message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Path of the file in terms of underlying disk/partition identifiers.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class DiskPath : pb::IMessage<DiskPath>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<DiskPath> _parser = new pb::MessageParser<DiskPath>(() => new DiskPath());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<DiskPath> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V2.File.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DiskPath() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DiskPath(DiskPath other) : this() {
          partitionUuid_ = other.partitionUuid_;
          relativePath_ = other.relativePath_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public DiskPath Clone() {
          return new DiskPath(this);
        }

        /// <summary>Field number for the "partition_uuid" field.</summary>
        public const int PartitionUuidFieldNumber = 1;
        private string partitionUuid_ = "";
        /// <summary>
        /// UUID of the partition (format
        /// https://wiki.archlinux.org/title/persistent_block_device_naming#by-uuid)
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string PartitionUuid {
          get { return partitionUuid_; }
          set {
            partitionUuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "relative_path" field.</summary>
        public const int RelativePathFieldNumber = 2;
        private string relativePath_ = "";
        /// <summary>
        /// Relative path of the file in the partition as a JSON encoded string.
        /// Example: /home/user1/executable_file.sh
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string RelativePath {
          get { return relativePath_; }
          set {
            relativePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as DiskPath);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(DiskPath other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (PartitionUuid != other.PartitionUuid) return false;
          if (RelativePath != other.RelativePath) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (PartitionUuid.Length != 0) hash ^= PartitionUuid.GetHashCode();
          if (RelativePath.Length != 0) hash ^= RelativePath.GetHashCode();
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
          if (PartitionUuid.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(PartitionUuid);
          }
          if (RelativePath.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(RelativePath);
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
          if (PartitionUuid.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(PartitionUuid);
          }
          if (RelativePath.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(RelativePath);
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
          if (PartitionUuid.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PartitionUuid);
          }
          if (RelativePath.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(RelativePath);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(DiskPath other) {
          if (other == null) {
            return;
          }
          if (other.PartitionUuid.Length != 0) {
            PartitionUuid = other.PartitionUuid;
          }
          if (other.RelativePath.Length != 0) {
            RelativePath = other.RelativePath;
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
                PartitionUuid = input.ReadString();
                break;
              }
              case 18: {
                RelativePath = input.ReadString();
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
                PartitionUuid = input.ReadString();
                break;
              }
              case 18: {
                RelativePath = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

      /// <summary>
      /// Operation(s) performed on a file.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class FileOperation : pb::IMessage<FileOperation>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<FileOperation> _parser = new pb::MessageParser<FileOperation>(() => new FileOperation());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<FileOperation> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V2.File.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FileOperation() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FileOperation(FileOperation other) : this() {
          type_ = other.type_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public FileOperation Clone() {
          return new FileOperation(this);
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 1;
        private global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType type_ = global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType.Unspecified;
        /// <summary>
        /// The type of the operation
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as FileOperation);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(FileOperation other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Type != other.Type) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Type != global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType.Unspecified) hash ^= Type.GetHashCode();
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
          if (Type != global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType.Unspecified) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Type);
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
          if (Type != global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType.Unspecified) {
            output.WriteRawTag(8);
            output.WriteEnum((int) Type);
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
          if (Type != global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType.Unspecified) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(FileOperation other) {
          if (other == null) {
            return;
          }
          if (other.Type != global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType.Unspecified) {
            Type = other.Type;
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
              case 8: {
                Type = (global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType) input.ReadEnum();
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
              case 8: {
                Type = (global::Google.Cloud.SecurityCenter.V2.File.Types.FileOperation.Types.OperationType) input.ReadEnum();
                break;
              }
            }
          }
        }
        #endif

        #region Nested types
        /// <summary>Container for nested types declared in the FileOperation message type.</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static partial class Types {
          /// <summary>
          /// The type of the operation
          /// </summary>
          public enum OperationType {
            /// <summary>
            /// The operation is unspecified.
            /// </summary>
            [pbr::OriginalName("OPERATION_TYPE_UNSPECIFIED")] Unspecified = 0,
            /// <summary>
            /// Represents an open operation.
            /// </summary>
            [pbr::OriginalName("OPEN")] Open = 1,
            /// <summary>
            /// Represents a read operation.
            /// </summary>
            [pbr::OriginalName("READ")] Read = 2,
            /// <summary>
            /// Represents a rename operation.
            /// </summary>
            [pbr::OriginalName("RENAME")] Rename = 3,
            /// <summary>
            /// Represents a write operation.
            /// </summary>
            [pbr::OriginalName("WRITE")] Write = 4,
            /// <summary>
            /// Represents an execute operation.
            /// </summary>
            [pbr::OriginalName("EXECUTE")] Execute = 5,
          }

        }
        #endregion

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
