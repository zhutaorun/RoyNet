
//------------------------------------------------------------------------------
// 
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//------------------------------------------------------------------------------

// Generated from: Sys.proto
namespace RoyNet.Server.Gate.Entity
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"G2G_ToGameConnect")]
    public partial class G2G_ToGameConnect : global::ProtoBuf.IExtensible
    {
      public G2G_ToGameConnect() {}
      
    private string _UserName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"UserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName
    {
      get { return _UserName; }
      set { _UserName = value; }
    }

    private string _IPAddress = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IPAddress", DataFormat = global::ProtoBuf.DataFormat.Default)][global::System.ComponentModel.DefaultValue("")]
    public string IPAddress
    {
      get { return _IPAddress; }
      set { _IPAddress = value; }
    }

    private int _Port = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)][global::System.ComponentModel.DefaultValue(default(int))]
    public int Port
    {
      get { return _Port; }
      set { _Port = value; }
    }

    private string _MAC = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MAC", DataFormat = global::ProtoBuf.DataFormat.Default)][global::System.ComponentModel.DefaultValue("")]
    public string MAC
    {
      get { return _MAC; }
      set { _MAC = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"G2G_ToGameDisconnect")]
    public partial class G2G_ToGameDisconnect : global::ProtoBuf.IExtensible
    {
      public G2G_ToGameDisconnect() {}
      

    private string _Reason = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.Default)][global::System.ComponentModel.DefaultValue("")]
    public string Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"G2G_ToGateLeave")]
    public partial class G2G_ToGateLeave : global::ProtoBuf.IExtensible
    {
      public G2G_ToGateLeave() {}
      
    private LeaveReason _Reason;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public LeaveReason Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    public enum CMD_G2G
    {
      ToGameConnect = 1,
    ToGameDisconnect = 2,
    ToGateLeave = 3
    }
  
    public enum LeaveReason
    {
      Normal = 0,
    Fatal = 1,
    Cheat = 2,
    Displace = 3,
    KickOff = 4
    }
  
}