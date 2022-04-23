#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateAssetbundles : MonoBehaviour {

    // Use this for initialization
    [MenuItem("Assets/Build/AssetBundles")]
    static void BuildAllAssetBundles()
    {


        BuildPipeline.BuildAssetBundles("Assets/AssetBundles",BuildAssetBundleOptions.None,BuildTarget.Android);
    }
    [MenuItem("Test/ChangeBundleName")]
     static void ChangeBundleName()
     {
         //string assetPath = AssetDatabase.GetAssetPath("Assets/Resources/Prefabs/cube");
         AssetImporter.GetAtPath("Assets/Resources/Prefabs/cube.prefab").SetAssetBundleNameAndVariant("testBundle", "");
     }
}
#endif
