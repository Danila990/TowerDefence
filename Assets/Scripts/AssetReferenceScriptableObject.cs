﻿using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TD
{
    [Serializable]
    public class AssetReferenceScriptableObject : AssetReferenceT<ScriptableObject>
    {
        public AssetReferenceScriptableObject(string guid) : base(guid)
        {
        }
    }
}