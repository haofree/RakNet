/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class SortQuery : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SortQuery(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SortQuery obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SortQuery() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_SortQuery(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public uint columnIndex {
    set {
      RakNetPINVOKE.SortQuery_columnIndex_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.SortQuery_columnIndex_get(swigCPtr);
      return ret;
    } 
  }

  public Table.SortQueryType operation {
    set {
      RakNetPINVOKE.SortQuery_operation_set(swigCPtr, (int)value);
    } 
    get {
      Table.SortQueryType ret = (Table.SortQueryType)RakNetPINVOKE.SortQuery_operation_get(swigCPtr);
      return ret;
    } 
  }

  public SortQuery() : this(RakNetPINVOKE.new_SortQuery(), true) {
  }

}

}
