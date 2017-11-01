using System;
using System.Collections.Generic;
using System.Text;

namespace Sunny.Application.Feature
{
    public struct FeatureReference<TFeature>
    {
        private TFeature _feature;

        public FeatureReference(TFeature feature)
        {
            _feature = feature;

        }
        public TFeature Fetch(IFeatureCollection features)
        {
            TFeature feature = features.Get<TFeature>();
            if (feature == null)
                feature = _feature;
            return feature;
        }

       
    }
}
