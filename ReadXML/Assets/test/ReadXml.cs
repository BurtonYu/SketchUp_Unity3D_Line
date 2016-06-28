using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using UnityEngine;
using System.Collections;

namespace Assets
{
    class ReadXml
    {
        XmlDocument xmlDoc;
        public int i=0;
        public Vector3[] v1;
        public Vector3[] v2;
        float x = 0, y = 0, z = 0;

        //显示xml数据
        public void gitv()
        {
            xmlDoc = new XmlDocument();
            xmlDoc.Load("shu_bs_q.edges.xml"); //加载xml文件
            XmlNode xn = xmlDoc.SelectSingleNode("edges");
            XmlNodeList xnl = xn.ChildNodes;
            v1 = new Vector3[xnl.Count];
            v2= new Vector3[xnl.Count];
            foreach (XmlNode xnf in xnl)
            {
                XmlNodeList xnl2 = xnf.ChildNodes;
                foreach (XmlNode xnf2 in xnl2)
                {
                    XmlElement xe = (XmlElement)xnf2;
                    x = float.Parse(xe.GetAttribute("x"));
                    y = float.Parse(xe.GetAttribute("y"));
                    z = -float.Parse(xe.GetAttribute("z"));
                    if (xe.Name == "start")
                    {
                        v1[i].Set(x, y, z);
                    }
                    else {
                        v2[i].Set(x, y, z);
                    }

                }             
                i++;
            }
        }


    }
}
