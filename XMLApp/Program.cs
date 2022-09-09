using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLApp
{
    class Program
    {
        static void Main(string[] args)  // This is where the program starts
        {

            // CreateXMLFile();   // Call the XML Method
            AddRecordToXML();    // Call the AddRecordToXML Method     
            Console.ReadLine();  // This will pause the screen
        }

        const string xmlFile = @"C:\dbass\source\repos\XMLApp\movies.xml";  // Make a varible where the xmlFile location will be

        //Method to Create XML Method

        static void CreateXMLFile()
        {
            // In order to create an XML File, we are going to need an XML Document

            XmlDocument XMLdoc = new XmlDocument();  //Creates the new object instance called XMLdoc in Memory
            XmlElement root = XMLdoc.CreateElement("MOVIES");     // Each XML File will contain 'Elements  = <MOVIES> and inside the Elements are data called 'attributes' closing Element
            XMLdoc.AppendChild(root);  // This adds to the document the root element
            XMLdoc.Save(xmlFile); // Where I can save my screen, use '@'to make it a literal string, meaning verbatium
            System.Console.WriteLine(XMLdoc.InnerXml);  // This will display our XML on the screen


        }
        // Method to AddRecord to our XML File
        static void AddRecordToXML()
        {
            XmlDocument XmlDoc = new XmlDocument(); //Creates the new object instance called XMLdoc in Memory
            XmlDoc.Load(xmlFile);
            XmlNode root = XmlDoc.SelectSingleNode("MOVIES");
            XmlElement movie = XmlDoc.CreateElement("MOVIE");  // Child element of the 'Root Element', <MOVIES>
            root.AppendChild(movie);   // This adds to the end of the Root Element <MOVIE>

            XmlAttribute id = XmlDoc.CreateAttribute("id"); // Inside the <MOVIE> 'Element' is data called 'attributes'
            movie.Attributes.Append(id);  // This will 'add' the 'id' to the 'Element' <MOVIE>
            id.Value = XmlDoc.SelectNodes("MOVIES/MOVIE").Count.ToString();  // Automatically counts and adds value to 'id' element, dynamic instead of static

            XmlElement title = XmlDoc.CreateElement("TITLE");
            title.InnerText = "Shawshank Redemption";
            movie.AppendChild(title);
            XmlDoc.Save(xmlFile); // Where I can save my screen, use '@'to make it a literal string, meaning verbatium
            Console.WriteLine(XmlDoc.InnerXml);
        }
    }
}
