using System.Linq;
using UnityEditor;

namespace Kogane
{
	public static class AssetDatabaseUtils
	{
		public static T FindAsset<T>() where T : UnityEngine.Object
		{
			var guids = AssetDatabase.FindAssets( $"t:{typeof( T ).Name}" );
			var guid  = guids.FirstOrDefault();
			var path  = AssetDatabase.GUIDToAssetPath( guid );
			var asset = AssetDatabase.LoadAssetAtPath<T>( path );

			return asset;
		}

		public static T[] FindAssets<T>() where T : UnityEngine.Object
		{
			return AssetDatabase
					.FindAssets( $"t:{typeof( T ).Name}" )
					.Select( c => AssetDatabase.GUIDToAssetPath( c ) )
					.Select( c => AssetDatabase.LoadAssetAtPath<T>( c ) )
					.ToArray()
				;
		}
	}
}