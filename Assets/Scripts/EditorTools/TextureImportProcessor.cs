using UnityEditor;
using UnityEditor.Presets;
using UnityEngine;

public class TextureImportProcessor : AssetPostprocessor
{
    void OnPreprocessTexture()
    {
        var textureImporter = (TextureImporter)assetImporter;
        var preset = AssetDatabase.LoadAssetAtPath<Preset>("Assets/Textures/DefaultTextureImport.preset");

        if (preset == null)
        {
            Debug.LogWarning("Preset not found.");
            return;
        }
        
        if (preset.CanBeAppliedTo(textureImporter))
        {
            preset.ApplyTo(textureImporter);
        }
    }
}
