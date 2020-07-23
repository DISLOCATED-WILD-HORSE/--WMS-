using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HSC_Update
{
    public class ConfigHelper
    {
        // 获取配置文件对象
        public static XmlDocument XmlConfig()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
            XmlDocument m_xmlDoc = new XmlDocument();
            if (File.Exists(Path.Combine(path, Const.FileName)))
            {
                m_xmlDoc.Load(Path.Combine(path, Const.FileName));
            }
            return m_xmlDoc;
        }
        /// <summary>
        /// 解析XML配置文件信息
        /// </summary>
        /// <param name="versionDir"></param>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static ConfigModel GetConfigContext(XmlDocument xmlDoc)
        {
            ConfigModel config = new ConfigModel();
            if (xmlDoc != null)
            {
                config.Version = GetContextNode(Const.Version, xmlDoc);
                if (!string.IsNullOrEmpty(Const.Message))
                {
                    config.Msg = GetContextNode(Const.Message, xmlDoc);
                }
                if (!string.IsNullOrEmpty(Const.Program))
                {
                    config.Program = GetContextNode(Const.Program, xmlDoc);
                }
                if (!string.IsNullOrEmpty(Const.IsSilentUpgrade))
                {
                    config.IsSilentUpgrade = GetContextNode(Const.IsSilentUpgrade, xmlDoc).Equals("true") ? true : false;
                }
                XmlNodeList xns = xmlDoc.SelectNodes(string.Format("{0}/{1}/file", "configuration", Const.Files));
                if (xns != null)
                {
                    List<string> files = new List<string>();
                    foreach (XmlNode xn in xns)
                    {
                        files.Add(xn.InnerText);
                    }
                    config.Files = files.ToArray();
                }
            }
            return config;
        }
        /// <summary>
        /// 获取XML配置文件节点信息
        /// </summary>
        /// <param name="contextID"></param>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static string GetContextNode(string contextID, XmlDocument xmlDoc)
        {
            if (xmlDoc != null)
            {
                XmlNode xn = xmlDoc.SelectSingleNode(string.Format("{0}/{1}", "configuration", contextID));
                if (xn != null)
                {
                    return xn.InnerText;
                }
            }
            return string.Empty;

        }

        /// <summary>
        /// 获取服务端的配置
        /// </summary>
        /// <param name="versionDir"></param>
        /// <returns></returns>
        public static ConfigModel GetServerConfig()
        {
            try
            {
                string url = GetContextNode("serviceUrl", XmlConfig()) + Const.FileName;

                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //发送请求并获取相应回应数据
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string str = reader.ReadToEnd();
                reader.Close();
                XmlDocument xdoc = new XmlDocument();
                xdoc.LoadXml(str);
                ConfigModel config = GetConfigContext(xdoc);
                return config;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// 获取客户端配置文件
        /// </summary>
        /// <returns></returns>
        public static ConfigModel GetClientConfig()
        {
            try
            {
                ConfigModel config = GetConfigContext(XmlConfig());
                return config;
            }
            catch (System.Exception ex)
            {
                return null;
            }
        }
    }
}
