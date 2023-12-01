using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListBlock : MonoBehaviour
{
    public GameObject content;
    public List<Bloque> blocks;


    public void GetListBlockContent()
    {
        // Aseg�rate de limpiar la lista antes de empezar a agregar elementos
        blocks.Clear();

        // Recorrer cada hijo del objeto 'content'
        foreach (Transform childTransform in content.transform)
        {
            // Obtener el componente Bloque del hijo
            Bloque bloque = childTransform.GetComponent<Bloque>();

            // Comprobar si el hijo tiene el componente Bloque
            if (bloque != null)
            {
                // Agregar el componente Bloque a la lista
                blocks.Add(bloque);
            }
        }

        string primerValorXML = blocks.Count > 0 ? blocks[0].valorXML : "";

        // Llamar a WriteBlocksToXml con el valor de valorXML
        WriteBlocksToXml(primerValorXML);
    }


        public void WriteBlocksToXml(string valorXML)
    {
        // Crear un nuevo documento XML
        XmlDocument xmlDoc = new XmlDocument();

        // Crear el elemento raíz del documento
        XmlElement rootElement = xmlDoc.CreateElement("Blocks");
        xmlDoc.AppendChild(rootElement);

        // Iterar sobre la lista de bloques
        foreach (Bloque bloque in blocks)
        {
            // Crear un nuevo elemento para cada bloque
            XmlElement blockElement = xmlDoc.CreateElement("Block");

            // Añadir el valorXML como atributo al elemento del bloque
            blockElement.SetAttribute("valorXML", valorXML);

            // Añadir el elemento del bloque al elemento raíz
            rootElement.AppendChild(blockElement);
        }

        // Guardar el documento XML en un archivo
        xmlDoc.Save("ruta/del/archivo.xml");
    }
}
