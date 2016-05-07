using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;


namespace GameDevBestPractices
{
    public class XmlManager <T>
    {
        public Type Type;
        public XmlManager() 
        {
            Type = typeof(T);
        }
        public T Load(string path) 
        {
            T destinationObject;

            using (StreamReader streamReader = new StreamReader(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(Type);
                destinationObject = (T)xmlSerializer.Deserialize(streamReader);
            }
            
            return destinationObject;
        }


    }
}
