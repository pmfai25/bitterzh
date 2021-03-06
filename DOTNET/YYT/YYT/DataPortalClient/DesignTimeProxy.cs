﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YYT.Reflection;

namespace YYT.DataPortalClient
{
  /// <summary>
  /// Data portal proxy used when an object is to be created with
  /// design time data for Visual Studio or Expression Blend.
  /// </summary>
  public class DesignTimeProxy : DataPortalClient.IDataPortalProxy
  {

    #region IDataPortalProxy Members

    /// <summary>
    /// Gets a value indicating whether the data portal
    /// will run remotely. Always returns false.
    /// </summary>
    public bool IsServerRemote
    {
      get { return false; }
    }

    #endregion

    #region IDataPortalServer Members

    /// <summary>
    /// Called by <see cref="DataPortal" /> to create a
    /// new business object.
    /// </summary>
    /// <param name="objectType">Type of business object to create.</param>
    /// <param name="criteria">Criteria object describing business object.</param>
    /// <param name="context">
    /// <see cref="Server.DataPortalContext" /> object passed to the server.
    /// </param>
    public YYT.Server.DataPortalResult Create(Type objectType, object criteria, YYT.Server.DataPortalContext context)
    {
      return CreateDesignTimeObject(objectType, criteria, context);
    }

    /// <summary>
    /// Called by <see cref="DataPortal" /> to load an
    /// existing business object.
    /// </summary>
    /// <param name="objectType">Type of business object to retrieve.</param>
    /// <param name="criteria">Criteria object describing business object.</param>
    /// <param name="context">
    /// <see cref="Server.DataPortalContext" /> object passed to the server.
    /// </param>
    public YYT.Server.DataPortalResult Fetch(Type objectType, object criteria, YYT.Server.DataPortalContext context)
    {
      return CreateDesignTimeObject(objectType, criteria, context);
    }

    /// <summary>
    /// Called by <see cref="DataPortal" /> to update a
    /// business object.
    /// </summary>
    /// <param name="obj">The business object to update.</param>
    /// <param name="context">
    /// <see cref="Server.DataPortalContext" /> object passed to the server.
    /// </param>
    public YYT.Server.DataPortalResult Update(object obj, YYT.Server.DataPortalContext context)
    {
      return new YYT.Server.DataPortalResult(obj);
    }

    /// <summary>
    /// Called by <see cref="DataPortal" /> to delete a
    /// business object.
    /// </summary>
    /// <param name="objectType">Type of business object to create.</param>
    /// <param name="criteria">Criteria object describing business object.</param>
    /// <param name="context">
    /// <see cref="Server.DataPortalContext" /> object passed to the server.
    /// </param>
    public YYT.Server.DataPortalResult Delete(Type objectType, object criteria, YYT.Server.DataPortalContext context)
    {
      return CreateDesignTimeObject(objectType, criteria, context);
    }

    private YYT.Server.DataPortalResult CreateDesignTimeObject(Type objectType, object criteria, YYT.Server.DataPortalContext context)
    {
      var obj = Activator.CreateInstance(objectType, true);
      object returnValue = null;
      returnValue = MethodCaller.CallMethodIfImplemented(obj, "DesignTime_Create");
      return new YYT.Server.DataPortalResult(returnValue);
    }

    #endregion
  }
}
