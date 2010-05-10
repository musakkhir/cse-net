﻿namespace Google.CustomSearch
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class FacetCollection : Collection<Facet>
    {
        public void Add(string label, string anchor)
        {
            base.Add(new Facet(label, anchor));
        }

        //public void Add(Facet facet)
        //{
        //    this.Add(facet.Label, facet.AnchorText);
        //}

        //public new string this[string label]
        //{
        //    get
        //    {
        //        return base[label];
        //    }
        //}

        public Facet this[string label]
        {
            get
            {
                return this.FirstOrDefault(f => f.Label == label);
            }
        }
    }
}
