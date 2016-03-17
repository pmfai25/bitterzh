﻿using System;
using System.Security.Principal;
using YYT.Serialization;
using System.Collections.Generic;
using YYT.Core.FieldManager;
using System.Runtime.Serialization;
using YYT.Core;

namespace YYT.Security
{
  /// <summary>
  /// Implementation of a .NET identity object representing
  /// an unauthenticated user. Used by the
  /// UnauthenticatedPrincipal class.
  /// </summary>
  [Serializable()]
  public sealed class UnauthenticatedIdentity : YYTIdentity
  {
    /// <summary>
    /// Creates an instance of the object.
    /// </summary>
    public UnauthenticatedIdentity()
    {
      IsAuthenticated = false;
      Name = string.Empty;
      AuthenticationType = string.Empty;
      Roles = new MobileList<string>();
    }
  }
}
