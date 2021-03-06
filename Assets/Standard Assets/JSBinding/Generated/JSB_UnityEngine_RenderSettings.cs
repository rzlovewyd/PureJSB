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

public class JSB_UnityEngine_RenderSettings
{

////////////////////// RenderSettings ///////////////////////////////////////
// constructors

static bool RenderSettings_RenderSettings1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.RenderSettings());
    }

    return true;
}

// fields

// properties
static void RenderSettings_fog(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fog;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fog = arg0;
    }
}
static void RenderSettings_fogMode(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogMode;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.FogMode arg0 = (UnityEngine.FogMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogMode = arg0;
    }
}
static void RenderSettings_fogColor(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogColor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogColor = arg0;
    }
}
static void RenderSettings_fogDensity(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogDensity;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogDensity = arg0;
    }
}
static void RenderSettings_fogStartDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogStartDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogStartDistance = arg0;
    }
}
static void RenderSettings_fogEndDistance(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.fogEndDistance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.fogEndDistance = arg0;
    }
}
static void RenderSettings_ambientLight(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.ambientLight;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Color arg0 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.ambientLight = arg0;
    }
}
static void RenderSettings_haloStrength(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.haloStrength;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.haloStrength = arg0;
    }
}
static void RenderSettings_flareStrength(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.flareStrength;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.flareStrength = arg0;
    }
}
static void RenderSettings_flareFadeSpeed(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.flareFadeSpeed;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.flareFadeSpeed = arg0;
    }
}
static void RenderSettings_skybox(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.RenderSettings.skybox;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Material arg0 = (UnityEngine.Material)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.RenderSettings.skybox = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.RenderSettings);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        RenderSettings_fog,
        RenderSettings_fogMode,
        RenderSettings_fogColor,
        RenderSettings_fogDensity,
        RenderSettings_fogStartDistance,
        RenderSettings_fogEndDistance,
        RenderSettings_ambientLight,
        RenderSettings_haloStrength,
        RenderSettings_flareStrength,
        RenderSettings_flareFadeSpeed,
        RenderSettings_skybox,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(RenderSettings_RenderSettings1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
