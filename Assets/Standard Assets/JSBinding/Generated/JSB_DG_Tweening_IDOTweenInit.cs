﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using DG.Tweening;

using jsval = JSApi.jsval;

public class JSB_DG_Tweening_IDOTweenInit
{

////////////////////// IDOTweenInit ///////////////////////////////////////
// constructors

// fields

// properties

// methods

static bool IDOTweenInit_SetCapacity__Int32__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((DG.Tweening.IDOTweenInit)vc.csObj).SetCapacity(arg0, arg1));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(DG.Tweening.IDOTweenInit);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(IDOTweenInit_SetCapacity__Int32__Int32, "SetCapacity"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}