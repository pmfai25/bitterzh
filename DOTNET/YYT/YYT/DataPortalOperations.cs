﻿using System.ComponentModel;

namespace YYT
{
  /// <summary>
  /// List of data portal operations.
  /// </summary>
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  public enum DataPortalOperations : int
  {
    /// <summary>
    /// Create operation.
    /// </summary>
    Create,
    /// <summary>
    /// Fetch operation.
    /// </summary>
    Fetch,
    /// <summary>
    /// Update operation (includes
    /// insert, update and delete self).
    /// </summary>
    Update,
    /// <summary>
    /// Delete operation.
    /// </summary>
    Delete,
    /// <summary>
    /// Execute operation.
    /// </summary>
    Execute
  }
}