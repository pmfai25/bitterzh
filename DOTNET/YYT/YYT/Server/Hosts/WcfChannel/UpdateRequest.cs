using System;
using System.Runtime.Serialization;

namespace YYT.Server.Hosts.WcfChannel
{
  /// <summary>
  /// Request message for updating
  /// a business object.
  /// </summary>
  [DataContract]
  public class UpdateRequest
  {
    [DataMember]
    private object _object;
    [DataMember]
    private YYT.Server.DataPortalContext _context;

    /// <summary>
    /// Create new instance of object.
    /// </summary>
    /// <param name="obj">Business object to update.</param>
    /// <param name="context">Data portal context from client.</param>
    public UpdateRequest(object obj, YYT.Server.DataPortalContext context)
    {
      _object = obj;
      _context = context;
    }

    /// <summary>
    /// Business object to be updated.
    /// </summary>
    public object Object
    {
      get { return _object; }
      set { _object = value; }
    }

    /// <summary>
    /// Data portal context from client.
    /// </summary>
    public YYT.Server.DataPortalContext Context
    {
      get { return _context; }
      set { _context = value; }
    }
  }
}