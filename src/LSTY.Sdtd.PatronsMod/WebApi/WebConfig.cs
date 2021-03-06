using IceCoffee.Common.Extensions;
using IceCoffee.Common.Xml;
using System;
using System.Xml;

namespace LSTY.Sdtd.PatronsMod.WebApi
{
    public class WebConfig
    {
        public const string AuthKeyName = "access-token";

        [ConfigNode(XmlNodeType.Attribute)]
        public string AccessToken { get; set; } = Guid.NewGuid().ToString().ToBase64();

        [ConfigNode(XmlNodeType.Attribute)]
        public int WebApiPort { get; set; } = 8888;

        [ConfigNode(XmlNodeType.Attribute)]
        public int WebSocketPort { get; set; } = 8889;

        [ConfigNode(XmlNodeType.Attribute)]
        public bool OpenInDefaultBrowser { get; set; } = true;

        [ConfigNode(XmlNodeType.Attribute)]
        public bool EnableGzip { get; set; } = true;
    }
}
