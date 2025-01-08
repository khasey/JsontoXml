using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using SimpleJSON;

namespace JsonToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Outils.Utils.Banner();

            // Vérifier que l'utilisateur a fourni un chemin de fichier JSON
            if (args.Length != 1)
            {
                Outils.Utils.TextCol("\nUsage : [executable] {nom ou chemin du fichier Json à convertir}\n", ConsoleColor.Red);
                return;
            }

            string jsonFilePath = args[0];

            if (!File.Exists(jsonFilePath))
            {
                Outils.Utils.TextCol("Le fichier spécifié " + jsonFilePath + " n'existe pas.", ConsoleColor.Red);
                return;
            }

            try
            {

                string jsonContent = File.ReadAllText(jsonFilePath);
                var jsonObject = JSON.Parse(jsonContent);

                XmlDocument xmlDocument = new XmlDocument();
                XmlElement rootElement = xmlDocument.CreateElement("root");
                xmlDocument.AppendChild(rootElement);

                ParseJsonToXml(jsonObject, rootElement, xmlDocument);

                string xmlFilePath = Path.ChangeExtension(jsonFilePath, ".xml");
                xmlDocument.Save(xmlFilePath);
                Outils.Utils.TextCol("Conversion réussie. Fichier XML enregistré à : " + xmlFilePath + "\n", ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                Outils.Utils.TextCol("Erreur lors de la conversion : " + ex.Message, ConsoleColor.Red);
            }
        }
        //var jsonObject = (Dictionary<string, object>)jsonToken;
        static void ParseJsonToXml(JSONNode jsonNode, XmlElement parentElement, XmlDocument xmlDocument)
        {
            if (jsonNode is JSONArray)
            {
                var jsonArray = jsonNode.AsArray;
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    // Créer un élément <item> pour chaque élément du tableau
                    XmlElement element = xmlDocument.CreateElement(parentElement.Name);
                    parentElement.AppendChild(element);
                    ParseJsonToXml(jsonArray[i], element, xmlDocument);
                }
            }
            else if (jsonNode is JSONObject)
            {
                var jsonObject = jsonNode.AsObject;
                var enumerator = jsonObject.Keys.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    string key = enumerator.Current;
                    XmlElement element = xmlDocument.CreateElement(key);
                    parentElement.AppendChild(element);
                    ParseJsonToXml(jsonObject[key], element, xmlDocument);
                }
            }
            else
            {
                parentElement.InnerText = jsonNode.Value;
            }
        }
    }
}