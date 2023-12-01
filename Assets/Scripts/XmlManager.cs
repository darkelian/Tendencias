using UnityEngine;
using System;
using System.Xml;
using System.Collections.Generic;

public class XmlManager : MonoBehaviour
{
    public void LeerArchivo()
    {
        // Nombre del archivo XML en la carpeta Resources (sin la extensión .xml)
        string nombreArchivo = "codigo";

        try
        {
            // Cargar el archivo XML como un TextAsset
            TextAsset textAsset = Resources.Load<TextAsset>(nombreArchivo);
            if (textAsset == null)
            {
                Debug.LogError("Archivo no encontrado. "+nombreArchivo);
                return;
            }

            // Crear un objeto XmlDocument
            XmlDocument xmlDoc = new XmlDocument();

            // Cargar el contenido del TextAsset en el XmlDocument
            xmlDoc.LoadXml(textAsset.text);

            // Crear una lista para almacenar los nombres de las etiquetas
            List<string> nombresEtiquetas = new List<string>();

            // Recorrer todas las etiquetas en el documento XML
            foreach (XmlNode nodo in xmlDoc.DocumentElement.ChildNodes)
            {
                // Agregar el nombre de la etiqueta a la lista
                nombresEtiquetas.Add(nodo.Name);
            }

            // Mostrar los nombres de las etiquetas en la consola
            Debug.Log("Nombres de las etiquetas en el archivo XML:");
            foreach (string nombreEtiqueta in nombresEtiquetas)
            {
                Debug.Log(nombreEtiqueta);
            }
        }
        catch (Exception ex)
        {
            Debug.LogError($"Error al leer el archivo XML: {ex.Message}");
        }
    }
}
