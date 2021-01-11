using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace PrototipoDiplomaDigital
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string rootPath = p.GetApplicationRoot();

            //Transformando xml diploma em um objeto C# do tipo diploma (desserialização)
            var diplomaObject = p.DeserializeObject(rootPath + "/diploma_teste.xml");

            //Tranformando o objeto C# do tipo diploma para xml diploma (serialização)
            p.SerializeObject(rootPath +  "/diploma_gerado.xml", diplomaObject);

            //Transformando o objeto diploma em string
            var xmlstring = p.SerializeToString(diplomaObject);
            Console.WriteLine(xmlstring);

            //Transformando a string do xml do diploma em um objeto
            var diplomaFromString = p.XmlStringToObject(xmlstring);
            
            //Transformando o objeto criado a partir de string para xml (serialização)
            p.SerializeObject(rootPath + "/diploma_gerado_de_string.xml", diplomaFromString);
        }

        private string GetApplicationRoot()
        {
            var exePath = Path.GetDirectoryName(System.Reflection
                              .Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return appRoot;
        }

        private TDiploma DeserializeObject(string filename)
        {
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer =
            new XmlSerializer(typeof(TDiploma));

            // Declare an object variable of the type to be deserialized.
            TDiploma diploma;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                diploma = (TDiploma)serializer.Deserialize(reader);
            }

            return diploma;
        }

        private void SerializeObject(string filename, TDiploma diploma)
        {
            FileStream stream = new FileStream(filename, FileMode.Create);
            XmlSerializer x = new XmlSerializer(typeof(TDiploma));
            x.Serialize(stream, diploma);
        }

        private string SerializeToString(TDiploma diploma)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerializer x = new XmlSerializer(typeof(TDiploma));
            x.Serialize(stream, diploma);

            string diplomaString = "";
            using (stream)
            {
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    diplomaString = reader.ReadToEnd();
                }
            }
            return diplomaString;
        }

        private TDiploma XmlStringToObject(string xmlstring)
        {
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer =
            new XmlSerializer(typeof(TDiploma));

            // Declare an object variable of the type to be deserialized.
            TDiploma diploma;

            using (StringReader reader = new StringReader(xmlstring))
            {
                // Call the Deserialize method to restore the object's state.
                diploma = (TDiploma)serializer.Deserialize(reader);
            }

            return diploma;
        }
    }
}
