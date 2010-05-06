﻿namespace Google.CSE
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    using System.Xml;
    using System.Xml.XPath;

    internal class RespnseParser
    {
        public void Parse(ResultSet results, Stream responseStream)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(responseStream);
            XPathNavigator nav = doc.CreateNavigator();
            XPathNodeIterator iterator = nav.Select("/GSP/RES/R");
            while (iterator.MoveNext())
            {
                results.Add(this.ParseResult(iterator.Current));
            }
        }

        private Result ParseResult(XPathNavigator navigator)
        {
            return new Result()
            {
                Id = int.Parse(navigator.GetAttribute("N", string.Empty)),
                Title = navigator.SelectSingleNode("T").Value,
                Excerpt = navigator.SelectSingleNode("S").Value,
                Uri = new Uri(navigator.SelectSingleNode("U").Value),
                EscapedUrl = navigator.SelectSingleNode("UE").Value
            };
        }
    }
}
