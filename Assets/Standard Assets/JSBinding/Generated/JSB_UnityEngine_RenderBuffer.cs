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

using jsval = JSApi.jsval;

public class JSB_UnityEngine_RenderBuffer
{

////////////////////// RenderBuffer ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool RenderBuffer_RenderBuffer1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.RenderBuffer());
    }

    return true;
}

// fields

// properties

// methods

static bool RenderBuffer_GetNativeRenderBufferPtr(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.RenderBuffer argThis = (UnityEngine.RenderBuffer)vc.csObj;                JSApi.setIntPtr((int)JSApi.SetType.Rval, (System.IntPtr)(argThis.GetNativeRenderBufferPtr()));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.RenderBuffer);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(RenderBuffer_RenderBuffer1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(RenderBuffer_GetNativeRenderBufferPtr, "GetNativeRenderBufferPtr"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
