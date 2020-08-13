using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleManager : MonoBehaviour
{
    private static Dictionary<string, AssetBundle> _assetBundles;
    public static Dictionary<string, AssetBundle> AssetBundles
    {
        get
        {
            if(_assetBundles == null)
            {
                _assetBundles = new Dictionary<string, AssetBundle>();
            }

            return _assetBundles;
        }
    }

    public static AssetBundle Load(string path)
    {
        if (AssetBundles.ContainsKey(path))
        {
            return AssetBundles[path];
        }
        AssetBundle assetBundle = AssetBundle.LoadFromFile(path);
        AssetBundles.Add(path, assetBundle);

        return assetBundle;
    }
}
