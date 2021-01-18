using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdminClientDAC
{
    public class ConnDB
    {
        protected static string ConnectionDBs
        {
            get
            {
                string strConn = string.Empty;
                XmlDocument configXml = new XmlDocument();
                string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/DB_XML.xml";
                configXml.Load(path);

                XmlNodeList addNodes = configXml.SelectNodes("configuration/settings/add");

                foreach (XmlNode node in addNodes)
                {
                    if (node.Attributes["key"].InnerText == "MyDB")
                    {
                        strConn = (node.ChildNodes[0]).InnerText;
                        break;
                    }
                }

                return strConn;
            }
        }
    }
}
