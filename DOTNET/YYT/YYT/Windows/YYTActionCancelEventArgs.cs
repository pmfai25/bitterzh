﻿using System;
using System.ComponentModel;

namespace YYT.Windows
{
  /// <summary>
  /// Event args providing information about
  /// a canceled action.
  /// </summary>
  public class YYTActionCancelEventArgs : CancelEventArgs
  {
    /// <summary>
    /// Creates an instance of the object.
    /// </summary>
    /// <param name="cancel">
    /// Indicates whether a cancel should occur.
    /// </param>
    /// <param name="commandName">
    /// Name of the command.
    /// </param>
    public YYTActionCancelEventArgs(bool cancel, string commandName)
      : base(cancel)
    {
      _commandName = commandName;
    }

    private string _commandName;

    /// <summary>
    /// Gets the name of the command.
    /// </summary>
    public string CommandName
    {
      get { return _commandName; }
    }
  }
}
