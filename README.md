# UniAssetDatabaseUtils

AssetDatabase 型に関係する汎用的な関数を管理するクラス

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEngine;

public class Example : ScriptableObject
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // Unity プロジェクトに存在する Example アセットを取得する
        var example = AssetDatabaseUtils.FindAsset<Example>();

        // Unity プロジェクトに存在するすべての Example アセットを取得する
        var examples = AssetDatabaseUtils.FindAssets<Example>();
    }
}
```
