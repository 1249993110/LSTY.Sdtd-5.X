using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LSTY.Sdtd.PatronsMod.MapRendering;
using Nancy;

namespace LSTY.Sdtd.PatronsMod.WebApi.Modules
{
    public class MapModule : NancyModule
    {
        private static MapTileCache _mapTileCache = MapRendering.MapRender.GetTileCache();

        public MapModule() : base("/map")
        {
            Get("/{z}/{x}/{y}", _ =>
            {
                string fileName = MapRendering.Constants.MapDirectory + Request.Path.Substring(4) + ".png";

                MemoryStream memoryStream = new MemoryStream(_mapTileCache.GetFileContent(fileName));
                memoryStream.Seek(0, SeekOrigin.Begin);

                return Response.FromStream(memoryStream, "image/png");
            }, null, "map");
        }
    }
}
