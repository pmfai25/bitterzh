using System;

namespace YYT
{
  /// <summary>
  /// Marks a field to indicate that the value should not 
  /// be copied as part of the undo process.
  /// </summary>
  /// <remarks>
  /// Marking a variable with this attribute will cause the n-level
  /// undo process to ignore that variable's value. The value will
  /// not be included in a snapshot when BeginEdit is called, nor
  /// will it be restored when CancelEdit is called.
  /// </remarks>
  [AttributeUsage(AttributeTargets.Field)]
  public sealed class NotUndoableAttribute : Attribute
  {

  }
}