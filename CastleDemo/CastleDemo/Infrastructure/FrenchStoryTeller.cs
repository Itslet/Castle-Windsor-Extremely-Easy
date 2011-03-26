using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CastleDemo.Infrastructure
{
    public class FrenchStoryTeller : IStoryTeller
    {

        public string GoodMorning()
        {
            return "bonne matin";
        }
    }
}