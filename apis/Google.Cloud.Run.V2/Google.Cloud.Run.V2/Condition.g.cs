// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/run/v2/condition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Run.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/run/v2/condition.proto</summary>
  public static partial class ConditionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/run/v2/condition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNnb29nbGUvY2xvdWQvcnVuL3YyL2NvbmRpdGlvbi5wcm90bxITZ29vZ2xl",
            "LmNsb3VkLnJ1bi52MhofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byLHDAoJQ29uZGl0",
            "aW9uEgwKBHR5cGUYASABKAkSMwoFc3RhdGUYAiABKA4yJC5nb29nbGUuY2xv",
            "dWQucnVuLnYyLkNvbmRpdGlvbi5TdGF0ZRIPCgdtZXNzYWdlGAMgASgJEjgK",
            "FGxhc3RfdHJhbnNpdGlvbl90aW1lGAQgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBI5CghzZXZlcml0eRgFIAEoDjInLmdvb2dsZS5jbG91ZC5y",
            "dW4udjIuQ29uZGl0aW9uLlNldmVyaXR5EkIKBnJlYXNvbhgGIAEoDjIrLmdv",
            "b2dsZS5jbG91ZC5ydW4udjIuQ29uZGl0aW9uLkNvbW1vblJlYXNvbkID4EED",
            "SAASTQoPcmV2aXNpb25fcmVhc29uGAkgASgOMi0uZ29vZ2xlLmNsb3VkLnJ1",
            "bi52Mi5Db25kaXRpb24uUmV2aXNpb25SZWFzb25CA+BBA0gAEk8KEGV4ZWN1",
            "dGlvbl9yZWFzb24YCyABKA4yLi5nb29nbGUuY2xvdWQucnVuLnYyLkNvbmRp",
            "dGlvbi5FeGVjdXRpb25SZWFzb25CA+BBA0gAIn8KBVN0YXRlEhUKEVNUQVRF",
            "X1VOU1BFQ0lGSUVEEAASFQoRQ09ORElUSU9OX1BFTkRJTkcQARIZChVDT05E",
            "SVRJT05fUkVDT05DSUxJTkcQAhIUChBDT05ESVRJT05fRkFJTEVEEAMSFwoT",
            "Q09ORElUSU9OX1NVQ0NFRURFRBAEIkYKCFNldmVyaXR5EhgKFFNFVkVSSVRZ",
            "X1VOU1BFQ0lGSUVEEAASCQoFRVJST1IQARILCgdXQVJOSU5HEAISCAoESU5G",
            "TxADIs0DCgxDb21tb25SZWFzb24SGwoXQ09NTU9OX1JFQVNPTl9VTkRFRklO",
            "RUQQABILCgdVTktOT1dOEAESEwoPUkVWSVNJT05fRkFJTEVEEAMSHgoaUFJP",
            "R1JFU1NfREVBRExJTkVfRVhDRUVERUQQBBIVChFDT05UQUlORVJfTUlTU0lO",
            "RxAGEh8KG0NPTlRBSU5FUl9QRVJNSVNTSU9OX0RFTklFRBAHEiAKHENPTlRB",
            "SU5FUl9JTUFHRV9VTkFVVEhPUklaRUQQCBIuCipDT05UQUlORVJfSU1BR0Vf",
            "QVVUSE9SSVpBVElPTl9DSEVDS19GQUlMRUQQCRIkCiBFTkNSWVBUSU9OX0tF",
            "WV9QRVJNSVNTSU9OX0RFTklFRBAKEh8KG0VOQ1JZUFRJT05fS0VZX0NIRUNL",
            "X0ZBSUxFRBALEh8KG1NFQ1JFVFNfQUNDRVNTX0NIRUNLX0ZBSUxFRBAMEhkK",
            "FVdBSVRJTkdfRk9SX09QRVJBVElPThANEhMKD0lNTUVESUFURV9SRVRSWRAO",
            "EhMKD1BPU1RQT05FRF9SRVRSWRAPEgwKCElOVEVSTkFMEBASGQoVVlBDX05F",
            "VFdPUktfTk9UX0ZPVU5EEBEiygIKDlJldmlzaW9uUmVhc29uEh0KGVJFVklT",
            "SU9OX1JFQVNPTl9VTkRFRklORUQQABILCgdQRU5ESU5HEAESCwoHUkVTRVJW",
            "RRACEgsKB1JFVElSRUQQAxIMCghSRVRJUklORxAEEg4KClJFQ1JFQVRJTkcQ",
            "BRIgChxIRUFMVEhfQ0hFQ0tfQ09OVEFJTkVSX0VSUk9SEAYSJAogQ1VTVE9N",
            "SVpFRF9QQVRIX1JFU1BPTlNFX1BFTkRJTkcQBxIhCh1NSU5fSU5TVEFOQ0VT",
            "X05PVF9QUk9WSVNJT05FRBAIEiEKHUFDVElWRV9SRVZJU0lPTl9MSU1JVF9S",
            "RUFDSEVEEAkSEQoNTk9fREVQTE9ZTUVOVBAKEhgKFEhFQUxUSF9DSEVDS19T",
            "S0lQUEVEEAsSGQoVTUlOX0lOU1RBTkNFU19XQVJNSU5HEAwimwEKD0V4ZWN1",
            "dGlvblJlYXNvbhIeChpFWEVDVVRJT05fUkVBU09OX1VOREVGSU5FRBAAEiQK",
            "IEpPQl9TVEFUVVNfU0VSVklDRV9QT0xMSU5HX0VSUk9SEAESFgoSTk9OX1pF",
            "Uk9fRVhJVF9DT0RFEAISDQoJQ0FOQ0VMTEVEEAMSDgoKQ0FOQ0VMTElORxAE",
            "EgsKB0RFTEVURUQQBUIJCgdyZWFzb25zQlYKF2NvbS5nb29nbGUuY2xvdWQu",
            "cnVuLnYyQg5Db25kaXRpb25Qcm90b1ABWiljbG91ZC5nb29nbGUuY29tL2dv",
            "L3J1bi9hcGl2Mi9ydW5wYjtydW5wYmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Run.V2.Condition), global::Google.Cloud.Run.V2.Condition.Parser, new[]{ "Type", "State", "Message", "LastTransitionTime", "Severity", "Reason", "RevisionReason", "ExecutionReason" }, new[]{ "Reasons" }, new[]{ typeof(global::Google.Cloud.Run.V2.Condition.Types.State), typeof(global::Google.Cloud.Run.V2.Condition.Types.Severity), typeof(global::Google.Cloud.Run.V2.Condition.Types.CommonReason), typeof(global::Google.Cloud.Run.V2.Condition.Types.RevisionReason), typeof(global::Google.Cloud.Run.V2.Condition.Types.ExecutionReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines a status condition for a resource.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Condition : pb::IMessage<Condition>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Condition> _parser = new pb::MessageParser<Condition>(() => new Condition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Condition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Run.V2.ConditionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Condition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Condition(Condition other) : this() {
      type_ = other.type_;
      state_ = other.state_;
      message_ = other.message_;
      lastTransitionTime_ = other.lastTransitionTime_ != null ? other.lastTransitionTime_.Clone() : null;
      severity_ = other.severity_;
      switch (other.ReasonsCase) {
        case ReasonsOneofCase.Reason:
          Reason = other.Reason;
          break;
        case ReasonsOneofCase.RevisionReason:
          RevisionReason = other.RevisionReason;
          break;
        case ReasonsOneofCase.ExecutionReason:
          ExecutionReason = other.ExecutionReason;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Condition Clone() {
      return new Condition(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private string type_ = "";
    /// <summary>
    /// type is used to communicate the status of the reconciliation process.
    /// See also:
    /// https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting
    /// Types common to all resources include:
    /// * "Ready": True when the Resource is ready.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::Google.Cloud.Run.V2.Condition.Types.State state_ = global::Google.Cloud.Run.V2.Condition.Types.State.Unspecified;
    /// <summary>
    /// State of the condition.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.Condition.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 3;
    private string message_ = "";
    /// <summary>
    /// Human readable message indicating details about the current status.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_transition_time" field.</summary>
    public const int LastTransitionTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastTransitionTime_;
    /// <summary>
    /// Last time the condition transitioned from one status to another.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastTransitionTime {
      get { return lastTransitionTime_; }
      set {
        lastTransitionTime_ = value;
      }
    }

    /// <summary>Field number for the "severity" field.</summary>
    public const int SeverityFieldNumber = 5;
    private global::Google.Cloud.Run.V2.Condition.Types.Severity severity_ = global::Google.Cloud.Run.V2.Condition.Types.Severity.Unspecified;
    /// <summary>
    /// How to interpret failures of this condition, one of Error, Warning, Info
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.Condition.Types.Severity Severity {
      get { return severity_; }
      set {
        severity_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 6;
    /// <summary>
    /// Output only. A common (service-level) reason for this condition.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.Condition.Types.CommonReason Reason {
      get { return HasReason ? (global::Google.Cloud.Run.V2.Condition.Types.CommonReason) reasons_ : global::Google.Cloud.Run.V2.Condition.Types.CommonReason.Undefined; }
      set {
        reasons_ = value;
        reasonsCase_ = ReasonsOneofCase.Reason;
      }
    }
    /// <summary>Gets whether the "reason" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasReason {
      get { return reasonsCase_ == ReasonsOneofCase.Reason; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "reason" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearReason() {
      if (HasReason) {
        ClearReasons();
      }
    }

    /// <summary>Field number for the "revision_reason" field.</summary>
    public const int RevisionReasonFieldNumber = 9;
    /// <summary>
    /// Output only. A reason for the revision condition.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.Condition.Types.RevisionReason RevisionReason {
      get { return HasRevisionReason ? (global::Google.Cloud.Run.V2.Condition.Types.RevisionReason) reasons_ : global::Google.Cloud.Run.V2.Condition.Types.RevisionReason.Undefined; }
      set {
        reasons_ = value;
        reasonsCase_ = ReasonsOneofCase.RevisionReason;
      }
    }
    /// <summary>Gets whether the "revision_reason" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRevisionReason {
      get { return reasonsCase_ == ReasonsOneofCase.RevisionReason; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "revision_reason" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRevisionReason() {
      if (HasRevisionReason) {
        ClearReasons();
      }
    }

    /// <summary>Field number for the "execution_reason" field.</summary>
    public const int ExecutionReasonFieldNumber = 11;
    /// <summary>
    /// Output only. A reason for the execution condition.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Run.V2.Condition.Types.ExecutionReason ExecutionReason {
      get { return HasExecutionReason ? (global::Google.Cloud.Run.V2.Condition.Types.ExecutionReason) reasons_ : global::Google.Cloud.Run.V2.Condition.Types.ExecutionReason.Undefined; }
      set {
        reasons_ = value;
        reasonsCase_ = ReasonsOneofCase.ExecutionReason;
      }
    }
    /// <summary>Gets whether the "execution_reason" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasExecutionReason {
      get { return reasonsCase_ == ReasonsOneofCase.ExecutionReason; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "execution_reason" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearExecutionReason() {
      if (HasExecutionReason) {
        ClearReasons();
      }
    }

    private object reasons_;
    /// <summary>Enum of possible cases for the "reasons" oneof.</summary>
    public enum ReasonsOneofCase {
      None = 0,
      Reason = 6,
      RevisionReason = 9,
      ExecutionReason = 11,
    }
    private ReasonsOneofCase reasonsCase_ = ReasonsOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReasonsOneofCase ReasonsCase {
      get { return reasonsCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearReasons() {
      reasonsCase_ = ReasonsOneofCase.None;
      reasons_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Condition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Condition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (State != other.State) return false;
      if (Message != other.Message) return false;
      if (!object.Equals(LastTransitionTime, other.LastTransitionTime)) return false;
      if (Severity != other.Severity) return false;
      if (Reason != other.Reason) return false;
      if (RevisionReason != other.RevisionReason) return false;
      if (ExecutionReason != other.ExecutionReason) return false;
      if (ReasonsCase != other.ReasonsCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type.Length != 0) hash ^= Type.GetHashCode();
      if (State != global::Google.Cloud.Run.V2.Condition.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (lastTransitionTime_ != null) hash ^= LastTransitionTime.GetHashCode();
      if (Severity != global::Google.Cloud.Run.V2.Condition.Types.Severity.Unspecified) hash ^= Severity.GetHashCode();
      if (HasReason) hash ^= Reason.GetHashCode();
      if (HasRevisionReason) hash ^= RevisionReason.GetHashCode();
      if (HasExecutionReason) hash ^= ExecutionReason.GetHashCode();
      hash ^= (int) reasonsCase_;
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (State != global::Google.Cloud.Run.V2.Condition.Types.State.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (lastTransitionTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LastTransitionTime);
      }
      if (Severity != global::Google.Cloud.Run.V2.Condition.Types.Severity.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Severity);
      }
      if (HasReason) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Reason);
      }
      if (HasRevisionReason) {
        output.WriteRawTag(72);
        output.WriteEnum((int) RevisionReason);
      }
      if (HasExecutionReason) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ExecutionReason);
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
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (State != global::Google.Cloud.Run.V2.Condition.Types.State.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Message);
      }
      if (lastTransitionTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LastTransitionTime);
      }
      if (Severity != global::Google.Cloud.Run.V2.Condition.Types.Severity.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Severity);
      }
      if (HasReason) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Reason);
      }
      if (HasRevisionReason) {
        output.WriteRawTag(72);
        output.WriteEnum((int) RevisionReason);
      }
      if (HasExecutionReason) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ExecutionReason);
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
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (State != global::Google.Cloud.Run.V2.Condition.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (lastTransitionTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastTransitionTime);
      }
      if (Severity != global::Google.Cloud.Run.V2.Condition.Types.Severity.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Severity);
      }
      if (HasReason) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (HasRevisionReason) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RevisionReason);
      }
      if (HasExecutionReason) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExecutionReason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Condition other) {
      if (other == null) {
        return;
      }
      if (other.Type.Length != 0) {
        Type = other.Type;
      }
      if (other.State != global::Google.Cloud.Run.V2.Condition.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.lastTransitionTime_ != null) {
        if (lastTransitionTime_ == null) {
          LastTransitionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastTransitionTime.MergeFrom(other.LastTransitionTime);
      }
      if (other.Severity != global::Google.Cloud.Run.V2.Condition.Types.Severity.Unspecified) {
        Severity = other.Severity;
      }
      switch (other.ReasonsCase) {
        case ReasonsOneofCase.Reason:
          Reason = other.Reason;
          break;
        case ReasonsOneofCase.RevisionReason:
          RevisionReason = other.RevisionReason;
          break;
        case ReasonsOneofCase.ExecutionReason:
          ExecutionReason = other.ExecutionReason;
          break;
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
            Type = input.ReadString();
            break;
          }
          case 16: {
            State = (global::Google.Cloud.Run.V2.Condition.Types.State) input.ReadEnum();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 34: {
            if (lastTransitionTime_ == null) {
              LastTransitionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastTransitionTime);
            break;
          }
          case 40: {
            Severity = (global::Google.Cloud.Run.V2.Condition.Types.Severity) input.ReadEnum();
            break;
          }
          case 48: {
            reasons_ = input.ReadEnum();
            reasonsCase_ = ReasonsOneofCase.Reason;
            break;
          }
          case 72: {
            reasons_ = input.ReadEnum();
            reasonsCase_ = ReasonsOneofCase.RevisionReason;
            break;
          }
          case 88: {
            reasons_ = input.ReadEnum();
            reasonsCase_ = ReasonsOneofCase.ExecutionReason;
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
            Type = input.ReadString();
            break;
          }
          case 16: {
            State = (global::Google.Cloud.Run.V2.Condition.Types.State) input.ReadEnum();
            break;
          }
          case 26: {
            Message = input.ReadString();
            break;
          }
          case 34: {
            if (lastTransitionTime_ == null) {
              LastTransitionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastTransitionTime);
            break;
          }
          case 40: {
            Severity = (global::Google.Cloud.Run.V2.Condition.Types.Severity) input.ReadEnum();
            break;
          }
          case 48: {
            reasons_ = input.ReadEnum();
            reasonsCase_ = ReasonsOneofCase.Reason;
            break;
          }
          case 72: {
            reasons_ = input.ReadEnum();
            reasonsCase_ = ReasonsOneofCase.RevisionReason;
            break;
          }
          case 88: {
            reasons_ = input.ReadEnum();
            reasonsCase_ = ReasonsOneofCase.ExecutionReason;
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Condition message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Represents the possible Condition states.
      /// </summary>
      public enum State {
        /// <summary>
        /// The default value. This value is used if the state is omitted.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Transient state: Reconciliation has not started yet.
        /// </summary>
        [pbr::OriginalName("CONDITION_PENDING")] ConditionPending = 1,
        /// <summary>
        /// Transient state: reconciliation is still in progress.
        /// </summary>
        [pbr::OriginalName("CONDITION_RECONCILING")] ConditionReconciling = 2,
        /// <summary>
        /// Terminal state: Reconciliation did not succeed.
        /// </summary>
        [pbr::OriginalName("CONDITION_FAILED")] ConditionFailed = 3,
        /// <summary>
        /// Terminal state: Reconciliation completed successfully.
        /// </summary>
        [pbr::OriginalName("CONDITION_SUCCEEDED")] ConditionSucceeded = 4,
      }

      /// <summary>
      /// Represents the severity of the condition failures.
      /// </summary>
      public enum Severity {
        /// <summary>
        /// Unspecified severity
        /// </summary>
        [pbr::OriginalName("SEVERITY_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Error severity.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 1,
        /// <summary>
        /// Warning severity.
        /// </summary>
        [pbr::OriginalName("WARNING")] Warning = 2,
        /// <summary>
        /// Info severity.
        /// </summary>
        [pbr::OriginalName("INFO")] Info = 3,
      }

      /// <summary>
      /// Reasons common to all types of conditions.
      /// </summary>
      public enum CommonReason {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("COMMON_REASON_UNDEFINED")] Undefined = 0,
        /// <summary>
        /// Reason unknown. Further details will be in message.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Revision creation process failed.
        /// </summary>
        [pbr::OriginalName("REVISION_FAILED")] RevisionFailed = 3,
        /// <summary>
        /// Timed out waiting for completion.
        /// </summary>
        [pbr::OriginalName("PROGRESS_DEADLINE_EXCEEDED")] ProgressDeadlineExceeded = 4,
        /// <summary>
        /// The container image path is incorrect.
        /// </summary>
        [pbr::OriginalName("CONTAINER_MISSING")] ContainerMissing = 6,
        /// <summary>
        /// Insufficient permissions on the container image.
        /// </summary>
        [pbr::OriginalName("CONTAINER_PERMISSION_DENIED")] ContainerPermissionDenied = 7,
        /// <summary>
        /// Container image is not authorized by policy.
        /// </summary>
        [pbr::OriginalName("CONTAINER_IMAGE_UNAUTHORIZED")] ContainerImageUnauthorized = 8,
        /// <summary>
        /// Container image policy authorization check failed.
        /// </summary>
        [pbr::OriginalName("CONTAINER_IMAGE_AUTHORIZATION_CHECK_FAILED")] ContainerImageAuthorizationCheckFailed = 9,
        /// <summary>
        /// Insufficient permissions on encryption key.
        /// </summary>
        [pbr::OriginalName("ENCRYPTION_KEY_PERMISSION_DENIED")] EncryptionKeyPermissionDenied = 10,
        /// <summary>
        /// Permission check on encryption key failed.
        /// </summary>
        [pbr::OriginalName("ENCRYPTION_KEY_CHECK_FAILED")] EncryptionKeyCheckFailed = 11,
        /// <summary>
        /// At least one Access check on secrets failed.
        /// </summary>
        [pbr::OriginalName("SECRETS_ACCESS_CHECK_FAILED")] SecretsAccessCheckFailed = 12,
        /// <summary>
        /// Waiting for operation to complete.
        /// </summary>
        [pbr::OriginalName("WAITING_FOR_OPERATION")] WaitingForOperation = 13,
        /// <summary>
        /// System will retry immediately.
        /// </summary>
        [pbr::OriginalName("IMMEDIATE_RETRY")] ImmediateRetry = 14,
        /// <summary>
        /// System will retry later; current attempt failed.
        /// </summary>
        [pbr::OriginalName("POSTPONED_RETRY")] PostponedRetry = 15,
        /// <summary>
        /// An internal error occurred. Further information may be in the message.
        /// </summary>
        [pbr::OriginalName("INTERNAL")] Internal = 16,
        /// <summary>
        /// User-provided VPC network was not found.
        /// </summary>
        [pbr::OriginalName("VPC_NETWORK_NOT_FOUND")] VpcNetworkNotFound = 17,
      }

      /// <summary>
      /// Reasons specific to Revision resource.
      /// </summary>
      public enum RevisionReason {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("REVISION_REASON_UNDEFINED")] Undefined = 0,
        /// <summary>
        /// Revision in Pending state.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 1,
        /// <summary>
        /// Revision is in Reserve state.
        /// </summary>
        [pbr::OriginalName("RESERVE")] Reserve = 2,
        /// <summary>
        /// Revision is Retired.
        /// </summary>
        [pbr::OriginalName("RETIRED")] Retired = 3,
        /// <summary>
        /// Revision is being retired.
        /// </summary>
        [pbr::OriginalName("RETIRING")] Retiring = 4,
        /// <summary>
        /// Revision is being recreated.
        /// </summary>
        [pbr::OriginalName("RECREATING")] Recreating = 5,
        /// <summary>
        /// There was a health check error.
        /// </summary>
        [pbr::OriginalName("HEALTH_CHECK_CONTAINER_ERROR")] HealthCheckContainerError = 6,
        /// <summary>
        /// Health check failed due to user error from customized path of the
        /// container. System will retry.
        /// </summary>
        [pbr::OriginalName("CUSTOMIZED_PATH_RESPONSE_PENDING")] CustomizedPathResponsePending = 7,
        /// <summary>
        /// A revision with min_instance_count > 0 was created and is reserved, but
        /// it was not configured to serve traffic, so it's not live. This can also
        /// happen momentarily during traffic migration.
        /// </summary>
        [pbr::OriginalName("MIN_INSTANCES_NOT_PROVISIONED")] MinInstancesNotProvisioned = 8,
        /// <summary>
        /// The maximum allowed number of active revisions has been reached.
        /// </summary>
        [pbr::OriginalName("ACTIVE_REVISION_LIMIT_REACHED")] ActiveRevisionLimitReached = 9,
        /// <summary>
        /// There was no deployment defined.
        /// This value is no longer used, but Services created in older versions of
        /// the API might contain this value.
        /// </summary>
        [pbr::OriginalName("NO_DEPLOYMENT")] NoDeployment = 10,
        /// <summary>
        /// A revision's container has no port specified since the revision is of a
        /// manually scaled service with 0 instance count
        /// </summary>
        [pbr::OriginalName("HEALTH_CHECK_SKIPPED")] HealthCheckSkipped = 11,
        /// <summary>
        /// A revision with min_instance_count > 0 was created and is waiting for
        /// enough instances to begin a traffic migration.
        /// </summary>
        [pbr::OriginalName("MIN_INSTANCES_WARMING")] MinInstancesWarming = 12,
      }

      /// <summary>
      /// Reasons specific to Execution resource.
      /// </summary>
      public enum ExecutionReason {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("EXECUTION_REASON_UNDEFINED")] Undefined = 0,
        /// <summary>
        /// Internal system error getting execution status. System will retry.
        /// </summary>
        [pbr::OriginalName("JOB_STATUS_SERVICE_POLLING_ERROR")] JobStatusServicePollingError = 1,
        /// <summary>
        /// A task reached its retry limit and the last attempt failed due to the
        /// user container exiting with a non-zero exit code.
        /// </summary>
        [pbr::OriginalName("NON_ZERO_EXIT_CODE")] NonZeroExitCode = 2,
        /// <summary>
        /// The execution was cancelled by users.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 3,
        /// <summary>
        /// The execution is in the process of being cancelled.
        /// </summary>
        [pbr::OriginalName("CANCELLING")] Cancelling = 4,
        /// <summary>
        /// The execution was deleted.
        /// </summary>
        [pbr::OriginalName("DELETED")] Deleted = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
