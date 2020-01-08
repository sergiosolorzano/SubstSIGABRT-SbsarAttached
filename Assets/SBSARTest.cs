using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SBSARTest : MonoBehaviour
{
    public Substance.Game.SubstanceGraph m_SubsGraphGO;
    List<Texture2D> m_listSubstTextures;
    public Material objMat;

    // Start is called before the first frame update
    void Start()
    {
            m_listSubstTextures = m_SubsGraphGO.GetGeneratedTextures();
            int i = 0;
            foreach (var tex in m_listSubstTextures)
            {
                string thisTex = tex.name.Substring(tex.name.LastIndexOf('-') + 2);
                Debug.Log("ThisTex CUT " + thisTex);
                Debug.Log("TEX " + tex.name);
                switch (thisTex)
                {
                    case "baseColor":
                        Debug.Log("Assigning BaseColor");
                        objMat.SetTexture("_BaseMap", tex);
                        break;
                    case "normal":
                        Debug.Log("Assigning normal");
                        objMat.SetTexture("_BumpMap", tex);
                        break;
                    case "metallic":
                        Debug.Log("Assigning metallic");
                        objMat.SetTexture("_MetallicGlossMap", tex);
                        break;
                    case "ambientOcclusion":
                        Debug.Log("Assigning AO");
                        objMat.SetTexture("_OcclusionMap", tex);
                        break;
                    default:
                        break;
                }
            }
    }
}
