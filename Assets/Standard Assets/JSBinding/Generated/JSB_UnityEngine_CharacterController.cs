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

public class JSB_UnityEngine_CharacterController
{

////////////////////// CharacterController ///////////////////////////////////////
// constructors

static bool CharacterController_CharacterController1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.CharacterController());
    }

    return true;
}

// fields

// properties
static void CharacterController_isGrounded(JSVCall vc)
{
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.isGrounded;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void CharacterController_velocity(JSVCall vc)
{
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.velocity;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
}
static void CharacterController_collisionFlags(JSVCall vc)
{
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.collisionFlags;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void CharacterController_radius(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.radius;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        _this.radius = arg0;
    }
}
static void CharacterController_height(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.height;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        _this.height = arg0;
    }
}
static void CharacterController_center(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.center;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        _this.center = arg0;
    }
}
static void CharacterController_slopeLimit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.slopeLimit;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        _this.slopeLimit = arg0;
    }
}
static void CharacterController_stepOffset(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.stepOffset;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        _this.stepOffset = arg0;
    }
}
static void CharacterController_detectCollisions(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        var result = _this.detectCollisions;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.CharacterController _this = (UnityEngine.CharacterController)vc.csObj;
        _this.detectCollisions = arg0;
    }
}

// methods

static bool CharacterController_Move__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)((UnityEngine.CharacterController)vc.csObj).Move(arg0));
    }

    return true;
}

static bool CharacterController_SimpleMove__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.CharacterController)vc.csObj).SimpleMove(arg0)));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.CharacterController);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        CharacterController_isGrounded,
        CharacterController_velocity,
        CharacterController_collisionFlags,
        CharacterController_radius,
        CharacterController_height,
        CharacterController_center,
        CharacterController_slopeLimit,
        CharacterController_stepOffset,
        CharacterController_detectCollisions,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CharacterController_CharacterController1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(CharacterController_Move__Vector3, "Move"),
        new JSMgr.MethodCallBackInfo(CharacterController_SimpleMove__Vector3, "SimpleMove"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
