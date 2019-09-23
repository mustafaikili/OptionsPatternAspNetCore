using System;

namespace OptionsPatternAspNetCore.Models
{
    public class ElasticSearchConfig
    {
        public Uri[] Nodes { get; set; }
        public int RequestTimeoutMs { get; set; }
    }
}