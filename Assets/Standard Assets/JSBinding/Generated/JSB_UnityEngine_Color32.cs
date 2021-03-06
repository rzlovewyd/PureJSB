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

public class JSB_UnityEngine_Color32
{

////////////////////// Color32 ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool Color32_Color321(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Color32());
    }

    return true;
}

static bool Color32_Color322(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 4)
    {
        System.Byte arg0 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        System.Byte arg1 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        System.Byte arg2 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        System.Byte arg3 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Color32(arg0, arg1, arg2, arg3));
    }

    return true;
}

// fields
static void Color32_r(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        var result = _this.r;
                JSApi.setByte((int)JSApi.SetType.Rval, (System.Byte)(result));
    }
    else {
        System.Byte arg0 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        _this.r = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Color32_g(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        var result = _this.g;
                JSApi.setByte((int)JSApi.SetType.Rval, (System.Byte)(result));
    }
    else {
        System.Byte arg0 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        _this.g = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Color32_b(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        var result = _this.b;
                JSApi.setByte((int)JSApi.SetType.Rval, (System.Byte)(result));
    }
    else {
        System.Byte arg0 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        _this.b = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Color32_a(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        var result = _this.a;
                JSApi.setByte((int)JSApi.SetType.Rval, (System.Byte)(result));
    }
    else {
        System.Byte arg0 = (System.Byte)JSApi.getByte((int)JSApi.GetType.Arg);
        UnityEngine.Color32 _this = (UnityEngine.Color32)vc.csObj;
        _this.a = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// properties

// methods

static bool Color32_ToString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.Color32 argThis = (UnityEngine.Color32)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Color32_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Color32 argThis = (UnityEngine.Color32)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Color32_Lerp__Color32__Color32__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Color32 arg0 = (UnityEngine.Color32)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Color32 arg1 = (UnityEngine.Color32)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Color32.Lerp(arg0, arg1, arg2));
    }

    return true;
}

static bool Color32_op_Implicit__Color32_to_Color(JSVCall vc, int argc)
{
    UnityEngine.Color32 arg0 = (UnityEngine.Color32)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Color)arg0);
    return true;
}

static bool Color32_op_Implicit__Color_to_Color32(JSVCall vc, int argc)
{
    UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSMgr.datax.setObject((int)JSApi.SetType.Rval, (UnityEngine.Color32)arg0);
    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Color32);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        Color32_r,
        Color32_g,
        Color32_b,
        Color32_a,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Color32_Color321, ".ctor"),
        new JSMgr.MethodCallBackInfo(Color32_Color322, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Color32_ToString__String, "ToString"),
        new JSMgr.MethodCallBackInfo(Color32_ToString, "ToString"),
        new JSMgr.MethodCallBackInfo(Color32_Lerp__Color32__Color32__Single, "Lerp"),
        new JSMgr.MethodCallBackInfo(Color32_op_Implicit__Color32_to_Color, "op_Implicit"),
        new JSMgr.MethodCallBackInfo(Color32_op_Implicit__Color_to_Color32, "op_Implicit"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
