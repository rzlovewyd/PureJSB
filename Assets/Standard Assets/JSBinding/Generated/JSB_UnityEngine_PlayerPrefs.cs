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

public class JSB_UnityEngine_PlayerPrefs
{

////////////////////// PlayerPrefs ///////////////////////////////////////
// constructors

static bool PlayerPrefs_PlayerPrefs1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.PlayerPrefs());
    }

    return true;
}

// fields

// properties

// methods

static bool PlayerPrefs_DeleteAll(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.PlayerPrefs.DeleteAll();
    }

    return true;
}

static bool PlayerPrefs_DeleteKey__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.PlayerPrefs.DeleteKey(arg0);
    }

    return true;
}

static bool PlayerPrefs_GetFloat__String__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.PlayerPrefs.GetFloat(arg0, arg1)));
    }

    return true;
}

static bool PlayerPrefs_GetFloat__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.PlayerPrefs.GetFloat(arg0)));
    }

    return true;
}

static bool PlayerPrefs_GetInt__String__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.PlayerPrefs.GetInt(arg0, arg1)));
    }

    return true;
}

static bool PlayerPrefs_GetInt__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.PlayerPrefs.GetInt(arg0)));
    }

    return true;
}

static bool PlayerPrefs_GetString__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.PlayerPrefs.GetString(arg0, arg1));
    }

    return true;
}

static bool PlayerPrefs_GetString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.PlayerPrefs.GetString(arg0));
    }

    return true;
}

static bool PlayerPrefs_HasKey__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.PlayerPrefs.HasKey(arg0)));
    }

    return true;
}

static bool PlayerPrefs_Save(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.PlayerPrefs.Save();
    }

    return true;
}

static bool PlayerPrefs_SetFloat__String__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.PlayerPrefs.SetFloat(arg0, arg1);
    }

    return true;
}

static bool PlayerPrefs_SetInt__String__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.PlayerPrefs.SetInt(arg0, arg1);
    }

    return true;
}

static bool PlayerPrefs_SetString__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.PlayerPrefs.SetString(arg0, arg1);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.PlayerPrefs);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(PlayerPrefs_PlayerPrefs1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(PlayerPrefs_DeleteAll, "DeleteAll"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_DeleteKey__String, "DeleteKey"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_GetFloat__String__Single, "GetFloat"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_GetFloat__String, "GetFloat"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_GetInt__String__Int32, "GetInt"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_GetInt__String, "GetInt"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_GetString__String__String, "GetString"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_GetString__String, "GetString"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_HasKey__String, "HasKey"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_Save, "Save"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_SetFloat__String__Single, "SetFloat"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_SetInt__String__Int32, "SetInt"),
        new JSMgr.MethodCallBackInfo(PlayerPrefs_SetString__String__String, "SetString"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
