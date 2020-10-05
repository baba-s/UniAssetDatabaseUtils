# UniAssetDatabaseUtils

AssetDatabase 型に関係する汎用的な関数を管理するクラス

## 使用例

### 通常

```cs
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Example : ScriptableObject
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        // Unity プロジェクトに存在する Example アセットを取得する
        {
            var guids   = AssetDatabase.FindAssets( $"t:{nameof( Example )}" );
            var guid    = guids.FirstOrDefault();
            var path    = AssetDatabase.GUIDToAssetPath( guid );
            var example = AssetDatabase.LoadAssetAtPath<Example>( path );
        }

        // Unity プロジェクトに存在するすべての Example アセットを取得する
        {
            var examples = AssetDatabase
                    .FindAssets( $"t:{nameof( Example )}" )
                    .Select( c => AssetDatabase.GUIDToAssetPath( c ) )
                    .Select( c => AssetDatabase.LoadAssetAtPath<Example>( c ) )
                    .ToArray()
                ;
        }
    }
}
```

### AssetDatabaseUtils

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
