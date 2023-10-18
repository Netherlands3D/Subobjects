

using System.Collections.Generic;
using UnityEngine;

namespace Netherlands3D.subobject
{
    public static class Interaction
    {
        static List<Color> vertexcolors;
        static List<ObjectMapping> mappings;

        internal static void CheckIn(ObjectMapping mapping)
        {
            if (mappings == null)
            {
                mappings = new List<ObjectMapping>();
                
            }
            mappings.Add(mapping);
            ApplyColors(GeometryColorizer.PrioritizedColors,mapping);

        }
        internal static void CheckOut(ObjectMapping mapping)
        {
            if (mappings.Contains(mapping))
            {
                mappings.Remove(mapping);

            }
        }

        internal static void ApplyColorsToAll(Dictionary<string, Color> colorMap)
        {
            Debug.Log("start coloring all");
            if (mappings==null)
            {
                return;
            }
            
            for (int i = 0; i < mappings.Count; i++)
            {
                ApplyColors(colorMap, mappings[i]);
            }
        }

        private static void ApplyColors(Dictionary<string, Color> colorMap, ObjectMapping mapping)
        {
            Debug.Log("coloring");

            if (vertexcolors == null)
            {
                vertexcolors = new List<Color>();
            }
            Color noOverrideColor = new Color(0, 0, 1, 0);
            GameObject gameobject = mapping.gameObject;
                //check if gameobject still exists
                if (gameobject == null)
                {
                return;
                }
                //check if mesh still exists
                Mesh mesh = gameobject.GetComponent<MeshFilter>().sharedMesh;
                if (mesh == null)
                {
                return;
                }
                // remove the old coloring
                mesh.colors = null;

                //setup a colorArray

                
            if (vertexcolors.Capacity<mesh.vertexCount)
            {
                vertexcolors.Capacity = mesh.vertexCount;
            }

                bool colorsApplied = false;
                for (int i = 0; i < mapping.items.Count; i++)
                {
                    //Determine the color
                    string objectID = mapping.items[i].objectID;
                    Color color;
                    if (colorMap.ContainsKey(objectID))
                    {
                        color = colorMap[objectID];
                        colorsApplied = true;
                    }
                    else
                    {
                        color = noOverrideColor;
                    }

                    //Apply the color to the ColorArray
                    int firstVertex = mapping.items[i].firstVertex;
                    int vertexcount = mapping.items[i].verticesLength;
                    int endVertex = firstVertex + vertexcount;

                    for (int j = 0; j < vertexcount; j++)
                    {
                        vertexcolors.Add(color);
                    }



                }
                //apply the colorArray to the mesh;
                if (colorsApplied)
                {
                mesh.SetColors(vertexcolors);
                }
            vertexcolors.Clear();


            }


    }



}