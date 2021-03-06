﻿using ProjectRimFactory.Storage.Editables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace ProjectRimFactory.Storage
{
    public class Building_Crate : Building_MassStorageUnit
    {
        public override bool CanStoreMoreItems => Position.GetThingList(Map).Count(t => t.def.category == ThingCategory.Item) < (Extension.limit - def.Size.Area + 1);
        public DefModExtension_Crate Extension => def.GetModExtension<DefModExtension_Crate>();
        public override string GetITabString()
        {
            return "PRFItemsTabLabel_Crate".Translate(StoredItemsCount, Extension.limit);
        }
    }
}
