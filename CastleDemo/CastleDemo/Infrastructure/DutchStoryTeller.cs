using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CastleDemo.Infrastructure
{
    public class DutchStoryTeller : IStoryTeller
    {

        public string GoodMorning()
        {
            return "goedemorgen";
        }
    }
}